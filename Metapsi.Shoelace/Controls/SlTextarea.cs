using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlTextarea
{
    public string value { get; set; }
}
public partial class SlTextareaBlurArgs
{
    public IClientSideSlTextarea target { get; set; }
}
public partial class SlTextareaChangeArgs
{
    public IClientSideSlTextarea target { get; set; }
}
public partial class SlTextareaFocusArgs
{
    public IClientSideSlTextarea target { get; set; }
}
public partial class SlTextareaInputArgs
{
    public IClientSideSlTextarea target { get; set; }
}
public partial class SlTextareaInvalidArgs
{
    public IClientSideSlTextarea target { get; set; }
}
public static partial class SlTextareaControl
{
    /// <summary>
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Var<IVNode> SlTextarea(this LayoutBuilder b, Action<PropsBuilder<SlTextarea>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-textarea", buildProps, children);
    }
    /// <summary>
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Var<IVNode> SlTextarea(this LayoutBuilder b, Action<PropsBuilder<SlTextarea>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-textarea", buildProps, children);
    }
    /// <summary>
    /// The name of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlTextarea> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlTextarea> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }
    /// <summary>
    /// The current value of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlTextarea> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The current value of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlTextarea> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }
    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }
    /// <summary>
    /// Draws a filled textarea.
    /// </summary>
    public static void SetFilled(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("filled"), b.Const(true));
    }
    /// <summary>
    /// The textarea's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlTextarea> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The textarea's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlTextarea> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }
    /// <summary>
    /// The textarea's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlTextarea> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), value);
    }
    /// <summary>
    /// The textarea's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlTextarea> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), b.Const(value));
    }
    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<SlTextarea> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), value);
    }
    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<SlTextarea> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(value));
    }
    /// <summary>
    /// The number of rows to display by default.
    /// </summary>
    public static void SetRows(this PropsBuilder<SlTextarea> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("rows"), value);
    }
    /// <summary>
    /// The number of rows to display by default.
    /// </summary>
    public static void SetRows(this PropsBuilder<SlTextarea> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("rows"), b.Const(value));
    }
    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static void SetResizeNone(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("resize"), b.Const("none"));
    }
    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static void SetResizeVertical(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("resize"), b.Const("vertical"));
    }
    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static void SetResizeAuto(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("resize"), b.Const("auto"));
    }
    /// <summary>
    /// Disables the textarea.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// Makes the textarea readonly.
    /// </summary>
    public static void SetReadonly(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("readonly"), b.Const(true));
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlTextarea> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlTextarea> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }
    /// <summary>
    /// Makes the textarea a required field.
    /// </summary>
    public static void SetRequired(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("required"), b.Const(true));
    }
    /// <summary>
    /// The minimum length of input that will be considered valid.
    /// </summary>
    public static void SetMinlength(this PropsBuilder<SlTextarea> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), value);
    }
    /// <summary>
    /// The minimum length of input that will be considered valid.
    /// </summary>
    public static void SetMinlength(this PropsBuilder<SlTextarea> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), b.Const(value));
    }
    /// <summary>
    /// The maximum length of input that will be considered valid.
    /// </summary>
    public static void SetMaxlength(this PropsBuilder<SlTextarea> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), value);
    }
    /// <summary>
    /// The maximum length of input that will be considered valid.
    /// </summary>
    public static void SetMaxlength(this PropsBuilder<SlTextarea> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), b.Const(value));
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOff(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("off"));
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeNone(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("none"));
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOn(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("on"));
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeSentences(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("sentences"));
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeWords(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("words"));
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeCharacters(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocapitalize"), b.Const("characters"));
    }
    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static void SetAutocorrect(this PropsBuilder<SlTextarea> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocorrect"), value);
    }
    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static void SetAutocorrect(this PropsBuilder<SlTextarea> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocorrect"), b.Const(value));
    }
    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static void SetAutocomplete(this PropsBuilder<SlTextarea> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), value);
    }
    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static void SetAutocomplete(this PropsBuilder<SlTextarea> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const(value));
    }
    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("autofocus"), b.Const(true));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintEnter(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("enter"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintDone(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("done"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintGo(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("go"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintNext(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("next"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("previous"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSearch(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("search"));
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSend(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("send"));
    }
    /// <summary>
    /// Enables spell checking on the textarea.
    /// </summary>
    public static void SetSpellcheck(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("spellcheck"), b.Const(true));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNone(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("none"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeText(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("text"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeDecimal(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("decimal"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNumeric(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("numeric"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeTel(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("tel"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeSearch(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("search"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeEmail(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("email"));
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeUrl(this PropsBuilder<SlTextarea> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("url"));
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue(this PropsBuilder<SlTextarea> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultValue"), value);
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue(this PropsBuilder<SlTextarea> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultValue"), b.Const(value));
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel, SlTextareaBlurArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTextareaBlurArgs>>("onsl-blur"), action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTextareaBlurArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTextareaBlurArgs>>("onsl-blur"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel, SlTextareaChangeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTextareaChangeArgs>>("onsl-change"), action);
    }
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTextareaChangeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTextareaChangeArgs>>("onsl-change"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel, SlTextareaFocusArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTextareaFocusArgs>>("onsl-focus"), action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTextareaFocusArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTextareaFocusArgs>>("onsl-focus"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel, SlTextareaInputArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTextareaInputArgs>>("onsl-input"), action);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTextareaInputArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTextareaInputArgs>>("onsl-input"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel, SlTextareaInvalidArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTextareaInvalidArgs>>("onsl-invalid"), action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTextareaInvalidArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTextareaInvalidArgs>>("onsl-invalid"), b.MakeAction(action));
    }
}

/// <summary>
/// Textareas collect data from the user and allow multiple lines of text.
/// </summary>
public partial class SlTextarea : HtmlTag
{
    public SlTextarea()
    {
        this.Tag = "sl-textarea";
    }

    public static SlTextarea New()
    {
        return new SlTextarea();
    }
    public static class Slot
    {
        /// <summary> 
        /// The textarea's label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
        /// <summary> 
        /// Text that describes how to use the input. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
}

public static partial class SlTextareaControl
{
    /// <summary>
    /// The name of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static SlTextarea SetName(this SlTextarea tag, string value)
    {
        return tag.SetAttribute("name", value.ToString());
    }
    /// <summary>
    /// The current value of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static SlTextarea SetValue(this SlTextarea tag, string value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static SlTextarea SetSizeSmall(this SlTextarea tag)
    {
        return tag.SetAttribute("size", "small");
    }
    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static SlTextarea SetSizeMedium(this SlTextarea tag)
    {
        return tag.SetAttribute("size", "medium");
    }
    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static SlTextarea SetSizeLarge(this SlTextarea tag)
    {
        return tag.SetAttribute("size", "large");
    }
    /// <summary>
    /// Draws a filled textarea.
    /// </summary>
    public static SlTextarea SetFilled(this SlTextarea tag)
    {
        return tag.SetAttribute("filled", "true");
    }
    /// <summary>
    /// The textarea's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static SlTextarea SetLabel(this SlTextarea tag, string value)
    {
        return tag.SetAttribute("label", value.ToString());
    }
    /// <summary>
    /// The textarea's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static SlTextarea SetHelpText(this SlTextarea tag, string value)
    {
        return tag.SetAttribute("helpText", value.ToString());
    }
    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static SlTextarea SetPlaceholder(this SlTextarea tag, string value)
    {
        return tag.SetAttribute("placeholder", value.ToString());
    }
    /// <summary>
    /// The number of rows to display by default.
    /// </summary>
    public static SlTextarea SetRows(this SlTextarea tag, int value)
    {
        return tag.SetAttribute("rows", value.ToString());
    }
    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static SlTextarea SetResizeNone(this SlTextarea tag)
    {
        return tag.SetAttribute("resize", "none");
    }
    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static SlTextarea SetResizeVertical(this SlTextarea tag)
    {
        return tag.SetAttribute("resize", "vertical");
    }
    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static SlTextarea SetResizeAuto(this SlTextarea tag)
    {
        return tag.SetAttribute("resize", "auto");
    }
    /// <summary>
    /// Disables the textarea.
    /// </summary>
    public static SlTextarea SetDisabled(this SlTextarea tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// Makes the textarea readonly.
    /// </summary>
    public static SlTextarea SetReadonly(this SlTextarea tag)
    {
        return tag.SetAttribute("readonly", "true");
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static SlTextarea SetForm(this SlTextarea tag, string value)
    {
        return tag.SetAttribute("form", value.ToString());
    }
    /// <summary>
    /// Makes the textarea a required field.
    /// </summary>
    public static SlTextarea SetRequired(this SlTextarea tag)
    {
        return tag.SetAttribute("required", "true");
    }
    /// <summary>
    /// The minimum length of input that will be considered valid.
    /// </summary>
    public static SlTextarea SetMinlength(this SlTextarea tag, int value)
    {
        return tag.SetAttribute("minlength", value.ToString());
    }
    /// <summary>
    /// The maximum length of input that will be considered valid.
    /// </summary>
    public static SlTextarea SetMaxlength(this SlTextarea tag, int value)
    {
        return tag.SetAttribute("maxlength", value.ToString());
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlTextarea SetAutocapitalizeOff(this SlTextarea tag)
    {
        return tag.SetAttribute("autocapitalize", "off");
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlTextarea SetAutocapitalizeNone(this SlTextarea tag)
    {
        return tag.SetAttribute("autocapitalize", "none");
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlTextarea SetAutocapitalizeOn(this SlTextarea tag)
    {
        return tag.SetAttribute("autocapitalize", "on");
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlTextarea SetAutocapitalizeSentences(this SlTextarea tag)
    {
        return tag.SetAttribute("autocapitalize", "sentences");
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlTextarea SetAutocapitalizeWords(this SlTextarea tag)
    {
        return tag.SetAttribute("autocapitalize", "words");
    }
    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static SlTextarea SetAutocapitalizeCharacters(this SlTextarea tag)
    {
        return tag.SetAttribute("autocapitalize", "characters");
    }
    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static SlTextarea SetAutocorrect(this SlTextarea tag, string value)
    {
        return tag.SetAttribute("autocorrect", value.ToString());
    }
    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static SlTextarea SetAutocomplete(this SlTextarea tag, string value)
    {
        return tag.SetAttribute("autocomplete", value.ToString());
    }
    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static SlTextarea SetAutofocus(this SlTextarea tag)
    {
        return tag.SetAttribute("autofocus", "true");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlTextarea SetEnterkeyhintEnter(this SlTextarea tag)
    {
        return tag.SetAttribute("enterkeyhint", "enter");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlTextarea SetEnterkeyhintDone(this SlTextarea tag)
    {
        return tag.SetAttribute("enterkeyhint", "done");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlTextarea SetEnterkeyhintGo(this SlTextarea tag)
    {
        return tag.SetAttribute("enterkeyhint", "go");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlTextarea SetEnterkeyhintNext(this SlTextarea tag)
    {
        return tag.SetAttribute("enterkeyhint", "next");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlTextarea SetEnterkeyhintPrevious(this SlTextarea tag)
    {
        return tag.SetAttribute("enterkeyhint", "previous");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlTextarea SetEnterkeyhintSearch(this SlTextarea tag)
    {
        return tag.SetAttribute("enterkeyhint", "search");
    }
    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static SlTextarea SetEnterkeyhintSend(this SlTextarea tag)
    {
        return tag.SetAttribute("enterkeyhint", "send");
    }
    /// <summary>
    /// Enables spell checking on the textarea.
    /// </summary>
    public static SlTextarea SetSpellcheck(this SlTextarea tag)
    {
        return tag.SetAttribute("spellcheck", "true");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlTextarea SetInputmodeNone(this SlTextarea tag)
    {
        return tag.SetAttribute("inputmode", "none");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlTextarea SetInputmodeText(this SlTextarea tag)
    {
        return tag.SetAttribute("inputmode", "text");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlTextarea SetInputmodeDecimal(this SlTextarea tag)
    {
        return tag.SetAttribute("inputmode", "decimal");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlTextarea SetInputmodeNumeric(this SlTextarea tag)
    {
        return tag.SetAttribute("inputmode", "numeric");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlTextarea SetInputmodeTel(this SlTextarea tag)
    {
        return tag.SetAttribute("inputmode", "tel");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlTextarea SetInputmodeSearch(this SlTextarea tag)
    {
        return tag.SetAttribute("inputmode", "search");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlTextarea SetInputmodeEmail(this SlTextarea tag)
    {
        return tag.SetAttribute("inputmode", "email");
    }
    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static SlTextarea SetInputmodeUrl(this SlTextarea tag)
    {
        return tag.SetAttribute("inputmode", "url");
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static SlTextarea SetDefaultValue(this SlTextarea tag, string value)
    {
        return tag.SetAttribute("defaultValue", value.ToString());
    }
}

