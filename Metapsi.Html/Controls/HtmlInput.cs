using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlInput
{
}

public static partial class HtmlInputControl
{
    /// <summary>
    /// The HTML input tag
    /// </summary>
    public static Var<IVNode> HtmlInput(this LayoutBuilder b, Action<PropsBuilder<HtmlInput>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("input", buildProps, children);
    }
    /// <summary>
    /// The HTML input tag
    /// </summary>
    public static Var<IVNode> HtmlInput(this LayoutBuilder b, Action<PropsBuilder<HtmlInput>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("input", buildProps, children);
    }
}

