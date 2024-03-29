using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlInput
{
    public static class Slot
    {
        /// <summary> 
        /// The input's label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
        /// <summary> 
        /// Used to prepend a presentational icon or similar element to the input.
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary> 
        /// Used to append a presentational icon or similar element to the input.
        /// </summary>
        public const string Suffix = "suffix";
        /// <summary> 
        /// An icon to use in lieu of the default clear icon.
        /// </summary>
        public const string ClearIcon = "clear-icon";
        /// <summary> 
        /// An icon to use in lieu of the default show password icon.
        /// </summary>
        public const string ShowPasswordIcon = "show-password-icon";
        /// <summary> 
        /// An icon to use in lieu of the default hide password icon.
        /// </summary>
        public const string HidePasswordIcon = "hide-password-icon";
        /// <summary> 
        /// Text that describes how to use the input. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
    public static class Method
    {
        /// <summary> 
        /// Sets focus on the input.
        /// </summary>
        public const string Focus = "focus";
        /// <summary> 
        /// Removes focus from the input.
        /// </summary>
        public const string Blur = "blur";
        /// <summary> 
        /// Selects all the text in the input.
        /// </summary>
        public const string Select = "select";
        /// <summary> 
        /// Sets the start and end positions of the text selection (0-based).
        /// </summary>
        public const string SetSelectionRange = "setSelectionRange";
        /// <summary> 
        /// Replaces a range of text with a new string.
        /// </summary>
        public const string SetRangeText = "setRangeText";
        /// <summary> 
        /// Displays the browser picker for an input element (only works if the browser supports it for the input type).
        /// </summary>
        public const string ShowPicker = "showPicker";
        /// <summary> 
        /// Increments the value of a numeric input type by the value of the step attribute.
        /// </summary>
        public const string StepUp = "stepUp";
        /// <summary> 
        /// Decrements the value of a numeric input type by the value of the step attribute.
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

public static partial class SlInputControl
{
    /// <summary>
    /// Inputs collect data from the user.
    /// </summary>
    public static Var<IVNode> SlInput(this LayoutBuilder b, Action<PropsBuilder<SlInput>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-input", buildProps, children);
    }
    /// <summary>
    /// Inputs collect data from the user.
    /// </summary>
    public static Var<IVNode> SlInput(this LayoutBuilder b, Action<PropsBuilder<SlInput>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-input", buildProps, children);
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeDate(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("date"));
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeDatetimeLocal(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("datetime-local"));
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeEmail(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("email"));
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeNumber(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("number"));
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypePassword(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("password"));
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeSearch(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("search"));
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeTel(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("tel"));
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeText(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("text"));
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeTime(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("time"));
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeUrl(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("url"));
    }

    /// <summary>
    /// The name of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// The current value of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The current value of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue(this PropsBuilder<SlInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultValue"), value);
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue(this PropsBuilder<SlInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultValue"), b.Const(value));
    }

    /// <summary>
    /// The input's size.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// The input's size.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// The input's size.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }

    /// <summary>
    /// Draws a filled input.
    /// </summary>
    public static void SetFilled(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("filled"), b.Const(true));
    }

    /// <summary>
    /// Draws a pill-style input with rounded edges.
    /// </summary>
    public static void SetPill(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("pill"), b.Const(true));
    }

    /// <summary>
    /// The input's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The input's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// The input's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), value);
    }
    /// <summary>
    /// The input's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), b.Const(value));
    }

    /// <summary>
    /// Adds a clear button when the input is not empty.
    /// </summary>
    public static void SetClearable(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("clearable"), b.Const(true));
    }

    /// <summary>
    /// Disables the input.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<SlInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), value);
    }
    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<SlInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(value));
    }

    /// <summary>
    /// Makes the input readonly.
    /// </summary>
    public static void SetReadonly(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("readonly"), b.Const(true));
    }

    /// <summary>
    /// Adds a button to toggle the password's visibility. Only applies to password types.
    /// </summary>
    public static void SetPasswordToggle(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("passwordToggle"), b.Const(true));
    }

    /// <summary>
    /// Determines whether or not the password is currently visible. Only applies to password input types.
    /// </summary>
    public static void SetPasswordVisible(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("passwordVisible"), b.Const(true));
    }

    /// <summary>
    /// Hides the browser's built-in increment/decrement spin buttons for number inputs.
    /// </summary>
    public static void SetNoSpinButtons(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("noSpinButtons"), b.Const(true));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }

    /// <summary>
    /// Makes the input a required field.
    /// </summary>
    public static void SetRequired(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("required"), b.Const(true));
    }

    /// <summary>
    /// A regular expression pattern to validate input against.
    /// </summary>
    public static void SetPattern(this PropsBuilder<SlInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pattern"), value);
    }
    /// <summary>
    /// A regular expression pattern to validate input against.
    /// </summary>
    public static void SetPattern(this PropsBuilder<SlInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pattern"), b.Const(value));
    }

    /// <summary>
    /// The minimum length of input that will be considered valid.
    /// </summary>
    public static void SetMinlength(this PropsBuilder<SlInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), value);
    }
    /// <summary>
    /// The minimum length of input that will be considered valid.
    /// </summary>
    public static void SetMinlength(this PropsBuilder<SlInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), b.Const(value));
    }

    /// <summary>
    /// The maximum length of input that will be considered valid.
    /// </summary>
    public static void SetMaxlength(this PropsBuilder<SlInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), value);
    }
    /// <summary>
    /// The maximum length of input that will be considered valid.
    /// </summary>
    public static void SetMaxlength(this PropsBuilder<SlInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), b.Const(value));
    }

    /// <summary>
    /// The input's minimum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMin(this PropsBuilder<SlInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), value);
    }
    /// <summary>
    /// The input's minimum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMin(this PropsBuilder<SlInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), b.Const(value));
    }
    /// <summary>
    /// The input's minimum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMin(this PropsBuilder<SlInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), value);
    }
    /// <summary>
    /// The input's minimum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMin(this PropsBuilder<SlInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), b.Const(value));
    }

    /// <summary>
    /// The input's maximum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMax(this PropsBuilder<SlInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), value);
    }
    /// <summary>
    /// The input's maximum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMax(this PropsBuilder<SlInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), b.Const(value));
    }
    /// <summary>
    /// The input's maximum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMax(this PropsBuilder<SlInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), value);
    }
    /// <summary>
    /// The input's maximum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMax(this PropsBuilder<SlInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), b.Const(value));
    }

    /// <summary>
    /// Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types.
    /// </summary>
    public static void SetStep(this PropsBuilder<SlInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), value);
    }
    /// <summary>
    /// Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types.
    /// </summary>
    public static void SetStep(this PropsBuilder<SlInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("step"), b.Const(value));
    }
    /// <summary>
    /// Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types.
    /// </summary>
    public static void SetStepAny(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("step"), b.Const("any"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOff(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("off"));
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeNone(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("none"));
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOn(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("on"));
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeSentences(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("sentences"));
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeWords(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("words"));
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeCharacters(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("characters"));
    }

    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static void SetAutocorrectOff(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocorrect"), b.Const("off"));
    }
    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static void SetAutocorrectOn(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocorrect"), b.Const("on"));
    }

    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static void SetAutocomplete(this PropsBuilder<SlInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), value);
    }
    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static void SetAutocomplete(this PropsBuilder<SlInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const(value));
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("autofocus"), b.Const(true));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintEnter(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("enter"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintDone(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("done"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintGo(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("go"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintNext(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("next"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("previous"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSearch(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("search"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSend(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("send"));
    }

    /// <summary>
    /// Enables spell checking on the input.
    /// </summary>
    public static void SetSpellcheck(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("spellcheck"), b.Const(true));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNone(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("none"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeText(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("text"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeDecimal(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("decimal"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNumeric(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("numeric"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeTel(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("tel"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeSearch(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("search"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeEmail(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("email"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeUrl(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// Gets or sets the current value as a `Date` object. Returns `null` if the value can't be converted. This will use the native `<input type="{{type}}">` implementation and may result in an error.
    /// </summary>
    public static void SetValueAsDate(this PropsBuilder<SlInput> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("valueAsDate"), value);
    }
    /// <summary>
    /// Gets or sets the current value as a `Date` object. Returns `null` if the value can't be converted. This will use the native `<input type="{{type}}">` implementation and may result in an error.
    /// </summary>
    public static void SetValueAsDate(this PropsBuilder<SlInput> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("valueAsDate"), b.Const(value));
    }

    /// <summary>
    /// Gets or sets the current value as a number. Returns `NaN` if the value can't be converted.
    /// </summary>
    public static void SetValueAsNumber(this PropsBuilder<SlInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("valueAsNumber"), value);
    }
    /// <summary>
    /// Gets or sets the current value as a number. Returns `NaN` if the value can't be converted.
    /// </summary>
    public static void SetValueAsNumber(this PropsBuilder<SlInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("valueAsNumber"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-blur"), eventAction);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-blur"), eventAction);
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-change"), eventAction);
    }
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-change"), eventAction);
    }

    /// <summary>
    /// Emitted when the clear button is activated.
    /// </summary>
    public static void OnSlClear<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-clear"), eventAction);
    }
    /// <summary>
    /// Emitted when the clear button is activated.
    /// </summary>
    public static void OnSlClear<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-clear"), eventAction);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-focus"), eventAction);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-focus"), eventAction);
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-input"), eventAction);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
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
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, object>> action)
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
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-invalid"), eventAction);
    }

}

