using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonRange
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Content is placed to the right of the range slider in LTR, and to the left in RTL.
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// The label text to associate with the range. Use the "labelPlacement" property to control where the label is placed relative to the range.
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// Content is placed to the left of the range slider in LTR, and to the right in RTL.
        /// </summary>
        public const string Start = "start";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of IonRange
/// </summary>
public static partial class IonRangeControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRange(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRange>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-range", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRange(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-range", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRange(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRange>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-range", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRange(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-range", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The start position of the range active bar. This feature is only available with a single knob (dualKnobs="false"). Valid values are greater than or equal to the min value and less than or equal to the max value.
    /// </summary>
    public static void SetActiveBarStart(this Metapsi.Html.AttributesBuilder<IonRange> b, string activeBarStart) 
    {
        b.SetAttribute("activeBarStart", activeBarStart);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonRange> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// How long, in milliseconds, to wait to trigger the `ionInput` event after each change in the range value.
    /// </summary>
    public static void SetDebounce(this Metapsi.Html.AttributesBuilder<IonRange> b, string debounce) 
    {
        b.SetAttribute("debounce", debounce);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the range.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonRange> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the range.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Show two knobs.
    /// </summary>
    public static void SetDualKnobs(this Metapsi.Html.AttributesBuilder<IonRange> b, bool dualKnobs) 
    {
        if (dualKnobs) b.SetAttribute("dualKnobs", "");
    }

    /// <summary>
    /// Show two knobs.
    /// </summary>
    public static void SetDualKnobs(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("dualKnobs", "");
    }

    /// <summary>
    /// The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<IonRange> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementEnd(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("labelPlacement", "end");
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementFixed(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("labelPlacement", "fixed");
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementStacked(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("labelPlacement", "stacked");
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementStart(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("labelPlacement", "start");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<IonRange> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// If `true`, a pin with integer value is shown when the knob is pressed.
    /// </summary>
    public static void SetPin(this Metapsi.Html.AttributesBuilder<IonRange> b, bool pin) 
    {
        if (pin) b.SetAttribute("pin", "");
    }

    /// <summary>
    /// If `true`, a pin with integer value is shown when the knob is pressed.
    /// </summary>
    public static void SetPin(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("pin", "");
    }

    /// <summary>
    /// If `true`, the knob snaps to tick marks evenly spaced based on the step property value.
    /// </summary>
    public static void SetSnaps(this Metapsi.Html.AttributesBuilder<IonRange> b, bool snaps) 
    {
        if (snaps) b.SetAttribute("snaps", "");
    }

    /// <summary>
    /// If `true`, the knob snaps to tick marks evenly spaced based on the step property value.
    /// </summary>
    public static void SetSnaps(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("snaps", "");
    }

    /// <summary>
    /// If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`.
    /// </summary>
    public static void SetTicks(this Metapsi.Html.AttributesBuilder<IonRange> b, bool ticks) 
    {
        if (ticks) b.SetAttribute("ticks", "");
    }

    /// <summary>
    /// If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`.
    /// </summary>
    public static void SetTicks(this Metapsi.Html.AttributesBuilder<IonRange> b) 
    {
        b.SetAttribute("ticks", "");
    }

    /// <summary>
    /// the value of the range.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<IonRange> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRange(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRange>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-range", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRange(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-range", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRange(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRange>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-range", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRange(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-range", children);
    }

    /// <summary>
    /// The start position of the range active bar. This feature is only available with a single knob (dualKnobs="false"). Valid values are greater than or equal to the min value and less than or equal to the max value.
    /// </summary>
    public static void SetActiveBarStart<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> activeBarStart) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("activeBarStart"), activeBarStart);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// How long, in milliseconds, to wait to trigger the `ionInput` event after each change in the range value.
    /// </summary>
    public static void SetDebounce<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> debounce) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("debounce"), debounce);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the range.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the range.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the range.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonRange
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Show two knobs.
    /// </summary>
    public static void SetDualKnobs<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetDualKnobs(b.Const(true));
    }

    /// <summary>
    /// Show two knobs.
    /// </summary>
    public static void SetDualKnobs<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> dualKnobs) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("dualKnobs"), dualKnobs);
    }

    /// <summary>
    /// Show two knobs.
    /// </summary>
    public static void SetDualKnobs<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool dualKnobs) where T: IonRange
    {
        b.SetDualKnobs(b.Const(dualKnobs));
    }

    /// <summary>
    /// The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: IonRange
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("end"));
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("fixed"));
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("stacked"));
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// Maximum integer value of the range.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> max) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// Minimum integer value of the range.
    /// </summary>
    public static void SetMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> min) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("min"), min);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: IonRange
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// If `true`, a pin with integer value is shown when the knob is pressed.
    /// </summary>
    public static void SetPin<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetPin(b.Const(true));
    }

    /// <summary>
    /// If `true`, a pin with integer value is shown when the knob is pressed.
    /// </summary>
    public static void SetPin<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> pin) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("pin"), pin);
    }

    /// <summary>
    /// If `true`, a pin with integer value is shown when the knob is pressed.
    /// </summary>
    public static void SetPin<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool pin) where T: IonRange
    {
        b.SetPin(b.Const(pin));
    }

    /// <summary>
    /// A callback used to format the pin text. By default the pin text is set to `Math.round(value)`.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetPinFormatter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<decimal, int>> pinFormatter) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("pinFormatter"), pinFormatter);
    }

    /// <summary>
    /// A callback used to format the pin text. By default the pin text is set to `Math.round(value)`.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetPinFormatter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<decimal, string>> pinFormatter) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("pinFormatter"), pinFormatter);
    }

    /// <summary>
    /// If `true`, the knob snaps to tick marks evenly spaced based on the step property value.
    /// </summary>
    public static void SetSnaps<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetSnaps(b.Const(true));
    }

    /// <summary>
    /// If `true`, the knob snaps to tick marks evenly spaced based on the step property value.
    /// </summary>
    public static void SetSnaps<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> snaps) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("snaps"), snaps);
    }

    /// <summary>
    /// If `true`, the knob snaps to tick marks evenly spaced based on the step property value.
    /// </summary>
    public static void SetSnaps<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool snaps) where T: IonRange
    {
        b.SetSnaps(b.Const(snaps));
    }

    /// <summary>
    /// Specifies the value granularity.
    /// </summary>
    public static void SetStep<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> step) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("step"), step);
    }

    /// <summary>
    /// If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`.
    /// </summary>
    public static void SetTicks<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRange
    {
        b.SetTicks(b.Const(true));
    }

    /// <summary>
    /// If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`.
    /// </summary>
    public static void SetTicks<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> ticks) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("ticks"), ticks);
    }

    /// <summary>
    /// If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`.
    /// </summary>
    public static void SetTicks<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool ticks) where T: IonRange
    {
        b.SetTicks(b.Const(ticks));
    }

    /// <summary>
    /// the value of the range.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> value) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// the value of the range.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> value) where T: IonRange
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// Emitted when the range loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the range loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the range loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the range loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired for `&lt;ion-range&gt;` elements when the user modifies the element's value: - When the user releases the knob after dragging; - When the user moves the knob with keyboard arrows  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// The `ionChange` event is fired for `&lt;ion-range&gt;` elements when the user modifies the element's value: - When the user releases the knob after dragging; - When the user moves the knob with keyboard arrows  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired for `&lt;ion-range&gt;` elements when the user modifies the element's value: - When the user releases the knob after dragging; - When the user moves the knob with keyboard arrows  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// The `ionChange` event is fired for `&lt;ion-range&gt;` elements when the user modifies the element's value: - When the user releases the knob after dragging; - When the user moves the knob with keyboard arrows  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired for `&lt;ion-range&gt;` elements when the user modifies the element's value: - When the user releases the knob after dragging; - When the user moves the knob with keyboard arrows  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<RangeChangeEventDetail>>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the range has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the range has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the range has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the range has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionInput` event is fired for `&lt;ion-range&gt;` elements when the value is modified. Unlike `ionChange`, `ionInput` is fired continuously while the user is dragging the knob.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

    /// <summary>
    /// The `ionInput` event is fired for `&lt;ion-range&gt;` elements when the value is modified. Unlike `ionChange`, `ionInput` is fired continuously while the user is dragging the knob.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonInput(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionInput` event is fired for `&lt;ion-range&gt;` elements when the value is modified. Unlike `ionChange`, `ionInput` is fired continuously while the user is dragging the knob.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

    /// <summary>
    /// The `ionInput` event is fired for `&lt;ion-range&gt;` elements when the value is modified. Unlike `ionChange`, `ionInput` is fired continuously while the user is dragging the knob.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonInput(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionInput` event is fired for `&lt;ion-range&gt;` elements when the value is modified. Unlike `ionChange`, `ionInput` is fired continuously while the user is dragging the knob.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<RangeChangeEventDetail>>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

    /// <summary>
    /// Emitted when the user finishes moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveEnd<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionKnobMoveEnd", action);
    }

    /// <summary>
    /// Emitted when the user finishes moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveEnd<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonKnobMoveEnd(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user finishes moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveEnd<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionKnobMoveEnd", action);
    }

    /// <summary>
    /// Emitted when the user finishes moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveEnd<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonKnobMoveEnd(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user finishes moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveEnd<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<RangeKnobMoveEndEventDetail>>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionKnobMoveEnd", action);
    }

    /// <summary>
    /// Emitted when the user starts moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionKnobMoveStart", action);
    }

    /// <summary>
    /// Emitted when the user starts moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonKnobMoveStart(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user starts moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionKnobMoveStart", action);
    }

    /// <summary>
    /// Emitted when the user starts moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonRange
    {
        b.OnIonKnobMoveStart(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user starts moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<RangeKnobMoveStartEventDetail>>> action) where T: IonRange
    {
        b.SetProperty(b.Props, "onionKnobMoveStart", action);
    }

}