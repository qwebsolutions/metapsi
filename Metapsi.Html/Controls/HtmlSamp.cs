using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSamp
{
}

public static partial class HtmlSampControl
{
    /// <summary>
    /// <para> The HTML samp tag </para>
    /// </summary>
    public static IHtmlNode HtmlSamp(this HtmlBuilder b, Action<AttributesBuilder<HtmlSamp>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("samp", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML samp tag </para>
    /// </summary>
    public static IHtmlNode HtmlSamp(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("samp", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML samp tag </para>
    /// </summary>
    public static IHtmlNode HtmlSamp(this HtmlBuilder b, Action<AttributesBuilder<HtmlSamp>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("samp", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML samp tag </para>
    /// </summary>
    public static IHtmlNode HtmlSamp(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("samp", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML samp tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSamp(this LayoutBuilder b, Action<PropsBuilder<HtmlSamp>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("samp", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML samp tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSamp(this LayoutBuilder b, Action<PropsBuilder<HtmlSamp>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("samp", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML samp tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSamp(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("samp", children);
    }
    /// <summary>
    /// <para> The HTML samp tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSamp(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("samp", children);
    }
}

