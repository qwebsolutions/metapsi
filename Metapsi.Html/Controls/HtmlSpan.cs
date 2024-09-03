using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlSpan
{
}

public static partial class HtmlSpanControl
{
    /// <summary>
    /// <para> The HTML span tag </para>
    /// </summary>
    public static IHtmlNode HtmlSpan(this HtmlBuilder b, Action<AttributesBuilder<HtmlSpan>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("span", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML span tag </para>
    /// </summary>
    public static IHtmlNode HtmlSpan(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("span", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML span tag </para>
    /// </summary>
    public static IHtmlNode HtmlSpan(this HtmlBuilder b, Action<AttributesBuilder<HtmlSpan>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("span", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML span tag </para>
    /// </summary>
    public static IHtmlNode HtmlSpan(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("span", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML span tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSpan(this LayoutBuilder b, Action<PropsBuilder<HtmlSpan>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("span", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML span tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSpan(this LayoutBuilder b, Action<PropsBuilder<HtmlSpan>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("span", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML span tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSpan(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("span", children);
    }
    /// <summary>
    /// <para> The HTML span tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSpan(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("span", children);
    }
}

