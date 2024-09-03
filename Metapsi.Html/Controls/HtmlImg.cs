using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlImg
{
}

public static partial class HtmlImgControl
{
    /// <summary>
    /// <para> The HTML img tag </para>
    /// </summary>
    public static IHtmlNode HtmlImg(this HtmlBuilder b, Action<AttributesBuilder<HtmlImg>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("img", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML img tag </para>
    /// </summary>
    public static IHtmlNode HtmlImg(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("img", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML img tag </para>
    /// </summary>
    public static IHtmlNode HtmlImg(this HtmlBuilder b, Action<AttributesBuilder<HtmlImg>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("img", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML img tag </para>
    /// </summary>
    public static IHtmlNode HtmlImg(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("img", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML img tag </para>
    /// </summary>
    public static Var<IVNode> HtmlImg(this LayoutBuilder b, Action<PropsBuilder<HtmlImg>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("img", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML img tag </para>
    /// </summary>
    public static Var<IVNode> HtmlImg(this LayoutBuilder b, Action<PropsBuilder<HtmlImg>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("img", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML img tag </para>
    /// </summary>
    public static Var<IVNode> HtmlImg(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("img", children);
    }
    /// <summary>
    /// <para> The HTML img tag </para>
    /// </summary>
    public static Var<IVNode> HtmlImg(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("img", children);
    }
}

