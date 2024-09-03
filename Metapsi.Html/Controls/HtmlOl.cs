using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlOl
{
}

public static partial class HtmlOlControl
{
    /// <summary>
    /// <para> The HTML ol tag </para>
    /// </summary>
    public static IHtmlNode HtmlOl(this HtmlBuilder b, Action<AttributesBuilder<HtmlOl>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ol", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML ol tag </para>
    /// </summary>
    public static IHtmlNode HtmlOl(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ol", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML ol tag </para>
    /// </summary>
    public static IHtmlNode HtmlOl(this HtmlBuilder b, Action<AttributesBuilder<HtmlOl>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("ol", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML ol tag </para>
    /// </summary>
    public static IHtmlNode HtmlOl(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("ol", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML ol tag </para>
    /// </summary>
    public static Var<IVNode> HtmlOl(this LayoutBuilder b, Action<PropsBuilder<HtmlOl>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("ol", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML ol tag </para>
    /// </summary>
    public static Var<IVNode> HtmlOl(this LayoutBuilder b, Action<PropsBuilder<HtmlOl>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("ol", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML ol tag </para>
    /// </summary>
    public static Var<IVNode> HtmlOl(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("ol", children);
    }
    /// <summary>
    /// <para> The HTML ol tag </para>
    /// </summary>
    public static Var<IVNode> HtmlOl(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("ol", children);
    }
}

