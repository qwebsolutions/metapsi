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
//using Metapsi.Syntax;
//using Microsoft.AspNetCore.Builder;

public static partial class Program
{
    //public static Command<string> InitSolution { get; set; } = new(nameof(InitSolution));

    public class ProjectSelected : IData
    {
        public string ProjectName { get; set; }
    }

    public static async Task Main()
    {
        MSBuildLocator.RegisterDefaults();
        //System.Threading.ThreadPool.SetMinThreads(1200, 1200);

        var setup = Metapsi.ApplicationSetup.New();

        var reloadEnvironment = setup.AddBusinessState(new ReloadEnvironment.State());
        var visualEnvironment = setup.AddBusinessState(new VisualEnvironment.State());

        var ig = setup.AddImplementationGroup();

        //ig.MapCommand(InitSolution, async (rc, slnPath) =>
        //{
        //    await rc.Using(reloadEnvironment, ig).EnqueueCommand(ReloadEnvironment.InitSolution, slnPath);
        //});

        const string targetPath = @"d:\qweb\mes\Flex\Flex.sln";
        var mainCsProj = "FlexPortal";
        var renderer = "RenderListsRequestsPage";

        setup.MapEvent<ApplicationRevived>(e =>
        {
            e.Using(reloadEnvironment).EnqueueCommand(ReloadEnvironment.InitSolution, targetPath);
            e.Using(reloadEnvironment).EnqueueCommand(ReloadEnvironment.SwitchProject, mainCsProj);
            e.Using(reloadEnvironment).EnqueueCommand(ReloadEnvironment.SwitchRenderer, renderer);
        });

        //setup.MapEvent<ReloadEnvironment.ProjectLoaded>(e =>
        //{
        //    e.Using(reloadEnvironment).EnqueueCommand(ReloadEnvironment.SwitchProject, e.EventData.ProjectName);
        //});

        setup.MapEvent<ReloadEnvironment.LoadingStarted>(e =>
        {
            e.Using(visualEnvironment).EnqueueCommand(VisualEnvironment.SetLoading, true);
        });

        setup.MapEvent<ReloadEnvironment.SolutionLoaded>(e =>
        {
            e.Using(visualEnvironment).EnqueueCommand(VisualEnvironment.SetLoading, false);
            e.Using(visualEnvironment).EnqueueCommand(VisualEnvironment.SetProjects, e.EventData.Projects);
        });

        setup.MapEvent<ReloadEnvironment.ProjectLoaded>(e =>
        {
            e.Using(visualEnvironment).EnqueueCommand(VisualEnvironment.SetLoading, false);
            e.Using(visualEnvironment).EnqueueCommand(VisualEnvironment.SetProjectRenderers, e.EventData.Renderers);
        });

        setup.MapEvent<ReloadEnvironment.RendererGenerated>(e =>
        {
            e.Using(visualEnvironment).EnqueueCommand(VisualEnvironment.SetLoading, false);
            e.Using(visualEnvironment).EnqueueCommand(async (cc, state, rendererJs) =>
            {
                state.RendererJs = rendererJs;
            }, e.EventData.Js);
        });

        setup.MapEvent<VisualEnvironment.ProjectSelected>(e =>
        {
            e.Using(reloadEnvironment).EnqueueCommand(ReloadEnvironment.SwitchProject, e.EventData.ProjectName);
        });

        setup.MapEvent<VisualEnvironment.RendererSelected>(e =>
        {
            e.Using(reloadEnvironment).EnqueueCommand(ReloadEnvironment.SwitchRenderer, e.EventData.RendererName);
        });

        //var webServer = setup.AddWebServer(ig, 7132);
        //var hyperApp = webServer.AddHyperapp(MetapsiEditor);

        //webServer.WebApplication.MapGroup("api").MapFrontend();


        ig.MapRequest(Backend.GetProjects, async (rc) =>
        {
            return await rc.Using(visualEnvironment, ig).EnqueueRequest(VisualEnvironment.GetProjects);
        });

        ig.MapRequest(Backend.GetRenderers, async (rc) =>
        {
            return await rc.Using(visualEnvironment, ig).EnqueueRequest(VisualEnvironment.GetRenderers);
        });

        ig.MapRequest(Backend.GetRenderer, async (rc) =>
        {
            return await rc.Using(visualEnvironment, ig).EnqueueRequest(VisualEnvironment.GetRenderer);
        });
        

        //ig.MapRequest(ReloadEnvironment.GetProjectAssembly, async (rc) =>
        //{
        //    return await rc.Using(reloadEnvironment, ig).EnqueueRequest(ReloadEnvironment.GetBaseProjectAssembly);
        //});

        var app = setup.Revive();

        await app.SuspendComplete;
    }

    //public class EditorPageModel : IApiSupportState
    //{
    //    public List<string> AllProjects { get; set; } = new();
    //    public string SelectedProject { get; set; } = string.Empty;
    //    public List<string> AllRenderers { get; set; } = new();
    //    public string SelectedRenderer { get; set; } = string.Empty;
    //    public string RendererJs { get; set; } = string.Empty;

    //    public ApiSupport ApiSupport { get; set; } = new();
    //}

    //public static async Task<IResponse> MetapsiEditor(CommandContext commandContext)
    //{
    //    var projectsResponse = await commandContext.Do(Backend.GetProjects);
    //    var renderersResponse = await commandContext.Do(Backend.GetRenderers);
    //    var rendererResponse = await commandContext.Do(Backend.GetRenderer);

    //    //var projectAssembly = await commandContext.Do(ReloadEnvironment.GetProjectAssembly);

    //    if (projectsResponse.IsLoading || renderersResponse.IsLoading || rendererResponse.IsLoading)
    //    {
    //        return Page.Response<EditorPageModel>(new EditorPageModel(), (BlockBuilder b, Var<EditorPageModel> model) =>
    //        {
    //            return b.Div("", b => b.Text("Compiling..."));
    //        });
    //    }
    //    else
    //    {
    //        var editorPageModel = new EditorPageModel();
    //        editorPageModel.AllProjects = projectsResponse.Projects;
    //        editorPageModel.AllRenderers = renderersResponse.Renderers;
    //        editorPageModel.RendererJs = rendererResponse.Js;

    //        return Page.Response<EditorPageModel>(editorPageModel, (BlockBuilder b, Var<EditorPageModel> model) =>
    //        {
    //            return b.Div(
    //                "",
    //                b => b.Text("Selected project:"),
    //                b => b.If(
    //                    b.HasValue(b.Get(model, x => x.SelectedProject)),
    //                    b => b.Text(b.Get(model, x => x.SelectedProject)),
    //                    b => b.Text("None")),
    //                b => b.Div(
    //                    "",
    //                    b.Map(
    //                        b.Get(model, x => x.AllProjects),
    //                        (BlockBuilder b, Var<string> projectName) =>
    //                        {
    //                            var projectButton = b.Div("button", b => b.Text(projectName));

    //                            b.SetOnClick(projectButton, b.MakeAction((BlockBuilder b, Var<EditorPageModel> model) =>
    //                            {
    //                                return b.AsyncResult(
    //                                    b.Clone(model),
    //                                    b.Request(
    //                                        Frontend.SelectProject,
    //                                        projectName,
    //                                        b.MakeAction((BlockBuilder b, Var<EditorPageModel> model, Var<ApiResponse> response) =>
    //                                        {
    //                                            b.Set(model, x => x.SelectedProject, projectName);
    //                                            return b.Clone(model);
    //                                        })));
    //                            }));

    //                            return projectButton;
    //                        })),
    //                b => b.Div(
    //                    "",
    //                    b.Map(
    //                        b.Get(model, x => x.AllRenderers),
    //                        (BlockBuilder b, Var<string> renderer) =>
    //                        {
    //                            var rendererButton = b.Div("button", b => b.Text(renderer));

    //                            b.SetOnClick(rendererButton, b.MakeAction((BlockBuilder b, Var<EditorPageModel> model) =>
    //                            {
    //                                return b.AsyncResult(
    //                                    b.Clone(model),
    //                                    b.Request(
    //                                        Frontend.SelectRenderer,
    //                                        renderer,
    //                                        b.MakeAction((BlockBuilder b, Var<EditorPageModel> model, Var<ApiResponse> response) =>
    //                                        {
    //                                            b.Set(model, x => x.SelectedRenderer, renderer);
    //                                            return b.Clone(model);
    //                                        })));
    //                            }));

    //                            return rendererButton;
    //                        })),
    //                b => b.Node("pre", "", b => b.TextNode(b.Get(model, x => x.RendererJs))));
    //        });
    //    }
    //}

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
            //Console.WriteLine(doc.FilePath);
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

    private static void TestCompilation()
    {
        try
        {
            // code for class A
            var classAString =
                @"public class A 
                    {
                        public static string Print() 
                        { 
                            return ""Hello "";
                        }
                    }";

            // code for class B (to spice it up, it is a 
            // subclass of A even though it is almost not needed
            // for the demonstration)
            var classBString =
                @"public class B : A
                    {
                        public static string Print()
                        { 
                            return ""World!"";
                        }
                    }";

            // the main class Program contain static void Main() 
            // that calls A.Print() and B.Print() methods
            var mainProgramString =
                @"public class Program
                    {
                        public static void Main()
                        {
                            System.Console.Write(A.Print()); 
                            System.Console.WriteLine(B.Print());
                        }
                    }";

            #region class A compilation into A.netmodule
            // create Roslyn compilation for class A
            var compilationA =
                CreateCompilationWithMscorlib
                (
                    "A",
                    classAString,
                    compilerOptions: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
                );

            // emit the compilation result to a byte array 
            // corresponding to A.netmodule byte code
            var compilationAResult = compilationA.EmitToArray();

            MemoryStream compilationAStream = new MemoryStream();
            compilationAStream.Write(compilationAResult);
            compilationAStream.Seek(0, SeekOrigin.Begin);

            MetadataReference referenceA = MetadataReference.CreateFromStream(compilationAStream, filePath: "a.dll");

            var compilationB =
                CreateCompilationWithMscorlib
                (
                    "B",
                    classBString,
                    compilerOptions: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary),

                    // since class B extends A, we need to 
                    // add a reference to A.netmodule
                    references: new[] { referenceA }
                );

            // emit the compilation result to a byte array 
            // corresponding to B.netmodule byte code
            var compilationBResult = compilationB.EmitToArray();

            // create a reference to B.netmodule
            MemoryStream compilationBStream = new MemoryStream();
            compilationBStream.Write(compilationBResult);
            compilationBStream.Seek(0, SeekOrigin.Begin);

            var referenceB = MetadataReference.CreateFromStream(compilationBStream, filePath: "b.dll");
            #endregion class B compilation into B.netmodule

            #region main program compilation into the assembly
            // create the Roslyn compilation for the main program with
            // ConsoleApplication compilation options
            // adding references to A.netmodule and B.netmodule
            var mainCompilation =
                CreateCompilationWithMscorlib
                (
                    "program",
                    mainProgramString,
                    compilerOptions: new CSharpCompilationOptions
                                     (OutputKind.ConsoleApplication),
                    references: new[] { referenceA, referenceB }
                );

            // Emit the byte result of the compilation
            var result = mainCompilation.EmitToArray();

            // create a reference to B.netmodule
            MemoryStream ms = new MemoryStream();
            ms.Write(result);
            ms.Seek(0, SeekOrigin.Begin);

            var loadContext = new AssemblyLoadContext("program");
            loadContext.LoadFromStream(ms);

            ms = new MemoryStream();
            ms.Write(compilationAResult);
            ms.Seek(0, SeekOrigin.Begin);
            loadContext.LoadFromStream(ms);

            ms = new MemoryStream();
            ms.Write(compilationBResult);
            ms.Seek(0, SeekOrigin.Begin);
            loadContext.LoadFromStream(ms);

            var assemblies = loadContext.Assemblies;
            var assembly = loadContext.Assemblies.Single(x => x.GetTypes().Any(x => x.Name == "Program"));

            //loadContext.LoadFromStream(compilationBResult);

            #endregion main program compilation into the assembly

            // load the A.netmodule and B.netmodule into the assembly.
            //assembly.LoadModule("A.netmodule", compilationAResult);
            //assembly.LoadModule("B.netmodule", compilationBResult);

            #region Test the program
            // here we get the Program type and 
            // call its static method Main()
            // to test the program. 
            // It should write "Hello world!"
            // to the console

            // get the type Program from the assembly
            Type programType = assembly.GetType("Program");

            // Get the static Main() method info from the type
            MethodInfo method = programType.GetMethod("Main");

            // invoke Program.Main() static method
            method.Invoke(null, null);
            #endregion Test the program
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    // a utility method that creates Roslyn compilation
    // for the passed code. 
    // The compilation references the collection of 
    // passed "references" arguments plus
    // the mscore library (which is required for the basic
    // functionality).
    private static CSharpCompilation CreateCompilationWithMscorlib
    (
        string assemblyOrModuleName,
        string code,
        CSharpCompilationOptions compilerOptions = null,
        IEnumerable<MetadataReference> references = null)
    {
        // create the syntax tree
        SyntaxTree syntaxTree = SyntaxFactory.ParseSyntaxTree(code, null, "");

        // get the reference to mscore library
        MetadataReference mscoreLibReference =
            AssemblyMetadata
                .CreateFromFile(typeof(string).Assembly.Location)
                .GetReference();

        MetadataReference consoleReference =
            AssemblyMetadata
            .CreateFromFile(typeof(System.Console).Assembly.Location)
            .GetReference();

        var objectAssemblyPath = Path.GetDirectoryName(typeof(System.Object).Assembly.Location);

        var runtimeReference = AssemblyMetadata
            .CreateFromFile(Path.Combine(objectAssemblyPath, "System.Runtime.dll"))
            .GetReference();

        //references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Private.CoreLib.dll")));
        //references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Console.dll")));
        //references.Add(MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Runtime.dll")));

        // create the allReferences collection consisting of 
        // mscore reference and all the references passed to the method
        IEnumerable <MetadataReference> allReferences =
            new MetadataReference[] { mscoreLibReference, consoleReference, runtimeReference };
        if (references != null)
        {
            allReferences = allReferences.Concat(references);
        }

        // create and return the compilation
        CSharpCompilation compilation = CSharpCompilation.Create
        (
            assemblyOrModuleName,
            new[] { syntaxTree },
            options: compilerOptions,
            references: allReferences
        );

        return compilation;
    }

    
}