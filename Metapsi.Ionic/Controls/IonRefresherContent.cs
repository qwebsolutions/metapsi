using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonRefresherContent : IonComponent
{
    public IonRefresherContent() : base("ion-refresher-content") { }
}

public static partial class IonRefresherContentControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRefresherContent(this HtmlBuilder b, Action<AttributesBuilder<IonRefresherContent>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-refresher-content", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRefresherContent(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-refresher-content", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices.
    /// </summary>
    public static void SetPullingIcon(this AttributesBuilder<IonRefresherContent> b, string value)
    {
        b.SetAttribute("pulling-icon", value);
    }

    /// <summary>
    /// The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetPullingText(this AttributesBuilder<IonRefresherContent> b, string value)
    {
        b.SetAttribute("pulling-text", value);
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinner(this AttributesBuilder<IonRefresherContent> b, string value)
    {
        b.SetAttribute("refreshing-spinner", value);
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerBubbles(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "bubbles");
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircles(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "circles");
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircular(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "circular");
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCrescent(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "crescent");
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerDots(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "dots");
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLines(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines");
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharp(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines-sharp");
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharpSmall(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines-sharp-small");
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSmall(this AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines-small");
    }

    /// <summary>
    /// The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetRefreshingText(this AttributesBuilder<IonRefresherContent> b, string value)
    {
        b.SetAttribute("refreshing-text", value);
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
    /// A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices.
    /// </summary>
    public static void SetPullingIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullingIcon"), value);
    }
    /// <summary>
    /// A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices.
    /// </summary>
    public static void SetPullingIcon<T>(this PropsBuilder<T> b, string value) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullingIcon"), b.Const(value));
    }

    /// <summary>
    /// The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetPullingText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullingText"), value);
    }
    /// <summary>
    /// The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetPullingText<T>(this PropsBuilder<T> b, string value) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullingText"), b.Const(value));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerBubbles<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("bubbles"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircles<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("circles"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircular<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("circular"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCrescent<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("crescent"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerDots<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("dots"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLines<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("lines"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharp<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("lines-sharp"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharpSmall<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("lines-sharp-small"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSmall<T>(this PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetRefreshingText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("refreshingText"), value);
    }
    /// <summary>
    /// The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetRefreshingText<T>(this PropsBuilder<T> b, string value) where T: IonRefresherContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("refreshingText"), b.Const(value));
    }

}

