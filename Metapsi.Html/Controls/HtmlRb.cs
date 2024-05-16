using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlRb
{
}

public static partial class HtmlRbControl
{
    /// <summary>
    /// The HTML rb tag
    /// </summary>
    public static IHtmlNode HtmlRb(this HtmlBuilder b, Action<AttributesBuilder<HtmlRb>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("rb", buildAttributes, children);
    }
    /// <summary>
    /// The HTML rb tag
    /// </summary>
    public static IHtmlNode HtmlRb(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("rb", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML rb tag
    /// </summary>
    public static Var<IVNode> HtmlRb(this LayoutBuilder b, Action<PropsBuilder<HtmlRb>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("rb", buildProps, children);
    }
    /// <summary>
    /// The HTML rb tag
    /// </summary>
    public static Var<IVNode> HtmlRb(this LayoutBuilder b, Action<PropsBuilder<HtmlRb>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("rb", buildProps, children);
    }
    /// <summary>
    /// The HTML rb tag
    /// </summary>
    public static Var<IVNode> HtmlRb(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("rb", children);
    }
    /// <summary>
    /// The HTML rb tag
    /// </summary>
    public static Var<IVNode> HtmlRb(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("rb", children);
    }
}

