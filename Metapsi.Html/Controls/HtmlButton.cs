using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlButton
{
}

public static partial class HtmlButtonControl
{
    /// <summary>
    /// The HTML button tag
    /// </summary>
    public static Var<IVNode> HtmlButton(this LayoutBuilder b, Action<PropsBuilder<HtmlButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("button", buildProps, children);
    }
    /// <summary>
    /// The HTML button tag
    /// </summary>
    public static Var<IVNode> HtmlButton(this LayoutBuilder b, Action<PropsBuilder<HtmlButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("button", buildProps, children);
    }
}

