using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public interface IVNode { }

    public class PropsBuilder : BlockBuilder
    {
        public Var<DynamicObject> Props { get; set; }
        public PropsBuilder(ModuleBuilder moduleBuilder, Block block) : base(moduleBuilder, block)
        {
            this.Props = this.NewObj<DynamicObject>();
        }

        public PropsBuilder(BlockBuilder b) : this(b.ModuleBuilder, b.Block) { }
    }

    public class LayoutBuilder : BlockBuilder
    {
        public LayoutBuilder(BlockBuilder b) : base(b.ModuleBuilder, b.Block) { }
    }

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
            b.Log(tag, validChildren);
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

        public static Var<IVNode> H(
            this LayoutBuilder b,
            Var<string> tag,
            Action<PropsBuilder> buildProps,
            params Var<IVNode>[] children)
        {
            var propsBuilder = new PropsBuilder(b.ModuleBuilder, b.Block);
            buildProps(propsBuilder);
            return b.H(tag, propsBuilder.Props, b.List(children));
        }

        public static Var<IVNode> H(
            this LayoutBuilder b,
            string tag,
            Action<PropsBuilder> buildProps,
            params Var<IVNode>[] children)
        {
            return b.H(b.Const(tag), buildProps, children);
        }

        public static Var<bool> IsVoidNode<TBlockBuilder>(this TBlockBuilder b, Var<IVNode> node)
            where TBlockBuilder: BlockBuilder
        {
            return b.AreEqual(b.GetDynamic(node, DynamicProperty.String("tag")), b.Const(ViewBuilder.VoidNodeTag));
        }

        public static Var<bool> IsValidNode<TBlockBuilder>(this TBlockBuilder b, Var<IVNode> node)
            where TBlockBuilder: BlockBuilder
        {
            return b.Not(b.IsVoidNode(node));
        }
    }
}
