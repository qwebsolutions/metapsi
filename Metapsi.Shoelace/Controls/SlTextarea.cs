using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlTextarea
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The textarea's label. Alternatively, you can use the `label` attribute. </para>
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// <para> Text that describes how to use the input. Alternatively, you can use the `help-text` attribute. </para>
        /// </summary>
        public const string HelpText = "help-text";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Sets focus on the textarea. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the textarea. </para>
        /// </summary>
        public const string Blur = "blur";
        /// <summary>
        /// <para> Selects all the text in the textarea. </para>
        /// </summary>
        public const string Select = "select";
        /// <summary>
        /// <para> Gets or sets the textarea's scroll position. </para>
        /// </summary>
        public const string ScrollPosition = "scrollPosition";
        /// <summary>
        /// <para> Sets the start and end positions of the text selection (0-based). </para>
        /// </summary>
        public const string SetSelectionRange = "setSelectionRange";
        /// <summary>
        /// <para> Replaces a range of text with a new string. </para>
        /// </summary>
        public const string SetRangeText = "setRangeText";
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

public static partial class SlTextareaControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTextarea(this HtmlBuilder b, Action<AttributesBuilder<SlTextarea>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-textarea", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTextarea(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-textarea", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTextarea(this HtmlBuilder b, Action<AttributesBuilder<SlTextarea>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-textarea", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTextarea(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-textarea", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The name of the textarea, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlTextarea> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The current value of the textarea, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlTextarea> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The textarea's size. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlTextarea> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The textarea's size. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> The textarea's size. </para>
    /// </summary>
    public static void SetSizeMedium(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// <para> The textarea's size. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> Draws a filled textarea. </para>
    /// </summary>
    public static void SetFilled(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("filled", "");
    }

    /// <summary>
    /// <para> Draws a filled textarea. </para>
    /// </summary>
    public static void SetFilled(this AttributesBuilder<SlTextarea> b, bool filled)
    {
        if (filled) b.SetAttribute("filled", "");
    }

    /// <summary>
    /// <para> The textarea's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlTextarea> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> The textarea's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText(this AttributesBuilder<SlTextarea> b, string helpText)
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// <para> Placeholder text to show as a hint when the input is empty. </para>
    /// </summary>
    public static void SetPlaceholder(this AttributesBuilder<SlTextarea> b, string placeholder)
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// <para> The number of rows to display by default. </para>
    /// </summary>
    public static void SetRows(this AttributesBuilder<SlTextarea> b, string rows)
    {
        b.SetAttribute("rows", rows);
    }

    /// <summary>
    /// <para> Controls how the textarea can be resized. </para>
    /// </summary>
    public static void SetResize(this AttributesBuilder<SlTextarea> b, string resize)
    {
        b.SetAttribute("resize", resize);
    }

    /// <summary>
    /// <para> Controls how the textarea can be resized. </para>
    /// </summary>
    public static void SetResizeNone(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("resize", "none");
    }

    /// <summary>
    /// <para> Controls how the textarea can be resized. </para>
    /// </summary>
    public static void SetResizeVertical(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("resize", "vertical");
    }

    /// <summary>
    /// <para> Controls how the textarea can be resized. </para>
    /// </summary>
    public static void SetResizeAuto(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("resize", "auto");
    }

    /// <summary>
    /// <para> Disables the textarea. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the textarea. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlTextarea> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Makes the textarea readonly. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> Makes the textarea readonly. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<SlTextarea> b, bool @readonly)
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm(this AttributesBuilder<SlTextarea> b, string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// <para> Makes the textarea a required field. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> Makes the textarea a required field. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlTextarea> b, bool required)
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> The minimum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMinlength(this AttributesBuilder<SlTextarea> b, string minlength)
    {
        b.SetAttribute("minlength", minlength);
    }

    /// <summary>
    /// <para> The maximum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMaxlength(this AttributesBuilder<SlTextarea> b, string maxlength)
    {
        b.SetAttribute("maxlength", maxlength);
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalize(this AttributesBuilder<SlTextarea> b, string autocapitalize)
    {
        b.SetAttribute("autocapitalize", autocapitalize);
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeOff(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("autocapitalize", "off");
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeNone(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("autocapitalize", "none");
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeOn(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("autocapitalize", "on");
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeSentences(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("autocapitalize", "sentences");
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeWords(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("autocapitalize", "words");
    }

    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeCharacters(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("autocapitalize", "characters");
    }

    /// <summary>
    /// <para> Indicates whether the browser's autocorrect feature is on or off. </para>
    /// </summary>
    public static void SetAutocorrect(this AttributesBuilder<SlTextarea> b, string autocorrect)
    {
        b.SetAttribute("autocorrect", autocorrect);
    }

    /// <summary>
    /// <para> Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values. </para>
    /// </summary>
    public static void SetAutocomplete(this AttributesBuilder<SlTextarea> b, string autocomplete)
    {
        b.SetAttribute("autocomplete", autocomplete);
    }

    /// <summary>
    /// <para> Indicates that the input should receive focus on page load. </para>
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// <para> Indicates that the input should receive focus on page load. </para>
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<SlTextarea> b, bool autofocus)
    {
        if (autofocus) b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhint(this AttributesBuilder<SlTextarea> b, string enterkeyhint)
    {
        b.SetAttribute("enterkeyhint", enterkeyhint);
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintEnter(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "enter");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintDone(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "done");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintGo(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "go");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintNext(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "next");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintPrevious(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "previous");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintSearch(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "search");
    }

    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintSend(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// <para> Enables spell checking on the textarea. </para>
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// <para> Enables spell checking on the textarea. </para>
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<SlTextarea> b, bool spellcheck)
    {
        if (spellcheck) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmode(this AttributesBuilder<SlTextarea> b, string inputmode)
    {
        b.SetAttribute("inputmode", inputmode);
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeNone(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("inputmode", "none");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeText(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("inputmode", "text");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeDecimal(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("inputmode", "decimal");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeNumeric(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("inputmode", "numeric");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeTel(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("inputmode", "tel");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeSearch(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("inputmode", "search");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeEmail(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("inputmode", "email");
    }

    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeUrl(this AttributesBuilder<SlTextarea> b)
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTextarea(this LayoutBuilder b, Action<PropsBuilder<SlTextarea>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-textarea", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTextarea(this LayoutBuilder b, Action<PropsBuilder<SlTextarea>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-textarea", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTextarea(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-textarea", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTextarea(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-textarea", children);
    }
    /// <summary>
    /// <para> The name of the textarea, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the textarea, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The current value of the textarea, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The current value of the textarea, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The textarea's size. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> The textarea's size. </para>
    /// </summary>
    public static void SetSizeMedium<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The textarea's size. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> Draws a filled textarea. </para>
    /// </summary>
    public static void SetFilled<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("filled"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws a filled textarea. </para>
    /// </summary>
    public static void SetFilled<T>(this PropsBuilder<T> b, Var<bool> filled) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("filled"), filled);
    }

    /// <summary>
    /// <para> Draws a filled textarea. </para>
    /// </summary>
    public static void SetFilled<T>(this PropsBuilder<T> b, bool filled) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("filled"), b.Const(filled));
    }


    /// <summary>
    /// <para> The textarea's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> The textarea's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> The textarea's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, Var<string> helpText) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), helpText);
    }

    /// <summary>
    /// <para> The textarea's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, string helpText) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), b.Const(helpText));
    }


    /// <summary>
    /// <para> Placeholder text to show as a hint when the input is empty. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, Var<string> placeholder) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), placeholder);
    }

    /// <summary>
    /// <para> Placeholder text to show as a hint when the input is empty. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, string placeholder) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(placeholder));
    }


    /// <summary>
    /// <para> The number of rows to display by default. </para>
    /// </summary>
    public static void SetRows<T>(this PropsBuilder<T> b, Var<int> rows) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("rows"), rows);
    }

    /// <summary>
    /// <para> The number of rows to display by default. </para>
    /// </summary>
    public static void SetRows<T>(this PropsBuilder<T> b, int rows) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("rows"), b.Const(rows));
    }


    /// <summary>
    /// <para> Controls how the textarea can be resized. </para>
    /// </summary>
    public static void SetResizeNone<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("resize"), b.Const("none"));
    }


    /// <summary>
    /// <para> Controls how the textarea can be resized. </para>
    /// </summary>
    public static void SetResizeVertical<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("resize"), b.Const("vertical"));
    }


    /// <summary>
    /// <para> Controls how the textarea can be resized. </para>
    /// </summary>
    public static void SetResizeAuto<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("resize"), b.Const("auto"));
    }


    /// <summary>
    /// <para> Disables the textarea. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the textarea. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the textarea. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Makes the textarea readonly. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), b.Const(true));
    }


    /// <summary>
    /// <para> Makes the textarea readonly. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, Var<bool> @readonly) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), @readonly);
    }

    /// <summary>
    /// <para> Makes the textarea readonly. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, bool @readonly) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), b.Const(@readonly));
    }


    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<string> form) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), form);
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, string form) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(form));
    }


    /// <summary>
    /// <para> Makes the textarea a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(true));
    }


    /// <summary>
    /// <para> Makes the textarea a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, Var<bool> required) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), required);
    }

    /// <summary>
    /// <para> Makes the textarea a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, bool required) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(required));
    }


    /// <summary>
    /// <para> The minimum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, Var<int> minlength) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), minlength);
    }

    /// <summary>
    /// <para> The minimum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, int minlength) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), b.Const(minlength));
    }


    /// <summary>
    /// <para> The maximum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, Var<int> maxlength) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), maxlength);
    }

    /// <summary>
    /// <para> The maximum length of input that will be considered valid. </para>
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, int maxlength) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), b.Const(maxlength));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeOff<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const("off"));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeNone<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const("none"));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeOn<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const("on"));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeSentences<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const("sentences"));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeWords<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const("words"));
    }


    /// <summary>
    /// <para> Controls whether and how text input is automatically capitalized as it is entered by the user. </para>
    /// </summary>
    public static void SetAutocapitalizeCharacters<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const("characters"));
    }


    /// <summary>
    /// <para> Indicates whether the browser's autocorrect feature is on or off. </para>
    /// </summary>
    public static void SetAutocorrect<T>(this PropsBuilder<T> b, Var<string> autocorrect) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocorrect"), autocorrect);
    }

    /// <summary>
    /// <para> Indicates whether the browser's autocorrect feature is on or off. </para>
    /// </summary>
    public static void SetAutocorrect<T>(this PropsBuilder<T> b, string autocorrect) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocorrect"), b.Const(autocorrect));
    }


    /// <summary>
    /// <para> Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values. </para>
    /// </summary>
    public static void SetAutocomplete<T>(this PropsBuilder<T> b, Var<string> autocomplete) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), autocomplete);
    }

    /// <summary>
    /// <para> Specifies what permission the browser has to provide assistance in filling out form field values. Refer to [this page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for available values. </para>
    /// </summary>
    public static void SetAutocomplete<T>(this PropsBuilder<T> b, string autocomplete) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const(autocomplete));
    }


    /// <summary>
    /// <para> Indicates that the input should receive focus on page load. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autofocus"), b.Const(true));
    }


    /// <summary>
    /// <para> Indicates that the input should receive focus on page load. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b, Var<bool> autofocus) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autofocus"), autofocus);
    }

    /// <summary>
    /// <para> Indicates that the input should receive focus on page load. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b, bool autofocus) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autofocus"), b.Const(autofocus));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("enter"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("done"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("go"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("next"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("previous"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("search"));
    }


    /// <summary>
    /// <para> Used to customize the label or icon of the Enter key on virtual keyboards. </para>
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("send"));
    }


    /// <summary>
    /// <para> Enables spell checking on the textarea. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), b.Const(true));
    }


    /// <summary>
    /// <para> Enables spell checking on the textarea. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b, Var<bool> spellcheck) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), spellcheck);
    }

    /// <summary>
    /// <para> Enables spell checking on the textarea. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b, bool spellcheck) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), b.Const(spellcheck));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeNone<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("none"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeText<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("text"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeDecimal<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("decimal"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeNumeric<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("numeric"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeTel<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("tel"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeSearch<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("search"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeEmail<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("email"));
    }


    /// <summary>
    /// <para> Tells the browser what type of data will be entered by the user, allowing it to display the appropriate virtual keyboard on supportive devices. </para>
    /// </summary>
    public static void SetInputmodeUrl<T>(this PropsBuilder<T> b) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("url"));
    }


    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, Var<string> defaultValue) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultValue"), defaultValue);
    }

    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, string defaultValue) where T: SlTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultValue"), b.Const(defaultValue));
    }


    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when an alteration to the control's value is committed by the user. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTextarea
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

