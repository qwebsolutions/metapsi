using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlLink
{
}

public static partial class HtmlLinkControl
{
    /// <summary>
    /// The HTML link tag
    /// </summary>
    public static IHtmlNode HtmlLink(this HtmlBuilder b, Action<AttributesBuilder<HtmlLink>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("link", buildAttributes, children);
    }
    /// <summary>
    /// The HTML link tag
    /// </summary>
    public static IHtmlNode HtmlLink(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("link", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML link tag
    /// </summary>
    public static Var<IVNode> HtmlLink(this LayoutBuilder b, Action<PropsBuilder<HtmlLink>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("link", buildProps, children);
    }
    /// <summary>
    /// The HTML link tag
    /// </summary>
    public static Var<IVNode> HtmlLink(this LayoutBuilder b, Action<PropsBuilder<HtmlLink>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("link", buildProps, children);
    }
    /// <summary>
    /// The HTML link tag
    /// </summary>
    public static Var<IVNode> HtmlLink(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("link", children);
    }
    /// <summary>
    /// The HTML link tag
    /// </summary>
    public static Var<IVNode> HtmlLink(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("link", children);
    }
}

