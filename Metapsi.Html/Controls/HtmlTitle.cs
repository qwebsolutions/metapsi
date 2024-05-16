using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTitle
{
}

public static partial class HtmlTitleControl
{
    /// <summary>
    /// The HTML title tag
    /// </summary>
    public static IHtmlNode HtmlTitle(this HtmlBuilder b, Action<AttributesBuilder<HtmlTitle>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("title", buildAttributes, children);
    }
    /// <summary>
    /// The HTML title tag
    /// </summary>
    public static IHtmlNode HtmlTitle(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("title", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML title tag
    /// </summary>
    public static Var<IVNode> HtmlTitle(this LayoutBuilder b, Action<PropsBuilder<HtmlTitle>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("title", buildProps, children);
    }
    /// <summary>
    /// The HTML title tag
    /// </summary>
    public static Var<IVNode> HtmlTitle(this LayoutBuilder b, Action<PropsBuilder<HtmlTitle>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("title", buildProps, children);
    }
    /// <summary>
    /// The HTML title tag
    /// </summary>
    public static Var<IVNode> HtmlTitle(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("title", children);
    }
    /// <summary>
    /// The HTML title tag
    /// </summary>
    public static Var<IVNode> HtmlTitle(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("title", children);
    }
}

