using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSection
{
}

public static partial class HtmlSectionControl
{
    /// <summary>
    /// <para> The HTML section tag </para>
    /// </summary>
    public static IHtmlNode HtmlSection(this HtmlBuilder b, Action<AttributesBuilder<HtmlSection>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("section", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML section tag </para>
    /// </summary>
    public static IHtmlNode HtmlSection(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("section", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML section tag </para>
    /// </summary>
    public static IHtmlNode HtmlSection(this HtmlBuilder b, Action<AttributesBuilder<HtmlSection>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("section", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML section tag </para>
    /// </summary>
    public static IHtmlNode HtmlSection(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("section", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML section tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSection(this LayoutBuilder b, Action<PropsBuilder<HtmlSection>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("section", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML section tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSection(this LayoutBuilder b, Action<PropsBuilder<HtmlSection>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("section", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML section tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSection(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("section", children);
    }
    /// <summary>
    /// <para> The HTML section tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSection(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("section", children);
    }
}

