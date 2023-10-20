﻿using Metapsi.Syntax;
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
            Func<TDefinition> initControlDefinition,
            Action<ControlBuilder<TDefinition, TData>> customize,
            Func<BlockBuilder, Var<TData>> initData = null)
            where TData : new()
            where TDefinition : IControlDefinition<TData>, new()
        {
            if (initData == null)
            {
                initData = b => b.NewObj<TData>();
            }

            TDefinition controlDefinition = initControlDefinition();
            ControlBuilder<TDefinition, TData> controlBuilder = new(controlDefinition, initData);
            customize(controlBuilder);

            return b.Render(controlDefinition, controlBuilder.GetData(b));
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
