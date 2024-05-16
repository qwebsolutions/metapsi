using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlDd
{
}

public static partial class HtmlDdControl
{
    /// <summary>
    /// The HTML dd tag
    /// </summary>
    public static IHtmlNode HtmlDd(this HtmlBuilder b, Action<AttributesBuilder<HtmlDd>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("dd", buildAttributes, children);
    }
    /// <summary>
    /// The HTML dd tag
    /// </summary>
    public static IHtmlNode HtmlDd(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("dd", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML dd tag
    /// </summary>
    public static Var<IVNode> HtmlDd(this LayoutBuilder b, Action<PropsBuilder<HtmlDd>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dd", buildProps, children);
    }
    /// <summary>
    /// The HTML dd tag
    /// </summary>
    public static Var<IVNode> HtmlDd(this LayoutBuilder b, Action<PropsBuilder<HtmlDd>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dd", buildProps, children);
    }
    /// <summary>
    /// The HTML dd tag
    /// </summary>
    public static Var<IVNode> HtmlDd(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("dd", children);
    }
    /// <summary>
    /// The HTML dd tag
    /// </summary>
    public static Var<IVNode> HtmlDd(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("dd", children);
    }
}

