using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlInput
{
    public string value { get; set; }
}
public partial class SlInputBlurArgs
{
    public IClientSideSlInput target { get; set; }
}
public partial class SlInputChangeArgs
{
    public IClientSideSlInput target { get; set; }
}
public partial class SlInputClearArgs
{
    public IClientSideSlInput target { get; set; }
}
public partial class SlInputFocusArgs
{
    public IClientSideSlInput target { get; set; }
}
public partial class SlInputInputArgs
{
    public IClientSideSlInput target { get; set; }
}
public partial class SlInputInvalidArgs
{
    public IClientSideSlInput target { get; set; }
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
    public static void SetTypeDatetimelocal(this PropsBuilder<SlInput> b)
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
    public static void SetMinNumber(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("min"), b.Const("number"));
    }
    /// <summary>
    /// The input's minimum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMinString(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("min"), b.Const("string"));
    }
    /// <summary>
    /// The input's maximum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMaxNumber(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("max"), b.Const("number"));
    }
    /// <summary>
    /// The input's maximum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMaxString(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("max"), b.Const("string"));
    }
    /// <summary>
    /// Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types.
    /// </summary>
    public static void SetStepNumber(this PropsBuilder<SlInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("step"), b.Const("number"));
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
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, SlInputBlurArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputBlurArgs>>("onsl-blur"), action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlInputBlurArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputBlurArgs>>("onsl-blur"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, SlInputChangeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputChangeArgs>>("onsl-change"), action);
    }
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlInputChangeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputChangeArgs>>("onsl-change"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the clear button is activated.
    /// </summary>
    public static void OnSlClear<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, SlInputClearArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputClearArgs>>("onsl-clear"), action);
    }
    /// <summary>
    /// Emitted when the clear button is activated.
    /// </summary>
    public static void OnSlClear<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlInputClearArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputClearArgs>>("onsl-clear"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, SlInputFocusArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputFocusArgs>>("onsl-focus"), action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlInputFocusArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputFocusArgs>>("onsl-focus"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, SlInputInputArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputInputArgs>>("onsl-input"), action);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlInputInputArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputInputArgs>>("onsl-input"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlInput> b, Var<HyperType.Action<TModel, SlInputInvalidArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputInvalidArgs>>("onsl-invalid"), action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlInputInvalidArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlInputInvalidArgs>>("onsl-invalid"), b.MakeAction(action));
    }
}

/// <summary>
/// Inputs collect data from the user.
/// </summary>
public partial class SlInput : HtmlTag
{
    public SlInput()
    {
        this.Tag = "sl-input";
    }

    public static SlInput New()
    {
        return new SlInput();
    }
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
}

public static partial class SlInputControl
{
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static SlInput SetTypeDate(this SlInput tag)
    {
        return tag.SetAttribute("type", "date");
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static SlInput SetTypeDatetimelocal(this SlInput tag)
    {
        return tag.SetAttribute("type", "datetime-local");
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static SlInput SetTypeEmail(this SlInput tag)
    {
        return tag.SetAttribute("type", "email");
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static SlInput SetTypeNumber(this SlInput tag)
    {
        return tag.SetAttribute("type", "number");
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static SlInput SetTypePassword(this SlInput tag)
    {
        return tag.SetAttribute("type", "password");
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static SlInput SetTypeSearch(this SlInput tag)
    {
        return tag.SetAttribute("type", "search");
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static SlInput SetTypeTel(this SlInput tag)
    {
        return tag.SetAttribute("type", "tel");
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static SlInput SetTypeText(this SlInput tag)
    {
        return tag.SetAttribute("type", "text");
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static SlInput SetTypeTime(this SlInput tag)
    {
        return tag.SetAttribute("type", "time");
    }
    /// <summary>
    /// The type of input. Works the same as a native `<input>` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static SlInput SetTypeUrl(this SlInput tag)
    {
        return tag.SetAttribute("type", "url");
    }
    /// <summary>
    /// The name of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static SlInput SetName(this SlInput tag, string value)
    {
        return tag.SetAttribute("name", value.ToString());
    }
    /// <summary>
    /// The current value of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static SlInput SetValue(this SlInput tag, string value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static SlInput SetDefaultValue(this SlInput tag, string value)
    {
        return tag.SetAttribute("defaultValue", value.ToString());
    }
    /// <summary>
    /// The input's size.
    /// </summary>
    public static SlInput SetSizeSmall(this SlInput tag)
    {
        return tag.SetAttribute("size", "small");
    }
    /// <summary>
    /// The input's size.
    /// </summary>
    public static SlInput SetSizeMedium(this SlInput tag)
    {
        return tag.SetAttribute("size", "medium");
    }
    /// <summary>
    /// The input's size.
    /// </summary>
    public static SlInput SetSizeLarge(this SlInput tag)
    {
        return tag.SetAttribute("size", "large");
    }
    /// <summary>
    /// Draws a filled input.
    /// </summary>
    public static SlInput SetFilled(this SlInput tag)
    {
        return tag.SetAttribute("filled", "true");
    }
    /// <summary>
    /// Draws a pill-style input with rounded edges.
    /// </summary>
    public static SlInput SetPill(this SlInput tag)
    {
        return tag.SetAttribute("pill", "true");
    }
    /// <summary>
    /// The input's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static SlInput SetLabel(this SlInput tag, string value)
    {
        return tag.SetAttribute("label", value.ToString());
    }
    /// <summary>
    /// The input's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static SlInput SetHelpText(this SlInput tag, string value)
    {
        return tag.SetAttribute("helpText", value.ToString());
    }
    /// <summary>
    /// Adds a clear button when the input is not empty.
    /// </summary>
    public static SlInput SetClearable(this SlInput tag)
    {
        return tag.SetAttribute("clearable", "true");
    }
    /// <summary>
    /// Disables the input.
    /// </summary>
    public static SlInput SetDisabled(this SlInput tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static SlInput SetPlaceholder(this SlInput tag, string value)
    {
        return tag.SetAttribute("placeholder", value.ToString());
    }
    /// <summary>
    /// Makes the input readonly.
    /// </summary>
    public static SlInput SetReadonly(this SlInput tag)
    {
        return tag.SetAttribute("readonly", "true");
    }
    /// <summary>
    /// Adds a button to toggle the password's visibility. Only applies to password types.
    /// </summary>
    public static SlInput SetPasswordToggle(this SlInput tag)
    {
        return tag.SetAttribute("passwordToggle", "true");
    }
    /// <summary>
    /// Determines whether or not the password is currently visible. Only applies to password input types.
    /// </summary>
    public static SlInput SetPasswordVisible(this SlInput tag)
    {
        return tag.SetAttribute("passwordVisible", "true");
    }
    /// <summary>
    /// Hides the browser's built-in increment/decrement spin buttons for number inputs.
    /// </summary>
    public static SlInput SetNoSpinButtons(this SlInput tag)
    {
        return tag.SetAttribute("noSpinButtons", "true");
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static SlInput SetForm(this SlInput tag, string value)
    {
        return tag.SetAttribute("form", value.ToString());
    }
    /// <summary>
    /// Makes the input a required field.
    /// </summary>
    public static SlInput SetRequired(this SlInput tag)
    {
        return tag.SetAttribute("required", "true");
    }
    /// <summary>
    /// A regular expression pattern to validate input against.
    /// </summary>
    public static SlInput SetPattern(this SlInput tag, string value)
    {
        return tag.SetAttribute("pattern", value.ToString());
    }
    /// <summary>
    /// The minimum length of input that will be considered valid.
    /// </summary>
    public static SlInput SetMinlength(this SlInput tag, int value)
    {
        return tag.SetAttribute("minlength", value.ToString());
    }
    /// <summary>
    /// The maximum length of input that will be considered valid.
    /// </summary>
    public static SlInput SetMaxlength(this SlInput tag, int value)
    {
        return tag.SetAttribute("maxlength", value.ToString());
    }
    /// <summary>
    /// The input's minimum value. Only applies to date and number input types.
    /// </summary>
    public static SlInput SetMinNumber(this SlInput tag)
    {
        return tag.SetAttribute("min", "number");
    }
    /// <summary>
    /// The input's minimum value. Only applies to date and number input types.
    /// </summary>
    public static SlInput SetMinString(this SlInput tag)
    {
        return tag.SetAttribute("min", "string");
    }
    /// <summary>
    /// The input's maximum value. Only applies to date and number input types.
    /// </summary>
    public static SlInput SetMaxNumber(this SlInput tag)
    {
        return tag.SetAttribute("max", "number");
    }
    /// <summary>
    /// The input's maximum value. Only applies to date and number input types.
    /// </summary>
    public static SlInput SetMaxString(this SlInput tag)
    {
        return tag.SetAttribute("max", "string");
    }
    /// <summary>
    /// Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types.
    /// </summary>
    public static SlInput SetStepNumber(this SlInput tag)
    {
        return tag.SetAttribute("step", "number");
    }
    /// <summary>
    /// Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types.
    /// </summary>
    public static SlInput SetStepAny(this SlInput tag)
    {
        return tag.SetAttribute("step", "any");
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlInput SetAutocapitalizeOff(this SlInput tag)
    {
        return tag.SetAttribute("autocapitalize", "off");
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlInput SetAutocapitalizeNone(this SlInput tag)
    {
        return tag.SetAttribute("autocapitalize", "none");
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlInput SetAutocapitalizeOn(this SlInput tag)
    {
        return tag.SetAttribute("autocapitalize", "on");
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlInput SetAutocapitalizeSentences(this SlInput tag)
    {
        return tag.SetAttribute("autocapitalize", "sentences");
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlInput SetAutocapitalizeWords(this SlInput tag)
    {
        return tag.SetAttribute("autocapitalize", "words");
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlInput SetAutocapitalizeCharacters(this SlInput tag)
    {
        return tag.SetAttribute("autocapitalize", "characters");
    }
    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static SlInput SetAutocorrectOff(this SlInput tag)
    {
        return tag.SetAttribute("autocorrect", "off");
    }
    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static SlInput SetAutocorrectOn(this SlInput tag)
    {
        return tag.SetAttribute("autocorrect", "on");
    }
    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static SlInput SetAutocomplete(this SlInput tag, string value)
    {
        return tag.SetAttribute("autocomplete", value.ToString());
    }
    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static SlInput SetAutofocus(this SlInput tag)
    {
        return tag.SetAttribute("autofocus", "true");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlInput SetEnterkeyhintEnter(this SlInput tag)
    {
        return tag.SetAttribute("enterkeyhint", "enter");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlInput SetEnterkeyhintDone(this SlInput tag)
    {
        return tag.SetAttribute("enterkeyhint", "done");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlInput SetEnterkeyhintGo(this SlInput tag)
    {
        return tag.SetAttribute("enterkeyhint", "go");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlInput SetEnterkeyhintNext(this SlInput tag)
    {
        return tag.SetAttribute("enterkeyhint", "next");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlInput SetEnterkeyhintPrevious(this SlInput tag)
    {
        return tag.SetAttribute("enterkeyhint", "previous");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlInput SetEnterkeyhintSearch(this SlInput tag)
    {
        return tag.SetAttribute("enterkeyhint", "search");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlInput SetEnterkeyhintSend(this SlInput tag)
    {
        return tag.SetAttribute("enterkeyhint", "send");
    }
    /// <summary>
    /// Enables spell checking on the input.
    /// </summary>
    public static SlInput SetSpellcheck(this SlInput tag)
    {
        return tag.SetAttribute("spellcheck", "true");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlInput SetInputmodeNone(this SlInput tag)
    {
        return tag.SetAttribute("inputmode", "none");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlInput SetInputmodeText(this SlInput tag)
    {
        return tag.SetAttribute("inputmode", "text");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlInput SetInputmodeDecimal(this SlInput tag)
    {
        return tag.SetAttribute("inputmode", "decimal");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlInput SetInputmodeNumeric(this SlInput tag)
    {
        return tag.SetAttribute("inputmode", "numeric");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlInput SetInputmodeTel(this SlInput tag)
    {
        return tag.SetAttribute("inputmode", "tel");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlInput SetInputmodeSearch(this SlInput tag)
    {
        return tag.SetAttribute("inputmode", "search");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlInput SetInputmodeEmail(this SlInput tag)
    {
        return tag.SetAttribute("inputmode", "email");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlInput SetInputmodeUrl(this SlInput tag)
    {
        return tag.SetAttribute("inputmode", "url");
    }
}

