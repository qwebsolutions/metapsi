﻿using Microsoft.CodeAnalysis;
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
using Microsoft.CodeAnalysis.FindSymbols;
using Microsoft.AspNetCore.WebUtilities;
using Metapsi.Live;

public record EmbeddedResource(string Path, string LogicalName);

public static class CompileEnvironment
{
    public record FileChanged : IData
    {
        public string FilePath { get; set; }
        public string ProjectName { get; set; }
    }

    //public class HandlerSymbol
    //{
    //    public TypeReference Symbol { get; set; }
    //    public ITypeSymbol RouteType { get; set; }
    //}


    //public class TypeReference
    //{
    //    public string ProjectName { get; set; }
    //    public string FilePath { get; set; }
    //    public INamedTypeSymbol Symbol { get; set; }
    //}

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
        public Dictionary<string, byte[]> DynamicAssemblies = new();
        //public List<TypeReference> Routes { get; set; } = new();
        //public List<HandlerSymbol> Handlers { get; set; } = new();
        //public List<TypeReference> Renderers { get; set; } = new();
        //public HashSet<EmbeddedResource> EmbeddedResources { get; set; } = new();

        //public AssemblyLoadContext OriginalLoadContext = new("original");

        public Project BaseProject { get; set; } // Stripped of separate 'focus' class
        public Project ChildProject { get; set; } // Temporary project for the 'focus' class
        public string RendererName { get; set; }
        public byte[] ParentBinary { get; set; }

        public string InputModel { get; set; }

        public SolutionEntities SolutionEntities { get; set; }

        public Dictionary<string, FileSystemWatcher> Watchers { get; set; } = new();
        public HashSet<string> AllDocumentPaths { get; set; } = new();
        public HashSet<FileChanged> ChangedSinceLastCompilation { get; set; } = new();
    }

    public static async Task InitSolution(CommandContext commandContext, State state, string slnPath)
    {
        SolutionEntities solutionEntities = new();

        List<string> routeInterfaceNames = new List<string>()
        {
            "IGet",
            "IPost"
        };

        if (state.OriginalSolution?.FilePath == slnPath)
        {
            Console.WriteLine("Solution already selected");
            return;
        }

        commandContext.PostEvent(new LoadingStarted());
        var sw = Stopwatch.StartNew();

        var workspace = MSBuildWorkspace.Create();
        state.OriginalSolution = await workspace.OpenSolutionAsync(slnPath);
        state.DynamicSolution = state.OriginalSolution;

        commandContext.PostEvent(new SolutionParsed() { TotalProjects = state.OriginalSolution.Projects.Count() });

        var deps = state.OriginalSolution.GetProjectDependencyGraph();
        Console.WriteLine($"Solution {sw.ElapsedMilliseconds} ms");
        foreach (var project in state.OriginalSolution.Projects)
        {
            commandContext.PostEvent(new StartedProjectCompile() { ProjectName = project.Name });

            state.OriginalCompilations[project.Name] = await project.GetCompilationAsync();

            var compilation = state.OriginalCompilations[project.Name].EmitToArray();

            if (compilation.Errors.Any())
            {
                solutionEntities.Errors.AddRange(compilation.Errors.Select(x => new CompilationError()
                {
                    ErrorMessage = x.ToString(),
                    ProjectName = project.Name,
                    FileName = x.Location.SourceTree.FilePath
                }));
            }
            else
            {
                commandContext.PostEvent(new FinishedProjectCompile() { ProjectName = project.Name });

                state.OriginalAssemblies[project.Name] = state.OriginalCompilations[project.Name].EmitToArray().Assembly;
                state.DynamicAssemblies[project.Name] = state.OriginalAssemblies[project.Name];

                //var embeddedResources = GetEmbeddedResources(project);

                //foreach (var embeddedResource in embeddedResources)
                //{
                //    state.EmbeddedResources.Add(embeddedResource);
                //}

                foreach (var document in project.Documents)
                {
                    if (document.FilePath.EndsWith(".cs"))
                    {
                        var syntaxTree = await document.GetSyntaxTreeAsync();

                        var semanticModel = await document.GetSemanticModelAsync();

                        var routesVisitor = new ClassVisitor();
                        routesVisitor.Visit(syntaxTree.GetRoot());
                        foreach (var classDeclaration in routesVisitor.ClassDeclarations)
                        {
                            var classSymbol = semanticModel.GetDeclaredSymbol(classDeclaration);

                            var apis = await GetApiDeclarations(classSymbol, state.OriginalSolution);

                            foreach (var api in apis)
                            {
                                Console.WriteLine($"==== {Metapsi.Serialize.ToJson(api)}");
                            }


                            var allInterfaces = classSymbol.AllInterfaces;
                            if (allInterfaces.Any(x => routeInterfaceNames.Contains(x.Name)))
                            {
                                var routeSymbolKey = GetSymbolKey(classSymbol);

                                var partialRoute = solutionEntities.Routes.SingleOrDefault(x => SymbolKeysEqual(routeSymbolKey, x.Route.SymbolKey));

                                if (partialRoute != null)
                                {
                                    partialRoute.Route.FilePaths.Add(document.FilePath);
                                }
                                else
                                {
                                    var route = new SymbolReference() { SymbolKey = routeSymbolKey };

                                    route.FilePaths.Add(document.FilePath);
                                    solutionEntities.Routes.Add(new RouteReference()
                                    {
                                        Route = route
                                    });
                                }
                            }

                            if (IsRouteHandler(classSymbol))
                            {
                                var handlerSymbolKey = GetSymbolKey(classSymbol);

                                var partialHandler = solutionEntities.Handlers.SingleOrDefault(x => SymbolKeysEqual(handlerSymbolKey, x.Handler.SymbolKey));

                                if (partialHandler != null)
                                {
                                    partialHandler.Handler.FilePaths.Add(document.FilePath);
                                }
                                else
                                {
                                    var handler = new SymbolReference() { SymbolKey = handlerSymbolKey };
                                    handler.FilePaths.Add(document.FilePath);

                                    var handlerReference = new HandlerReference()
                                    {
                                        Handler = handler,
                                        Route = GetSymbolKey(classSymbol.BaseType.TypeArguments.First())
                                    };

                                    solutionEntities.Handlers.Add(handlerReference);

                                    var allDescendants = classDeclaration.DescendantNodes();
                                    var allMethods = allDescendants.OfType<MethodDeclarationSyntax>();
                                    var httpHandlerMethods = allMethods.Where(x => x.Identifier.Text == "OnGet" || x.Identifier.Text == "OnPost");

                                    foreach (var httpMethod in httpHandlerMethods)
                                    {
                                        var pageResults = httpMethod.DescendantNodes().OfType<InvocationExpressionSyntax>().Where(IsPageResultCall);
                                        //var allInvocations = getMethod.DescendantNodes().OfType<InvocationExpressionSyntax>();

                                        foreach (var invocation in pageResults)
                                        {
                                            if (invocation.ArgumentList.Arguments.Count() == 1)
                                            {
                                                var pageModelType = semanticModel.GetTypeInfo(invocation.ArgumentList.Arguments.Single().Expression);

                                                if (pageModelType.Type != null)
                                                {
                                                    handlerReference.ReturnModelType = GetSymbolKey(pageModelType.Type);
                                                }
                                            }
                                        }

                                        var contextCalls = httpMethod.DescendantNodes().OfType<InvocationExpressionSyntax>().Where(IsCommandContextCall);

                                        foreach (var contextCall in contextCalls)
                                        {
                                            handlerReference.CommandContextCalls.Add(contextCall.ArgumentList.Arguments.First().Expression.ToString());
                                        }
                                    }
                                }
                            }

                            if (allInterfaces.Any(x => x.Name == "IPageTemplate"))
                            {
                                if (classSymbol.BaseType.TypeArguments.Count() >= 1)
                                {

                                    var rendererSymbolKey = GetSymbolKey(classSymbol);

                                    var partialRenderer = solutionEntities.Renderers.SingleOrDefault(x => SymbolKeysEqual(rendererSymbolKey, x.Renderer.SymbolKey));

                                    if (partialRenderer != null)
                                    {
                                        partialRenderer.Renderer.FilePaths.Add(document.FilePath);
                                    }
                                    else
                                    {
                                        var renderer = new SymbolReference() { SymbolKey = rendererSymbolKey };
                                        renderer.FilePaths.Add(document.FilePath);

                                        solutionEntities.Renderers.Add(new RendererReference()
                                        {
                                            Renderer = renderer,
                                            Model = GetSymbolKey(classSymbol.BaseType.TypeArguments.First())
                                        });
                                    }

                                    await RecursiveCalls(classSymbol, document, state.OriginalSolution, si =>
                                    {
                                        if (si.Symbol.Name == "Url")
                                        {
                                            Console.WriteLine("==============================");
                                        }
                                    });
                                }
                            }
                        }
                    }

                    state.AllDocumentPaths.Add(document.FilePath);


                    var dirName = System.IO.Path.GetDirectoryName(document.FilePath);

                    if (!state.Watchers.ContainsKey(dirName))
                    {

                        AddWatcher(commandContext, state, project, dirName);
                    }
                }

                solutionEntities.Projects.Add(new Metapsi.Live.ProjectReference()
                {
                    Name = project.Name,
                    CsprojFilePath = project.FilePath,
                    UsedProjects = project.ProjectReferences.Select(x => state.OriginalSolution.Projects.Single(p => p.Id == x.ProjectId).Name).ToList(),
                    EmbeddedResources = GetEmbeddedResources(project)
                });

                commandContext.PostEvent(new FinishedProjectCompile() { ProjectName = project.Name });

            }
        }
        List<Metapsi.Live.SymbolReference> renderers = new();

        //foreach (var rendererReference in state.Renderers)
        //{
        //    var rendererData = renderers.SingleOrDefault(x => x.SymbolKey.ClassPath.Last() == rendererReference.Symbol.Name);
        //    if (rendererData == null)
        //    {
        //        rendererData = new Metapsi.Live.SymbolReference()
        //        {
        //            SymbolKey = GetSymbolKey(rendererReference.Symbol)
        //        };
        //        renderers.Add(rendererData);
        //    }

        //    rendererData.FileNames.Add(rendererReference.FilePath);
        //}

        state.SolutionEntities = solutionEntities;

        commandContext.PostEvent(new SolutionCompiled()
        {
            SolutionEntities = solutionEntities
        });
    }

    public static void AddWatcher(
        CommandContext commandContext,
        State state,
        Project project,
        string dirName)
    {
        var changed = (string filePath) =>
        {
            try
            {
                if (state.AllDocumentPaths.Contains(filePath))
                {
                    commandContext.PostEvent(new FileChanged()
                    {
                        FilePath = filePath,
                        ProjectName = project.Name
                    });
                }
            }
            catch
            {
            }
        };

        if (!state.Watchers.ContainsKey(dirName))
        {
            var watcher = new FileSystemWatcher(dirName);
            watcher.NotifyFilter = NotifyFilters.Attributes
                     | NotifyFilters.CreationTime
                     | NotifyFilters.DirectoryName
                     | NotifyFilters.FileName
                     | NotifyFilters.LastAccess
                     | NotifyFilters.LastWrite
                     | NotifyFilters.Security
                     | NotifyFilters.Size;
            watcher.IncludeSubdirectories = false;
            watcher.Changed += (o, e) => changed(e.FullPath);
            watcher.Renamed += (o, e) => changed(e.OldFullPath);
            watcher.Created += (o, e) => changed(e.FullPath);
            watcher.Deleted += (o, e) => changed(e.FullPath);
            watcher.EnableRaisingEvents = true;
            state.Watchers[dirName] = watcher;
        }
    }

    public static async Task RecursiveCalls(INamedTypeSymbol rendererClass, Document document, Solution solution, Action<SymbolInfo> onCall)
    {
        var syntaxTree = await document.GetSyntaxTreeAsync();
        var semanticModel = await document.GetSemanticModelAsync();

        var allMembers = rendererClass.GetMembers();

        foreach (var member in allMembers)
        {
            if (member.Name == "OnRender")
            {
                var declaration = member.DeclaringSyntaxReferences.First();

                var rendererClassDeclaration = syntaxTree.GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>().Where(x => x.Identifier.Text == rendererClass.Name);

                if (rendererClassDeclaration.Count() == 1)
                {
                    var methods = rendererClassDeclaration.First().DescendantNodes().OfType<MethodDeclarationSyntax>();

                    var onRender = methods.Where(sn => sn.Identifier.Text == "OnRender");

                    if (onRender.Count() == 1)
                    {
                        var calls = onRender.First().DescendantNodes().OfType<InvocationExpressionSyntax>();

                        foreach (var call in calls)
                        {
                            if (call.Expression is MemberAccessExpressionSyntax)
                            {
                                var access = call.Expression as MemberAccessExpressionSyntax;
                                if (access.Name.ToString().Contains("Url"))
                                {
                                    Console.WriteLine($"======== Renderer {rendererClass.Name} {call}");
                                }
                            }

                            var callInfo = semanticModel.GetSymbolInfo(call);

                            if (callInfo.Symbol != null)
                            {
                                if (!IsFrameworkNamespace(callInfo.Symbol.ContainingNamespace.ToString()))
                                {
                                    await RecursiveCalls(callInfo, solution, onCall);
                                }
                            }
                        }
                    }

                }
            }
        }
    }

    public static async Task RecursiveCalls(SymbolInfo call, Solution solution, Action<SymbolInfo> onCall)
    {
        if (call.Symbol.DeclaringSyntaxReferences.Count() == 1)
        {
            var document = solution.GetDocument(call.Symbol.DeclaringSyntaxReferences.Single().SyntaxTree);
            var semanticModel = await document.GetSemanticModelAsync();
            var methodSyntax = call.Symbol.DeclaringSyntaxReferences.Single().GetSyntax();
            var calls = methodSyntax.DescendantNodes().OfType<InvocationExpressionSyntax>();

            foreach (var innerCall in calls)
            {
                var innerCallSymbol = semanticModel.GetSymbolInfo(innerCall);

                if (innerCallSymbol.Symbol != null)
                {
                    if (!IsFrameworkNamespace(innerCallSymbol.Symbol.ContainingNamespace.ToString()))
                    {
                        await RecursiveCalls(innerCallSymbol, solution, onCall);
                    }
                }
            }
        }
    }

    public static bool IsFrameworkNamespace(string ns)
    {
        if (ns.StartsWith("Metapsi"))
            return true;

        if (ns.StartsWith("System"))
            return true;

        return false;
    }

    public enum ApiType
    {
        Request,
        Command
    }

    public class Api
    {
        public ApiType ApiType { get; set; }
        public string Name { get; set; }
        public List<string> Parameters { get; set; } = new();
    }

    private static async Task<List<Api>> GetApiDeclarations(INamedTypeSymbol classDeclaration, Solution sln)
    {
        List<Api> apis = new List<Api>();
        var members = classDeclaration.GetMembers();
        foreach(var member in members)
        {
            if(member is IPropertySymbol)
            {
                var property = member as IPropertySymbol;
                if (property.Type.Name == "Request" && property.Type.ContainingNamespace.Name == "Metapsi")
                {
                    INamedTypeSymbol genericType = property.Type as INamedTypeSymbol;

                    if (genericType != null)
                    {

                        var references = await SymbolFinder.FindReferencesAsync(property, sln);

                        foreach (var reference in references)
                        {
                            foreach (var location in reference.Locations)
                            {
                                var syntaxTree = await location.Document.GetSyntaxTreeAsync();
                                var syntaxNode = syntaxTree.GetRoot().FindNode(location.Location.SourceSpan);

                                if (IsCommandContextCall(syntaxNode))
                                {
                                    Console.WriteLine(location.Document.FilePath);
                                }

                                //var something = location.Location.SourceTree.GetLineSpan(location.Location.SourceSpan);
                                //var semanticDoc = await location.Document.GetSemanticModelAsync();
                                //var syntaxNode = location.Location.SourceTree.GetRoot().FindNode(location.Location.SourceSpan);
                                //semanticDoc.GetSymbolInfo( location.Location.SourceSpan);
                            }
                        }

                        apis.Add(new Api()
                        {
                            ApiType = ApiType.Request,
                            Name = property.Name,
                            Parameters = genericType.TypeArguments.Select(x => x.Name).ToList()
                        });
                    }
                }

                if (property.Type.Name == "Command" && property.Type.ContainingNamespace.Name == "Metapsi")
                {
                    INamedTypeSymbol genericType = property.Type as INamedTypeSymbol;

                    if (genericType != null)
                    {
                        apis.Add(new Api()
                        {
                            ApiType = ApiType.Command,
                            Name = property.Name,
                            Parameters = genericType.TypeArguments.Select(x => x.Name).ToList()
                        });
                    }
                }
            }
        }

        return apis;
    }

    public static bool IsCommandContextCall(SyntaxNode syntaxNode)
    {
        if (syntaxNode is IdentifierNameSyntax)
        {
            if(syntaxNode.Parent is MemberAccessExpressionSyntax)
            {
                if(syntaxNode.Parent.Parent is ArgumentSyntax)
                {
                    if(syntaxNode.Parent.Parent.Parent is ArgumentListSyntax)
                    {
                        if(syntaxNode.Parent.Parent.Parent.Parent is InvocationExpressionSyntax)
                        {
                            var invocation = syntaxNode.Parent.Parent.Parent.Parent as InvocationExpressionSyntax;
                            var memberAccess = invocation.Expression as MemberAccessExpressionSyntax;
                            if (memberAccess.Name.Identifier.Text == "Do")
                            {
                                return true;
                            }
                        }
                    }
                }
            }
        }
        return false;
    }

    public static bool IsCommandContextCall(InvocationExpressionSyntax invocation)
    {
        var memberAccess = invocation.Expression as MemberAccessExpressionSyntax;

        if (memberAccess == null)
            return false;

        if (memberAccess.Name.Identifier.Text == "Do")
        {
            return true;
        }

        return false;
    }

    public static bool IsPageResultCall(InvocationExpressionSyntax expressionSyntax)
    {
        if (!(expressionSyntax is InvocationExpressionSyntax))
            return false;

        if (!(expressionSyntax.Expression is MemberAccessExpressionSyntax))
            return false;

        var pageResultCall = expressionSyntax.Expression as MemberAccessExpressionSyntax;

        if (pageResultCall.Expression.ToString() != "Page")
            return false;

        if (pageResultCall.Name.Identifier.Text != "Result")
            return false;

        return true;
    }

    public static SymbolKey GetSymbolKey(ITypeSymbol symbol)
    {

        //List<string> namespaces = new List<string>();

        //var constituentNamespaces = symbol.ContainingNamespace.ConstituentNamespaces;

        //INamespaceSymbol containingNamespace = symbol.ContainingNamespace;

        //while (true)
        //{
        //    if (containingNamespace == null)
        //        break;

        //    if (string.IsNullOrEmpty(containingNamespace.Name))
        //        break;

        //    namespaces.Add(containingNamespace.Name);

        //    containingNamespace = containingNamespace.ContainingNamespace;
        //}

        //namespaces.Reverse();

        //var recursiveNamespace = string.Join(".", namespaces);

        return new SymbolKey()
        {
            ClassPath = GetClassPath(symbol),
            Namespace = symbol.ContainingNamespace?.ToString(),
            Project = symbol.ContainingAssembly?.Name
        };
    }

    public static SymbolKey GetSymbolKey(System.Type type)
    {
        if (type == null)
            return new SymbolKey();

        if (type.AssemblyQualifiedName.Contains("List"))
        {
            Console.WriteLine(type);
        }

        var sk = new SymbolKey()
        {
            ClassPath = GetClassPath(type),
            Namespace = type.Namespace,
            Project = type.Assembly.GetName().Name
        };

        return sk;
    }

    public static bool SymbolKeysEqual(SymbolKey first, SymbolKey second)
    {
        if (first == null)
            return false;

        if (second == null)
            return false;

        if (first.Project != second.Project)
            return false;

        if (first.Namespace != second.Namespace)
            return false;

        if (string.Join(".", first.ClassPath) != string.Join(".", second.ClassPath))
            return false;

        return true;
    }

    public static List<string> GetClassPath(ITypeSymbol symbol)
    {
        List<string> classPath = new();

        while (true)
        {
            if (symbol == null)
                break;
            classPath.Add(symbol.Name);
            symbol = symbol.ContainingType;
        }

        classPath.Reverse();
        return classPath;
    }

    public static List<string> GetClassPath(System.Type type)
    {
        List<string> classPath = new();

        while (true)
        {
            if (type == null)
                break;
            classPath.Add(type.Name);
            type = type.DeclaringType;
        }

        classPath.Reverse();
        return classPath;
    }

    private static bool IsRouteHandler(INamedTypeSymbol symbol)
    {
        if (symbol.BaseType == null)
            return false;

        if (symbol.BaseType.ContainingType == null)
            return false;

        if (symbol.BaseType.ContainingType.Name != "Http")
            return false;

        if (symbol.BaseType.ContainingNamespace.Name != "Metapsi")
            return false;

        return true;
    }

    private static List<EmbeddedResource> GetEmbeddedResources(Project project)
    {
        List<EmbeddedResource> embeddedResources = new();

        System.Xml.Linq.XDocument xmldoc = System.Xml.Linq.XDocument.Load(project.FilePath);

        foreach (var resource in xmldoc.Descendants("EmbeddedResource"))
        {
            var includeAttribute = resource.Attribute("Include");
            if (includeAttribute != null)
            {
                string includePath = resource.Attribute("Include").Value;
                string logicalName = resource.Attribute("LogicalName").Value;

                var qualifiedIncludePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(project.FilePath), includePath);

                embeddedResources.Add(new EmbeddedResource(qualifiedIncludePath, logicalName));
            }
        }

        return embeddedResources;
    }

    public static async Task<string> CreateEmptyModel(CommandContext commandContext, State state, SymbolKey renderer)
    {
        var sw = Stopwatch.StartNew();

        var rendererReference = state.SolutionEntities.Renderers.Single(x => SymbolKeysEqual(renderer, x.Renderer.SymbolKey));

        var originalProject = state.OriginalSolution.Projects.Single(x => x.Name == renderer.Project);

        var updatedProject = originalProject;

        // Refresh files
        foreach (var filePath in rendererReference.Renderer.FilePaths)
        {
            var originalDocument = originalProject.Documents.Single(x => x.FilePath == filePath);
            updatedProject = originalProject.RemoveDocument(originalDocument.Id);
            var newDocument = updatedProject.AddDocument(originalDocument.Name, await System.IO.File.ReadAllTextAsync(originalDocument.FilePath));
            updatedProject = newDocument.Project;
        }

        var updatedCompilation = await updatedProject.GetCompilationAsync();

        var binary = updatedCompilation.EmitToArray();

        var assemblyLoadContext = new AssemblyLoadContext("preview_" + renderer.Project);
        var reloadedBinary = LoadFromArray(assemblyLoadContext, binary.Assembly);
        var relatedAssemblies = state.OriginalAssemblies.Where(x => x.Key != renderer.Project);

        foreach (var assembly in relatedAssemblies)
        {
            LoadFromArray(assemblyLoadContext, assembly.Value);
        }

        var rendererType = reloadedBinary.DefinedTypes.Where(x => SymbolKeysEqual(GetSymbolKey(x), renderer)).Single();
        var renderMethod = rendererType.GetMethods().Single(x => x.Name == "Render" && x.ReturnType == typeof(string) && x.GetParameters().Count() == 1);

        //var inputJson = await System.IO.File.ReadAllTextAsync("D:\\qwebsolutions\\metapsi\\MetapsiEditor\\input.json");

        var modelType = renderMethod.GetParameters().First().ParameterType;


        var emptyModel = Activator.CreateInstance(modelType);
        var loadedMetapsiRuntime = assemblyLoadContext.Assemblies.Single(x => x.GetName().Name == "Metapsi.Runtime");
        var metapsiRuntimeTypes = loadedMetapsiRuntime.GetTypes();
        var serializerType = metapsiRuntimeTypes.Single(x => x.Name == "Serialize");
        var serializerMethod = serializerType.GetMethods().Single(x => x.Name == "ToJson");

        string serialized = serializerMethod.Invoke(null, new object[] { emptyModel }) as string;

        return serialized;
    }

    public static async Task<string> PreviewRenderer(CommandContext commandContext, State state, SymbolKey renderer, string inputJson)
    {
        var sw = Stopwatch.StartNew();

        var rendererReference = state.SolutionEntities.Renderers.SingleOrDefault(x => SymbolKeysEqual(renderer, x.Renderer.SymbolKey));

        if (rendererReference == null || string.IsNullOrEmpty(inputJson))
        {
            return "<html> <head> <title> Preview renderer</title> </head> <body style=\"width:100%;height:100%\"> No page selected </body> </html>";
        }

        try
        {
            // Refresh files
            foreach (var change in state.ChangedSinceLastCompilation)
            {
                var project = state.DynamicSolution.Projects.Single(x => x.Name == change.ProjectName);
                var document = project.Documents.Single(x => x.FilePath == change.FilePath);
                var updatedProject = project.RemoveDocument(document.Id);
                var updatedDocument = updatedProject.AddDocument(
                    document.Name,
                    await System.IO.File.ReadAllTextAsync(document.FilePath),
                    filePath: change.FilePath);
                state.DynamicSolution = updatedDocument.Project.Solution;

                //var originalDocument = originalProject.Documents.Single(x => x.FilePath == filePath);
                //updatedProject = originalProject.RemoveDocument(originalDocument.Id);
                //var newDocument = updatedProject.AddDocument(originalDocument.Name, await System.IO.File.ReadAllTextAsync(originalDocument.FilePath));
                //updatedProject = newDocument.Project;
            }

            foreach (var changedProjectName in state.ChangedSinceLastCompilation.Select(x => x.ProjectName).Distinct())
            {
                var project = state.DynamicSolution.Projects.Single(x => x.Name == changedProjectName);
                var projectCompilation = await project.GetCompilationAsync();
                var projectBinary = projectCompilation.EmitToArray();
                state.DynamicAssemblies[changedProjectName] = projectBinary.Assembly;
            }

            //var originalProject = state.OriginalSolution.Projects.Single(x => x.Name == renderer.Project);

            //var updatedProject = originalProject;

            var assemblyLoadContext = new AssemblyLoadContext("preview_" + renderer.Project);
            var reloadedBinary = LoadFromArray(assemblyLoadContext, state.DynamicAssemblies[renderer.Project]);
            var relatedAssemblies = state.DynamicAssemblies.Where(x => x.Key != renderer.Project);

            foreach (var assembly in relatedAssemblies)
            {
                LoadFromArray(assemblyLoadContext, assembly.Value);
            }

            var rendererType = reloadedBinary.DefinedTypes.Where(x => SymbolKeysEqual(GetSymbolKey(x.UnderlyingSystemType), renderer)).Single();
            var renderMethod = rendererType.GetMethods().Single(x => x.Name == "Render" && x.ReturnType == typeof(string) && x.GetParameters().Count() == 1);

            //var inputJson = await System.IO.File.ReadAllTextAsync("D:\\qwebsolutions\\metapsi\\MetapsiEditor\\input.json");

            var modelType = renderMethod.GetParameters().First().ParameterType;

            var loadedMetapsiRuntime = assemblyLoadContext.Assemblies.Single(x => x.GetName().Name == "Metapsi.Runtime");

            var metapsiRuntimeTypes = loadedMetapsiRuntime.GetTypes();
            var deserializerType = metapsiRuntimeTypes.Single(x => x.Name == "Serialize");
            var deserializerMethod = deserializerType.GetMethods().Single(x => x.Name == "FromJson" && x.GetParameters().First().ParameterType.Name == "Type");
            var inputObject = deserializerMethod.Invoke(null, new object[] { modelType, inputJson });

            //var inputObject = Metapsi.Serialize.FromJson(renderMethod.GetParameters().First().ParameterType, inputJson);

            var result = renderMethod.Invoke(Activator.CreateInstance(rendererType), new object[] { inputObject });

            Console.WriteLine($"Recompiled in {sw.ElapsedMilliseconds} ms");

            state.ChangedSinceLastCompilation = new();

            return result as string;
        }
        catch (Exception ex)
        {
            return $"<html> <head> <title> Preview exception </title> </head> <body style=\"width:100%;height:100%\"> <pre>{ex.ToString()}</pre></body> </html>";
        }
    }

    public static string RouteSymbolToPath(INamedTypeSymbol symbol)
    {
        if (symbol.ContainingType != null)
        {
            return $"{symbol.ContainingType.Name}/{symbol.Name}";
        }
        else
        {
            return symbol.Name;
        }
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

    //public static async Task SwitchProject(CommandContext commandContext, State state, string projectName)
    //{
    //    commandContext.PostEvent(new LoadingStarted());

    //    state.SelectedProjectName = projectName;

    //    List<string> renderers = new();

    //    //var dict = new System.Collections.Generic.Dictionary<string, string>();
    //    //var taskItemOutputs = new System.Collections.Generic.Dictionary<string, ITaskItem>();

    //    //var msBuild = new MSBuild();
    //    //msBuild.Projects = new ITaskItem[] {new TaskItem().}

    //    //var whatever = new MSBuild().BuildEngine.BuildProjectFile(
    //    //    state.SelectedOriginalProject().FilePath,
    //    //    new string[] { "net7.0" },
    //    //    dict,
    //    //    taskItemOutputs);

    //    var process = System.Diagnostics.Process.Start(
    //        new ProcessStartInfo()
    //        {
    //            FileName = "dotnet",
    //            Arguments = $"build {state.SelectedOriginalProject().FilePath} -c Release -r win10-x64"
    //        });

    //    await process.WaitForExitAsync();

    //    foreach (var document in state.SelectedOriginalProject().Documents)
    //    {
    //        if (document.FilePath.EndsWith(".cs"))
    //        {
    //            var syntaxTree = await document.GetSyntaxTreeAsync();

    //            var semanticModel = await document.GetSemanticModelAsync();

    //            var renderersVisitor = new ClassVisitor();
    //            renderersVisitor.Visit(syntaxTree.GetRoot());
    //            foreach (var classDeclaration in renderersVisitor.ClassDeclarations)
    //            {
    //                var classSymbol = semanticModel.GetDeclaredSymbol(classDeclaration);
    //                var allInterfaces = classSymbol.AllInterfaces;
    //                if (allInterfaces.Any(x => x.Name == "IPageBuilder"))
    //                {
    //                    renderers.Add(classSymbol.Name);
    //                }
    //            }
    //        }
    //    }

    //    Console.WriteLine("Project switched");

    //    commandContext.PostEvent(new ProjectLoaded()
    //    {
    //        Renderers = renderers
    //    });

    //    //var originalAssembly = state.OriginalLoadContext.Assemblies.Single(x => x.GetName().Name == projectName);
    //    //var allTypes = originalAssembly.DefinedTypes;
    //}

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
                    LoadFromArray(loadContext, relatedBinary.Assembly);
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

    public class EmitResult
    {
        public byte[] Assembly { get; set; }
        public List<Diagnostic> Errors { get; set; } = new ();
    }

    public static EmitResult EmitToArray(this Compilation compilation)
    {
        var stream = new MemoryStream();
        // emit result into a stream
        var emitResult = compilation.Emit(stream);

        if (!emitResult.Success)
        {
            return new EmitResult()
            {
                Errors = emitResult.Diagnostics.Where(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error).ToList()
            };
        }
        else
        {
            stream.Seek(0, SeekOrigin.Begin);
            // get the byte array from a stream
            return new EmitResult() { Assembly = stream.ToArray() };
        }
    }

    private static Assembly LoadFromArray(AssemblyLoadContext assemblyLoadContext, byte[] binaries)
    {
        var ms = new MemoryStream();
        ms.Write(binaries);
        ms.Seek(0, SeekOrigin.Begin);
        return assemblyLoadContext.LoadFromStream(ms);
    }
}

public class ProjectCompilationException : System.Exception
{
    public List<Diagnostic> Errors { get; set; } = new();
}