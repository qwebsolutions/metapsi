using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public static class ExternalFunctions
    {
        public static Var<HyperNode> H(this BlockBuilder b, Var<string> tag, Var<DynamicObject> props, Var<List<HyperNode>> children)
        {
            return b.CallExternal<HyperNode>("hyperapp", "h", tag, props, children);
        }

        public static Var<HyperNode> H(this BlockBuilder b, Var<string> tag, Var<DynamicObject> props, List<Func<BlockBuilder, Var<HyperNode>>> buildChildren)
        {
            var children = b.NewCollection<HyperNode>();
            foreach (var buildChild in buildChildren)
            {
                b.Push(children, b.Call(buildChild));
            }
            return b.H(tag, props, children);
        }

        public static Var<HyperNode> H(this BlockBuilder b, Var<string> tag, Var<DynamicObject> props, params Func<BlockBuilder, Var<HyperNode>>[] buildChildren)
        {
            return b.H(tag, props, buildChildren.ToList());
        }

        public static Var<HyperNode> H(this BlockBuilder b, Var<string> tag, Var<DynamicObject> props)
        {
            return b.CallExternal<HyperNode>("hyperapp", "h", tag, props);
        }

        public static Var<HyperNode> H(this BlockBuilder b, string tag, Var<DynamicObject> props)
        {
            return b.H(b.Const(tag), props);
        }

        public static Var<HyperNode> H(this BlockBuilder b,Var<HParams> hInput, List<Func<BlockBuilder, Var<HyperNode>>> buildChildren)
        {
            return b.H(b.Get(hInput, x => x.Tag), b.Get(hInput, x => x.Props), buildChildren);
        }

        public static Var<HyperNode> H(this BlockBuilder b, Var<HParams> hInput, params Func<BlockBuilder, Var<HyperNode>>[] buildChildren)
        {
            return b.H(b.Get(hInput, x => x.Tag), b.Get(hInput, x => x.Props), buildChildren);
        }
    }
}
