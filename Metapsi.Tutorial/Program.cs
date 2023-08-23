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

public static partial class Program
{
    public class Arguments
    {
        public int UiPort { get; set; }
    }

    public static async Task Main()
    {
        MSBuildLocator.RegisterDefaults();
        Metapsi.Sqlite.Converters.RegisterAll();

        var setup = Metapsi.ApplicationSetup.New();

        var parametersFullFilePath = Metapsi.RelativePath.SearchUpfolder(RelativePath.From.CurrentDir, "parameters.json");

        var arguments = Metapsi.Serialize.FromJson<Arguments>(await System.IO.File.ReadAllTextAsync(parametersFullFilePath));

        var ig = setup.AddImplementationGroup();
        var webServer = setup.AddWebServer(ig, arguments.UiPort);

        var apiEndpoint = webServer.WebApplication.MapGroup("api");

        webServer.RegisterStaticFiles(typeof(Program).Assembly);
        webServer.RegisterStaticFiles(typeof(Metapsi.Syntax.Module).Assembly);
        webServer.RegisterStaticFiles(typeof(HyperNode).Assembly);
        webServer.RegisterStaticFiles(typeof(Metapsi.Shoelace.Control).Assembly);


        webServer.WebApplication.MapGet("/", () => Results.Redirect(WebServer.Url<Metapsi.Tutorial.Routes.Tutorial.Step, int>(1)));

        webServer.WebApplication.RegisterGetHandler<TutorialHandler, Metapsi.Tutorial.Routes.Tutorial.Step, int>();
        webServer.RegisterPageBuilder<TutorialModel>(new TutorialRenderer().Render);

        var app = setup.Revive();

        await app.SuspendComplete;
    }
}