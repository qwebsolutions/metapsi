using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonToggle
{
}

public static partial class IonToggleControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonToggle(this HtmlBuilder b, Action<AttributesBuilder<IonToggle>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-toggle", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonToggle(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-toggle", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonToggle(this HtmlBuilder b, Action<AttributesBuilder<IonToggle>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-toggle", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonToggle(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-toggle", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> How to control the alignment of the toggle and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. </para>
    /// </summary>
    public static void SetAlignment(this AttributesBuilder<IonToggle> b, string alignment)
    {
        b.SetAttribute("alignment", alignment);
    }

    /// <summary>
    /// <para> How to control the alignment of the toggle and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. </para>
    /// </summary>
    public static void SetAlignmentCenter(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("alignment", "center");
    }

    /// <summary>
    /// <para> How to control the alignment of the toggle and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. </para>
    /// </summary>
    public static void SetAlignmentStart(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("alignment", "start");
    }

    /// <summary>
    /// <para> If `true`, the toggle is selected. </para>
    /// </summary>
    public static void SetChecked(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("checked", "");
    }

    /// <summary>
    /// <para> If `true`, the toggle is selected. </para>
    /// </summary>
    public static void SetChecked(this AttributesBuilder<IonToggle> b, bool @checked)
    {
        if (@checked) b.SetAttribute("checked", "");
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonToggle> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the toggle. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the toggle. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonToggle> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Enables the on/off accessibility switch labels within the toggle. </para>
    /// </summary>
    public static void SetEnableOnOffLabels(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("enable-on-off-labels", "");
    }

    /// <summary>
    /// <para> Enables the on/off accessibility switch labels within the toggle. </para>
    /// </summary>
    public static void SetEnableOnOffLabels(this AttributesBuilder<IonToggle> b, bool enableOnOffLabels)
    {
        if (enableOnOffLabels) b.SetAttribute("enable-on-off-labels", "");
    }

    /// <summary>
    /// <para> How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustify(this AttributesBuilder<IonToggle> b, string justify)
    {
        b.SetAttribute("justify", justify);
    }

    /// <summary>
    /// <para> How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifyEnd(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("justify", "end");
    }

    /// <summary>
    /// <para> How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifySpaceBetween(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("justify", "space-between");
    }

    /// <summary>
    /// <para> How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifyStart(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("justify", "start");
    }

    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonToggle> b, string labelPlacement)
    {
        b.SetAttribute("label-placement", labelPlacement);
    }

    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("label-placement", "end");
    }

    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }

    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }

    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonToggle> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonToggle> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<IonToggle> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The value of the toggle does not mean if it's checked or not, use the `checked` property for that.  The value of a toggle is analogous to the value of a `<input type="checkbox">`, it's only used when the toggle participates in a native `<form>`. </para>
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
    /// <para> How to control the alignment of the toggle and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. </para>
    /// </summary>
    public static void SetAlignmentCenter<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alignment"), b.Const("center"));
    }


    /// <summary>
    /// <para> How to control the alignment of the toggle and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. </para>
    /// </summary>
    public static void SetAlignmentStart<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alignment"), b.Const("start"));
    }


    /// <summary>
    /// <para> If `true`, the toggle is selected. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the toggle is selected. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, Var<bool> @checked) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), @checked);
    }

    /// <summary>
    /// <para> If `true`, the toggle is selected. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, bool @checked) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), b.Const(@checked));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the toggle. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the toggle. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the toggle. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Enables the on/off accessibility switch labels within the toggle. </para>
    /// </summary>
    public static void SetEnableOnOffLabels<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("enableOnOffLabels"), b.Const(true));
    }


    /// <summary>
    /// <para> Enables the on/off accessibility switch labels within the toggle. </para>
    /// </summary>
    public static void SetEnableOnOffLabels<T>(this PropsBuilder<T> b, Var<bool> enableOnOffLabels) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("enableOnOffLabels"), enableOnOffLabels);
    }

    /// <summary>
    /// <para> Enables the on/off accessibility switch labels within the toggle. </para>
    /// </summary>
    public static void SetEnableOnOffLabels<T>(this PropsBuilder<T> b, bool enableOnOffLabels) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("enableOnOffLabels"), b.Const(enableOnOffLabels));
    }


    /// <summary>
    /// <para> How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifyEnd<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("justify"), b.Const("end"));
    }


    /// <summary>
    /// <para> How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifySpaceBetween<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("justify"), b.Const("space-between"));
    }


    /// <summary>
    /// <para> How to pack the label and toggle within a line. `"start"`: The label and toggle will appear on the left in LTR and on the right in RTL. `"end"`: The label and toggle will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and toggle will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifyStart<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("justify"), b.Const("start"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("end"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("fixed"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("stacked"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the toggle in LTR and to the right in RTL. `"end"`: The label will appear to the right of the toggle in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the toggle regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStart<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("start"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The value of the toggle does not mean if it's checked or not, use the `checked` property for that.  The value of a toggle is analogous to the value of a `<input type="checkbox">`, it's only used when the toggle participates in a native `<form>`. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The value of the toggle does not mean if it's checked or not, use the `checked` property for that.  The value of a toggle is analogous to the value of a `<input type="checkbox">`, it's only used when the toggle participates in a native `<form>`. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Emitted when the toggle loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// <para> Emitted when the toggle loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the user switches the toggle on or off. Does not emit when programmatically changing the value of the `checked` property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, ToggleChangeEventDetail>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the user switches the toggle on or off. Does not emit when programmatically changing the value of the `checked` property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ToggleChangeEventDetail>, Var<TModel>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the toggle has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// <para> Emitted when the toggle has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToggle
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

