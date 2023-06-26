using System.Collections.Generic;

namespace Metapsi.Live
{
    public class SymbolReference
    {
        public string Name { get; set; } = string.Empty;
        public string ProjectName { get; set; } = string.Empty;

        // Could be partial classes
        public List<string> FileNames { get; set; } = new();
    }
}
