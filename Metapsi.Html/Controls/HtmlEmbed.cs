using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlEmbed
{
}

public static partial class HtmlEmbedControl
{
    /// <summary>
    /// The HTML embed tag
    /// </summary>
    public static Var<IVNode> HtmlEmbed(this LayoutBuilder b, Action<PropsBuilder<HtmlEmbed>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("embed", buildProps, children);
    }
    /// <summary>
    /// The HTML embed tag
    /// </summary>
    public static Var<IVNode> HtmlEmbed(this LayoutBuilder b, Action<PropsBuilder<HtmlEmbed>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("embed", buildProps, children);
    }
}

