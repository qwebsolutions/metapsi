using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlStrong
{
}

public static partial class HtmlStrongControl
{
    /// <summary>
    /// The HTML strong tag
    /// </summary>
    public static IHtmlNode HtmlStrong(this HtmlBuilder b, Action<AttributesBuilder<HtmlStrong>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("strong", buildAttributes, children);
    }
    /// <summary>
    /// The HTML strong tag
    /// </summary>
    public static IHtmlNode HtmlStrong(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("strong", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML strong tag
    /// </summary>
    public static Var<IVNode> HtmlStrong(this LayoutBuilder b, Action<PropsBuilder<HtmlStrong>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("strong", buildProps, children);
    }
    /// <summary>
    /// The HTML strong tag
    /// </summary>
    public static Var<IVNode> HtmlStrong(this LayoutBuilder b, Action<PropsBuilder<HtmlStrong>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("strong", buildProps, children);
    }
    /// <summary>
    /// The HTML strong tag
    /// </summary>
    public static Var<IVNode> HtmlStrong(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("strong", children);
    }
    /// <summary>
    /// The HTML strong tag
    /// </summary>
    public static Var<IVNode> HtmlStrong(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("strong", children);
    }
}

