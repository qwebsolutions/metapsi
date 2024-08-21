using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlRp
{
}

public static partial class HtmlRpControl
{
    /// <summary>
    /// <para> The HTML rp tag </para>
    /// </summary>
    public static IHtmlNode HtmlRp(this HtmlBuilder b, Action<AttributesBuilder<HtmlRp>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("rp", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML rp tag </para>
    /// </summary>
    public static IHtmlNode HtmlRp(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("rp", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML rp tag </para>
    /// </summary>
    public static IHtmlNode HtmlRp(this HtmlBuilder b, Action<AttributesBuilder<HtmlRp>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("rp", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML rp tag </para>
    /// </summary>
    public static IHtmlNode HtmlRp(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("rp", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML rp tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRp(this LayoutBuilder b, Action<PropsBuilder<HtmlRp>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("rp", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML rp tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRp(this LayoutBuilder b, Action<PropsBuilder<HtmlRp>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("rp", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML rp tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRp(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("rp", children);
    }
    /// <summary>
    /// <para> The HTML rp tag </para>
    /// </summary>
    public static Var<IVNode> HtmlRp(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("rp", children);
    }
}

