using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonProgressBar : IonComponent
{
    public IonProgressBar() : base("ion-progress-bar") { }
}

public static partial class IonProgressBarControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonProgressBar(this HtmlBuilder b, Action<AttributesBuilder<IonProgressBar>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-progress-bar", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonProgressBar(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-progress-bar", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If the buffer and value are smaller than 1, the buffer circles will show. The buffer should be between [0, 1].
    /// </summary>
    public static void SetBuffer(this AttributesBuilder<IonProgressBar> b, string value)
    {
        b.SetAttribute("buffer", value);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonProgressBar> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonProgressBar> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonProgressBar> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonProgressBar> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If true, reverse the progress bar direction.
    /// </summary>
    public static void SetReversed(this AttributesBuilder<IonProgressBar> b)
    {
        b.SetAttribute("reversed", "");
    }
    /// <summary>
    /// If true, reverse the progress bar direction.
    /// </summary>
    public static void SetReversed(this AttributesBuilder<IonProgressBar> b, bool value)
    {
        if (value) b.SetAttribute("reversed", "");
    }

    /// <summary>
    /// The state of the progress bar, based on if the time the process takes is known or not. Default options are: `"determinate"` (no animation), `"indeterminate"` (animate from left to right).
    /// </summary>
    public static void SetType(this AttributesBuilder<IonProgressBar> b, string value)
    {
        b.SetAttribute("type", value);
    }
    /// <summary>
    /// The state of the progress bar, based on if the time the process takes is known or not. Default options are: `"determinate"` (no animation), `"indeterminate"` (animate from left to right).
    /// </summary>
    public static void SetTypeDeterminate(this AttributesBuilder<IonProgressBar> b)
    {
        b.SetAttribute("type", "determinate");
    }
    /// <summary>
    /// The state of the progress bar, based on if the time the process takes is known or not. Default options are: `"determinate"` (no animation), `"indeterminate"` (animate from left to right).
    /// </summary>
    public static void SetTypeIndeterminate(this AttributesBuilder<IonProgressBar> b)
    {
        b.SetAttribute("type", "indeterminate");
    }

    /// <summary>
    /// The value determines how much of the active bar should display when the `type` is `"determinate"`. The value should be between [0, 1].
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonProgressBar> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonProgressBar(this LayoutBuilder b, Action<PropsBuilder<IonProgressBar>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-progress-bar", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonProgressBar(this LayoutBuilder b, Action<PropsBuilder<IonProgressBar>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-progress-bar", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonProgressBar(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-progress-bar", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonProgressBar(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-progress-bar", children);
    }
    /// <summary>
    /// If the buffer and value are smaller than 1, the buffer circles will show. The buffer should be between [0, 1].
    /// </summary>
    public static void SetBuffer<T>(this PropsBuilder<T> b, Var<int> value) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("buffer"), value);
    }
    /// <summary>
    /// If the buffer and value are smaller than 1, the buffer circles will show. The buffer should be between [0, 1].
    /// </summary>
    public static void SetBuffer<T>(this PropsBuilder<T> b, int value) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("buffer"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If true, reverse the progress bar direction.
    /// </summary>
    public static void SetReversed<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("reversed"), b.Const(true));
    }

    /// <summary>
    /// The state of the progress bar, based on if the time the process takes is known or not. Default options are: `"determinate"` (no animation), `"indeterminate"` (animate from left to right).
    /// </summary>
    public static void SetTypeDeterminate<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("determinate"));
    }
    /// <summary>
    /// The state of the progress bar, based on if the time the process takes is known or not. Default options are: `"determinate"` (no animation), `"indeterminate"` (animate from left to right).
    /// </summary>
    public static void SetTypeIndeterminate<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("indeterminate"));
    }

    /// <summary>
    /// The value determines how much of the active bar should display when the `type` is `"determinate"`. The value should be between [0, 1].
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The value determines how much of the active bar should display when the `type` is `"determinate"`. The value should be between [0, 1].
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }

}

