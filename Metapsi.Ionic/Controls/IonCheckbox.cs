using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonCheckbox
{
}

public static partial class IonCheckboxControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCheckbox(this HtmlBuilder b, Action<AttributesBuilder<IonCheckbox>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-checkbox", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCheckbox(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-checkbox", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCheckbox(this HtmlBuilder b, Action<AttributesBuilder<IonCheckbox>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-checkbox", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCheckbox(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-checkbox", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. </para>
    /// </summary>
    public static void SetAlignment(this AttributesBuilder<IonCheckbox> b, string alignment)
    {
        b.SetAttribute("alignment", alignment);
    }

    /// <summary>
    /// <para> How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. </para>
    /// </summary>
    public static void SetAlignmentCenter(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("alignment", "center");
    }

    /// <summary>
    /// <para> How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. </para>
    /// </summary>
    public static void SetAlignmentStart(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("alignment", "start");
    }

    /// <summary>
    /// <para> If `true`, the checkbox is selected. </para>
    /// </summary>
    public static void SetChecked(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("checked", "");
    }

    /// <summary>
    /// <para> If `true`, the checkbox is selected. </para>
    /// </summary>
    public static void SetChecked(this AttributesBuilder<IonCheckbox> b, bool @checked)
    {
        if (@checked) b.SetAttribute("checked", "");
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonCheckbox> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the checkbox. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the checkbox. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonCheckbox> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the checkbox will visually appear as indeterminate. </para>
    /// </summary>
    public static void SetIndeterminate(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// <para> If `true`, the checkbox will visually appear as indeterminate. </para>
    /// </summary>
    public static void SetIndeterminate(this AttributesBuilder<IonCheckbox> b, bool indeterminate)
    {
        if (indeterminate) b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// <para> How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustify(this AttributesBuilder<IonCheckbox> b, string justify)
    {
        b.SetAttribute("justify", justify);
    }

    /// <summary>
    /// <para> How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifyEnd(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("justify", "end");
    }

    /// <summary>
    /// <para> How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifySpaceBetween(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("justify", "space-between");
    }

    /// <summary>
    /// <para> How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifyStart(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("justify", "start");
    }

    /// <summary>
    /// <para> Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonCheckbox> b, string labelPlacement)
    {
        b.SetAttribute("label-placement", labelPlacement);
    }

    /// <summary>
    /// <para> Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("label-placement", "end");
    }

    /// <summary>
    /// <para> Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }

    /// <summary>
    /// <para> Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }

    /// <summary>
    /// <para> Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonCheckbox> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonCheckbox> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<IonCheckbox> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The value of the checkbox does not mean if it's checked or not, use the `checked` property for that.  The value of a checkbox is analogous to the value of an `<input type="checkbox">`, it's only used when the checkbox participates in a native `<form>`. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonCheckbox> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCheckbox(this LayoutBuilder b, Action<PropsBuilder<IonCheckbox>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-checkbox", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCheckbox(this LayoutBuilder b, Action<PropsBuilder<IonCheckbox>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-checkbox", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCheckbox(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-checkbox", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCheckbox(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-checkbox", children);
    }
    /// <summary>
    /// <para> How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. </para>
    /// </summary>
    public static void SetAlignmentCenter<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alignment"), b.Const("center"));
    }


    /// <summary>
    /// <para> How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. </para>
    /// </summary>
    public static void SetAlignmentStart<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alignment"), b.Const("start"));
    }


    /// <summary>
    /// <para> If `true`, the checkbox is selected. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the checkbox is selected. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, Var<bool> @checked) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), @checked);
    }

    /// <summary>
    /// <para> If `true`, the checkbox is selected. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, bool @checked) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), b.Const(@checked));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the checkbox. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the checkbox. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the checkbox. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> If `true`, the checkbox will visually appear as indeterminate. </para>
    /// </summary>
    public static void SetIndeterminate<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("indeterminate"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the checkbox will visually appear as indeterminate. </para>
    /// </summary>
    public static void SetIndeterminate<T>(this PropsBuilder<T> b, Var<bool> indeterminate) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("indeterminate"), indeterminate);
    }

    /// <summary>
    /// <para> If `true`, the checkbox will visually appear as indeterminate. </para>
    /// </summary>
    public static void SetIndeterminate<T>(this PropsBuilder<T> b, bool indeterminate) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("indeterminate"), b.Const(indeterminate));
    }


    /// <summary>
    /// <para> How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifyEnd<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("justify"), b.Const("end"));
    }


    /// <summary>
    /// <para> How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifySpaceBetween<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("justify"), b.Const("space-between"));
    }


    /// <summary>
    /// <para> How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. </para>
    /// </summary>
    public static void SetJustifyStart<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("justify"), b.Const("start"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("end"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("fixed"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("stacked"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property. </para>
    /// </summary>
    public static void SetLabelPlacementStart<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("start"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The value of the checkbox does not mean if it's checked or not, use the `checked` property for that.  The value of a checkbox is analogous to the value of an `<input type="checkbox">`, it's only used when the checkbox participates in a native `<form>`. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<object> value) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), value);
    }

    /// <summary>
    /// <para> The value of the checkbox does not mean if it's checked or not, use the `checked` property for that.  The value of a checkbox is analogous to the value of an `<input type="checkbox">`, it's only used when the checkbox participates in a native `<form>`. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, object value) where T: IonCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Emitted when the checkbox loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonCheckbox
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// <para> Emitted when the checkbox loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonCheckbox
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the checked property has changed as a result of a user action such as a click. This event will not emit when programmatically setting the checked property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, CheckboxChangeEventDetail>> action) where TComponent: IonCheckbox
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the checked property has changed as a result of a user action such as a click. This event will not emit when programmatically setting the checked property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<CheckboxChangeEventDetail>, Var<TModel>> action) where TComponent: IonCheckbox
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the checkbox has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonCheckbox
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// <para> Emitted when the checkbox has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonCheckbox
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

