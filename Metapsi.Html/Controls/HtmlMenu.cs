using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlMenu
{
}

public static partial class HtmlMenuControl
{
    /// <summary>
    /// <para> The HTML menu tag </para>
    /// </summary>
    public static IHtmlNode HtmlMenu(this HtmlBuilder b, Action<AttributesBuilder<HtmlMenu>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("menu", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML menu tag </para>
    /// </summary>
    public static IHtmlNode HtmlMenu(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("menu", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML menu tag </para>
    /// </summary>
    public static IHtmlNode HtmlMenu(this HtmlBuilder b, Action<AttributesBuilder<HtmlMenu>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("menu", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML menu tag </para>
    /// </summary>
    public static IHtmlNode HtmlMenu(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("menu", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML menu tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMenu(this LayoutBuilder b, Action<PropsBuilder<HtmlMenu>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("menu", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML menu tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMenu(this LayoutBuilder b, Action<PropsBuilder<HtmlMenu>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("menu", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML menu tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMenu(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("menu", children);
    }
    /// <summary>
    /// <para> The HTML menu tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMenu(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("menu", children);
    }
}

