using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi
{
    public static class WebServerExtensions
    {
        public static WebApplicationBuilder AddMetapsi(
           this WebApplicationBuilder builder,
           ApplicationSetup applicationSetup,
           ImplementationGroup ig)
        {
            builder.Services.AddHttpContextAccessor();
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

        public static WebApplicationBuilder AddMetapsi(
           this WebApplicationBuilder builder)
        {
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddSingleton<RenderersService>();

            builder.Services.ConfigureHttpJsonOptions(options =>
            {
                options.SerializerOptions.PropertyNamingPolicy = null;
                options.SerializerOptions.WriteIndented = true;
                options.SerializerOptions.PropertyNameCaseInsensitive = true;
            });

            return builder;
        }

        public static WebApplication UseMetapsi(this WebApplication webApplication)
        {
            webApplication.UseEmbeddedFiles();
            webApplication.UseJsModules();
            return webApplication;
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

        public static RouteHandlerBuilder UseEmbeddedFiles(this WebApplication app)
        {
            return app.MapGet("/embedded/{package}/{version}/{*logicalName}", async (HttpContext httpContext, string package, string version, string logicalName) =>
            {
                await new Metapsi.Web.CfHttpContext(httpContext).Response.WriteEmbeddedResource(package, logicalName);
            });
        }

        public static RouteHandlerBuilder UseJsModules(this WebApplication app)
        {
            return app.MapGet("/metapsi-js-module/{*modulePath}",
                async (HttpContext httpContext, string modulePath, JsModuleProvider modules) =>
                {
                    modules.modules.TryGetValue(modulePath, out var moduleRetriever);
                    if (moduleRetriever != null)
                    {
                        try
                        {
                            var module = moduleRetriever();
                            new CfHttpContext(httpContext).Response.SetCacheControlHeader("public,max-age=31536000");
                            await httpContext.WriteJsModule(module);
                            return;
                        }
                        catch (Exception ex)
                        {
                            httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                        }
                    }
                    else
                    {
                        httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                    }
                });
        }

        public static async Task WriteHtmlDocumentResponse(
            this HttpContext httpContext, 
            HtmlDocument document,
            ToHtmlOptions options = null)
        {
            string html = document.ToHtml(options);
            httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
            httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
            await httpContext.Response.WriteAsync(html);
        }

        public static async Task WriteJsModule(this HttpContext httpContext, Metapsi.Syntax.Module module, ToJavaScriptOptions options = null)
        {
            httpContext.Response.ContentType = "text/javascript";
            await httpContext.Response.WriteAsync(module.ToJs(options));
        }
    }
}