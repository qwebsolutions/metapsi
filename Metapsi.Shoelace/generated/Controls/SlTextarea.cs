using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Textareas collect data from the user and allow multiple lines of text.
/// </summary>
public partial class SlTextarea
{
    /// <summary>
    /// 
    /// </summary>
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
    /// <summary>
    /// 
    /// </summary>
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
/// <summary>
/// Setter extensions of SlTextarea
/// </summary>
public static partial class SlTextareaControl
{
    /// <summary>
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTextarea(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTextarea>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-textarea", buildAttributes, children);
    }

    /// <summary>
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTextarea(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-textarea", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTextarea(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTextarea>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-textarea", buildAttributes, children);
    }

    /// <summary>
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTextarea(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-textarea", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static void SetTitle(this Metapsi.Html.AttributesBuilder<SlTextarea> b, string title) 
    {
        b.SetAttribute("title", title);
    }

    /// <summary>
    /// The name of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlTextarea> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// The current value of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlTextarea> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// Draws a filled textarea.
    /// </summary>
    public static void SetFilled(this Metapsi.Html.AttributesBuilder<SlTextarea> b, bool filled) 
    {
        if (filled) b.SetAttribute("filled", "");
    }

    /// <summary>
    /// Draws a filled textarea.
    /// </summary>
    public static void SetFilled(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("filled", "");
    }

    /// <summary>
    /// The textarea's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlTextarea> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// The textarea's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this Metapsi.Html.AttributesBuilder<SlTextarea> b, string helpText) 
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static void SetPlaceholder(this Metapsi.Html.AttributesBuilder<SlTextarea> b, string placeholder) 
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static void SetResizeNone(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("resize", "none");
    }

    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static void SetResizeVertical(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("resize", "vertical");
    }

    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static void SetResizeAuto(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("resize", "auto");
    }

    /// <summary>
    /// Disables the textarea.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlTextarea> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the textarea.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Makes the textarea readonly.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<SlTextarea> b, bool @readonly) 
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// Makes the textarea readonly.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this Metapsi.Html.AttributesBuilder<SlTextarea> b, string form) 
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// Makes the textarea a required field.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlTextarea> b, bool required) 
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// Makes the textarea a required field.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOff(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("autocapitalize", "off");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeNone(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("autocapitalize", "none");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOn(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("autocapitalize", "on");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeSentences(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("autocapitalize", "sentences");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeWords(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("autocapitalize", "words");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeCharacters(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("autocapitalize", "characters");
    }

    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static void SetAutocorrect(this Metapsi.Html.AttributesBuilder<SlTextarea> b, string autocorrect) 
    {
        b.SetAttribute("autocorrect", autocorrect);
    }

    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static void SetAutocomplete(this Metapsi.Html.AttributesBuilder<SlTextarea> b, string autocomplete) 
    {
        b.SetAttribute("autocomplete", autocomplete);
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus(this Metapsi.Html.AttributesBuilder<SlTextarea> b, bool autofocus) 
    {
        if (autofocus) b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintEnter(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "enter");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintDone(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "done");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintGo(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "go");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintNext(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "next");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "previous");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSearch(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "search");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSend(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// Enables spell checking on the textarea.
    /// </summary>
    public static void SetSpellcheck(this Metapsi.Html.AttributesBuilder<SlTextarea> b, bool spellcheck) 
    {
        if (spellcheck) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// Enables spell checking on the textarea.
    /// </summary>
    public static void SetSpellcheck(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNone(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("inputmode", "none");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeText(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("inputmode", "text");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeDecimal(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("inputmode", "decimal");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNumeric(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("inputmode", "numeric");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeTel(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("inputmode", "tel");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeSearch(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("inputmode", "search");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeEmail(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("inputmode", "email");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeUrl(this Metapsi.Html.AttributesBuilder<SlTextarea> b) 
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTextarea(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTextarea>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-textarea", buildProps, children);
    }

    /// <summary>
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTextarea(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-textarea", children);
    }

    /// <summary>
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTextarea(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTextarea>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-textarea", buildProps, children);
    }

    /// <summary>
    /// Textareas collect data from the user and allow multiple lines of text.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTextarea(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-textarea", children);
    }

    /// <summary>
    /// The name of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlTextarea
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// The current value of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The current value of the textarea, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlTextarea
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The textarea's size.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// Draws a filled textarea.
    /// </summary>
    public static void SetFilled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetFilled(b.Const(true));
    }

    /// <summary>
    /// Draws a filled textarea.
    /// </summary>
    public static void SetFilled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> filled) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("filled"), filled);
    }

    /// <summary>
    /// Draws a filled textarea.
    /// </summary>
    public static void SetFilled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool filled) where T: SlTextarea
    {
        b.SetFilled(b.Const(filled));
    }

    /// <summary>
    /// The textarea's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The textarea's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlTextarea
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// The textarea's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helpText) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("helpText"), helpText);
    }

    /// <summary>
    /// The textarea's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helpText) where T: SlTextarea
    {
        b.SetHelpText(b.Const(helpText));
    }

    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> placeholder) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }

    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, string placeholder) where T: SlTextarea
    {
        b.SetPlaceholder(b.Const(placeholder));
    }

    /// <summary>
    /// The number of rows to display by default.
    /// </summary>
    public static void SetRows<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> rows) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("rows"), rows);
    }

    /// <summary>
    /// The number of rows to display by default.
    /// </summary>
    public static void SetRows<T>(this Metapsi.Syntax.PropsBuilder<T> b, int rows) where T: SlTextarea
    {
        b.SetRows(b.Const(rows));
    }

    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static void SetResizeNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("resize"), b.Const("none"));
    }

    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static void SetResizeVertical<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("resize"), b.Const("vertical"));
    }

    /// <summary>
    /// Controls how the textarea can be resized.
    /// </summary>
    public static void SetResizeAuto<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("resize"), b.Const("auto"));
    }

    /// <summary>
    /// Disables the textarea.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the textarea.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the textarea.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlTextarea
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Makes the textarea readonly.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetReadonly(b.Const(true));
    }

    /// <summary>
    /// Makes the textarea readonly.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @readonly) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("readonly"), @readonly);
    }

    /// <summary>
    /// Makes the textarea readonly.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @readonly) where T: SlTextarea
    {
        b.SetReadonly(b.Const(@readonly));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string form) where T: SlTextarea
    {
        b.SetForm(b.Const(form));
    }

    /// <summary>
    /// Makes the textarea a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetRequired(b.Const(true));
    }

    /// <summary>
    /// Makes the textarea a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> required) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// Makes the textarea a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool required) where T: SlTextarea
    {
        b.SetRequired(b.Const(required));
    }

    /// <summary>
    /// The minimum length of input that will be considered valid.
    /// </summary>
    public static void SetMinlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> minlength) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("minlength"), minlength);
    }

    /// <summary>
    /// The minimum length of input that will be considered valid.
    /// </summary>
    public static void SetMinlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, int minlength) where T: SlTextarea
    {
        b.SetMinlength(b.Const(minlength));
    }

    /// <summary>
    /// The maximum length of input that will be considered valid.
    /// </summary>
    public static void SetMaxlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> maxlength) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("maxlength"), maxlength);
    }

    /// <summary>
    /// The maximum length of input that will be considered valid.
    /// </summary>
    public static void SetMaxlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, int maxlength) where T: SlTextarea
    {
        b.SetMaxlength(b.Const(maxlength));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOff<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("off"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("none"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOn<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("on"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeSentences<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("sentences"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeWords<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("words"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeCharacters<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("characters"));
    }

    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static void SetAutocorrect<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> autocorrect) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("autocorrect"), autocorrect);
    }

    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static void SetAutocorrect<T>(this Metapsi.Syntax.PropsBuilder<T> b, string autocorrect) where T: SlTextarea
    {
        b.SetAutocorrect(b.Const(autocorrect));
    }

    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static void SetAutocomplete<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> autocomplete) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), autocomplete);
    }

    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static void SetAutocomplete<T>(this Metapsi.Syntax.PropsBuilder<T> b, string autocomplete) where T: SlTextarea
    {
        b.SetAutocomplete(b.Const(autocomplete));
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetAutofocus(b.Const(true));
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> autofocus) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("autofocus"), autofocus);
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool autofocus) where T: SlTextarea
    {
        b.SetAutofocus(b.Const(autofocus));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("enter"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("done"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("go"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("next"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("previous"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("search"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("send"));
    }

    /// <summary>
    /// Enables spell checking on the textarea.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetSpellcheck(b.Const(true));
    }

    /// <summary>
    /// Enables spell checking on the textarea.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> spellcheck) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("spellcheck"), spellcheck);
    }

    /// <summary>
    /// Enables spell checking on the textarea.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool spellcheck) where T: SlTextarea
    {
        b.SetSpellcheck(b.Const(spellcheck));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("none"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("text"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeDecimal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("decimal"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("numeric"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeTel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("tel"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("search"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeEmail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("email"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> defaultValue) where T: SlTextarea
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), defaultValue);
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string defaultValue) where T: SlTextarea
    {
        b.SetDefaultValue(b.Const(defaultValue));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTextarea
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTextarea
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTextarea
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTextarea
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTextarea
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTextarea
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTextarea
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTextarea
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTextarea
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTextarea
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTextarea
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTextarea
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTextarea
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTextarea
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTextarea
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTextarea
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTextarea
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTextarea
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTextarea
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTextarea
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

}