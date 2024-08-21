using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSup
{
}

public static partial class HtmlSupControl
{
    /// <summary>
    /// <para> The HTML sup tag </para>
    /// </summary>
    public static IHtmlNode HtmlSup(this HtmlBuilder b, Action<AttributesBuilder<HtmlSup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sup", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML sup tag </para>
    /// </summary>
    public static IHtmlNode HtmlSup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sup", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML sup tag </para>
    /// </summary>
    public static IHtmlNode HtmlSup(this HtmlBuilder b, Action<AttributesBuilder<HtmlSup>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("sup", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML sup tag </para>
    /// </summary>
    public static IHtmlNode HtmlSup(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("sup", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML sup tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSup(this LayoutBuilder b, Action<PropsBuilder<HtmlSup>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sup", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML sup tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSup(this LayoutBuilder b, Action<PropsBuilder<HtmlSup>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sup", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML sup tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sup", children);
    }
    /// <summary>
    /// <para> The HTML sup tag </para>
    /// </summary>
    public static Var<IVNode> HtmlSup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sup", children);
    }
}

