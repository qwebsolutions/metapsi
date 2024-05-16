using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlEmbed
{
}

public static partial class HtmlEmbedControl
{
    /// <summary>
    /// The HTML embed tag
    /// </summary>
    public static IHtmlNode HtmlEmbed(this HtmlBuilder b, Action<AttributesBuilder<HtmlEmbed>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("embed", buildAttributes, children);
    }
    /// <summary>
    /// The HTML embed tag
    /// </summary>
    public static IHtmlNode HtmlEmbed(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("embed", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML embed tag
    /// </summary>
    public static Var<IVNode> HtmlEmbed(this LayoutBuilder b, Action<PropsBuilder<HtmlEmbed>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("embed", buildProps, children);
    }
    /// <summary>
    /// The HTML embed tag
    /// </summary>
    public static Var<IVNode> HtmlEmbed(this LayoutBuilder b, Action<PropsBuilder<HtmlEmbed>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("embed", buildProps, children);
    }
    /// <summary>
    /// The HTML embed tag
    /// </summary>
    public static Var<IVNode> HtmlEmbed(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("embed", children);
    }
    /// <summary>
    /// The HTML embed tag
    /// </summary>
    public static Var<IVNode> HtmlEmbed(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("embed", children);
    }
}

