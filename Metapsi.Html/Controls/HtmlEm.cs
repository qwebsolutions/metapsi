using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlEm
{
}

public static partial class HtmlEmControl
{
    /// <summary>
    /// The HTML em tag
    /// </summary>
    public static IHtmlNode HtmlEm(this HtmlBuilder b, Action<AttributesBuilder<HtmlEm>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("em", buildAttributes, children);
    }
    /// <summary>
    /// The HTML em tag
    /// </summary>
    public static IHtmlNode HtmlEm(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("em", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML em tag
    /// </summary>
    public static Var<IVNode> HtmlEm(this LayoutBuilder b, Action<PropsBuilder<HtmlEm>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("em", buildProps, children);
    }
    /// <summary>
    /// The HTML em tag
    /// </summary>
    public static Var<IVNode> HtmlEm(this LayoutBuilder b, Action<PropsBuilder<HtmlEm>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("em", buildProps, children);
    }
    /// <summary>
    /// The HTML em tag
    /// </summary>
    public static Var<IVNode> HtmlEm(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("em", children);
    }
    /// <summary>
    /// The HTML em tag
    /// </summary>
    public static Var<IVNode> HtmlEm(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("em", children);
    }
}

