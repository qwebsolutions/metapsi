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
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Tutorial;

public class Arguments
{
    public string UiPort { get; set; }
    public string TemplateSlnFolder { get; set; }

    public static async Task<Arguments> Load()
    {
        var parametersFullFilePath = Metapsi.RelativePath.SearchUpfolder(RelativePath.From.CurrentDir, "parameters.json");
        var arguments = Metapsi.Serialize.FromJson<Arguments>(await System.IO.File.ReadAllTextAsync(parametersFullFilePath));

        return arguments;
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
        StaticFiles.AddAll(typeof(Program).Assembly);
        StaticFiles.AddAll(typeof(Metapsi.Hyperapp.HyperType).Assembly);

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

        webServer.WebApplication.MapPostRequest(SandboxApi.CompileSample, async (CommandContext commandContext, HttpContext httpContext, SandboxSample sample) =>
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
                Console.WriteLine(ex);
                return new CompileResponse()
                {
                    ResultHtml = "Compile error"
                };
            }
        }).AllowAnonymous();

        webServer.WebApplication.MapGet("/codicon.ttf", async (HttpContext context) =>
        {
            var contentType = WebServerExtensions.GetMimeTypeForFileExtension(".ttf");
            context.Response.ContentType = contentType;
            var font = await StaticFiles.Get("codicon.ttf");
            await context.Response.BodyWriter.WriteAsync(font);
        });
      
        webServer.WebApplication.RegisterGetHandler<TutorialHandler, Metapsi.Tutorial.Routes.Tutorial, string>();
        webServer.WebApplication.UseRenderer<TutorialModel>(model =>
        {
            return HtmlBuilder.FromDefault(b =>
            {
                TutorialPage.Render(b, model);
            }).ToHtml();
        });

        webServer.WebApplication.RegisterGetHandler<HomepageHandler, Metapsi.Tutorial.Routes.Home>();
        webServer.WebApplication.UseRenderer<HomepageModel>(model =>
        {
            return HtmlBuilder.FromDefault(b =>
            {
                Homepage.Render(b, model);
            }).ToHtml();
        });

        webServer.WebApplication.UseExceptionHandler(
            exceptionHandlerApp => exceptionHandlerApp.Run(
                async context => await Results.Problem().ExecuteAsync(context)));
        

        webServer.WebApplication.MapFallback((HttpContext context) =>
        {
            return "OOOPS!";
        });

        setup.MapEvent<ApplicationRevived>(e =>
        {
            var createTemplateSlnTask = Task.Run(async () =>
            {
                try
                {
                    if (System.IO.Directory.Exists(arguments.TemplateSlnFolder))
                    {
                        System.IO.Directory.Delete(arguments.TemplateSlnFolder, true);
                    }

                    System.IO.Directory.CreateDirectory(arguments.TemplateSlnFolder);

                    List<string> slnFiles = new() {
                        "Metapsi.Tutorial.Template.sln",
                        "Metapsi.Tutorial.Template.csproj",
                        "Renderer.cs" 
                    };

                    foreach (var file in slnFiles)
                    {
                        await System.IO.File.WriteAllTextAsync(
                            System.IO.Path.Combine(arguments.TemplateSlnFolder, file),
                            await typeof(Program).Assembly.GetEmbeddedTextFile(file));
                    }

                    var dotnetRestore = System.Diagnostics.Process.Start("dotnet", $"restore {arguments.TemplateSlnFolder} -f");

                    await dotnetRestore.WaitForExitAsync();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            });
        });

        var app = setup.Revive();

        await app.SuspendComplete;
    }
}