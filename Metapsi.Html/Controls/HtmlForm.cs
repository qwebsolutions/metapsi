using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlForm
{
}

public static partial class HtmlFormControl
{
    /// <summary>
    /// The HTML form tag
    /// </summary>
    public static Var<IVNode> HtmlForm(this LayoutBuilder b, Action<PropsBuilder<HtmlForm>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("form", buildProps, children);
    }
    /// <summary>
    /// The HTML form tag
    /// </summary>
    public static Var<IVNode> HtmlForm(this LayoutBuilder b, Action<PropsBuilder<HtmlForm>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("form", buildProps, children);
    }
}

