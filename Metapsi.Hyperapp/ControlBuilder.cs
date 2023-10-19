using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    public class ControlBuilder<TControlDefinition, TData> : BlockBuilder
        where TControlDefinition: IControlDefinition<TData>
    {
        public TControlDefinition Control { get; set; }
        public Var<TData> Data { get; set; }

        public ControlBuilder(
            BlockBuilder b, 
            TControlDefinition controlDefinition,
            Var<TData> data) : base(b.ModuleBuilder, b.Block)
        {
            this.Control = controlDefinition;
            Data = data;
        }
    }

    public static class ControlBuilderExtensions
    {
        public static void OnControl<TParentControlDefinition, TParentData, TChildControlDefinition, TChildData>(
            this ControlBuilder<TParentControlDefinition, TParentData> b,
            Func<TParentControlDefinition, TChildControlDefinition> getChildDefinition,
            System.Linq.Expressions.Expression<Func<TParentData, TChildData>> getChildData,
            Action<ControlBuilder<TChildControlDefinition, TChildData>> action)
            where TParentControlDefinition : IControlDefinition<TParentData>
            where TChildControlDefinition : IControlDefinition<TChildData>
        {
            var childDefinition = getChildDefinition(b.Control);
            var childData = b.Get(b.Data, getChildData);

            ControlBuilder<TChildControlDefinition, TChildData> builder = new(b, childDefinition, childData);
            action(builder);
        }

        public static void AddChild<TData>(
            this ControlBuilder<ControlDefinition<TData>, TData> b,
            Func<LayoutBuilder, Var<TData>, Var<IVNode>> buildChild)
        {
            b.Control.AddChild(buildChild);
        }
    }
}

