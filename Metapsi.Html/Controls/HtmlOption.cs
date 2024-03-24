using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlOption
{
}

public static partial class HtmlOptionControl
{
    /// <summary>
    /// The HTML option tag
    /// </summary>
    public static Var<IVNode> HtmlOption(this LayoutBuilder b, Action<PropsBuilder<HtmlOption>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("option", buildProps, children);
    }
    /// <summary>
    /// The HTML option tag
    /// </summary>
    public static Var<IVNode> HtmlOption(this LayoutBuilder b, Action<PropsBuilder<HtmlOption>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("option", buildProps, children);
    }
}

