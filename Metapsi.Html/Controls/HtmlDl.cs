using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlDl
{
}

public static partial class HtmlDlControl
{
    /// <summary>
    /// The HTML dl tag
    /// </summary>
    public static Var<IVNode> HtmlDl(this LayoutBuilder b, Action<PropsBuilder<HtmlDl>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dl", buildProps, children);
    }
    /// <summary>
    /// The HTML dl tag
    /// </summary>
    public static Var<IVNode> HtmlDl(this LayoutBuilder b, Action<PropsBuilder<HtmlDl>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dl", buildProps, children);
    }
}

