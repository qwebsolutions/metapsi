using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlDetails
{
}

public static partial class HtmlDetailsControl
{
    /// <summary>
    /// <para> The HTML details tag </para>
    /// </summary>
    public static IHtmlNode HtmlDetails(this HtmlBuilder b, Action<AttributesBuilder<HtmlDetails>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("details", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML details tag </para>
    /// </summary>
    public static IHtmlNode HtmlDetails(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("details", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML details tag </para>
    /// </summary>
    public static IHtmlNode HtmlDetails(this HtmlBuilder b, Action<AttributesBuilder<HtmlDetails>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("details", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML details tag </para>
    /// </summary>
    public static IHtmlNode HtmlDetails(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("details", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML details tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDetails(this LayoutBuilder b, Action<PropsBuilder<HtmlDetails>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("details", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML details tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDetails(this LayoutBuilder b, Action<PropsBuilder<HtmlDetails>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("details", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML details tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDetails(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("details", children);
    }
    /// <summary>
    /// <para> The HTML details tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDetails(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("details", children);
    }
}

