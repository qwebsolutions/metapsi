using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonInput : IonComponent
{
    public IonInput() : base("ion-input") { }
    public static class Slot
    {
        /// <summary> 
        /// Content to display at the trailing edge of the input. (EXPERIMENTAL)
        /// </summary>
        public const string End = "end";
        /// <summary> 
        /// The label text to associate with the input. Use the `labelPlacement` property to control where the label is placed relative to the input. Use this if you need to render a label with custom HTML. (EXPERIMENTAL)
        /// </summary>
        public const string Label = "label";
        /// <summary> 
        /// Content to display at the leading edge of the input. (EXPERIMENTAL)
        /// </summary>
        public const string Start = "start";
    }
    public static class Method
    {
        /// <summary> 
        /// Returns the native `&lt;input&gt;` element used under the hood.
        /// <para>() =&gt; Promise&lt;HTMLInputElement&gt;</para>
        /// </summary>
        public const string GetInputElement = "getInputElement";
        /// <summary> 
        /// Sets focus on the native `input` in `ion-input`. Use this method instead of the global `input.focus()`.  Developers who wish to focus an input when a page enters should call `setFocus()` in the `ionViewDidEnter()` lifecycle method.  Developers who wish to focus an input when an overlay is presented should call `setFocus` after `didPresent` has resolved.  See [managing focus](/docs/developing/managing-focus) for more information.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string SetFocus = "setFocus";
    }
}

public static partial class IonInputControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonInput(this HtmlBuilder b, Action<AttributesBuilder<IonInput>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-input", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonInput(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-input", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("autocapitalize", value);
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocomplete(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("autocomplete", value);
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "name");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteEmail(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "email");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTel(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteUrl(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "url");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOn(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "on");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOff(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "off");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteHonorificPrefix(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "honorific-prefix");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteGivenName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "given-name");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAdditionalName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "additional-name");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteFamilyName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "family-name");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteHonorificSuffix(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "honorific-suffix");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteNickname(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "nickname");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteUsername(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "username");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteNewPassword(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "new-password");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCurrentPassword(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "current-password");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOneTimeCode(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "one-time-code");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOrganizationTitle(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "organization-title");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOrganization(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "organization");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteStreetAddress(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "street-address");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine1(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-line1");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine2(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-line2");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine3(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-line3");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel4(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-level4");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel3(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-level3");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel2(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-level2");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel1(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-level1");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCountry(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "country");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCountryName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "country-name");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompletePostalCode(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "postal-code");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-name");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcGivenName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-given-name");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcAdditionalName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-additional-name");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcFamilyName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-family-name");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcNumber(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-number");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExp(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-exp");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExpMonth(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-exp-month");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExpYear(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-exp-year");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcCsc(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-csc");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcType(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-type");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTransactionCurrency(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "transaction-currency");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTransactionAmount(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "transaction-amount");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteLanguage(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "language");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBday(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "bday");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayDay(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "bday-day");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayMonth(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "bday-month");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayYear(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "bday-year");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteSex(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "sex");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelCountryCode(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel-country-code");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelNational(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel-national");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelAreaCode(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel-area-code");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelLocal(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel-local");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelExtension(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel-extension");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteImpp(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "impp");
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompletePhoto(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "photo");
    }

    /// <summary>
    /// Whether auto correction should be enabled when the user is entering/editing the text value.
    /// </summary>
    public static void SetAutocorrect(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("autocorrect", value);
    }
    /// <summary>
    /// Whether auto correction should be enabled when the user is entering/editing the text value.
    /// </summary>
    public static void SetAutocorrectOff(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocorrect", "off");
    }
    /// <summary>
    /// Whether auto correction should be enabled when the user is entering/editing the text value.
    /// </summary>
    public static void SetAutocorrectOn(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocorrect", "on");
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autofocus", "");
    }
    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<IonInput> b, bool value)
    {
        if (value) b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input.
    /// </summary>
    public static void SetClearInput(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("clear-input", "");
    }
    /// <summary>
    /// If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input.
    /// </summary>
    public static void SetClearInput(this AttributesBuilder<IonInput> b, bool value)
    {
        if (value) b.SetAttribute("clear-input", "");
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types.
    /// </summary>
    public static void SetClearOnEdit(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("clear-on-edit", "");
    }
    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types.
    /// </summary>
    public static void SetClearOnEdit(this AttributesBuilder<IonInput> b, bool value)
    {
        if (value) b.SetAttribute("clear-on-edit", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("counter", "");
    }
    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter(this AttributesBuilder<IonInput> b, bool value)
    {
        if (value) b.SetAttribute("counter", "");
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("debounce", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonInput> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhint(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("enterkeyhint", value);
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "done");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "enter");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "go");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "next");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "previous");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "search");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// Text that is placed under the input and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("error-text", value);
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFill(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("fill", value);
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("fill", "outline");
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// Text that is placed under the input and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("helper-text", value);
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmode(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("inputmode", value);
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "decimal");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "email");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "none");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "numeric");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "search");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "tel");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "text");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// The visible label associated with the input.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("label", value);
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("label-placement", value);
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("label-placement", "end");
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFloating(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("label-placement", "floating");
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("max", value);
    }

    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("maxlength", value);
    }

    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("min", value);
    }

    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("minlength", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored.
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("multiple", "");
    }
    /// <summary>
    /// If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored.
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonInput> b, bool value)
    {
        if (value) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("name", value);
    }

    /// <summary>
    /// A regular expression that the value is checked against. The pattern must match the entire value, not just some subset. Use the title attribute to describe the pattern to help the user. This attribute applies when the value of the type attribute is `"text"`, `"search"`, `"tel"`, `"url"`, `"email"`, `"date"`, or `"password"`, otherwise it is ignored. When the type attribute is `"date"`, `pattern` will only be used in browsers that do not support the `"date"` input type natively. See https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date for more information.
    /// </summary>
    public static void SetPattern(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("pattern", value);
    }

    /// <summary>
    /// Instructional text that shows before the input has a value. This property applies only when the `type` property is set to `"email"`, `"number"`, `"password"`, `"search"`, `"tel"`, `"text"`, or `"url"`, otherwise it is ignored.
    /// </summary>
    public static void SetPlaceholder(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("placeholder", value);
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("readonly", "");
    }
    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonInput> b, bool value)
    {
        if (value) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("required", "");
    }
    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired(this AttributesBuilder<IonInput> b, bool value)
    {
        if (value) b.SetAttribute("required", "");
    }

    /// <summary>
    /// The shape of the input. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShape(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("shape", value);
    }
    /// <summary>
    /// The shape of the input. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("spellcheck", "");
    }
    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonInput> b, bool value)
    {
        if (value) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// Works with the min and max attributes to limit the increments at which a value can be set. Possible values are: `"any"` or a positive floating point number.
    /// </summary>
    public static void SetStep(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("step", value);
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetType(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("type", value);
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeDate(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "date");
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeDatetimeLocal(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "datetime-local");
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeEmail(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "email");
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeMonth(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "month");
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeNumber(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "number");
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypePassword(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "password");
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeSearch(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "search");
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeTel(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "tel");
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeText(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "text");
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeTime(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "time");
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeUrl(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "url");
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeWeek(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "week");
    }

    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonInput> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonInput(this LayoutBuilder b, Action<PropsBuilder<IonInput>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-input", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonInput(this LayoutBuilder b, Action<PropsBuilder<IonInput>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-input", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonInput(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-input", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonInput(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-input", children);
    }
    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), value);
    }
    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const(value));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteEmail<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("email"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTel<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteUrl<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("url"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOn<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("on"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOff<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("off"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteHonorificPrefix<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("honorific-prefix"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteGivenName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("given-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAdditionalName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("additional-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteFamilyName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("family-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteHonorificSuffix<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("honorific-suffix"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteNickname<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("nickname"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteUsername<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("username"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteNewPassword<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("new-password"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCurrentPassword<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("current-password"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOneTimeCode<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("one-time-code"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOrganizationTitle<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("organization-title"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOrganization<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("organization"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteStreetAddress<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("street-address"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine1<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line1"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine2<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line2"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine3<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line3"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel4<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level4"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel3<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level3"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel2<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level2"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel1<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level1"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCountry<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("country"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCountryName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("country-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompletePostalCode<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("postal-code"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcGivenName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-given-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcAdditionalName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-additional-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcFamilyName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-family-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcNumber<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-number"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExp<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExpMonth<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp-month"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExpYear<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp-year"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcCsc<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-csc"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcType<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-type"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTransactionCurrency<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("transaction-currency"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTransactionAmount<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("transaction-amount"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteLanguage<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("language"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBday<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayDay<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-day"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayMonth<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-month"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayYear<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-year"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteSex<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("sex"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelCountryCode<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-country-code"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelNational<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-national"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelAreaCode<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-area-code"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelLocal<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-local"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelExtension<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-extension"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteImpp<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("impp"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompletePhoto<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("photo"));
    }

    /// <summary>
    /// Whether auto correction should be enabled when the user is entering/editing the text value.
    /// </summary>
    public static void SetAutocorrectOff<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocorrect"), b.Const("off"));
    }
    /// <summary>
    /// Whether auto correction should be enabled when the user is entering/editing the text value.
    /// </summary>
    public static void SetAutocorrectOn<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocorrect"), b.Const("on"));
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("autofocus"), b.Const(true));
    }

    /// <summary>
    /// If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input.
    /// </summary>
    public static void SetClearInput<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("clearInput"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types.
    /// </summary>
    public static void SetClearOnEdit<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("clearOnEdit"), b.Const(true));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("counter"), b.Const(true));
    }

    /// <summary>
    /// A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCounterFormatter<T>(this PropsBuilder<T> b, Var<Func<int,int,string>> f) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,int,string>>("counterFormatter"), f);
    }
    /// <summary>
    /// A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCounterFormatter<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<int>,Var<int>,Var<string>> f) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,int,string>>("counterFormatter"), b.Def(f));
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, Var<int> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), value);
    }
    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, int value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("done"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("enter"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("go"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("next"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("previous"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("search"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("send"));
    }

    /// <summary>
    /// Text that is placed under the input and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), value);
    }
    /// <summary>
    /// Text that is placed under the input and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), b.Const(value));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("outline"));
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("solid"));
    }

    /// <summary>
    /// Text that is placed under the input and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), value);
    }
    /// <summary>
    /// Text that is placed under the input and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), b.Const(value));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("decimal"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("email"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("none"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("numeric"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("search"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("tel"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("text"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// The visible label associated with the input.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The visible label associated with the input.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("end"));
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("fixed"));
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFloating<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("floating"));
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("stacked"));
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStart<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<int> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), value);
    }
    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, int value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), b.Const(value));
    }
    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), value);
    }
    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), b.Const(value));
    }

    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, Var<int> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), value);
    }
    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, int value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), b.Const(value));
    }

    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, Var<int> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), value);
    }
    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, int value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), b.Const(value));
    }
    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), value);
    }
    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), b.Const(value));
    }

    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, Var<int> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), value);
    }
    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, int value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored.
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), b.Const(true));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// A regular expression that the value is checked against. The pattern must match the entire value, not just some subset. Use the title attribute to describe the pattern to help the user. This attribute applies when the value of the type attribute is `"text"`, `"search"`, `"tel"`, `"url"`, `"email"`, `"date"`, or `"password"`, otherwise it is ignored. When the type attribute is `"date"`, `pattern` will only be used in browsers that do not support the `"date"` input type natively. See https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date for more information.
    /// </summary>
    public static void SetPattern<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pattern"), value);
    }
    /// <summary>
    /// A regular expression that the value is checked against. The pattern must match the entire value, not just some subset. Use the title attribute to describe the pattern to help the user. This attribute applies when the value of the type attribute is `"text"`, `"search"`, `"tel"`, `"url"`, `"email"`, `"date"`, or `"password"`, otherwise it is ignored. When the type attribute is `"date"`, `pattern` will only be used in browsers that do not support the `"date"` input type natively. See https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date for more information.
    /// </summary>
    public static void SetPattern<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pattern"), b.Const(value));
    }

    /// <summary>
    /// Instructional text that shows before the input has a value. This property applies only when the `type` property is set to `"email"`, `"number"`, `"password"`, `"search"`, `"tel"`, `"text"`, or `"url"`, otherwise it is ignored.
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), value);
    }
    /// <summary>
    /// Instructional text that shows before the input has a value. This property applies only when the `type` property is set to `"email"`, `"number"`, `"password"`, `"search"`, `"tel"`, `"text"`, or `"url"`, otherwise it is ignored.
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("readonly"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("required"), b.Const(true));
    }

    /// <summary>
    /// The shape of the input. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("shape"), b.Const("round"));
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("spellcheck"), b.Const(true));
    }

    /// <summary>
    /// Works with the min and max attributes to limit the increments at which a value can be set. Possible values are: `"any"` or a positive floating point number.
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("step"), value);
    }
    /// <summary>
    /// Works with the min and max attributes to limit the increments at which a value can be set. Possible values are: `"any"` or a positive floating point number.
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("step"), b.Const(value));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeDate<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("date"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeDatetimeLocal<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("datetime-local"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeEmail<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("email"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeMonth<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("month"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeNumber<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("number"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypePassword<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("password"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeSearch<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("search"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeTel<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("tel"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeText<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("text"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeTime<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("time"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeUrl<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("url"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeWeek<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("week"));
    }

    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }
    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, FocusEvent>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionBlur", action, "detail");
    }
    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<FocusEvent>, Var<TModel>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionBlur", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  Depending on the way the users interacts with the element, the `ionChange` event fires at a different moment: - When the user commits the change explicitly (e.g. by selecting a date from a date picker for `<ion-input type="date">`, pressing the "Enter" key, etc.). - When the element loses focus after its value has changed: for elements where the user's interaction is typing.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, InputChangeEventDetail>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  Depending on the way the users interacts with the element, the `ionChange` event fires at a different moment: - When the user commits the change explicitly (e.g. by selecting a date from a date picker for `<ion-input type="date">`, pressing the "Enter" key, etc.). - When the element loses focus after its value has changed: for elements where the user's interaction is typing.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<InputChangeEventDetail>, Var<TModel>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, FocusEvent>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionFocus", action, "detail");
    }
    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<FocusEvent>, Var<TModel>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionFocus", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, InputInputEventDetail>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionInput", action, "detail");
    }
    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<InputInputEventDetail>, Var<TModel>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionInput", b.MakeAction(action), "detail");
    }

}

