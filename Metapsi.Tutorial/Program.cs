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
    public string DbPath { get; set; }
    public string TemplateSlnPath { get; set; }

    public static async Task<Arguments> Load()
    {
        var parametersFullFilePath = Metapsi.RelativePath.SearchUpfolder(RelativePath.From.CurrentDir, "parameters.json");
        var arguments = Metapsi.Serialize.FromJson<Arguments>(await System.IO.File.ReadAllTextAsync(parametersFullFilePath));

        return arguments;
    }

    public static async Task<string> FullDbPath()
    {
        var parametersFullFilePath = Metapsi.RelativePath.SearchUpfolder(RelativePath.From.CurrentDir, "parameters.json");
        var arguments = Metapsi.Serialize.FromJson<Arguments>(await System.IO.File.ReadAllTextAsync(parametersFullFilePath));
        var dbFullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(parametersFullFilePath), arguments.DbPath);
        return dbFullPath;
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
        Metapsi.Sqlite.Converters.RegisterAll();

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
                var contentType = WebServer.GetMimeTypeForFileExtension(".ttf");
                context.HttpContext.Response.ContentType = contentType;
                await context.HttpContext.Response.BodyWriter.WriteAsync(webServer.StaticFiles["codicon.ttf"]);

                context.Result = RuleResult.EndResponse;
            }
        });

        webServer.WebApplication.UseRewriter(rewriteOptions);


        webServer.WebApplication.RegisterGetHandler<TutorialHandler, Metapsi.Tutorial.Routes.Tutorial, string>();
        webServer.RegisterPageBuilder<TutorialModel>(new TutorialPage().Render);

        //webServer.WebApplication.RegisterGetHandler<DocsHandler, Metapsi.Tutorial.Routes.Docs, string>();
        //webServer.RegisterPageBuilder<DocsModel>(new DocsRenderer().Render);

        webServer.WebApplication.RegisterGetHandler<HomeHandler, Metapsi.Tutorial.Routes.Home>();
        webServer.RegisterPageBuilder<HomeModel>(new Homepage().Render);

        //webServer.WebApplication.RegisterGetHandler<XXXHandler, Metapsi.Tutorial.Routes.XXX, string, string>();
        //webServer.RegisterPageBuilder<XXXModel>(new XXXRenderer().Render);


        webServer.WebApplication.RegisterGetHandler<ParagraphHandler, Metapsi.Tutorial.Routes.Paragraph, string>();

        webServer.WebApplication.RegisterGetHandler<MarkdownHandler, Metapsi.Tutorial.Routes.MTutorial, string>();
        webServer.RegisterPageBuilder<MarkdownPage>(new MarkdownRenderer().Render);

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