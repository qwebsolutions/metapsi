using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonRange
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Content is placed to the right of the range slider in LTR, and to the left in RTL. </para>
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// <para> The label text to associate with the range. Use the "labelPlacement" property to control where the label is placed relative to the range. </para>
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// <para> Content is placed to the left of the range slider in LTR, and to the right in RTL. </para>
        /// </summary>
        public const string Start = "start";
    }
}

public static partial class IonRangeControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRange(this HtmlBuilder b, Action<AttributesBuilder<IonRange>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-range", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRange(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-range", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRange(this HtmlBuilder b, Action<AttributesBuilder<IonRange>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-range", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRange(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-range", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The start position of the range active bar. This feature is only available with a single knob (dualKnobs="false"). Valid values are greater than or equal to the min value and less than or equal to the max value. </para>
    /// </summary>
    public static void SetActiveBarStart(this AttributesBuilder<IonRange> b, string activeBarStart)
    {
        b.SetAttribute("active-bar-start", activeBarStart);
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonRange> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> How long, in milliseconds, to wait to trigger the `ionInput` event after each change in the range value. </para>
    /// </summary>
    public static void SetDebounce(this AttributesBuilder<IonRange> b, string debounce)
    {
        b.SetAttribute("debounce", debounce);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the range. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the range. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRange> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Show two knobs. </para>
    /// </summary>
    public static void SetDualKnobs(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("dual-knobs", "");
    }

    /// <summary>
    /// <para> Show two knobs. </para>
    /// </summary>
    public static void SetDualKnobs(this AttributesBuilder<IonRange> b, bool dualKnobs)
    {
        if (dualKnobs) b.SetAttribute("dual-knobs", "");
    }

    /// <summary>
    /// <para> The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<IonRange> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction. </para>
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonRange> b, string labelPlacement)
    {
        b.SetAttribute("label-placement", labelPlacement);
    }

    /// <summary>
    /// <para> Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction. </para>
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("label-placement", "end");
    }

    /// <summary>
    /// <para> Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction. </para>
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }

    /// <summary>
    /// <para> Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction. </para>
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }

    /// <summary>
    /// <para> Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction. </para>
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// <para> Maximum integer value of the range. </para>
    /// </summary>
    public static void SetMax(this AttributesBuilder<IonRange> b, string max)
    {
        b.SetAttribute("max", max);
    }

    /// <summary>
    /// <para> Minimum integer value of the range. </para>
    /// </summary>
    public static void SetMin(this AttributesBuilder<IonRange> b, string min)
    {
        b.SetAttribute("min", min);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonRange> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<IonRange> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> If `true`, a pin with integer value is shown when the knob is pressed. </para>
    /// </summary>
    public static void SetPin(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("pin", "");
    }

    /// <summary>
    /// <para> If `true`, a pin with integer value is shown when the knob is pressed. </para>
    /// </summary>
    public static void SetPin(this AttributesBuilder<IonRange> b, bool pin)
    {
        if (pin) b.SetAttribute("pin", "");
    }

    /// <summary>
    /// <para> If `true`, the knob snaps to tick marks evenly spaced based on the step property value. </para>
    /// </summary>
    public static void SetSnaps(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("snaps", "");
    }

    /// <summary>
    /// <para> If `true`, the knob snaps to tick marks evenly spaced based on the step property value. </para>
    /// </summary>
    public static void SetSnaps(this AttributesBuilder<IonRange> b, bool snaps)
    {
        if (snaps) b.SetAttribute("snaps", "");
    }

    /// <summary>
    /// <para> Specifies the value granularity. </para>
    /// </summary>
    public static void SetStep(this AttributesBuilder<IonRange> b, string step)
    {
        b.SetAttribute("step", step);
    }

    /// <summary>
    /// <para> If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`. </para>
    /// </summary>
    public static void SetTicks(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("ticks", "");
    }

    /// <summary>
    /// <para> If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`. </para>
    /// </summary>
    public static void SetTicks(this AttributesBuilder<IonRange> b, bool ticks)
    {
        if (ticks) b.SetAttribute("ticks", "");
    }

    /// <summary>
    /// <para> the value of the range. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonRange> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRange(this LayoutBuilder b, Action<PropsBuilder<IonRange>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-range", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRange(this LayoutBuilder b, Action<PropsBuilder<IonRange>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-range", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRange(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-range", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRange(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-range", children);
    }
    /// <summary>
    /// <para> The start position of the range active bar. This feature is only available with a single knob (dualKnobs="false"). Valid values are greater than or equal to the min value and less than or equal to the max value. </para>
    /// </summary>
    public static void SetActiveBarStart<T>(this PropsBuilder<T> b, Var<int> activeBarStart) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("activeBarStart"), activeBarStart);
    }

    /// <summary>
    /// <para> The start position of the range active bar. This feature is only available with a single knob (dualKnobs="false"). Valid values are greater than or equal to the min value and less than or equal to the max value. </para>
    /// </summary>
    public static void SetActiveBarStart<T>(this PropsBuilder<T> b, int activeBarStart) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("activeBarStart"), b.Const(activeBarStart));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> How long, in milliseconds, to wait to trigger the `ionInput` event after each change in the range value. </para>
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, Var<int> debounce) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), debounce);
    }

    /// <summary>
    /// <para> How long, in milliseconds, to wait to trigger the `ionInput` event after each change in the range value. </para>
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, int debounce) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), b.Const(debounce));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the range. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the range. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the range. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Show two knobs. </para>
    /// </summary>
    public static void SetDualKnobs<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("dualKnobs"), b.Const(true));
    }


    /// <summary>
    /// <para> Show two knobs. </para>
    /// </summary>
    public static void SetDualKnobs<T>(this PropsBuilder<T> b, Var<bool> dualKnobs) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("dualKnobs"), dualKnobs);
    }

    /// <summary>
    /// <para> Show two knobs. </para>
    /// </summary>
    public static void SetDualKnobs<T>(this PropsBuilder<T> b, bool dualKnobs) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("dualKnobs"), b.Const(dualKnobs));
    }


    /// <summary>
    /// <para> The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction. </para>
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("end"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction. </para>
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("fixed"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction. </para>
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("stacked"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction. </para>
    /// </summary>
    public static void SetLabelPlacementStart<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("start"));
    }


    /// <summary>
    /// <para> Maximum integer value of the range. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<int> max) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), max);
    }

    /// <summary>
    /// <para> Maximum integer value of the range. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, int max) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), b.Const(max));
    }


    /// <summary>
    /// <para> Minimum integer value of the range. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, Var<int> min) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), min);
    }

    /// <summary>
    /// <para> Minimum integer value of the range. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, int min) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), b.Const(min));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> If `true`, a pin with integer value is shown when the knob is pressed. </para>
    /// </summary>
    public static void SetPin<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pin"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a pin with integer value is shown when the knob is pressed. </para>
    /// </summary>
    public static void SetPin<T>(this PropsBuilder<T> b, Var<bool> pin) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pin"), pin);
    }

    /// <summary>
    /// <para> If `true`, a pin with integer value is shown when the knob is pressed. </para>
    /// </summary>
    public static void SetPin<T>(this PropsBuilder<T> b, bool pin) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pin"), b.Const(pin));
    }


    /// <summary>
    /// <para> A callback used to format the pin text. By default the pin text is set to `Math.round(value)`.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetPinFormatter<T>(this PropsBuilder<T> b, Var<System.Func<int,DynamicObject>> pinFormatter) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<int,DynamicObject>>("pinFormatter"), pinFormatter);
    }

    /// <summary>
    /// <para> A callback used to format the pin text. By default the pin text is set to `Math.round(value)`.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetPinFormatter<T>(this PropsBuilder<T> b, System.Func<int,DynamicObject> pinFormatter) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<int,DynamicObject>>("pinFormatter"), b.Const(pinFormatter));
    }


    /// <summary>
    /// <para> If `true`, the knob snaps to tick marks evenly spaced based on the step property value. </para>
    /// </summary>
    public static void SetSnaps<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("snaps"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the knob snaps to tick marks evenly spaced based on the step property value. </para>
    /// </summary>
    public static void SetSnaps<T>(this PropsBuilder<T> b, Var<bool> snaps) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("snaps"), snaps);
    }

    /// <summary>
    /// <para> If `true`, the knob snaps to tick marks evenly spaced based on the step property value. </para>
    /// </summary>
    public static void SetSnaps<T>(this PropsBuilder<T> b, bool snaps) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("snaps"), b.Const(snaps));
    }


    /// <summary>
    /// <para> Specifies the value granularity. </para>
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, Var<int> step) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), step);
    }

    /// <summary>
    /// <para> Specifies the value granularity. </para>
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, int step) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), b.Const(step));
    }


    /// <summary>
    /// <para> If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`. </para>
    /// </summary>
    public static void SetTicks<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("ticks"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`. </para>
    /// </summary>
    public static void SetTicks<T>(this PropsBuilder<T> b, Var<bool> ticks) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("ticks"), ticks);
    }

    /// <summary>
    /// <para> If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`. </para>
    /// </summary>
    public static void SetTicks<T>(this PropsBuilder<T> b, bool ticks) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("ticks"), b.Const(ticks));
    }


    /// <summary>
    /// <para> the value of the range. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }

    /// <summary>
    /// <para> the value of the range. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> the value of the range. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<IonRangeValue> value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<IonRangeValue>("value"), value);
    }

    /// <summary>
    /// <para> the value of the range. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, IonRangeValue value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<IonRangeValue>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Emitted when the range loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// <para> Emitted when the range loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> The `ionChange` event is fired for `<ion-range>` elements when the user modifies the element's value: - When the user releases the knob after dragging; - When the user moves the knob with keyboard arrows  This event will not emit when programmatically setting the `value` property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RangeChangeEventDetail>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> The `ionChange` event is fired for `<ion-range>` elements when the user modifies the element's value: - When the user releases the knob after dragging; - When the user moves the knob with keyboard arrows  This event will not emit when programmatically setting the `value` property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeChangeEventDetail>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the range has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// <para> Emitted when the range has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> The `ionInput` event is fired for `<ion-range>` elements when the value is modified. Unlike `ionChange`, `ionInput` is fired continuously while the user is dragging the knob. </para>
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RangeChangeEventDetail>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionInput", action, "detail");
    }
    /// <summary>
    /// <para> The `ionInput` event is fired for `<ion-range>` elements when the value is modified. Unlike `ionChange`, `ionInput` is fired continuously while the user is dragging the knob. </para>
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeChangeEventDetail>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionInput", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the user finishes moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction. </para>
    /// </summary>
    public static void OnIonKnobMoveEnd<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RangeKnobMoveEndEventDetail>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionKnobMoveEnd", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the user finishes moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction. </para>
    /// </summary>
    public static void OnIonKnobMoveEnd<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeKnobMoveEndEventDetail>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionKnobMoveEnd", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the user starts moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction. </para>
    /// </summary>
    public static void OnIonKnobMoveStart<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RangeKnobMoveStartEventDetail>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionKnobMoveStart", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the user starts moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction. </para>
    /// </summary>
    public static void OnIonKnobMoveStart<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeKnobMoveStartEventDetail>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionKnobMoveStart", b.MakeAction(action), "detail");
    }

public class IonRangeValue { }
    /// <summary>
    ///
    /// </summary>
    public static void SetLower<T>(this PropsBuilder<T> b, Var<int> lower) where T: IonRangeValue
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("lower"), lower);
    }

    /// <summary>
    ///
    /// </summary>
    public static void SetUpper<T>(this PropsBuilder<T> b, Var<int> upper) where T: IonRangeValue
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("upper"), upper);
    }

}

