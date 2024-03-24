using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlMenu
{
}

public static partial class HtmlMenuControl
{
    /// <summary>
    /// The HTML menu tag
    /// </summary>
    public static Var<IVNode> HtmlMenu(this LayoutBuilder b, Action<PropsBuilder<HtmlMenu>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("menu", buildProps, children);
    }
    /// <summary>
    /// The HTML menu tag
    /// </summary>
    public static Var<IVNode> HtmlMenu(this LayoutBuilder b, Action<PropsBuilder<HtmlMenu>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("menu", buildProps, children);
    }
}

