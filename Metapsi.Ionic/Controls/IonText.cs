using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonText : IonComponent
{
    public IonText() : base("ion-text") { }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public string color
    {
        get
        {
            return this.GetTag().GetAttribute<string>("color");
        }
        set
        {
            this.GetTag().SetAttribute("color", value.ToString());
        }
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("mode");
        }
        set
        {
            this.GetTag().SetAttribute("mode", value.ToString());
        }
    }

}

public static partial class IonTextControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonText(this LayoutBuilder b, Action<PropsBuilder<IonText>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-text", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonText(this LayoutBuilder b, Action<PropsBuilder<IonText>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-text", buildProps, children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonText> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonText> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

}

