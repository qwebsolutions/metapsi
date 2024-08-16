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
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Content to display at the trailing edge of the textarea. (EXPERIMENTAL) </para>
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// <para> The label text to associate with the textarea. Use the `labelPlacement` property to control where the label is placed relative to the textarea. Use this if you need to render a label with custom HTML. (EXPERIMENTAL) </para>
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// <para> Content to display at the leading edge of the textarea. (EXPERIMENTAL) </para>
        /// </summary>
        public const string Start = "start";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Returns the native `&lt;textarea&gt;` element used under the hood. </para>
        /// <para> () =&gt; Promise&lt;HTMLTextAreaElement&gt; </para>
        /// </summary>
        public const string GetInputElement = "getInputElement";
        /// <summary>
        /// <para> Sets focus on the native `textarea` in `ion-textarea`. Use this method instead of the global `textarea.focus()`.  See [managing focus](/docs/developing/managing-focus) for more information. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
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
    /// <para> If `true`, the textarea container will grow and shrink based on the contents of the textarea. </para>
    /// </summary>
    public static void SetAutoGrow(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("auto-grow", "");
    }

    /// <summary>
    /// <para> If `true`, the textarea container will grow and shrink based on the contents of the textarea. </para>
    /// </summary>
    public static void SetAutoGrow(this AttributesBuilder<IonTextarea> b,bool autoGrow)
    {
        if (autoGrow) b.SetAttribute("auto-grow", "");
    }

    /// <summary>
    /// <para> Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`. </para>
    /// </summary>
    public static void SetAutocapitalize(this AttributesBuilder<IonTextarea> b,string autocapitalize)
    {
        b.SetAttribute("autocapitalize", autocapitalize);
    }

    /// <summary>
    /// <para> Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information. </para>
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// <para> Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information. </para>
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<IonTextarea> b,bool autofocus)
    {
        if (autofocus) b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// <para> If `true`, the value will be cleared after focus upon edit. </para>
    /// </summary>
    public static void SetClearOnEdit(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("clear-on-edit", "");
    }

    /// <summary>
    /// <para> If `true`, the value will be cleared after focus upon edit. </para>
    /// </summary>
    public static void SetClearOnEdit(this AttributesBuilder<IonTextarea> b,bool clearOnEdit)
    {
        if (clearOnEdit) b.SetAttribute("clear-on-edit", "");
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonTextarea> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> The visible width of the text control, in average character widths. If it is specified, it must be a positive integer. </para>
    /// </summary>
    public static void SetCols(this AttributesBuilder<IonTextarea> b,string cols)
    {
        b.SetAttribute("cols", cols);
    }

    /// <summary>
    /// <para> If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly. </para>
    /// </summary>
    public static void SetCounter(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("counter", "");
    }

    /// <summary>
    /// <para> If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly. </para>
    /// </summary>
    public static void SetCounter(this AttributesBuilder<IonTextarea> b,bool counter)
    {
        if (counter) b.SetAttribute("counter", "");
    }

    /// <summary>
    /// <para> Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke. </para>
    /// </summary>
    public static void SetDebounce(this AttributesBuilder<IonTextarea> b,string debounce)
    {
        b.SetAttribute("debounce", debounce);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the textarea. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the textarea. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonTextarea> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhint(this AttributesBuilder<IonTextarea> b,string enterkeyhint)
    {
        b.SetAttribute("enterkeyhint", enterkeyhint);
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintDone(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "done");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintEnter(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "enter");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintGo(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "go");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintNext(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "next");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintPrevious(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "previous");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintSearch(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "search");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintSend(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// <para> Text that is placed under the textarea and displayed when an error is detected. </para>
    /// </summary>
    public static void SetErrorText(this AttributesBuilder<IonTextarea> b,string errorText)
    {
        b.SetAttribute("error-text", errorText);
    }

    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFill(this AttributesBuilder<IonTextarea> b,string fill)
    {
        b.SetAttribute("fill", fill);
    }

    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFillOutline(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("fill", "outline");
    }

    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFillSolid(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// <para> Text that is placed under the textarea and displayed when no error is detected. </para>
    /// </summary>
    public static void SetHelperText(this AttributesBuilder<IonTextarea> b,string helperText)
    {
        b.SetAttribute("helper-text", helperText);
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmode(this AttributesBuilder<IonTextarea> b,string inputmode)
    {
        b.SetAttribute("inputmode", inputmode);
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeDecimal(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "decimal");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeEmail(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "email");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeNone(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "none");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeNumeric(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "numeric");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeSearch(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "search");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeTel(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "tel");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeText(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "text");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeUrl(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// <para> The visible label associated with the textarea.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<IonTextarea> b,string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonTextarea> b,string labelPlacement)
    {
        b.SetAttribute("label-placement", labelPlacement);
    }

    /// <summary>
    /// <para> Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("label-placement", "end");
    }

    /// <summary>
    /// <para> Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }

    /// <summary>
    /// <para> Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementFloating(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("label-placement", "floating");
    }

    /// <summary>
    /// <para> Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }

    /// <summary>
    /// <para> Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// <para> This attribute specifies the maximum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMaxlength(this AttributesBuilder<IonTextarea> b,string maxlength)
    {
        b.SetAttribute("maxlength", maxlength);
    }

    /// <summary>
    /// <para> This attribute specifies the minimum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMinlength(this AttributesBuilder<IonTextarea> b,string minlength)
    {
        b.SetAttribute("minlength", minlength);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonTextarea> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<IonTextarea> b,string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> Instructional text that shows before the input has a value. </para>
    /// </summary>
    public static void SetPlaceholder(this AttributesBuilder<IonTextarea> b,string placeholder)
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// <para> If `true`, the user cannot modify the value. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot modify the value. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonTextarea> b,bool @readonly)
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> If `true`, the user must fill in a value before submitting a form. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> If `true`, the user must fill in a value before submitting a form. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<IonTextarea> b,bool required)
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> The number of visible text lines for the control. </para>
    /// </summary>
    public static void SetRows(this AttributesBuilder<IonTextarea> b,string rows)
    {
        b.SetAttribute("rows", rows);
    }

    /// <summary>
    /// <para> The shape of the textarea. If "round" it will have an increased border radius. </para>
    /// </summary>
    public static void SetShape(this AttributesBuilder<IonTextarea> b,string shape)
    {
        b.SetAttribute("shape", shape);
    }

    /// <summary>
    /// <para> The shape of the textarea. If "round" it will have an increased border radius. </para>
    /// </summary>
    public static void SetShapeRound(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// <para> If `true`, the element will have its spelling and grammar checked. </para>
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// <para> If `true`, the element will have its spelling and grammar checked. </para>
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonTextarea> b,bool spellcheck)
    {
        if (spellcheck) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// <para> The value of the textarea. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonTextarea> b,string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> Indicates how the control wraps text. </para>
    /// </summary>
    public static void SetWrap(this AttributesBuilder<IonTextarea> b,string wrap)
    {
        b.SetAttribute("wrap", wrap);
    }

    /// <summary>
    /// <para> Indicates how the control wraps text. </para>
    /// </summary>
    public static void SetWrapHard(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("wrap", "hard");
    }

    /// <summary>
    /// <para> Indicates how the control wraps text. </para>
    /// </summary>
    public static void SetWrapOff(this AttributesBuilder<IonTextarea> b)
    {
        b.SetAttribute("wrap", "off");
    }

    /// <summary>
    /// <para> Indicates how the control wraps text. </para>
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
    /// <para> If `true`, the textarea container will grow and shrink based on the contents of the textarea. </para>
    /// </summary>
    public static void SetAutoGrow<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoGrow"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the textarea container will grow and shrink based on the contents of the textarea. </para>
    /// </summary>
    public static void SetAutoGrow<T>(this PropsBuilder<T> b, Var<bool> autoGrow) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoGrow"), autoGrow);
    }

    /// <summary>
    /// <para> If `true`, the textarea container will grow and shrink based on the contents of the textarea. </para>
    /// </summary>
    public static void SetAutoGrow<T>(this PropsBuilder<T> b, bool autoGrow) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoGrow"), b.Const(autoGrow));
    }


    /// <summary>
    /// <para> Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`. </para>
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, Var<string> autocapitalize) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), autocapitalize);
    }

    /// <summary>
    /// <para> Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`. </para>
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, string autocapitalize) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const(autocapitalize));
    }


    /// <summary>
    /// <para> Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autofocus"), b.Const(true));
    }


    /// <summary>
    /// <para> Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b, Var<bool> autofocus) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autofocus"), autofocus);
    }

    /// <summary>
    /// <para> Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b, bool autofocus) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autofocus"), b.Const(autofocus));
    }


    /// <summary>
    /// <para> If `true`, the value will be cleared after focus upon edit. </para>
    /// </summary>
    public static void SetClearOnEdit<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("clearOnEdit"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the value will be cleared after focus upon edit. </para>
    /// </summary>
    public static void SetClearOnEdit<T>(this PropsBuilder<T> b, Var<bool> clearOnEdit) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("clearOnEdit"), clearOnEdit);
    }

    /// <summary>
    /// <para> If `true`, the value will be cleared after focus upon edit. </para>
    /// </summary>
    public static void SetClearOnEdit<T>(this PropsBuilder<T> b, bool clearOnEdit) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("clearOnEdit"), b.Const(clearOnEdit));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The visible width of the text control, in average character widths. If it is specified, it must be a positive integer. </para>
    /// </summary>
    public static void SetCols<T>(this PropsBuilder<T> b, Var<int> cols) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("cols"), cols);
    }

    /// <summary>
    /// <para> The visible width of the text control, in average character widths. If it is specified, it must be a positive integer. </para>
    /// </summary>
    public static void SetCols<T>(this PropsBuilder<T> b, int cols) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("cols"), b.Const(cols));
    }


    /// <summary>
    /// <para> If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly. </para>
    /// </summary>
    public static void SetCounter<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("counter"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly. </para>
    /// </summary>
    public static void SetCounter<T>(this PropsBuilder<T> b, Var<bool> counter) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("counter"), counter);
    }

    /// <summary>
    /// <para> If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly. </para>
    /// </summary>
    public static void SetCounter<T>(this PropsBuilder<T> b, bool counter) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("counter"), b.Const(counter));
    }


    /// <summary>
    /// <para> A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetCounterFormatter<T>(this PropsBuilder<T> b, Var<System.Func<int,int,string>> counterFormatter) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<int,int,string>>("counterFormatter"), counterFormatter);
    }

    /// <summary>
    /// <para> A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetCounterFormatter<T>(this PropsBuilder<T> b, System.Func<int,int,string> counterFormatter) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<int,int,string>>("counterFormatter"), b.Const(counterFormatter));
    }


    /// <summary>
    /// <para> Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke. </para>
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, Var<int> debounce) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), debounce);
    }

    /// <summary>
    /// <para> Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke. </para>
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, int debounce) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), b.Const(debounce));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the textarea. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the textarea. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the textarea. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("done"));
    }


    /// <summary>
    /// <para> Text that is placed under the textarea and displayed when an error is detected. </para>
    /// </summary>
    public static void SetErrorText<T>(this PropsBuilder<T> b, Var<string> errorText) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), errorText);
    }

    /// <summary>
    /// <para> Text that is placed under the textarea and displayed when an error is detected. </para>
    /// </summary>
    public static void SetErrorText<T>(this PropsBuilder<T> b, string errorText) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), b.Const(errorText));
    }


    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFillOutline<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), b.Const("outline"));
    }


    /// <summary>
    /// <para> Text that is placed under the textarea and displayed when no error is detected. </para>
    /// </summary>
    public static void SetHelperText<T>(this PropsBuilder<T> b, Var<string> helperText) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), helperText);
    }

    /// <summary>
    /// <para> Text that is placed under the textarea and displayed when no error is detected. </para>
    /// </summary>
    public static void SetHelperText<T>(this PropsBuilder<T> b, string helperText) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), b.Const(helperText));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeDecimal<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("decimal"));
    }


    /// <summary>
    /// <para> The visible label associated with the textarea.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> The visible label associated with the textarea.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> Where to place the label relative to the textarea. `"start"`: The label will appear to the left of the textarea in LTR and to the right in RTL. `"end"`: The label will appear to the right of the textarea in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the textarea when the textarea is focused or it has a value. Otherwise it will appear on top of the textarea. `"stacked"`: The label will appear smaller and above the textarea regardless even when the textarea is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("end"));
    }


    /// <summary>
    /// <para> This attribute specifies the maximum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, Var<int> maxlength) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), maxlength);
    }

    /// <summary>
    /// <para> This attribute specifies the maximum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, int maxlength) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), b.Const(maxlength));
    }


    /// <summary>
    /// <para> This attribute specifies the minimum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, Var<int> minlength) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), minlength);
    }

    /// <summary>
    /// <para> This attribute specifies the minimum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, int minlength) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), b.Const(minlength));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> Instructional text that shows before the input has a value. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, Var<string> placeholder) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), placeholder);
    }

    /// <summary>
    /// <para> Instructional text that shows before the input has a value. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, string placeholder) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(placeholder));
    }


    /// <summary>
    /// <para> If `true`, the user cannot modify the value. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot modify the value. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, Var<bool> @readonly) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), @readonly);
    }

    /// <summary>
    /// <para> If `true`, the user cannot modify the value. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, bool @readonly) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), b.Const(@readonly));
    }


    /// <summary>
    /// <para> If `true`, the user must fill in a value before submitting a form. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user must fill in a value before submitting a form. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, Var<bool> required) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), required);
    }

    /// <summary>
    /// <para> If `true`, the user must fill in a value before submitting a form. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, bool required) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(required));
    }


    /// <summary>
    /// <para> The number of visible text lines for the control. </para>
    /// </summary>
    public static void SetRows<T>(this PropsBuilder<T> b, Var<int> rows) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("rows"), rows);
    }

    /// <summary>
    /// <para> The number of visible text lines for the control. </para>
    /// </summary>
    public static void SetRows<T>(this PropsBuilder<T> b, int rows) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("rows"), b.Const(rows));
    }


    /// <summary>
    /// <para> The shape of the textarea. If "round" it will have an increased border radius. </para>
    /// </summary>
    public static void SetShapeRound<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("shape"), b.Const("round"));
    }


    /// <summary>
    /// <para> If `true`, the element will have its spelling and grammar checked. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the element will have its spelling and grammar checked. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b, Var<bool> spellcheck) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), spellcheck);
    }

    /// <summary>
    /// <para> If `true`, the element will have its spelling and grammar checked. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b, bool spellcheck) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), b.Const(spellcheck));
    }


    /// <summary>
    /// <para> The value of the textarea. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The value of the textarea. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Indicates how the control wraps text. </para>
    /// </summary>
    public static void SetWrapHard<T>(this PropsBuilder<T> b) where T: IonTextarea
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("wrap"), b.Const("hard"));
    }


    /// <summary>
    /// <para> Emitted when the input loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, FocusEvent>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionBlur", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the input loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<FocusEvent>, Var<TModel>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionBlur", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> The `ionChange` event is fired when the user modifies the textarea's value. Unlike the `ionInput` event, the `ionChange` event is fired when the element loses focus after its value has been modified. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, TextareaChangeEventDetail>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> The `ionChange` event is fired when the user modifies the textarea's value. Unlike the `ionInput` event, the `ionChange` event is fired when the element loses focus after its value has been modified. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TextareaChangeEventDetail>, Var<TModel>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the input has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, FocusEvent>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionFocus", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the input has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<FocusEvent>, Var<TModel>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionFocus", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> The `ionInput` event is fired each time the user modifies the textarea's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the textarea's value. This typically happens for each keystroke as the user types.  When `clearOnEdit` is enabled, the `ionInput` event will be fired when the user clears the textarea by performing a keydown event. </para>
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, TextareaInputEventDetail>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionInput", action, "detail");
    }
    /// <summary>
    /// <para> The `ionInput` event is fired each time the user modifies the textarea's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the textarea's value. This typically happens for each keystroke as the user types.  When `clearOnEdit` is enabled, the `ionInput` event will be fired when the user clears the textarea by performing a keydown event. </para>
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TextareaInputEventDetail>, Var<TModel>> action) where TComponent: IonTextarea
    {
        b.OnEventAction("onionInput", b.MakeAction(action), "detail");
    }

}

