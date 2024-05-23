using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonSegmentButton : IonComponent
{
    public IonSegmentButton() : base("ion-segment-button") { }
}

public static partial class IonSegmentButtonControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSegmentButton(this HtmlBuilder b, Action<AttributesBuilder<IonSegmentButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-segment-button", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSegmentButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-segment-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSegmentButton> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayout(this AttributesBuilder<IonSegmentButton> b, string value)
    {
        b.SetAttribute("layout", value);
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconBottom(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "icon-bottom");
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconEnd(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "icon-end");
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconHide(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "icon-hide");
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconStart(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "icon-start");
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconTop(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "icon-top");
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutLabelHide(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "label-hide");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonSegmentButton> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetType(this AttributesBuilder<IonSegmentButton> b, string value)
    {
        b.SetAttribute("type", value);
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("type", "button");
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("type", "reset");
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonSegmentButton> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSegmentButton(this LayoutBuilder b, Action<PropsBuilder<IonSegmentButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-segment-button", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSegmentButton(this LayoutBuilder b, Action<PropsBuilder<IonSegmentButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-segment-button", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSegmentButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-segment-button", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSegmentButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-segment-button", children);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconBottom<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-bottom"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconEnd<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-end"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconHide<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-hide"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconStart<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-start"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconTop<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-top"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutLabelHide<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("label-hide"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("button"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reset"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("submit"));
    }

    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }
    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

}

