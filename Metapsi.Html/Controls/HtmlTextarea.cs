using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTextarea
{
}

public static partial class HtmlTextareaControl
{
    /// <summary>
    /// The HTML textarea tag
    /// </summary>
    public static IHtmlNode HtmlTextarea(this HtmlBuilder b, Action<AttributesBuilder<HtmlTextarea>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("textarea", buildAttributes, children);
    }
    /// <summary>
    /// The HTML textarea tag
    /// </summary>
    public static IHtmlNode HtmlTextarea(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("textarea", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML textarea tag
    /// </summary>
    public static Var<IVNode> HtmlTextarea(this LayoutBuilder b, Action<PropsBuilder<HtmlTextarea>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("textarea", buildProps, children);
    }
    /// <summary>
    /// The HTML textarea tag
    /// </summary>
    public static Var<IVNode> HtmlTextarea(this LayoutBuilder b, Action<PropsBuilder<HtmlTextarea>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("textarea", buildProps, children);
    }
    /// <summary>
    /// The HTML textarea tag
    /// </summary>
    public static Var<IVNode> HtmlTextarea(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("textarea", children);
    }
    /// <summary>
    /// The HTML textarea tag
    /// </summary>
    public static Var<IVNode> HtmlTextarea(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("textarea", children);
    }
}

