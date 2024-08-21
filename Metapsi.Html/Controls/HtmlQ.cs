using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlQ
{
}

public static partial class HtmlQControl
{
    /// <summary>
    /// <para> The HTML q tag </para>
    /// </summary>
    public static IHtmlNode HtmlQ(this HtmlBuilder b, Action<AttributesBuilder<HtmlQ>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("q", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML q tag </para>
    /// </summary>
    public static IHtmlNode HtmlQ(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("q", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML q tag </para>
    /// </summary>
    public static IHtmlNode HtmlQ(this HtmlBuilder b, Action<AttributesBuilder<HtmlQ>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("q", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML q tag </para>
    /// </summary>
    public static IHtmlNode HtmlQ(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("q", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML q tag </para>
    /// </summary>
    public static Var<IVNode> HtmlQ(this LayoutBuilder b, Action<PropsBuilder<HtmlQ>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("q", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML q tag </para>
    /// </summary>
    public static Var<IVNode> HtmlQ(this LayoutBuilder b, Action<PropsBuilder<HtmlQ>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("q", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML q tag </para>
    /// </summary>
    public static Var<IVNode> HtmlQ(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("q", children);
    }
    /// <summary>
    /// <para> The HTML q tag </para>
    /// </summary>
    public static Var<IVNode> HtmlQ(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("q", children);
    }
}

