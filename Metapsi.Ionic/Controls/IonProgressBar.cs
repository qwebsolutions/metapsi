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
    /// <para> If the buffer and value are smaller than 1, the buffer circles will show. The buffer should be between [0, 1]. </para>
    /// </summary>
    public static void SetBuffer(this AttributesBuilder<IonProgressBar> b,string buffer)
    {
        b.SetAttribute("buffer", buffer);
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonProgressBar> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonProgressBar> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonProgressBar> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonProgressBar> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> If true, reverse the progress bar direction. </para>
    /// </summary>
    public static void SetReversed(this AttributesBuilder<IonProgressBar> b)
    {
        b.SetAttribute("reversed", "");
    }

    /// <summary>
    /// <para> If true, reverse the progress bar direction. </para>
    /// </summary>
    public static void SetReversed(this AttributesBuilder<IonProgressBar> b,bool reversed)
    {
        if (reversed) b.SetAttribute("reversed", "");
    }

    /// <summary>
    /// <para> The state of the progress bar, based on if the time the process takes is known or not. Default options are: `"determinate"` (no animation), `"indeterminate"` (animate from left to right). </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<IonProgressBar> b,string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The state of the progress bar, based on if the time the process takes is known or not. Default options are: `"determinate"` (no animation), `"indeterminate"` (animate from left to right). </para>
    /// </summary>
    public static void SetTypeDeterminate(this AttributesBuilder<IonProgressBar> b)
    {
        b.SetAttribute("type", "determinate");
    }

    /// <summary>
    /// <para> The state of the progress bar, based on if the time the process takes is known or not. Default options are: `"determinate"` (no animation), `"indeterminate"` (animate from left to right). </para>
    /// </summary>
    public static void SetTypeIndeterminate(this AttributesBuilder<IonProgressBar> b)
    {
        b.SetAttribute("type", "indeterminate");
    }

    /// <summary>
    /// <para> The value determines how much of the active bar should display when the `type` is `"determinate"`. The value should be between [0, 1]. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonProgressBar> b,string value)
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
    /// <para> If the buffer and value are smaller than 1, the buffer circles will show. The buffer should be between [0, 1]. </para>
    /// </summary>
    public static void SetBuffer<T>(this PropsBuilder<T> b, Var<int> buffer) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("buffer"), buffer);
    }

    /// <summary>
    /// <para> If the buffer and value are smaller than 1, the buffer circles will show. The buffer should be between [0, 1]. </para>
    /// </summary>
    public static void SetBuffer<T>(this PropsBuilder<T> b, int buffer) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("buffer"), b.Const(buffer));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> If true, reverse the progress bar direction. </para>
    /// </summary>
    public static void SetReversed<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("reversed"), b.Const(true));
    }


    /// <summary>
    /// <para> If true, reverse the progress bar direction. </para>
    /// </summary>
    public static void SetReversed<T>(this PropsBuilder<T> b, Var<bool> reversed) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("reversed"), reversed);
    }

    /// <summary>
    /// <para> If true, reverse the progress bar direction. </para>
    /// </summary>
    public static void SetReversed<T>(this PropsBuilder<T> b, bool reversed) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("reversed"), b.Const(reversed));
    }


    /// <summary>
    /// <para> The state of the progress bar, based on if the time the process takes is known or not. Default options are: `"determinate"` (no animation), `"indeterminate"` (animate from left to right). </para>
    /// </summary>
    public static void SetTypeDeterminate<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("determinate"));
    }


    /// <summary>
    /// <para> The state of the progress bar, based on if the time the process takes is known or not. Default options are: `"determinate"` (no animation), `"indeterminate"` (animate from left to right). </para>
    /// </summary>
    public static void SetTypeIndeterminate<T>(this PropsBuilder<T> b) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("indeterminate"));
    }


    /// <summary>
    /// <para> The value determines how much of the active bar should display when the `type` is `"determinate"`. The value should be between [0, 1]. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }

    /// <summary>
    /// <para> The value determines how much of the active bar should display when the `type` is `"determinate"`. The value should be between [0, 1]. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: IonProgressBar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }


}

