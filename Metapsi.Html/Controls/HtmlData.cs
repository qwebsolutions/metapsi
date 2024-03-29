using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlData
{
}

public static partial class HtmlDataControl
{
    /// <summary>
    /// The HTML data tag
    /// </summary>
    public static Var<IVNode> HtmlData(this LayoutBuilder b, Action<PropsBuilder<HtmlData>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("data", buildProps, children);
    }
    /// <summary>
    /// The HTML data tag
    /// </summary>
    public static Var<IVNode> HtmlData(this LayoutBuilder b, Action<PropsBuilder<HtmlData>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("data", buildProps, children);
    }
}

