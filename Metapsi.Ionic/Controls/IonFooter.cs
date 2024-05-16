using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonFooter : IonComponent
{
    public IonFooter() : base("ion-footer") { }
}

public static partial class IonFooterControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonFooter(this HtmlBuilder b, Action<AttributesBuilder<IonFooter>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-footer", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonFooter(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-footer", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// Describes the scroll effect that will be applied to the footer. Only applies in iOS mode.
    /// </summary>
    public static void SetCollapse(this AttributesBuilder<IonFooter> b, string value)
    {
        b.SetAttribute("collapse", value);
    }
    /// <summary>
    /// Describes the scroll effect that will be applied to the footer. Only applies in iOS mode.
    /// </summary>
    public static void SetCollapseFade(this AttributesBuilder<IonFooter> b)
    {
        b.SetAttribute("collapse", "fade");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonFooter> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonFooter> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonFooter> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, the footer will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the footer, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonFooter> b)
    {
        b.SetAttribute("translucent", "");
    }
    /// <summary>
    /// If `true`, the footer will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the footer, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonFooter> b, bool value)
    {
        if (value) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFooter(this LayoutBuilder b, Action<PropsBuilder<IonFooter>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-footer", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFooter(this LayoutBuilder b, Action<PropsBuilder<IonFooter>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-footer", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFooter(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-footer", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFooter(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-footer", children);
    }
    /// <summary>
    /// Describes the scroll effect that will be applied to the footer. Only applies in iOS mode.
    /// </summary>
    public static void SetCollapseFade<T>(this PropsBuilder<T> b) where T: IonFooter
    {
        b.SetDynamic(b.Props, DynamicProperty.String("collapse"), b.Const("fade"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonFooter
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonFooter
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the footer will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the footer, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonFooter
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

}

