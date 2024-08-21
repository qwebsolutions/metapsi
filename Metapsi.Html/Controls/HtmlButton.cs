using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlButton
{
}

public static partial class HtmlButtonControl
{
    /// <summary>
    /// <para> The HTML button tag </para>
    /// </summary>
    public static IHtmlNode HtmlButton(this HtmlBuilder b, Action<AttributesBuilder<HtmlButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("button", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML button tag </para>
    /// </summary>
    public static IHtmlNode HtmlButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML button tag </para>
    /// </summary>
    public static IHtmlNode HtmlButton(this HtmlBuilder b, Action<AttributesBuilder<HtmlButton>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("button", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML button tag </para>
    /// </summary>
    public static IHtmlNode HtmlButton(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML button tag </para>
    /// </summary>
    public static Var<IVNode> HtmlButton(this LayoutBuilder b, Action<PropsBuilder<HtmlButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("button", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML button tag </para>
    /// </summary>
    public static Var<IVNode> HtmlButton(this LayoutBuilder b, Action<PropsBuilder<HtmlButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("button", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML button tag </para>
    /// </summary>
    public static Var<IVNode> HtmlButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("button", children);
    }
    /// <summary>
    /// <para> The HTML button tag </para>
    /// </summary>
    public static Var<IVNode> HtmlButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("button", children);
    }
}

