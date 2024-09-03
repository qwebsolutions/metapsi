using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlCol
{
}

public static partial class HtmlColControl
{
    /// <summary>
    /// <para> The HTML col tag </para>
    /// </summary>
    public static IHtmlNode HtmlCol(this HtmlBuilder b, Action<AttributesBuilder<HtmlCol>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("col", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML col tag </para>
    /// </summary>
    public static IHtmlNode HtmlCol(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("col", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML col tag </para>
    /// </summary>
    public static IHtmlNode HtmlCol(this HtmlBuilder b, Action<AttributesBuilder<HtmlCol>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("col", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML col tag </para>
    /// </summary>
    public static IHtmlNode HtmlCol(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("col", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML col tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCol(this LayoutBuilder b, Action<PropsBuilder<HtmlCol>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("col", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML col tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCol(this LayoutBuilder b, Action<PropsBuilder<HtmlCol>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("col", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML col tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCol(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("col", children);
    }
    /// <summary>
    /// <para> The HTML col tag </para>
    /// </summary>
    public static Var<IVNode> HtmlCol(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("col", children);
    }
}

