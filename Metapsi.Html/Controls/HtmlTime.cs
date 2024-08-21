using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTime
{
}

public static partial class HtmlTimeControl
{
    /// <summary>
    /// <para> The HTML time tag </para>
    /// </summary>
    public static IHtmlNode HtmlTime(this HtmlBuilder b, Action<AttributesBuilder<HtmlTime>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("time", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML time tag </para>
    /// </summary>
    public static IHtmlNode HtmlTime(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("time", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML time tag </para>
    /// </summary>
    public static IHtmlNode HtmlTime(this HtmlBuilder b, Action<AttributesBuilder<HtmlTime>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("time", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML time tag </para>
    /// </summary>
    public static IHtmlNode HtmlTime(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("time", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML time tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTime(this LayoutBuilder b, Action<PropsBuilder<HtmlTime>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("time", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML time tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTime(this LayoutBuilder b, Action<PropsBuilder<HtmlTime>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("time", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML time tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTime(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("time", children);
    }
    /// <summary>
    /// <para> The HTML time tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTime(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("time", children);
    }
}

