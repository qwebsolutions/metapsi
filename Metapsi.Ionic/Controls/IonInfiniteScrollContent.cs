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
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public string loadingSpinner
    {
        get
        {
            return this.GetTag().GetAttribute<string>("loadingSpinner");
        }
        set
        {
            this.GetTag().SetAttribute("loadingSpinner", value.ToString());
        }
    }

    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public string loadingText
    {
        get
        {
            return this.GetTag().GetAttribute<string>("loadingText");
        }
        set
        {
            this.GetTag().SetAttribute("loadingText", value.ToString());
        }
    }

}

public static partial class IonInfiniteScrollContentControl
{
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
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerBubbles(this PropsBuilder<IonInfiniteScrollContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("bubbles"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircles(this PropsBuilder<IonInfiniteScrollContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("circles"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircular(this PropsBuilder<IonInfiniteScrollContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("circular"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCrescent(this PropsBuilder<IonInfiniteScrollContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("crescent"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerDots(this PropsBuilder<IonInfiniteScrollContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("dots"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLines(this PropsBuilder<IonInfiniteScrollContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("lines"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharp(this PropsBuilder<IonInfiniteScrollContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("lines-sharp"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharpSmall(this PropsBuilder<IonInfiniteScrollContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("lines-sharp-small"));
    }
    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSmall(this PropsBuilder<IonInfiniteScrollContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("loadingSpinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetLoadingText(this PropsBuilder<IonInfiniteScrollContent> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("loadingText"), value);
    }
    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetLoadingText(this PropsBuilder<IonInfiniteScrollContent> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("loadingText"), b.Const(value));
    }

}

