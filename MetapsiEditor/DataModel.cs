using System.Collections.Generic;

namespace Metapsi.Live
{
    public class SymbolKey
    {
        public List<string> ClassPath { get; set; } = new();
        public string Project { get; set; } = string.Empty;
        public string Namespace { get; set; } = string.Empty;
    }

    public class SymbolReference
    {
        public SymbolKey SymbolKey { get; set; }
//        public string Name { get; set; } = string.Empty;
//        public string ProjectName { get; set; } = string.Empty;

        // Could be partial classes
        public List<string> FileNames { get; set; } = new();
    }

    public class RendererReference
    {
        public SymbolReference Renderer { get; set; }
        public SymbolKey Model { get; set; }
    }

    public class RouteReference
    {
        public SymbolReference Route { get; set; }
        public List<SymbolKey> Handlers { get; set; } = new();
    }

    public class HandlerReference
    {
        public SymbolReference Handler { get; set; }
        public SymbolKey Route { get; set; }
    }
}
