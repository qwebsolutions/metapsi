using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonSegmentContent
{
}

public static partial class IonSegmentContentControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentContent(this HtmlBuilder b, Action<AttributesBuilder<IonSegmentContent>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment-content", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentContent(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment-content", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentContent(this HtmlBuilder b, Action<AttributesBuilder<IonSegmentContent>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-segment-content", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentContent(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-segment-content", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentContent(this LayoutBuilder b, Action<PropsBuilder<IonSegmentContent>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-segment-content", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentContent(this LayoutBuilder b, Action<PropsBuilder<IonSegmentContent>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-segment-content", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentContent(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-segment-content", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentContent(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-segment-content", children);
    }
}

