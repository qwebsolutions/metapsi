using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlP
{
}

public static partial class HtmlPControl
{
    /// <summary>
    /// <para> The HTML p tag </para>
    /// </summary>
    public static IHtmlNode HtmlP(this HtmlBuilder b, Action<AttributesBuilder<HtmlP>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("p", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML p tag </para>
    /// </summary>
    public static IHtmlNode HtmlP(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("p", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML p tag </para>
    /// </summary>
    public static IHtmlNode HtmlP(this HtmlBuilder b, Action<AttributesBuilder<HtmlP>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("p", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML p tag </para>
    /// </summary>
    public static IHtmlNode HtmlP(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("p", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML p tag </para>
    /// </summary>
    public static Var<IVNode> HtmlP(this LayoutBuilder b, Action<PropsBuilder<HtmlP>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("p", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML p tag </para>
    /// </summary>
    public static Var<IVNode> HtmlP(this LayoutBuilder b, Action<PropsBuilder<HtmlP>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("p", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML p tag </para>
    /// </summary>
    public static Var<IVNode> HtmlP(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("p", children);
    }
    /// <summary>
    /// <para> The HTML p tag </para>
    /// </summary>
    public static Var<IVNode> HtmlP(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("p", children);
    }
}

