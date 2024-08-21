using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonThumbnail
{
}

public static partial class IonThumbnailControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonThumbnail(this HtmlBuilder b, Action<AttributesBuilder<IonThumbnail>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-thumbnail", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonThumbnail(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-thumbnail", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonThumbnail(this HtmlBuilder b, Action<AttributesBuilder<IonThumbnail>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-thumbnail", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonThumbnail(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-thumbnail", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonThumbnail(this LayoutBuilder b, Action<PropsBuilder<IonThumbnail>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-thumbnail", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonThumbnail(this LayoutBuilder b, Action<PropsBuilder<IonThumbnail>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-thumbnail", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonThumbnail(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-thumbnail", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonThumbnail(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-thumbnail", children);
    }
}

