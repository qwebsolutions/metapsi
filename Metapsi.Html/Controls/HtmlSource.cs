using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSource
{
}

public static partial class HtmlSourceControl
{
    /// <summary>
    /// <para> The HTML source tag </para>
    /// </summary>
    public static IHtmlNode HtmlSource(this HtmlBuilder b, Action<AttributesBuilder<HtmlSource>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("source", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML source tag </para>
    /// </summary>
    public static IHtmlNode HtmlSource(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("source", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML source tag </para>
    /// </summary>
    public static IHtmlNode HtmlSource(this HtmlBuilder b, Action<AttributesBuilder<HtmlSource>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("source", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML source tag </para>
    /// </summary>
    public static IHtmlNode HtmlSource(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("source", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML source tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSource(this LayoutBuilder b, Action<PropsBuilder<HtmlSource>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("source", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML source tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSource(this LayoutBuilder b, Action<PropsBuilder<HtmlSource>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("source", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML source tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSource(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("source", children);
    }
    /// <summary>
    /// <para> The HTML source tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSource(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("source", children);
    }
}

