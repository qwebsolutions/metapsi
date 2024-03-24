using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlSup
{
}

public static partial class HtmlSupControl
{
    /// <summary>
    /// The HTML sup tag
    /// </summary>
    public static Var<IVNode> HtmlSup(this LayoutBuilder b, Action<PropsBuilder<HtmlSup>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sup", buildProps, children);
    }
    /// <summary>
    /// The HTML sup tag
    /// </summary>
    public static Var<IVNode> HtmlSup(this LayoutBuilder b, Action<PropsBuilder<HtmlSup>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sup", buildProps, children);
    }
}

