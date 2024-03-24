using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlFieldset
{
}

public static partial class HtmlFieldsetControl
{
    /// <summary>
    /// The HTML fieldset tag
    /// </summary>
    public static Var<IVNode> HtmlFieldset(this LayoutBuilder b, Action<PropsBuilder<HtmlFieldset>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("fieldset", buildProps, children);
    }
    /// <summary>
    /// The HTML fieldset tag
    /// </summary>
    public static Var<IVNode> HtmlFieldset(this LayoutBuilder b, Action<PropsBuilder<HtmlFieldset>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("fieldset", buildProps, children);
    }
}

