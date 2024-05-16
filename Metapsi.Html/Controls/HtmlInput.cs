using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlInput
{
}

public static partial class HtmlInputControl
{
    /// <summary>
    /// The HTML input tag
    /// </summary>
    public static IHtmlNode HtmlInput(this HtmlBuilder b, Action<AttributesBuilder<HtmlInput>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("input", buildAttributes, children);
    }
    /// <summary>
    /// The HTML input tag
    /// </summary>
    public static IHtmlNode HtmlInput(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("input", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML input tag
    /// </summary>
    public static Var<IVNode> HtmlInput(this LayoutBuilder b, Action<PropsBuilder<HtmlInput>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("input", buildProps, children);
    }
    /// <summary>
    /// The HTML input tag
    /// </summary>
    public static Var<IVNode> HtmlInput(this LayoutBuilder b, Action<PropsBuilder<HtmlInput>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("input", buildProps, children);
    }
    /// <summary>
    /// The HTML input tag
    /// </summary>
    public static Var<IVNode> HtmlInput(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("input", children);
    }
    /// <summary>
    /// The HTML input tag
    /// </summary>
    public static Var<IVNode> HtmlInput(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("input", children);
    }
}

