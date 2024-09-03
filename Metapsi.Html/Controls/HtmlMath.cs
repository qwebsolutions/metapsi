using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlMath
{
}

public static partial class HtmlMathControl
{
    /// <summary>
    /// <para> The HTML math tag </para>
    /// </summary>
    public static IHtmlNode HtmlMath(this HtmlBuilder b, Action<AttributesBuilder<HtmlMath>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("math", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML math tag </para>
    /// </summary>
    public static IHtmlNode HtmlMath(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("math", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML math tag </para>
    /// </summary>
    public static IHtmlNode HtmlMath(this HtmlBuilder b, Action<AttributesBuilder<HtmlMath>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("math", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML math tag </para>
    /// </summary>
    public static IHtmlNode HtmlMath(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("math", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML math tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMath(this LayoutBuilder b, Action<PropsBuilder<HtmlMath>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("math", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML math tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMath(this LayoutBuilder b, Action<PropsBuilder<HtmlMath>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("math", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML math tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMath(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("math", children);
    }
    /// <summary>
    /// <para> The HTML math tag </para>
    /// </summary>
    public static Var<IVNode> HtmlMath(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("math", children);
    }
}

