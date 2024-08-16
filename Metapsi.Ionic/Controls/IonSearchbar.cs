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
        /// <para> Returns the native `&lt;input&gt;` element used under the hood. </para>
        /// <para> () =&gt; Promise&lt;HTMLInputElement&gt; </para>
        /// </summary>
        public const string GetInputElement = "getInputElement";
        /// <summary>
        /// <para> Sets focus on the native `input` in `ion-searchbar`. Use this method instead of the global `input.focus()`.  Developers who wish to focus an input when a page enters should call `setFocus()` in the `ionViewDidEnter()` lifecycle method.  Developers who wish to focus an input when an overlay is presented should call `setFocus` after `didPresent` has resolved.  See [managing focus](/docs/developing/managing-focus) for more information. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
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
    /// <para> If `true`, enable searchbar animation. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, enable searchbar animation. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonSearchbar> b,bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`. </para>
    /// </summary>
    public static void SetAutocapitalize(this AttributesBuilder<IonSearchbar> b,string autocapitalize)
    {
        b.SetAttribute("autocapitalize", autocapitalize);
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocomplete(this AttributesBuilder<IonSearchbar> b,string autocomplete)
    {
        b.SetAttribute("autocomplete", autocomplete);
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "name");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteEmail(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "email");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTel(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteUrl(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "url");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteOn(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "on");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteOff(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "off");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteHonorificPrefix(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "honorific-prefix");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteGivenName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "given-name");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAdditionalName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "additional-name");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteFamilyName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "family-name");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteHonorificSuffix(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "honorific-suffix");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteNickname(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "nickname");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteUsername(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "username");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteNewPassword(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "new-password");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCurrentPassword(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "current-password");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteOneTimeCode(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "one-time-code");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteOrganizationTitle(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "organization-title");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteOrganization(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "organization");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteStreetAddress(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "street-address");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine1(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-line1");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine2(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-line2");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine3(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-line3");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel4(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-level4");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel3(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-level3");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel2(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-level2");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel1(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "address-level1");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCountry(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "country");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCountryName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "country-name");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompletePostalCode(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "postal-code");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-name");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcGivenName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-given-name");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcAdditionalName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-additional-name");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcFamilyName(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-family-name");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcNumber(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-number");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcExp(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-exp");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcExpMonth(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-exp-month");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcExpYear(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-exp-year");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcCsc(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-csc");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcType(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "cc-type");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTransactionCurrency(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "transaction-currency");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTransactionAmount(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "transaction-amount");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteLanguage(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "language");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteBday(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "bday");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteBdayDay(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "bday-day");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteBdayMonth(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "bday-month");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteBdayYear(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "bday-year");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteSex(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "sex");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTelCountryCode(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel-country-code");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTelNational(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel-national");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTelAreaCode(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel-area-code");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTelLocal(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel-local");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTelExtension(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "tel-extension");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteImpp(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "impp");
    }

    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompletePhoto(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocomplete", "photo");
    }

    /// <summary>
    /// <para> Set the input's autocorrect property. </para>
    /// </summary>
    public static void SetAutocorrect(this AttributesBuilder<IonSearchbar> b,string autocorrect)
    {
        b.SetAttribute("autocorrect", autocorrect);
    }

    /// <summary>
    /// <para> Set the input's autocorrect property. </para>
    /// </summary>
    public static void SetAutocorrectOff(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocorrect", "off");
    }

    /// <summary>
    /// <para> Set the input's autocorrect property. </para>
    /// </summary>
    public static void SetAutocorrectOn(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("autocorrect", "on");
    }

    /// <summary>
    /// <para> Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`. </para>
    /// </summary>
    public static void SetCancelButtonIcon(this AttributesBuilder<IonSearchbar> b,string cancelButtonIcon)
    {
        b.SetAttribute("cancel-button-icon", cancelButtonIcon);
    }

    /// <summary>
    /// <para> Set the the cancel button text. Only applies to `ios` mode. </para>
    /// </summary>
    public static void SetCancelButtonText(this AttributesBuilder<IonSearchbar> b,string cancelButtonText)
    {
        b.SetAttribute("cancel-button-text", cancelButtonText);
    }

    /// <summary>
    /// <para> Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`. </para>
    /// </summary>
    public static void SetClearIcon(this AttributesBuilder<IonSearchbar> b,string clearIcon)
    {
        b.SetAttribute("clear-icon", clearIcon);
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonSearchbar> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke. </para>
    /// </summary>
    public static void SetDebounce(this AttributesBuilder<IonSearchbar> b,string debounce)
    {
        b.SetAttribute("debounce", debounce);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the input. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the input. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSearchbar> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhint(this AttributesBuilder<IonSearchbar> b,string enterkeyhint)
    {
        b.SetAttribute("enterkeyhint", enterkeyhint);
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintDone(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "done");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintEnter(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "enter");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintGo(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "go");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintNext(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "next");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintPrevious(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "previous");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintSearch(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "search");
    }

    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintSend(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmode(this AttributesBuilder<IonSearchbar> b,string inputmode)
    {
        b.SetAttribute("inputmode", inputmode);
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeDecimal(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "decimal");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeEmail(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "email");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeNone(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "none");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeNumeric(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "numeric");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeSearch(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "search");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeTel(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "tel");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeText(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "text");
    }

    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeUrl(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// <para> This attribute specifies the maximum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMaxlength(this AttributesBuilder<IonSearchbar> b,string maxlength)
    {
        b.SetAttribute("maxlength", maxlength);
    }

    /// <summary>
    /// <para> This attribute specifies the minimum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMinlength(this AttributesBuilder<IonSearchbar> b,string minlength)
    {
        b.SetAttribute("minlength", minlength);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonSearchbar> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> If used in a form, set the name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<IonSearchbar> b,string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security) </para>
    /// </summary>
    public static void SetPlaceholder(this AttributesBuilder<IonSearchbar> b,string placeholder)
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// <para> The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode. </para>
    /// </summary>
    public static void SetSearchIcon(this AttributesBuilder<IonSearchbar> b,string searchIcon)
    {
        b.SetAttribute("search-icon", searchIcon);
    }

    /// <summary>
    /// <para> Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state. </para>
    /// </summary>
    public static void SetShowCancelButton(this AttributesBuilder<IonSearchbar> b,string showCancelButton)
    {
        b.SetAttribute("show-cancel-button", showCancelButton);
    }

    /// <summary>
    /// <para> Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state. </para>
    /// </summary>
    public static void SetShowCancelButtonAlways(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-cancel-button", "always");
    }

    /// <summary>
    /// <para> Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state. </para>
    /// </summary>
    public static void SetShowCancelButtonFocus(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-cancel-button", "focus");
    }

    /// <summary>
    /// <para> Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state. </para>
    /// </summary>
    public static void SetShowCancelButtonNever(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-cancel-button", "never");
    }

    /// <summary>
    /// <para> Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty. </para>
    /// </summary>
    public static void SetShowClearButton(this AttributesBuilder<IonSearchbar> b,string showClearButton)
    {
        b.SetAttribute("show-clear-button", showClearButton);
    }

    /// <summary>
    /// <para> Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty. </para>
    /// </summary>
    public static void SetShowClearButtonAlways(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-clear-button", "always");
    }

    /// <summary>
    /// <para> Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty. </para>
    /// </summary>
    public static void SetShowClearButtonFocus(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-clear-button", "focus");
    }

    /// <summary>
    /// <para> Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty. </para>
    /// </summary>
    public static void SetShowClearButtonNever(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("show-clear-button", "never");
    }

    /// <summary>
    /// <para> If `true`, enable spellcheck on the input. </para>
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// <para> If `true`, enable spellcheck on the input. </para>
    /// </summary>
    public static void SetSpellcheck(this AttributesBuilder<IonSearchbar> b,bool spellcheck)
    {
        if (spellcheck) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<IonSearchbar> b,string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeEmail(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "email");
    }

    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeNumber(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "number");
    }

    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypePassword(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "password");
    }

    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeSearch(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "search");
    }

    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeTel(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "tel");
    }

    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeText(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "text");
    }

    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeUrl(this AttributesBuilder<IonSearchbar> b)
    {
        b.SetAttribute("type", "url");
    }

    /// <summary>
    /// <para> the value of the searchbar. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonSearchbar> b,string value)
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
    /// <para> If `true`, enable searchbar animation. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, enable searchbar animation. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> animated) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), animated);
    }

    /// <summary>
    /// <para> If `true`, enable searchbar animation. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool animated) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(animated));
    }


    /// <summary>
    /// <para> Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`. </para>
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, Var<string> autocapitalize) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), autocapitalize);
    }

    /// <summary>
    /// <para> Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`. </para>
    /// </summary>
    public static void SetAutocapitalize<T>(this PropsBuilder<T> b, string autocapitalize) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const(autocapitalize));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("name"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteEmail<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("email"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTel<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteUrl<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("url"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteOn<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("on"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteOff<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("off"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteHonorificPrefix<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("honorific-prefix"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteGivenName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("given-name"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAdditionalName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("additional-name"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteFamilyName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("family-name"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteHonorificSuffix<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("honorific-suffix"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteNickname<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("nickname"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteUsername<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("username"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteNewPassword<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("new-password"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCurrentPassword<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("current-password"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteOneTimeCode<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("one-time-code"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteOrganizationTitle<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("organization-title"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteOrganization<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("organization"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteStreetAddress<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("street-address"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine1<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-line1"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine2<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-line2"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLine3<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-line3"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel4<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-level4"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel3<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-level3"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel2<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-level2"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteAddressLevel1<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("address-level1"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCountry<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("country"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCountryName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("country-name"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompletePostalCode<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("postal-code"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-name"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcGivenName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-given-name"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcAdditionalName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-additional-name"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcFamilyName<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-family-name"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcNumber<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-number"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcExp<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-exp"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcExpMonth<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-exp-month"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcExpYear<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-exp-year"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcCsc<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-csc"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteCcType<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("cc-type"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTransactionCurrency<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("transaction-currency"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTransactionAmount<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("transaction-amount"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteLanguage<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("language"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteBday<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("bday"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteBdayDay<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("bday-day"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteBdayMonth<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("bday-month"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteBdayYear<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("bday-year"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteSex<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("sex"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTelCountryCode<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel-country-code"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTelNational<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel-national"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTelAreaCode<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel-area-code"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTelLocal<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel-local"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteTelExtension<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("tel-extension"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompleteImpp<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("impp"));
    }


    /// <summary>
    /// <para> Set the input's autocomplete property. </para>
    /// </summary>
    public static void SetAutocompletePhoto<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocomplete"), b.Const("photo"));
    }


    /// <summary>
    /// <para> Set the input's autocorrect property. </para>
    /// </summary>
    public static void SetAutocorrectOff<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocorrect"), b.Const("off"));
    }


    /// <summary>
    /// <para> Set the input's autocorrect property. </para>
    /// </summary>
    public static void SetAutocorrectOn<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocorrect"), b.Const("on"));
    }


    /// <summary>
    /// <para> Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`. </para>
    /// </summary>
    public static void SetCancelButtonIcon<T>(this PropsBuilder<T> b, Var<string> cancelButtonIcon) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonIcon"), cancelButtonIcon);
    }

    /// <summary>
    /// <para> Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`. </para>
    /// </summary>
    public static void SetCancelButtonIcon<T>(this PropsBuilder<T> b, string cancelButtonIcon) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonIcon"), b.Const(cancelButtonIcon));
    }


    /// <summary>
    /// <para> Set the the cancel button text. Only applies to `ios` mode. </para>
    /// </summary>
    public static void SetCancelButtonText<T>(this PropsBuilder<T> b, Var<string> cancelButtonText) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonText"), cancelButtonText);
    }

    /// <summary>
    /// <para> Set the the cancel button text. Only applies to `ios` mode. </para>
    /// </summary>
    public static void SetCancelButtonText<T>(this PropsBuilder<T> b, string cancelButtonText) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonText"), b.Const(cancelButtonText));
    }


    /// <summary>
    /// <para> Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`. </para>
    /// </summary>
    public static void SetClearIcon<T>(this PropsBuilder<T> b, Var<string> clearIcon) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("clearIcon"), clearIcon);
    }

    /// <summary>
    /// <para> Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`. </para>
    /// </summary>
    public static void SetClearIcon<T>(this PropsBuilder<T> b, string clearIcon) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("clearIcon"), b.Const(clearIcon));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke. </para>
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, Var<int> debounce) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), debounce);
    }

    /// <summary>
    /// <para> Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke. </para>
    /// </summary>
    public static void SetDebounce<T>(this PropsBuilder<T> b, int debounce) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), b.Const(debounce));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the input. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the input. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the input. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("done"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("enter"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("go"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("next"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("previous"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("search"));
    }


    /// <summary>
    /// <para> A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`. </para>
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("enterkeyhint"), b.Const("send"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeDecimal<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("decimal"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeEmail<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("email"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeNone<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("none"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeNumeric<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("numeric"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeSearch<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("search"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeTel<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("tel"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeText<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("text"));
    }


    /// <summary>
    /// <para> A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`. </para>
    /// </summary>
    public static void SetInputmodeUrl<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("inputmode"), b.Const("url"));
    }


    /// <summary>
    /// <para> This attribute specifies the maximum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, Var<int> maxlength) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), maxlength);
    }

    /// <summary>
    /// <para> This attribute specifies the maximum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMaxlength<T>(this PropsBuilder<T> b, int maxlength) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), b.Const(maxlength));
    }


    /// <summary>
    /// <para> This attribute specifies the minimum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, Var<int> minlength) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), minlength);
    }

    /// <summary>
    /// <para> This attribute specifies the minimum number of characters that the user can enter. </para>
    /// </summary>
    public static void SetMinlength<T>(this PropsBuilder<T> b, int minlength) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), b.Const(minlength));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> If used in a form, set the name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> If used in a form, set the name of the control, which is submitted with the form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security) </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, Var<string> placeholder) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), placeholder);
    }

    /// <summary>
    /// <para> Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security) </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, string placeholder) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(placeholder));
    }


    /// <summary>
    /// <para> The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode. </para>
    /// </summary>
    public static void SetSearchIcon<T>(this PropsBuilder<T> b, Var<string> searchIcon) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("searchIcon"), searchIcon);
    }

    /// <summary>
    /// <para> The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode. </para>
    /// </summary>
    public static void SetSearchIcon<T>(this PropsBuilder<T> b, string searchIcon) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("searchIcon"), b.Const(searchIcon));
    }


    /// <summary>
    /// <para> Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state. </para>
    /// </summary>
    public static void SetShowCancelButtonAlways<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("showCancelButton"), b.Const("always"));
    }


    /// <summary>
    /// <para> Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state. </para>
    /// </summary>
    public static void SetShowCancelButtonFocus<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("showCancelButton"), b.Const("focus"));
    }


    /// <summary>
    /// <para> Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state. </para>
    /// </summary>
    public static void SetShowCancelButtonNever<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("showCancelButton"), b.Const("never"));
    }


    /// <summary>
    /// <para> Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty. </para>
    /// </summary>
    public static void SetShowClearButtonAlways<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("showClearButton"), b.Const("always"));
    }


    /// <summary>
    /// <para> Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty. </para>
    /// </summary>
    public static void SetShowClearButtonFocus<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("showClearButton"), b.Const("focus"));
    }


    /// <summary>
    /// <para> Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty. </para>
    /// </summary>
    public static void SetShowClearButtonNever<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("showClearButton"), b.Const("never"));
    }


    /// <summary>
    /// <para> If `true`, enable spellcheck on the input. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, enable spellcheck on the input. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b, Var<bool> spellcheck) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), spellcheck);
    }

    /// <summary>
    /// <para> If `true`, enable spellcheck on the input. </para>
    /// </summary>
    public static void SetSpellcheck<T>(this PropsBuilder<T> b, bool spellcheck) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("spellcheck"), b.Const(spellcheck));
    }


    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeEmail<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("email"));
    }


    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeNumber<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("number"));
    }


    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypePassword<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("password"));
    }


    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeSearch<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("search"));
    }


    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeTel<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("tel"));
    }


    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeText<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("text"));
    }


    /// <summary>
    /// <para> Set the type of the input. </para>
    /// </summary>
    public static void SetTypeUrl<T>(this PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("url"));
    }


    /// <summary>
    /// <para> the value of the searchbar. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> the value of the searchbar. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonSearchbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Emitted when the input loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// <para> Emitted when the input loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the cancel button is clicked. </para>
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionCancel", action);
    }
    /// <summary>
    /// <para> Emitted when the cancel button is clicked. </para>
    /// </summary>
    public static void OnIonCancel<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionCancel", b.MakeAction(action));
    }

    /// <summary>
    /// <para> The `ionChange` event is fired for `<ion-searchbar>` elements when the user modifies the element's value. Unlike the `ionInput` event, the `ionChange` event is not necessarily fired for each alteration to an element's value.  The `ionChange` event is fired when the value has been committed by the user. This can happen when the element loses focus or when the "Enter" key is pressed. `ionChange` can also fire when clicking the clear or cancel buttons. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SearchbarChangeEventDetail>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> The `ionChange` event is fired for `<ion-searchbar>` elements when the user modifies the element's value. Unlike the `ionInput` event, the `ionChange` event is not necessarily fired for each alteration to an element's value.  The `ionChange` event is fired when the value has been committed by the user. This can happen when the element loses focus or when the "Enter" key is pressed. `ionChange` can also fire when clicking the clear or cancel buttons. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SearchbarChangeEventDetail>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the clear input button is clicked. </para>
    /// </summary>
    public static void OnIonClear<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionClear", action);
    }
    /// <summary>
    /// <para> Emitted when the clear input button is clicked. </para>
    /// </summary>
    public static void OnIonClear<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionClear", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the input has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// <para> Emitted when the input has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the `value` of the `ion-searchbar` element has changed. </para>
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SearchbarInputEventDetail>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionInput", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the `value` of the `ion-searchbar` element has changed. </para>
    /// </summary>
    public static void OnIonInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SearchbarInputEventDetail>, Var<TModel>> action) where TComponent: IonSearchbar
    {
        b.OnEventAction("onionInput", b.MakeAction(action), "detail");
    }

}

