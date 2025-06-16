using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonHeader
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of IonHeader
/// </summary>
public static partial class IonHeaderControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonHeader(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonHeader>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-header", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonHeader(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-header", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonHeader(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonHeader>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-header", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonHeader(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-header", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Describes the scroll effect that will be applied to the header. Only applies in iOS mode.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapseCondense(this Metapsi.Html.AttributesBuilder<IonHeader> b) 
    {
        b.SetAttribute("collapse", "condense");
    }

    /// <summary>
    /// Describes the scroll effect that will be applied to the header. Only applies in iOS mode.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapseFade(this Metapsi.Html.AttributesBuilder<IonHeader> b) 
    {
        b.SetAttribute("collapse", "fade");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonHeader> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonHeader> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, the header will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the header, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonHeader> b, bool translucent) 
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// If `true`, the header will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the header, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonHeader> b) 
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonHeader(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonHeader>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-header", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonHeader(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-header", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonHeader(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonHeader>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-header", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonHeader(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-header", children);
    }

    /// <summary>
    /// Describes the scroll effect that will be applied to the header. Only applies in iOS mode.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapseCondense<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonHeader
    {
        b.SetProperty(b.Props, b.Const("collapse"), b.Const("condense"));
    }

    /// <summary>
    /// Describes the scroll effect that will be applied to the header. Only applies in iOS mode.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapseFade<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonHeader
    {
        b.SetProperty(b.Props, b.Const("collapse"), b.Const("fade"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonHeader
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonHeader
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the header will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the header, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonHeader
    {
        b.SetTranslucent(b.Const(true));
    }

    /// <summary>
    /// If `true`, the header will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the header, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonHeader
    {
        b.SetProperty(b.Props, b.Const("translucent"), translucent);
    }

    /// <summary>
    /// If `true`, the header will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the header, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool translucent) where T: IonHeader
    {
        b.SetTranslucent(b.Const(translucent));
    }

}