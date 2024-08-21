using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlAddress
{
}

public static partial class HtmlAddressControl
{
    /// <summary>
    /// <para> The HTML address tag </para>
    /// </summary>
    public static IHtmlNode HtmlAddress(this HtmlBuilder b, Action<AttributesBuilder<HtmlAddress>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("address", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML address tag </para>
    /// </summary>
    public static IHtmlNode HtmlAddress(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("address", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML address tag </para>
    /// </summary>
    public static IHtmlNode HtmlAddress(this HtmlBuilder b, Action<AttributesBuilder<HtmlAddress>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("address", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML address tag </para>
    /// </summary>
    public static IHtmlNode HtmlAddress(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("address", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML address tag </para>
    /// </summary>
    public static Var<IVNode> HtmlAddress(this LayoutBuilder b, Action<PropsBuilder<HtmlAddress>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("address", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML address tag </para>
    /// </summary>
    public static Var<IVNode> HtmlAddress(this LayoutBuilder b, Action<PropsBuilder<HtmlAddress>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("address", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML address tag </para>
    /// </summary>
    public static Var<IVNode> HtmlAddress(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("address", children);
    }
    /// <summary>
    /// <para> The HTML address tag </para>
    /// </summary>
    public static Var<IVNode> HtmlAddress(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("address", children);
    }
}

