using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTrack
{
}

public static partial class HtmlTrackControl
{
    /// <summary>
    /// <para> The HTML track tag </para>
    /// </summary>
    public static IHtmlNode HtmlTrack(this HtmlBuilder b, Action<AttributesBuilder<HtmlTrack>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("track", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML track tag </para>
    /// </summary>
    public static IHtmlNode HtmlTrack(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("track", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML track tag </para>
    /// </summary>
    public static IHtmlNode HtmlTrack(this HtmlBuilder b, Action<AttributesBuilder<HtmlTrack>> buildAttributes, List<IHtmlNode> children)
    {
        return b.Tag("track", buildAttributes, children);
    }
    /// <summary>
    /// <para> The HTML track tag </para>
    /// </summary>
    public static IHtmlNode HtmlTrack(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.Tag("track", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The HTML track tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTrack(this LayoutBuilder b, Action<PropsBuilder<HtmlTrack>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("track", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML track tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTrack(this LayoutBuilder b, Action<PropsBuilder<HtmlTrack>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("track", buildProps, children);
    }
    /// <summary>
    /// <para> The HTML track tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTrack(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("track", children);
    }
    /// <summary>
    /// <para> The HTML track tag </para>
    /// </summary>
    public static Var<IVNode> HtmlTrack(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("track", children);
    }
}

