using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlProgress
{
}

public static partial class HtmlProgressControl
{
    /// <summary>
    /// <para> The HTML progress tag </para>
    /// </summary>
    public static IHtmlNode HtmlProgress(this HtmlBuilder b, Action<AttributesBuilder<HtmlProgress>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("progress", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML progress tag </para>
    /// </summary>
    public static IHtmlNode HtmlProgress(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("progress", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML progress tag </para>
    /// </summary>
    public static IHtmlNode HtmlProgress(this HtmlBuilder b, Action<AttributesBuilder<HtmlProgress>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("progress", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML progress tag </para>
    /// </summary>
    public static IHtmlNode HtmlProgress(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("progress", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML progress tag </para>
    /// </summary>
    public static Var<IVNode> HtmlProgress(this LayoutBuilder b, Action<PropsBuilder<HtmlProgress>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("progress", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML progress tag </para>
    /// </summary>
    public static Var<IVNode> HtmlProgress(this LayoutBuilder b, Action<PropsBuilder<HtmlProgress>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("progress", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML progress tag </para>
    /// </summary>
    public static Var<IVNode> HtmlProgress(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("progress", children);
    }
    /// <summary>
    /// <para> The HTML progress tag </para>
    /// </summary>
    public static Var<IVNode> HtmlProgress(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("progress", children);
    }
}

