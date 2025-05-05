using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonRefresherContent
{
}

public static partial class IonRefresherContentControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRefresherContent(this HtmlBuilder b, Action<AttributesBuilder<IonRefresherContent>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-refresher-content", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRefresherContent(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-refresher-content", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRefresherContent(this HtmlBuilder b, Action<AttributesBuilder<IonRefresherContent>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-refresher-content", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRefresherContent(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-refresher-content", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices. </para>
    /// </summary>
    public static void SetPullingIcon(this AttributesBuilder<IonRefresherContent> b, string pullingIcon)
    {
        b.SetAttribute("pulling-icon", pullingIcon);
    }

    /// <summary>
    /// <para> The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetPullingText(this AttributesBuilder<IonRefresherContent> b, string pullingText)
    {
        b.SetAttribute("pulling-text", pullingText);
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinner(this AttributesBuilder<IonRefresherContent> b, string refreshingSpinner)
    {
        b.SetAttribute("refreshing-spinner", refreshingSpinner);
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerBubbles(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "bubbles");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerCircles(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "circles");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerCircular(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "circular");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerCrescent(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "crescent");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerDots(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "dots");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerLines(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharp(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines-sharp");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharpSmall(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines-sharp-small");
    }

    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerLinesSmall(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines-small");
    }

    /// <summary>
    /// <para> The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetRefreshingText(this AttributesBuilder<IonRefresherContent> b, string refreshingText)
    {
        b.SetAttribute("refreshing-text", refreshingText);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRefresherContent(this LayoutBuilder b, Action<PropsBuilder<IonRefresherContent>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-refresher-content", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRefresherContent(this LayoutBuilder b, Action<PropsBuilder<IonRefresherContent>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-refresher-content", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRefresherContent(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-refresher-content", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRefresherContent(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-refresher-content", children);
    }
    /// <summary>
    /// <para> A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices. </para>
    /// </summary>
    public static void SetPullingIcon<T>(this PropsBuilder<T> b, Var<string> pullingIcon) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("pullingIcon"), pullingIcon);
    }

    /// <summary>
    /// <para> A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices. </para>
    /// </summary>
    public static void SetPullingIcon<T>(this PropsBuilder<T> b, string pullingIcon) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("pullingIcon"), b.Const(pullingIcon));
    }


    /// <summary>
    /// <para> The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetPullingText<T>(this PropsBuilder<T> b, Var<IonicSafeString> pullingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("pullingText"), pullingText);
    }



    /// <summary>
    /// <para> The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetPullingText<T>(this PropsBuilder<T> b, Var<string> pullingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("pullingText"), pullingText);
    }

    /// <summary>
    /// <para> The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetPullingText<T>(this PropsBuilder<T> b, string pullingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("pullingText"), b.Const(pullingText));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerBubbles<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingSpinner"), b.Const("bubbles"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerCircles<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingSpinner"), b.Const("circles"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerCircular<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingSpinner"), b.Const("circular"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerCrescent<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingSpinner"), b.Const("crescent"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerDots<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingSpinner"), b.Const("dots"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerLines<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingSpinner"), b.Const("lines"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharp<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingSpinner"), b.Const("lines-sharp"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharpSmall<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingSpinner"), b.Const("lines-sharp-small"));
    }


    /// <summary>
    /// <para> An animated SVG spinner that shows when refreshing begins </para>
    /// </summary>
    public static void SetRefreshingSpinnerLinesSmall<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingSpinner"), b.Const("lines-small"));
    }


    /// <summary>
    /// <para> The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetRefreshingText<T>(this PropsBuilder<T> b, Var<IonicSafeString> refreshingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingText"), refreshingText);
    }



    /// <summary>
    /// <para> The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetRefreshingText<T>(this PropsBuilder<T> b, Var<string> refreshingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingText"), refreshingText);
    }

    /// <summary>
    /// <para> The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetRefreshingText<T>(this PropsBuilder<T> b, string refreshingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Props, b.Const("refreshingText"), b.Const(refreshingText));
    }


}

