using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlA
{
}

public static partial class HtmlAControl
{
    /// <summary>
    /// <para> The HTML a tag </para>
    /// </summary>
    public static IHtmlNode HtmlA(this HtmlBuilder b, Action<AttributesBuilder<HtmlA>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("a", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML a tag </para>
    /// </summary>
    public static IHtmlNode HtmlA(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("a", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML a tag </para>
    /// </summary>
    public static IHtmlNode HtmlA(this HtmlBuilder b, Action<AttributesBuilder<HtmlA>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("a", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML a tag </para>
    /// </summary>
    public static IHtmlNode HtmlA(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("a", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static void SetHref(this AttributesBuilder<HtmlA> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    ///
    /// </summary>
    public static void SetTarget(this AttributesBuilder<HtmlA> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// <para> The HTML a tag </para>
    /// </summary>
    public static Var<IVNode> HtmlA(this LayoutBuilder b, Action<PropsBuilder<HtmlA>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("a", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML a tag </para>
    /// </summary>
    public static Var<IVNode> HtmlA(this LayoutBuilder b, Action<PropsBuilder<HtmlA>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("a", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML a tag </para>
    /// </summary>
    public static Var<IVNode> HtmlA(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("a", children);
    }
    /// <summary>
    /// <para> The HTML a tag </para>
    /// </summary>
    public static Var<IVNode> HtmlA(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("a", children);
    }
}

