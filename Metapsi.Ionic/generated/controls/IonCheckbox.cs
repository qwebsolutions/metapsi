using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonCheckbox
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of IonCheckbox
/// </summary>
public static partial class IonCheckboxControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCheckbox(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonCheckbox>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-checkbox", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCheckbox(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-checkbox", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCheckbox(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonCheckbox>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-checkbox", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCheckbox(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-checkbox", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. Setting this property will change the checkbox `display` to `block`.
    /// </summary>
    public static void SetAlignmentCenter(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("alignment", "center");
    }

    /// <summary>
    /// How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. Setting this property will change the checkbox `display` to `block`.
    /// </summary>
    public static void SetAlignmentStart(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("alignment", "start");
    }

    /// <summary>
    /// If `true`, the checkbox is selected.
    /// </summary>
    public static void SetChecked(this Metapsi.Html.AttributesBuilder<IonCheckbox> b, bool @checked) 
    {
        if (@checked) b.SetAttribute("checked", "");
    }

    /// <summary>
    /// If `true`, the checkbox is selected.
    /// </summary>
    public static void SetChecked(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("checked", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonCheckbox> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the checkbox.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonCheckbox> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the checkbox.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Text that is placed under the checkbox label and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText(this Metapsi.Html.AttributesBuilder<IonCheckbox> b, string errorText) 
    {
        b.SetAttribute("errorText", errorText);
    }

    /// <summary>
    /// Text that is placed under the checkbox label and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText(this Metapsi.Html.AttributesBuilder<IonCheckbox> b, string helperText) 
    {
        b.SetAttribute("helperText", helperText);
    }

    /// <summary>
    /// If `true`, the checkbox will visually appear as indeterminate.
    /// </summary>
    public static void SetIndeterminate(this Metapsi.Html.AttributesBuilder<IonCheckbox> b, bool indeterminate) 
    {
        if (indeterminate) b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// If `true`, the checkbox will visually appear as indeterminate.
    /// </summary>
    public static void SetIndeterminate(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. Setting this property will change the checkbox `display` to `block`.
    /// </summary>
    public static void SetJustifyEnd(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("justify", "end");
    }

    /// <summary>
    /// How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. Setting this property will change the checkbox `display` to `block`.
    /// </summary>
    public static void SetJustifySpaceBetween(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("justify", "space-between");
    }

    /// <summary>
    /// How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. Setting this property will change the checkbox `display` to `block`.
    /// </summary>
    public static void SetJustifyStart(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("justify", "start");
    }

    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementEnd(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("labelPlacement", "end");
    }

    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementFixed(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("labelPlacement", "fixed");
    }

    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStacked(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("labelPlacement", "stacked");
    }

    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStart(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("labelPlacement", "start");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<IonCheckbox> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// If true, screen readers will announce it as a required field. This property works only for accessibility purposes, it will not prevent the form from submitting if the value is invalid.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<IonCheckbox> b, bool required) 
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// If true, screen readers will announce it as a required field. This property works only for accessibility purposes, it will not prevent the form from submitting if the value is invalid.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<IonCheckbox> b) 
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCheckbox(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonCheckbox>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-checkbox", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCheckbox(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-checkbox", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCheckbox(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonCheckbox>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-checkbox", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCheckbox(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-checkbox", children);
    }

    /// <summary>
    /// How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. Setting this property will change the checkbox `display` to `block`.
    /// </summary>
    public static void SetAlignmentCenter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("alignment"), b.Const("center"));
    }

    /// <summary>
    /// How to control the alignment of the checkbox and label on the cross axis. `"start"`: The label and control will appear on the left of the cross axis in LTR, and on the right side in RTL. `"center"`: The label and control will appear at the center of the cross axis in both LTR and RTL. Setting this property will change the checkbox `display` to `block`.
    /// </summary>
    public static void SetAlignmentStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("alignment"), b.Const("start"));
    }

    /// <summary>
    /// If `true`, the checkbox is selected.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetChecked(b.Const(true));
    }

    /// <summary>
    /// If `true`, the checkbox is selected.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @checked) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("checked"), @checked);
    }

    /// <summary>
    /// If `true`, the checkbox is selected.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @checked) where T: IonCheckbox
    {
        b.SetChecked(b.Const(@checked));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the checkbox.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the checkbox.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the checkbox.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonCheckbox
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Text that is placed under the checkbox label and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> errorText) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("errorText"), errorText);
    }

    /// <summary>
    /// Text that is placed under the checkbox label and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string errorText) where T: IonCheckbox
    {
        b.SetErrorText(b.Const(errorText));
    }

    /// <summary>
    /// Text that is placed under the checkbox label and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helperText) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("helperText"), helperText);
    }

    /// <summary>
    /// Text that is placed under the checkbox label and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helperText) where T: IonCheckbox
    {
        b.SetHelperText(b.Const(helperText));
    }

    /// <summary>
    /// If `true`, the checkbox will visually appear as indeterminate.
    /// </summary>
    public static void SetIndeterminate<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetIndeterminate(b.Const(true));
    }

    /// <summary>
    /// If `true`, the checkbox will visually appear as indeterminate.
    /// </summary>
    public static void SetIndeterminate<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> indeterminate) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("indeterminate"), indeterminate);
    }

    /// <summary>
    /// If `true`, the checkbox will visually appear as indeterminate.
    /// </summary>
    public static void SetIndeterminate<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool indeterminate) where T: IonCheckbox
    {
        b.SetIndeterminate(b.Const(indeterminate));
    }

    /// <summary>
    /// How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. Setting this property will change the checkbox `display` to `block`.
    /// </summary>
    public static void SetJustifyEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("justify"), b.Const("end"));
    }

    /// <summary>
    /// How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. Setting this property will change the checkbox `display` to `block`.
    /// </summary>
    public static void SetJustifySpaceBetween<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("justify"), b.Const("space-between"));
    }

    /// <summary>
    /// How to pack the label and checkbox within a line. `"start"`: The label and checkbox will appear on the left in LTR and on the right in RTL. `"end"`: The label and checkbox will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and checkbox will appear on opposite ends of the line with space between the two elements. Setting this property will change the checkbox `display` to `block`.
    /// </summary>
    public static void SetJustifyStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("justify"), b.Const("start"));
    }

    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("end"));
    }

    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("fixed"));
    }

    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("stacked"));
    }

    /// <summary>
    /// Where to place the label relative to the checkbox. `"start"`: The label will appear to the left of the checkbox in LTR and to the right in RTL. `"end"`: The label will appear to the right of the checkbox in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the checkbox regardless of the direction. The alignment of the label can be controlled with the `alignment` property.
    /// </summary>
    public static void SetLabelPlacementStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: IonCheckbox
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// If true, screen readers will announce it as a required field. This property works only for accessibility purposes, it will not prevent the form from submitting if the value is invalid.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonCheckbox
    {
        b.SetRequired(b.Const(true));
    }

    /// <summary>
    /// If true, screen readers will announce it as a required field. This property works only for accessibility purposes, it will not prevent the form from submitting if the value is invalid.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> required) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// If true, screen readers will announce it as a required field. This property works only for accessibility purposes, it will not prevent the form from submitting if the value is invalid.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool required) where T: IonCheckbox
    {
        b.SetRequired(b.Const(required));
    }

    /// <summary>
    /// The value of the checkbox does not mean if it's checked or not, use the `checked` property for that.  The value of a checkbox is analogous to the value of an `&lt;input type="checkbox"&gt;`, it's only used when the checkbox participates in a native `&lt;form&gt;`.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: IonCheckbox
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The value of the checkbox does not mean if it's checked or not, use the `checked` property for that.  The value of a checkbox is analogous to the value of an `&lt;input type="checkbox"&gt;`, it's only used when the checkbox participates in a native `&lt;form&gt;`.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, object value) where T: IonCheckbox
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonCheckbox
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonCheckbox
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonCheckbox
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonCheckbox
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checked property has changed as a result of a user action such as a click.  This event will not emit when programmatically setting the `checked` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonCheckbox
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the checked property has changed as a result of a user action such as a click.  This event will not emit when programmatically setting the `checked` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonCheckbox
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checked property has changed as a result of a user action such as a click.  This event will not emit when programmatically setting the `checked` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonCheckbox
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the checked property has changed as a result of a user action such as a click.  This event will not emit when programmatically setting the `checked` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonCheckbox
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checked property has changed as a result of a user action such as a click.  This event will not emit when programmatically setting the `checked` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<CheckboxChangeEventDetail>>> action) where T: IonCheckbox
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the checkbox has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonCheckbox
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the checkbox has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonCheckbox
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonCheckbox
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the checkbox has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonCheckbox
    {
        b.OnIonFocus(b.MakeAction(action));
    }

}