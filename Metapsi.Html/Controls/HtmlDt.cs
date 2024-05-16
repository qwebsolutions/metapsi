using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlDt
{
}

public static partial class HtmlDtControl
{
    /// <summary>
    /// The HTML dt tag
    /// </summary>
    public static IHtmlNode HtmlDt(this HtmlBuilder b, Action<AttributesBuilder<HtmlDt>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("dt", buildAttributes, children);
    }
    /// <summary>
    /// The HTML dt tag
    /// </summary>
    public static IHtmlNode HtmlDt(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("dt", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML dt tag
    /// </summary>
    public static Var<IVNode> HtmlDt(this LayoutBuilder b, Action<PropsBuilder<HtmlDt>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dt", buildProps, children);
    }
    /// <summary>
    /// The HTML dt tag
    /// </summary>
    public static Var<IVNode> HtmlDt(this LayoutBuilder b, Action<PropsBuilder<HtmlDt>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dt", buildProps, children);
    }
    /// <summary>
    /// The HTML dt tag
    /// </summary>
    public static Var<IVNode> HtmlDt(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("dt", children);
    }
    /// <summary>
    /// The HTML dt tag
    /// </summary>
    public static Var<IVNode> HtmlDt(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("dt", children);
    }
}

