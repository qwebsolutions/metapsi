using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlDiv
{
}

public static partial class HtmlDivControl
{
    /// <summary>
    /// <para> The HTML div tag </para>
    /// </summary>
    public static IHtmlNode HtmlDiv(this HtmlBuilder b, Action<AttributesBuilder<HtmlDiv>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("div", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML div tag </para>
    /// </summary>
    public static IHtmlNode HtmlDiv(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("div", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML div tag </para>
    /// </summary>
    public static IHtmlNode HtmlDiv(this HtmlBuilder b, Action<AttributesBuilder<HtmlDiv>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("div", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML div tag </para>
    /// </summary>
    public static IHtmlNode HtmlDiv(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("div", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML div tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDiv(this LayoutBuilder b, Action<PropsBuilder<HtmlDiv>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("div", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML div tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDiv(this LayoutBuilder b, Action<PropsBuilder<HtmlDiv>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("div", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML div tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDiv(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("div", children);
    }
    /// <summary>
    /// <para> The HTML div tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDiv(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("div", children);
    }
}

