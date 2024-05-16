using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTime
{
}

public static partial class HtmlTimeControl
{
    /// <summary>
    /// The HTML time tag
    /// </summary>
    public static IHtmlNode HtmlTime(this HtmlBuilder b, Action<AttributesBuilder<HtmlTime>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("time", buildAttributes, children);
    }
    /// <summary>
    /// The HTML time tag
    /// </summary>
    public static IHtmlNode HtmlTime(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("time", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML time tag
    /// </summary>
    public static Var<IVNode> HtmlTime(this LayoutBuilder b, Action<PropsBuilder<HtmlTime>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("time", buildProps, children);
    }
    /// <summary>
    /// The HTML time tag
    /// </summary>
    public static Var<IVNode> HtmlTime(this LayoutBuilder b, Action<PropsBuilder<HtmlTime>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("time", buildProps, children);
    }
    /// <summary>
    /// The HTML time tag
    /// </summary>
    public static Var<IVNode> HtmlTime(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("time", children);
    }
    /// <summary>
    /// The HTML time tag
    /// </summary>
    public static Var<IVNode> HtmlTime(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("time", children);
    }
}

