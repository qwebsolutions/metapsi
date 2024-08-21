using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlAudio
{
}

public static partial class HtmlAudioControl
{
    /// <summary>
    /// <para> The HTML audio tag </para>
    /// </summary>
    public static IHtmlNode HtmlAudio(this HtmlBuilder b, Action<AttributesBuilder<HtmlAudio>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("audio", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML audio tag </para>
    /// </summary>
    public static IHtmlNode HtmlAudio(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("audio", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML audio tag </para>
    /// </summary>
    public static IHtmlNode HtmlAudio(this HtmlBuilder b, Action<AttributesBuilder<HtmlAudio>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("audio", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML audio tag </para>
    /// </summary>
    public static IHtmlNode HtmlAudio(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("audio", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML audio tag </para>
    /// </summary>
    public static Var<IVNode> HtmlAudio(this LayoutBuilder b, Action<PropsBuilder<HtmlAudio>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("audio", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML audio tag </para>
    /// </summary>
    public static Var<IVNode> HtmlAudio(this LayoutBuilder b, Action<PropsBuilder<HtmlAudio>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("audio", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML audio tag </para>
    /// </summary>
    public static Var<IVNode> HtmlAudio(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("audio", children);
    }
    /// <summary>
    /// <para> The HTML audio tag </para>
    /// </summary>
    public static Var<IVNode> HtmlAudio(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("audio", children);
    }
}

