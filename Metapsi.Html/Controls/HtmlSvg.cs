using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSvg
{
}

public static partial class HtmlSvgControl
{
    /// <summary>
    /// The HTML svg tag
    /// </summary>
    public static IHtmlNode HtmlSvg(this HtmlBuilder b, Action<AttributesBuilder<HtmlSvg>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("svg", buildAttributes, children);
    }
    /// <summary>
    /// The HTML svg tag
    /// </summary>
    public static IHtmlNode HtmlSvg(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("svg", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML svg tag
    /// </summary>
    public static Var<IVNode> HtmlSvg(this LayoutBuilder b, Action<PropsBuilder<HtmlSvg>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("svg", buildProps, children);
    }
    /// <summary>
    /// The HTML svg tag
    /// </summary>
    public static Var<IVNode> HtmlSvg(this LayoutBuilder b, Action<PropsBuilder<HtmlSvg>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("svg", buildProps, children);
    }
    /// <summary>
    /// The HTML svg tag
    /// </summary>
    public static Var<IVNode> HtmlSvg(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("svg", children);
    }
    /// <summary>
    /// The HTML svg tag
    /// </summary>
    public static Var<IVNode> HtmlSvg(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("svg", children);
    }
}

