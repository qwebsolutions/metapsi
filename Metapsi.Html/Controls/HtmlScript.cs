using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlScript
{
}

public static partial class HtmlScriptControl
{
    /// <summary>
    /// The HTML script tag
    /// </summary>
    public static Var<IVNode> HtmlScript(this LayoutBuilder b, Action<PropsBuilder<HtmlScript>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("script", buildProps, children);
    }
    /// <summary>
    /// The HTML script tag
    /// </summary>
    public static Var<IVNode> HtmlScript(this LayoutBuilder b, Action<PropsBuilder<HtmlScript>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("script", buildProps, children);
    }
}

