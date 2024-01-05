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
        public static Var<IVNode> T(this LayoutBuilder b, Var<string> text)
        {
            return b.CallExternal<IVNode>("hyperapp", "text", text);
        }

        /// <summary>
        /// Creates a text node (leaf node, no children)
        /// </summary>
        /// <param name="b"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Var<IVNode> T(this LayoutBuilder b, string text)
        {
            return b.T(b.Const(text));
        }

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
            var validChildren = b.Filter(children, Metapsi.Hyperapp.ExternalFunctions.IsValidNode);
            return b.CallExternal<IVNode>("hyperapp", "h", tag, props, validChildren);
        }


        public static Var<IVNode> H(this LayoutBuilder b, string tag, Var<DynamicObject> props, Var<List<IVNode>> children)
        {
            return b.H(b.Const(tag), props, children);
        }


        public static Var<IVNode> H(this LayoutBuilder b, string tag, Var<DynamicObject> props, params Var<IVNode>[] children)
        {
            return b.H(b.Const(tag), props, b.List(children));
        }

        public static Var<IVNode> Div(this LayoutBuilder b, Var<DynamicObject> props, params Var<IVNode>[] children)
        {
            return b.H(b.Const("div"), props, b.List(children));
        }

        public static Var<IVNode> Button(this LayoutBuilder b, Var<DynamicObject> props, params Var<IVNode>[] children)
        {
            return b.H(b.Const("button"), props, b.List(children));
        }

        public static Var<IVNode> Button(this LayoutBuilder b, Action<PropsBuilder, Var<DynamicObject>> buildProps, params Var<IVNode>[] children)
        {
            return b.H(b.Const("button"), buildProps, children);
        }

        public static Var<IVNode> H(this LayoutBuilder b, string tag, Action<PropsBuilder, Var<DynamicObject>> buildProps, Var<List<IVNode>> children)
        {
            return b.H(b.Const(tag), buildProps, children);
        }

        public static Var<DynamicObject> EmptyProps(this LayoutBuilder b)
        {
            return b.NewObj<DynamicObject>();
        }

        public static Var<IVNode> H(
            this LayoutBuilder b,
            Var<string> tag,
            Action<PropsBuilder, Var<DynamicObject>> buildProps,
            params Var<IVNode>[] children)
        {
            var propsBuilder = new PropsBuilder(b);
            var props = propsBuilder.NewObj<DynamicObject>();
            buildProps(propsBuilder, props);
            return b.H(tag, props, b.List(children));
        }

        public static Var<IVNode> H(
            this LayoutBuilder b,
            Var<string> tag,
            Action<PropsBuilder, Var<DynamicObject>> buildProps,
            Var<List<IVNode>> children)
        {
            var propsBuilder = new PropsBuilder(b);
            var props = propsBuilder.NewObj<DynamicObject>();
            buildProps(propsBuilder, props);
            return b.H(tag, props, children);
        }

        public static Var<IVNode> H(
            this LayoutBuilder b,
            string tag,
            Action<PropsBuilder, Var<DynamicObject>> buildProps,
            params Var<IVNode>[] children)
        {
            return b.H(b.Const(tag), buildProps, children);
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
    }
}
