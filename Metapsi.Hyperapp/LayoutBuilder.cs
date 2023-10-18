using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public class LayoutBuilder : BlockBuilder
    {
        public LayoutBuilder() { }

        public LayoutBuilder(BlockBuilder b) : base(b.ModuleBuilder, b.Block) { }
    }

    public static class LayoutBuilderExtensions
    {
        public static Var<IVNode> Layout<TData>(this LayoutBuilder b, Var<TData> data, System.Func<LayoutBuilder, Var<TData>, Var<IVNode>> buildLayout)
        {
            return b.Call(buildLayout, data);
        }
    }
}
