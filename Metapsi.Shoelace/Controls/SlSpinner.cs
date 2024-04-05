using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlSpinner : SlComponent
{
    public SlSpinner() : base("sl-spinner") { }
}

public static partial class SlSpinnerControl
{
    /// <summary>
    /// Spinners are used to show the progress of an indeterminate operation.
    /// </summary>
    public static Var<IVNode> SlSpinner(this LayoutBuilder b, Action<PropsBuilder<SlSpinner>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-spinner", buildProps, children);
    }
    /// <summary>
    /// Spinners are used to show the progress of an indeterminate operation.
    /// </summary>
    public static Var<IVNode> SlSpinner(this LayoutBuilder b, Action<PropsBuilder<SlSpinner>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-spinner", buildProps, children);
    }
}

