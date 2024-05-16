using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlMath
{
}

public static partial class HtmlMathControl
{
    /// <summary>
    /// The HTML math tag
    /// </summary>
    public static IHtmlNode HtmlMath(this HtmlBuilder b, Action<AttributesBuilder<HtmlMath>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("math", buildAttributes, children);
    }
    /// <summary>
    /// The HTML math tag
    /// </summary>
    public static IHtmlNode HtmlMath(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("math", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML math tag
    /// </summary>
    public static Var<IVNode> HtmlMath(this LayoutBuilder b, Action<PropsBuilder<HtmlMath>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("math", buildProps, children);
    }
    /// <summary>
    /// The HTML math tag
    /// </summary>
    public static Var<IVNode> HtmlMath(this LayoutBuilder b, Action<PropsBuilder<HtmlMath>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("math", buildProps, children);
    }
    /// <summary>
    /// The HTML math tag
    /// </summary>
    public static Var<IVNode> HtmlMath(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("math", children);
    }
    /// <summary>
    /// The HTML math tag
    /// </summary>
    public static Var<IVNode> HtmlMath(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("math", children);
    }
}

