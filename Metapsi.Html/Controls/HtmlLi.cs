using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlLi
{
}

public static partial class HtmlLiControl
{
    /// <summary>
    /// <para> The HTML li tag </para>
    /// </summary>
    public static IHtmlNode HtmlLi(this HtmlBuilder b, Action<AttributesBuilder<HtmlLi>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("li", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML li tag </para>
    /// </summary>
    public static IHtmlNode HtmlLi(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("li", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML li tag </para>
    /// </summary>
    public static IHtmlNode HtmlLi(this HtmlBuilder b, Action<AttributesBuilder<HtmlLi>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("li", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML li tag </para>
    /// </summary>
    public static IHtmlNode HtmlLi(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("li", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML li tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLi(this LayoutBuilder b, Action<PropsBuilder<HtmlLi>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("li", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML li tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLi(this LayoutBuilder b, Action<PropsBuilder<HtmlLi>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("li", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML li tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLi(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("li", children);
    }
    /// <summary>
    /// <para> The HTML li tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLi(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("li", children);
    }
}

