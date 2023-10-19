using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    public class LayoutBuilder : BlockBuilder
    {
        public LayoutBuilder() { }

        public LayoutBuilder(BlockBuilder b) : base(b.ModuleBuilder, b.Block) { }
    }

    public static class LayoutBuilderExtensions
    {
        public static Var<IVNode> Render<TData>(this LayoutBuilder b, IControlDefinition<TData> builder, Var<TData> data)
        {
            return b.Call(builder.GetRenderer(), data);
        }

        public static Var<IVNode> FromDefinition<TDefinition, TData>(
            this LayoutBuilder b,
            Func<TDefinition> init,
            Action<ControlBuilder<TDefinition, TData>, Var<TData>> customize = null)
            where TData : new()
            where TDefinition : IControlDefinition<TData>, new()
        {
            var data = b.NewObj<TData>();
            TDefinition controlDefinition = init();
            if (customize != null)
            {
                ControlBuilder<TDefinition, TData> controlBuilder = new(b, controlDefinition, data);
                customize(controlBuilder, data);
            }

            return b.Render(controlDefinition, data);
        }

        public static Var<IVNode> FromDefinition<TDefinition, TData>(
            this LayoutBuilder b,
            Func<TDefinition> init,
            Var<TData> staticData,
            Action<ControlBuilder<TDefinition, TData>, Var<TData>> customize = null)
            where TDefinition : IControlDefinition<TData>, new()
        {
            TDefinition controlDefinition = init();
            if (customize != null)
            {
                ControlBuilder<TDefinition, TData> controlBuilder = new(b, controlDefinition, staticData);
                customize(controlBuilder, staticData);
            }

            return b.Render(controlDefinition, staticData);
        }

        public static Var<IVNode> Optional(this LayoutBuilder b, Var<bool> ifValue, System.Func<LayoutBuilder, Var<IVNode>> buildControl)
        {
            return b.If(
                ifValue,
                b => b.Call(buildControl),
                b => b.H(ViewBuilder.VoidNodeTag, (b, props) => { }));
        }
    }
}
