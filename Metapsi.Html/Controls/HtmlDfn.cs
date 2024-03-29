using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlDfn
{
}

public static partial class HtmlDfnControl
{
    /// <summary>
    /// The HTML dfn tag
    /// </summary>
    public static Var<IVNode> HtmlDfn(this LayoutBuilder b, Action<PropsBuilder<HtmlDfn>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dfn", buildProps, children);
    }
    /// <summary>
    /// The HTML dfn tag
    /// </summary>
    public static Var<IVNode> HtmlDfn(this LayoutBuilder b, Action<PropsBuilder<HtmlDfn>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dfn", buildProps, children);
    }
}

