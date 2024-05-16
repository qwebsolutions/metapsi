using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlBlockquote
{
}

public static partial class HtmlBlockquoteControl
{
    /// <summary>
    /// The HTML blockquote tag
    /// </summary>
    public static IHtmlNode HtmlBlockquote(this HtmlBuilder b, Action<AttributesBuilder<HtmlBlockquote>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("blockquote", buildAttributes, children);
    }
    /// <summary>
    /// The HTML blockquote tag
    /// </summary>
    public static IHtmlNode HtmlBlockquote(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("blockquote", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML blockquote tag
    /// </summary>
    public static Var<IVNode> HtmlBlockquote(this LayoutBuilder b, Action<PropsBuilder<HtmlBlockquote>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("blockquote", buildProps, children);
    }
    /// <summary>
    /// The HTML blockquote tag
    /// </summary>
    public static Var<IVNode> HtmlBlockquote(this LayoutBuilder b, Action<PropsBuilder<HtmlBlockquote>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("blockquote", buildProps, children);
    }
    /// <summary>
    /// The HTML blockquote tag
    /// </summary>
    public static Var<IVNode> HtmlBlockquote(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("blockquote", children);
    }
    /// <summary>
    /// The HTML blockquote tag
    /// </summary>
    public static Var<IVNode> HtmlBlockquote(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("blockquote", children);
    }
}

