using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlH3
{
}

public static partial class HtmlH3Control
{
    /// <summary>
    /// <para> The HTML h3 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH3(this HtmlBuilder b, Action<AttributesBuilder<HtmlH3>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("h3", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML h3 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH3(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("h3", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML h3 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH3(this HtmlBuilder b, Action<AttributesBuilder<HtmlH3>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("h3", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML h3 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH3(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("h3", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML h3 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH3(this LayoutBuilder b, Action<PropsBuilder<HtmlH3>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("h3", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML h3 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH3(this LayoutBuilder b, Action<PropsBuilder<HtmlH3>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("h3", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML h3 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH3(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("h3", children);
    }
    /// <summary>
    /// <para> The HTML h3 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH3(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("h3", children);
    }
}

