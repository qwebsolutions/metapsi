using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlRange : SlComponent
{
    public SlRange() : base("sl-range") { }
    /// <summary>
    /// The name of the range, submitted as a name/value pair with form data.
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
    /// The current value of the range, submitted as a name/value pair with form data.
    /// </summary>
    public int value
    {
        get
        {
            return this.GetTag().GetAttribute<int>("value");
        }
        set
        {
            this.GetTag().SetAttribute("value", value.ToString());
        }
    }

    /// <summary>
    /// The range's label. If you need to display HTML, use the `label` slot instead.
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
    /// The range's help text. If you need to display HTML, use the help-text slot instead.
    /// </summary>
    public string helpText
    {
        get
        {
            return this.GetTag().GetAttribute<string>("helpText");
        }
        set
        {
            this.GetTag().SetAttribute("helpText", value.ToString());
        }
    }

    /// <summary>
    /// Disables the range.
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
    /// The minimum acceptable value of the range.
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
    /// The maximum acceptable value of the range.
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
    /// The interval at which the range will increase and decrease.
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
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public string tooltip
    {
        get
        {
            return this.GetTag().GetAttribute<string>("tooltip");
        }
        set
        {
            this.GetTag().SetAttribute("tooltip", value.ToString());
        }
    }

    /// <summary>
    /// A function used to format the tooltip's value. The range's value is passed as the first and only argument. The function should return a string to display in the tooltip.
    /// </summary>
    public System.Func<int,string> tooltipFormatter
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<int,string>>("tooltipFormatter");
        }
        set
        {
            this.GetTag().SetAttribute("tooltipFormatter", value.ToString());
        }
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public string form
    {
        get
        {
            return this.GetTag().GetAttribute<string>("form");
        }
        set
        {
            this.GetTag().SetAttribute("form", value.ToString());
        }
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public int defaultValue
    {
        get
        {
            return this.GetTag().GetAttribute<int>("defaultValue");
        }
        set
        {
            this.GetTag().SetAttribute("defaultValue", value.ToString());
        }
    }

    public static class Slot
    {
        /// <summary> 
        /// The range's label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
        /// <summary> 
        /// Text that describes how to use the input. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
    public static class Method
    {
        /// <summary> 
        /// Sets focus on the range.
        /// </summary>
        public const string Focus = "focus";
        /// <summary> 
        /// Removes focus from the range.
        /// </summary>
        public const string Blur = "blur";
        /// <summary> 
        /// Increments the value of the range by the value of the step attribute.
        /// </summary>
        public const string StepUp = "stepUp";
        /// <summary> 
        /// Decrements the value of the range by the value of the step attribute.
        /// </summary>
        public const string StepDown = "stepDown";
        /// <summary> 
        /// Checks for validity but does not show a validation message. Returns `true` when valid and `false` when invalid.
        /// </summary>
        public const string CheckValidity = "checkValidity";
        /// <summary> 
        /// Gets the associated form, if one exists.
        /// </summary>
        public const string GetForm = "getForm";
        /// <summary> 
        /// Checks for validity and shows the browser's validation message if the control is invalid.
        /// </summary>
        public const string ReportValidity = "reportValidity";
        /// <summary> 
        /// Sets a custom validation message. Pass an empty string to restore validity.
        /// </summary>
        public const string SetCustomValidity = "setCustomValidity";
    }
}

public static partial class SlRangeControl
{
    /// <summary>
    /// Ranges allow the user to select a single value within a given range using a slider.
    /// </summary>
    public static Var<IVNode> SlRange(this LayoutBuilder b, Action<PropsBuilder<SlRange>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-range", buildProps, children);
    }
    /// <summary>
    /// Ranges allow the user to select a single value within a given range using a slider.
    /// </summary>
    public static Var<IVNode> SlRange(this LayoutBuilder b, Action<PropsBuilder<SlRange>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-range", buildProps, children);
    }
    /// <summary>
    /// The name of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlRange> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlRange> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// The current value of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRange> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The current value of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRange> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }

    /// <summary>
    /// The range's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlRange> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The range's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlRange> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// The range's help text. If you need to display HTML, use the help-text slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlRange> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), value);
    }
    /// <summary>
    /// The range's help text. If you need to display HTML, use the help-text slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlRange> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), b.Const(value));
    }

    /// <summary>
    /// Disables the range.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// The minimum acceptable value of the range.
    /// </summary>
    public static void SetMin(this PropsBuilder<SlRange> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), value);
    }
    /// <summary>
    /// The minimum acceptable value of the range.
    /// </summary>
    public static void SetMin(this PropsBuilder<SlRange> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), b.Const(value));
    }

    /// <summary>
    /// The maximum acceptable value of the range.
    /// </summary>
    public static void SetMax(this PropsBuilder<SlRange> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), value);
    }
    /// <summary>
    /// The maximum acceptable value of the range.
    /// </summary>
    public static void SetMax(this PropsBuilder<SlRange> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), b.Const(value));
    }

    /// <summary>
    /// The interval at which the range will increase and decrease.
    /// </summary>
    public static void SetStep(this PropsBuilder<SlRange> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), value);
    }
    /// <summary>
    /// The interval at which the range will increase and decrease.
    /// </summary>
    public static void SetStep(this PropsBuilder<SlRange> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), b.Const(value));
    }

    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static void SetTooltipTop(this PropsBuilder<SlRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("tooltip"), b.Const("top"));
    }
    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static void SetTooltipBottom(this PropsBuilder<SlRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("tooltip"), b.Const("bottom"));
    }
    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static void SetTooltipNone(this PropsBuilder<SlRange> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("tooltip"), b.Const("none"));
    }

    /// <summary>
    /// A function used to format the tooltip's value. The range's value is passed as the first and only argument. The function should return a string to display in the tooltip.
    /// </summary>
    public static void SetTooltipFormatter(this PropsBuilder<SlRange> b, Var<Func<int,string>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,string>>("tooltipFormatter"), f);
    }
    /// <summary>
    /// A function used to format the tooltip's value. The range's value is passed as the first and only argument. The function should return a string to display in the tooltip.
    /// </summary>
    public static void SetTooltipFormatter(this PropsBuilder<SlRange> b, Func<SyntaxBuilder,Var<int>,Var<string>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,string>>("tooltipFormatter"), b.Def(f));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlRange> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlRange> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue(this PropsBuilder<SlRange> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("defaultValue"), value);
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue(this PropsBuilder<SlRange> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("defaultValue"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

