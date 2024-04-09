using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTbody
{
}

public static partial class HtmlTbodyControl
{
    /// <summary>
    /// The HTML tbody tag
    /// </summary>
    public static Var<IVNode> HtmlTbody(this LayoutBuilder b, Action<PropsBuilder<HtmlTbody>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("tbody", buildProps, children);
    }
    /// <summary>
    /// The HTML tbody tag
    /// </summary>
    public static Var<IVNode> HtmlTbody(this LayoutBuilder b, Action<PropsBuilder<HtmlTbody>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("tbody", buildProps, children);
    }
    /// <summary>
    /// The HTML tbody tag
    /// </summary>
    public static Var<IVNode> HtmlTbody(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("tbody", children);
    }
    /// <summary>
    /// The HTML tbody tag
    /// </summary>
    public static Var<IVNode> HtmlTbody(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("tbody", children);
    }
}

