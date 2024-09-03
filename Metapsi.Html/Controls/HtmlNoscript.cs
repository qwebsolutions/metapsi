using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlNoscript
{
}

public static partial class HtmlNoscriptControl
{
    /// <summary>
    /// <para> The HTML noscript tag </para>
    /// </summary>
    public static IHtmlNode HtmlNoscript(this HtmlBuilder b, Action<AttributesBuilder<HtmlNoscript>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("noscript", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML noscript tag </para>
    /// </summary>
    public static IHtmlNode HtmlNoscript(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("noscript", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML noscript tag </para>
    /// </summary>
    public static IHtmlNode HtmlNoscript(this HtmlBuilder b, Action<AttributesBuilder<HtmlNoscript>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("noscript", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML noscript tag </para>
    /// </summary>
    public static IHtmlNode HtmlNoscript(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("noscript", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML noscript tag </para>
    /// </summary>
    public static Var<IVNode> HtmlNoscript(this LayoutBuilder b, Action<PropsBuilder<HtmlNoscript>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("noscript", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML noscript tag </para>
    /// </summary>
    public static Var<IVNode> HtmlNoscript(this LayoutBuilder b, Action<PropsBuilder<HtmlNoscript>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("noscript", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML noscript tag </para>
    /// </summary>
    public static Var<IVNode> HtmlNoscript(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("noscript", children);
    }
    /// <summary>
    /// <para> The HTML noscript tag </para>
    /// </summary>
    public static Var<IVNode> HtmlNoscript(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("noscript", children);
    }
}

