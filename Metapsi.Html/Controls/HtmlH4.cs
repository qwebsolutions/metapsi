using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlH4
{
}

public static partial class HtmlH4Control
{
    /// <summary>
    /// <para> The HTML h4 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH4(this HtmlBuilder b, Action<AttributesBuilder<HtmlH4>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("h4", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML h4 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH4(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("h4", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML h4 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH4(this HtmlBuilder b, Action<AttributesBuilder<HtmlH4>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("h4", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML h4 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH4(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("h4", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML h4 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH4(this LayoutBuilder b, Action<PropsBuilder<HtmlH4>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("h4", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML h4 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH4(this LayoutBuilder b, Action<PropsBuilder<HtmlH4>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("h4", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML h4 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH4(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("h4", children);
    }
    /// <summary>
    /// <para> The HTML h4 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH4(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("h4", children);
    }
}

