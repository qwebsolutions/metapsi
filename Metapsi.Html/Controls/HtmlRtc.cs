using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlRtc
{
}

public static partial class HtmlRtcControl
{
    /// <summary>
    /// The HTML rtc tag
    /// </summary>
    public static Var<IVNode> HtmlRtc(this LayoutBuilder b, Action<PropsBuilder<HtmlRtc>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("rtc", buildProps, children);
    }
    /// <summary>
    /// The HTML rtc tag
    /// </summary>
    public static Var<IVNode> HtmlRtc(this LayoutBuilder b, Action<PropsBuilder<HtmlRtc>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("rtc", buildProps, children);
    }
}

