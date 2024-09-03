using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlLink
{
}

public static partial class HtmlLinkControl
{
    /// <summary>
    /// <para> The HTML link tag </para>
    /// </summary>
    public static IHtmlNode HtmlLink(this HtmlBuilder b, Action<AttributesBuilder<HtmlLink>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("link", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML link tag </para>
    /// </summary>
    public static IHtmlNode HtmlLink(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("link", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML link tag </para>
    /// </summary>
    public static IHtmlNode HtmlLink(this HtmlBuilder b, Action<AttributesBuilder<HtmlLink>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("link", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML link tag </para>
    /// </summary>
    public static IHtmlNode HtmlLink(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("link", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static void SetHref(this AttributesBuilder<HtmlLink> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    ///
    /// </summary>
    public static void SetRel(this AttributesBuilder<HtmlLink> b, string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// <para> The HTML link tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLink(this LayoutBuilder b, Action<PropsBuilder<HtmlLink>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("link", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML link tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLink(this LayoutBuilder b, Action<PropsBuilder<HtmlLink>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("link", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML link tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLink(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("link", children);
    }
    /// <summary>
    /// <para> The HTML link tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLink(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("link", children);
    }
}

