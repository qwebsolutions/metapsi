using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlBr
{
}

public static partial class HtmlBrControl
{
    /// <summary>
    /// The HTML br tag
    /// </summary>
    public static Var<IVNode> HtmlBr(this LayoutBuilder b, Action<PropsBuilder<HtmlBr>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("br", buildProps, children);
    }
    /// <summary>
    /// The HTML br tag
    /// </summary>
    public static Var<IVNode> HtmlBr(this LayoutBuilder b, Action<PropsBuilder<HtmlBr>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("br", buildProps, children);
    }
}

