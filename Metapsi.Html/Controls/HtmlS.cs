using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlS
{
}

public static partial class HtmlSControl
{
    /// <summary>
    /// <para> The HTML s tag </para>
    /// </summary>
    public static IHtmlNode HtmlS(this HtmlBuilder b, Action<AttributesBuilder<HtmlS>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("s", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML s tag </para>
    /// </summary>
    public static IHtmlNode HtmlS(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("s", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML s tag </para>
    /// </summary>
    public static IHtmlNode HtmlS(this HtmlBuilder b, Action<AttributesBuilder<HtmlS>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("s", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML s tag </para>
    /// </summary>
    public static IHtmlNode HtmlS(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("s", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML s tag </para>
    /// </summary>
    public static Var<IVNode> HtmlS(this LayoutBuilder b, Action<PropsBuilder<HtmlS>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("s", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML s tag </para>
    /// </summary>
    public static Var<IVNode> HtmlS(this LayoutBuilder b, Action<PropsBuilder<HtmlS>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("s", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML s tag </para>
    /// </summary>
    public static Var<IVNode> HtmlS(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("s", children);
    }
    /// <summary>
    /// <para> The HTML s tag </para>
    /// </summary>
    public static Var<IVNode> HtmlS(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("s", children);
    }
}

