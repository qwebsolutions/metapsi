using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlHead
{
}

public static partial class HtmlHeadControl
{
    /// <summary>
    /// The HTML head tag
    /// </summary>
    public static IHtmlNode HtmlHead(this HtmlBuilder b, Action<AttributesBuilder<HtmlHead>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("head", buildAttributes, children);
    }
    /// <summary>
    /// The HTML head tag
    /// </summary>
    public static IHtmlNode HtmlHead(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("head", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML head tag
    /// </summary>
    public static Var<IVNode> HtmlHead(this LayoutBuilder b, Action<PropsBuilder<HtmlHead>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("head", buildProps, children);
    }
    /// <summary>
    /// The HTML head tag
    /// </summary>
    public static Var<IVNode> HtmlHead(this LayoutBuilder b, Action<PropsBuilder<HtmlHead>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("head", buildProps, children);
    }
    /// <summary>
    /// The HTML head tag
    /// </summary>
    public static Var<IVNode> HtmlHead(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("head", children);
    }
    /// <summary>
    /// The HTML head tag
    /// </summary>
    public static Var<IVNode> HtmlHead(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("head", children);
    }
}

