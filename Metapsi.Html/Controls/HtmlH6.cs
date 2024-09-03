using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlH6
{
}

public static partial class HtmlH6Control
{
    /// <summary>
    /// <para> The HTML h6 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH6(this HtmlBuilder b, Action<AttributesBuilder<HtmlH6>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("h6", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML h6 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH6(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("h6", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML h6 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH6(this HtmlBuilder b, Action<AttributesBuilder<HtmlH6>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("h6", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML h6 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH6(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("h6", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML h6 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH6(this LayoutBuilder b, Action<PropsBuilder<HtmlH6>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("h6", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML h6 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH6(this LayoutBuilder b, Action<PropsBuilder<HtmlH6>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("h6", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML h6 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH6(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("h6", children);
    }
    /// <summary>
    /// <para> The HTML h6 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH6(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("h6", children);
    }
}

