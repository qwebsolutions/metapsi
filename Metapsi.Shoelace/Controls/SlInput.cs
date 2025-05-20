using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlInput
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The input's label. Alternatively, you can use the `label` attribute. </para>
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// <para> Used to prepend a presentational icon or similar element to the input. </para>
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// <para> Used to append a presentational icon or similar element to the input. </para>
        /// </summary>
        public const string Suffix = "suffix";
        /// <summary>
        /// <para> An icon to use in lieu of the default clear icon. </para>
        /// </summary>
        public const string ClearIcon = "clear-icon";
        /// <summary>
        /// <para> An icon to use in lieu of the default show password icon. </para>
        /// </summary>
        public const string ShowPasswordIcon = "show-password-icon";
        /// <summary>
        /// <para> An icon to use in lieu of the default hide password icon. </para>
        /// </summary>
        public const string HidePasswordIcon = "hide-password-icon";
        /// <summary>
        /// <para> Text that describes how to use the input. Alternatively, you can use the `help-text` attribute. </para>
        /// </summary>
        public const string HelpText = "help-text";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Sets focus on the input. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the input. </para>
        /// </summary>
        public const string Blur = "blur";
        /// <summary>
        /// <para> Selects all the text in the input. </para>
        /// </summary>
        public const string Select = "select";
        /// <summary>
        /// <para> Sets the start and end positions of the text selection (0-based). </para>
        /// </summary>
        public const string SetSelectionRange = "setSelectionRange";
        /// <summary>
        /// <para> Replaces a range of text with a new string. </para>
        /// </summary>
        public const string SetRangeText = "setRangeText";
        /// <summary>
        /// <para> Displays the browser picker for an input element (only works if the browser supports it for the input type). </para>
        /// </summary>
        public const string ShowPicker = "showPicker";
        /// <summary>
        /// <para> Increments the value of a numeric input type by the value of the step attribute. </para>
        /// </summary>
        public const string StepUp = "stepUp";
        /// <summary>
        /// <para> Decrements the value of a numeric input type by the value of the step attribute. </para>
        /// </summary>
        public const string StepDown = "stepDown";
        /// <summary>
        /// <para> Checks for validity but does not show a validation message. Returns `true` when valid and `false` when invalid. </para>
        /// </summary>
        public const string CheckValidity = "checkValidity";
        /// <summary>
        /// <para> Gets the associated form, if one exists. </para>
        /// </summary>
        public const string GetForm = "getForm";
        /// <summary>
        /// <para> Checks for validity and shows the browser's validation message if the control is invalid. </para>
        /// </summary>
        public const string ReportValidity = "reportValidity";
        /// <summary>
        /// <para> Sets a custom validation message. Pass an empty string to restore validity. </para>
        /// </summary>
        public const string SetCustomValidity = "setCustomValidity";
    }
}

public static partial class SlInputControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlInput(this HtmlBuilder b, Action<AttributesBuilder<SlInput>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-input", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlInput(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-input", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlInput(this HtmlBuilder b, Action<AttributesBuilder<SlInput>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-input", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlInput(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-input", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<SlInput> b, string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeDate(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("type", "date");
    }

    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeDatetimeLocal(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("type", "datetime-local");
    }

    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeEmail(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("type", "email");
    }

    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeNumber(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("type", "number");
    }

    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypePassword(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("type", "password");
    }

    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeSearch(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("type", "search");
    }

    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeTel(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("type", "tel");
    }

    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeText(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("type", "text");
    }

    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeTime(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("type", "time");
    }

    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeUrl(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("type", "url");
    }

    /// <summary>
    /// <para> The name of the input, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlInput> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The current value of the input, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlInput> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The input's size. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlInput> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The input's size. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> The input's size. </para>
    /// </summary>
    public static void SetSizeMedium(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// <para> The input's size. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> Draws a filled input. </para>
    /// </summary>
    public static void SetFilled(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("filled", "");
    }

    /// <summary>
    /// <para> Draws a filled input. </para>
    /// </summary>
    public static void SetFilled(this AttributesBuilder<SlInput> b, bool filled)
    {
        if (filled) b.SetAttribute("filled", "");
    }

    /// <summary>
    /// <para> Draws a pill-style input with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// <para> Draws a pill-style input with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlInput> b, bool pill)
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    /// <para> The input's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlInput> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> The input's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText(this AttributesBuilder<SlInput> b, string helpText)
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// <para> Adds a clear button when the input is not empty. </para>
    /// </summary>
    public static void SetClearable(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("clearable", "");
    }

    /// <summary>
    /// <para> Adds a clear button when the input is not empty. </para>
    /// </summary>
    public static void SetClearable(this AttributesBuilder<SlInput> b, bool clearable)
    {
        if (clearable) b.SetAttribute("clearable", "");
    }

    /// <summary>
    /// <para> Disables the input. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the input. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlInput> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Placeholder text to show as a hint when the input is empty. </para>
    /// </summary>
    public static void SetPlaceholder(this AttributesBuilder<SlInput> b, string placeholder)
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// <para> Makes the input readonly. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> Makes the input readonly. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<SlInput> b, bool @readonly)
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> Adds a button to toggle the password's visibility. Only applies to password types. </para>
    /// </summary>
    public static void SetPasswordToggle(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("password-toggle", "");
    }

    /// <summary>
    /// <para> Adds a button to toggle the password's visibility. Only applies to password types. </para>
    /// </summary>
    public static void SetPasswordToggle(this AttributesBuilder<SlInput> b, bool passwordToggle)
    {
        if (passwordToggle) b.SetAttribute("password-toggle", "");
    }

    /// <summary>
    /// <para> Determines whether or not the password is currently visible. Only applies to password input types. </para>
    /// </summary>
    public static void SetPasswordVisible(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("password-visible", "");
    }

    /// <summary>
    /// <para> Determines whether or not the password is currently visible. Only applies to password input types. </para>
    /// </summary>
    public static void SetPasswordVisible(this AttributesBuilder<SlInput> b, bool passwordVisible)
    {
        if (passwordVisible) b.SetAttribute("password-visible", "");
    }

    /// <summary>
    /// <para> Hides the browser's built-in increment/decrement spin buttons for number inputs. </para>
    /// </summary>
    public static void SetNoSpinButtons(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("no-spin-buttons", "");
    }

    /// <summary>
    /// <para> Hides the browser's built-in increment/decrement spin buttons for number inputs. </para>
    /// </summary>
    public static void SetNoSpinButtons(this AttributesBuilder<SlInput> b, bool noSpinButtons)
    {
        if (noSpinButtons) b.SetAttribute("no-spin-buttons", "");
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm(this AttributesBuilder<SlInput> b, string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// <para> Makes the input a required field. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> Makes the input a required field. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlInput> b, bool required)
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> A regular expression pattern to validate input against. </para>
    /// </summary>
    public static void SetPattern(this AttributesBuilder<SlInput> b, string pattern)
    {
        b.SetAttribute("pattern", pattern);
    }

    /// <summary>
    /// <para> The minimum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMinlength(this AttributesBuilder<SlInput> b, string minlength)
    {
        b.SetAttribute("minlength", minlength);
    }

    /// <summary>
    /// <para> The maximum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMaxlength(this AttributesBuilder<SlInput> b, string maxlength)
    {
        b.SetAttribute("maxlength", maxlength);
    }

    /// <summary>
    /// <para> The input's minimum value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetMin(this AttributesBuilder<SlInput> b, string min)
    {
        b.SetAttribute("min", min);
    }

    /// <summary>
    /// <para> The input's maximum value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetMax(this AttributesBuilder<SlInput> b, string max)
    {
        b.SetAttribute("max", max);
    }

    /// <summary>
    /// <para> Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetStep(this AttributesBuilder<SlInput> b, string step)
    {
        b.SetAttribute("step", step);
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalize(this AttributesBuilder<SlInput> b, string autocapitalize)
    {
        b.SetAttribute("autocapitalize", autocapitalize);
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeOff(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("autocapitalize", "off");
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeNone(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("autocapitalize", "none");
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeOn(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("autocapitalize", "on");
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeSentences(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("autocapitalize", "sentences");
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeWords(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("autocapitalize", "words");
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeCharacters(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("autocapitalize", "characters");
    }

    /// <summary>
    /// <para> Indicates whether the browser's autocorrect feature is on or off. </para>
    /// </summary>
    public static void SetAutocorrect(this AttributesBuilder<SlInput> b, string autocorrect)
    {
        b.SetAttribute("autocorrect", autocorrect);
    }

    /// <summary>
    /// <para> Indicates whether the browser's autocorrect feature is on or off. </para>
    /// </summary>
    public static void SetAutocorrectOff(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("autocorrect", "off");
    }

    /// <summary>
    /// <para> Indicates whether the browser's autocorrect feature is on or off. </para>
    /// </summary>
    public static void SetAutocorrectOn(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("autocorrect", "on");
    }

    /// <summary>
    /// <para> Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values. </para>
    /// </summary>
    public static void SetAutocomplete(this AttributesBuilder<SlInput> b, string autocomplete)
    {
        b.SetAttribute("autocomplete", autocomplete);
    }

    /// <summary>
    /// <para> Indicates that the input should receive focus on page load. </para>
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// <para> Indicates that the input should receive focus on page load. </para>
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<SlInput> b, bool autofocus)
    {
        if (autofocus) b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhint(this AttributesBuilder<SlInput> b, string enterkeyhint)
    {
        b.SetAttribute("enterkeyhint", enterkeyhint);
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintEnter(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("enterkeyhint", "enter");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintDone(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("enterkeyhint", "done");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintGo(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("enterkeyhint", "go");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintNext(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("enterkeyhint", "next");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintPrevious(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("enterkeyhint", "previous");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintSearch(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("enterkeyhint", "search");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintSend(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// <para> Enables spell checking on the input. </para>
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// <para> Enables spell checking on the input. </para>
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<SlInput> b, bool spellcheck)
    {
        if (spellcheck) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmode(this AttributesBuilder<SlInput> b, string inputmode)
    {
        b.SetAttribute("inputmode", inputmode);
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeNone(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("inputmode", "none");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeText(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("inputmode", "text");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeDecimal(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("inputmode", "decimal");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeNumeric(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("inputmode", "numeric");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeTel(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("inputmode", "tel");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeSearch(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("inputmode", "search");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeEmail(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("inputmode", "email");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeUrl(this AttributesBuilder<SlInput> b)
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlInput(this LayoutBuilder b, Action<PropsBuilder<SlInput>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-input", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlInput(this LayoutBuilder b, Action<PropsBuilder<SlInput>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-input", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlInput(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-input", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlInput(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-input", children);
    }
    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeDate<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("date"));
    }


    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeDatetimeLocal<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("datetime-local"));
    }


    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeEmail<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("email"));
    }


    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeNumber<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("number"));
    }


    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypePassword<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("password"));
    }


    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeSearch<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("search"));
    }


    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeTel<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("tel"));
    }


    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeText<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("text"));
    }


    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeTime<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("time"));
    }


    /// <summary>
    /// <para> The type of input. Works the same as a native `&lt;input&gt;` element, but only a subset of types are supported. Defaults to `text`. </para>
    /// </summary>
    public static void SetTypeUrl<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("url"));
    }


    /// <summary>
    /// <para> The name of the input, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// <para> The name of the input, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The current value of the input, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> The current value of the input, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, Var<string> defaultValue) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), defaultValue);
    }

    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, string defaultValue) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), b.Const(defaultValue));
    }


    /// <summary>
    /// <para> The input's size. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> The input's size. </para>
    /// </summary>
    public static void SetSizeMedium<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The input's size. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> Draws a filled input. </para>
    /// </summary>
    public static void SetFilled<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("filled"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws a filled input. </para>
    /// </summary>
    public static void SetFilled<T>(this PropsBuilder<T> b, Var<bool> filled) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("filled"), filled);
    }

    /// <summary>
    /// <para> Draws a filled input. </para>
    /// </summary>
    public static void SetFilled<T>(this PropsBuilder<T> b, bool filled) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("filled"), b.Const(filled));
    }


    /// <summary>
    /// <para> Draws a pill-style input with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("pill"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws a pill-style input with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, Var<bool> pill) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("pill"), pill);
    }

    /// <summary>
    /// <para> Draws a pill-style input with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, bool pill) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("pill"), b.Const(pill));
    }


    /// <summary>
    /// <para> The input's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// <para> The input's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("label"), b.Const(label));
    }


    /// <summary>
    /// <para> The input's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, Var<string> helpText) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("helpText"), helpText);
    }

    /// <summary>
    /// <para> The input's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, string helpText) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("helpText"), b.Const(helpText));
    }


    /// <summary>
    /// <para> Adds a clear button when the input is not empty. </para>
    /// </summary>
    public static void SetClearable<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("clearable"), b.Const(true));
    }


    /// <summary>
    /// <para> Adds a clear button when the input is not empty. </para>
    /// </summary>
    public static void SetClearable<T>(this PropsBuilder<T> b, Var<bool> clearable) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("clearable"), clearable);
    }

    /// <summary>
    /// <para> Adds a clear button when the input is not empty. </para>
    /// </summary>
    public static void SetClearable<T>(this PropsBuilder<T> b, bool clearable) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("clearable"), b.Const(clearable));
    }


    /// <summary>
    /// <para> Disables the input. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the input. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the input. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Placeholder text to show as a hint when the input is empty. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, Var<string> placeholder) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }

    /// <summary>
    /// <para> Placeholder text to show as a hint when the input is empty. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, string placeholder) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("placeholder"), b.Const(placeholder));
    }


    /// <summary>
    /// <para> Makes the input readonly. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("readonly"), b.Const(true));
    }


    /// <summary>
    /// <para> Makes the input readonly. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, Var<bool> @readonly) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("readonly"), @readonly);
    }

    /// <summary>
    /// <para> Makes the input readonly. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, bool @readonly) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("readonly"), b.Const(@readonly));
    }


    /// <summary>
    /// <para> Adds a button to toggle the password's visibility. Only applies to password types. </para>
    /// </summary>
    public static void SetPasswordToggle<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("passwordToggle"), b.Const(true));
    }


    /// <summary>
    /// <para> Adds a button to toggle the password's visibility. Only applies to password types. </para>
    /// </summary>
    public static void SetPasswordToggle<T>(this PropsBuilder<T> b, Var<bool> passwordToggle) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("passwordToggle"), passwordToggle);
    }

    /// <summary>
    /// <para> Adds a button to toggle the password's visibility. Only applies to password types. </para>
    /// </summary>
    public static void SetPasswordToggle<T>(this PropsBuilder<T> b, bool passwordToggle) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("passwordToggle"), b.Const(passwordToggle));
    }


    /// <summary>
    /// <para> Determines whether or not the password is currently visible. Only applies to password input types. </para>
    /// </summary>
    public static void SetPasswordVisible<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("passwordVisible"), b.Const(true));
    }


    /// <summary>
    /// <para> Determines whether or not the password is currently visible. Only applies to password input types. </para>
    /// </summary>
    public static void SetPasswordVisible<T>(this PropsBuilder<T> b, Var<bool> passwordVisible) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("passwordVisible"), passwordVisible);
    }

    /// <summary>
    /// <para> Determines whether or not the password is currently visible. Only applies to password input types. </para>
    /// </summary>
    public static void SetPasswordVisible<T>(this PropsBuilder<T> b, bool passwordVisible) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("passwordVisible"), b.Const(passwordVisible));
    }


    /// <summary>
    /// <para> Hides the browser's built-in increment/decrement spin buttons for number inputs. </para>
    /// </summary>
    public static void SetNoSpinButtons<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("noSpinButtons"), b.Const(true));
    }


    /// <summary>
    /// <para> Hides the browser's built-in increment/decrement spin buttons for number inputs. </para>
    /// </summary>
    public static void SetNoSpinButtons<T>(this PropsBuilder<T> b, Var<bool> noSpinButtons) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("noSpinButtons"), noSpinButtons);
    }

    /// <summary>
    /// <para> Hides the browser's built-in increment/decrement spin buttons for number inputs. </para>
    /// </summary>
    public static void SetNoSpinButtons<T>(this PropsBuilder<T> b, bool noSpinButtons) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("noSpinButtons"), b.Const(noSpinButtons));
    }


    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<string> form) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, string form) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("form"), b.Const(form));
    }


    /// <summary>
    /// <para> Makes the input a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("required"), b.Const(true));
    }


    /// <summary>
    /// <para> Makes the input a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, Var<bool> required) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// <para> Makes the input a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, bool required) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("required"), b.Const(required));
    }


    /// <summary>
    /// <para> A regular expression pattern to validate input against. </para>
    /// </summary>
    public static void SetPattern<T>(this PropsBuilder<T> b, Var<string> pattern) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("pattern"), pattern);
    }

    /// <summary>
    /// <para> A regular expression pattern to validate input against. </para>
    /// </summary>
    public static void SetPattern<T>(this PropsBuilder<T> b, string pattern) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("pattern"), b.Const(pattern));
    }


    /// <summary>
    /// <para> The minimum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, Var<int> minlength) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("minlength"), minlength);
    }

    /// <summary>
    /// <para> The minimum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, int minlength) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("minlength"), b.Const(minlength));
    }


    /// <summary>
    /// <para> The maximum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, Var<int> maxlength) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("maxlength"), maxlength);
    }

    /// <summary>
    /// <para> The maximum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, int maxlength) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("maxlength"), b.Const(maxlength));
    }


    /// <summary>
    /// <para> The input's minimum value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, Var<int> min) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("min"), min);
    }

    /// <summary>
    /// <para> The input's minimum value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, int min) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("min"), b.Const(min));
    }


    /// <summary>
    /// <para> The input's minimum value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, Var<string> min) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("min"), min);
    }

    /// <summary>
    /// <para> The input's minimum value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, string min) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("min"), b.Const(min));
    }


    /// <summary>
    /// <para> The input's maximum value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<int> max) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// <para> The input's maximum value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, int max) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("max"), b.Const(max));
    }


    /// <summary>
    /// <para> The input's maximum value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<string> max) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// <para> The input's maximum value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, string max) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("max"), b.Const(max));
    }


    /// <summary>
    /// <para> Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, Var<int> step) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("step"), step);
    }

    /// <summary>
    /// <para> Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, int step) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("step"), b.Const(step));
    }


    /// <summary>
    /// <para> Specifies the granularity that the value must adhere to, or the special value `any` which means no stepping is implied, allowing any numeric value. Only applies to date and number input types. </para>
    /// </summary>
    public static void SetStepAny<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("step"), b.Const("any"));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeOff<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("off"));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeNone<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("none"));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeOn<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("on"));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeSentences<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("sentences"));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeWords<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("words"));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeCharacters<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), b.Const("characters"));
    }


    /// <summary>
    /// <para> Indicates whether the browser's autocorrect feature is on or off. </para>
    /// </summary>
    public static void SetAutocorrectOff<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocorrect"), b.Const("off"));
    }


    /// <summary>
    /// <para> Indicates whether the browser's autocorrect feature is on or off. </para>
    /// </summary>
    public static void SetAutocorrectOn<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocorrect"), b.Const("on"));
    }


    /// <summary>
    /// <para> Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values. </para>
    /// </summary>
    public static void SetAutocomplete<T>(this PropsBuilder<T> b, Var<string> autocomplete) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), autocomplete);
    }

    /// <summary>
    /// <para> Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values. </para>
    /// </summary>
    public static void SetAutocomplete<T>(this PropsBuilder<T> b, string autocomplete) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const(autocomplete));
    }


    /// <summary>
    /// <para> Indicates that the input should receive focus on page load. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autofocus"), b.Const(true));
    }


    /// <summary>
    /// <para> Indicates that the input should receive focus on page load. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b, Var<bool> autofocus) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autofocus"), autofocus);
    }

    /// <summary>
    /// <para> Indicates that the input should receive focus on page load. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b, bool autofocus) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("autofocus"), b.Const(autofocus));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("enter"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("done"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("go"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("next"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("previous"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("search"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("send"));
    }


    /// <summary>
    /// <para> Enables spell checking on the input. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("spellcheck"), b.Const(true));
    }


    /// <summary>
    /// <para> Enables spell checking on the input. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b, Var<bool> spellcheck) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("spellcheck"), spellcheck);
    }

    /// <summary>
    /// <para> Enables spell checking on the input. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b, bool spellcheck) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("spellcheck"), b.Const(spellcheck));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeNone<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("none"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeText<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("text"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeDecimal<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("decimal"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeNumeric<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("numeric"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeTel<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("tel"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeSearch<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("search"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeEmail<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("email"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeUrl<T>(this PropsBuilder<T> b) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("url"));
    }


    /// <summary>
    /// <para> Gets or sets the current value as a `Date` object. Returns `null` if the value can't be converted. This will use the native `&lt;input type="{{type}}"&gt;` implementation and may result in an error. </para>
    /// </summary>
    public static void SetValueAsDate<T>(this PropsBuilder<T> b, Var<object> valueAsDate) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("valueAsDate"), valueAsDate);
    }

    /// <summary>
    /// <para> Gets or sets the current value as a `Date` object. Returns `null` if the value can't be converted. This will use the native `&lt;input type="{{type}}"&gt;` implementation and may result in an error. </para>
    /// </summary>
    public static void SetValueAsDate<T>(this PropsBuilder<T> b, object valueAsDate) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("valueAsDate"), b.Const(valueAsDate));
    }


    /// <summary>
    /// <para> Gets or sets the current value as a number. Returns `NaN` if the value can't be converted. </para>
    /// </summary>
    public static void SetValueAsNumber<T>(this PropsBuilder<T> b, Var<int> valueAsNumber) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("valueAsNumber"), valueAsNumber);
    }

    /// <summary>
    /// <para> Gets or sets the current value as a number. Returns `NaN` if the value can't be converted. </para>
    /// </summary>
    public static void SetValueAsNumber<T>(this PropsBuilder<T> b, int valueAsNumber) where T: SlInput
    {
        b.SetProperty(b.Props, b.Const("valueAsNumber"), b.Const(valueAsNumber));
    }


    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the clear button is activated. </para>
    /// </summary>
    public static void OnSlClear<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-clear", action);
    }
    /// <summary>
    /// <para> Emitted when the clear button is activated. </para>
    /// </summary>
    public static void OnSlClear<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-clear", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the clear button is activated. </para>
    /// </summary>
    public static void OnSlClear<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-clear", action);
    }
    /// <summary>
    /// <para> Emitted when the clear button is activated. </para>
    /// </summary>
    public static void OnSlClear<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-clear", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlInput
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

