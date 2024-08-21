using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlMeta
{
}

public static partial class HtmlMetaControl
{
    /// <summary>
    /// <para> The HTML meta tag </para>
    /// </summary>
    public static IHtmlNode HtmlMeta(this HtmlBuilder b, Action<AttributesBuilder<HtmlMeta>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("meta", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML meta tag </para>
    /// </summary>
    public static IHtmlNode HtmlMeta(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("meta", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML meta tag </para>
    /// </summary>
    public static IHtmlNode HtmlMeta(this HtmlBuilder b, Action<AttributesBuilder<HtmlMeta>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("meta", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML meta tag </para>
    /// </summary>
    public static IHtmlNode HtmlMeta(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("meta", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML meta tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMeta(this LayoutBuilder b, Action<PropsBuilder<HtmlMeta>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("meta", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML meta tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMeta(this LayoutBuilder b, Action<PropsBuilder<HtmlMeta>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("meta", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML meta tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMeta(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("meta", children);
    }
    /// <summary>
    /// <para> The HTML meta tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMeta(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("meta", children);
    }
}

