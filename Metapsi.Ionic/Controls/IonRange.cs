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
    /// <summary>
    /// The start position of the range active bar. This feature is only available with a single knob (dualKnobs="false"). Valid values are greater than or equal to the min value and less than or equal to the max value.
    /// </summary>
    public int activeBarStart
    {
        get
        {
            return this.GetTag().GetAttribute<int>("activeBarStart");
        }
        set
        {
            this.GetTag().SetAttribute("activeBarStart", value.ToString());
        }
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public string color
    {
        get
        {
            return this.GetTag().GetAttribute<string>("color");
        }
        set
        {
            this.GetTag().SetAttribute("color", value.ToString());
        }
    }

    /// <summary>
    /// How long, in milliseconds, to wait to trigger the `ionInput` event after each change in the range value.
    /// </summary>
    public int debounce
    {
        get
        {
            return this.GetTag().GetAttribute<int>("debounce");
        }
        set
        {
            this.GetTag().SetAttribute("debounce", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the user cannot interact with the range.
    /// </summary>
    public bool disabled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("disabled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("disabled", value.ToString());
        }
    }

    /// <summary>
    /// Show two knobs.
    /// </summary>
    public bool dualKnobs
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("dualKnobs");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("dualKnobs", value.ToString());
        }
    }

    /// <summary>
    /// The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public string label
    {
        get
        {
            return this.GetTag().GetAttribute<string>("label");
        }
        set
        {
            this.GetTag().SetAttribute("label", value.ToString());
        }
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public string labelPlacement
    {
        get
        {
            return this.GetTag().GetAttribute<string>("labelPlacement");
        }
        set
        {
            this.GetTag().SetAttribute("labelPlacement", value.ToString());
        }
    }

    /// <summary>
    /// Set the `legacy` property to `true` to forcibly use the legacy form control markup. Ionic will only opt components in to the modern form markup when they are using either the `aria-label` attribute or the `label` property. As a result, the `legacy` property should only be used as an escape hatch when you want to avoid this automatic opt-in behavior. Note that this property will be removed in an upcoming major release of Ionic, and all form components will be opted-in to using the modern form markup.
    /// </summary>
    public bool legacy
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("legacy");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("legacy", value.ToString());
        }
    }

    /// <summary>
    /// Maximum integer value of the range.
    /// </summary>
    public int max
    {
        get
        {
            return this.GetTag().GetAttribute<int>("max");
        }
        set
        {
            this.GetTag().SetAttribute("max", value.ToString());
        }
    }

    /// <summary>
    /// Minimum integer value of the range.
    /// </summary>
    public int min
    {
        get
        {
            return this.GetTag().GetAttribute<int>("min");
        }
        set
        {
            this.GetTag().SetAttribute("min", value.ToString());
        }
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("mode");
        }
        set
        {
            this.GetTag().SetAttribute("mode", value.ToString());
        }
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public string name
    {
        get
        {
            return this.GetTag().GetAttribute<string>("name");
        }
        set
        {
            this.GetTag().SetAttribute("name", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, a pin with integer value is shown when the knob is pressed.
    /// </summary>
    public bool pin
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("pin");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("pin", value.ToString());
        }
    }

    /// <summary>
    /// A callback used to format the pin text. By default the pin text is set to `Math.round(value)`.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public System.Func<int,object> pinFormatter
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<int,object>>("pinFormatter");
        }
        set
        {
            this.GetTag().SetAttribute("pinFormatter", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the knob snaps to tick marks evenly spaced based on the step property value.
    /// </summary>
    public bool snaps
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("snaps");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("snaps", value.ToString());
        }
    }

    /// <summary>
    /// Specifies the value granularity.
    /// </summary>
    public int step
    {
        get
        {
            return this.GetTag().GetAttribute<int>("step");
        }
        set
        {
            this.GetTag().SetAttribute("step", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`.
    /// </summary>
    public bool ticks
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("ticks");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("ticks", value.ToString());
        }
    }


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
    /// The start position of the range active bar. This feature is only available with a single knob (dualKnobs="false"). Valid values are greater than or equal to the min value and less than or equal to the max value.
    /// </summary>
    public static void SetActiveBarStart(this PropsBuilder<IonRange> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("activeBarStart"), value);
    }
    /// <summary>
    /// The start position of the range active bar. This feature is only available with a single knob (dualKnobs="false"). Valid values are greater than or equal to the min value and less than or equal to the max value.
    /// </summary>
    public static void SetActiveBarStart(this PropsBuilder<IonRange> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("activeBarStart"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonRange> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonRange> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// How long, in milliseconds, to wait to trigger the `ionInput` event after each change in the range value.
    /// </summary>
    public static void SetDebounce(this PropsBuilder<IonRange> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), value);
    }
    /// <summary>
    /// How long, in milliseconds, to wait to trigger the `ionInput` event after each change in the range value.
    /// </summary>
    public static void SetDebounce(this PropsBuilder<IonRange> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the range.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Show two knobs.
    /// </summary>
    public static void SetDualKnobs(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("dualKnobs"), b.Const(true));
    }

    /// <summary>
    /// The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this PropsBuilder<IonRange> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The text to display as the control's label. Use this over the `label` slot if you only need plain text. The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this PropsBuilder<IonRange> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementEnd(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("end"));
    }
    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementFixed(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("fixed"));
    }
    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementStacked(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("stacked"));
    }
    /// <summary>
    /// Where to place the label relative to the range. `"start"`: The label will appear to the left of the range in LTR and to the right in RTL. `"end"`: The label will appear to the right of the range in LTR and to the left in RTL. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). `"stacked"`: The label will appear above the range regardless of the direction.
    /// </summary>
    public static void SetLabelPlacementStart(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// Set the `legacy` property to `true` to forcibly use the legacy form control markup. Ionic will only opt components in to the modern form markup when they are using either the `aria-label` attribute or the `label` property. As a result, the `legacy` property should only be used as an escape hatch when you want to avoid this automatic opt-in behavior. Note that this property will be removed in an upcoming major release of Ionic, and all form components will be opted-in to using the modern form markup.
    /// </summary>
    public static void SetLegacy(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("legacy"), b.Const(true));
    }

    /// <summary>
    /// Maximum integer value of the range.
    /// </summary>
    public static void SetMax(this PropsBuilder<IonRange> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), value);
    }
    /// <summary>
    /// Maximum integer value of the range.
    /// </summary>
    public static void SetMax(this PropsBuilder<IonRange> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), b.Const(value));
    }

    /// <summary>
    /// Minimum integer value of the range.
    /// </summary>
    public static void SetMin(this PropsBuilder<IonRange> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), value);
    }
    /// <summary>
    /// Minimum integer value of the range.
    /// </summary>
    public static void SetMin(this PropsBuilder<IonRange> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonRange> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonRange> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a pin with integer value is shown when the knob is pressed.
    /// </summary>
    public static void SetPin(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("pin"), b.Const(true));
    }

    /// <summary>
    /// A callback used to format the pin text. By default the pin text is set to `Math.round(value)`.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetPinFormatter(this PropsBuilder<IonRange> b, Var<Func<int,object>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,object>>("pinFormatter"), f);
    }
    /// <summary>
    /// A callback used to format the pin text. By default the pin text is set to `Math.round(value)`.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetPinFormatter(this PropsBuilder<IonRange> b, Func<SyntaxBuilder,Var<int>,Var<object>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,object>>("pinFormatter"), b.Def(f));
    }

    /// <summary>
    /// If `true`, the knob snaps to tick marks evenly spaced based on the step property value.
    /// </summary>
    public static void SetSnaps(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("snaps"), b.Const(true));
    }

    /// <summary>
    /// Specifies the value granularity.
    /// </summary>
    public static void SetStep(this PropsBuilder<IonRange> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), value);
    }
    /// <summary>
    /// Specifies the value granularity.
    /// </summary>
    public static void SetStep(this PropsBuilder<IonRange> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), b.Const(value));
    }

    /// <summary>
    /// If `true`, tick marks are displayed based on the step value. Only applies when `snaps` is `true`.
    /// </summary>
    public static void SetTicks(this PropsBuilder<IonRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("ticks"), b.Const(true));
    }

    /// <summary>
    /// the value of the range.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonRange> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// the value of the range.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonRange> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }
    /// <summary>
    /// the value of the range.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonRange> b, Var<int> lower,Var<int> upper)
    {
        var _dynamicParameter = b.NewObj<DynamicObject>();
        b.SetDynamic(_dynamicParameter, new DynamicProperty<int>("lower"), lower);
        b.SetDynamic(_dynamicParameter, new DynamicProperty<int>("upper"), upper);
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("value"), _dynamicParameter);
    }

    /// <summary>
    /// Emitted when the range loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonRange> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the range loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired for `<ion-range>` elements when the user modifies the element's value: - When the user releases the knob after dragging; - When the user moves the knob with keyboard arrows  `ionChange` is not fired when the value is changed programmatically.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonRange> b, Var<HyperType.Action<TModel, RangeChangeEventDetail>> action)
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// The `ionChange` event is fired for `<ion-range>` elements when the user modifies the element's value: - When the user releases the knob after dragging; - When the user moves the knob with keyboard arrows  `ionChange` is not fired when the value is changed programmatically.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeChangeEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the range has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonRange> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the range has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

    /// <summary>
    /// The `ionInput` event is fired for `<ion-range>` elements when the value is modified. Unlike `ionChange`, `ionInput` is fired continuously while the user is dragging the knob.
    /// </summary>
    public static void OnIonInput<TModel>(this PropsBuilder<IonRange> b, Var<HyperType.Action<TModel, RangeChangeEventDetail>> action)
    {
        b.OnEventAction("onionInput", action, "detail");
    }
    /// <summary>
    /// The `ionInput` event is fired for `<ion-range>` elements when the value is modified. Unlike `ionChange`, `ionInput` is fired continuously while the user is dragging the knob.
    /// </summary>
    public static void OnIonInput<TModel>(this PropsBuilder<IonRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeChangeEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionInput", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the user finishes moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveEnd<TModel>(this PropsBuilder<IonRange> b, Var<HyperType.Action<TModel, RangeKnobMoveEndEventDetail>> action)
    {
        b.OnEventAction("onionKnobMoveEnd", action, "detail");
    }
    /// <summary>
    /// Emitted when the user finishes moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveEnd<TModel>(this PropsBuilder<IonRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeKnobMoveEndEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionKnobMoveEnd", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the user starts moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveStart<TModel>(this PropsBuilder<IonRange> b, Var<HyperType.Action<TModel, RangeKnobMoveStartEventDetail>> action)
    {
        b.OnEventAction("onionKnobMoveStart", action, "detail");
    }
    /// <summary>
    /// Emitted when the user starts moving the range knob, whether through mouse drag, touch gesture, or keyboard interaction.
    /// </summary>
    public static void OnIonKnobMoveStart<TModel>(this PropsBuilder<IonRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<RangeKnobMoveStartEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionKnobMoveStart", b.MakeAction(action), "detail");
    }

}

