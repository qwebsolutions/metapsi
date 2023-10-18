using Metapsi;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Metapsi.Hyperapp
{
    public interface IControlBuilder
    {
        Var<IVNode> GetRoot(LayoutBuilder b);
    }

    public class ControlBuilder : IControlBuilder
    {
        public Func<LayoutBuilder, Var<DynamicObject>, Var<IVNode>> BuildControl { get; set; }
        private List<Action<PropsBuilder>> propsActions = new List<Action<PropsBuilder>>();

        public ControlBuilder(Action<PropsBuilder> defaultProps)
        {
            propsActions.Add(defaultProps);
        }

        public void SetProps(Action<PropsBuilder> setProps)
        {
            propsActions.Add(setProps);
        }

        public Var<IVNode> GetRoot(LayoutBuilder b)
        {
            PropsBuilder propsBuilder = new PropsBuilder(b);
            foreach (var prop in propsActions)
            {
                prop(propsBuilder);
            }
            return this.BuildControl(b, propsBuilder.Props);
        }

        public static ControlBuilder New(
            string tag,
            Action<PropsBuilder> defaultProps,
            params Func<LayoutBuilder, Var<IVNode>>[] children)
        {
            return new ControlBuilder(defaultProps)
            {
                BuildControl = (b, props) => b.H(tag, props, b.List(children.Select(x => x(b))))
            };
        }

        public static ControlBuilder New(
            string tag,
            Action<PropsBuilder> defaultProps,
            Func<LayoutBuilder, Var<List<IVNode>>> children)
        {
            return new ControlBuilder(defaultProps)
            {
                BuildControl = (b, props) => b.H(tag, props, b.Call(children))
            };
        }

        public static ControlBuilder<TData> New<TData>(
            string tag,
            Action<PropsBuilder> defaultProps,
            params Func<LayoutBuilder, Var<TData>, Var<IVNode>>[] children)
        {
            return new ControlBuilder<TData>(defaultProps)
            {
                BuildControl = (b, data, props) => b.H(tag, props, b.List(children.Select(x => x(b, data))))
            };
        }

        public static ControlBuilder<TData> New<TData>(
            string tag,
            Action<PropsBuilder> defaultProps,
            Func<LayoutBuilder, Var<TData>, Var<List<IVNode>>> children)
        {
            return new ControlBuilder<TData>(defaultProps)
            {
                BuildControl = (b, data, props) => b.H(tag, props, b.Call(children, data))
            };
        }

        public static TBuilder New<TBuilder, TData>(LayoutBuilder b)
            where TBuilder : CompoundBuilder<TData>, new()
            where TData: new()
        {
            TBuilder builder  = new TBuilder();
            builder.Init(b);
            return builder;
        }
    }

    public class ControlBuilder<TData>
        where TData: new()
    {
        
        public Func<LayoutBuilder, Var<TData>, Var<DynamicObject>, Var<IVNode>> BuildControl { get; set; }
        private List<Action<PropsBuilder>> propsActions = new List<Action<PropsBuilder>>();

        public List<Action<BlockBuilder, Var<TData>>> dataActions { get; set; } = new();

        public ControlBuilder(Action<PropsBuilder> defaultProps)
        {
            propsActions.Add(defaultProps);
        }

        public void SetProps(Action<PropsBuilder> setProps)
        {
            propsActions.Add(setProps);
        }

        public Var<IVNode> Build(LayoutBuilder b, Var<TData> data)
        {
            BlockBuilder dataBuilder = BlockBuilder.New<BlockBuilder>(b.ModuleBuilder, b.Block);
            foreach (var dataAction in dataActions)
            {
                dataAction(dataBuilder, data);
            }

            PropsBuilder propsBuilder = new PropsBuilder(b);
            foreach (var prop in propsActions)
            {
                prop(propsBuilder);
            }
            return this.BuildControl(b, data, propsBuilder.Props);
        }
    }

    public abstract class CompoundBuilder<TData> : IControlBuilder
        where TData : new()
    {
        public Action<BlockBuilder, Var<TData>> FillData { get; set; }

        public void Init(LayoutBuilder b)
        {
            this.Setup(b);
        }
        protected abstract void Setup(LayoutBuilder b);

        public abstract Var<IVNode> GetRoot(LayoutBuilder b);
    }
}

