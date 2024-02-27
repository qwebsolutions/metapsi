using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlSpinner
{
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

/// <summary>
/// Spinners are used to show the progress of an indeterminate operation.
/// </summary>
public partial class SlSpinner : HtmlTag
{
    public SlSpinner()
    {
        this.Tag = "sl-spinner";
    }

    public static SlSpinner New()
    {
        return new SlSpinner();
    }
}

public static partial class SlSpinnerControl
{
}

