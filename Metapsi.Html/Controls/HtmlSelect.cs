using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSelect
{
}

public static partial class HtmlSelectControl
{
    /// <summary>
    /// <para> The HTML select tag </para>
    /// </summary>
    public static IHtmlNode HtmlSelect(this HtmlBuilder b, Action<AttributesBuilder<HtmlSelect>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("select", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML select tag </para>
    /// </summary>
    public static IHtmlNode HtmlSelect(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("select", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML select tag </para>
    /// </summary>
    public static IHtmlNode HtmlSelect(this HtmlBuilder b, Action<AttributesBuilder<HtmlSelect>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("select", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML select tag </para>
    /// </summary>
    public static IHtmlNode HtmlSelect(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("select", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML select tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSelect(this LayoutBuilder b, Action<PropsBuilder<HtmlSelect>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("select", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML select tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSelect(this LayoutBuilder b, Action<PropsBuilder<HtmlSelect>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("select", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML select tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSelect(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("select", children);
    }
    /// <summary>
    /// <para> The HTML select tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSelect(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("select", children);
    }
}

