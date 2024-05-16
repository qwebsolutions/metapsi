using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlFigure
{
}

public static partial class HtmlFigureControl
{
    /// <summary>
    /// The HTML figure tag
    /// </summary>
    public static IHtmlNode HtmlFigure(this HtmlBuilder b, Action<AttributesBuilder<HtmlFigure>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("figure", buildAttributes, children);
    }
    /// <summary>
    /// The HTML figure tag
    /// </summary>
    public static IHtmlNode HtmlFigure(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("figure", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML figure tag
    /// </summary>
    public static Var<IVNode> HtmlFigure(this LayoutBuilder b, Action<PropsBuilder<HtmlFigure>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("figure", buildProps, children);
    }
    /// <summary>
    /// The HTML figure tag
    /// </summary>
    public static Var<IVNode> HtmlFigure(this LayoutBuilder b, Action<PropsBuilder<HtmlFigure>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("figure", buildProps, children);
    }
    /// <summary>
    /// The HTML figure tag
    /// </summary>
    public static Var<IVNode> HtmlFigure(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("figure", children);
    }
    /// <summary>
    /// The HTML figure tag
    /// </summary>
    public static Var<IVNode> HtmlFigure(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("figure", children);
    }
}

