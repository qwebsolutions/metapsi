using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlImg
{
}

public static partial class HtmlImgControl
{
    /// <summary>
    /// The HTML img tag
    /// </summary>
    public static Var<IVNode> HtmlImg(this LayoutBuilder b, Action<PropsBuilder<HtmlImg>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("img", buildProps, children);
    }
    /// <summary>
    /// The HTML img tag
    /// </summary>
    public static Var<IVNode> HtmlImg(this LayoutBuilder b, Action<PropsBuilder<HtmlImg>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("img", buildProps, children);
    }
    /// <summary>
    /// The HTML img tag
    /// </summary>
    public static Var<IVNode> HtmlImg(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("img", children);
    }
    /// <summary>
    /// The HTML img tag
    /// </summary>
    public static Var<IVNode> HtmlImg(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("img", children);
    }
}

