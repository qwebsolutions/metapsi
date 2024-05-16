using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonTextarea : IonComponent
{
    public IonTextarea() : base("ion-textarea") { }
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
    public static class Method
    {
        /// <summary> 
        /// Returns the native `&lt;textarea&gt;` element used under the hood.
        /// <para>() =&gt; Promise&lt;HTMLTextAreaElement&gt;</para>
        /// </summary>
        public const string GetInputElement = "getInputElement";
        /// <summary> 
        /// Sets focus on the native `textarea` in `ion-textarea`. Use this method instead of the global `textarea.focus()`.  See [managing focus](/docs/developing/managing-focus) for more information.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string SetFocus = "setFocus";
    }
}

public static partial class IonTextareaControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonTextarea(this HtmlBuilder b, Action<AttributesBuilder<IonTextarea>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-textarea", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonTextarea(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-textarea", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the textarea container will grow and shrink based on the contents of the textarea.
    /// </summary>
    public static void SetAutoGrow(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("auto-grow", "");
    }
    /// <summary>
    /// If `true`, the textarea container will grow and shrink based on the contents of the textarea.
    /// </summary>
    public static void SetAutoGrow(this AttributesBuilder<IonTextarea> b, bool value)
    {
        if (value) b.SetAttribute("auto-grow", "");
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("autocapitalize", value);
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("autofocus", "");
    }
    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<IonTextarea> b, bool value)
    {
        if (value) b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit.
    /// </summary>
    public static void SetClearOnEdit(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("clear-on-edit", "");
    }
    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit.
    /// </summary>
    public static void SetClearOnEdit(this AttributesBuilder<IonTextarea> b, bool value)
    {
        if (value) b.SetAttribute("clear-on-edit", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// The visible width of the text control, in average character widths. If it is specified, it must be a positive integer.
    /// </summary>
    public static void SetCols(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("cols", value);
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("counter", "");
    }
    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter(this AttributesBuilder<IonTextarea> b, bool value)
    {
        if (value) b.SetAttribute("counter", "");
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("debounce", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the textarea.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the textarea.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonTextarea> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhint(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("enterkeyhint", value);
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "done");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "enter");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "go");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "next");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "previous");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "search");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// Text that is placed under the textarea and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("error-text", value);
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFill(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("fill", value);
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("fill", "outline");
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// Text that is placed under the textarea and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("helper-text", value);
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmode(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("inputmode", value);
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "decimal");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "email");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "none");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "numeric");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "search");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "tel");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "text");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// The visible label associated with the textarea.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("label", value);
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("label-placement", value);
    }
    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("label-placement", "end");
    }
    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }
    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFloating(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("label-placement", "floating");
    }
    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }
    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// This attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("maxlength", value);
    }

    /// <summary>
    /// This attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("minlength", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("name", value);
    }

    /// <summary>
    /// Instructional text that shows before the input has a value.
    /// </summary>
    public static void SetPlaceholder(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("placeholder", value);
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("readonly", "");
    }
    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonTextarea> b, bool value)
    {
        if (value) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("required", "");
    }
    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired(this AttributesBuilder<IonTextarea> b, bool value)
    {
        if (value) b.SetAttribute("required", "");
    }

    /// <summary>
    /// The number of visible text lines for the control.
    /// </summary>
    public static void SetRows(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("rows", value);
    }

    /// <summary>
    /// The shape of the textarea. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShape(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("shape", value);
    }
    /// <summary>
    /// The shape of the textarea. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("spellcheck", "");
    }
    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonTextarea> b, bool value)
    {
        if (value) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// The value of the textarea.
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrap(this AttributesBuilder<IonTextarea> b, string value)
    {
        b.SetAttribute("wrap", value);
    }
    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapHard(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("wrap", "hard");
    }
    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapOff(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("wrap", "off");
    }
    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapSoft(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("wrap", "soft");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTextarea(this LayoutBuilder b, Action<PropsBuilder<IonTextarea>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-textarea", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTextarea(this LayoutBuilder b, Action<PropsBuilder<IonTextarea>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-textarea", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTextarea(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-textarea", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTextarea(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-textarea", children);
    }
    /// <summary>
    /// If `true`, the textarea container will grow and shrink based on the contents of the textarea.
    /// </summary>
    public static void SetAutoGrow<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("autoGrow"), b.Const(true));
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), value);
    }
    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, string value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const(value));
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("autofocus"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit.
    /// </summary>
    public static void SetClearOnEdit<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("clearOnEdit"), b.Const(true));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// The visible width of the text control, in average character widths. If it is specified, it must be a positive integer.
    /// </summary>
    public static void SetCols<T>(this PropsBuilder<T> b, Var<int> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("cols"), value);
    }
    /// <summary>
    /// The visible width of the text control, in average character widths. If it is specified, it must be a positive integer.
    /// </summary>
    public static void SetCols<T>(this PropsBuilder<T> b, int value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("cols"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("counter"), b.Const(true));
    }

    /// <summary>
    /// A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCounterFormatter<T>(this PropsBuilder<T> b, Var<Func<int,int,string>> f) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,int,string>>("counterFormatter"), f);
    }
    /// <summary>
    /// A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCounterFormatter<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<int>,Var<int>,Var<string>> f) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,int,string>>("counterFormatter"), b.Def(f));
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, Var<int> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), value);
    }
    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, int value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the textarea.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("done"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("enter"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("go"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("next"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("previous"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("search"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("send"));
    }

    /// <summary>
    /// Text that is placed under the textarea and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), value);
    }
    /// <summary>
    /// Text that is placed under the textarea and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this PropsBuilder<T> b, string value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), b.Const(value));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("outline"));
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("solid"));
    }

    /// <summary>
    /// Text that is placed under the textarea and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), value);
    }
    /// <summary>
    /// Text that is placed under the textarea and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this PropsBuilder<T> b, string value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), b.Const(value));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("decimal"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("email"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("none"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("numeric"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("search"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("tel"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("text"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// The visible label associated with the textarea.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The visible label associated with the textarea.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("end"));
    }
    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("fixed"));
    }
    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFloating<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("floating"));
    }
    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("stacked"));
    }
    /// <summary>
    /// Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStart<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// This attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, Var<int> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), value);
    }
    /// <summary>
    /// This attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, int value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), b.Const(value));
    }

    /// <summary>
    /// This attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, Var<int> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), value);
    }
    /// <summary>
    /// This attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, int value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// Instructional text that shows before the input has a value.
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), value);
    }
    /// <summary>
    /// Instructional text that shows before the input has a value.
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, string value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("readonly"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("required"), b.Const(true));
    }

    /// <summary>
    /// The number of visible text lines for the control.
    /// </summary>
    public static void SetRows<T>(this PropsBuilder<T> b, Var<int> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("rows"), value);
    }
    /// <summary>
    /// The number of visible text lines for the control.
    /// </summary>
    public static void SetRows<T>(this PropsBuilder<T> b, int value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("rows"), b.Const(value));
    }

    /// <summary>
    /// The shape of the textarea. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("shape"), b.Const("round"));
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("spellcheck"), b.Const(true));
    }

    /// <summary>
    /// The value of the textarea.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The value of the textarea.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapHard<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("wrap"), b.Const("hard"));
    }
    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapOff<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("wrap"), b.Const("off"));
    }
    /// <summary>
    /// Indicates how the control wraps text.
    /// </summary>
    public static void SetWrapSoft<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, DynamicProperty.String("wrap"), b.Const("soft"));
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, FocusEvent>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionBlur", action, "detail");
    }
    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<FocusEvent>, Var<TModel>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionBlur", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the textarea's value. Unlike the `ionInput` event, the `ionChange` event is fired when the element loses focus after its value has been modified.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, TextareaChangeEventDetail>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// The `ionChange` event is fired when the user modifies the textarea's value. Unlike the `ionInput` event, the `ionChange` event is fired when the element loses focus after its value has been modified.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TextareaChangeEventDetail>, Var<TModel>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, FocusEvent>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionFocus", action, "detail");
    }
    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<FocusEvent>, Var<TModel>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionFocus", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the textarea's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the textarea's value. This typically happens for each keystroke as the user types.  When `clearOnEdit` is enabled, the `ionInput` event will be fired when the user clears the textarea by performing a keydown event.
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, TextareaInputEventDetail>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionInput", action, "detail");
    }
    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the textarea's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the textarea's value. This typically happens for each keystroke as the user types.  When `clearOnEdit` is enabled, the `ionInput` event will be fired when the user clears the textarea by performing a keydown event.
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TextareaInputEventDetail>, Var<TModel>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionInput", b.MakeAction(action), "detail");
    }

}

