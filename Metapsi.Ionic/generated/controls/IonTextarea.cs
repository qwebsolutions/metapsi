using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonTextarea
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Content to display at the trailing edge of the textarea. (EXPERIMENTAL)
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// The label text to associate with the textarea. Use the `labelPlacement` property to control where the label is placed relative to the textarea. Use this if you need to render a label with custom HTML. (EXPERIMENTAL)
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// Content to display at the leading edge of the textarea. (EXPERIMENTAL)
        /// </summary>
        public const string Start = "start";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Returns the native `&lt;textarea&gt;` element used under the hood.
        /// </summary>
        public const string GetInputElement = "getInputElement";
        /// <summary>
        /// Sets focus on the native `textarea` in `ion-textarea`. Use this method instead of the global `textarea.focus()`.  See [managing focus](/docs/developing/managing-focus) for more information.
        /// </summary>
        public const string SetFocus = "setFocus";
    }
}
/// <summary>
/// Setter extensions of IonTextarea
/// </summary>
public static partial class IonTextareaControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTextarea(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonTextarea>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-textarea", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTextarea(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-textarea", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTextarea(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonTextarea>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-textarea", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTextarea(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-textarea", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the textarea container will grow and shrink based on the contents of the textarea.
    /// </summary>
    public static void SetAutoGrow(this Metapsi.Html.AttributesBuilder<IonTextarea> b, bool autoGrow) 
    {
        if (autoGrow) b.SetAttribute("autoGrow", "");
    }

    /// <summary>
    /// If `true`, the textarea container will grow and shrink based on the contents of the textarea.
    /// </summary>
    public static void SetAutoGrow(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("autoGrow", "");
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string autocapitalize) 
    {
        b.SetAttribute("autocapitalize", autocapitalize);
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus(this Metapsi.Html.AttributesBuilder<IonTextarea> b, bool autofocus) 
    {
        if (autofocus) b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit.
    /// </summary>
    public static void SetClearOnEdit(this Metapsi.Html.AttributesBuilder<IonTextarea> b, bool clearOnEdit) 
    {
        if (clearOnEdit) b.SetAttribute("clearOnEdit", "");
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit.
    /// </summary>
    public static void SetClearOnEdit(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("clearOnEdit", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// The visible width of the text control, in average character widths. If it is specified, it must be a positive integer.
    /// </summary>
    public static void SetCols(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string cols) 
    {
        b.SetAttribute("cols", cols);
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter(this Metapsi.Html.AttributesBuilder<IonTextarea> b, bool counter) 
    {
        if (counter) b.SetAttribute("counter", "");
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("counter", "");
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string debounce) 
    {
        b.SetAttribute("debounce", debounce);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the textarea.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonTextarea> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the textarea.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "done");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "enter");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "go");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "next");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "previous");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "search");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// Text that is placed under the textarea and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string errorText) 
    {
        b.SetAttribute("errorText", errorText);
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("fill", "outline");
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// Text that is placed under the textarea and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string helperText) 
    {
        b.SetAttribute("helperText", helperText);
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("inputmode", "decimal");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("inputmode", "email");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("inputmode", "none");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("inputmode", "numeric");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("inputmode", "search");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("inputmode", "tel");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("inputmode", "text");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// The visible label associated with the textarea.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementEnd(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("labelPlacement", "end");
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFixed(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("labelPlacement", "fixed");
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFloating(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("labelPlacement", "floating");
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStacked(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("labelPlacement", "stacked");
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStart(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("labelPlacement", "start");
    }

    /// <summary>
    /// This attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string maxlength) 
    {
        b.SetAttribute("maxlength", maxlength);
    }

    /// <summary>
    /// This attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string minlength) 
    {
        b.SetAttribute("minlength", minlength);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// Instructional text that shows before the input has a value.
    /// </summary>
    public static void SetPlaceholder(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string placeholder) 
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<IonTextarea> b, bool @readonly) 
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<IonTextarea> b, bool required) 
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// The number of visible text lines for the control.
    /// </summary>
    public static void SetRows(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string rows) 
    {
        b.SetAttribute("rows", rows);
    }

    /// <summary>
    /// The shape of the textarea. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck(this Metapsi.Html.AttributesBuilder<IonTextarea> b, bool spellcheck) 
    {
        if (spellcheck) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// The value of the textarea.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<IonTextarea> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapHard(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("wrap", "hard");
    }

    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapOff(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("wrap", "off");
    }

    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapSoft(this Metapsi.Html.AttributesBuilder<IonTextarea> b) 
    {
        b.SetAttribute("wrap", "soft");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTextarea(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonTextarea>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-textarea", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTextarea(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-textarea", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTextarea(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonTextarea>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-textarea", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTextarea(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-textarea", children);
    }

    /// <summary>
    /// If `true`, the textarea container will grow and shrink based on the contents of the textarea.
    /// </summary>
    public static void SetAutoGrow<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetAutoGrow(b.Const(true));
    }

    /// <summary>
    /// If `true`, the textarea container will grow and shrink based on the contents of the textarea.
    /// </summary>
    public static void SetAutoGrow<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> autoGrow) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("autoGrow"), autoGrow);
    }

    /// <summary>
    /// If `true`, the textarea container will grow and shrink based on the contents of the textarea.
    /// </summary>
    public static void SetAutoGrow<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool autoGrow) where T: IonTextarea
    {
        b.SetAutoGrow(b.Const(autoGrow));
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> autocapitalize) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), autocapitalize);
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this Metapsi.Syntax.PropsBuilder<T> b, string autocapitalize) where T: IonTextarea
    {
        b.SetAutocapitalize(b.Const(autocapitalize));
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetAutofocus(b.Const(true));
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> autofocus) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("autofocus"), autofocus);
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool autofocus) where T: IonTextarea
    {
        b.SetAutofocus(b.Const(autofocus));
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit.
    /// </summary>
    public static void SetClearOnEdit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetClearOnEdit(b.Const(true));
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit.
    /// </summary>
    public static void SetClearOnEdit<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> clearOnEdit) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("clearOnEdit"), clearOnEdit);
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit.
    /// </summary>
    public static void SetClearOnEdit<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool clearOnEdit) where T: IonTextarea
    {
        b.SetClearOnEdit(b.Const(clearOnEdit));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// The visible width of the text control, in average character widths. If it is specified, it must be a positive integer.
    /// </summary>
    public static void SetCols<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> cols) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("cols"), cols);
    }

    /// <summary>
    /// The visible width of the text control, in average character widths. If it is specified, it must be a positive integer.
    /// </summary>
    public static void SetCols<T>(this Metapsi.Syntax.PropsBuilder<T> b, int cols) where T: IonTextarea
    {
        b.SetCols(b.Const(cols));
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetCounter(b.Const(true));
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> counter) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("counter"), counter);
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool counter) where T: IonTextarea
    {
        b.SetCounter(b.Const(counter));
    }

    /// <summary>
    /// A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCounterFormatter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<int, int, string>> counterFormatter) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("counterFormatter"), counterFormatter);
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> debounce) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("debounce"), debounce);
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce<T>(this Metapsi.Syntax.PropsBuilder<T> b, int debounce) where T: IonTextarea
    {
        b.SetDebounce(b.Const(debounce));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the textarea.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the textarea.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the textarea.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonTextarea
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("done"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("enter"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("go"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("next"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("previous"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("search"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("send"));
    }

    /// <summary>
    /// Text that is placed under the textarea and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> errorText) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("errorText"), errorText);
    }

    /// <summary>
    /// Text that is placed under the textarea and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string errorText) where T: IonTextarea
    {
        b.SetErrorText(b.Const(errorText));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const("outline"));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const("solid"));
    }

    /// <summary>
    /// Text that is placed under the textarea and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helperText) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("helperText"), helperText);
    }

    /// <summary>
    /// Text that is placed under the textarea and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helperText) where T: IonTextarea
    {
        b.SetHelperText(b.Const(helperText));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("decimal"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("email"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("none"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("numeric"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("search"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("tel"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("text"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// The visible label associated with the textarea.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The visible label associated with the textarea.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: IonTextarea
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("end"));
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("fixed"));
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFloating<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("floating"));
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("stacked"));
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// This attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> maxlength) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("maxlength"), maxlength);
    }

    /// <summary>
    /// This attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, int maxlength) where T: IonTextarea
    {
        b.SetMaxlength(b.Const(maxlength));
    }

    /// <summary>
    /// This attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> minlength) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("minlength"), minlength);
    }

    /// <summary>
    /// This attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, int minlength) where T: IonTextarea
    {
        b.SetMinlength(b.Const(minlength));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: IonTextarea
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// Instructional text that shows before the input has a value.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> placeholder) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }

    /// <summary>
    /// Instructional text that shows before the input has a value.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, string placeholder) where T: IonTextarea
    {
        b.SetPlaceholder(b.Const(placeholder));
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetReadonly(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @readonly) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("readonly"), @readonly);
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @readonly) where T: IonTextarea
    {
        b.SetReadonly(b.Const(@readonly));
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetRequired(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> required) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool required) where T: IonTextarea
    {
        b.SetRequired(b.Const(required));
    }

    /// <summary>
    /// The number of visible text lines for the control.
    /// </summary>
    public static void SetRows<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> rows) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("rows"), rows);
    }

    /// <summary>
    /// The number of visible text lines for the control.
    /// </summary>
    public static void SetRows<T>(this Metapsi.Syntax.PropsBuilder<T> b, int rows) where T: IonTextarea
    {
        b.SetRows(b.Const(rows));
    }

    /// <summary>
    /// The shape of the textarea. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("round"));
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetSpellcheck(b.Const(true));
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> spellcheck) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("spellcheck"), spellcheck);
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool spellcheck) where T: IonTextarea
    {
        b.SetSpellcheck(b.Const(spellcheck));
    }

    /// <summary>
    /// The value of the textarea.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapHard<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("wrap"), b.Const("hard"));
    }

    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapOff<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("wrap"), b.Const("off"));
    }

    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapSoft<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetProperty(b.Props, b.Const("wrap"), b.Const("soft"));
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonTextarea
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonTextarea
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<FocusEvent>>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the textarea's value. Unlike the `ionInput` event, the `ionChange` event is fired when the element loses focus after its value has been modified.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the textarea's value. Unlike the `ionInput` event, the `ionChange` event is fired when the element loses focus after its value has been modified.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonTextarea
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the textarea's value. Unlike the `ionInput` event, the `ionChange` event is fired when the element loses focus after its value has been modified.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the textarea's value. Unlike the `ionInput` event, the `ionChange` event is fired when the element loses focus after its value has been modified.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonTextarea
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the textarea's value. Unlike the `ionInput` event, the `ionChange` event is fired when the element loses focus after its value has been modified.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<TextareaChangeEventDetail>>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonTextarea
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonTextarea
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<FocusEvent>>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the textarea's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the textarea's value. This typically happens for each keystroke as the user types.  When `clearOnEdit` is enabled, the `ionInput` event will be fired when the user clears the textarea by performing a keydown event.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the textarea's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the textarea's value. This typically happens for each keystroke as the user types.  When `clearOnEdit` is enabled, the `ionInput` event will be fired when the user clears the textarea by performing a keydown event.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonTextarea
    {
        b.OnIonInput(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the textarea's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the textarea's value. This typically happens for each keystroke as the user types.  When `clearOnEdit` is enabled, the `ionInput` event will be fired when the user clears the textarea by performing a keydown event.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the textarea's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the textarea's value. This typically happens for each keystroke as the user types.  When `clearOnEdit` is enabled, the `ionInput` event will be fired when the user clears the textarea by performing a keydown event.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonTextarea
    {
        b.OnIonInput(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the textarea's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the textarea's value. This typically happens for each keystroke as the user types.  When `clearOnEdit` is enabled, the `ionInput` event will be fired when the user clears the textarea by performing a keydown event.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<TextareaInputEventDetail>>> action) where T: IonTextarea
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

}