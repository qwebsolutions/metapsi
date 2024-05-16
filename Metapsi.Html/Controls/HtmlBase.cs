using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlBase
{
}

public static partial class HtmlBaseControl
{
    /// <summary>
    /// The HTML base tag
    /// </summary>
    public static IHtmlNode HtmlBase(this HtmlBuilder b, Action<AttributesBuilder<HtmlBase>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("base", buildAttributes, children);
    }
    /// <summary>
    /// The HTML base tag
    /// </summary>
    public static IHtmlNode HtmlBase(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("base", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML base tag
    /// </summary>
    public static Var<IVNode> HtmlBase(this LayoutBuilder b, Action<PropsBuilder<HtmlBase>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("base", buildProps, children);
    }
    /// <summary>
    /// The HTML base tag
    /// </summary>
    public static Var<IVNode> HtmlBase(this LayoutBuilder b, Action<PropsBuilder<HtmlBase>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("base", buildProps, children);
    }
    /// <summary>
    /// The HTML base tag
    /// </summary>
    public static Var<IVNode> HtmlBase(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("base", children);
    }
    /// <summary>
    /// The HTML base tag
    /// </summary>
    public static Var<IVNode> HtmlBase(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("base", children);
    }
}

