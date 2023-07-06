using System.Collections.Generic;

namespace Metapsi.Live
{
    public class SymbolKey
    {
        public List<string> ClassPath { get; set; } = new();
        public string Project { get; set; } = string.Empty;
        public string Namespace { get; set; } = string.Empty;
    }

    public class ProjectReference
    {
        public string Name { get; set; } = string.Empty;
        public string CsprojFilePath { get; set; } = string.Empty;
        public List<string> UsedProjects { get; set; } = new();
        public List<EmbeddedResource> EmbeddedResources { get; set; } = new();
    }

    public class SymbolReference
    {
        public SymbolKey SymbolKey { get; set; }

        // Could be partial classes
        public List<string> FilePaths { get; set; } = new();
    }

    public class RendererReference
    {
        public SymbolReference Renderer { get; set; }
        public SymbolKey Model { get; set; }
    }

    public class RouteReference
    {
        public SymbolReference Route { get; set; }
        //public List<SymbolKey> Handlers { get; set; } = new();
    }

    public class HandlerReference
    {
        public SymbolReference Handler { get; set; }
        public SymbolKey Route { get; set; }
    }

    public class ModelReference
    {
        public SymbolKey Model { get; set; }
    }

    public class SolutionEntities
    {
        public List<ProjectReference> Projects { get; set; } = new();
        public List<HandlerReference> Handlers { get; set; } = new();
        public List<ModelReference> Models { get; set; } = new();
        public List<RendererReference> Renderers { get; set; } = new();
        public List<RouteReference> Routes { get; set; } = new();
    }

    public class CompilationStatus
    {
        public bool IsCompiling { get; set; }
        public string CurrentlyCompiling { get; set; } = string.Empty;
        public List<string> AlreadyCompiled { get; set; } = new();
    }
}
