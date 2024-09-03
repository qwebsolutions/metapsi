using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlDatalist
{
}

public static partial class HtmlDatalistControl
{
    /// <summary>
    /// <para> The HTML datalist tag </para>
    /// </summary>
    public static IHtmlNode HtmlDatalist(this HtmlBuilder b, Action<AttributesBuilder<HtmlDatalist>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("datalist", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML datalist tag </para>
    /// </summary>
    public static IHtmlNode HtmlDatalist(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("datalist", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML datalist tag </para>
    /// </summary>
    public static IHtmlNode HtmlDatalist(this HtmlBuilder b, Action<AttributesBuilder<HtmlDatalist>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("datalist", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML datalist tag </para>
    /// </summary>
    public static IHtmlNode HtmlDatalist(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("datalist", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML datalist tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDatalist(this LayoutBuilder b, Action<PropsBuilder<HtmlDatalist>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("datalist", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML datalist tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDatalist(this LayoutBuilder b, Action<PropsBuilder<HtmlDatalist>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("datalist", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML datalist tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDatalist(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("datalist", children);
    }
    /// <summary>
    /// <para> The HTML datalist tag </para>
    /// </summary>
    public static Var<IVNode> HtmlDatalist(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("datalist", children);
    }
}

