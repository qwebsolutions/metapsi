using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlCode
{
}

public static partial class HtmlCodeControl
{
    /// <summary>
    /// The HTML code tag
    /// </summary>
    public static Var<IVNode> HtmlCode(this LayoutBuilder b, Action<PropsBuilder<HtmlCode>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("code", buildProps, children);
    }
    /// <summary>
    /// The HTML code tag
    /// </summary>
    public static Var<IVNode> HtmlCode(this LayoutBuilder b, Action<PropsBuilder<HtmlCode>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("code", buildProps, children);
    }
}

