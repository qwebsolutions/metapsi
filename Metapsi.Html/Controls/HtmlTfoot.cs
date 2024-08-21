using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTfoot
{
}

public static partial class HtmlTfootControl
{
    /// <summary>
    /// <para> The HTML tfoot tag </para>
    /// </summary>
    public static IHtmlNode HtmlTfoot(this HtmlBuilder b, Action<AttributesBuilder<HtmlTfoot>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("tfoot", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML tfoot tag </para>
    /// </summary>
    public static IHtmlNode HtmlTfoot(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("tfoot", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML tfoot tag </para>
    /// </summary>
    public static IHtmlNode HtmlTfoot(this HtmlBuilder b, Action<AttributesBuilder<HtmlTfoot>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("tfoot", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML tfoot tag </para>
    /// </summary>
    public static IHtmlNode HtmlTfoot(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("tfoot", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML tfoot tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTfoot(this LayoutBuilder b, Action<PropsBuilder<HtmlTfoot>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("tfoot", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML tfoot tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTfoot(this LayoutBuilder b, Action<PropsBuilder<HtmlTfoot>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("tfoot", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML tfoot tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTfoot(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("tfoot", children);
    }
    /// <summary>
    /// <para> The HTML tfoot tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTfoot(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("tfoot", children);
    }
}

