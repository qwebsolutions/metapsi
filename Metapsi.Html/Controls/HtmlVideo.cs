using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlVideo
{
}

public static partial class HtmlVideoControl
{
    /// <summary>
    /// The HTML video tag
    /// </summary>
    public static IHtmlNode HtmlVideo(this HtmlBuilder b, Action<AttributesBuilder<HtmlVideo>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("video", buildAttributes, children);
    }
    /// <summary>
    /// The HTML video tag
    /// </summary>
    public static IHtmlNode HtmlVideo(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("video", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML video tag
    /// </summary>
    public static Var<IVNode> HtmlVideo(this LayoutBuilder b, Action<PropsBuilder<HtmlVideo>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("video", buildProps, children);
    }
    /// <summary>
    /// The HTML video tag
    /// </summary>
    public static Var<IVNode> HtmlVideo(this LayoutBuilder b, Action<PropsBuilder<HtmlVideo>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("video", buildProps, children);
    }
    /// <summary>
    /// The HTML video tag
    /// </summary>
    public static Var<IVNode> HtmlVideo(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("video", children);
    }
    /// <summary>
    /// The HTML video tag
    /// </summary>
    public static Var<IVNode> HtmlVideo(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("video", children);
    }
}

