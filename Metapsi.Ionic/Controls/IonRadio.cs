using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonRadio : IonComponent
{
    public IonRadio() : base("ion-radio") { }
    /// <summary> 
    /// The label text to associate with the radio. Use the "labelPlacement" property to control where the label is placed relative to the radio.
    /// </summary>
    public static class Slot
    {
    }
}

public static partial class IonRadioControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRadio(this HtmlBuilder b, Action<AttributesBuilder<IonRadio>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-radio", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRadio(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-radio", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// How to control the alignment of the radio and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignment(this AttributesBuilder<IonRadio> b, string value)
    {
        b.SetAttribute("alignment", value);
    }
    /// <summary>
    /// How to control the alignment of the radio and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignmentCenter(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("alignment", "center");
    }
    /// <summary>
    /// How to control the alignment of the radio and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignmentStart(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("alignment", "start");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonRadio> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the radio.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the radio.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRadio> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustify(this AttributesBuilder<IonRadio> b, string value)
    {
        b.SetAttribute("justify", value);
    }
    /// <summary>
    /// How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyEnd(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("justify", "end");
    }
    /// <summary>
    /// How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifySpaceBetween(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("justify", "space-between");
    }
    /// <summary>
    /// How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyStart(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("justify", "start");
    }

    /// <summary>
    /// Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonRadio> b, string value)
    {
        b.SetAttribute("label-placement", value);
    }
    /// <summary>
    /// Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("label-placement", "end");
    }
    /// <summary>
    /// Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }
    /// <summary>
    /// Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }
    /// <summary>
    /// Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonRadio> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonRadio> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this AttributesBuilder<IonRadio> b, string value)
    {
        b.SetAttribute("name", value);
    }

    /// <summary>
    /// the value of the radio.
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonRadio> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRadio(this LayoutBuilder b, Action<PropsBuilder<IonRadio>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-radio", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRadio(this LayoutBuilder b, Action<PropsBuilder<IonRadio>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-radio", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRadio(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-radio", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRadio(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-radio", children);
    }
    /// <summary>
    /// How to control the alignment of the radio and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignmentCenter<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("center"));
    }
    /// <summary>
    /// How to control the alignment of the radio and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignmentStart<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("start"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the radio.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the user cannot interact with the radio.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the radio.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyEnd<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("end"));
    }
    /// <summary>
    /// How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifySpaceBetween<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("space-between"));
    }
    /// <summary>
    /// How to pack the label and radio within a line. `"start"`: The label and radio will appear on the left in LTR and on the right in RTL. `"end"`: The label and radio will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and radio will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyStart<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("start"));
    }

    /// <summary>
    /// Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("end"));
    }
    /// <summary>
    /// Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("fixed"));
    }
    /// <summary>
    /// Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("stacked"));
    }
    /// <summary>
    /// Where to place the label relative to the radio. `"start"`: The label will appear to the left of the radio in LTR and to the right in RTL. `"end"`: The label will appear to the right of the radio in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the radio regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStart<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonRadio
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string value) where T: IonRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// the value of the radio.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<object> value) where T: IonRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), value);
    }
    /// <summary>
    /// the value of the radio.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, object value) where T: IonRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the radio button loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRadio
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the radio button loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRadio
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the radio button has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRadio
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the radio button has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRadio
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

