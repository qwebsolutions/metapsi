using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlTh
{
}

public static partial class HtmlThControl
{
    /// <summary>
    /// <para> The HTML th tag </para>
    /// </summary>
    public static IHtmlNode HtmlTh(this HtmlBuilder b, Action<AttributesBuilder<HtmlTh>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("th", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML th tag </para>
    /// </summary>
    public static IHtmlNode HtmlTh(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("th", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML th tag </para>
    /// </summary>
    public static IHtmlNode HtmlTh(this HtmlBuilder b, Action<AttributesBuilder<HtmlTh>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("th", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML th tag </para>
    /// </summary>
    public static IHtmlNode HtmlTh(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("th", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML th tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTh(this LayoutBuilder b, Action<PropsBuilder<HtmlTh>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("th", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML th tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTh(this LayoutBuilder b, Action<PropsBuilder<HtmlTh>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("th", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML th tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTh(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("th", children);
    }
    /// <summary>
    /// <para> The HTML th tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTh(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("th", children);
    }
}

