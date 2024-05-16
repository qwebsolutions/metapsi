using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlH5
{
}

public static partial class HtmlH5Control
{
    /// <summary>
    /// The HTML h5 tag
    /// </summary>
    public static IHtmlNode HtmlH5(this HtmlBuilder b, Action<AttributesBuilder<HtmlH5>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("h5", buildAttributes, children);
    }
    /// <summary>
    /// The HTML h5 tag
    /// </summary>
    public static IHtmlNode HtmlH5(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("h5", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML h5 tag
    /// </summary>
    public static Var<IVNode> HtmlH5(this LayoutBuilder b, Action<PropsBuilder<HtmlH5>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("h5", buildProps, children);
    }
    /// <summary>
    /// The HTML h5 tag
    /// </summary>
    public static Var<IVNode> HtmlH5(this LayoutBuilder b, Action<PropsBuilder<HtmlH5>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("h5", buildProps, children);
    }
    /// <summary>
    /// The HTML h5 tag
    /// </summary>
    public static Var<IVNode> HtmlH5(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("h5", children);
    }
    /// <summary>
    /// The HTML h5 tag
    /// </summary>
    public static Var<IVNode> HtmlH5(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("h5", children);
    }
}

