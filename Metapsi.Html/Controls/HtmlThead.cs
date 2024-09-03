using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlThead
{
}

public static partial class HtmlTheadControl
{
    /// <summary>
    /// <para> The HTML thead tag </para>
    /// </summary>
    public static IHtmlNode HtmlThead(this HtmlBuilder b, Action<AttributesBuilder<HtmlThead>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("thead", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML thead tag </para>
    /// </summary>
    public static IHtmlNode HtmlThead(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("thead", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML thead tag </para>
    /// </summary>
    public static IHtmlNode HtmlThead(this HtmlBuilder b, Action<AttributesBuilder<HtmlThead>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("thead", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML thead tag </para>
    /// </summary>
    public static IHtmlNode HtmlThead(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("thead", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML thead tag </para>
    /// </summary>
    public static Var<IVNode> HtmlThead(this LayoutBuilder b, Action<PropsBuilder<HtmlThead>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("thead", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML thead tag </para>
    /// </summary>
    public static Var<IVNode> HtmlThead(this LayoutBuilder b, Action<PropsBuilder<HtmlThead>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("thead", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML thead tag </para>
    /// </summary>
    public static Var<IVNode> HtmlThead(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("thead", children);
    }
    /// <summary>
    /// <para> The HTML thead tag </para>
    /// </summary>
    public static Var<IVNode> HtmlThead(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("thead", children);
    }
}

