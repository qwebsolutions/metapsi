using Metapsi;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Metapsi.Hyperapp
{
    public static class HtmlControlBuilder
    {
        public static HtmlControlBuilder<TData> New<TData>(
            string tag,
            Action<PropsBuilder, Var<TData>, Var<DynamicObject>> defaultProps,
            Func<LayoutBuilder, Var<TData>, Var<IVNode>> child)
        {
            var builder = new HtmlControlBuilder<TData>();
            builder.EditProps(defaultProps);
            builder.BuildControl = (b, data, props) => b.H(tag, props, b.Call(child, data));
            return builder;
        }

        public static HtmlControlBuilder<TData> New<TData>(
            string tag,
            Action<PropsBuilder, Var<TData>, Var<DynamicObject>> defaultProps,
            params Func<LayoutBuilder, Var<TData>, Var<IVNode>>[] children)
        {
            var builder = new HtmlControlBuilder<TData>();
            builder.EditProps(defaultProps);
            builder.BuildControl = (b, data, props) => b.H(tag, props, b.List(children.Select(buildChild => buildChild(b, data))));
            return builder;
        }
    }

    //public class HtmlControlBuilder
    //{
    //    public Func<LayoutBuilder, Var<DynamicObject>, Var<IVNode>> BuildControl { get; set; }
    //    private List<Action<PropsBuilder>> propsActions = new List<Action<PropsBuilder>>();

    //    public HtmlControlBuilder(Action<PropsBuilder> defaultProps)
    //    {
    //        propsActions.Add(defaultProps);
    //    }

    //    public void SetProps(Action<PropsBuilder> setProps)
    //    {
    //        propsActions.Add(setProps);
    //    }

    //    public Var<IVNode> GetRoot(LayoutBuilder b)
    //    {
    //        PropsBuilder propsBuilder = new PropsBuilder(b);
    //        foreach (var prop in propsActions)
    //        {
    //            prop(propsBuilder);
    //        }
    //        return this.BuildControl(b, propsBuilder.Props);
    //    }

    //    public static HtmlControlBuilder New(
    //        string tag,
    //        Action<PropsBuilder> defaultProps,
    //        params Func<LayoutBuilder, Var<IVNode>>[] children)
    //    {
    //        return new HtmlControlBuilder(defaultProps)
    //        {
    //            BuildControl = (b, props) => b.H(tag, props, b.List(children.Select(x => x(b))))
    //        };
    //    }

    //    public static HtmlControlBuilder New(
    //        string tag,
    //        Action<PropsBuilder> defaultProps,
    //        Func<LayoutBuilder, Var<List<IVNode>>> children)
    //    {
    //        return new HtmlControlBuilder(defaultProps)
    //        {
    //            BuildControl = (b, props) => b.H(tag, props, b.Call(children))
    //        };
    //    }

    //    public static HtmlControlBuilder<TData> New<TData>(
    //        string tag,
    //        Action<PropsBuilder, Var<DynamicObject>> defaultProps,
    //        params Func<LayoutBuilder, Var<TData>, Var<IVNode>>[] children)
    //    {
    //        var builder = new HtmlControlBuilder<TData>();
    //        builder.

    //        return new HtmlControlBuilder<TData>(defaultProps)
    //        {
    //            BuildControl = (b, data, props) => b.H(tag, props, b.List(children.Select(x => x(b, data))))
    //        };
    //    }



    //    public static TBuilder New<TBuilder, TData>(LayoutBuilder b)
    //        where TBuilder : CompoundBuilder<TData>, new()
    //        where TData: new()
    //    {
    //        TBuilder builder  = new TBuilder();
    //        builder.Init(b);
    //        return builder;
    //    }
    //}

    public class HtmlControlBuilder<TData>
    {
        public Func<LayoutBuilder, Var<TData>, Var<DynamicObject>, Var<IVNode>> BuildControl { get; set; }
        public List<Action<PropsBuilder, Var<TData>, Var<DynamicObject>>> PropsActions { get; set; } = new();

        //public List<Action<BlockBuilder, Var<TData>>> dataActions { get; set; } = new();

        //public Var<IVNode> GetRoot(LayoutBuilder b)
        //{
        //    BlockBuilder dataBuilder = BlockBuilder.New<BlockBuilder>(b.ModuleBuilder, b.Block);
        //    return this.BuildControl(b, data, propsBuilder.Props);
        //}
    }

    public static class HtmlControlBuilderExtensions
    {
        /// <summary>
        /// Called when the control is completely defined
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static Func<LayoutBuilder, Var<TData>, Var<IVNode>> GetRenderer<TData>(this HtmlControlBuilder<TData> builder)
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

        public static HtmlControlBuilder<TData> FillBuilder<TData>(this HtmlControlBuilder<TData> b, Action<HtmlControlBuilder<TData>> fill)
        {
            fill(b);
            return b;
        }

        public static Var<IVNode> Render<TData>(this LayoutBuilder b, HtmlControlBuilder<TData> builder, Var<TData> data)
        {
            return b.Call(builder.GetRenderer(), data);
        }
    }

    //public abstract class CompoundBuilder<TData> : IControlBuilder
    //    where TData : new()
    //{
    //    protected void Init(LayoutBuilder b)
    //    {
    //        this.Setup(b);
    //    }
    //    protected abstract void Setup(LayoutBuilder b);

    //    //public abstract Var<IVNode> GetRoot(LayoutBuilder b);
    //    public Func<LayoutBuilder, Var<TData>, Var<IVNode>> GetRenderer()
    //    {
    //        return (b, data) =>
    //        {

    //        };
    //    }
    //}
}

