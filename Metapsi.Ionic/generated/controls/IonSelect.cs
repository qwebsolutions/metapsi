using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonSelect
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Content to display at the trailing edge of the select.
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// The label text to associate with the select. Use the `labelPlacement` property to control where the label is placed relative to the select. Use this if you need to render a label with custom HTML.
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// Content to display at the leading edge of the select.
        /// </summary>
        public const string Start = "start";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Open the select overlay. The overlay is either an alert, action sheet, or popover, depending on the `interface` property on the `ion-select`.
        /// </summary>
        public const string Open = "open";
    }
}
/// <summary>
/// Setter extensions of IonSelect
/// </summary>
public static partial class IonSelectControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSelect(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSelect>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-select", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSelect(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-select", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSelect(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSelect>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-select", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSelect(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-select", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The text to display on the cancel button.
    /// </summary>
    public static void SetCancelText(this Metapsi.Html.AttributesBuilder<IonSelect> b, string cancelText) 
    {
        b.SetAttribute("cancelText", cancelText);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonSelect> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith(this Metapsi.Html.AttributesBuilder<IonSelect> b, string compareWith) 
    {
        b.SetAttribute("compareWith", compareWith);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSelect> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Text that is placed under the select and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText(this Metapsi.Html.AttributesBuilder<IonSelect> b, string errorText) 
    {
        b.SetAttribute("errorText", errorText);
    }

    /// <summary>
    /// The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed.
    /// </summary>
    public static void SetExpandedIcon(this Metapsi.Html.AttributesBuilder<IonSelect> b, string expandedIcon) 
    {
        b.SetAttribute("expandedIcon", expandedIcon);
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("fill", "outline");
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// Text that is placed under the select and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText(this Metapsi.Html.AttributesBuilder<IonSelect> b, string helperText) 
    {
        b.SetAttribute("helperText", helperText);
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover`, `alert`, or `modal`.
    /// </summary>
    public static void SetInterfaceActionSheet(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("interface", "action-sheet");
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover`, `alert`, or `modal`.
    /// </summary>
    public static void SetInterfaceAlert(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("interface", "alert");
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover`, `alert`, or `modal`.
    /// </summary>
    public static void SetInterfaceModal(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("interface", "modal");
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover`, `alert`, or `modal`.
    /// </summary>
    public static void SetInterfacePopover(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("interface", "popover");
    }

    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyEnd(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("justify", "end");
    }

    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifySpaceBetween(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("justify", "space-between");
    }

    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyStart(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("justify", "start");
    }

    /// <summary>
    /// The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<IonSelect> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementEnd(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("labelPlacement", "end");
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementFixed(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("labelPlacement", "fixed");
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementFloating(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("labelPlacement", "floating");
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementStacked(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("labelPlacement", "stacked");
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementStart(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("labelPlacement", "start");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public static void SetMultiple(this Metapsi.Html.AttributesBuilder<IonSelect> b, bool multiple) 
    {
        if (multiple) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public static void SetMultiple(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<IonSelect> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// The text to display on the ok button.
    /// </summary>
    public static void SetOkText(this Metapsi.Html.AttributesBuilder<IonSelect> b, string okText) 
    {
        b.SetAttribute("okText", okText);
    }

    /// <summary>
    /// The text to display when the select is empty.
    /// </summary>
    public static void SetPlaceholder(this Metapsi.Html.AttributesBuilder<IonSelect> b, string placeholder) 
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// If true, screen readers will announce it as a required field. This property works only for accessibility purposes, it will not prevent the form from submitting if the value is invalid.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<IonSelect> b, bool required) 
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// If true, screen readers will announce it as a required field. This property works only for accessibility purposes, it will not prevent the form from submitting if the value is invalid.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// The text to display instead of the selected option's value.
    /// </summary>
    public static void SetSelectedText(this Metapsi.Html.AttributesBuilder<IonSelect> b, string selectedText) 
    {
        b.SetAttribute("selectedText", selectedText);
    }

    /// <summary>
    /// The shape of the select. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound(this Metapsi.Html.AttributesBuilder<IonSelect> b) 
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode.
    /// </summary>
    public static void SetToggleIcon(this Metapsi.Html.AttributesBuilder<IonSelect> b, string toggleIcon) 
    {
        b.SetAttribute("toggleIcon", toggleIcon);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSelect(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSelect>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-select", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSelect(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-select", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSelect(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSelect>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-select", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSelect(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-select", children);
    }

    /// <summary>
    /// The text to display on the cancel button.
    /// </summary>
    public static void SetCancelText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> cancelText) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("cancelText"), cancelText);
    }

    /// <summary>
    /// The text to display on the cancel button.
    /// </summary>
    public static void SetCancelText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string cancelText) where T: IonSelect
    {
        b.SetCancelText(b.Const(cancelText));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).  This property is only available when using the modern select syntax.
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> compareWith) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("compareWith"), compareWith);
    }

    /// <summary>
    /// This property allows developers to specify a custom function or property name for comparing objects when determining the selected option in the ion-select. When not specified, the default behavior will use strict equality (===) for comparison.
    /// </summary>
    public static void SetCompareWith<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, bool>> compareWith) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("compareWith"), compareWith);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the select.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonSelect
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Text that is placed under the select and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> errorText) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("errorText"), errorText);
    }

    /// <summary>
    /// Text that is placed under the select and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string errorText) where T: IonSelect
    {
        b.SetErrorText(b.Const(errorText));
    }

    /// <summary>
    /// The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed.
    /// </summary>
    public static void SetExpandedIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> expandedIcon) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("expandedIcon"), expandedIcon);
    }

    /// <summary>
    /// The toggle icon to show when the select is open. If defined, the icon rotation behavior in `md` mode will be disabled. If undefined, `toggleIcon` will be used for when the select is both open and closed.
    /// </summary>
    public static void SetExpandedIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, string expandedIcon) where T: IonSelect
    {
        b.SetExpandedIcon(b.Const(expandedIcon));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const("outline"));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const("solid"));
    }

    /// <summary>
    /// Text that is placed under the select and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helperText) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("helperText"), helperText);
    }

    /// <summary>
    /// Text that is placed under the select and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helperText) where T: IonSelect
    {
        b.SetHelperText(b.Const(helperText));
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover`, `alert`, or `modal`.
    /// </summary>
    public static void SetInterfaceActionSheet<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("interface"), b.Const("action-sheet"));
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover`, `alert`, or `modal`.
    /// </summary>
    public static void SetInterfaceAlert<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("interface"), b.Const("alert"));
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover`, `alert`, or `modal`.
    /// </summary>
    public static void SetInterfaceModal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("interface"), b.Const("modal"));
    }

    /// <summary>
    /// The interface the select should use: `action-sheet`, `popover`, `alert`, or `modal`.
    /// </summary>
    public static void SetInterfacePopover<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("interface"), b.Const("popover"));
    }

    /// <summary>
    /// Any additional options that the `alert`, `action-sheet` or `popover` interface can take. See the [ion-alert docs](./alert), the [ion-action-sheet docs](./action-sheet), the [ion-popover docs](./popover), and the [ion-modal docs](./modal) for the create options for each interface.  Note: `interfaceOptions` will not override `inputs` or `buttons` with the `alert` interface.
    /// </summary>
    public static void SetInterfaceOptions<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> interfaceOptions) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("interfaceOptions"), interfaceOptions);
    }

    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("justify"), b.Const("end"));
    }

    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifySpaceBetween<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("justify"), b.Const("space-between"));
    }

    /// <summary>
    /// How to pack the label and select within a line. `justify` does not apply when the label and select are on different lines when `labelPlacement` is set to `"floating"` or `"stacked"`. `"start"`: The label and select will appear on the left in LTR and on the right in RTL. `"end"`: The label and select will appear on the right in LTR and on the left in RTL. `"space-between"`: The label and select will appear on opposite ends of the line with space between the two elements.
    /// </summary>
    public static void SetJustifyStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("justify"), b.Const("start"));
    }

    /// <summary>
    /// The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The visible label associated with the select.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: IonSelect
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("end"));
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("fixed"));
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementFloating<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("floating"));
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("stacked"));
    }

    /// <summary>
    /// Where to place the label relative to the select. `"start"`: The label will appear to the left of the select in LTR and to the right in RTL. `"end"`: The label will appear to the right of the select in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the select when the select is focused or it has a value. Otherwise it will appear on top of the select. `"stacked"`: The label will appear smaller and above the select regardless even when the select is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). When using `"floating"` or `"stacked"` we recommend initializing the select with either a `value` or a `placeholder`.
    /// </summary>
    public static void SetLabelPlacementStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetMultiple(b.Const(true));
    }

    /// <summary>
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> multiple) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("multiple"), multiple);
    }

    /// <summary>
    /// If `true`, the select can accept multiple values.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool multiple) where T: IonSelect
    {
        b.SetMultiple(b.Const(multiple));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: IonSelect
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// The text to display on the ok button.
    /// </summary>
    public static void SetOkText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> okText) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("okText"), okText);
    }

    /// <summary>
    /// The text to display on the ok button.
    /// </summary>
    public static void SetOkText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string okText) where T: IonSelect
    {
        b.SetOkText(b.Const(okText));
    }

    /// <summary>
    /// The text to display when the select is empty.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> placeholder) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }

    /// <summary>
    /// The text to display when the select is empty.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, string placeholder) where T: IonSelect
    {
        b.SetPlaceholder(b.Const(placeholder));
    }

    /// <summary>
    /// If true, screen readers will announce it as a required field. This property works only for accessibility purposes, it will not prevent the form from submitting if the value is invalid.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetRequired(b.Const(true));
    }

    /// <summary>
    /// If true, screen readers will announce it as a required field. This property works only for accessibility purposes, it will not prevent the form from submitting if the value is invalid.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> required) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// If true, screen readers will announce it as a required field. This property works only for accessibility purposes, it will not prevent the form from submitting if the value is invalid.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool required) where T: IonSelect
    {
        b.SetRequired(b.Const(required));
    }

    /// <summary>
    /// The text to display instead of the selected option's value.
    /// </summary>
    public static void SetSelectedText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> selectedText) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("selectedText"), selectedText);
    }

    /// <summary>
    /// The shape of the select. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("round"));
    }

    /// <summary>
    /// The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode.
    /// </summary>
    public static void SetToggleIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> toggleIcon) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("toggleIcon"), toggleIcon);
    }

    /// <summary>
    /// The toggle icon to use. Defaults to `chevronExpand` for `ios` mode, or `caretDownSharp` for `md` mode.
    /// </summary>
    public static void SetToggleIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, string toggleIcon) where T: IonSelect
    {
        b.SetToggleIcon(b.Const(toggleIcon));
    }

    /// <summary>
    /// The value of the select.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> value) where T: IonSelect
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// Emitted when the select loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSelect
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the select loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSelect
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSelect
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the select loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSelect
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the selection is cancelled.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSelect
    {
        b.SetProperty(b.Props, "onionCancel", action);
    }

    /// <summary>
    /// Emitted when the selection is cancelled.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSelect
    {
        b.OnIonCancel(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the selection is cancelled.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSelect
    {
        b.SetProperty(b.Props, "onionCancel", action);
    }

    /// <summary>
    /// Emitted when the selection is cancelled.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSelect
    {
        b.OnIonCancel(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSelect
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSelect
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSelect
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSelect
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SelectChangeEventDetail>>> action) where T: IonSelect
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the overlay is dismissed.
    /// </summary>
    public static void OnIonDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSelect
    {
        b.SetProperty(b.Props, "onionDismiss", action);
    }

    /// <summary>
    /// Emitted when the overlay is dismissed.
    /// </summary>
    public static void OnIonDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSelect
    {
        b.OnIonDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the overlay is dismissed.
    /// </summary>
    public static void OnIonDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSelect
    {
        b.SetProperty(b.Props, "onionDismiss", action);
    }

    /// <summary>
    /// Emitted when the overlay is dismissed.
    /// </summary>
    public static void OnIonDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSelect
    {
        b.OnIonDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSelect
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the select has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSelect
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSelect
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the select has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSelect
    {
        b.OnIonFocus(b.MakeAction(action));
    }

}