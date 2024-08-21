using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlFigcaption
{
}

public static partial class HtmlFigcaptionControl
{
    /// <summary>
    /// <para> The HTML figcaption tag </para>
    /// </summary>
    public static IHtmlNode HtmlFigcaption(this HtmlBuilder b, Action<AttributesBuilder<HtmlFigcaption>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("figcaption", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML figcaption tag </para>
    /// </summary>
    public static IHtmlNode HtmlFigcaption(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("figcaption", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML figcaption tag </para>
    /// </summary>
    public static IHtmlNode HtmlFigcaption(this HtmlBuilder b, Action<AttributesBuilder<HtmlFigcaption>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("figcaption", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML figcaption tag </para>
    /// </summary>
    public static IHtmlNode HtmlFigcaption(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("figcaption", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML figcaption tag </para>
    /// </summary>
    public static Var<IVNode> HtmlFigcaption(this LayoutBuilder b, Action<PropsBuilder<HtmlFigcaption>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("figcaption", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML figcaption tag </para>
    /// </summary>
    public static Var<IVNode> HtmlFigcaption(this LayoutBuilder b, Action<PropsBuilder<HtmlFigcaption>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("figcaption", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML figcaption tag </para>
    /// </summary>
    public static Var<IVNode> HtmlFigcaption(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("figcaption", children);
    }
    /// <summary>
    /// <para> The HTML figcaption tag </para>
    /// </summary>
    public static Var<IVNode> HtmlFigcaption(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("figcaption", children);
    }
}

