using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static partial class Controls
    {
        public static Var<HyperNode> Hidden(this BlockBuilder b)
        {
            return b.Div("hidden");
        }

        public static Var<HyperNode> OptionalText(this BlockBuilder b, Var<string> text, string stylingClasses = null)
        {
            return b.If(b.HasValue(text), b => b.Text(text, stylingClasses), b => b.Hidden());
        }

        public static Var<HyperNode> Optional(this BlockBuilder b, Var<bool> ifValue, System.Func<BlockBuilder, Var<HyperNode>> buildControl)
        {
            return b.If(
                ifValue,
                b => b.Call(buildControl),
                b => b.Hidden());
        }
    }
}

