using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlRuby
{
}

public static partial class HtmlRubyControl
{
    /// <summary>
    /// The HTML ruby tag
    /// </summary>
    public static IHtmlNode HtmlRuby(this HtmlBuilder b, Action<AttributesBuilder<HtmlRuby>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ruby", buildAttributes, children);
    }
    /// <summary>
    /// The HTML ruby tag
    /// </summary>
    public static IHtmlNode HtmlRuby(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ruby", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML ruby tag
    /// </summary>
    public static Var<IVNode> HtmlRuby(this LayoutBuilder b, Action<PropsBuilder<HtmlRuby>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("ruby", buildProps, children);
    }
    /// <summary>
    /// The HTML ruby tag
    /// </summary>
    public static Var<IVNode> HtmlRuby(this LayoutBuilder b, Action<PropsBuilder<HtmlRuby>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("ruby", buildProps, children);
    }
    /// <summary>
    /// The HTML ruby tag
    /// </summary>
    public static Var<IVNode> HtmlRuby(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("ruby", children);
    }
    /// <summary>
    /// The HTML ruby tag
    /// </summary>
    public static Var<IVNode> HtmlRuby(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("ruby", children);
    }
}

