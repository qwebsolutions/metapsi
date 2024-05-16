using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlHeader
{
}

public static partial class HtmlHeaderControl
{
    /// <summary>
    /// The HTML header tag
    /// </summary>
    public static IHtmlNode HtmlHeader(this HtmlBuilder b, Action<AttributesBuilder<HtmlHeader>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("header", buildAttributes, children);
    }
    /// <summary>
    /// The HTML header tag
    /// </summary>
    public static IHtmlNode HtmlHeader(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("header", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML header tag
    /// </summary>
    public static Var<IVNode> HtmlHeader(this LayoutBuilder b, Action<PropsBuilder<HtmlHeader>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("header", buildProps, children);
    }
    /// <summary>
    /// The HTML header tag
    /// </summary>
    public static Var<IVNode> HtmlHeader(this LayoutBuilder b, Action<PropsBuilder<HtmlHeader>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("header", buildProps, children);
    }
    /// <summary>
    /// The HTML header tag
    /// </summary>
    public static Var<IVNode> HtmlHeader(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("header", children);
    }
    /// <summary>
    /// The HTML header tag
    /// </summary>
    public static Var<IVNode> HtmlHeader(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("header", children);
    }
}

