using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlStrong
{
}

public static partial class HtmlStrongControl
{
    /// <summary>
    /// The HTML strong tag
    /// </summary>
    public static Var<IVNode> HtmlStrong(this LayoutBuilder b, Action<PropsBuilder<HtmlStrong>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("strong", buildProps, children);
    }
    /// <summary>
    /// The HTML strong tag
    /// </summary>
    public static Var<IVNode> HtmlStrong(this LayoutBuilder b, Action<PropsBuilder<HtmlStrong>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("strong", buildProps, children);
    }
}

