using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlBr
{
}

public static partial class HtmlBrControl
{
    /// <summary>
    /// The HTML br tag
    /// </summary>
    public static IHtmlNode HtmlBr(this HtmlBuilder b, Action<AttributesBuilder<HtmlBr>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("br", buildAttributes, children);
    }
    /// <summary>
    /// The HTML br tag
    /// </summary>
    public static IHtmlNode HtmlBr(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("br", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML br tag
    /// </summary>
    public static Var<IVNode> HtmlBr(this LayoutBuilder b, Action<PropsBuilder<HtmlBr>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("br", buildProps, children);
    }
    /// <summary>
    /// The HTML br tag
    /// </summary>
    public static Var<IVNode> HtmlBr(this LayoutBuilder b, Action<PropsBuilder<HtmlBr>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("br", buildProps, children);
    }
    /// <summary>
    /// The HTML br tag
    /// </summary>
    public static Var<IVNode> HtmlBr(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("br", children);
    }
    /// <summary>
    /// The HTML br tag
    /// </summary>
    public static Var<IVNode> HtmlBr(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("br", children);
    }
}

