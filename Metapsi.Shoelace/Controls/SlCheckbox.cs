using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlCheckbox
{
    public string value { get; set; }
}
public partial class SlCheckboxBlurArgs
{
    public IClientSideSlCheckbox target { get; set; }
}
public partial class SlCheckboxChangeArgs
{
    public IClientSideSlCheckbox target { get; set; }
}
public partial class SlCheckboxFocusArgs
{
    public IClientSideSlCheckbox target { get; set; }
}
public partial class SlCheckboxInputArgs
{
    public IClientSideSlCheckbox target { get; set; }
}
public partial class SlCheckboxInvalidArgs
{
    public IClientSideSlCheckbox target { get; set; }
}
public static partial class SlCheckboxControl
{
    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Var<IVNode> SlCheckbox(this LayoutBuilder b, Action<PropsBuilder<SlCheckbox>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-checkbox", buildProps, children);
    }
    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Var<IVNode> SlCheckbox(this LayoutBuilder b, Action<PropsBuilder<SlCheckbox>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-checkbox", buildProps, children);
    }
    /// <summary>
    /// The name of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlCheckbox> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlCheckbox> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }
    /// <summary>
    /// The current value of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlCheckbox> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The current value of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlCheckbox> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }
    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }
    /// <summary>
    /// Disables the checkbox.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// Draws the checkbox in a checked state.
    /// </summary>
    public static void SetChecked(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("checked"), b.Const(true));
    }
    /// <summary>
    /// Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states.
    /// </summary>
    public static void SetIndeterminate(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("indeterminate"), b.Const(true));
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultChecked(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("defaultChecked"), b.Const(true));
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlCheckbox> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlCheckbox> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }
    /// <summary>
    /// Makes the checkbox a required field.
    /// </summary>
    public static void SetRequired(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("required"), b.Const(true));
    }
    /// <summary>
    /// The checkbox's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlCheckbox> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), value);
    }
    /// <summary>
    /// The checkbox's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlCheckbox> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), b.Const(value));
    }
    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, SlCheckboxBlurArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlCheckboxBlurArgs>>("onsl-blur"), action);
    }
    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlCheckboxBlurArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlCheckboxBlurArgs>>("onsl-blur"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, SlCheckboxChangeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlCheckboxChangeArgs>>("onsl-change"), action);
    }
    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlCheckboxChangeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlCheckboxChangeArgs>>("onsl-change"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, SlCheckboxFocusArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlCheckboxFocusArgs>>("onsl-focus"), action);
    }
    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlCheckboxFocusArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlCheckboxFocusArgs>>("onsl-focus"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, SlCheckboxInputArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlCheckboxInputArgs>>("onsl-input"), action);
    }
    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlCheckboxInputArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlCheckboxInputArgs>>("onsl-input"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, SlCheckboxInvalidArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlCheckboxInvalidArgs>>("onsl-invalid"), action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlCheckboxInvalidArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlCheckboxInvalidArgs>>("onsl-invalid"), b.MakeAction(action));
    }
}

/// <summary>
/// Checkboxes allow the user to toggle an option on or off.
/// </summary>
public partial class SlCheckbox : HtmlTag
{
    public SlCheckbox()
    {
        this.Tag = "sl-checkbox";
    }

    public static SlCheckbox New()
    {
        return new SlCheckbox();
    }
    public static class Slot
    {
        /// <summary> 
        /// Text that describes how to use the checkbox. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
}

public static partial class SlCheckboxControl
{
    /// <summary>
    /// The name of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static SlCheckbox SetName(this SlCheckbox tag, string value)
    {
        return tag.SetAttribute("name", value.ToString());
    }
    /// <summary>
    /// The current value of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static SlCheckbox SetValue(this SlCheckbox tag, string value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static SlCheckbox SetSizeSmall(this SlCheckbox tag)
    {
        return tag.SetAttribute("size", "small");
    }
    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static SlCheckbox SetSizeMedium(this SlCheckbox tag)
    {
        return tag.SetAttribute("size", "medium");
    }
    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static SlCheckbox SetSizeLarge(this SlCheckbox tag)
    {
        return tag.SetAttribute("size", "large");
    }
    /// <summary>
    /// Disables the checkbox.
    /// </summary>
    public static SlCheckbox SetDisabled(this SlCheckbox tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// Draws the checkbox in a checked state.
    /// </summary>
    public static SlCheckbox SetChecked(this SlCheckbox tag)
    {
        return tag.SetAttribute("checked", "true");
    }
    /// <summary>
    /// Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states.
    /// </summary>
    public static SlCheckbox SetIndeterminate(this SlCheckbox tag)
    {
        return tag.SetAttribute("indeterminate", "true");
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static SlCheckbox SetDefaultChecked(this SlCheckbox tag)
    {
        return tag.SetAttribute("defaultChecked", "true");
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static SlCheckbox SetForm(this SlCheckbox tag, string value)
    {
        return tag.SetAttribute("form", value.ToString());
    }
    /// <summary>
    /// Makes the checkbox a required field.
    /// </summary>
    public static SlCheckbox SetRequired(this SlCheckbox tag)
    {
        return tag.SetAttribute("required", "true");
    }
    /// <summary>
    /// The checkbox's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static SlCheckbox SetHelpText(this SlCheckbox tag, string value)
    {
        return tag.SetAttribute("helpText", value.ToString());
    }
}

