using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Metapsi
{
    public static class WebServerExtensions
    {
        public static WebApplicationBuilder AddMetapsiWebServices(
           this WebApplicationBuilder builder,
           ApplicationSetup applicationSetup,
           ImplementationGroup ig)
        {
            builder.Services.AddSingleton<RenderersService>();
            builder.Services.AddWindowsService();
            builder.Services.AddSystemd();
            builder.Services.AddMetapsiCommandContext(applicationSetup, ig);

            builder.Services.ConfigureHttpJsonOptions(options =>
            {
                options.SerializerOptions.PropertyNamingPolicy = null;
                options.SerializerOptions.WriteIndented = true;
                options.SerializerOptions.PropertyNameCaseInsensitive = true;
            });

            builder.Host.ConfigureHostOptions(options =>
            {
                options.ShutdownTimeout = TimeSpan.FromSeconds(30);
            });
            return builder;
        }

        public static WebApplication UseMetapsi(this WebApplication webApplication, ApplicationSetup applicationSetup)
        {
            webApplication.UseEmbeddedFiles();
            webApplication.BindStart(applicationSetup);
            webApplication.BindStop(applicationSetup);
            return webApplication;
        }

        public static void BindStop(this WebApplication webApp, ApplicationSetup applicationSetup)
        {
            // Always close web server when shutting down application
            applicationSetup.MapEvent<ApplicationIsShuttingDown>(e =>
            {
                webApp.StopAsync();
            });
        }

        public static void BindStart(this WebApplication webApp, ApplicationSetup applicationSetup)
        {
            applicationSetup.MapEvent<ApplicationRevived>(e =>
            {
                webApp.RunAsync();
            });
        }

        public static void UseEmbeddedFiles(this WebApplication app)
        {
            // Embedded static files
            app.Use(async (context, next) =>
            {
                var handled = false;

                // Try EmbeddedStaticFiles

                if (!string.IsNullOrEmpty(context.Request.Path))
                {
                    var fileName = context.Request.Path.Value.ToLower().Trim('/');

                    var bytes = await StaticFiles.Get(fileName);
                    if (bytes != null)
                    {
                        handled = true;

                        var contentType = GetMimeTypeForFileExtension(fileName);

                        switch (contentType)
                        {
                            case "text/html":
                                {
                                    context.Response.StatusCode = StatusCodes.Status404NotFound;
                                    handled = true;
                                }
                                break;
                            default:
                                {
#if !DEBUG
                                    context.Response.Headers.CacheControl = new[] { "public", $"max-age={TimeSpan.FromDays(100).TotalSeconds}" };
#endif
                                    context.Response.ContentType = contentType;
                                    await context.Response.BodyWriter.WriteAsync(bytes);
                                    handled = true;
                                }
                                break;
                        }
                    }
                }
                if (!handled)
                    await next(context);
            });
        }

        public static string GetMimeTypeForFileExtension(string filePath)
        {
            const string DefaultContentType = "application/octet-stream";

            var provider = new FileExtensionContentTypeProvider();

            if (!provider.TryGetContentType(filePath, out string contentType))
            {
                contentType = DefaultContentType;
            }

            return contentType;
        }
    }

}