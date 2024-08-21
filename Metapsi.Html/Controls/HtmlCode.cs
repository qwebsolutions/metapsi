using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlCode
{
}

public static partial class HtmlCodeControl
{
    /// <summary>
    /// <para> The HTML code tag </para>
    /// </summary>
    public static IHtmlNode HtmlCode(this HtmlBuilder b, Action<AttributesBuilder<HtmlCode>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("code", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML code tag </para>
    /// </summary>
    public static IHtmlNode HtmlCode(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("code", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML code tag </para>
    /// </summary>
    public static IHtmlNode HtmlCode(this HtmlBuilder b, Action<AttributesBuilder<HtmlCode>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("code", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML code tag </para>
    /// </summary>
    public static IHtmlNode HtmlCode(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("code", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML code tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCode(this LayoutBuilder b, Action<PropsBuilder<HtmlCode>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("code", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML code tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCode(this LayoutBuilder b, Action<PropsBuilder<HtmlCode>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("code", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML code tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCode(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("code", children);
    }
    /// <summary>
    /// <para> The HTML code tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCode(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("code", children);
    }
}

