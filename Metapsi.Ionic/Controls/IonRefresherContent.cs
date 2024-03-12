using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonRefresherContent
{
}

public static partial class IonRefresherContentControl
{
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
    /// A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices.
    /// </summary>
    public static void SetPullingIcon(this PropsBuilder<IonRefresherContent> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullingIcon"), value);
    }
    /// <summary>
    /// A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices.
    /// </summary>
    public static void SetPullingIcon(this PropsBuilder<IonRefresherContent> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullingIcon"), b.Const(value));
    }

    /// <summary>
    /// The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetPullingText(this PropsBuilder<IonRefresherContent> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullingText"), value);
    }
    /// <summary>
    /// The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetPullingText(this PropsBuilder<IonRefresherContent> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullingText"), b.Const(value));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerBubbles(this PropsBuilder<IonRefresherContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("bubbles"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircles(this PropsBuilder<IonRefresherContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("circles"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircular(this PropsBuilder<IonRefresherContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("circular"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCrescent(this PropsBuilder<IonRefresherContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("crescent"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerDots(this PropsBuilder<IonRefresherContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("dots"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLines(this PropsBuilder<IonRefresherContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("lines"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharp(this PropsBuilder<IonRefresherContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("lines-sharp"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharpSmall(this PropsBuilder<IonRefresherContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("lines-sharp-small"));
    }
    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSmall(this PropsBuilder<IonRefresherContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("refreshingSpinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetRefreshingText(this PropsBuilder<IonRefresherContent> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("refreshingText"), value);
    }
    /// <summary>
    /// The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetRefreshingText(this PropsBuilder<IonRefresherContent> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("refreshingText"), b.Const(value));
    }

}

