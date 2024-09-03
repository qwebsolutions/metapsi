using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlRt
{
}

public static partial class HtmlRtControl
{
    /// <summary>
    /// <para> The HTML rt tag </para>
    /// </summary>
    public static IHtmlNode HtmlRt(this HtmlBuilder b, Action<AttributesBuilder<HtmlRt>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("rt", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML rt tag </para>
    /// </summary>
    public static IHtmlNode HtmlRt(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("rt", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML rt tag </para>
    /// </summary>
    public static IHtmlNode HtmlRt(this HtmlBuilder b, Action<AttributesBuilder<HtmlRt>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("rt", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML rt tag </para>
    /// </summary>
    public static IHtmlNode HtmlRt(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("rt", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML rt tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRt(this LayoutBuilder b, Action<PropsBuilder<HtmlRt>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("rt", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML rt tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRt(this LayoutBuilder b, Action<PropsBuilder<HtmlRt>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("rt", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML rt tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRt(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("rt", children);
    }
    /// <summary>
    /// <para> The HTML rt tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRt(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("rt", children);
    }
}

