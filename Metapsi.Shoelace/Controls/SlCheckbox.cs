using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlCheckbox
{
    public static class Slot
    {
        /// <summary> 
        /// Text that describes how to use the checkbox. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
    public static class Method
    {
        /// <summary> 
        /// Simulates a click on the checkbox.
        /// </summary>
        public const string Click = "click";
        /// <summary> 
        /// Sets focus on the checkbox.
        /// </summary>
        public const string Focus = "focus";
        /// <summary> 
        /// Removes focus from the checkbox.
        /// </summary>
        public const string Blur = "blur";
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
        /// Sets a custom validation message. The value provided will be shown to the user when the form is submitted. To clear the custom validation message, call this method with an empty string.
        /// </summary>
        public const string SetCustomValidity = "setCustomValidity";
    }
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
    public static void OnSlBlur<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-blur"), eventAction);
    }
    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-blur"), eventAction);
    }

    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-change"), eventAction);
    }
    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-change"), eventAction);
    }

    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-focus"), eventAction);
    }
    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-focus"), eventAction);
    }

    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-input"), eventAction);
    }
    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-input"), eventAction);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-invalid"), eventAction);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-invalid"), eventAction);
    }

}

