using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTrack
{
}

public static partial class HtmlTrackControl
{
    /// <summary>
    /// The HTML track tag
    /// </summary>
    public static Var<IVNode> HtmlTrack(this LayoutBuilder b, Action<PropsBuilder<HtmlTrack>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("track", buildProps, children);
    }
    /// <summary>
    /// The HTML track tag
    /// </summary>
    public static Var<IVNode> HtmlTrack(this LayoutBuilder b, Action<PropsBuilder<HtmlTrack>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("track", buildProps, children);
    }
    /// <summary>
    /// The HTML track tag
    /// </summary>
    public static Var<IVNode> HtmlTrack(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("track", children);
    }
    /// <summary>
    /// The HTML track tag
    /// </summary>
    public static Var<IVNode> HtmlTrack(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("track", children);
    }
}

