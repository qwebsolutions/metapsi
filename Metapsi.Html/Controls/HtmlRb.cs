using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlRb
{
}

public static partial class HtmlRbControl
{
    /// <summary>
    /// <para> The HTML rb tag </para>
    /// </summary>
    public static IHtmlNode HtmlRb(this HtmlBuilder b, Action<AttributesBuilder<HtmlRb>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("rb", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML rb tag </para>
    /// </summary>
    public static IHtmlNode HtmlRb(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("rb", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML rb tag </para>
    /// </summary>
    public static IHtmlNode HtmlRb(this HtmlBuilder b, Action<AttributesBuilder<HtmlRb>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("rb", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML rb tag </para>
    /// </summary>
    public static IHtmlNode HtmlRb(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("rb", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML rb tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRb(this LayoutBuilder b, Action<PropsBuilder<HtmlRb>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("rb", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML rb tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRb(this LayoutBuilder b, Action<PropsBuilder<HtmlRb>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("rb", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML rb tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRb(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("rb", children);
    }
    /// <summary>
    /// <para> The HTML rb tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRb(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("rb", children);
    }
}

