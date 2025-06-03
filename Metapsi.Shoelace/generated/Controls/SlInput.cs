using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Inputs collect data from the user.
/// </summary>
public partial class SlInput
{
    /// <summary>
    /// 
    /// </summary>
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
    /// <summary>
    /// 
    /// </summary>
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
/// <summary>
/// Setter extensions of SlInput
/// </summary>
public static partial class SlInputControl
{
    /// <summary>
    /// Inputs collect data from the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlInput(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlInput>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-input", buildAttributes, children);
    }

    /// <summary>
    /// Inputs collect data from the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlInput(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-input", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Inputs collect data from the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlInput(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlInput>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-input", buildAttributes, children);
    }

    /// <summary>
    /// Inputs collect data from the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlInput(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-input", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static void SetTitle(this Metapsi.Html.AttributesBuilder<SlInput> b, string title) 
    {
        b.SetAttribute("title", title);
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeDate(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("type", "date");
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeDatetimeLocal(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("type", "datetime-local");
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeEmail(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("type", "email");
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeNumber(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("type", "number");
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypePassword(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("type", "password");
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeSearch(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("type", "search");
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeTel(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("type", "tel");
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeText(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("type", "text");
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeTime(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("type", "time");
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeUrl(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("type", "url");
    }

    /// <summary>
    /// The name of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlInput> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// The current value of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlInput> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// The input's size.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// The input's size.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// The input's size.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// Draws a filled input.
    /// </summary>
    public static void SetFilled(this Metapsi.Html.AttributesBuilder<SlInput> b, bool filled) 
    {
        if (filled) b.SetAttribute("filled", "");
    }

    /// <summary>
    /// Draws a filled input.
    /// </summary>
    public static void SetFilled(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("filled", "");
    }

    /// <summary>
    /// Draws a pill-style input with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlInput> b, bool pill) 
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    /// Draws a pill-style input with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// The input's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlInput> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// The input's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this Metapsi.Html.AttributesBuilder<SlInput> b, string helpText) 
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// Adds a clear button when the input is not empty.
    /// </summary>
    public static void SetClearable(this Metapsi.Html.AttributesBuilder<SlInput> b, bool clearable) 
    {
        if (clearable) b.SetAttribute("clearable", "");
    }

    /// <summary>
    /// Adds a clear button when the input is not empty.
    /// </summary>
    public static void SetClearable(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("clearable", "");
    }

    /// <summary>
    /// Disables the input.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlInput> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the input.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static void SetPlaceholder(this Metapsi.Html.AttributesBuilder<SlInput> b, string placeholder) 
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// Makes the input readonly.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<SlInput> b, bool @readonly) 
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// Makes the input readonly.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// Adds a button to toggle the password's visibility. Only applies to password types.
    /// </summary>
    public static void SetPasswordToggle(this Metapsi.Html.AttributesBuilder<SlInput> b, bool passwordToggle) 
    {
        if (passwordToggle) b.SetAttribute("password-toggle", "");
    }

    /// <summary>
    /// Adds a button to toggle the password's visibility. Only applies to password types.
    /// </summary>
    public static void SetPasswordToggle(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("password-toggle", "");
    }

    /// <summary>
    /// Determines whether or not the password is currently visible. Only applies to password input types.
    /// </summary>
    public static void SetPasswordVisible(this Metapsi.Html.AttributesBuilder<SlInput> b, bool passwordVisible) 
    {
        if (passwordVisible) b.SetAttribute("password-visible", "");
    }

    /// <summary>
    /// Determines whether or not the password is currently visible. Only applies to password input types.
    /// </summary>
    public static void SetPasswordVisible(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("password-visible", "");
    }

    /// <summary>
    /// Hides the browser's built-in increment/decrement spin buttons for number inputs.
    /// </summary>
    public static void SetNoSpinButtons(this Metapsi.Html.AttributesBuilder<SlInput> b, bool noSpinButtons) 
    {
        if (noSpinButtons) b.SetAttribute("no-spin-buttons", "");
    }

    /// <summary>
    /// Hides the browser's built-in increment/decrement spin buttons for number inputs.
    /// </summary>
    public static void SetNoSpinButtons(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("no-spin-buttons", "");
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this Metapsi.Html.AttributesBuilder<SlInput> b, string form) 
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// Makes the input a required field.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlInput> b, bool required) 
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// Makes the input a required field.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// A regular expression pattern to validate input against.
    /// </summary>
    public static void SetPattern(this Metapsi.Html.AttributesBuilder<SlInput> b, string pattern) 
    {
        b.SetAttribute("pattern", pattern);
    }

    /// <summary>
    /// The input's minimum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMin(this Metapsi.Html.AttributesBuilder<SlInput> b, string min) 
    {
        b.SetAttribute("min", min);
    }

    /// <summary>
    /// The input's maximum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMax(this Metapsi.Html.AttributesBuilder<SlInput> b, string max) 
    {
        b.SetAttribute("max", max);
    }

    /// <summary>
    /// Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types.
    /// </summary>
    public static void SetStep(this Metapsi.Html.AttributesBuilder<SlInput> b, string step) 
    {
        b.SetAttribute("step", step);
    }

    /// <summary>
    /// Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types.
    /// </summary>
    public static void SetStepAny(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("step", "any");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOff(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("autocapitalize", "off");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeNone(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("autocapitalize", "none");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOn(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("autocapitalize", "on");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeSentences(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("autocapitalize", "sentences");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeWords(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("autocapitalize", "words");
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeCharacters(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("autocapitalize", "characters");
    }

    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static void SetAutocorrectOff(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("autocorrect", "off");
    }

    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static void SetAutocorrectOn(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("autocorrect", "on");
    }

    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static void SetAutocomplete(this Metapsi.Html.AttributesBuilder<SlInput> b, string autocomplete) 
    {
        b.SetAttribute("autocomplete", autocomplete);
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus(this Metapsi.Html.AttributesBuilder<SlInput> b, bool autofocus) 
    {
        if (autofocus) b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintEnter(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("enterkeyhint", "enter");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintDone(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("enterkeyhint", "done");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintGo(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("enterkeyhint", "go");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintNext(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("enterkeyhint", "next");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("enterkeyhint", "previous");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSearch(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("enterkeyhint", "search");
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSend(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// Enables spell checking on the input.
    /// </summary>
    public static void SetSpellcheck(this Metapsi.Html.AttributesBuilder<SlInput> b, bool spellcheck) 
    {
        if (spellcheck) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// Enables spell checking on the input.
    /// </summary>
    public static void SetSpellcheck(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNone(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("inputmode", "none");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeText(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("inputmode", "text");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeDecimal(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("inputmode", "decimal");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNumeric(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("inputmode", "numeric");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeTel(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("inputmode", "tel");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeSearch(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("inputmode", "search");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeEmail(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("inputmode", "email");
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeUrl(this Metapsi.Html.AttributesBuilder<SlInput> b) 
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// Inputs collect data from the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlInput(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlInput>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-input", buildProps, children);
    }

    /// <summary>
    /// Inputs collect data from the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlInput(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-input", children);
    }

    /// <summary>
    /// Inputs collect data from the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlInput(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlInput>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-input", buildProps, children);
    }

    /// <summary>
    /// Inputs collect data from the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlInput(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-input", children);
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeDate<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("date"));
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeDatetimeLocal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("datetime-local"));
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeEmail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("email"));
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeNumber<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("number"));
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypePassword<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("password"));
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("search"));
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeTel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("tel"));
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("text"));
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeTime<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("time"));
    }

    /// <summary>
    /// The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`.
    /// </summary>
    public static void SetTypeUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("url"));
    }

    /// <summary>
    /// The name of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlInput
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// The current value of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The current value of the input, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlInput
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> defaultValue) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), defaultValue);
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string defaultValue) where T: SlInput
    {
        b.SetDefaultValue(b.Const(defaultValue));
    }

    /// <summary>
    /// The input's size.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The input's size.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The input's size.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// Draws a filled input.
    /// </summary>
    public static void SetFilled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetFilled(b.Const(true));
    }

    /// <summary>
    /// Draws a filled input.
    /// </summary>
    public static void SetFilled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> filled) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("filled"), filled);
    }

    /// <summary>
    /// Draws a filled input.
    /// </summary>
    public static void SetFilled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool filled) where T: SlInput
    {
        b.SetFilled(b.Const(filled));
    }

    /// <summary>
    /// Draws a pill-style input with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetPill(b.Const(true));
    }

    /// <summary>
    /// Draws a pill-style input with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> pill) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("pill"), pill);
    }

    /// <summary>
    /// Draws a pill-style input with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool pill) where T: SlInput
    {
        b.SetPill(b.Const(pill));
    }

    /// <summary>
    /// The input's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The input's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlInput
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// The input's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helpText) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("helpText"), helpText);
    }

    /// <summary>
    /// The input's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helpText) where T: SlInput
    {
        b.SetHelpText(b.Const(helpText));
    }

    /// <summary>
    /// Adds a clear button when the input is not empty.
    /// </summary>
    public static void SetClearable<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetClearable(b.Const(true));
    }

    /// <summary>
    /// Adds a clear button when the input is not empty.
    /// </summary>
    public static void SetClearable<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> clearable) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("clearable"), clearable);
    }

    /// <summary>
    /// Adds a clear button when the input is not empty.
    /// </summary>
    public static void SetClearable<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool clearable) where T: SlInput
    {
        b.SetClearable(b.Const(clearable));
    }

    /// <summary>
    /// Disables the input.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the input.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the input.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlInput
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> placeholder) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }

    /// <summary>
    /// Placeholder text to show as a hint when the input is empty.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, string placeholder) where T: SlInput
    {
        b.SetPlaceholder(b.Const(placeholder));
    }

    /// <summary>
    /// Makes the input readonly.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetReadonly(b.Const(true));
    }

    /// <summary>
    /// Makes the input readonly.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @readonly) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("readonly"), @readonly);
    }

    /// <summary>
    /// Makes the input readonly.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @readonly) where T: SlInput
    {
        b.SetReadonly(b.Const(@readonly));
    }

    /// <summary>
    /// Adds a button to toggle the password's visibility. Only applies to password types.
    /// </summary>
    public static void SetPasswordToggle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetPasswordToggle(b.Const(true));
    }

    /// <summary>
    /// Adds a button to toggle the password's visibility. Only applies to password types.
    /// </summary>
    public static void SetPasswordToggle<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> passwordToggle) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("passwordToggle"), passwordToggle);
    }

    /// <summary>
    /// Adds a button to toggle the password's visibility. Only applies to password types.
    /// </summary>
    public static void SetPasswordToggle<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool passwordToggle) where T: SlInput
    {
        b.SetPasswordToggle(b.Const(passwordToggle));
    }

    /// <summary>
    /// Determines whether or not the password is currently visible. Only applies to password input types.
    /// </summary>
    public static void SetPasswordVisible<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetPasswordVisible(b.Const(true));
    }

    /// <summary>
    /// Determines whether or not the password is currently visible. Only applies to password input types.
    /// </summary>
    public static void SetPasswordVisible<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> passwordVisible) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("passwordVisible"), passwordVisible);
    }

    /// <summary>
    /// Determines whether or not the password is currently visible. Only applies to password input types.
    /// </summary>
    public static void SetPasswordVisible<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool passwordVisible) where T: SlInput
    {
        b.SetPasswordVisible(b.Const(passwordVisible));
    }

    /// <summary>
    /// Hides the browser's built-in increment/decrement spin buttons for number inputs.
    /// </summary>
    public static void SetNoSpinButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetNoSpinButtons(b.Const(true));
    }

    /// <summary>
    /// Hides the browser's built-in increment/decrement spin buttons for number inputs.
    /// </summary>
    public static void SetNoSpinButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> noSpinButtons) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("noSpinButtons"), noSpinButtons);
    }

    /// <summary>
    /// Hides the browser's built-in increment/decrement spin buttons for number inputs.
    /// </summary>
    public static void SetNoSpinButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool noSpinButtons) where T: SlInput
    {
        b.SetNoSpinButtons(b.Const(noSpinButtons));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string form) where T: SlInput
    {
        b.SetForm(b.Const(form));
    }

    /// <summary>
    /// Makes the input a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetRequired(b.Const(true));
    }

    /// <summary>
    /// Makes the input a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> required) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// Makes the input a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool required) where T: SlInput
    {
        b.SetRequired(b.Const(required));
    }

    /// <summary>
    /// A regular expression pattern to validate input against.
    /// </summary>
    public static void SetPattern<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pattern) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("pattern"), pattern);
    }

    /// <summary>
    /// A regular expression pattern to validate input against.
    /// </summary>
    public static void SetPattern<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pattern) where T: SlInput
    {
        b.SetPattern(b.Const(pattern));
    }

    /// <summary>
    /// The minimum length of input that will be considered valid.
    /// </summary>
    public static void SetMinlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> minlength) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("minlength"), minlength);
    }

    /// <summary>
    /// The minimum length of input that will be considered valid.
    /// </summary>
    public static void SetMinlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, int minlength) where T: SlInput
    {
        b.SetMinlength(b.Const(minlength));
    }

    /// <summary>
    /// The maximum length of input that will be considered valid.
    /// </summary>
    public static void SetMaxlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> maxlength) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("maxlength"), maxlength);
    }

    /// <summary>
    /// The maximum length of input that will be considered valid.
    /// </summary>
    public static void SetMaxlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, int maxlength) where T: SlInput
    {
        b.SetMaxlength(b.Const(maxlength));
    }

    /// <summary>
    /// The input's minimum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> min) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("min"), min);
    }

    /// <summary>
    /// The input's minimum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> min) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("min"), min);
    }

    /// <summary>
    /// The input's maximum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> max) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// The input's maximum value. Only applies to date and number input types.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> max) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types.
    /// </summary>
    public static void SetStep<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> step) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("step"), step);
    }

    /// <summary>
    /// Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types.
    /// </summary>
    public static void SetStepAny<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("step"), b.Const("any"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOff<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("off"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("none"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeOn<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("on"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeSentences<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("sentences"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeWords<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("words"));
    }

    /// <summary>
    /// Controls whether and how text input is automatically capitalized as it is entered by the user.
    /// </summary>
    public static void SetAutocapitalizeCharacters<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("characters"));
    }

    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static void SetAutocorrectOff<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocorrect"), b.Const("off"));
    }

    /// <summary>
    /// Indicates whether the browser's autocorrect feature is on or off.
    /// </summary>
    public static void SetAutocorrectOn<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocorrect"), b.Const("on"));
    }

    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static void SetAutocomplete<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> autocomplete) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), autocomplete);
    }

    /// <summary>
    /// Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values.
    /// </summary>
    public static void SetAutocomplete<T>(this Metapsi.Syntax.PropsBuilder<T> b, string autocomplete) where T: SlInput
    {
        b.SetAutocomplete(b.Const(autocomplete));
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetAutofocus(b.Const(true));
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> autofocus) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autofocus"), autofocus);
    }

    /// <summary>
    /// Indicates that the input should receive focus on page load.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool autofocus) where T: SlInput
    {
        b.SetAutofocus(b.Const(autofocus));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("enter"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("done"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("go"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("next"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("previous"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("search"));
    }

    /// <summary>
    /// Used to customize the label or icon of the Enter key on virtual keyboards.
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("send"));
    }

    /// <summary>
    /// Enables spell checking on the input.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetSpellcheck(b.Const(true));
    }

    /// <summary>
    /// Enables spell checking on the input.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> spellcheck) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("spellcheck"), spellcheck);
    }

    /// <summary>
    /// Enables spell checking on the input.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool spellcheck) where T: SlInput
    {
        b.SetSpellcheck(b.Const(spellcheck));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("none"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("text"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeDecimal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("decimal"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("numeric"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeTel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("tel"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("search"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeEmail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("email"));
    }

    /// <summary>
    /// Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices.
    /// </summary>
    public static void SetInputmodeUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// Gets or sets the current value as a `Date` object. Returns `null` if the value can't be converted. This will use the native `&lt;input type="{{type}}"&gt;` implementation and may result in an error.
    /// </summary>
    public static void SetValueAsDate<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> valueAsDate) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("valueAsDate"), valueAsDate);
    }

    /// <summary>
    /// Gets or sets the current value as a `Date` object. Returns `null` if the value can't be converted. This will use the native `&lt;input type="{{type}}"&gt;` implementation and may result in an error.
    /// </summary>
    public static void SetValueAsDate<T>(this Metapsi.Syntax.PropsBuilder<T> b, string valueAsDate) where T: SlInput
    {
        b.SetValueAsDate(b.Const(valueAsDate));
    }

    /// <summary>
    /// Gets or sets the current value as a number. Returns `NaN` if the value can't be converted.
    /// </summary>
    public static void SetValueAsNumber<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> valueAsNumber) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("valueAsNumber"), valueAsNumber);
    }

    /// <summary>
    /// Gets or sets the current value as a number. Returns `NaN` if the value can't be converted.
    /// </summary>
    public static void SetValueAsNumber<T>(this Metapsi.Syntax.PropsBuilder<T> b, string valueAsNumber) where T: SlInput
    {
        b.SetValueAsNumber(b.Const(valueAsNumber));
    }

    /// <summary>
    /// Gets the validity state object
    /// </summary>
    public static void SetValidity<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> validity) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("validity"), validity);
    }

    /// <summary>
    /// Gets the validity state object
    /// </summary>
    public static void SetValidity<T>(this Metapsi.Syntax.PropsBuilder<T> b, string validity) where T: SlInput
    {
        b.SetValidity(b.Const(validity));
    }

    /// <summary>
    /// Gets the validation message
    /// </summary>
    public static void SetValidationMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> validationMessage) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("validationMessage"), validationMessage);
    }

    /// <summary>
    /// Gets the validation message
    /// </summary>
    public static void SetValidationMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, string validationMessage) where T: SlInput
    {
        b.SetValidationMessage(b.Const(validationMessage));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the clear button is activated.
    /// </summary>
    public static void OnSlClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-clear", action);
    }

    /// <summary>
    /// Emitted when the clear button is activated.
    /// </summary>
    public static void OnSlClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlClear(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the clear button is activated.
    /// </summary>
    public static void OnSlClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-clear", action);
    }

    /// <summary>
    /// Emitted when the clear button is activated.
    /// </summary>
    public static void OnSlClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlClear(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlInput
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlInput
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

}