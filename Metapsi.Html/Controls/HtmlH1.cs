using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlH1
{
}

public static partial class HtmlH1Control
{
    /// <summary>
    /// <para> The HTML h1 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH1(this HtmlBuilder b, Action<AttributesBuilder<HtmlH1>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("h1", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML h1 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH1(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("h1", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML h1 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH1(this HtmlBuilder b, Action<AttributesBuilder<HtmlH1>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("h1", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML h1 tag </para>
    /// </summary>
    public static IHtmlNode HtmlH1(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("h1", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML h1 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH1(this LayoutBuilder b, Action<PropsBuilder<HtmlH1>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("h1", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML h1 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH1(this LayoutBuilder b, Action<PropsBuilder<HtmlH1>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("h1", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML h1 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH1(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("h1", children);
    }
    /// <summary>
    /// <para> The HTML h1 tag </para>
    /// </summary>
    public static Var<IVNode> HtmlH1(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("h1", children);
    }
}

