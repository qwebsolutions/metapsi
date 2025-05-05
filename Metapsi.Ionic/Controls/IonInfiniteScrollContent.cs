using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonInfiniteScrollContent
{
}

public static partial class IonInfiniteScrollContentControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonInfiniteScrollContent(this HtmlBuilder b, Action<AttributesBuilder<IonInfiniteScrollContent>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-infinite-scroll-content", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonInfiniteScrollContent(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-infinite-scroll-content", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonInfiniteScrollContent(this HtmlBuilder b, Action<AttributesBuilder<IonInfiniteScrollContent>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-infinite-scroll-content", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonInfiniteScrollContent(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-infinite-scroll-content", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinner(this AttributesBuilder<IonInfiniteScrollContent> b, string loadingSpinner)
    {
        b.SetAttribute("loading-spinner", loadingSpinner);
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerBubbles(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "bubbles");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerCircles(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "circles");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerCircular(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "circular");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerCrescent(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "crescent");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerDots(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "dots");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerLines(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerLinesSharp(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines-sharp");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerLinesSharpSmall(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines-sharp-small");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerLinesSmall(this AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines-small");
    }

    /// <summary>
    /// <para> Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetLoadingText(this AttributesBuilder<IonInfiniteScrollContent> b, string loadingText)
    {
        b.SetAttribute("loading-text", loadingText);
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
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerBubbles<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingSpinner"), b.Const("bubbles"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerCircles<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingSpinner"), b.Const("circles"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerCircular<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingSpinner"), b.Const("circular"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerCrescent<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingSpinner"), b.Const("crescent"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerDots<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingSpinner"), b.Const("dots"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerLines<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingSpinner"), b.Const("lines"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerLinesSharp<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingSpinner"), b.Const("lines-sharp"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerLinesSharpSmall<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingSpinner"), b.Const("lines-sharp-small"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows while loading. </para>
    /// </summary>
    public static void SetLoadingSpinnerLinesSmall<T>(this PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingSpinner"), b.Const("lines-small"));
    }


    /// <summary>
    /// <para> Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetLoadingText<T>(this PropsBuilder<T> b, Var<IonicSafeString> loadingText) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingText"), loadingText);
    }



    /// <summary>
    /// <para> Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetLoadingText<T>(this PropsBuilder<T> b, Var<string> loadingText) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingText"), loadingText);
    }

    /// <summary>
    /// <para> Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetLoadingText<T>(this PropsBuilder<T> b, string loadingText) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Props, b.Const("loadingText"), b.Const(loadingText));
    }


}

