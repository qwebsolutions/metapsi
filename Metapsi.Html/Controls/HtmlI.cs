using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlI
{
}

public static partial class HtmlIControl
{
    /// <summary>
    /// <para> The HTML i tag </para>
    /// </summary>
    public static IHtmlNode HtmlI(this HtmlBuilder b, Action<AttributesBuilder<HtmlI>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("i", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML i tag </para>
    /// </summary>
    public static IHtmlNode HtmlI(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("i", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML i tag </para>
    /// </summary>
    public static IHtmlNode HtmlI(this HtmlBuilder b, Action<AttributesBuilder<HtmlI>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("i", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML i tag </para>
    /// </summary>
    public static IHtmlNode HtmlI(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("i", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML i tag </para>
    /// </summary>
    public static Var<IVNode> HtmlI(this LayoutBuilder b, Action<PropsBuilder<HtmlI>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("i", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML i tag </para>
    /// </summary>
    public static Var<IVNode> HtmlI(this LayoutBuilder b, Action<PropsBuilder<HtmlI>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("i", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML i tag </para>
    /// </summary>
    public static Var<IVNode> HtmlI(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("i", children);
    }
    /// <summary>
    /// <para> The HTML i tag </para>
    /// </summary>
    public static Var<IVNode> HtmlI(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("i", children);
    }
}

