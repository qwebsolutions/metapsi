using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlEm
{
}

public static partial class HtmlEmControl
{
    /// <summary>
    /// <para> The HTML em tag </para>
    /// </summary>
    public static IHtmlNode HtmlEm(this HtmlBuilder b, Action<AttributesBuilder<HtmlEm>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("em", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML em tag </para>
    /// </summary>
    public static IHtmlNode HtmlEm(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("em", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML em tag </para>
    /// </summary>
    public static IHtmlNode HtmlEm(this HtmlBuilder b, Action<AttributesBuilder<HtmlEm>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("em", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML em tag </para>
    /// </summary>
    public static IHtmlNode HtmlEm(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("em", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML em tag </para>
    /// </summary>
    public static Var<IVNode> HtmlEm(this LayoutBuilder b, Action<PropsBuilder<HtmlEm>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("em", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML em tag </para>
    /// </summary>
    public static Var<IVNode> HtmlEm(this LayoutBuilder b, Action<PropsBuilder<HtmlEm>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("em", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML em tag </para>
    /// </summary>
    public static Var<IVNode> HtmlEm(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("em", children);
    }
    /// <summary>
    /// <para> The HTML em tag </para>
    /// </summary>
    public static Var<IVNode> HtmlEm(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("em", children);
    }
}

