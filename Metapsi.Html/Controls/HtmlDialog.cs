using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlDialog
{
}

public static partial class HtmlDialogControl
{
    /// <summary>
    /// The HTML dialog tag
    /// </summary>
    public static Var<IVNode> HtmlDialog(this LayoutBuilder b, Action<PropsBuilder<HtmlDialog>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dialog", buildProps, children);
    }
    /// <summary>
    /// The HTML dialog tag
    /// </summary>
    public static Var<IVNode> HtmlDialog(this LayoutBuilder b, Action<PropsBuilder<HtmlDialog>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dialog", buildProps, children);
    }
}

