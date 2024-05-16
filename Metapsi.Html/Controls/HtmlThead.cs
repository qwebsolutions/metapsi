using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlThead
{
}

public static partial class HtmlTheadControl
{
    /// <summary>
    /// The HTML thead tag
    /// </summary>
    public static IHtmlNode HtmlThead(this HtmlBuilder b, Action<AttributesBuilder<HtmlThead>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("thead", buildAttributes, children);
    }
    /// <summary>
    /// The HTML thead tag
    /// </summary>
    public static IHtmlNode HtmlThead(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("thead", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML thead tag
    /// </summary>
    public static Var<IVNode> HtmlThead(this LayoutBuilder b, Action<PropsBuilder<HtmlThead>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("thead", buildProps, children);
    }
    /// <summary>
    /// The HTML thead tag
    /// </summary>
    public static Var<IVNode> HtmlThead(this LayoutBuilder b, Action<PropsBuilder<HtmlThead>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("thead", buildProps, children);
    }
    /// <summary>
    /// The HTML thead tag
    /// </summary>
    public static Var<IVNode> HtmlThead(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("thead", children);
    }
    /// <summary>
    /// The HTML thead tag
    /// </summary>
    public static Var<IVNode> HtmlThead(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("thead", children);
    }
}

