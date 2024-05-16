using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlBody
{
}

public static partial class HtmlBodyControl
{
    /// <summary>
    /// The HTML body tag
    /// </summary>
    public static IHtmlNode HtmlBody(this HtmlBuilder b, Action<AttributesBuilder<HtmlBody>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("body", buildAttributes, children);
    }
    /// <summary>
    /// The HTML body tag
    /// </summary>
    public static IHtmlNode HtmlBody(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("body", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML body tag
    /// </summary>
    public static Var<IVNode> HtmlBody(this LayoutBuilder b, Action<PropsBuilder<HtmlBody>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("body", buildProps, children);
    }
    /// <summary>
    /// The HTML body tag
    /// </summary>
    public static Var<IVNode> HtmlBody(this LayoutBuilder b, Action<PropsBuilder<HtmlBody>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("body", buildProps, children);
    }
    /// <summary>
    /// The HTML body tag
    /// </summary>
    public static Var<IVNode> HtmlBody(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("body", children);
    }
    /// <summary>
    /// The HTML body tag
    /// </summary>
    public static Var<IVNode> HtmlBody(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("body", children);
    }
}

