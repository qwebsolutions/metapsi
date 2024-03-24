using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlSlot
{
}

public static partial class HtmlSlotControl
{
    /// <summary>
    /// The HTML slot tag
    /// </summary>
    public static Var<IVNode> HtmlSlot(this LayoutBuilder b, Action<PropsBuilder<HtmlSlot>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("slot", buildProps, children);
    }
    /// <summary>
    /// The HTML slot tag
    /// </summary>
    public static Var<IVNode> HtmlSlot(this LayoutBuilder b, Action<PropsBuilder<HtmlSlot>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("slot", buildProps, children);
    }
}

