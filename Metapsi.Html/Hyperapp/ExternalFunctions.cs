using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public interface IVNode { }

    public static class ExternalFunctions
    {

        /// <summary>
        /// Creates a text node (leaf node, no children)
        /// </summary>
        /// <param name="b"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Var<IVNode> Text(this LayoutBuilder b, Var<string> text)
        {
            StaticFiles.Add(typeof(Metapsi.Hyperapp.ExternalFunctions).Assembly, "metapsi.core.js");
            StaticFiles.Add(typeof(Metapsi.Hyperapp.ExternalFunctions).Assembly, "linq.js");
            StaticFiles.Add(typeof(Metapsi.Hyperapp.ExternalFunctions).Assembly, "uuid.js");
            StaticFiles.Add(typeof(Metapsi.Hyperapp.ExternalFunctions).Assembly, "hyperapp.js");
            return b.CallExternal<IVNode>("hyperapp", "text", text);
        }

        /// <summary>
        /// Creates a text node (leaf node, no children)
        /// </summary>
        /// <param name="b"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Var<IVNode> Text(this LayoutBuilder b, string text)
        {
            return b.Text(b.Const(text));
        }

        // All parameters

        /// <summary>
        /// Creates a virtual node
        /// </summary>
        /// <param name="b"></param>
        /// <param name="tag"></param>
        /// <param name="props"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        public static Var<IVNode> H(this LayoutBuilder b, Var<string> tag, Var<DynamicObject> props, Var<List<IVNode>> children)
        {
            StaticFiles.Add(typeof(Metapsi.Hyperapp.ExternalFunctions).Assembly, "hyperapp.js");
            return b.CallExternal<IVNode>("hyperapp", "h", tag, props, b.Call(ValidChildren, children));
        }

        public static Var<IVNode> H(this LayoutBuilder b, string tag, Var<DynamicObject> props, Var<List<IVNode>> children)
        {
            return b.H(b.Const(tag), props, children);
        }

        public static Var<IVNode> H(this LayoutBuilder b, Var<string> tag, Var<DynamicObject> props, params Var<IVNode>[] children)
        {
            return b.H(tag, props, b.List(children));
        }

        public static Var<IVNode> H(this LayoutBuilder b, string tag, Var<DynamicObject> props, params Var<IVNode>[] children)
        {
            return b.H(b.Const(tag), props, b.List(children));
        }

        // Without props. Children are optional, so this signatures include the ones without children

        public static Var<IVNode> H(this LayoutBuilder b, Var<string> tag, Var<List<IVNode>> children)
        {
            return b.H(tag, b.NewObj<DynamicObject>(), children);
        }

        public static Var<IVNode> H(this LayoutBuilder b, string tag, Var<List<IVNode>> children)
        {
            return b.H(tag, b.NewObj<DynamicObject>(), children);
        }

        public static Var<IVNode> H(this LayoutBuilder b, Var<string> tag, params Var<IVNode>[] children)
        {
            return b.H(tag, b.NewObj<DynamicObject>(), children);
        }

        public static Var<IVNode> H(this LayoutBuilder b, string tag, params Var<IVNode>[] children)
        {
            return b.H(tag, b.NewObj<DynamicObject>(), children);
        }

        // Just tag

        public static Var<IVNode> H(this LayoutBuilder b, Var<string> tag)
        {
            return b.H(tag, b.NewObj<DynamicObject>());
        }

        public static Var<IVNode> H(this LayoutBuilder b, string tag)
        {
            return b.H(b.Const(tag), b.NewObj<DynamicObject>());
        }

        public static Var<bool> IsVoidNode<TSyntaxBuilder>(this TSyntaxBuilder b, Var<IVNode> node)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.AreEqual(b.GetDynamic(node, DynamicProperty.String("tag")), b.Const(ViewBuilder.VoidNodeTag));
        }

        public static Var<bool> IsValidNode<TSyntaxBuilder>(this TSyntaxBuilder b, Var<IVNode> node)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Not(b.IsVoidNode(node));
        }

        public static Var<List<IVNode>> ValidChildren(this SyntaxBuilder b, Var<List<IVNode>> children)
        {
            return b.Filter(children, IsValidNode);
        }
    }
}
