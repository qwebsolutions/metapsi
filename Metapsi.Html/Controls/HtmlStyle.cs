using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlStyle
{
}

public static partial class HtmlStyleControl
{
    /// <summary>
    /// <para> The HTML style tag </para>
    /// </summary>
    public static IHtmlNode HtmlStyle(this HtmlBuilder b, Action<AttributesBuilder<HtmlStyle>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("style", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML style tag </para>
    /// </summary>
    public static IHtmlNode HtmlStyle(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("style", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML style tag </para>
    /// </summary>
    public static IHtmlNode HtmlStyle(this HtmlBuilder b, Action<AttributesBuilder<HtmlStyle>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("style", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML style tag </para>
    /// </summary>
    public static IHtmlNode HtmlStyle(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("style", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML style tag </para>
    /// </summary>
    public static Var<IVNode> HtmlStyle(this LayoutBuilder b, Action<PropsBuilder<HtmlStyle>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("style", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML style tag </para>
    /// </summary>
    public static Var<IVNode> HtmlStyle(this LayoutBuilder b, Action<PropsBuilder<HtmlStyle>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("style", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML style tag </para>
    /// </summary>
    public static Var<IVNode> HtmlStyle(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("style", children);
    }
    /// <summary>
    /// <para> The HTML style tag </para>
    /// </summary>
    public static Var<IVNode> HtmlStyle(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("style", children);
    }
}

