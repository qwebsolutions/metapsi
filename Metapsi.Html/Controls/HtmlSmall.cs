using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlSmall
{
}

public static partial class HtmlSmallControl
{
    /// <summary>
    /// <para> The HTML small tag </para>
    /// </summary>
    public static IHtmlNode HtmlSmall(this HtmlBuilder b, Action<AttributesBuilder<HtmlSmall>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("small", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML small tag </para>
    /// </summary>
    public static IHtmlNode HtmlSmall(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("small", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML small tag </para>
    /// </summary>
    public static IHtmlNode HtmlSmall(this HtmlBuilder b, Action<AttributesBuilder<HtmlSmall>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("small", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML small tag </para>
    /// </summary>
    public static IHtmlNode HtmlSmall(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("small", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML small tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSmall(this LayoutBuilder b, Action<PropsBuilder<HtmlSmall>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("small", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML small tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSmall(this LayoutBuilder b, Action<PropsBuilder<HtmlSmall>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("small", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML small tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSmall(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("small", children);
    }
    /// <summary>
    /// <para> The HTML small tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSmall(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("small", children);
    }
}

