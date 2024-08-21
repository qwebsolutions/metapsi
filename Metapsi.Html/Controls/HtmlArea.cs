using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlArea
{
}

public static partial class HtmlAreaControl
{
    /// <summary>
    /// <para> The HTML area tag </para>
    /// </summary>
    public static IHtmlNode HtmlArea(this HtmlBuilder b, Action<AttributesBuilder<HtmlArea>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("area", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML area tag </para>
    /// </summary>
    public static IHtmlNode HtmlArea(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("area", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML area tag </para>
    /// </summary>
    public static IHtmlNode HtmlArea(this HtmlBuilder b, Action<AttributesBuilder<HtmlArea>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("area", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML area tag </para>
    /// </summary>
    public static IHtmlNode HtmlArea(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("area", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML area tag </para>
    /// </summary>
    public static Var<IVNode> HtmlArea(this LayoutBuilder b, Action<PropsBuilder<HtmlArea>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("area", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML area tag </para>
    /// </summary>
    public static Var<IVNode> HtmlArea(this LayoutBuilder b, Action<PropsBuilder<HtmlArea>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("area", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML area tag </para>
    /// </summary>
    public static Var<IVNode> HtmlArea(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("area", children);
    }
    /// <summary>
    /// <para> The HTML area tag </para>
    /// </summary>
    public static Var<IVNode> HtmlArea(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("area", children);
    }
}

