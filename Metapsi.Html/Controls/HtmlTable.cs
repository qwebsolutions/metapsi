using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlTable
{
}

public static partial class HtmlTableControl
{
    /// <summary>
    /// <para> The HTML table tag </para>
    /// </summary>
    public static IHtmlNode HtmlTable(this HtmlBuilder b, Action<AttributesBuilder<HtmlTable>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("table", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML table tag </para>
    /// </summary>
    public static IHtmlNode HtmlTable(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("table", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML table tag </para>
    /// </summary>
    public static IHtmlNode HtmlTable(this HtmlBuilder b, Action<AttributesBuilder<HtmlTable>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("table", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML table tag </para>
    /// </summary>
    public static IHtmlNode HtmlTable(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("table", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML table tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTable(this LayoutBuilder b, Action<PropsBuilder<HtmlTable>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("table", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML table tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTable(this LayoutBuilder b, Action<PropsBuilder<HtmlTable>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("table", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML table tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTable(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("table", children);
    }
    /// <summary>
    /// <para> The HTML table tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTable(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("table", children);
    }
}

