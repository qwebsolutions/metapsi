using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlVisuallyHidden
{
}

public static partial class SlVisuallyHiddenControl
{
    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Var<IVNode> SlVisuallyHidden(this LayoutBuilder b, Action<PropsBuilder<SlVisuallyHidden>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-visually-hidden", buildProps, children);
    }
    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Var<IVNode> SlVisuallyHidden(this LayoutBuilder b, Action<PropsBuilder<SlVisuallyHidden>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-visually-hidden", buildProps, children);
    }
}

