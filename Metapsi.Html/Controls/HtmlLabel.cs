using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlLabel
{
}

public static partial class HtmlLabelControl
{
    /// <summary>
    /// <para> The HTML label tag </para>
    /// </summary>
    public static IHtmlNode HtmlLabel(this HtmlBuilder b, Action<AttributesBuilder<HtmlLabel>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("label", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML label tag </para>
    /// </summary>
    public static IHtmlNode HtmlLabel(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("label", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML label tag </para>
    /// </summary>
    public static IHtmlNode HtmlLabel(this HtmlBuilder b, Action<AttributesBuilder<HtmlLabel>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("label", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML label tag </para>
    /// </summary>
    public static IHtmlNode HtmlLabel(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("label", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML label tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLabel(this LayoutBuilder b, Action<PropsBuilder<HtmlLabel>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("label", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML label tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLabel(this LayoutBuilder b, Action<PropsBuilder<HtmlLabel>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("label", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML label tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLabel(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("label", children);
    }
    /// <summary>
    /// <para> The HTML label tag </para>
    /// </summary>
    public static Var<IVNode> HtmlLabel(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("label", children);
    }
}

