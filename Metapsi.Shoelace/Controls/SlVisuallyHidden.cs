using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlVisuallyHidden : SlComponent
{
    public SlVisuallyHidden() : base("sl-visually-hidden") { }
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
    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Var<IVNode> SlVisuallyHidden(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-visually-hidden", children);
    }
    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Var<IVNode> SlVisuallyHidden(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-visually-hidden", children);
    }
}

