using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlMenuLabel
{
}

public static partial class SlMenuLabelControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenuLabel(this HtmlBuilder b, Action<AttributesBuilder<SlMenuLabel>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-menu-label", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenuLabel(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-menu-label", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenuLabel(this HtmlBuilder b, Action<AttributesBuilder<SlMenuLabel>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-menu-label", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenuLabel(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-menu-label", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenuLabel(this LayoutBuilder b, Action<PropsBuilder<SlMenuLabel>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-menu-label", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenuLabel(this LayoutBuilder b, Action<PropsBuilder<SlMenuLabel>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-menu-label", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenuLabel(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-menu-label", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenuLabel(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-menu-label", children);
    }
}

