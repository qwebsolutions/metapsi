using Metapsi;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Metapsi.Hyperapp
{
    public class ControlBuilder<TControlDefinition, TData> : BlockBuilder
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

    public static class ControlDefinition
    {
        public static ControlDefinition<TData> New<TData>(
            string tag,
            Action<PropsBuilder, Var<TData>, Var<DynamicObject>> defaultProps,
            Func<LayoutBuilder, Var<TData>, Var<IVNode>> child)
        {
            var builder = new ControlDefinition<TData>();
            builder.EditProps(defaultProps);
            builder.BuildControl = (b, data, props) => b.H(tag, props, b.Call(child, data));
            return builder;
        }

        public static ControlDefinition<TData> New<TData>(
            string tag,
            Action<PropsBuilder, Var<TData>, Var<DynamicObject>> defaultProps,
            params Func<LayoutBuilder, Var<TData>, Var<IVNode>>[] children)
        {
            var builder = new ControlDefinition<TData>();
            builder.EditProps(defaultProps);
            builder.BuildControl = (b, data, props) => b.H(tag, props, b.List(children.Select(buildChild => buildChild(b, data))));
            return builder;
        }

        public static ControlDefinition<TData> New<TData>(
            string tag,
            Action<PropsBuilder, Var<TData>, Var<DynamicObject>> defaultProps,
            Func<LayoutBuilder, Var<TData>, Var<List<IVNode>>> children)
        {
            var builder = new ControlDefinition<TData>();
            builder.EditProps(defaultProps);
            builder.BuildControl = (b, data, props) => b.H(tag, props, b.Call(children, data));
            return builder;
        }
    }

    public class ControlDefinition<TData>
    {
        public Func<LayoutBuilder, Var<TData>, Var<DynamicObject>, Var<IVNode>> BuildControl { get; set; }
        public List<Action<PropsBuilder, Var<TData>, Var<DynamicObject>>> PropsActions { get; set; } = new();
    }

    public static class ControlDefinitionExtensions
    {
        /// <summary>
        /// Called when the control is completely defined
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static Func<LayoutBuilder, Var<TData>, Var<IVNode>> GetRenderer<TData>(this ControlDefinition<TData> builder)
        {
            return (LayoutBuilder b, Var<TData> data) =>
            {
                var props = b.NewObj<DynamicObject>();
                PropsBuilder propsBuilder = new PropsBuilder(b);
                foreach (var prop in builder.PropsActions)
                {
                    prop(propsBuilder, data, props);
                }

                return builder.BuildControl(b, data, props);
            };
        }

        public static Var<IVNode> Render<TData>(this LayoutBuilder b, ControlDefinition<TData> builder, Var<TData> data)
        {
            return b.Call(builder.GetRenderer(), data);
        }
    }
}

