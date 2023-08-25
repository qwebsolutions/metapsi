using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
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

        var apiEndpoint = webServer.WebApplication.MapGroup("api");

        webServer.RegisterStaticFiles(typeof(Program).Assembly);
        webServer.RegisterStaticFiles(typeof(Metapsi.Syntax.Module).Assembly);
        webServer.RegisterStaticFiles(typeof(HyperNode).Assembly);
        webServer.RegisterStaticFiles(typeof(Metapsi.Shoelace.Control).Assembly);


        webServer.WebApplication.MapGet("/", () => Results.Redirect(WebServer.Url<Metapsi.Tutorial.Routes.Home>()));

        webServer.WebApplication.RegisterGetHandler<TutorialHandler, Metapsi.Tutorial.Routes.Tutorial, string>();
        webServer.RegisterPageBuilder<TutorialModel>(new TutorialRenderer().Render);

        webServer.WebApplication.RegisterGetHandler<DocsHandler, Metapsi.Tutorial.Routes.Docs, string>();
        webServer.RegisterPageBuilder<DocsModel>(new DocsRenderer().Render);

        webServer.WebApplication.RegisterGetHandler<HomeHandler, Metapsi.Tutorial.Routes.Home>();
        webServer.RegisterPageBuilder<HomeModel>(new HomeRenderer().Render);

        webServer.WebApplication.RegisterGetHandler<ParagraphHandler, Metapsi.Tutorial.Routes.Paragraph, string>();


        var app = setup.Revive();

        await app.SuspendComplete;
    }
}