using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlRt
{
}

public static partial class HtmlRtControl
{
    /// <summary>
    /// The HTML rt tag
    /// </summary>
    public static IHtmlNode HtmlRt(this HtmlBuilder b, Action<AttributesBuilder<HtmlRt>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("rt", buildAttributes, children);
    }
    /// <summary>
    /// The HTML rt tag
    /// </summary>
    public static IHtmlNode HtmlRt(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("rt", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML rt tag
    /// </summary>
    public static Var<IVNode> HtmlRt(this LayoutBuilder b, Action<PropsBuilder<HtmlRt>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("rt", buildProps, children);
    }
    /// <summary>
    /// The HTML rt tag
    /// </summary>
    public static Var<IVNode> HtmlRt(this LayoutBuilder b, Action<PropsBuilder<HtmlRt>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("rt", buildProps, children);
    }
    /// <summary>
    /// The HTML rt tag
    /// </summary>
    public static Var<IVNode> HtmlRt(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("rt", children);
    }
    /// <summary>
    /// The HTML rt tag
    /// </summary>
    public static Var<IVNode> HtmlRt(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("rt", children);
    }
}

