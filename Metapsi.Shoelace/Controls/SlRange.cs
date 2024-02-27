using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlRange
{
    public int value { get; set; }
}
public partial class SlRangeBlurArgs
{
    public IClientSideSlRange target { get; set; }
}
public partial class SlRangeChangeArgs
{
    public IClientSideSlRange target { get; set; }
}
public partial class SlRangeFocusArgs
{
    public IClientSideSlRange target { get; set; }
}
public partial class SlRangeInputArgs
{
    public IClientSideSlRange target { get; set; }
}
public partial class SlRangeInvalidArgs
{
    public IClientSideSlRange target { get; set; }
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
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel, SlRangeBlurArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRangeBlurArgs>>("onsl-blur"), action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRangeBlurArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRangeBlurArgs>>("onsl-blur"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel, SlRangeChangeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRangeChangeArgs>>("onsl-change"), action);
    }
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRangeChangeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRangeChangeArgs>>("onsl-change"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel, SlRangeFocusArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRangeFocusArgs>>("onsl-focus"), action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRangeFocusArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRangeFocusArgs>>("onsl-focus"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel, SlRangeInputArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRangeInputArgs>>("onsl-input"), action);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRangeInputArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRangeInputArgs>>("onsl-input"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRange> b, Var<HyperType.Action<TModel, SlRangeInvalidArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRangeInvalidArgs>>("onsl-invalid"), action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRange> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRangeInvalidArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRangeInvalidArgs>>("onsl-invalid"), b.MakeAction(action));
    }
}

/// <summary>
/// Ranges allow the user to select a single value within a given range using a slider.
/// </summary>
public partial class SlRange : HtmlTag
{
    public SlRange()
    {
        this.Tag = "sl-range";
    }

    public static SlRange New()
    {
        return new SlRange();
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
}

public static partial class SlRangeControl
{
    /// <summary>
    /// The name of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static SlRange SetName(this SlRange tag, string value)
    {
        return tag.SetAttribute("name", value.ToString());
    }
    /// <summary>
    /// The current value of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static SlRange SetValue(this SlRange tag, int value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// The range's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static SlRange SetLabel(this SlRange tag, string value)
    {
        return tag.SetAttribute("label", value.ToString());
    }
    /// <summary>
    /// The range's help text. If you need to display HTML, use the help-text slot instead.
    /// </summary>
    public static SlRange SetHelpText(this SlRange tag, string value)
    {
        return tag.SetAttribute("helpText", value.ToString());
    }
    /// <summary>
    /// Disables the range.
    /// </summary>
    public static SlRange SetDisabled(this SlRange tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// The minimum acceptable value of the range.
    /// </summary>
    public static SlRange SetMin(this SlRange tag, int value)
    {
        return tag.SetAttribute("min", value.ToString());
    }
    /// <summary>
    /// The maximum acceptable value of the range.
    /// </summary>
    public static SlRange SetMax(this SlRange tag, int value)
    {
        return tag.SetAttribute("max", value.ToString());
    }
    /// <summary>
    /// The interval at which the range will increase and decrease.
    /// </summary>
    public static SlRange SetStep(this SlRange tag, int value)
    {
        return tag.SetAttribute("step", value.ToString());
    }
    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static SlRange SetTooltipTop(this SlRange tag)
    {
        return tag.SetAttribute("tooltip", "top");
    }
    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static SlRange SetTooltipBottom(this SlRange tag)
    {
        return tag.SetAttribute("tooltip", "bottom");
    }
    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static SlRange SetTooltipNone(this SlRange tag)
    {
        return tag.SetAttribute("tooltip", "none");
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static SlRange SetForm(this SlRange tag, string value)
    {
        return tag.SetAttribute("form", value.ToString());
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static SlRange SetDefaultValue(this SlRange tag, int value)
    {
        return tag.SetAttribute("defaultValue", value.ToString());
    }
}

