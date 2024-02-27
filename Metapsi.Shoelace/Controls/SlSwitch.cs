using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlSwitch
{
    public string value { get; set; }
}
public partial class SlSwitchBlurArgs
{
    public IClientSideSlSwitch target { get; set; }
}
public partial class SlSwitchChangeArgs
{
    public IClientSideSlSwitch target { get; set; }
}
public partial class SlSwitchInputArgs
{
    public IClientSideSlSwitch target { get; set; }
}
public partial class SlSwitchFocusArgs
{
    public IClientSideSlSwitch target { get; set; }
}
public partial class SlSwitchInvalidArgs
{
    public IClientSideSlSwitch target { get; set; }
}
public static partial class SlSwitchControl
{
    /// <summary>
    /// Switches allow the user to toggle an option on or off.
    /// </summary>
    public static Var<IVNode> SlSwitch(this LayoutBuilder b, Action<PropsBuilder<SlSwitch>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-switch", buildProps, children);
    }
    /// <summary>
    /// Switches allow the user to toggle an option on or off.
    /// </summary>
    public static Var<IVNode> SlSwitch(this LayoutBuilder b, Action<PropsBuilder<SlSwitch>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-switch", buildProps, children);
    }
    /// <summary>
    /// The name of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlSwitch> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlSwitch> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }
    /// <summary>
    /// The current value of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlSwitch> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The current value of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlSwitch> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }
    /// <summary>
    /// The switch's size.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlSwitch> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// The switch's size.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlSwitch> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// The switch's size.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlSwitch> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }
    /// <summary>
    /// Disables the switch.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlSwitch> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// Draws the switch in a checked state.
    /// </summary>
    public static void SetChecked(this PropsBuilder<SlSwitch> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("checked"), b.Const(true));
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultChecked(this PropsBuilder<SlSwitch> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("defaultChecked"), b.Const(true));
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlSwitch> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlSwitch> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }
    /// <summary>
    /// Makes the switch a required field.
    /// </summary>
    public static void SetRequired(this PropsBuilder<SlSwitch> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("required"), b.Const(true));
    }
    /// <summary>
    /// The switch's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlSwitch> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), value);
    }
    /// <summary>
    /// The switch's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlSwitch> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), b.Const(value));
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlSwitch> b, Var<HyperType.Action<TModel, SlSwitchBlurArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSwitchBlurArgs>>("onsl-blur"), action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlSwitch> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSwitchBlurArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSwitchBlurArgs>>("onsl-blur"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control's checked state changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlSwitch> b, Var<HyperType.Action<TModel, SlSwitchChangeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSwitchChangeArgs>>("onsl-change"), action);
    }
    /// <summary>
    /// Emitted when the control's checked state changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlSwitch> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSwitchChangeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSwitchChangeArgs>>("onsl-change"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlSwitch> b, Var<HyperType.Action<TModel, SlSwitchInputArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSwitchInputArgs>>("onsl-input"), action);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlSwitch> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSwitchInputArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSwitchInputArgs>>("onsl-input"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlSwitch> b, Var<HyperType.Action<TModel, SlSwitchFocusArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSwitchFocusArgs>>("onsl-focus"), action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlSwitch> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSwitchFocusArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSwitchFocusArgs>>("onsl-focus"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlSwitch> b, Var<HyperType.Action<TModel, SlSwitchInvalidArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSwitchInvalidArgs>>("onsl-invalid"), action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlSwitch> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSwitchInvalidArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSwitchInvalidArgs>>("onsl-invalid"), b.MakeAction(action));
    }
}

/// <summary>
/// Switches allow the user to toggle an option on or off.
/// </summary>
public partial class SlSwitch : HtmlTag
{
    public SlSwitch()
    {
        this.Tag = "sl-switch";
    }

    public static SlSwitch New()
    {
        return new SlSwitch();
    }
    public static class Slot
    {
        /// <summary> 
        /// Text that describes how to use the switch. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
}

public static partial class SlSwitchControl
{
    /// <summary>
    /// The name of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static SlSwitch SetName(this SlSwitch tag, string value)
    {
        return tag.SetAttribute("name", value.ToString());
    }
    /// <summary>
    /// The current value of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static SlSwitch SetValue(this SlSwitch tag, string value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// The switch's size.
    /// </summary>
    public static SlSwitch SetSizeSmall(this SlSwitch tag)
    {
        return tag.SetAttribute("size", "small");
    }
    /// <summary>
    /// The switch's size.
    /// </summary>
    public static SlSwitch SetSizeMedium(this SlSwitch tag)
    {
        return tag.SetAttribute("size", "medium");
    }
    /// <summary>
    /// The switch's size.
    /// </summary>
    public static SlSwitch SetSizeLarge(this SlSwitch tag)
    {
        return tag.SetAttribute("size", "large");
    }
    /// <summary>
    /// Disables the switch.
    /// </summary>
    public static SlSwitch SetDisabled(this SlSwitch tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// Draws the switch in a checked state.
    /// </summary>
    public static SlSwitch SetChecked(this SlSwitch tag)
    {
        return tag.SetAttribute("checked", "true");
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static SlSwitch SetDefaultChecked(this SlSwitch tag)
    {
        return tag.SetAttribute("defaultChecked", "true");
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static SlSwitch SetForm(this SlSwitch tag, string value)
    {
        return tag.SetAttribute("form", value.ToString());
    }
    /// <summary>
    /// Makes the switch a required field.
    /// </summary>
    public static SlSwitch SetRequired(this SlSwitch tag)
    {
        return tag.SetAttribute("required", "true");
    }
    /// <summary>
    /// The switch's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static SlSwitch SetHelpText(this SlSwitch tag, string value)
    {
        return tag.SetAttribute("helpText", value.ToString());
    }
}

