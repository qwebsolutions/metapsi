using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSummary
{
}

public static partial class HtmlSummaryControl
{
    /// <summary>
    /// <para> The HTML summary tag </para>
    /// </summary>
    public static IHtmlNode HtmlSummary(this HtmlBuilder b, Action<AttributesBuilder<HtmlSummary>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("summary", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML summary tag </para>
    /// </summary>
    public static IHtmlNode HtmlSummary(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("summary", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML summary tag </para>
    /// </summary>
    public static IHtmlNode HtmlSummary(this HtmlBuilder b, Action<AttributesBuilder<HtmlSummary>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("summary", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML summary tag </para>
    /// </summary>
    public static IHtmlNode HtmlSummary(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("summary", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML summary tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSummary(this LayoutBuilder b, Action<PropsBuilder<HtmlSummary>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("summary", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML summary tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSummary(this LayoutBuilder b, Action<PropsBuilder<HtmlSummary>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("summary", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML summary tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSummary(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("summary", children);
    }
    /// <summary>
    /// <para> The HTML summary tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSummary(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("summary", children);
    }
}

