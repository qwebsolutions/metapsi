using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlOutput
{
}

public static partial class HtmlOutputControl
{
    /// <summary>
    /// <para> The HTML output tag </para>
    /// </summary>
    public static IHtmlNode HtmlOutput(this HtmlBuilder b, Action<AttributesBuilder<HtmlOutput>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("output", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML output tag </para>
    /// </summary>
    public static IHtmlNode HtmlOutput(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("output", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML output tag </para>
    /// </summary>
    public static IHtmlNode HtmlOutput(this HtmlBuilder b, Action<AttributesBuilder<HtmlOutput>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("output", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML output tag </para>
    /// </summary>
    public static IHtmlNode HtmlOutput(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("output", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML output tag </para>
    /// </summary>
    public static Var<IVNode> HtmlOutput(this LayoutBuilder b, Action<PropsBuilder<HtmlOutput>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("output", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML output tag </para>
    /// </summary>
    public static Var<IVNode> HtmlOutput(this LayoutBuilder b, Action<PropsBuilder<HtmlOutput>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("output", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML output tag </para>
    /// </summary>
    public static Var<IVNode> HtmlOutput(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("output", children);
    }
    /// <summary>
    /// <para> The HTML output tag </para>
    /// </summary>
    public static Var<IVNode> HtmlOutput(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("output", children);
    }
}

