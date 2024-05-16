using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlVar
{
}

public static partial class HtmlVarControl
{
    /// <summary>
    /// The HTML var tag
    /// </summary>
    public static IHtmlNode HtmlVar(this HtmlBuilder b, Action<AttributesBuilder<HtmlVar>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("var", buildAttributes, children);
    }
    /// <summary>
    /// The HTML var tag
    /// </summary>
    public static IHtmlNode HtmlVar(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("var", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML var tag
    /// </summary>
    public static Var<IVNode> HtmlVar(this LayoutBuilder b, Action<PropsBuilder<HtmlVar>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("var", buildProps, children);
    }
    /// <summary>
    /// The HTML var tag
    /// </summary>
    public static Var<IVNode> HtmlVar(this LayoutBuilder b, Action<PropsBuilder<HtmlVar>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("var", buildProps, children);
    }
    /// <summary>
    /// The HTML var tag
    /// </summary>
    public static Var<IVNode> HtmlVar(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("var", children);
    }
    /// <summary>
    /// The HTML var tag
    /// </summary>
    public static Var<IVNode> HtmlVar(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("var", children);
    }
}

