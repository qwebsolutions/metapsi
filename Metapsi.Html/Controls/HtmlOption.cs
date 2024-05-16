using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlOption
{
}

public static partial class HtmlOptionControl
{
    /// <summary>
    /// The HTML option tag
    /// </summary>
    public static IHtmlNode HtmlOption(this HtmlBuilder b, Action<AttributesBuilder<HtmlOption>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("option", buildAttributes, children);
    }
    /// <summary>
    /// The HTML option tag
    /// </summary>
    public static IHtmlNode HtmlOption(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("option", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML option tag
    /// </summary>
    public static Var<IVNode> HtmlOption(this LayoutBuilder b, Action<PropsBuilder<HtmlOption>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("option", buildProps, children);
    }
    /// <summary>
    /// The HTML option tag
    /// </summary>
    public static Var<IVNode> HtmlOption(this LayoutBuilder b, Action<PropsBuilder<HtmlOption>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("option", buildProps, children);
    }
    /// <summary>
    /// The HTML option tag
    /// </summary>
    public static Var<IVNode> HtmlOption(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("option", children);
    }
    /// <summary>
    /// The HTML option tag
    /// </summary>
    public static Var<IVNode> HtmlOption(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("option", children);
    }
}

