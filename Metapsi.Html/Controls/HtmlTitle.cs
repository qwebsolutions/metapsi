using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlTitle
{
}

public static partial class HtmlTitleControl
{
    /// <summary>
    /// The HTML title tag
    /// </summary>
    public static Var<IVNode> HtmlTitle(this LayoutBuilder b, Action<PropsBuilder<HtmlTitle>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("title", buildProps, children);
    }
    /// <summary>
    /// The HTML title tag
    /// </summary>
    public static Var<IVNode> HtmlTitle(this LayoutBuilder b, Action<PropsBuilder<HtmlTitle>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("title", buildProps, children);
    }
}

