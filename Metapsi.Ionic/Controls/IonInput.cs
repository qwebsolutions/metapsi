using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonInput
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Content to display at the trailing edge of the input. (EXPERIMENTAL) </para>
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// <para> The label text to associate with the input. Use the `labelPlacement` property to control where the label is placed relative to the input. Use this if you need to render a label with custom HTML. (EXPERIMENTAL) </para>
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// <para> Content to display at the leading edge of the input. (EXPERIMENTAL) </para>
        /// </summary>
        public const string Start = "start";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Returns the native `&lt;input&gt;` element used under the hood. </para>
        /// <para> () =&gt; Promise&lt;HTMLInputElement&gt; </para>
        /// </summary>
        public const string GetInputElement = "getInputElement";
        /// <summary>
        /// <para> Sets focus on the native `input` in `ion-input`. Use this method instead of the global `input.focus()`.  Developers who wish to focus an input when a page enters should call `setFocus()` in the `ionViewDidEnter()` lifecycle method.  Developers who wish to focus an input when an overlay is presented should call `setFocus` after `didPresent` has resolved.  See [managing focus](/docs/developing/managing-focus) for more information. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
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
        return b.IonicTag("ion-input", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonInput(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-input", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonInput(this HtmlBuilder b, Action<AttributesBuilder<IonInput>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-input", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonInput(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-input", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`. </para>
    /// </summary>
    public static void SetAutocapitalize(this AttributesBuilder<IonInput> b, string autocapitalize)
    {
        b.SetAttribute("autocapitalize", autocapitalize);
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocomplete(this AttributesBuilder<IonInput> b, string autocomplete)
    {
        b.SetAttribute("autocomplete", autocomplete);
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "name");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteEmail(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "email");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTel(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteUrl(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "url");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteOn(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "on");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteOff(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "off");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteHonorificPrefix(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "honorific-prefix");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteGivenName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "given-name");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAdditionalName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "additional-name");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteFamilyName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "family-name");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteHonorificSuffix(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "honorific-suffix");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteNickname(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "nickname");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteUsername(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "username");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteNewPassword(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "new-password");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCurrentPassword(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "current-password");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteOneTimeCode(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "one-time-code");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteOrganizationTitle(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "organization-title");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteOrganization(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "organization");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteStreetAddress(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "street-address");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine1(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-line1");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine2(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-line2");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine3(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-line3");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel4(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-level4");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel3(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-level3");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel2(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-level2");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel1(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "address-level1");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCountry(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "country");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCountryName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "country-name");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompletePostalCode(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "postal-code");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-name");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcGivenName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-given-name");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcAdditionalName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-additional-name");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcFamilyName(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-family-name");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcNumber(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-number");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcExp(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-exp");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcExpMonth(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-exp-month");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcExpYear(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-exp-year");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcCsc(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-csc");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcType(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "cc-type");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTransactionCurrency(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "transaction-currency");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTransactionAmount(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "transaction-amount");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteLanguage(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "language");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteBday(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "bday");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteBdayDay(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "bday-day");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteBdayMonth(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "bday-month");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteBdayYear(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "bday-year");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteSex(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "sex");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTelCountryCode(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel-country-code");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTelNational(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel-national");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTelAreaCode(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel-area-code");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTelLocal(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel-local");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTelExtension(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "tel-extension");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteImpp(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "impp");
    }

    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompletePhoto(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocomplete", "photo");
    }

    /// <summary>
    /// <para> Whether auto correction should be enabled when the user is entering/editing the text value. </para>
    /// </summary>
    public static void SetAutocorrect(this AttributesBuilder<IonInput> b, string autocorrect)
    {
        b.SetAttribute("autocorrect", autocorrect);
    }

    /// <summary>
    /// <para> Whether auto correction should be enabled when the user is entering/editing the text value. </para>
    /// </summary>
    public static void SetAutocorrectOff(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocorrect", "off");
    }

    /// <summary>
    /// <para> Whether auto correction should be enabled when the user is entering/editing the text value. </para>
    /// </summary>
    public static void SetAutocorrectOn(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autocorrect", "on");
    }

    /// <summary>
    /// <para> Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information. </para>
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// <para> Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information. </para>
    /// </summary>
    public static void SetAutofocus(this AttributesBuilder<IonInput> b, bool autofocus)
    {
        if (autofocus) b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// <para> If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input. </para>
    /// </summary>
    public static void SetClearInput(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("clear-input", "");
    }

    /// <summary>
    /// <para> If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input. </para>
    /// </summary>
    public static void SetClearInput(this AttributesBuilder<IonInput> b, bool clearInput)
    {
        if (clearInput) b.SetAttribute("clear-input", "");
    }

    /// <summary>
    /// <para> If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types. </para>
    /// </summary>
    public static void SetClearOnEdit(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("clear-on-edit", "");
    }

    /// <summary>
    /// <para> If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types. </para>
    /// </summary>
    public static void SetClearOnEdit(this AttributesBuilder<IonInput> b, bool clearOnEdit)
    {
        if (clearOnEdit) b.SetAttribute("clear-on-edit", "");
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonInput> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly. </para>
    /// </summary>
    public static void SetCounter(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("counter", "");
    }

    /// <summary>
    /// <para> If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly. </para>
    /// </summary>
    public static void SetCounter(this AttributesBuilder<IonInput> b, bool counter)
    {
        if (counter) b.SetAttribute("counter", "");
    }

    /// <summary>
    /// <para> Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke. </para>
    /// </summary>
    public static void SetDebounce(this AttributesBuilder<IonInput> b, string debounce)
    {
        b.SetAttribute("debounce", debounce);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the input. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the input. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonInput> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhint(this AttributesBuilder<IonInput> b, string enterkeyhint)
    {
        b.SetAttribute("enterkeyhint", enterkeyhint);
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintDone(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "done");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintEnter(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "enter");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintGo(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "go");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintNext(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "next");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintPrevious(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "previous");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintSearch(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "search");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintSend(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// <para> Text that is placed under the input and displayed when an error is detected. </para>
    /// </summary>
    public static void SetErrorText(this AttributesBuilder<IonInput> b, string errorText)
    {
        b.SetAttribute("error-text", errorText);
    }

    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFill(this AttributesBuilder<IonInput> b, string fill)
    {
        b.SetAttribute("fill", fill);
    }

    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFillOutline(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("fill", "outline");
    }

    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFillSolid(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// <para> Text that is placed under the input and displayed when no error is detected. </para>
    /// </summary>
    public static void SetHelperText(this AttributesBuilder<IonInput> b, string helperText)
    {
        b.SetAttribute("helper-text", helperText);
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmode(this AttributesBuilder<IonInput> b, string inputmode)
    {
        b.SetAttribute("inputmode", inputmode);
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeDecimal(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "decimal");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeEmail(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "email");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeNone(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "none");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeNumeric(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "numeric");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeSearch(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "search");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeTel(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "tel");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeText(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "text");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeUrl(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// <para> The visible label associated with the input.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<IonInput> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacement(this AttributesBuilder<IonInput> b, string labelPlacement)
    {
        b.SetAttribute("label-placement", labelPlacement);
    }

    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementEnd(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("label-placement", "end");
    }

    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementFixed(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("label-placement", "fixed");
    }

    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementFloating(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("label-placement", "floating");
    }

    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementStacked(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("label-placement", "stacked");
    }

    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementStart(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("label-placement", "start");
    }

    /// <summary>
    /// <para> The maximum value, which must not be less than its minimum (min attribute) value. </para>
    /// </summary>
    public static void SetMax(this AttributesBuilder<IonInput> b, string max)
    {
        b.SetAttribute("max", max);
    }

    /// <summary>
    /// <para> If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the maximum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMaxlength(this AttributesBuilder<IonInput> b, string maxlength)
    {
        b.SetAttribute("maxlength", maxlength);
    }

    /// <summary>
    /// <para> The minimum value, which must not be greater than its maximum (max attribute) value. </para>
    /// </summary>
    public static void SetMin(this AttributesBuilder<IonInput> b, string min)
    {
        b.SetAttribute("min", min);
    }

    /// <summary>
    /// <para> If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the minimum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMinlength(this AttributesBuilder<IonInput> b, string minlength)
    {
        b.SetAttribute("minlength", minlength);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonInput> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored. </para>
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// <para> If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored. </para>
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonInput> b, bool multiple)
    {
        if (multiple) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<IonInput> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> A regular expression that the value is checked against. The pattern must match the entire value, not just some subset. Use the title attribute to describe the pattern to help the user. This attribute applies when the value of the type attribute is `"text"`, `"search"`, `"tel"`, `"url"`, `"email"`, `"date"`, or `"password"`, otherwise it is ignored. When the type attribute is `"date"`, `pattern` will only be used in browsers that do not support the `"date"` input type natively. See https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date for more information. </para>
    /// </summary>
    public static void SetPattern(this AttributesBuilder<IonInput> b, string pattern)
    {
        b.SetAttribute("pattern", pattern);
    }

    /// <summary>
    /// <para> Instructional text that shows before the input has a value. This property applies only when the `type` property is set to `"email"`, `"number"`, `"password"`, `"search"`, `"tel"`, `"text"`, or `"url"`, otherwise it is ignored. </para>
    /// </summary>
    public static void SetPlaceholder(this AttributesBuilder<IonInput> b, string placeholder)
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// <para> If `true`, the user cannot modify the value. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot modify the value. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<IonInput> b, bool @readonly)
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> If `true`, the user must fill in a value before submitting a form. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> If `true`, the user must fill in a value before submitting a form. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<IonInput> b, bool required)
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> The shape of the input. If "round" it will have an increased border radius. </para>
    /// </summary>
    public static void SetShape(this AttributesBuilder<IonInput> b, string shape)
    {
        b.SetAttribute("shape", shape);
    }

    /// <summary>
    /// <para> The shape of the input. If "round" it will have an increased border radius. </para>
    /// </summary>
    public static void SetShapeRound(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// <para> If `true`, the element will have its spelling and grammar checked. </para>
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// <para> If `true`, the element will have its spelling and grammar checked. </para>
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonInput> b, bool spellcheck)
    {
        if (spellcheck) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// <para> Works with the min and max attributes to limit the increments at which a value can be set. Possible values are: `"any"` or a positive floating point number. </para>
    /// </summary>
    public static void SetStep(this AttributesBuilder<IonInput> b, string step)
    {
        b.SetAttribute("step", step);
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<IonInput> b, string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeDate(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "date");
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeDatetimeLocal(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "datetime-local");
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeEmail(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "email");
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeMonth(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "month");
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeNumber(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "number");
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypePassword(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "password");
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeSearch(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "search");
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeTel(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "tel");
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeText(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "text");
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeTime(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "time");
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeUrl(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "url");
    }

    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeWeek(this AttributesBuilder<IonInput> b)
    {
        b.SetAttribute("type", "week");
    }

    /// <summary>
    /// <para> The value of the input. </para>
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
    /// <para> Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`. </para>
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, Var<string> autocapitalize) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), autocapitalize);
    }

    /// <summary>
    /// <para> Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`. </para>
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, string autocapitalize) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const(autocapitalize));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("name"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteEmail<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("email"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTel<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteUrl<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("url"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteOn<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("on"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteOff<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("off"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteHonorificPrefix<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("honorific-prefix"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteGivenName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("given-name"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAdditionalName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("additional-name"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteFamilyName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("family-name"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteHonorificSuffix<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("honorific-suffix"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteNickname<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("nickname"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteUsername<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("username"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteNewPassword<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("new-password"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCurrentPassword<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("current-password"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteOneTimeCode<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("one-time-code"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteOrganizationTitle<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("organization-title"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteOrganization<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("organization"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteStreetAddress<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("street-address"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine1<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-line1"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine2<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-line2"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine3<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-line3"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel4<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-level4"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel3<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-level3"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel2<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-level2"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel1<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-level1"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCountry<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("country"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCountryName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("country-name"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompletePostalCode<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("postal-code"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-name"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcGivenName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-given-name"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcAdditionalName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-additional-name"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcFamilyName<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-family-name"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcNumber<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-number"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcExp<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-exp"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcExpMonth<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-exp-month"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcExpYear<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-exp-year"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcCsc<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-csc"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteCcType<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-type"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTransactionCurrency<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("transaction-currency"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTransactionAmount<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("transaction-amount"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteLanguage<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("language"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteBday<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("bday"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteBdayDay<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("bday-day"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteBdayMonth<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("bday-month"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteBdayYear<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("bday-year"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteSex<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("sex"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTelCountryCode<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel-country-code"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTelNational<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel-national"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTelAreaCode<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel-area-code"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTelLocal<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel-local"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteTelExtension<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel-extension"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompleteImpp<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("impp"));
    }


    /// <summary>
    /// <para> Indicates whether the value of the control can be automatically completed by the browser. </para>
    /// </summary>
    public static void SetAutocompletePhoto<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("photo"));
    }


    /// <summary>
    /// <para> Whether auto correction should be enabled when the user is entering/editing the text value. </para>
    /// </summary>
    public static void SetAutocorrectOff<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocorrect"), b.Const("off"));
    }


    /// <summary>
    /// <para> Whether auto correction should be enabled when the user is entering/editing the text value. </para>
    /// </summary>
    public static void SetAutocorrectOn<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocorrect"), b.Const("on"));
    }


    /// <summary>
    /// <para> Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autofocus"), b.Const(true));
    }


    /// <summary>
    /// <para> Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b, Var<bool> autofocus) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autofocus"), autofocus);
    }

    /// <summary>
    /// <para> Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information. </para>
    /// </summary>
    public static void SetAutofocus<T>(this PropsBuilder<T> b, bool autofocus) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autofocus"), b.Const(autofocus));
    }


    /// <summary>
    /// <para> If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input. </para>
    /// </summary>
    public static void SetClearInput<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("clearInput"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input. </para>
    /// </summary>
    public static void SetClearInput<T>(this PropsBuilder<T> b, Var<bool> clearInput) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("clearInput"), clearInput);
    }

    /// <summary>
    /// <para> If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input. </para>
    /// </summary>
    public static void SetClearInput<T>(this PropsBuilder<T> b, bool clearInput) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("clearInput"), b.Const(clearInput));
    }


    /// <summary>
    /// <para> If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types. </para>
    /// </summary>
    public static void SetClearOnEdit<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("clearOnEdit"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types. </para>
    /// </summary>
    public static void SetClearOnEdit<T>(this PropsBuilder<T> b, Var<bool> clearOnEdit) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("clearOnEdit"), clearOnEdit);
    }

    /// <summary>
    /// <para> If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types. </para>
    /// </summary>
    public static void SetClearOnEdit<T>(this PropsBuilder<T> b, bool clearOnEdit) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("clearOnEdit"), b.Const(clearOnEdit));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly. </para>
    /// </summary>
    public static void SetCounter<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("counter"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly. </para>
    /// </summary>
    public static void SetCounter<T>(this PropsBuilder<T> b, Var<bool> counter) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("counter"), counter);
    }

    /// <summary>
    /// <para> If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly. </para>
    /// </summary>
    public static void SetCounter<T>(this PropsBuilder<T> b, bool counter) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("counter"), b.Const(counter));
    }


    /// <summary>
    /// <para> A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetCounterFormatter<T>(this PropsBuilder<T> b, Var<System.Func<int,int,string>> counterFormatter) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<int,int,string>>("counterFormatter"), counterFormatter);
    }

    /// <summary>
    /// <para> A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetCounterFormatter<T>(this PropsBuilder<T> b, System.Func<int,int,string> counterFormatter) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<int,int,string>>("counterFormatter"), b.Const(counterFormatter));
    }


    /// <summary>
    /// <para> Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke. </para>
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, Var<int> debounce) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), debounce);
    }

    /// <summary>
    /// <para> Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke. </para>
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, int debounce) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), b.Const(debounce));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the input. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the input. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the input. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("done"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("enter"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("go"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("next"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("previous"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("search"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("send"));
    }


    /// <summary>
    /// <para> Text that is placed under the input and displayed when an error is detected. </para>
    /// </summary>
    public static void SetErrorText<T>(this PropsBuilder<T> b, Var<string> errorText) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), errorText);
    }

    /// <summary>
    /// <para> Text that is placed under the input and displayed when an error is detected. </para>
    /// </summary>
    public static void SetErrorText<T>(this PropsBuilder<T> b, string errorText) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), b.Const(errorText));
    }


    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFillOutline<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), b.Const("outline"));
    }


    /// <summary>
    /// <para> The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode. </para>
    /// </summary>
    public static void SetFillSolid<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), b.Const("solid"));
    }


    /// <summary>
    /// <para> Text that is placed under the input and displayed when no error is detected. </para>
    /// </summary>
    public static void SetHelperText<T>(this PropsBuilder<T> b, Var<string> helperText) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), helperText);
    }

    /// <summary>
    /// <para> Text that is placed under the input and displayed when no error is detected. </para>
    /// </summary>
    public static void SetHelperText<T>(this PropsBuilder<T> b, string helperText) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), b.Const(helperText));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeDecimal<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("decimal"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeEmail<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("email"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeNone<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("none"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeNumeric<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("numeric"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeSearch<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("search"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeTel<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("tel"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeText<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("text"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeUrl<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("url"));
    }


    /// <summary>
    /// <para> The visible label associated with the input.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> The visible label associated with the input.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("end"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("fixed"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementFloating<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("floating"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("stacked"));
    }


    /// <summary>
    /// <para> Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("..."). </para>
    /// </summary>
    public static void SetLabelPlacementStart<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("labelPlacement"), b.Const("start"));
    }


    /// <summary>
    /// <para> The maximum value, which must not be less than its minimum (min attribute) value. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<int> max) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), max);
    }

    /// <summary>
    /// <para> The maximum value, which must not be less than its minimum (min attribute) value. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, int max) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), b.Const(max));
    }


    /// <summary>
    /// <para> The maximum value, which must not be less than its minimum (min attribute) value. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<string> max) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), max);
    }

    /// <summary>
    /// <para> The maximum value, which must not be less than its minimum (min attribute) value. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, string max) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), b.Const(max));
    }


    /// <summary>
    /// <para> If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the maximum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, Var<int> maxlength) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), maxlength);
    }

    /// <summary>
    /// <para> If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the maximum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, int maxlength) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), b.Const(maxlength));
    }


    /// <summary>
    /// <para> The minimum value, which must not be greater than its maximum (max attribute) value. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, Var<int> min) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), min);
    }

    /// <summary>
    /// <para> The minimum value, which must not be greater than its maximum (max attribute) value. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, int min) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), b.Const(min));
    }


    /// <summary>
    /// <para> The minimum value, which must not be greater than its maximum (max attribute) value. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, Var<string> min) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), min);
    }

    /// <summary>
    /// <para> The minimum value, which must not be greater than its maximum (max attribute) value. </para>
    /// </summary>
    public static void SetMin<T>(this PropsBuilder<T> b, string min) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), b.Const(min));
    }


    /// <summary>
    /// <para> If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the minimum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, Var<int> minlength) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), minlength);
    }

    /// <summary>
    /// <para> If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the minimum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, int minlength) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), b.Const(minlength));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, Var<bool> multiple) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), multiple);
    }

    /// <summary>
    /// <para> If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, bool multiple) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("multiple"), b.Const(multiple));
    }


    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> A regular expression that the value is checked against. The pattern must match the entire value, not just some subset. Use the title attribute to describe the pattern to help the user. This attribute applies when the value of the type attribute is `"text"`, `"search"`, `"tel"`, `"url"`, `"email"`, `"date"`, or `"password"`, otherwise it is ignored. When the type attribute is `"date"`, `pattern` will only be used in browsers that do not support the `"date"` input type natively. See https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date for more information. </para>
    /// </summary>
    public static void SetPattern<T>(this PropsBuilder<T> b, Var<string> pattern) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pattern"), pattern);
    }

    /// <summary>
    /// <para> A regular expression that the value is checked against. The pattern must match the entire value, not just some subset. Use the title attribute to describe the pattern to help the user. This attribute applies when the value of the type attribute is `"text"`, `"search"`, `"tel"`, `"url"`, `"email"`, `"date"`, or `"password"`, otherwise it is ignored. When the type attribute is `"date"`, `pattern` will only be used in browsers that do not support the `"date"` input type natively. See https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date for more information. </para>
    /// </summary>
    public static void SetPattern<T>(this PropsBuilder<T> b, string pattern) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pattern"), b.Const(pattern));
    }


    /// <summary>
    /// <para> Instructional text that shows before the input has a value. This property applies only when the `type` property is set to `"email"`, `"number"`, `"password"`, `"search"`, `"tel"`, `"text"`, or `"url"`, otherwise it is ignored. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, Var<string> placeholder) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), placeholder);
    }

    /// <summary>
    /// <para> Instructional text that shows before the input has a value. This property applies only when the `type` property is set to `"email"`, `"number"`, `"password"`, `"search"`, `"tel"`, `"text"`, or `"url"`, otherwise it is ignored. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, string placeholder) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(placeholder));
    }


    /// <summary>
    /// <para> If `true`, the user cannot modify the value. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot modify the value. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, Var<bool> @readonly) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), @readonly);
    }

    /// <summary>
    /// <para> If `true`, the user cannot modify the value. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, bool @readonly) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("readonly"), b.Const(@readonly));
    }


    /// <summary>
    /// <para> If `true`, the user must fill in a value before submitting a form. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user must fill in a value before submitting a form. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, Var<bool> required) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), required);
    }

    /// <summary>
    /// <para> If `true`, the user must fill in a value before submitting a form. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, bool required) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(required));
    }


    /// <summary>
    /// <para> The shape of the input. If "round" it will have an increased border radius. </para>
    /// </summary>
    public static void SetShapeRound<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("shape"), b.Const("round"));
    }


    /// <summary>
    /// <para> If `true`, the element will have its spelling and grammar checked. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the element will have its spelling and grammar checked. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b, Var<bool> spellcheck) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), spellcheck);
    }

    /// <summary>
    /// <para> If `true`, the element will have its spelling and grammar checked. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b, bool spellcheck) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), b.Const(spellcheck));
    }


    /// <summary>
    /// <para> Works with the min and max attributes to limit the increments at which a value can be set. Possible values are: `"any"` or a positive floating point number. </para>
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, Var<string> step) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("step"), step);
    }

    /// <summary>
    /// <para> Works with the min and max attributes to limit the increments at which a value can be set. Possible values are: `"any"` or a positive floating point number. </para>
    /// </summary>
    public static void SetStep<T>(this PropsBuilder<T> b, string step) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("step"), b.Const(step));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeDate<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("date"));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeDatetimeLocal<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("datetime-local"));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeEmail<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("email"));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeMonth<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("month"));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeNumber<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("number"));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypePassword<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("password"));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeSearch<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("search"));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeTel<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("tel"));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeText<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("text"));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeTime<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("time"));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeUrl<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("url"));
    }


    /// <summary>
    /// <para> The type of control to display. The default type is text. </para>
    /// </summary>
    public static void SetTypeWeek<T>(this PropsBuilder<T> b) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("week"));
    }


    /// <summary>
    /// <para> The value of the input. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }

    /// <summary>
    /// <para> The value of the input. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The value of the input. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The value of the input. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonInput
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Emitted when the input loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, FocusEvent>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionBlur", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the input loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<FocusEvent>, Var<TModel>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionBlur", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  Depending on the way the users interacts with the element, the `ionChange` event fires at a different moment: - When the user commits the change explicitly (e.g. by selecting a date from a date picker for `<ion-input type="date">`, pressing the "Enter" key, etc.). - When the element loses focus after its value has changed: for elements where the user's interaction is typing. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, InputChangeEventDetail>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  Depending on the way the users interacts with the element, the `ionChange` event fires at a different moment: - When the user commits the change explicitly (e.g. by selecting a date from a date picker for `<ion-input type="date">`, pressing the "Enter" key, etc.). - When the element loses focus after its value has changed: for elements where the user's interaction is typing. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<InputChangeEventDetail>, Var<TModel>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the input has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, FocusEvent>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionFocus", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the input has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<FocusEvent>, Var<TModel>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionFocus", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`. </para>
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, InputInputEventDetail>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionInput", action, "detail");
    }
    /// <summary>
    /// <para> The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`. </para>
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<InputInputEventDetail>, Var<TModel>> action) where TComponent: IonInput
    {
        b.OnEventAction("onionInput", b.MakeAction(action), "detail");
    }

}

