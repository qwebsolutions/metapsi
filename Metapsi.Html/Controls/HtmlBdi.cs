using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlBdi
{
}

public static partial class HtmlBdiControl
{
    /// <summary>
    /// <para> The HTML bdi tag </para>
    /// </summary>
    public static IHtmlNode HtmlBdi(this HtmlBuilder b, Action<AttributesBuilder<HtmlBdi>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("bdi", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML bdi tag </para>
    /// </summary>
    public static IHtmlNode HtmlBdi(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("bdi", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML bdi tag </para>
    /// </summary>
    public static IHtmlNode HtmlBdi(this HtmlBuilder b, Action<AttributesBuilder<HtmlBdi>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("bdi", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML bdi tag </para>
    /// </summary>
    public static IHtmlNode HtmlBdi(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("bdi", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML bdi tag </para>
    /// </summary>
    public static Var<IVNode> HtmlBdi(this LayoutBuilder b, Action<PropsBuilder<HtmlBdi>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("bdi", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML bdi tag </para>
    /// </summary>
    public static Var<IVNode> HtmlBdi(this LayoutBuilder b, Action<PropsBuilder<HtmlBdi>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("bdi", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML bdi tag </para>
    /// </summary>
    public static Var<IVNode> HtmlBdi(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("bdi", children);
    }
    /// <summary>
    /// <para> The HTML bdi tag </para>
    /// </summary>
    public static Var<IVNode> HtmlBdi(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("bdi", children);
    }
}

