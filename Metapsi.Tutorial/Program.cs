using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Reflection;
using System.IO;
using System.Runtime.Loader;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using System.Diagnostics;
using Metapsi;
using Metapsi.Ui;
using System.Text;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;
using Metapsi.Hyperapp;
using Microsoft.AspNetCore.Builder;
using Metapsi.Dom;
using Microsoft.AspNetCore.Rewrite;

namespace Metapsi.Tutorial;

public class Arguments
{
    public string UiPort { get; set; }
    public string TemplateSlnPath { get; set; }

    public static async Task<Arguments> Load()
    {
        var parametersFullFilePath = Metapsi.RelativePath.SearchUpfolder(RelativePath.From.CurrentDir, "parameters.json");
        var arguments = Metapsi.Serialize.FromJson<Arguments>(await System.IO.File.ReadAllTextAsync(parametersFullFilePath));

        return arguments;
    }

    public static async Task<string> TemplateSlnFullPath()
    {
        var parametersFullFilePath = Metapsi.RelativePath.SearchUpfolder(RelativePath.From.CurrentDir, "parameters.json");
        var arguments = Metapsi.Serialize.FromJson<Arguments>(await System.IO.File.ReadAllTextAsync(parametersFullFilePath));
        return arguments.TemplateSlnPath;
    }
}

public static partial class Program
{
    public static async Task Main()
    {
        MSBuildLocator.RegisterDefaults();
        //Metapsi.Sqlite.Converters.RegisterAll();

        var setup = Metapsi.ApplicationSetup.New();
        var arguments = await Arguments.Load();

        var ig = setup.AddImplementationGroup();
        var webServer = setup.AddWebServer(ig, Convert.ToInt32(arguments.UiPort));

        await CodeSampleRenderer.LoadAllCodeSamples();

        var apiEndpoint = webServer.WebApplication.MapGroup("api");

        webServer.RegisterStaticFiles(typeof(Program).Assembly);
        webServer.RegisterStaticFiles(typeof(DomElement).Assembly);
        webServer.RegisterStaticFiles(typeof(Metapsi.Syntax.Module).Assembly);
        webServer.RegisterStaticFiles(typeof(HyperNode).Assembly);
        webServer.RegisterStaticFiles(typeof(Metapsi.Shoelace.Control).Assembly);


        webServer.WebApplication.MapGet("/", () => Results.Redirect(WebServer.Url<Metapsi.Tutorial.Routes.Home>()));

        // fix Monaco codicon.ttf because I don't know how or if it's even possible using the js options
        var rewriteOptions = new Microsoft.AspNetCore.Rewrite.RewriteOptions();
        rewriteOptions.Add(async (RewriteContext context) =>
        {
            var request = context.HttpContext.Request;
            if (request.Path.Value != null && context.HttpContext.Request.Path.Value.EndsWith("codicon.ttf"))
            {
                request.Path = "/codicon.ttf";
                // If I write the results directly here some other middleware which I cannot identify crashes
            }
        });

        webServer.WebApplication.UseRewriter(rewriteOptions);

        var api = webServer.WebApplication.MapGroup("api");
        api.MapRequest(SandboxApi.CompileSample, async (CommandContext commandContext, HttpContext httpContext, SandboxSample sample) =>
        {
            try
            {
                var resultHtml = await Control.Compile(commandContext, sample);
                return new CompileResponse()
                {
                    ResultHtml = resultHtml
                };
            }
            catch (Exception ex)
            {
                return new CompileResponse()
                {
                    ErrorMessage = ex.Message,
                    ResultCode = "Error",
                    ResultHtml = "Compile error"
                };
            }
        }, WebServer.Authorization.Public);

        webServer.WebApplication.MapGet("/codicon.ttf", async (HttpContext context) =>
        {
            var contentType = WebServer.GetMimeTypeForFileExtension(".ttf");
            context.Response.ContentType = contentType;
            await context.Response.BodyWriter.WriteAsync(webServer.StaticFiles["codicon.ttf"]);
        });

        webServer.WebApplication.RegisterGetHandler<TutorialHandler, Metapsi.Tutorial.Routes.Tutorial, string>();
        webServer.RegisterPageBuilder<TutorialModel>(new TutorialPage().Render);

        webServer.WebApplication.RegisterGetHandler<HomepageHandler, Metapsi.Tutorial.Routes.Home>();
        webServer.RegisterPageBuilder<HomepageModel>(new Homepage().Render);

        webServer.WebApplication.UseExceptionHandler(
            exceptionHandlerApp => exceptionHandlerApp.Run(
                async context => await Results.Problem().ExecuteAsync(context)));


        webServer.WebApplication.MapFallback((HttpContext context) =>
        {
            return "OOOPS!";
        });

        var app = setup.Revive();

        await app.SuspendComplete;
    }
}