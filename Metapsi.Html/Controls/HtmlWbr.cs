using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlWbr
{
}

public static partial class HtmlWbrControl
{
    /// <summary>
    /// <para> The HTML wbr tag </para>
    /// </summary>
    public static IHtmlNode HtmlWbr(this HtmlBuilder b, Action<AttributesBuilder<HtmlWbr>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("wbr", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML wbr tag </para>
    /// </summary>
    public static IHtmlNode HtmlWbr(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("wbr", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML wbr tag </para>
    /// </summary>
    public static IHtmlNode HtmlWbr(this HtmlBuilder b, Action<AttributesBuilder<HtmlWbr>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("wbr", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML wbr tag </para>
    /// </summary>
    public static IHtmlNode HtmlWbr(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("wbr", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML wbr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlWbr(this LayoutBuilder b, Action<PropsBuilder<HtmlWbr>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("wbr", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML wbr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlWbr(this LayoutBuilder b, Action<PropsBuilder<HtmlWbr>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("wbr", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML wbr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlWbr(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("wbr", children);
    }
    /// <summary>
    /// <para> The HTML wbr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlWbr(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("wbr", children);
    }
}

