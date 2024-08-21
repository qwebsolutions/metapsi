using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlStrong
{
}

public static partial class HtmlStrongControl
{
    /// <summary>
    /// <para> The HTML strong tag </para>
    /// </summary>
    public static IHtmlNode HtmlStrong(this HtmlBuilder b, Action<AttributesBuilder<HtmlStrong>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("strong", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML strong tag </para>
    /// </summary>
    public static IHtmlNode HtmlStrong(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("strong", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML strong tag </para>
    /// </summary>
    public static IHtmlNode HtmlStrong(this HtmlBuilder b, Action<AttributesBuilder<HtmlStrong>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("strong", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML strong tag </para>
    /// </summary>
    public static IHtmlNode HtmlStrong(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("strong", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML strong tag </para>
    /// </summary>
    public static Var<IVNode> HtmlStrong(this LayoutBuilder b, Action<PropsBuilder<HtmlStrong>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("strong", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML strong tag </para>
    /// </summary>
    public static Var<IVNode> HtmlStrong(this LayoutBuilder b, Action<PropsBuilder<HtmlStrong>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("strong", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML strong tag </para>
    /// </summary>
    public static Var<IVNode> HtmlStrong(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("strong", children);
    }
    /// <summary>
    /// <para> The HTML strong tag </para>
    /// </summary>
    public static Var<IVNode> HtmlStrong(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("strong", children);
    }
}

