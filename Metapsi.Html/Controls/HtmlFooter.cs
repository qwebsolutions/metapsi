using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlFooter
{
}

public static partial class HtmlFooterControl
{
    /// <summary>
    /// The HTML footer tag
    /// </summary>
    public static IHtmlNode HtmlFooter(this HtmlBuilder b, Action<AttributesBuilder<HtmlFooter>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("footer", buildAttributes, children);
    }
    /// <summary>
    /// The HTML footer tag
    /// </summary>
    public static IHtmlNode HtmlFooter(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("footer", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML footer tag
    /// </summary>
    public static Var<IVNode> HtmlFooter(this LayoutBuilder b, Action<PropsBuilder<HtmlFooter>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("footer", buildProps, children);
    }
    /// <summary>
    /// The HTML footer tag
    /// </summary>
    public static Var<IVNode> HtmlFooter(this LayoutBuilder b, Action<PropsBuilder<HtmlFooter>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("footer", buildProps, children);
    }
    /// <summary>
    /// The HTML footer tag
    /// </summary>
    public static Var<IVNode> HtmlFooter(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("footer", children);
    }
    /// <summary>
    /// The HTML footer tag
    /// </summary>
    public static Var<IVNode> HtmlFooter(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("footer", children);
    }
}

