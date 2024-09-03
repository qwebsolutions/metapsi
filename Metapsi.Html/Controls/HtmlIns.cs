using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlIns
{
}

public static partial class HtmlInsControl
{
    /// <summary>
    /// <para> The HTML ins tag </para>
    /// </summary>
    public static IHtmlNode HtmlIns(this HtmlBuilder b, Action<AttributesBuilder<HtmlIns>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ins", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML ins tag </para>
    /// </summary>
    public static IHtmlNode HtmlIns(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ins", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML ins tag </para>
    /// </summary>
    public static IHtmlNode HtmlIns(this HtmlBuilder b, Action<AttributesBuilder<HtmlIns>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("ins", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML ins tag </para>
    /// </summary>
    public static IHtmlNode HtmlIns(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("ins", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML ins tag </para>
    /// </summary>
    public static Var<IVNode> HtmlIns(this LayoutBuilder b, Action<PropsBuilder<HtmlIns>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("ins", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML ins tag </para>
    /// </summary>
    public static Var<IVNode> HtmlIns(this LayoutBuilder b, Action<PropsBuilder<HtmlIns>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("ins", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML ins tag </para>
    /// </summary>
    public static Var<IVNode> HtmlIns(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("ins", children);
    }
    /// <summary>
    /// <para> The HTML ins tag </para>
    /// </summary>
    public static Var<IVNode> HtmlIns(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("ins", children);
    }
}

