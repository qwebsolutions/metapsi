using Metapsi;
using Metapsi.Live;
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

    public static async Task Start(CommandContext commandContext, State state, SolutionEntities solutionEntities)
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

        var embeddedResources = solutionEntities.Projects.SelectMany(x => x.EmbeddedResources);
        var distinctResourceNames = embeddedResources.Select(x => x.LogicalName).Distinct();

        foreach (var embeddedResourceName in distinctResourceNames)
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

        if (string.IsNullOrWhiteSpace(webRootPath))
        {
            builder = WebApplication.CreateBuilder();
        }
        else
        {
            builder = WebApplication.CreateBuilder(new WebApplicationOptions() { WebRootPath = webRootPath });
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

        app.UseStaticFiles();

        if (buildApp != null)
            buildApp(app);

        app.Urls.Add($"http://*:{port}");
        return app;
    }
}
