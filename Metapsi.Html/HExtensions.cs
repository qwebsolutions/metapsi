using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

public static class HExtensions
{
    public static Var<IVNode> H<TControl>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TControl>> buildProps,
        Var<List<IVNode>> children)
    {
        var propsBuilder = new PropsBuilder<TControl>();
        propsBuilder.InitializeFrom(b);
        propsBuilder.Props = b.NewObj<DynamicObject>().As<TControl>();
        buildProps(propsBuilder);
        return b.H(tag, propsBuilder.Props.As<DynamicObject>(), children);
    }

    public static Var<IVNode> H<TControl>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TControl>> buildProps,
        params Var<IVNode>[] children)
    {
        return b.H(tag, buildProps, b.List(children));
    }
}

public static class StyledTagsExtensions
{
    public static Var<IVNode> HtmlSpanText(this LayoutBuilder b, Action<PropsBuilder<HtmlSpan>> buildSpan, Var<string> text)
    {
        return b.HtmlSpan(
            buildSpan,
            b.T(text));
    }

    public static Var<IVNode> HtmlSpanText(this LayoutBuilder b, Action<PropsBuilder<HtmlSpan>> buildSpan, string text)
    {
        return b.HtmlSpanText(buildSpan, b.Const(text));
    }
}