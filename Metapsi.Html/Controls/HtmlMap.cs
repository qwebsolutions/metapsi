using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlMap
{
}

public static partial class HtmlMapControl
{
    /// <summary>
    /// The HTML map tag
    /// </summary>
    public static IHtmlNode HtmlMap(this HtmlBuilder b, Action<AttributesBuilder<HtmlMap>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("map", buildAttributes, children);
    }
    /// <summary>
    /// The HTML map tag
    /// </summary>
    public static IHtmlNode HtmlMap(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("map", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML map tag
    /// </summary>
    public static Var<IVNode> HtmlMap(this LayoutBuilder b, Action<PropsBuilder<HtmlMap>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("map", buildProps, children);
    }
    /// <summary>
    /// The HTML map tag
    /// </summary>
    public static Var<IVNode> HtmlMap(this LayoutBuilder b, Action<PropsBuilder<HtmlMap>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("map", buildProps, children);
    }
    /// <summary>
    /// The HTML map tag
    /// </summary>
    public static Var<IVNode> HtmlMap(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("map", children);
    }
    /// <summary>
    /// The HTML map tag
    /// </summary>
    public static Var<IVNode> HtmlMap(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("map", children);
    }
}

