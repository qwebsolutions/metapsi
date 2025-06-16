using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    public class LayoutBuilder : SyntaxBuilder
    {
        public LayoutBuilder(SyntaxBuilder b) : base(b) { }
        //public override void InitializeFrom(SyntaxBuilder parent)
        //{
        //    base.InitializeFrom(parent);
        //}
    }

    public static partial class LayoutBuilderExtensions
    {
        public static Var<IVNode> Optional(this LayoutBuilder b, Var<bool> ifValue, System.Func<LayoutBuilder, Var<IVNode>> buildControl)
        {
            return b.If(
                ifValue,
                b => b.Call(buildControl),
                b => b.H(ViewBuilder.VoidNodeTag));
        }
    }
}
