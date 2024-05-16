using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonSearchbar : IonComponent
{
    public IonSearchbar() : base("ion-searchbar") { }
    public static class Method
    {
        /// <summary> 
        /// Returns the native `&lt;input&gt;` element used under the hood.
        /// <para>() =&gt; Promise&lt;HTMLInputElement&gt;</para>
        /// </summary>
        public const string GetInputElement = "getInputElement";
        /// <summary> 
        /// Sets focus on the native `input` in `ion-searchbar`. Use this method instead of the global `input.focus()`.  Developers who wish to focus an input when a page enters should call `setFocus()` in the `ionViewDidEnter()` lifecycle method.  Developers who wish to focus an input when an overlay is presented should call `setFocus` after `didPresent` has resolved.  See [managing focus](/docs/developing/managing-focus) for more information.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string SetFocus = "setFocus";
    }
}

public static partial class IonSearchbarControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSearchbar(this HtmlBuilder b, Action<AttributesBuilder<IonSearchbar>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-searchbar", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSearchbar(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-searchbar", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, enable searchbar animation.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("animated", "");
    }
    /// <summary>
    /// If `true`, enable searchbar animation.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonSearchbar> b, bool value)
    {
        if (value) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("autocapitalize", value);
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocomplete(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("autocomplete", value);
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "name");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteEmail(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "email");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTel(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteUrl(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "url");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOn(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "on");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOff(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "off");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteHonorificPrefix(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "honorific-prefix");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteGivenName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "given-name");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAdditionalName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "additional-name");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteFamilyName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "family-name");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteHonorificSuffix(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "honorific-suffix");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteNickname(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "nickname");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteUsername(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "username");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteNewPassword(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "new-password");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCurrentPassword(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "current-password");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOneTimeCode(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "one-time-code");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOrganizationTitle(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "organization-title");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOrganization(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "organization");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteStreetAddress(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "street-address");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine1(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-line1");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine2(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-line2");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine3(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-line3");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel4(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-level4");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel3(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-level3");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel2(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-level2");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel1(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-level1");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCountry(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "country");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCountryName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "country-name");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompletePostalCode(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "postal-code");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-name");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcGivenName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-given-name");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcAdditionalName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-additional-name");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcFamilyName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-family-name");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcNumber(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-number");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExp(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-exp");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExpMonth(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-exp-month");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExpYear(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-exp-year");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcCsc(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-csc");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcType(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-type");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTransactionCurrency(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "transaction-currency");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTransactionAmount(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "transaction-amount");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteLanguage(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "language");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBday(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "bday");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayDay(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "bday-day");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayMonth(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "bday-month");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayYear(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "bday-year");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteSex(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "sex");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelCountryCode(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel-country-code");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelNational(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel-national");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelAreaCode(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel-area-code");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelLocal(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel-local");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelExtension(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel-extension");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteImpp(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "impp");
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompletePhoto(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "photo");
    }

    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public static void SetAutocorrect(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("autocorrect", value);
    }
    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public static void SetAutocorrectOff(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocorrect", "off");
    }
    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public static void SetAutocorrectOn(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocorrect", "on");
    }

    /// <summary>
    /// Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`.
    /// </summary>
    public static void SetCancelButtonIcon(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("cancel-button-icon", value);
    }

    /// <summary>
    /// Set the the cancel button text. Only applies to `ios` mode.
    /// </summary>
    public static void SetCancelButtonText(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("cancel-button-text", value);
    }

    /// <summary>
    /// Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`.
    /// </summary>
    public static void SetClearIcon(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("clear-icon", value);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("debounce", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSearchbar> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhint(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("enterkeyhint", value);
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "done");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "enter");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "go");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "next");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "previous");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "search");
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmode(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("inputmode", value);
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "decimal");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "email");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "none");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "numeric");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "search");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "tel");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "text");
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// This attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("maxlength", value);
    }

    /// <summary>
    /// This attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("minlength", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If used in a form, set the name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("name", value);
    }

    /// <summary>
    /// Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)
    /// </summary>
    public static void SetPlaceholder(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("placeholder", value);
    }

    /// <summary>
    /// The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode.
    /// </summary>
    public static void SetSearchIcon(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("search-icon", value);
    }

    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButton(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("show-cancel-button", value);
    }
    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonAlways(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-cancel-button", "always");
    }
    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonFocus(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-cancel-button", "focus");
    }
    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonNever(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-cancel-button", "never");
    }

    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButton(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("show-clear-button", value);
    }
    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonAlways(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-clear-button", "always");
    }
    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonFocus(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-clear-button", "focus");
    }
    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonNever(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-clear-button", "never");
    }

    /// <summary>
    /// If `true`, enable spellcheck on the input.
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("spellcheck", "");
    }
    /// <summary>
    /// If `true`, enable spellcheck on the input.
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonSearchbar> b, bool value)
    {
        if (value) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetType(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("type", value);
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeEmail(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "email");
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeNumber(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "number");
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypePassword(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "password");
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeSearch(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "search");
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeTel(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "tel");
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeText(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "text");
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeUrl(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "url");
    }

    /// <summary>
    /// the value of the searchbar.
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonSearchbar> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSearchbar(this LayoutBuilder b, Action<PropsBuilder<IonSearchbar>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-searchbar", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSearchbar(this LayoutBuilder b, Action<PropsBuilder<IonSearchbar>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-searchbar", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSearchbar(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-searchbar", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSearchbar(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-searchbar", children);
    }
    /// <summary>
    /// If `true`, enable searchbar animation.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), value);
    }
    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, string value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const(value));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteEmail<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("email"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTel<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteUrl<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("url"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOn<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("on"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOff<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("off"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteHonorificPrefix<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("honorific-prefix"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteGivenName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("given-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAdditionalName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("additional-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteFamilyName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("family-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteHonorificSuffix<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("honorific-suffix"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteNickname<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("nickname"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteUsername<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("username"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteNewPassword<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("new-password"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCurrentPassword<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("current-password"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOneTimeCode<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("one-time-code"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOrganizationTitle<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("organization-title"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOrganization<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("organization"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteStreetAddress<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("street-address"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine1<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line1"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine2<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line2"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine3<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line3"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel4<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level4"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel3<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level3"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel2<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level2"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel1<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level1"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCountry<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("country"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCountryName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("country-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompletePostalCode<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("postal-code"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcGivenName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-given-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcAdditionalName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-additional-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcFamilyName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-family-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcNumber<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-number"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExp<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExpMonth<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp-month"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExpYear<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp-year"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcCsc<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-csc"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcType<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-type"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTransactionCurrency<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("transaction-currency"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTransactionAmount<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("transaction-amount"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteLanguage<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("language"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBday<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayDay<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-day"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayMonth<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-month"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayYear<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-year"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteSex<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("sex"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelCountryCode<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-country-code"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelNational<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-national"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelAreaCode<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-area-code"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelLocal<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-local"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelExtension<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-extension"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteImpp<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("impp"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompletePhoto<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("photo"));
    }

    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public static void SetAutocorrectOff<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocorrect"), b.Const("off"));
    }
    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public static void SetAutocorrectOn<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocorrect"), b.Const("on"));
    }

    /// <summary>
    /// Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`.
    /// </summary>
    public static void SetCancelButtonIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonIcon"), value);
    }
    /// <summary>
    /// Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`.
    /// </summary>
    public static void SetCancelButtonIcon<T>(this PropsBuilder<T> b, string value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonIcon"), b.Const(value));
    }

    /// <summary>
    /// Set the the cancel button text. Only applies to `ios` mode.
    /// </summary>
    public static void SetCancelButtonText<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonText"), value);
    }
    /// <summary>
    /// Set the the cancel button text. Only applies to `ios` mode.
    /// </summary>
    public static void SetCancelButtonText<T>(this PropsBuilder<T> b, string value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonText"), b.Const(value));
    }

    /// <summary>
    /// Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`.
    /// </summary>
    public static void SetClearIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("clearIcon"), value);
    }
    /// <summary>
    /// Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`.
    /// </summary>
    public static void SetClearIcon<T>(this PropsBuilder<T> b, string value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("clearIcon"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, Var<int> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), value);
    }
    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, int value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("done"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("enter"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("go"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("next"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("previous"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("search"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("send"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("decimal"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("email"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("none"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("numeric"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("search"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("tel"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("text"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// This attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, Var<int> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), value);
    }
    /// <summary>
    /// This attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, int value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), b.Const(value));
    }

    /// <summary>
    /// This attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, Var<int> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), value);
    }
    /// <summary>
    /// This attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, int value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If used in a form, set the name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// If used in a form, set the name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), value);
    }
    /// <summary>
    /// Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, string value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(value));
    }

    /// <summary>
    /// The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode.
    /// </summary>
    public static void SetSearchIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("searchIcon"), value);
    }
    /// <summary>
    /// The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode.
    /// </summary>
    public static void SetSearchIcon<T>(this PropsBuilder<T> b, string value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("searchIcon"), b.Const(value));
    }

    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonAlways<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showCancelButton"), b.Const("always"));
    }
    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonFocus<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showCancelButton"), b.Const("focus"));
    }
    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonNever<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showCancelButton"), b.Const("never"));
    }

    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonAlways<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showClearButton"), b.Const("always"));
    }
    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonFocus<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showClearButton"), b.Const("focus"));
    }
    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonNever<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showClearButton"), b.Const("never"));
    }

    /// <summary>
    /// If `true`, enable spellcheck on the input.
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("spellcheck"), b.Const(true));
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeEmail<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("email"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeNumber<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("number"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypePassword<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("password"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeSearch<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("search"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeTel<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("tel"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeText<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("text"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeUrl<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("url"));
    }

    /// <summary>
    /// the value of the searchbar.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// the value of the searchbar.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the cancel button is clicked.
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionCancel", action);
    }
    /// <summary>
    /// Emitted when the cancel button is clicked.
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionCancel", b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired for `<ion-searchbar>` elements when the user modifies the element's value. Unlike the `ionInput` event, the `ionChange` event is not necessarily fired for each alteration to an element's value.  The `ionChange` event is fired when the value has been committed by the user. This can happen when the element loses focus or when the "Enter" key is pressed. `ionChange` can also fire when clicking the clear or cancel buttons.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SearchbarChangeEventDetail>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// The `ionChange` event is fired for `<ion-searchbar>` elements when the user modifies the element's value. Unlike the `ionInput` event, the `ionChange` event is not necessarily fired for each alteration to an element's value.  The `ionChange` event is fired when the value has been committed by the user. This can happen when the element loses focus or when the "Enter" key is pressed. `ionChange` can also fire when clicking the clear or cancel buttons.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SearchbarChangeEventDetail>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the clear input button is clicked.
    /// </summary>
    public static void OnIonClear<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionClear", action);
    }
    /// <summary>
    /// Emitted when the clear input button is clicked.
    /// </summary>
    public static void OnIonClear<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionClear", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the `value` of the `ion-searchbar` element has changed.
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SearchbarInputEventDetail>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionInput", action, "detail");
    }
    /// <summary>
    /// Emitted when the `value` of the `ion-searchbar` element has changed.
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SearchbarInputEventDetail>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionInput", b.MakeAction(action), "detail");
    }

}

