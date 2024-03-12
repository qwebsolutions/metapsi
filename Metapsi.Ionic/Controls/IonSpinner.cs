using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonSpinner
{
}

public static partial class IonSpinnerControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSpinner(this LayoutBuilder b, Action<PropsBuilder<IonSpinner>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-spinner", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSpinner(this LayoutBuilder b, Action<PropsBuilder<IonSpinner>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-spinner", buildProps, children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonSpinner> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonSpinner> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// Duration of the spinner animation in milliseconds. The default varies based on the spinner.
    /// </summary>
    public static void SetDuration(this PropsBuilder<IonSpinner> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), value);
    }
    /// <summary>
    /// Duration of the spinner animation in milliseconds. The default varies based on the spinner.
    /// </summary>
    public static void SetDuration(this PropsBuilder<IonSpinner> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(value));
    }

    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameBubbles(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("bubbles"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCircles(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("circles"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCircular(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("circular"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameCrescent(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("crescent"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameDots(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("dots"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLines(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("lines"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSharp(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("lines-sharp"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSharpSmall(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("lines-sharp-small"));
    }
    /// <summary>
    /// The name of the SVG spinner to use. If a name is not provided, the platform's default spinner will be used.
    /// </summary>
    public static void SetNameLinesSmall(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("name"), b.Const("lines-small"));
    }

    /// <summary>
    /// If `true`, the spinner's animation will be paused.
    /// </summary>
    public static void SetPaused(this PropsBuilder<IonSpinner> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("paused"), b.Const(true));
    }

}

