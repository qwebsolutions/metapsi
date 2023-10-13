using System.Collections.Generic;

namespace Metapsi.Hyperapp
{
    public class HParams
    {
        public string Tag { get; set; }
        public DynamicObject Props { get; set; } = new();
        //public List<HyperNode> Children { get; set; } = new();
    }

    //public class HParams<TProps>
    //    where TProps : new()
    //{
    //    public string Tag { get; set; }
    //    public TProps Props { get; set; } = new();
    //    public List<HyperNode> Children { get; set; } = new();
    //}

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