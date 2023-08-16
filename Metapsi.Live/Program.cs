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
//using Metapsi.Hyperapp;
//using Metapsi.JavaScript;
using Metapsi;
using Metapsi.Ui;
using System.Text;
using Metapsi.Sqlite;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;
using Metapsi.Hyperapp;
using Microsoft.AspNetCore.Builder;
using Metapsi.Live;

public static partial class Program
{
    public class Arguments
    {
        public string DbPath { get; set; } = string.Empty;
        public int UiPort { get; set; }
    }

    public static async Task Main()
    {
        MSBuildLocator.RegisterDefaults();
        Metapsi.Sqlite.Converters.RegisterAll();

        var setup = Metapsi.ApplicationSetup.New();

        var parametersFullFilePath = Metapsi.RelativePath.SearchUpfolder(RelativePath.From.CurrentDir, "parameters.json");

        var arguments = Metapsi.Serialize.FromJson<Arguments>(await System.IO.File.ReadAllTextAsync(parametersFullFilePath));

        var dbFullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(parametersFullFilePath), arguments.DbPath);

        var compileEnvironment = setup.AddBusinessState(new CompileEnvironment.State());
        var panelEnvironment = setup.AddBusinessState(
            new PanelEnvironment.State()
            {
                FullDbPath = dbFullPath
            });
        var previewEnvironment = setup.AddBusinessState(new PreviewEnvironment.State());

        var ig = setup.AddImplementationGroup();
        setup.MapEvents(ig, compileEnvironment, panelEnvironment, previewEnvironment);

        var webServer = setup.AddWebServer(ig, arguments.UiPort);

        var apiEndpoint = webServer.WebApplication.MapGroup("api");

        apiEndpoint.MapFrontend();

        webServer.RegisterStaticFiles(typeof(Program).Assembly);
        webServer.RegisterStaticFiles(typeof(Metapsi.Syntax.Module).Assembly);
        webServer.RegisterStaticFiles(typeof(HyperNode).Assembly);
        webServer.RegisterStaticFiles(typeof(Metapsi.Shoelace.Control).Assembly);

        webServer.WebApplication.RegisterGetHandler<Handler.Home, Metapsi.Live.Route.Home>();
        webServer.RegisterPageBuilder<Handler.Home.Model>(new Render.Homepage().Render);
        webServer.WebApplication.MapGet("/", () => Results.Redirect(WebServer.Url<Metapsi.Live.Route.Home>()));

        ig.MapStorage(dbFullPath);
        ig.MapBackend(compileEnvironment, panelEnvironment, previewEnvironment);


        var app = setup.Revive();

        await app.SuspendComplete;
    }

    public static void WriteList(IEnumerable<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    private static List<string> GetProjectFiles(Project project)
    {
        List<string> projectFiles = new();
        foreach (var doc in project.Documents)
        {
            projectFiles.Add(doc.FilePath);
        }

        return projectFiles;
    }

    private static void FillRecursiveProjectReferences(Solution solution, Project project, HashSet<Project> recursiveProjects)
    {
        foreach (var reference in project.ProjectReferences)
        {
            var referencedProject = solution.GetProject(reference.ProjectId);
            if (!recursiveProjects.Contains(referencedProject))
            {
                recursiveProjects.Add(referencedProject);
                FillRecursiveProjectReferences(solution, project, recursiveProjects);
            }
        }
    }
}