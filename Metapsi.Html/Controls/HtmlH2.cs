using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlH2
{
}

public static partial class HtmlH2Control
{
    /// <summary>
    /// <para> The HTML h2 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH2(this HtmlBuilder b, Action<AttributesBuilder<HtmlH2>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("h2", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML h2 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH2(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("h2", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML h2 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH2(this HtmlBuilder b, Action<AttributesBuilder<HtmlH2>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("h2", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML h2 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH2(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("h2", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML h2 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH2(this LayoutBuilder b, Action<PropsBuilder<HtmlH2>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("h2", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML h2 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH2(this LayoutBuilder b, Action<PropsBuilder<HtmlH2>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("h2", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML h2 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH2(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("h2", children);
    }
    /// <summary>
    /// <para> The HTML h2 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH2(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("h2", children);
    }
}

