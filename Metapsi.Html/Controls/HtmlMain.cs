using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlMain
{
}

public static partial class HtmlMainControl
{
    /// <summary>
    /// The HTML main tag
    /// </summary>
    public static Var<IVNode> HtmlMain(this LayoutBuilder b, Action<PropsBuilder<HtmlMain>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("main", buildProps, children);
    }
    /// <summary>
    /// The HTML main tag
    /// </summary>
    public static Var<IVNode> HtmlMain(this LayoutBuilder b, Action<PropsBuilder<HtmlMain>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("main", buildProps, children);
    }
}

