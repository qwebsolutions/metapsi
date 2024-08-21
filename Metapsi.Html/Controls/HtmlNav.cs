using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlNav
{
}

public static partial class HtmlNavControl
{
    /// <summary>
    /// <para> The HTML nav tag </para>
    /// </summary>
    public static IHtmlNode HtmlNav(this HtmlBuilder b, Action<AttributesBuilder<HtmlNav>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("nav", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML nav tag </para>
    /// </summary>
    public static IHtmlNode HtmlNav(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("nav", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML nav tag </para>
    /// </summary>
    public static IHtmlNode HtmlNav(this HtmlBuilder b, Action<AttributesBuilder<HtmlNav>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("nav", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML nav tag </para>
    /// </summary>
    public static IHtmlNode HtmlNav(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("nav", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML nav tag </para>
    /// </summary>
    public static Var<IVNode> HtmlNav(this LayoutBuilder b, Action<PropsBuilder<HtmlNav>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("nav", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML nav tag </para>
    /// </summary>
    public static Var<IVNode> HtmlNav(this LayoutBuilder b, Action<PropsBuilder<HtmlNav>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("nav", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML nav tag </para>
    /// </summary>
    public static Var<IVNode> HtmlNav(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("nav", children);
    }
    /// <summary>
    /// <para> The HTML nav tag </para>
    /// </summary>
    public static Var<IVNode> HtmlNav(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("nav", children);
    }
}

