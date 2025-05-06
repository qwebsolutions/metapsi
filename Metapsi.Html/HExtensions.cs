using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

public static class HExtensions
{
    // Typed TControl with List

    public static Var<IVNode> H<TControl>(
        this LayoutBuilder b,
        Var<string> tag,
        Action<PropsBuilder<TControl>> buildProps,
        Var<List<IVNode>> children)
    {
        var props = b.SetProps(b.NewObj(), buildProps);
        return b.H(tag, props.As<object>(), children);
    }

    public static Var<IVNode> H<TControl>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TControl>> buildProps,
        Var<List<IVNode>> children)
    {
        return b.H(b.Const(tag), buildProps, children);
    }

    // Typed TControl with params

    public static Var<IVNode> H<TControl>(
        this LayoutBuilder b,
        Var<string> tag,
        Action<PropsBuilder<TControl>> buildProps,
        params Var<IVNode>[] children)
    {
        return b.H(tag, buildProps, b.List(children));
    }

    public static Var<IVNode> H<TControl>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TControl>> buildProps,
        params Var<IVNode>[] children)
    {
        return b.H(b.Const(tag), buildProps, b.List(children));
    }

    // Untyped control with list

    public static Var<IVNode> H(
        this LayoutBuilder b,
        Var<string> tag,
        Action<PropsBuilder<object>> buildProps,
        Var<List<IVNode>> children)
    {
        return b.H<object>(tag, buildProps, children);
    }

    public static Var<IVNode> H(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<object>> buildProps,
        Var<List<IVNode>> children)
    {
        return b.H<object>(b.Const(tag), buildProps, children);
    }

    // Untyped control with params

    public static Var<IVNode> H(
        this LayoutBuilder b,
        Var<string> tag,
        Action<PropsBuilder<object>> buildProps,
        params Var<IVNode>[] children)
    {
        return b.H<object>(tag, buildProps, children);
    }

    public static Var<IVNode> H(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<object>> buildProps,
        params Var<IVNode>[] children)
    {
        return b.H<object>(b.Const(tag), buildProps, children);
    }
}

public static class StyledTagsExtensions
{
    public static Var<IVNode> HtmlSpanText(this LayoutBuilder b, Action<PropsBuilder<HtmlSpan>> buildSpan, Var<string> text)
    {
        return b.HtmlSpan(
            buildSpan,
            b.Text(text));
    }

    public static Var<IVNode> HtmlSpanText(this LayoutBuilder b, Action<PropsBuilder<HtmlSpan>> buildSpan, string text)
    {
        return b.HtmlSpanText(buildSpan, b.Const(text));
    }

    public static Var<IVNode> HtmlSpanText(this LayoutBuilder b, Var<string> text)
    {
        return b.HtmlSpanText(b => { }, text);
    }

    public static Var<IVNode> HtmlSpanText(this LayoutBuilder b, string text)
    {
        return b.HtmlSpanText(b.Const(text));
    }
}