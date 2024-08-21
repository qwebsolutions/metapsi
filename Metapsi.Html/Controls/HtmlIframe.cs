using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlIframe
{
}

public static partial class HtmlIframeControl
{
    /// <summary>
    /// <para> The HTML iframe tag </para>
    /// </summary>
    public static IHtmlNode HtmlIframe(this HtmlBuilder b, Action<AttributesBuilder<HtmlIframe>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("iframe", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML iframe tag </para>
    /// </summary>
    public static IHtmlNode HtmlIframe(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("iframe", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML iframe tag </para>
    /// </summary>
    public static IHtmlNode HtmlIframe(this HtmlBuilder b, Action<AttributesBuilder<HtmlIframe>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("iframe", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML iframe tag </para>
    /// </summary>
    public static IHtmlNode HtmlIframe(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("iframe", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML iframe tag </para>
    /// </summary>
    public static Var<IVNode> HtmlIframe(this LayoutBuilder b, Action<PropsBuilder<HtmlIframe>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("iframe", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML iframe tag </para>
    /// </summary>
    public static Var<IVNode> HtmlIframe(this LayoutBuilder b, Action<PropsBuilder<HtmlIframe>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("iframe", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML iframe tag </para>
    /// </summary>
    public static Var<IVNode> HtmlIframe(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("iframe", children);
    }
    /// <summary>
    /// <para> The HTML iframe tag </para>
    /// </summary>
    public static Var<IVNode> HtmlIframe(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("iframe", children);
    }
}

