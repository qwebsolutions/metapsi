using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTr
{
}

public static partial class HtmlTrControl
{
    /// <summary>
    /// <para> The HTML tr tag </para>
    /// </summary>
    public static IHtmlNode HtmlTr(this HtmlBuilder b, Action<AttributesBuilder<HtmlTr>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("tr", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML tr tag </para>
    /// </summary>
    public static IHtmlNode HtmlTr(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("tr", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML tr tag </para>
    /// </summary>
    public static IHtmlNode HtmlTr(this HtmlBuilder b, Action<AttributesBuilder<HtmlTr>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("tr", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML tr tag </para>
    /// </summary>
    public static IHtmlNode HtmlTr(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("tr", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML tr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTr(this LayoutBuilder b, Action<PropsBuilder<HtmlTr>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("tr", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML tr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTr(this LayoutBuilder b, Action<PropsBuilder<HtmlTr>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("tr", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML tr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTr(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("tr", children);
    }
    /// <summary>
    /// <para> The HTML tr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTr(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("tr", children);
    }
}

