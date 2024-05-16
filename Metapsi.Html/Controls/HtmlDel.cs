using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlDel
{
}

public static partial class HtmlDelControl
{
    /// <summary>
    /// The HTML del tag
    /// </summary>
    public static IHtmlNode HtmlDel(this HtmlBuilder b, Action<AttributesBuilder<HtmlDel>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("del", buildAttributes, children);
    }
    /// <summary>
    /// The HTML del tag
    /// </summary>
    public static IHtmlNode HtmlDel(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("del", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML del tag
    /// </summary>
    public static Var<IVNode> HtmlDel(this LayoutBuilder b, Action<PropsBuilder<HtmlDel>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("del", buildProps, children);
    }
    /// <summary>
    /// The HTML del tag
    /// </summary>
    public static Var<IVNode> HtmlDel(this LayoutBuilder b, Action<PropsBuilder<HtmlDel>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("del", buildProps, children);
    }
    /// <summary>
    /// The HTML del tag
    /// </summary>
    public static Var<IVNode> HtmlDel(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("del", children);
    }
    /// <summary>
    /// The HTML del tag
    /// </summary>
    public static Var<IVNode> HtmlDel(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("del", children);
    }
}

