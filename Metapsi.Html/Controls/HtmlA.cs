using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlA
{
}

public static partial class HtmlAControl
{
    /// <summary>
    /// The HTML a tag
    /// </summary>
    public static IHtmlNode HtmlA(this HtmlBuilder b, Action<AttributesBuilder<HtmlA>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("a", buildAttributes, children);
    }
    /// <summary>
    /// The HTML a tag
    /// </summary>
    public static IHtmlNode HtmlA(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("a", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML a tag
    /// </summary>
    public static Var<IVNode> HtmlA(this LayoutBuilder b, Action<PropsBuilder<HtmlA>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("a", buildProps, children);
    }
    /// <summary>
    /// The HTML a tag
    /// </summary>
    public static Var<IVNode> HtmlA(this LayoutBuilder b, Action<PropsBuilder<HtmlA>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("a", buildProps, children);
    }
    /// <summary>
    /// The HTML a tag
    /// </summary>
    public static Var<IVNode> HtmlA(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("a", children);
    }
    /// <summary>
    /// The HTML a tag
    /// </summary>
    public static Var<IVNode> HtmlA(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("a", children);
    }
}

