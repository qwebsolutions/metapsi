using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlMeter
{
}

public static partial class HtmlMeterControl
{
    /// <summary>
    /// The HTML meter tag
    /// </summary>
    public static IHtmlNode HtmlMeter(this HtmlBuilder b, Action<AttributesBuilder<HtmlMeter>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("meter", buildAttributes, children);
    }
    /// <summary>
    /// The HTML meter tag
    /// </summary>
    public static IHtmlNode HtmlMeter(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("meter", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML meter tag
    /// </summary>
    public static Var<IVNode> HtmlMeter(this LayoutBuilder b, Action<PropsBuilder<HtmlMeter>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("meter", buildProps, children);
    }
    /// <summary>
    /// The HTML meter tag
    /// </summary>
    public static Var<IVNode> HtmlMeter(this LayoutBuilder b, Action<PropsBuilder<HtmlMeter>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("meter", buildProps, children);
    }
    /// <summary>
    /// The HTML meter tag
    /// </summary>
    public static Var<IVNode> HtmlMeter(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("meter", children);
    }
    /// <summary>
    /// The HTML meter tag
    /// </summary>
    public static Var<IVNode> HtmlMeter(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("meter", children);
    }
}

