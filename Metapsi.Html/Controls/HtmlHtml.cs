using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlHtml
{
}

public static partial class HtmlHtmlControl
{
    /// <summary>
    /// <para> The HTML html tag </para>
    /// </summary>
    public static IHtmlNode HtmlHtml(this HtmlBuilder b, Action<AttributesBuilder<HtmlHtml>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("html", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML html tag </para>
    /// </summary>
    public static IHtmlNode HtmlHtml(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("html", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML html tag </para>
    /// </summary>
    public static IHtmlNode HtmlHtml(this HtmlBuilder b, Action<AttributesBuilder<HtmlHtml>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("html", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML html tag </para>
    /// </summary>
    public static IHtmlNode HtmlHtml(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("html", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML html tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHtml(this LayoutBuilder b, Action<PropsBuilder<HtmlHtml>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("html", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML html tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHtml(this LayoutBuilder b, Action<PropsBuilder<HtmlHtml>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("html", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML html tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHtml(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("html", children);
    }
    /// <summary>
    /// <para> The HTML html tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHtml(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("html", children);
    }
}

