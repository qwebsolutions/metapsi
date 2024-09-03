using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlHeader
{
}

public static partial class HtmlHeaderControl
{
    /// <summary>
    /// <para> The HTML header tag </para>
    /// </summary>
    public static IHtmlNode HtmlHeader(this HtmlBuilder b, Action<AttributesBuilder<HtmlHeader>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("header", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML header tag </para>
    /// </summary>
    public static IHtmlNode HtmlHeader(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("header", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML header tag </para>
    /// </summary>
    public static IHtmlNode HtmlHeader(this HtmlBuilder b, Action<AttributesBuilder<HtmlHeader>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("header", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML header tag </para>
    /// </summary>
    public static IHtmlNode HtmlHeader(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("header", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML header tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHeader(this LayoutBuilder b, Action<PropsBuilder<HtmlHeader>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("header", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML header tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHeader(this LayoutBuilder b, Action<PropsBuilder<HtmlHeader>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("header", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML header tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHeader(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("header", children);
    }
    /// <summary>
    /// <para> The HTML header tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHeader(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("header", children);
    }
}

