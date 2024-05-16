using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlU
{
}

public static partial class HtmlUControl
{
    /// <summary>
    /// The HTML u tag
    /// </summary>
    public static IHtmlNode HtmlU(this HtmlBuilder b, Action<AttributesBuilder<HtmlU>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("u", buildAttributes, children);
    }
    /// <summary>
    /// The HTML u tag
    /// </summary>
    public static IHtmlNode HtmlU(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("u", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML u tag
    /// </summary>
    public static Var<IVNode> HtmlU(this LayoutBuilder b, Action<PropsBuilder<HtmlU>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("u", buildProps, children);
    }
    /// <summary>
    /// The HTML u tag
    /// </summary>
    public static Var<IVNode> HtmlU(this LayoutBuilder b, Action<PropsBuilder<HtmlU>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("u", buildProps, children);
    }
    /// <summary>
    /// The HTML u tag
    /// </summary>
    public static Var<IVNode> HtmlU(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("u", children);
    }
    /// <summary>
    /// The HTML u tag
    /// </summary>
    public static Var<IVNode> HtmlU(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("u", children);
    }
}

