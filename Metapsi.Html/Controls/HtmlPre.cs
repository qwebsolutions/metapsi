using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlPre
{
}

public static partial class HtmlPreControl
{
    /// <summary>
    /// <para> The HTML pre tag </para>
    /// </summary>
    public static IHtmlNode HtmlPre(this HtmlBuilder b, Action<AttributesBuilder<HtmlPre>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("pre", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML pre tag </para>
    /// </summary>
    public static IHtmlNode HtmlPre(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("pre", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML pre tag </para>
    /// </summary>
    public static IHtmlNode HtmlPre(this HtmlBuilder b, Action<AttributesBuilder<HtmlPre>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("pre", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML pre tag </para>
    /// </summary>
    public static IHtmlNode HtmlPre(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("pre", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML pre tag </para>
    /// </summary>
    public static Var<IVNode> HtmlPre(this LayoutBuilder b, Action<PropsBuilder<HtmlPre>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("pre", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML pre tag </para>
    /// </summary>
    public static Var<IVNode> HtmlPre(this LayoutBuilder b, Action<PropsBuilder<HtmlPre>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("pre", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML pre tag </para>
    /// </summary>
    public static Var<IVNode> HtmlPre(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("pre", children);
    }
    /// <summary>
    /// <para> The HTML pre tag </para>
    /// </summary>
    public static Var<IVNode> HtmlPre(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("pre", children);
    }
}

