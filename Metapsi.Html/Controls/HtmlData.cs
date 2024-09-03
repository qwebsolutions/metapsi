using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Html;


public partial class HtmlData
{
}

public static partial class HtmlDataControl
{
    /// <summary>
    /// <para> The HTML data tag </para>
    /// </summary>
    public static IHtmlNode HtmlData(this HtmlBuilder b, Action<AttributesBuilder<HtmlData>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("data", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML data tag </para>
    /// </summary>
    public static IHtmlNode HtmlData(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("data", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML data tag </para>
    /// </summary>
    public static IHtmlNode HtmlData(this HtmlBuilder b, Action<AttributesBuilder<HtmlData>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("data", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML data tag </para>
    /// </summary>
    public static IHtmlNode HtmlData(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("data", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML data tag </para>
    /// </summary>
    public static Var<IVNode> HtmlData(this LayoutBuilder b, Action<PropsBuilder<HtmlData>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("data", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML data tag </para>
    /// </summary>
    public static Var<IVNode> HtmlData(this LayoutBuilder b, Action<PropsBuilder<HtmlData>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("data", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML data tag </para>
    /// </summary>
    public static Var<IVNode> HtmlData(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("data", children);
    }
    /// <summary>
    /// <para> The HTML data tag </para>
    /// </summary>
    public static Var<IVNode> HtmlData(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("data", children);
    }
}

