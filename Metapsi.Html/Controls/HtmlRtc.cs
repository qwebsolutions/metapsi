using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlRtc
{
}

public static partial class HtmlRtcControl
{
    /// <summary>
    /// The HTML rtc tag
    /// </summary>
    public static IHtmlNode HtmlRtc(this HtmlBuilder b, Action<AttributesBuilder<HtmlRtc>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("rtc", buildAttributes, children);
    }
    /// <summary>
    /// The HTML rtc tag
    /// </summary>
    public static IHtmlNode HtmlRtc(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("rtc", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The HTML rtc tag
    /// </summary>
    public static Var<IVNode> HtmlRtc(this LayoutBuilder b, Action<PropsBuilder<HtmlRtc>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("rtc", buildProps, children);
    }
    /// <summary>
    /// The HTML rtc tag
    /// </summary>
    public static Var<IVNode> HtmlRtc(this LayoutBuilder b, Action<PropsBuilder<HtmlRtc>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("rtc", buildProps, children);
    }
    /// <summary>
    /// The HTML rtc tag
    /// </summary>
    public static Var<IVNode> HtmlRtc(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("rtc", children);
    }
    /// <summary>
    /// The HTML rtc tag
    /// </summary>
    public static Var<IVNode> HtmlRtc(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("rtc", children);
    }
}

