using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlBase
{
}

public static partial class HtmlBaseControl
{
    /// <summary>
    /// <para> The HTML base tag </para>
    /// </summary>
    public static IHtmlNode HtmlBase(this HtmlBuilder b, Action<AttributesBuilder<HtmlBase>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("base", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML base tag </para>
    /// </summary>
    public static IHtmlNode HtmlBase(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("base", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML base tag </para>
    /// </summary>
    public static IHtmlNode HtmlBase(this HtmlBuilder b, Action<AttributesBuilder<HtmlBase>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("base", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML base tag </para>
    /// </summary>
    public static IHtmlNode HtmlBase(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("base", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML base tag </para>
    /// </summary>
    public static Var<IVNode> HtmlBase(this LayoutBuilder b, Action<PropsBuilder<HtmlBase>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("base", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML base tag </para>
    /// </summary>
    public static Var<IVNode> HtmlBase(this LayoutBuilder b, Action<PropsBuilder<HtmlBase>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("base", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML base tag </para>
    /// </summary>
    public static Var<IVNode> HtmlBase(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("base", children);
    }
    /// <summary>
    /// <para> The HTML base tag </para>
    /// </summary>
    public static Var<IVNode> HtmlBase(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("base", children);
    }
}

