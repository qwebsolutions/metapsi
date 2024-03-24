using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlAudio
{
}

public static partial class HtmlAudioControl
{
    /// <summary>
    /// The HTML audio tag
    /// </summary>
    public static Var<IVNode> HtmlAudio(this LayoutBuilder b, Action<PropsBuilder<HtmlAudio>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("audio", buildProps, children);
    }
    /// <summary>
    /// The HTML audio tag
    /// </summary>
    public static Var<IVNode> HtmlAudio(this LayoutBuilder b, Action<PropsBuilder<HtmlAudio>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("audio", buildProps, children);
    }
}

