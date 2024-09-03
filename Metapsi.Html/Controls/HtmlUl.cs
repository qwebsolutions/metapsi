using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlUl
{
}

public static partial class HtmlUlControl
{
    /// <summary>
    /// <para> The HTML ul tag </para>
    /// </summary>
    public static IHtmlNode HtmlUl(this HtmlBuilder b, Action<AttributesBuilder<HtmlUl>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ul", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML ul tag </para>
    /// </summary>
    public static IHtmlNode HtmlUl(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ul", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML ul tag </para>
    /// </summary>
    public static IHtmlNode HtmlUl(this HtmlBuilder b, Action<AttributesBuilder<HtmlUl>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("ul", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML ul tag </para>
    /// </summary>
    public static IHtmlNode HtmlUl(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("ul", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML ul tag </para>
    /// </summary>
    public static Var<IVNode> HtmlUl(this LayoutBuilder b, Action<PropsBuilder<HtmlUl>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("ul", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML ul tag </para>
    /// </summary>
    public static Var<IVNode> HtmlUl(this LayoutBuilder b, Action<PropsBuilder<HtmlUl>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("ul", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML ul tag </para>
    /// </summary>
    public static Var<IVNode> HtmlUl(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("ul", children);
    }
    /// <summary>
    /// <para> The HTML ul tag </para>
    /// </summary>
    public static Var<IVNode> HtmlUl(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("ul", children);
    }
}

