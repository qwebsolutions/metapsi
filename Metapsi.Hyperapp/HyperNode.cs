using System.Collections.Generic;

namespace Metapsi.Hyperapp
{
    public class HyperNode
    {
        public string tag { get; set; }
        public DynamicObject props { get; set; } = new DynamicObject();
        public List<HyperNode> children { get; set; }
    }
    public class TextNode
    {
        public string Text { get; set; }
    }
}