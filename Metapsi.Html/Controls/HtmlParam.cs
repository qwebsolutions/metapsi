using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlParam
{
}

public static partial class HtmlParamControl
{
    /// <summary>
    /// The HTML param tag
    /// </summary>
    public static IHtmlNode HtmlParam(this HtmlBuilder b, Action<AttributesBuilder<HtmlParam>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("param", buildAttributes, children);
    }
    /// <summary>
    /// The HTML param tag
    /// </summary>
    public static IHtmlNode HtmlParam(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("param", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML param tag
    /// </summary>
    public static Var<IVNode> HtmlParam(this LayoutBuilder b, Action<PropsBuilder<HtmlParam>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("param", buildProps, children);
    }
    /// <summary>
    /// The HTML param tag
    /// </summary>
    public static Var<IVNode> HtmlParam(this LayoutBuilder b, Action<PropsBuilder<HtmlParam>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("param", buildProps, children);
    }
    /// <summary>
    /// The HTML param tag
    /// </summary>
    public static Var<IVNode> HtmlParam(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("param", children);
    }
    /// <summary>
    /// The HTML param tag
    /// </summary>
    public static Var<IVNode> HtmlParam(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("param", children);
    }
}

