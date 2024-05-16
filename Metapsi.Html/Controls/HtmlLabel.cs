using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlLabel
{
}

public static partial class HtmlLabelControl
{
    /// <summary>
    /// The HTML label tag
    /// </summary>
    public static IHtmlNode HtmlLabel(this HtmlBuilder b, Action<AttributesBuilder<HtmlLabel>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("label", buildAttributes, children);
    }
    /// <summary>
    /// The HTML label tag
    /// </summary>
    public static IHtmlNode HtmlLabel(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("label", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML label tag
    /// </summary>
    public static Var<IVNode> HtmlLabel(this LayoutBuilder b, Action<PropsBuilder<HtmlLabel>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("label", buildProps, children);
    }
    /// <summary>
    /// The HTML label tag
    /// </summary>
    public static Var<IVNode> HtmlLabel(this LayoutBuilder b, Action<PropsBuilder<HtmlLabel>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("label", buildProps, children);
    }
    /// <summary>
    /// The HTML label tag
    /// </summary>
    public static Var<IVNode> HtmlLabel(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("label", children);
    }
    /// <summary>
    /// The HTML label tag
    /// </summary>
    public static Var<IVNode> HtmlLabel(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("label", children);
    }
}

