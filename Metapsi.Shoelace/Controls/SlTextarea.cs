using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlTextarea : SlComponent
{
    public SlTextarea() : base("sl-textarea") { }
    /// <summary>
    /// The name of the textarea, submitted as a name/value pair with form data.
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
    /// The current value of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public string value
    {
        get
        {
            return this.GetTag().GetAttribute<string>("value");
        }
        set
        {
            this.GetTag().SetAttribute("value", value.ToString());
        }
    }

    /// <summary>
    /// The textarea's size.
    /// </summary>
    public string size
    {
        get
        {
            return this.GetTag().GetAttribute<string>("size");
        }
        set
        {
            this.GetTag().SetAttribute("size", value.ToString());
        }
    }

    /// <summary>
    /// Draws a filled textarea.
    /// </summary>
    public bool filled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("filled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("filled", value.ToString());
        }
    }

    /// <summary>
    /// The textarea's label. If you need to display HTML, use the `label` slot instead.
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
    /// The textarea's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public string helpText
    {
        get
        {
            return this.GetTag().GetAttribute<string>("help-text");
        }
        set
        {
            this.GetTag().SetAttribute("help-text", value.ToString());
        }
    }

    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public string placeholder
    {
        get
        {
            return this.GetTag().GetAttribute<string>("placeholder");
        }
        set
        {
            this.GetTag().SetAttribute("placeholder", value.ToString());
        }
    }

    /// <summary>
    /// The number of rows to display by default.
    /// </summary>
    public int rows
    {
        get
        {
            return this.GetTag().GetAttribute<int>("rows");
        }
        set
        {
            this.GetTag().SetAttribute("rows", value.ToString());
        }
    }

    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public string resize
    {
        get
        {
            return this.GetTag().GetAttribute<string>("resize");
        }
        set
        {
            this.GetTag().SetAttribute("resize", value.ToString());
        }
    }

    /// <summary>
    /// Disables the textarea.
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
    /// Makes the textarea readonly.
    /// </summary>
    public bool @readonly
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("readonly");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("readonly", value.ToString());
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
    /// Makes the textarea a required field.
    /// </summary>
    public bool required
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("required");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("required", value.ToString());
        }
    }

    /// <summary>
    /// The minimum length of input that will be considered valid.
    /// </summary>
    public int minlength
    {
        get
        {
            return this.GetTag().GetAttribute<int>("minlength");
        }
        set
        {
            this.GetTag().SetAttribute("minlength", value.ToString());
        }
    }

    /// <summary>
    /// The maximum length of input that will be considered valid.
    /// </summary>
    public int maxlength
    {
        get
        {
            return this.GetTag().GetAttribute<int>("maxlength");
        }
        set
        {
            this.GetTag().SetAttribute("maxlength", value.ToString());
        }
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public string autocapitalize
    {
        get
        {
            return this.GetTag().GetAttribute<string>("autocapitalize");
        }
        set
        {
            this.GetTag().SetAttribute("autocapitalize", value.ToString());
        }
    }

    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public string autocorrect
    {
        get
        {
            return this.GetTag().GetAttribute<string>("autocorrect");
        }
        set
        {
            this.GetTag().SetAttribute("autocorrect", value.ToString());
        }
    }

    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public string autocomplete
    {
        get
        {
            return this.GetTag().GetAttribute<string>("autocomplete");
        }
        set
        {
            this.GetTag().SetAttribute("autocomplete", value.ToString());
        }
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public bool autofocus
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("autofocus");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("autofocus", value.ToString());
        }
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public string enterkeyhint
    {
        get
        {
            return this.GetTag().GetAttribute<string>("enterkeyhint");
        }
        set
        {
            this.GetTag().SetAttribute("enterkeyhint", value.ToString());
        }
    }

    /// <summary>
    /// Enables spell checking on the textarea.
    /// </summary>
    public bool spellcheck
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("spellcheck");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("spellcheck", value.ToString());
        }
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public string inputmode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("inputmode");
        }
        set
        {
            this.GetTag().SetAttribute("inputmode", value.ToString());
        }
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public string defaultValue
    {
        get
        {
            return this.GetTag().GetAttribute<string>("");
        }
        set
        {
            this.GetTag().SetAttribute("", value.ToString());
        }
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
    public static class Method
    {
        /// <summary> 
        /// Sets focus on the textarea.
        /// </summary>
        public const string Focus = "focus";
        /// <summary> 
        /// Removes focus from the textarea.
        /// </summary>
        public const string Blur = "blur";
        /// <summary> 
        /// Selects all the text in the textarea.
        /// </summary>
        public const string Select = "select";
        /// <summary> 
        /// Gets or sets the textarea's scroll position.
        /// </summary>
        public const string ScrollPosition = "scrollPosition";
        /// <summary> 
        /// Sets the start and end positions of the text selection (0-based).
        /// </summary>
        public const string SetSelectionRange = "setSelectionRange";
        /// <summary> 
        /// Replaces a range of text with a new string.
        /// </summary>
        public const string SetRangeText = "setRangeText";
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
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Var<IVNode> SlTextarea(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-textarea", children);
    }
    /// <summary>
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Var<IVNode> SlTextarea(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-textarea", children);
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
        b.SetDynamic(b.Props, new DynamicProperty<string>("help-text"), value);
    }
    /// <summary>
    /// The textarea's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlTextarea> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("help-text"), b.Const(value));
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
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlTextarea> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlTextarea> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

