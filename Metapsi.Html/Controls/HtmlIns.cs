using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlIns
{
}

public static partial class HtmlInsControl
{
    /// <summary>
    /// The HTML ins tag
    /// </summary>
    public static Var<IVNode> HtmlIns(this LayoutBuilder b, Action<PropsBuilder<HtmlIns>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("ins", buildProps, children);
    }
    /// <summary>
    /// The HTML ins tag
    /// </summary>
    public static Var<IVNode> HtmlIns(this LayoutBuilder b, Action<PropsBuilder<HtmlIns>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("ins", buildProps, children);
    }
}

