using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlMeter
{
}

public static partial class HtmlMeterControl
{
    /// <summary>
    /// The HTML meter tag
    /// </summary>
    public static Var<IVNode> HtmlMeter(this LayoutBuilder b, Action<PropsBuilder<HtmlMeter>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("meter", buildProps, children);
    }
    /// <summary>
    /// The HTML meter tag
    /// </summary>
    public static Var<IVNode> HtmlMeter(this LayoutBuilder b, Action<PropsBuilder<HtmlMeter>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("meter", buildProps, children);
    }
}

