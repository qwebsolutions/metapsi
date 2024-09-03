using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlMark
{
}

public static partial class HtmlMarkControl
{
    /// <summary>
    /// <para> The HTML mark tag </para>
    /// </summary>
    public static IHtmlNode HtmlMark(this HtmlBuilder b, Action<AttributesBuilder<HtmlMark>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("mark", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML mark tag </para>
    /// </summary>
    public static IHtmlNode HtmlMark(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("mark", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML mark tag </para>
    /// </summary>
    public static IHtmlNode HtmlMark(this HtmlBuilder b, Action<AttributesBuilder<HtmlMark>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("mark", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML mark tag </para>
    /// </summary>
    public static IHtmlNode HtmlMark(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("mark", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML mark tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMark(this LayoutBuilder b, Action<PropsBuilder<HtmlMark>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("mark", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML mark tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMark(this LayoutBuilder b, Action<PropsBuilder<HtmlMark>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("mark", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML mark tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMark(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("mark", children);
    }
    /// <summary>
    /// <para> The HTML mark tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMark(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("mark", children);
    }
}

