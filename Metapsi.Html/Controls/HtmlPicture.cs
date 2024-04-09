using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlPicture
{
}

public static partial class HtmlPictureControl
{
    /// <summary>
    /// The HTML picture tag
    /// </summary>
    public static Var<IVNode> HtmlPicture(this LayoutBuilder b, Action<PropsBuilder<HtmlPicture>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("picture", buildProps, children);
    }
    /// <summary>
    /// The HTML picture tag
    /// </summary>
    public static Var<IVNode> HtmlPicture(this LayoutBuilder b, Action<PropsBuilder<HtmlPicture>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("picture", buildProps, children);
    }
    /// <summary>
    /// The HTML picture tag
    /// </summary>
    public static Var<IVNode> HtmlPicture(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("picture", children);
    }
    /// <summary>
    /// The HTML picture tag
    /// </summary>
    public static Var<IVNode> HtmlPicture(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("picture", children);
    }
}

