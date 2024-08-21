using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlDel
{
}

public static partial class HtmlDelControl
{
    /// <summary>
    /// <para> The HTML del tag </para>
    /// </summary>
    public static IHtmlNode HtmlDel(this HtmlBuilder b, Action<AttributesBuilder<HtmlDel>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("del", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML del tag </para>
    /// </summary>
    public static IHtmlNode HtmlDel(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("del", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML del tag </para>
    /// </summary>
    public static IHtmlNode HtmlDel(this HtmlBuilder b, Action<AttributesBuilder<HtmlDel>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("del", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML del tag </para>
    /// </summary>
    public static IHtmlNode HtmlDel(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("del", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML del tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDel(this LayoutBuilder b, Action<PropsBuilder<HtmlDel>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("del", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML del tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDel(this LayoutBuilder b, Action<PropsBuilder<HtmlDel>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("del", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML del tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDel(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("del", children);
    }
    /// <summary>
    /// <para> The HTML del tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDel(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("del", children);
    }
}

