using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlCaption
{
}

public static partial class HtmlCaptionControl
{
    /// <summary>
    /// <para> The HTML caption tag </para>
    /// </summary>
    public static IHtmlNode HtmlCaption(this HtmlBuilder b, Action<AttributesBuilder<HtmlCaption>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("caption", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML caption tag </para>
    /// </summary>
    public static IHtmlNode HtmlCaption(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("caption", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML caption tag </para>
    /// </summary>
    public static IHtmlNode HtmlCaption(this HtmlBuilder b, Action<AttributesBuilder<HtmlCaption>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("caption", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML caption tag </para>
    /// </summary>
    public static IHtmlNode HtmlCaption(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("caption", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML caption tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCaption(this LayoutBuilder b, Action<PropsBuilder<HtmlCaption>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("caption", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML caption tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCaption(this LayoutBuilder b, Action<PropsBuilder<HtmlCaption>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("caption", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML caption tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCaption(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("caption", children);
    }
    /// <summary>
    /// <para> The HTML caption tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCaption(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("caption", children);
    }
}

