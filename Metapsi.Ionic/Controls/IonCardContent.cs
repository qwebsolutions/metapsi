using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonCardContent
{
}

public static partial class IonCardContentControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCardContent(this HtmlBuilder b, Action<AttributesBuilder<IonCardContent>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-card-content", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCardContent(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-card-content", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCardContent(this HtmlBuilder b, Action<AttributesBuilder<IonCardContent>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-card-content", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCardContent(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-card-content", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonCardContent> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonCardContent> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonCardContent> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCardContent(this LayoutBuilder b, Action<PropsBuilder<IonCardContent>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-card-content", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCardContent(this LayoutBuilder b, Action<PropsBuilder<IonCardContent>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-card-content", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCardContent(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-card-content", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCardContent(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-card-content", children);
    }
    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonCardContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonCardContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


}

