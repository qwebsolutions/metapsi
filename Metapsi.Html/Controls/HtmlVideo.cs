using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlVideo
{
}

public static partial class HtmlVideoControl
{
    /// <summary>
    /// <para> The HTML video tag </para>
    /// </summary>
    public static IHtmlNode HtmlVideo(this HtmlBuilder b, Action<AttributesBuilder<HtmlVideo>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("video", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML video tag </para>
    /// </summary>
    public static IHtmlNode HtmlVideo(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("video", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML video tag </para>
    /// </summary>
    public static IHtmlNode HtmlVideo(this HtmlBuilder b, Action<AttributesBuilder<HtmlVideo>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("video", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML video tag </para>
    /// </summary>
    public static IHtmlNode HtmlVideo(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("video", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML video tag </para>
    /// </summary>
    public static Var<IVNode> HtmlVideo(this LayoutBuilder b, Action<PropsBuilder<HtmlVideo>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("video", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML video tag </para>
    /// </summary>
    public static Var<IVNode> HtmlVideo(this LayoutBuilder b, Action<PropsBuilder<HtmlVideo>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("video", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML video tag </para>
    /// </summary>
    public static Var<IVNode> HtmlVideo(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("video", children);
    }
    /// <summary>
    /// <para> The HTML video tag </para>
    /// </summary>
    public static Var<IVNode> HtmlVideo(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("video", children);
    }
}

