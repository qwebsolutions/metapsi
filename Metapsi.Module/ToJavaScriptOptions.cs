using System.Linq;

namespace Metapsi.Syntax
{
    public class ToJavaScriptOptions
    {
        public int IndentLevel { get; set; }
        public bool OutputTypes { get; set; }
        public Metapsi.IJsonSerializer JsonSerializer { get; set; }
    }
}