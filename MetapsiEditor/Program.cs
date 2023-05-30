using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Loader;
using Microsoft.CodeAnalysis.MSBuild;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using System.Diagnostics;
using Metapsi.Hyperapp;
using Metapsi.JavaScript;
using Metapsi;

public static class Program
{
    public static class ReloadEnvironment
    {
        public class State
        {
            public Solution OriginalSolution { get; set; }
            public Solution DynamicSolution { get; set; }
            public Project OriginalProject { get; set; } // Full project
            public Compilation OriginalProjectCompilation { get; set; }
            public Project BaseProject { get; set; } // Stripped of separate 'focus' class
            public Project ChildProject { get; set; } // Temporary project for the 'focus' class
            public string RendererName { get; set; }

            // Just some tests

            public byte[] ParentBinary { get; set; }
            public byte[] FlexContractsBinary { get; set; }
        }

        public class ProjectLoaded : IData
        {
            public string ProjectName { get; set; }
        }

        public static async Task InitSolution(CommandContext commandContext, State state, string slnPath)
        {
            var sw = Stopwatch.StartNew();
            var workspace = MSBuildWorkspace.Create();
            state.OriginalSolution = await workspace.OpenSolutionAsync(slnPath);
            Console.WriteLine($"Solution {sw.ElapsedMilliseconds} ms");
        }

        public static async Task SwitchProject(CommandContext commandContext, State state, string projectName)
        {
            var sw = Stopwatch.StartNew();

            state.OriginalProject = state.OriginalSolution.Projects.SingleOrDefault(x => x.Name == projectName);
            if (state.OriginalProject == null)
            {
                Console.WriteLine("Project does not exist in the specified solution");
                return;
            }

            state.OriginalProjectCompilation = await state.OriginalProject.GetCompilationAsync();

            Console.WriteLine($"Project {sw.ElapsedMilliseconds} ms");

            // Get the static Main() method info from the type
            //MethodInfo method = programType.GetMethod("Render");

            // invoke Program.Main() static method
            //method.Invoke(null, null);

            //var projectFiles = GetProjectFiles(phantomProject);

            //WriteList(projectFiles);

            //var recProjects = new HashSet<Project>();

            //FillRecursiveProjectReferences(updatedSln, phantomProject, recProjects);

            //foreach (var reference in recProjects)
            //{
            //    WriteList(GetProjectFiles(reference));
            //}

        }


        public static async Task SwitchRenderer(CommandContext commandContext, State state, string rendererClass)
        {
            var projectStopwatch = Stopwatch.StartNew();

            var rendererSymbol = state.OriginalProjectCompilation.GetSymbolsWithName(rendererClass).Single();
            var declaration = rendererSymbol.DeclaringSyntaxReferences;

            state.BaseProject = state.OriginalProject.RemoveDocument(state.OriginalProject.Documents.SingleOrDefault(x => x.FilePath.Contains(rendererClass)).Id);

            //var baseProjectCompilation = state.OriginalProjectCompilation.RemoveSyntaxTrees(declaration.Select(x => x.SyntaxTree));
            var baseProjectCompilation = await state.BaseProject.GetCompilationAsync();
            //baseProjectCompilation = baseProjectCompilation.AddReferences(
            //    AssemblyMetadata
            //    .CreateFromFile(typeof(string).Assembly.Location)
            //    .GetReference());

            state.ParentBinary = baseProjectCompilation.EmitToArray();
            
            

            //var sellerDashboard = project.Documents.Single(x => x.FilePath.EndsWith(@"PrivateSeller\Dashboard.cs"));
            //var withoutDashboard = project.RemoveDocument(sellerDashboard.Id);
            //state.DynamicSolution = withoutDashboard.Solution;
            var phantomProjectId = ProjectId.CreateNewId();

            var withOriginalProjectReference = state.OriginalProject.ProjectReferences;//.Append(new ProjectReference(state.OriginalProject.Id));

            var phantomProjectInfo = ProjectInfo.Create(
                phantomProjectId,
                VersionStamp.Default,
                "Dynamic" + state.OriginalProject.Name,
                "Dynamic" + state.OriginalProject.Name,
                "C#",
                projectReferences: withOriginalProjectReference,
                compilationOptions: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary),
                metadataReferences: state.OriginalProject.MetadataReferences.Append(MetadataReference.CreateFromImage(state.ParentBinary)));

            state.DynamicSolution = state.OriginalSolution.AddProject(phantomProjectInfo);

            var phantomProject = state.DynamicSolution.GetProject(phantomProjectInfo.Id);
            var classIndex = 0;
            foreach (var partialClass in declaration)
            {
                phantomProject = state.DynamicSolution.GetProject(phantomProjectInfo.Id);
                classIndex++;
                var document = phantomProject.AddDocument($"_{classIndex}.cs", partialClass.SyntaxTree.GetRoot());
                phantomProject = document.Project;
                state.DynamicSolution = phantomProject.Solution;
            }

            var sw = Stopwatch.StartNew();
            try
            {
                var phantomCompilation = await phantomProject.GetCompilationAsync();

                foreach (var diagnostic in phantomCompilation.GetDiagnostics())
                {
                    Console.WriteLine(diagnostic);
                }

                Console.WriteLine(sw.ElapsedMilliseconds);




                //if (state.ParentBinary == null)
                //{
                //    var parentProjectCompilation = await withoutDashboard.GetCompilationAsync();
                //    state.ParentBinary = parentProjectCompilation.EmitToArray();
                //}

                //if (state.FlexContractsBinary == null)
                //{
                //    var flexContractsProject = updatedSln.Projects.Single(x => x.Name.Contains("FlexContracts"));
                //    var flexContractsCompilation = await flexContractsProject.GetCompilationAsync();
                //    state.FlexContractsBinary = flexContractsCompilation.EmitToArray();
                //}

                var flexContractsProject = state.DynamicSolution.Projects.Single(x => x.Name.Contains("FlexContracts"));
                var flexContractsCompilation = await flexContractsProject.GetCompilationAsync();
                var flexContractsBinaries = flexContractsCompilation.EmitToArray();

                var loadContext = new AssemblyLoadContext("Renderer_" + rendererClass);

                LoadFromArray(loadContext, state.ParentBinary);
                LoadFromArray(loadContext, flexContractsBinaries);
                //LoadFromArray(state.AssemblyLoadContext, state.FlexContractsBinary);

                var rendererBinary = phantomCompilation.EmitToArray();
                var assembly = LoadFromArray(loadContext, rendererBinary);

                // get the type Program from the assembly
                Type programType = assembly.GetTypes().Single(x => x.Name.Contains("SellerPageRenderer"));

                BuildJsModule(programType);

                Console.WriteLine($"Renderer {projectStopwatch.ElapsedMilliseconds} ms");
            }
            catch (Exception ex)
            {

            }

            //commandContext.PostEvent(new ProjectLoaded() { ProjectName = projectName });
        }
    }

    public static Command<string> InitSolution { get; set; } = new(nameof(InitSolution));

    public class ProjectSelected : IData
    {
        public string ProjectName { get; set; }
    }

    public static async Task Main()
    {
        MSBuildLocator.RegisterDefaults();
        System.Threading.ThreadPool.SetMinThreads(1200, 1200);

        var setup = Metapsi.ApplicationSetup.New();

        var reloadEnvironment = setup.AddBusinessState(new ReloadEnvironment.State());

        var ig = setup.AddImplementationGroup();

        ig.MapCommand(InitSolution, async (rc, slnPath) =>
        {
            await rc.Using(reloadEnvironment, ig).EnqueueCommand(ReloadEnvironment.InitSolution, slnPath);
        });

        const string targetPath = @"d:\qweb\mes\Flex\FlexPortal\FlexPortal.sln";
        var mainCsProj = "FlexPortal";
        var renderer = "SellerPageRenderer";

        setup.MapEvent<ApplicationRevived>(e =>
        {
            e.Using(reloadEnvironment).EnqueueCommand(ReloadEnvironment.InitSolution, targetPath);
            e.Using(reloadEnvironment).EnqueueCommand(ReloadEnvironment.SwitchProject, mainCsProj);
            e.Using(reloadEnvironment).EnqueueCommand(ReloadEnvironment.SwitchRenderer, renderer);
        });

        setup.MapEvent<ReloadEnvironment.ProjectLoaded>(e =>
        {
            e.Using(reloadEnvironment).EnqueueCommand(ReloadEnvironment.SwitchProject, e.EventData.ProjectName);
        });

        var app = setup.Revive();

        await app.SuspendComplete;
    }

    public static string BuildJsModule(
        Type rendererType)
    {
        Stopwatch sw = Stopwatch.StartNew();
        IPageBuilder pageBuilder = Activator.CreateInstance(rendererType) as IPageBuilder;
        var module = pageBuilder.GetModule();
        var jsModule = PrettyBuilder.Generate(module, string.Empty);
        var generateElapsed = sw.ElapsedMilliseconds;

        Console.WriteLine(jsModule);
        Console.WriteLine("Generate all pages " + generateElapsed + " ms");

        return jsModule;
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

    // emit the compilation result into a byte array.
    // throw an exception with corresponding message
    // if there are errors
    private static byte[] EmitToArray
    (
        this Compilation compilation
    )
    {
        var stream = new MemoryStream();
        // emit result into a stream
        var emitResult = compilation.Emit(stream);

        if (!emitResult.Success)
        {
            // if not successful, throw an exception
            Diagnostic firstError =
                emitResult
                    .Diagnostics
                    .FirstOrDefault
                    (
                        diagnostic =>
                            diagnostic.Severity == DiagnosticSeverity.Error
                    );

            throw new Exception(firstError?.GetMessage());
        }
        stream.Seek(0, SeekOrigin.Begin);
        // get the byte array from a stream
        return stream.ToArray();
    }

    private static Assembly LoadFromArray(AssemblyLoadContext assemblyLoadContext, byte[] binaries)
    {
        var ms = new MemoryStream();
        ms.Write(binaries);
        ms.Seek(0, SeekOrigin.Begin);
        return assemblyLoadContext.LoadFromStream(ms);
    }
}