using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonInfiniteScrollContent : IonComponent
{
    public IonInfiniteScrollContent() : base("ion-infinite-scroll-content") { }
}

public static partial class IonInfiniteScrollContentControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonInfiniteScrollContent(this HtmlBuilder b, Action<AttributesBuilder<IonInfiniteScrollContent>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-infinite-scroll-content", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonInfiniteScrollContent(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-infinite-scroll-content", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinner(this AttributesBuilder<IonInfiniteScrollContent> b, string value)
    {
        b.SetAttribute("loading-spinner", value);
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerBubbles(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "bubbles");
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircles(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "circles");
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircular(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "circular");
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCrescent(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "crescent");
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerDots(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "dots");
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLines(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines");
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharp(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines-sharp");
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharpSmall(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines-sharp-small");
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSmall(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines-small");
    }

    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetLoadingText(this AttributesBuilder<IonInfiniteScrollContent> b, string value)
    {
        b.SetAttribute("loading-text", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonInfiniteScrollContent(this LayoutBuilder b, Action<PropsBuilder<IonInfiniteScrollContent>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-infinite-scroll-content", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonInfiniteScrollContent(this LayoutBuilder b, Action<PropsBuilder<IonInfiniteScrollContent>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-infinite-scroll-content", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonInfiniteScrollContent(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-infinite-scroll-content", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonInfiniteScrollContent(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-infinite-scroll-content", children);
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerBubbles<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("bubbles"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircles<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("circles"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircular<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("circular"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCrescent<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("crescent"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerDots<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("dots"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLines<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("lines"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharp<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("lines-sharp"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharpSmall<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("lines-sharp-small"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSmall<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetLoadingText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInfiniteScrollContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("loadingText"), value);
    }
    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetLoadingText<T>(this PropsBuilder<T> b, string value) where T: IonInfiniteScrollContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("loadingText"), b.Const(value));
    }

}

