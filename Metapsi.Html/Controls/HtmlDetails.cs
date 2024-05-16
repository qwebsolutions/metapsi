using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlDetails
{
}

public static partial class HtmlDetailsControl
{
    /// <summary>
    /// The HTML details tag
    /// </summary>
    public static IHtmlNode HtmlDetails(this HtmlBuilder b, Action<AttributesBuilder<HtmlDetails>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("details", buildAttributes, children);
    }
    /// <summary>
    /// The HTML details tag
    /// </summary>
    public static IHtmlNode HtmlDetails(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("details", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML details tag
    /// </summary>
    public static Var<IVNode> HtmlDetails(this LayoutBuilder b, Action<PropsBuilder<HtmlDetails>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("details", buildProps, children);
    }
    /// <summary>
    /// The HTML details tag
    /// </summary>
    public static Var<IVNode> HtmlDetails(this LayoutBuilder b, Action<PropsBuilder<HtmlDetails>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("details", buildProps, children);
    }
    /// <summary>
    /// The HTML details tag
    /// </summary>
    public static Var<IVNode> HtmlDetails(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("details", children);
    }
    /// <summary>
    /// The HTML details tag
    /// </summary>
    public static Var<IVNode> HtmlDetails(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("details", children);
    }
}

