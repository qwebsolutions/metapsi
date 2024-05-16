using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonRange : IonComponent
{
    public IonRange() : base("ion-range") { }
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
}

public static partial class IonRangeControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRange(this HtmlBuilder b, Action<AttributesBuilder<IonRange>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-range", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonRange(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-range", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The start position of the range active bar. This feature is only available with a single knob (dualKnobs="false"). Valid values are greater than or equal to the min value and less than or equal to the max value.
    /// </summary>
    public static void SetActiveBarStart(this AttributesBuilder<IonRange> b, string value)
    {
        b.SetAttribute("active-bar-start", value);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonRange> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// How long, in milliseconds, to wait to trigger the `ionInput` event after each change in the range value.
    /// </summary>
    public static void SetDebounce(this AttributesBuilder<IonRange> b, string value)
    {
        b.SetAttribute("debounce", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the range.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the range.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonRange> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Show two knobs.
    /// </summary>
    public static void SetDualKnobs(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("dual-knobs", "");
    }
    /// <summary>
    /// Show two knobs.
    /// </summary>
    public static void SetDualKnobs(this AttributesBuilder<IonRange> b, bool value)
    {
        if (value) b.SetAttribute("dual-knobs", "");
    }

    /// <summary>
    /// The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this AttributesBuilder<IonRange> b, string value)
    {
        b.SetAttribute("label", value);
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonRange> b, string value)
    {
        b.SetAttribute("label-placement", value);
    }
    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("label-placement", "end");
    }
    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }
    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }
    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// Maximum integer value of the range.
    /// </summary>
    public static void SetMax(this AttributesBuilder<IonRange> b, string value)
    {
        b.SetAttribute("max", value);
    }

    /// <summary>
    /// Minimum integer value of the range.
    /// </summary>
    public static void SetMin(this AttributesBuilder<IonRange> b, string value)
    {
        b.SetAttribute("min", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonRange> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this AttributesBuilder<IonRange> b, string value)
    {
        b.SetAttribute("name", value);
    }

    /// <summary>
    /// If `true`, a pin with integer value is shown when the knob is pressed.
    /// </summary>
    public static void SetPin(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("pin", "");
    }
    /// <summary>
    /// If `true`, a pin with integer value is shown when the knob is pressed.
    /// </summary>
    public static void SetPin(this AttributesBuilder<IonRange> b, bool value)
    {
        if (value) b.SetAttribute("pin", "");
    }

    /// <summary>
    /// If `true`, the knob snaps to tick marks evenly spaced based on the step property value.
    /// </summary>
    public static void SetSnaps(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("snaps", "");
    }
    /// <summary>
    /// If `true`, the knob snaps to tick marks evenly spaced based on the step property value.
    /// </summary>
    public static void SetSnaps(this AttributesBuilder<IonRange> b, bool value)
    {
        if (value) b.SetAttribute("snaps", "");
    }

    /// <summary>
    /// Specifies the value granularity.
    /// </summary>
    public static void SetStep(this AttributesBuilder<IonRange> b, string value)
    {
        b.SetAttribute("step", value);
    }

    /// <summary>
    /// If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`.
    /// </summary>
    public static void SetTicks(this AttributesBuilder<IonRange> b)
    {
        b.SetAttribute("ticks", "");
    }
    /// <summary>
    /// If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`.
    /// </summary>
    public static void SetTicks(this AttributesBuilder<IonRange> b, bool value)
    {
        if (value) b.SetAttribute("ticks", "");
    }

    /// <summary>
    /// the value of the range.
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
    /// The start position of the range active bar. This feature is only available with a single knob (dualKnobs="false"). Valid values are greater than or equal to the min value and less than or equal to the max value.
    /// </summary>
    public static void SetActiveBarStart<T>(this PropsBuilder<T> b, Var<int> value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("activeBarStart"), value);
    }
    /// <summary>
    /// The start position of the range active bar. This feature is only available with a single knob (dualKnobs="false"). Valid values are greater than or equal to the min value and less than or equal to the max value.
    /// </summary>
    public static void SetActiveBarStart<T>(this PropsBuilder<T> b, int value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("activeBarStart"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// How long, in milliseconds, to wait to trigger the `ionInput` event after each change in the range value.
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, Var<int> value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), value);
    }
    /// <summary>
    /// How long, in milliseconds, to wait to trigger the `ionInput` event after each change in the range value.
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, int value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the range.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Show two knobs.
    /// </summary>
    public static void SetDualKnobs<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("dualKnobs"), b.Const(true));
    }

    /// <summary>
    /// The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("end"));
    }
    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("fixed"));
    }
    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("stacked"));
    }
    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementStart<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// Maximum integer value of the range.
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<int> value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), value);
    }
    /// <summary>
    /// Maximum integer value of the range.
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, int value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), b.Const(value));
    }

    /// <summary>
    /// Minimum integer value of the range.
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, Var<int> value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), value);
    }
    /// <summary>
    /// Minimum integer value of the range.
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, int value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a pin with integer value is shown when the knob is pressed.
    /// </summary>
    public static void SetPin<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("pin"), b.Const(true));
    }

    /// <summary>
    /// A callback used to format the pin text. By default the pin text is set to `Math.round(value)`.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetPinFormatter<T>(this PropsBuilder<T> b, Var<Func<int,object>> f) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,object>>("pinFormatter"), f);
    }
    /// <summary>
    /// A callback used to format the pin text. By default the pin text is set to `Math.round(value)`.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetPinFormatter<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<int>,Var<object>> f) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,object>>("pinFormatter"), b.Def(f));
    }

    /// <summary>
    /// If `true`, the knob snaps to tick marks evenly spaced based on the step property value.
    /// </summary>
    public static void SetSnaps<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("snaps"), b.Const(true));
    }

    /// <summary>
    /// Specifies the value granularity.
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, Var<int> value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), value);
    }
    /// <summary>
    /// Specifies the value granularity.
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, int value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), b.Const(value));
    }

    /// <summary>
    /// If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`.
    /// </summary>
    public static void SetTicks<T>(this PropsBuilder<T> b) where T: IonRange
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("ticks"), b.Const(true));
    }

    /// <summary>
    /// the value of the range.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// the value of the range.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: IonRange
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }
    /// <summary>
    /// the value of the range.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> lower,Var<int> upper) where T: IonRange
    {
        var _dynamicParameter = b.NewObj<DynamicObject>();
        b.SetDynamic(_dynamicParameter, new DynamicProperty<int>("lower"), lower);
        b.SetDynamic(_dynamicParameter, new DynamicProperty<int>("upper"), upper);
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("value"), _dynamicParameter);
    }

    /// <summary>
    /// Emitted when the range loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the range loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired for `<ion-range>` elements when the user modifies the element's value: - When the user releases the knob after dragging; - When the user moves the knob with keyboard arrows  `ionChange` is not fired when the value is changed programmatically.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RangeChangeEventDetail>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// The `ionChange` event is fired for `<ion-range>` elements when the user modifies the element's value: - When the user releases the knob after dragging; - When the user moves the knob with keyboard arrows  `ionChange` is not fired when the value is changed programmatically.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeChangeEventDetail>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the range has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the range has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

    /// <summary>
    /// The `ionInput` event is fired for `<ion-range>` elements when the value is modified. Unlike `ionChange`, `ionInput` is fired continuously while the user is dragging the knob.
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RangeChangeEventDetail>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionInput", action, "detail");
    }
    /// <summary>
    /// The `ionInput` event is fired for `<ion-range>` elements when the value is modified. Unlike `ionChange`, `ionInput` is fired continuously while the user is dragging the knob.
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeChangeEventDetail>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionInput", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the user finishes moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveEnd<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RangeKnobMoveEndEventDetail>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionKnobMoveEnd", action, "detail");
    }
    /// <summary>
    /// Emitted when the user finishes moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveEnd<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeKnobMoveEndEventDetail>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionKnobMoveEnd", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the user starts moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveStart<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, RangeKnobMoveStartEventDetail>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionKnobMoveStart", action, "detail");
    }
    /// <summary>
    /// Emitted when the user starts moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveStart<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeKnobMoveStartEventDetail>, Var<TModel>> action) where TComponent: IonRange
    {
        b.OnEventAction("onionKnobMoveStart", b.MakeAction(action), "detail");
    }

}

