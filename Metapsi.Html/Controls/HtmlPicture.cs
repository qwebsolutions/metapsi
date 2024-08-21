using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlPicture
{
}

public static partial class HtmlPictureControl
{
    /// <summary>
    /// <para> The HTML picture tag </para>
    /// </summary>
    public static IHtmlNode HtmlPicture(this HtmlBuilder b, Action<AttributesBuilder<HtmlPicture>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("picture", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML picture tag </para>
    /// </summary>
    public static IHtmlNode HtmlPicture(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("picture", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML picture tag </para>
    /// </summary>
    public static IHtmlNode HtmlPicture(this HtmlBuilder b, Action<AttributesBuilder<HtmlPicture>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("picture", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML picture tag </para>
    /// </summary>
    public static IHtmlNode HtmlPicture(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("picture", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML picture tag </para>
    /// </summary>
    public static Var<IVNode> HtmlPicture(this LayoutBuilder b, Action<PropsBuilder<HtmlPicture>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("picture", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML picture tag </para>
    /// </summary>
    public static Var<IVNode> HtmlPicture(this LayoutBuilder b, Action<PropsBuilder<HtmlPicture>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("picture", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML picture tag </para>
    /// </summary>
    public static Var<IVNode> HtmlPicture(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("picture", children);
    }
    /// <summary>
    /// <para> The HTML picture tag </para>
    /// </summary>
    public static Var<IVNode> HtmlPicture(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("picture", children);
    }
}

