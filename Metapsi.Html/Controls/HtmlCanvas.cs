using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlCanvas
{
}

public static partial class HtmlCanvasControl
{
    /// <summary>
    /// The HTML canvas tag
    /// </summary>
    public static Var<IVNode> HtmlCanvas(this LayoutBuilder b, Action<PropsBuilder<HtmlCanvas>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("canvas", buildProps, children);
    }
    /// <summary>
    /// The HTML canvas tag
    /// </summary>
    public static Var<IVNode> HtmlCanvas(this LayoutBuilder b, Action<PropsBuilder<HtmlCanvas>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("canvas", buildProps, children);
    }
}

