using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlVideo
{
}

public static partial class HtmlVideoControl
{
    /// <summary>
    /// The HTML video tag
    /// </summary>
    public static Var<IVNode> HtmlVideo(this LayoutBuilder b, Action<PropsBuilder<HtmlVideo>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("video", buildProps, children);
    }
    /// <summary>
    /// The HTML video tag
    /// </summary>
    public static Var<IVNode> HtmlVideo(this LayoutBuilder b, Action<PropsBuilder<HtmlVideo>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("video", buildProps, children);
    }
}

