using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTd
{
}

public static partial class HtmlTdControl
{
    /// <summary>
    /// <para> The HTML td tag </para>
    /// </summary>
    public static IHtmlNode HtmlTd(this HtmlBuilder b, Action<AttributesBuilder<HtmlTd>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("td", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML td tag </para>
    /// </summary>
    public static IHtmlNode HtmlTd(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("td", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML td tag </para>
    /// </summary>
    public static IHtmlNode HtmlTd(this HtmlBuilder b, Action<AttributesBuilder<HtmlTd>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("td", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML td tag </para>
    /// </summary>
    public static IHtmlNode HtmlTd(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("td", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML td tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTd(this LayoutBuilder b, Action<PropsBuilder<HtmlTd>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("td", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML td tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTd(this LayoutBuilder b, Action<PropsBuilder<HtmlTd>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("td", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML td tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTd(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("td", children);
    }
    /// <summary>
    /// <para> The HTML td tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTd(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("td", children);
    }
}

