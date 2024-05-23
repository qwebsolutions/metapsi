using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonToggle : IonComponent
{
    public IonToggle() : base("ion-toggle") { }
    /// <summary> 
    /// The label text to associate with the toggle. Use the "labelPlacement" property to control where the label is placed relative to the toggle.
    /// </summary>
    public static class Slot
    {
    }
}

public static partial class IonToggleControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonToggle(this HtmlBuilder b, Action<AttributesBuilder<IonToggle>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-toggle", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonToggle(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-toggle", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// How to control the alignment of the toggle and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignment(this AttributesBuilder<IonToggle> b, string value)
    {
        b.SetAttribute("alignment", value);
    }
    /// <summary>
    /// How to control the alignment of the toggle and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignmentCenter(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("alignment", "center");
    }
    /// <summary>
    /// How to control the alignment of the toggle and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignmentStart(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("alignment", "start");
    }

    /// <summary>
    /// If `true`, the toggle is selected.
    /// </summary>
    public static void SetChecked(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("checked", "");
    }
    /// <summary>
    /// If `true`, the toggle is selected.
    /// </summary>
    public static void SetChecked(this AttributesBuilder<IonToggle> b, bool value)
    {
        if (value) b.SetAttribute("checked", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonToggle> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the toggle.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the toggle.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonToggle> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Enables the on/off accessibility switch labels within the toggle.
    /// </summary>
    public static void SetEnableOnOffLabels(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("enable-on-off-labels", "");
    }
    /// <summary>
    /// Enables the on/off accessibility switch labels within the toggle.
    /// </summary>
    public static void SetEnableOnOffLabels(this AttributesBuilder<IonToggle> b, bool value)
    {
        if (value) b.SetAttribute("enable-on-off-labels", "");
    }

    /// <summary>
    /// How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustify(this AttributesBuilder<IonToggle> b, string value)
    {
        b.SetAttribute("justify", value);
    }
    /// <summary>
    /// How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyEnd(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("justify", "end");
    }
    /// <summary>
    /// How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifySpaceBetween(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("justify", "space-between");
    }
    /// <summary>
    /// How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyStart(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("justify", "start");
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonToggle> b, string value)
    {
        b.SetAttribute("label-placement", value);
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("label-placement", "end");
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonToggle> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this AttributesBuilder<IonToggle> b, string value)
    {
        b.SetAttribute("name", value);
    }

    /// <summary>
    /// The value of the toggle does not mean if it's checked or not, use the `checked` property for that.  The value of a toggle is analogous to the value of a `<input type="checkbox">`, it's only used when the toggle participates in a native `<form>`.
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonToggle> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonToggle(this LayoutBuilder b, Action<PropsBuilder<IonToggle>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-toggle", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonToggle(this LayoutBuilder b, Action<PropsBuilder<IonToggle>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-toggle", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonToggle(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-toggle", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonToggle(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-toggle", children);
    }
    /// <summary>
    /// How to control the alignment of the toggle and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignmentCenter<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("center"));
    }
    /// <summary>
    /// How to control the alignment of the toggle and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL.
    /// </summary>
    public static void SetAlignmentStart<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("start"));
    }

    /// <summary>
    /// If `true`, the toggle is selected.
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("checked"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the toggle is selected.
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("checked"), value);
    }
    /// <summary>
    /// If `true`, the toggle is selected.
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, bool value) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("checked"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the toggle.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the user cannot interact with the toggle.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the toggle.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// Enables the on/off accessibility switch labels within the toggle.
    /// </summary>
    public static void SetEnableOnOffLabels<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("enableOnOffLabels"), b.Const(true));
    }
    /// <summary>
    /// Enables the on/off accessibility switch labels within the toggle.
    /// </summary>
    public static void SetEnableOnOffLabels<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("enableOnOffLabels"), value);
    }
    /// <summary>
    /// Enables the on/off accessibility switch labels within the toggle.
    /// </summary>
    public static void SetEnableOnOffLabels<T>(this PropsBuilder<T> b, bool value) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("enableOnOffLabels"), b.Const(value));
    }

    /// <summary>
    /// How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyEnd<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("end"));
    }
    /// <summary>
    /// How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifySpaceBetween<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("space-between"));
    }
    /// <summary>
    /// How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyStart<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("justify"), b.Const("start"));
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("end"));
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("fixed"));
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("stacked"));
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStart<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> value) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string value) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// The value of the toggle does not mean if it's checked or not, use the `checked` property for that.  The value of a toggle is analogous to the value of a `<input type="checkbox">`, it's only used when the toggle participates in a native `<form>`.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The value of the toggle does not mean if it's checked or not, use the `checked` property for that.  The value of a toggle is analogous to the value of a `<input type="checkbox">`, it's only used when the toggle participates in a native `<form>`.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the toggle loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the toggle loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user switches the toggle on or off. Does not emit when programmatically changing the value of the `checked` property.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, ToggleChangeEventDetail>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the user switches the toggle on or off. Does not emit when programmatically changing the value of the `checked` property.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ToggleChangeEventDetail>, Var<TModel>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the toggle has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the toggle has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

