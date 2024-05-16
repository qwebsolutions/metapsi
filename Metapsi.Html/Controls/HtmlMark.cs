using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlMark
{
}

public static partial class HtmlMarkControl
{
    /// <summary>
    /// The HTML mark tag
    /// </summary>
    public static IHtmlNode HtmlMark(this HtmlBuilder b, Action<AttributesBuilder<HtmlMark>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("mark", buildAttributes, children);
    }
    /// <summary>
    /// The HTML mark tag
    /// </summary>
    public static IHtmlNode HtmlMark(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("mark", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML mark tag
    /// </summary>
    public static Var<IVNode> HtmlMark(this LayoutBuilder b, Action<PropsBuilder<HtmlMark>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("mark", buildProps, children);
    }
    /// <summary>
    /// The HTML mark tag
    /// </summary>
    public static Var<IVNode> HtmlMark(this LayoutBuilder b, Action<PropsBuilder<HtmlMark>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("mark", buildProps, children);
    }
    /// <summary>
    /// The HTML mark tag
    /// </summary>
    public static Var<IVNode> HtmlMark(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("mark", children);
    }
    /// <summary>
    /// The HTML mark tag
    /// </summary>
    public static Var<IVNode> HtmlMark(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("mark", children);
    }
}

