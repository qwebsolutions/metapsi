using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonAvatar
{
}

public static partial class IonAvatarControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonAvatar(this HtmlBuilder b, Action<AttributesBuilder<IonAvatar>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-avatar", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonAvatar(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-avatar", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonAvatar(this HtmlBuilder b, Action<AttributesBuilder<IonAvatar>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-avatar", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonAvatar(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-avatar", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonAvatar(this LayoutBuilder b, Action<PropsBuilder<IonAvatar>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-avatar", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonAvatar(this LayoutBuilder b, Action<PropsBuilder<IonAvatar>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-avatar", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonAvatar(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-avatar", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonAvatar(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-avatar", children);
    }
}

