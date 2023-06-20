using Metapsi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Build.Tasks.Deployment.ManifestUtilities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PreviewEnvironment
{
    public class PreviewParameters
    {
        public string RendererName { get; set; } = string.Empty;
        public string InputName { get; set; } = string.Empty;
    }

    public static Request<PreviewParameters> GetPreviewParameters { get; set; } = new(nameof(GetPreviewParameters));


    public class State
    {

    }

    public static async Task Start(CommandContext commandContext, State state, List<EmbeddedResource> embeddedResources)
    {
        var app = AddPreviewWebServer(9999, "d:\\qweb\\mes\\Metapsi.Hyperapp");
        app.MapGroup("api").MapGet("GetPreviewParameters", async (HttpContext httpContext) =>
        {
            return await commandContext.Do(GetPreviewParameters);
        });

        app.MapFallback(async (HttpContext httpContext) =>
        {
            var previewParameters = await commandContext.Do(GetPreviewParameters);

            var preview = await commandContext.Do(Backend.PreviewFocusedRenderer);

            preview = preview.Replace("</body>", $"{RefreshScript(previewParameters)} </body>");

            httpContext.Response.ContentType = "text/html";
            await httpContext.Response.WriteAsync(preview);
        });

        var embeddedLogicalNames = embeddedResources.Select(x => x.LogicalName).Distinct();

        foreach (var embeddedResourceName in embeddedLogicalNames)
        {
            app.MapGet(embeddedResourceName, async (HttpContext httpContext) =>
            {
                var firstMatch = embeddedResources.First(x => x.LogicalName == embeddedResourceName);
                var embeddedFileContent = await File.ReadAllBytesAsync(firstMatch.Path);
                httpContext.Response.ContentType = GetMimeTypeForFileExtension(firstMatch.Path);
                await httpContext.Response.BodyWriter.WriteAsync(embeddedFileContent);// .WriteAsync(embeddedFileContent);
            });
        }

        await app.StartAsync();

        Console.WriteLine("Preview ready");
    }

    private static string RefreshScript(PreviewParameters initialParameters)
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine("<script>");

        stringBuilder.AppendLine("window.MetapsiPreviewParameters = " + Metapsi.Serialize.ToJson(initialParameters));

        stringBuilder.AppendLine("function parametersChanged(newParameters) {return window.MetapsiPreviewParameters.RendererName != newParameters.RendererName || window.MetapsiPreviewParameters.InputName != newParameters.InputName}");

        stringBuilder.AppendLine("function tryRefresh() {fetch('/api/GetPreviewParameters').then(r => r.json()).then(r=> {if(parametersChanged(r)) {clearInterval(window.MetapsiRefreshInterval); location.reload();} })}");

        stringBuilder.AppendLine("window.MetapsiRefreshInterval = setInterval(tryRefresh, 1000);");

        stringBuilder.AppendLine("</script>");

        return stringBuilder.ToString();
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

    public static WebApplication AddPreviewWebServer(
            int port = 0,
            string webRootPath = null,
            Action<WebApplicationBuilder> buildServices = null,
            Action<WebApplication> buildApp = null)
    {
        WebApplicationBuilder builder = null;

        //IdentityModelEventSource.ShowPII = true;

        if (string.IsNullOrWhiteSpace(webRootPath))
        {
            builder = WebApplication.CreateBuilder();
        }
        else
        {
            builder = WebApplication.CreateBuilder(new WebApplicationOptions() { WebRootPath = webRootPath });
            //builder = WebApplication.CreateBuilder();
        }

        builder.Services.ConfigureHttpJsonOptions(options =>
        {
            options.SerializerOptions.PropertyNamingPolicy = null;
            options.SerializerOptions.WriteIndented = true;
            options.SerializerOptions.PropertyNameCaseInsensitive = true;
        });

        if (buildServices != null)
            buildServices(builder);

        var app = builder.Build();

        //        // some JS files need path updates
        //        app.Use(async (context, next) =>
        //        {
        //            if (!string.IsNullOrWhiteSpace(context.GetHostedRootPath()) && context.Request.Path.Value.EndsWith(".js"))
        //            {
        //                string fileWebPath = context.Request.Path.Value;
        //                fileWebPath = fileWebPath.Replace(context.GetHostedRootPath() + "/", string.Empty);
        //                var fileSegments = new List<string>();
        //                fileSegments.Add(webRootPath);
        //                fileSegments.AddRange(fileWebPath.Split("/", StringSplitOptions.RemoveEmptyEntries).ToArray());
        //                string filePath = System.IO.Path.Combine(fileSegments.ToArray());
        //                if (!File.Exists(filePath))
        //                {
        //                    context.Response.StatusCode = 404;
        //                    return;
        //                }
        //                var allContent = await System.IO.File.ReadAllTextAsync(filePath);
        //                allContent = allContent.Replace("/static/", context.GetHostedRootPath() + "/static/");
        //                context.Response.ContentType = "text/javascript";
        //                await context.Response.WriteAsync(allContent);
        //                return;
        //            }
        //            // if not a js file served through proxy just move on
        //            await next(context);
        //        });

        //        HashSet<string> staticFileExtensions = new HashSet<string>
        //            {
        //                ".js",
        //                ".css",
        //                ".ico"
        //            };

        //        // Embedded static files
        //        app.Use(async (context, next) =>
        //        {
        //            var handled = false;

        //            if (!string.IsNullOrEmpty(context.Request.Path))
        //            {
        //                var fileName = context.Request.Path.Value.ToLower().Trim('/');
        //                if (references.StaticFiles.ContainsKey(fileName))
        //                {
        //                    var contentType = GetMimeTypeForFileExtension(fileName);

        //                    switch (contentType)
        //                    {
        //                        case "text/html":
        //                            {
        //                                context.Response.StatusCode = StatusCodes.Status404NotFound;
        //                                handled = true;
        //                            }
        //                            break;
        //                        default:
        //                            {
        //                                byte[] bytes = references.StaticFiles[fileName];

        //#if !DEBUG
        //                                    context.Response.Headers.CacheControl = new[] { "public", $"max-age={TimeSpan.FromDays(100).TotalSeconds}" };
        //#endif
        //                                context.Response.ContentType = contentType;
        //                                await context.Response.BodyWriter.WriteAsync(bytes);
        //                                handled = true;
        //                            }
        //                            break;
        //                    }
        //                }
        //            }
        //            if (!handled)
        //                await next(context);
        //        });

        app.UseStaticFiles();

        //// If no static middleware found the file, stop now!
        //app.Use(async (context, next) =>
        //{
        //    // Except if swagger file ...

        //    if (!context.Request.Path.Value.ToLower().Contains("swagger"))
        //    {
        //        foreach (string extension in staticFileExtensions)
        //        {
        //            if (context.Request.Path.Value.EndsWith(extension))
        //            {
        //                context.Response.StatusCode = 404;
        //                return;
        //            }
        //        }
        //    }
        //    await next(context);
        //});

        //app.UseForwardedHeaders();
        //app.UseHttpLogging();

        if (buildApp != null)
            buildApp(app);

        app.Urls.Add($"http://*:{port}");
        return app;
    }
}
