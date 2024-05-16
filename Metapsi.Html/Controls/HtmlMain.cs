using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlMain
{
}

public static partial class HtmlMainControl
{
    /// <summary>
    /// The HTML main tag
    /// </summary>
    public static IHtmlNode HtmlMain(this HtmlBuilder b, Action<AttributesBuilder<HtmlMain>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("main", buildAttributes, children);
    }
    /// <summary>
    /// The HTML main tag
    /// </summary>
    public static IHtmlNode HtmlMain(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("main", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML main tag
    /// </summary>
    public static Var<IVNode> HtmlMain(this LayoutBuilder b, Action<PropsBuilder<HtmlMain>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("main", buildProps, children);
    }
    /// <summary>
    /// The HTML main tag
    /// </summary>
    public static Var<IVNode> HtmlMain(this LayoutBuilder b, Action<PropsBuilder<HtmlMain>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("main", buildProps, children);
    }
    /// <summary>
    /// The HTML main tag
    /// </summary>
    public static Var<IVNode> HtmlMain(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("main", children);
    }
    /// <summary>
    /// The HTML main tag
    /// </summary>
    public static Var<IVNode> HtmlMain(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("main", children);
    }
}

