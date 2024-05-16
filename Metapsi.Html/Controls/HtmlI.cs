using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlI
{
}

public static partial class HtmlIControl
{
    /// <summary>
    /// The HTML i tag
    /// </summary>
    public static IHtmlNode HtmlI(this HtmlBuilder b, Action<AttributesBuilder<HtmlI>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("i", buildAttributes, children);
    }
    /// <summary>
    /// The HTML i tag
    /// </summary>
    public static IHtmlNode HtmlI(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("i", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML i tag
    /// </summary>
    public static Var<IVNode> HtmlI(this LayoutBuilder b, Action<PropsBuilder<HtmlI>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("i", buildProps, children);
    }
    /// <summary>
    /// The HTML i tag
    /// </summary>
    public static Var<IVNode> HtmlI(this LayoutBuilder b, Action<PropsBuilder<HtmlI>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("i", buildProps, children);
    }
    /// <summary>
    /// The HTML i tag
    /// </summary>
    public static Var<IVNode> HtmlI(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("i", children);
    }
    /// <summary>
    /// The HTML i tag
    /// </summary>
    public static Var<IVNode> HtmlI(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("i", children);
    }
}

