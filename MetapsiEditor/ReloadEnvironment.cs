using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using Microsoft.CodeAnalysis.MSBuild;
using System.Threading.Tasks;
using System.Diagnostics;
using Metapsi;
using System.IO;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics.Contracts;
using Microsoft.Build.Framework;

public static class ReloadEnvironment
{
    public class LoadingStarted : IData
    {
    }

    public class SolutionLoaded : IData
    {
        public List<string> Projects { get; set; }
    }

    public class ProjectLoaded : IData
    {
        public List<string> Renderers { get; set; } = new();
    }

    public class RendererGenerated: IData
    {
        public string RendererName { get; set; } = string.Empty;
        public string Js { get; set; } = string.Empty;
        public long Milliseconds { get; set; }
    }

    public class State
    {
        public Solution OriginalSolution { get; set; }
        public Solution DynamicSolution { get; set; }

        public string SelectedProjectName { get; set; } = string.Empty;

        public Dictionary<string, Compilation> OriginalCompilations { get; set; } = new();

        //public Project OriginalProject { get; set; } // Full project
                                                     //public Compilation OriginalProjectCompilation { get; set; }
                                                     //public Assembly OriginalAssembly { get; set; }
        public List<string> OriginalRenderers { get; set; } = new();
        public Dictionary<string, byte[]> OriginalAssemblies = new();

        //public AssemblyLoadContext OriginalLoadContext = new("original");

        public Project BaseProject { get; set; } // Stripped of separate 'focus' class
        public Project ChildProject { get; set; } // Temporary project for the 'focus' class
        public string RendererName { get; set; }
        public byte[] ParentBinary { get; set; }

        public string InputModel { get; set; }
    }

    public static async Task InitSolution(CommandContext commandContext, State state, string slnPath)
    {
        commandContext.PostEvent(new LoadingStarted());
        var sw = Stopwatch.StartNew();

        var workspace = MSBuildWorkspace.Create();
        state.OriginalSolution = await workspace.OpenSolutionAsync(slnPath);
        var deps = state.OriginalSolution.GetProjectDependencyGraph();
        Console.WriteLine($"Solution {sw.ElapsedMilliseconds} ms");
        foreach (var project in state.OriginalSolution.Projects)
        {
            state.OriginalCompilations[project.Name] = await project.GetCompilationAsync();
            state.OriginalAssemblies[project.Name] = state.OriginalCompilations[project.Name].EmitToArray();
        }

        commandContext.PostEvent(new SolutionLoaded()
        {
            Projects = state.OriginalSolution.Projects.Select(x => x.Name).ToList()
        });
    }

    public static Project SelectedOriginalProject(this State state)
    {
        if (string.IsNullOrEmpty(state.SelectedProjectName))
            return null;

        return state.OriginalSolution.Projects.Single(x => x.Name == state.SelectedProjectName);
    }

    public static Compilation SelectedProjectCompilation(this State state)
    {
        if (state.SelectedOriginalProject() == null)
            return null;

        return state.OriginalCompilations[state.SelectedProjectName];
    }

    public class ClassVisitor : CSharpSyntaxWalker
    {
        public HashSet<ClassDeclarationSyntax> ClassDeclarations = new();

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            ClassDeclarations.Add(node);
            base.VisitClassDeclaration(node);
        }
    }

    public static async Task SwitchProject(CommandContext commandContext, State state, string projectName)
    {
        commandContext.PostEvent(new LoadingStarted());

        state.SelectedProjectName = projectName;

        List<string> renderers = new();

        //var dict = new System.Collections.Generic.Dictionary<string, string>();
        //var taskItemOutputs = new System.Collections.Generic.Dictionary<string, ITaskItem>();

        //var msBuild = new MSBuild();
        //msBuild.Projects = new ITaskItem[] {new TaskItem().}

        //var whatever = new MSBuild().BuildEngine.BuildProjectFile(
        //    state.SelectedOriginalProject().FilePath,
        //    new string[] { "net7.0" },
        //    dict,
        //    taskItemOutputs);

        var process = System.Diagnostics.Process.Start(
            new ProcessStartInfo()
            {
                FileName = "dotnet",
                Arguments = $"build {state.SelectedOriginalProject().FilePath} -c Release -r win10-x64"
            });

        await process.WaitForExitAsync();

        foreach (var document in state.SelectedOriginalProject().Documents)
        {
            if (document.FilePath.EndsWith(".cs"))
            {
                var syntaxTree = await document.GetSyntaxTreeAsync();

                var semanticModel = await document.GetSemanticModelAsync();

                var renderersVisitor = new ClassVisitor();
                renderersVisitor.Visit(syntaxTree.GetRoot());
                foreach (var classDeclaration in renderersVisitor.ClassDeclarations)
                {
                    var classSymbol = semanticModel.GetDeclaredSymbol(classDeclaration);
                    var allInterfaces = classSymbol.AllInterfaces;
                    if (allInterfaces.Any(x => x.Name == "IPageBuilder"))
                    {
                        renderers.Add(classSymbol.Name);
                    }
                }
            }
        }

        Console.WriteLine("Project switched");

        commandContext.PostEvent(new ProjectLoaded()
        {
            Renderers = renderers
        });

        //var originalAssembly = state.OriginalLoadContext.Assemblies.Single(x => x.GetName().Name == projectName);
        //var allTypes = originalAssembly.DefinedTypes;
    }

    //public static async Task<Assembly> GetBaseProjectAssembly(CommandContext commandContext, State state)
    //{
    //    if (state.ParentBinary == null)
    //        return null;

    //    var originalLoadContext = new AssemblyLoadContext("original");
    //    var originalAssembly = LoadFromArray(originalLoadContext, state.OriginalProjectCompilation.EmitToArray());
    //    var parentAssembly = LoadFromArray(originalLoadContext, state.ParentBinary);

    //    while (true)
    //    {
    //        try
    //        {
    //            var allRenderers = originalAssembly.DefinedTypes.Where(x => x.IsAssignableTo(typeof(IPageBuilder)));

    //            state.OriginalRenderers.AddRange(allRenderers.Select(x => x.Name));

    //            break;
    //        }
    //        catch (FileNotFoundException ex)
    //        {

    //        }

    //        catch (System.Reflection.ReflectionTypeLoadException ex)
    //        {
    //            var first = ex.LoaderExceptions.FirstOrDefault(x => x is FileNotFoundException);

    //            var supportProject = state.OriginalSolution.Projects.Single(x => x.Name == AssemblyName(first as FileNotFoundException));

    //            var supportCompilation = await supportProject.GetCompilationAsync();
    //            var supportBinary = supportCompilation.EmitToArray();

    //            var supportAssembly = LoadFromArray(originalLoadContext, supportBinary);
    //        }
    //    }

    //    return originalAssembly;
    //}

    public class NamespaceRewriter : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            //Console.WriteLine(node.Name);
            var updatedNamespace = node.WithName(SyntaxFactory.ParseName("Dynamic_" + node.Name.ToString()));
            return base.VisitNamespaceDeclaration(updatedNamespace);
        }
    }

    public static async Task SwitchRenderer(CommandContext commandContext, State state, string rendererClass)
    {
        commandContext.PostEvent(new LoadingStarted());

        var sw = Stopwatch.StartNew();

        

        //var rendererSymbol = state.OriginalCompilations[state.SelectedProjectName].GetSymbolsWithName(rendererClass);
        //var declaration = rendererSymbol.SelectMany(x => x.DeclaringSyntaxReferences);

//        state.BaseProject = state.SelectedOriginalProject().RemoveDocument(state.SelectedOriginalProject().Documents.SingleOrDefault(x => x.FilePath.Contains(rendererClass)).Id);
//        var baseProjectCompilation = await state.BaseProject.GetCompilationAsync();

//        state.ParentBinary = baseProjectCompilation.EmitToArray();
        var phantomProjectId = ProjectId.CreateNewId();

        var withOriginalProjectReference = state.SelectedOriginalProject().ProjectReferences;//.Append(new ProjectReference(state.SelectedOriginalProject().Id));

        var phantomProjectInfo = ProjectInfo.Create(
            phantomProjectId,
            VersionStamp.Default,
            "Dynamic" + state.SelectedOriginalProject().Name,
            "Dynamic" + state.SelectedOriginalProject().Name,
            "C#",
            projectReferences: withOriginalProjectReference,
            compilationOptions: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary),
            metadataReferences: state.SelectedOriginalProject().MetadataReferences);

        state.DynamicSolution = state.OriginalSolution.AddProject(phantomProjectInfo);

        var phantomProject = state.DynamicSolution.GetProject(phantomProjectInfo.Id);

        foreach (var document in state.SelectedOriginalProject().Documents)
        {
            NamespaceRewriter namespaceRewriter = new NamespaceRewriter();
            var originalSyntaxRoot = await document.GetSyntaxRootAsync();
            var updated = namespaceRewriter.Visit(originalSyntaxRoot);
            var updatedDocument = phantomProject.AddDocument(document.Name, updated);
            phantomProject = document.Project;
            state.DynamicSolution = phantomProject.Solution;
        }

        //var classIndex = 0;
        //foreach (var partialClass in declaration)
        //{
        //    phantomProject = state.DynamicSolution.GetProject(phantomProjectInfo.Id);
        //    classIndex++;

        //    NamespaceRewriter namespaceRewriter = new NamespaceRewriter();
        //    var updated = namespaceRewriter.Visit(partialClass.SyntaxTree.GetRoot());

        //    var document = phantomProject.AddDocument($"_{classIndex}.cs", updated);
        //    phantomProject = document.Project;
        //    state.DynamicSolution = phantomProject.Solution;
        //}

        try
        {
            var phantomCompilation = await phantomProject.GetCompilationAsync();

            foreach (var diagnostic in phantomCompilation.GetDiagnostics())
            {
                Console.WriteLine(diagnostic);
            }

            var loadContext = new AssemblyLoadContext("Renderer_" + rendererClass, false);
            loadContext.Resolving += LoadContext_Resolving;

            //var emitResult = phantomCompilation.Emit("d:\\qwebsolutions\\metapsi\\JustBuildGodDamnIt\\plm");

            //var rendererBinary = phantomCompilation.EmitToArray();
            //var assembly = LoadFromArray(loadContext, rendererBinary);

            var dynDll = $"d:\\qweb\\mes\\Flex\\FlexPortal\\bin\\Debug\\net7.0\\dyn{state.SelectedProjectName}.dll";

            phantomCompilation.Emit(dynDll);



            //foreach (var relatedProject in state.OriginalAssemblies.Values)
            //{
            //    LoadFromArray(loadContext, relatedProject);
            //}

            //loadContext.LoadFromAssemblyPath("c:\\\\Users\\Calin\\.nuget\\packages\\metapsi.hyperapp\\1.6.0\\lib\\net7.0\\Metapsi.Hyperapp.dll");

            //foreach (var related in phantomCompilation.References)
            //{
            //    try
            //    {
            //        //var assemblyFile = Assembly.LoadFile(related.Display);
            //        //loadContext.LoadFromAssemblyName(assemblyFile.GetName());
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}

            while (true)
            {
                try
                {
                    var assembly = loadContext.LoadFromAssemblyPath(dynDll);
                    // get the type Program from the assembly
                    Type programType = assembly.GetTypes().Single(x => x.Name.Contains(rendererClass));

                    var jsModule = string.Empty;// BuildJsModule(programType);

                    commandContext.PostEvent(new RendererGenerated()
                    {
                        RendererName = rendererClass,
                        Js = jsModule,
                        Milliseconds = sw.ElapsedMilliseconds
                    });

                    Console.WriteLine("Renderer generated");

                    break;
                }
                catch (System.IO.FileNotFoundException ex)
                {
                    var relatedProject = state.DynamicSolution.Projects.Single(x => x.Name == ex.FileName.Split(",").First());
                    var relatedCompilation = await relatedProject.GetCompilationAsync();
                    var relatedBinary = relatedCompilation.EmitToArray();
                    LoadFromArray(loadContext, relatedBinary);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    private static Assembly LoadContext_Resolving(AssemblyLoadContext arg1, AssemblyName arg2)
    {
        return Assembly.LoadFrom($"d:\\qweb\\mes\\Flex\\FlexPortal\\bin\\Release\\net7.0\\win10-x64\\{arg2.Name}.dll");

        //var allDlls = System.IO.Directory.GetFiles($"c:\\\\Users\\Calin\\.nuget\\packages\\{arg2.Name}", "*.dll", SearchOption.AllDirectories);

        //foreach (var dll in allDlls)
        //{
        //    var assembly = Assembly.LoadFile(dll);

        //    if (assembly.GetName().Version == arg2.Version)
        //    {
        //        return arg1.LoadFromAssemblyPath(dll);
        //    }
        //}

        //return null;

        //var assemblyPath = $"c:\\\\Users\\Calin\\.nuget\\packages\\{arg2.Name}\\{arg2.Version}\\lib\\net7.0\\{arg2.Name}.dll";
    }

    //public static string BuildJsModule(Type rendererType)
    //{
    //    Stopwatch sw = Stopwatch.StartNew();
    //    IPageBuilder pageBuilder = Activator.CreateInstance(rendererType) as IPageBuilder;
    //    var module = pageBuilder.GetModule();
    //    var jsModule = PrettyBuilder.Generate(module, string.Empty);
    //    var generateElapsed = sw.ElapsedMilliseconds;

    //    Console.WriteLine(jsModule);
    //    Console.WriteLine("Generate all pages " + generateElapsed + " ms");

    //    return jsModule;
    //}

    public static async Task SetInputModel(CommandContext commandContext, State state, string inputModel)
    {
        state.InputModel = inputModel;
    }

    public static string AssemblyName(System.IO.FileNotFoundException ex)
    {
        return ex.FileName.Split(",").First();
    }

    // emit the compilation result into a byte array.
    // throw an exception with corresponding message
    // if there are errors
    public static byte[] EmitToArray
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