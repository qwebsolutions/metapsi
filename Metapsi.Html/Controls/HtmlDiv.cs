using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlDiv
{
}

public static partial class HtmlDivControl
{
    /// <summary>
    /// The HTML div tag
    /// </summary>
    public static IHtmlNode HtmlDiv(this HtmlBuilder b, Action<AttributesBuilder<HtmlDiv>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("div", buildAttributes, children);
    }
    /// <summary>
    /// The HTML div tag
    /// </summary>
    public static IHtmlNode HtmlDiv(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("div", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML div tag
    /// </summary>
    public static Var<IVNode> HtmlDiv(this LayoutBuilder b, Action<PropsBuilder<HtmlDiv>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("div", buildProps, children);
    }
    /// <summary>
    /// The HTML div tag
    /// </summary>
    public static Var<IVNode> HtmlDiv(this LayoutBuilder b, Action<PropsBuilder<HtmlDiv>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("div", buildProps, children);
    }
    /// <summary>
    /// The HTML div tag
    /// </summary>
    public static Var<IVNode> HtmlDiv(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("div", children);
    }
    /// <summary>
    /// The HTML div tag
    /// </summary>
    public static Var<IVNode> HtmlDiv(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("div", children);
    }
}

