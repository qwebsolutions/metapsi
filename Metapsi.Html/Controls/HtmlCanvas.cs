using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlCanvas
{
}

public static partial class HtmlCanvasControl
{
    /// <summary>
    /// The HTML canvas tag
    /// </summary>
    public static IHtmlNode HtmlCanvas(this HtmlBuilder b, Action<AttributesBuilder<HtmlCanvas>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("canvas", buildAttributes, children);
    }
    /// <summary>
    /// The HTML canvas tag
    /// </summary>
    public static IHtmlNode HtmlCanvas(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("canvas", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML canvas tag
    /// </summary>
    public static Var<IVNode> HtmlCanvas(this LayoutBuilder b, Action<PropsBuilder<HtmlCanvas>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("canvas", buildProps, children);
    }
    /// <summary>
    /// The HTML canvas tag
    /// </summary>
    public static Var<IVNode> HtmlCanvas(this LayoutBuilder b, Action<PropsBuilder<HtmlCanvas>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("canvas", buildProps, children);
    }
    /// <summary>
    /// The HTML canvas tag
    /// </summary>
    public static Var<IVNode> HtmlCanvas(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("canvas", children);
    }
    /// <summary>
    /// The HTML canvas tag
    /// </summary>
    public static Var<IVNode> HtmlCanvas(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("canvas", children);
    }
}

