using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlHr
{
}

public static partial class HtmlHrControl
{
    /// <summary>
    /// <para> The HTML hr tag </para>
    /// </summary>
    public static IHtmlNode HtmlHr(this HtmlBuilder b, Action<AttributesBuilder<HtmlHr>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("hr", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML hr tag </para>
    /// </summary>
    public static IHtmlNode HtmlHr(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("hr", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML hr tag </para>
    /// </summary>
    public static IHtmlNode HtmlHr(this HtmlBuilder b, Action<AttributesBuilder<HtmlHr>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("hr", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML hr tag </para>
    /// </summary>
    public static IHtmlNode HtmlHr(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("hr", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML hr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHr(this LayoutBuilder b, Action<PropsBuilder<HtmlHr>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("hr", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML hr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHr(this LayoutBuilder b, Action<PropsBuilder<HtmlHr>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("hr", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML hr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHr(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("hr", children);
    }
    /// <summary>
    /// <para> The HTML hr tag </para>
    /// </summary>
    public static Var<IVNode> HtmlHr(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("hr", children);
    }
}

