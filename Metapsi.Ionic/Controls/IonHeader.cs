using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonHeader : IonComponent
{
    public IonHeader() : base("ion-header") { }
}

public static partial class IonHeaderControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonHeader(this HtmlBuilder b, Action<AttributesBuilder<IonHeader>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-header", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonHeader(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-header", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// Describes the scroll effect that will be applied to the header. Only applies in iOS mode.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapse(this AttributesBuilder<IonHeader> b, string value)
    {
        b.SetAttribute("collapse", value);
    }
    /// <summary>
    /// Describes the scroll effect that will be applied to the header. Only applies in iOS mode.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapseCondense(this AttributesBuilder<IonHeader> b)
    {
        b.SetAttribute("collapse", "condense");
    }
    /// <summary>
    /// Describes the scroll effect that will be applied to the header. Only applies in iOS mode.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapseFade(this AttributesBuilder<IonHeader> b)
    {
        b.SetAttribute("collapse", "fade");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonHeader> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonHeader> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonHeader> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, the header will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the header, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonHeader> b)
    {
        b.SetAttribute("translucent", "");
    }
    /// <summary>
    /// If `true`, the header will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the header, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonHeader> b, bool value)
    {
        if (value) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonHeader(this LayoutBuilder b, Action<PropsBuilder<IonHeader>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-header", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonHeader(this LayoutBuilder b, Action<PropsBuilder<IonHeader>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-header", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonHeader(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-header", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonHeader(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-header", children);
    }
    /// <summary>
    /// Describes the scroll effect that will be applied to the header. Only applies in iOS mode.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapseCondense<T>(this PropsBuilder<T> b) where T: IonHeader
    {
        b.SetDynamic(b.Props, DynamicProperty.String("collapse"), b.Const("condense"));
    }
    /// <summary>
    /// Describes the scroll effect that will be applied to the header. Only applies in iOS mode.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapseFade<T>(this PropsBuilder<T> b) where T: IonHeader
    {
        b.SetDynamic(b.Props, DynamicProperty.String("collapse"), b.Const("fade"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonHeader
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonHeader
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the header will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the header, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonHeader
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

}

