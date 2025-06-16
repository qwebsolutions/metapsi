using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonSearchbar
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Returns the native `&lt;input&gt;` element used under the hood.
        /// </summary>
        public const string GetInputElement = "getInputElement";
        /// <summary>
        /// Sets focus on the native `input` in `ion-searchbar`. Use this method instead of the global `input.focus()`.  Developers who wish to focus an input when a page enters should call `setFocus()` in the `ionViewDidEnter()` lifecycle method.  Developers who wish to focus an input when an overlay is presented should call `setFocus` after `didPresent` has resolved.  See [managing focus](/docs/developing/managing-focus) for more information.
        /// </summary>
        public const string SetFocus = "setFocus";
    }
}
/// <summary>
/// Setter extensions of IonSearchbar
/// </summary>
public static partial class IonSearchbarControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSearchbar(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSearchbar>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-searchbar", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSearchbar(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-searchbar", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSearchbar(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSearchbar>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-searchbar", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSearchbar(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-searchbar", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, enable searchbar animation.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, bool animated) 
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, enable searchbar animation.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string autocapitalize) 
    {
        b.SetAttribute("autocapitalize", autocapitalize);
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteName(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "name");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteEmail(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "email");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTel(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "tel");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteUrl(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "url");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOn(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "on");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOff(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "off");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteHonorificPrefix(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "honorific-prefix");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteGivenName(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "given-name");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAdditionalName(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "additional-name");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteFamilyName(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "family-name");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteHonorificSuffix(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "honorific-suffix");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteNickname(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "nickname");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteUsername(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "username");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteNewPassword(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "new-password");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCurrentPassword(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "current-password");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOneTimeCode(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "one-time-code");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOrganizationTitle(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "organization-title");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOrganization(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "organization");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteStreetAddress(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "street-address");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine1(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "address-line1");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine2(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "address-line2");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine3(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "address-line3");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel4(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "address-level4");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel3(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "address-level3");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel2(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "address-level2");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel1(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "address-level1");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCountry(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "country");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCountryName(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "country-name");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompletePostalCode(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "postal-code");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcName(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "cc-name");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcGivenName(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "cc-given-name");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcAdditionalName(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "cc-additional-name");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcFamilyName(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "cc-family-name");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcNumber(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "cc-number");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExp(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "cc-exp");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExpMonth(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "cc-exp-month");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExpYear(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "cc-exp-year");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcCsc(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "cc-csc");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcType(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "cc-type");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTransactionCurrency(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "transaction-currency");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTransactionAmount(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "transaction-amount");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteLanguage(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "language");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBday(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "bday");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayDay(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "bday-day");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayMonth(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "bday-month");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayYear(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "bday-year");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteSex(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "sex");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelCountryCode(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "tel-country-code");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelNational(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "tel-national");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelAreaCode(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "tel-area-code");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelLocal(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "tel-local");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelExtension(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "tel-extension");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteImpp(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "impp");
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompletePhoto(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocomplete", "photo");
    }

    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public static void SetAutocorrectOff(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocorrect", "off");
    }

    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public static void SetAutocorrectOn(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("autocorrect", "on");
    }

    /// <summary>
    /// Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`.
    /// </summary>
    public static void SetCancelButtonIcon(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string cancelButtonIcon) 
    {
        b.SetAttribute("cancelButtonIcon", cancelButtonIcon);
    }

    /// <summary>
    /// Set the cancel button text. Only applies to `ios` mode.
    /// </summary>
    public static void SetCancelButtonText(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string cancelButtonText) 
    {
        b.SetAttribute("cancelButtonText", cancelButtonText);
    }

    /// <summary>
    /// Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`.
    /// </summary>
    public static void SetClearIcon(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string clearIcon) 
    {
        b.SetAttribute("clearIcon", clearIcon);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string debounce) 
    {
        b.SetAttribute("debounce", debounce);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("enterkeyhint", "done");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("enterkeyhint", "enter");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("enterkeyhint", "go");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("enterkeyhint", "next");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("enterkeyhint", "previous");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("enterkeyhint", "search");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("inputmode", "decimal");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("inputmode", "email");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("inputmode", "none");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("inputmode", "numeric");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("inputmode", "search");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("inputmode", "tel");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("inputmode", "text");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// This attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string maxlength) 
    {
        b.SetAttribute("maxlength", maxlength);
    }

    /// <summary>
    /// This attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string minlength) 
    {
        b.SetAttribute("minlength", minlength);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If used in a form, set the name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)
    /// </summary>
    public static void SetPlaceholder(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string placeholder) 
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode.
    /// </summary>
    public static void SetSearchIcon(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string searchIcon) 
    {
        b.SetAttribute("searchIcon", searchIcon);
    }

    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonAlways(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("showCancelButton", "always");
    }

    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonFocus(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("showCancelButton", "focus");
    }

    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonNever(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("showCancelButton", "never");
    }

    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonAlways(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("showClearButton", "always");
    }

    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonFocus(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("showClearButton", "focus");
    }

    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonNever(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("showClearButton", "never");
    }

    /// <summary>
    /// If `true`, enable spellcheck on the input.
    /// </summary>
    public static void SetSpellcheck(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, bool spellcheck) 
    {
        if (spellcheck) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// If `true`, enable spellcheck on the input.
    /// </summary>
    public static void SetSpellcheck(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeEmail(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("type", "email");
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeNumber(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("type", "number");
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypePassword(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("type", "password");
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeSearch(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("type", "search");
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeTel(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("type", "tel");
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeText(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("type", "text");
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeUrl(this Metapsi.Html.AttributesBuilder<IonSearchbar> b) 
    {
        b.SetAttribute("type", "url");
    }

    /// <summary>
    /// the value of the searchbar.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<IonSearchbar> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSearchbar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSearchbar>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-searchbar", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSearchbar(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-searchbar", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSearchbar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSearchbar>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-searchbar", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSearchbar(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-searchbar", children);
    }

    /// <summary>
    /// If `true`, enable searchbar animation.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetAnimated(b.Const(true));
    }

    /// <summary>
    /// If `true`, enable searchbar animation.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, enable searchbar animation.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool animated) where T: IonSearchbar
    {
        b.SetAnimated(b.Const(animated));
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> autocapitalize) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), autocapitalize);
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this Metapsi.Syntax.PropsBuilder<T> b, string autocapitalize) where T: IonSearchbar
    {
        b.SetAutocapitalize(b.Const(autocapitalize));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("name"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteEmail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("email"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("url"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOn<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("on"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOff<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("off"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteHonorificPrefix<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("honorific-prefix"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteGivenName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("given-name"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAdditionalName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("additional-name"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteFamilyName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("family-name"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteHonorificSuffix<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("honorific-suffix"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteNickname<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("nickname"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteUsername<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("username"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteNewPassword<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("new-password"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCurrentPassword<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("current-password"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOneTimeCode<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("one-time-code"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOrganizationTitle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("organization-title"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOrganization<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("organization"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteStreetAddress<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("street-address"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine1<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-line1"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine2<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-line2"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine3<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-line3"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel4<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-level4"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel3<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-level3"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel2<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-level2"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel1<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-level1"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCountry<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("country"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCountryName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("country-name"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompletePostalCode<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("postal-code"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-name"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcGivenName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-given-name"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcAdditionalName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-additional-name"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcFamilyName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-family-name"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcNumber<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-number"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExp<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-exp"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExpMonth<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-exp-month"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExpYear<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-exp-year"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcCsc<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-csc"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcType<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-type"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTransactionCurrency<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("transaction-currency"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTransactionAmount<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("transaction-amount"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteLanguage<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("language"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBday<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("bday"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayDay<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("bday-day"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayMonth<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("bday-month"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayYear<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("bday-year"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteSex<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("sex"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelCountryCode<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel-country-code"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelNational<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel-national"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelAreaCode<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel-area-code"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelLocal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel-local"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelExtension<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel-extension"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteImpp<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("impp"));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompletePhoto<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("photo"));
    }

    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public static void SetAutocorrectOff<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocorrect"), b.Const("off"));
    }

    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public static void SetAutocorrectOn<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("autocorrect"), b.Const("on"));
    }

    /// <summary>
    /// Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`.
    /// </summary>
    public static void SetCancelButtonIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> cancelButtonIcon) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("cancelButtonIcon"), cancelButtonIcon);
    }

    /// <summary>
    /// Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`.
    /// </summary>
    public static void SetCancelButtonIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, string cancelButtonIcon) where T: IonSearchbar
    {
        b.SetCancelButtonIcon(b.Const(cancelButtonIcon));
    }

    /// <summary>
    /// Set the cancel button text. Only applies to `ios` mode.
    /// </summary>
    public static void SetCancelButtonText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> cancelButtonText) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("cancelButtonText"), cancelButtonText);
    }

    /// <summary>
    /// Set the cancel button text. Only applies to `ios` mode.
    /// </summary>
    public static void SetCancelButtonText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string cancelButtonText) where T: IonSearchbar
    {
        b.SetCancelButtonText(b.Const(cancelButtonText));
    }

    /// <summary>
    /// Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`.
    /// </summary>
    public static void SetClearIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> clearIcon) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("clearIcon"), clearIcon);
    }

    /// <summary>
    /// Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`.
    /// </summary>
    public static void SetClearIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, string clearIcon) where T: IonSearchbar
    {
        b.SetClearIcon(b.Const(clearIcon));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> debounce) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("debounce"), debounce);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonSearchbar
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("done"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("enter"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("go"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("next"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("previous"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("search"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("send"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("decimal"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("email"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("none"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("numeric"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("search"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("tel"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("text"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// This attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> maxlength) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("maxlength"), maxlength);
    }

    /// <summary>
    /// This attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> minlength) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("minlength"), minlength);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// If used in a form, set the name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// If used in a form, set the name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: IonSearchbar
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> placeholder) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }

    /// <summary>
    /// Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, string placeholder) where T: IonSearchbar
    {
        b.SetPlaceholder(b.Const(placeholder));
    }

    /// <summary>
    /// The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode.
    /// </summary>
    public static void SetSearchIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> searchIcon) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("searchIcon"), searchIcon);
    }

    /// <summary>
    /// The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode.
    /// </summary>
    public static void SetSearchIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, string searchIcon) where T: IonSearchbar
    {
        b.SetSearchIcon(b.Const(searchIcon));
    }

    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonAlways<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("showCancelButton"), b.Const("always"));
    }

    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonFocus<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("showCancelButton"), b.Const("focus"));
    }

    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonNever<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("showCancelButton"), b.Const("never"));
    }

    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonAlways<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("showClearButton"), b.Const("always"));
    }

    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonFocus<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("showClearButton"), b.Const("focus"));
    }

    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonNever<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("showClearButton"), b.Const("never"));
    }

    /// <summary>
    /// If `true`, enable spellcheck on the input.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetSpellcheck(b.Const(true));
    }

    /// <summary>
    /// If `true`, enable spellcheck on the input.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> spellcheck) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("spellcheck"), spellcheck);
    }

    /// <summary>
    /// If `true`, enable spellcheck on the input.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool spellcheck) where T: IonSearchbar
    {
        b.SetSpellcheck(b.Const(spellcheck));
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeEmail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("email"));
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeNumber<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("number"));
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypePassword<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("password"));
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("search"));
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeTel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("tel"));
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("text"));
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("url"));
    }

    /// <summary>
    /// the value of the searchbar.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: IonSearchbar
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the cancel button is clicked.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionCancel", action);
    }

    /// <summary>
    /// Emitted when the cancel button is clicked.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonCancel(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the cancel button is clicked.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionCancel", action);
    }

    /// <summary>
    /// Emitted when the cancel button is clicked.
    /// </summary>
    public static void OnIonCancel<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonCancel(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired for `&lt;ion-searchbar&gt;` elements when the user modifies the element's value. Unlike the `ionInput` event, the `ionChange` event is not necessarily fired for each alteration to an element's value.  The `ionChange` event is fired when the value has been committed by the user. This can happen when the element loses focus or when the "Enter" key is pressed. `ionChange` can also fire when clicking the clear or cancel buttons.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// The `ionChange` event is fired for `&lt;ion-searchbar&gt;` elements when the user modifies the element's value. Unlike the `ionInput` event, the `ionChange` event is not necessarily fired for each alteration to an element's value.  The `ionChange` event is fired when the value has been committed by the user. This can happen when the element loses focus or when the "Enter" key is pressed. `ionChange` can also fire when clicking the clear or cancel buttons.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired for `&lt;ion-searchbar&gt;` elements when the user modifies the element's value. Unlike the `ionInput` event, the `ionChange` event is not necessarily fired for each alteration to an element's value.  The `ionChange` event is fired when the value has been committed by the user. This can happen when the element loses focus or when the "Enter" key is pressed. `ionChange` can also fire when clicking the clear or cancel buttons.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// The `ionChange` event is fired for `&lt;ion-searchbar&gt;` elements when the user modifies the element's value. Unlike the `ionInput` event, the `ionChange` event is not necessarily fired for each alteration to an element's value.  The `ionChange` event is fired when the value has been committed by the user. This can happen when the element loses focus or when the "Enter" key is pressed. `ionChange` can also fire when clicking the clear or cancel buttons.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired for `&lt;ion-searchbar&gt;` elements when the user modifies the element's value. Unlike the `ionInput` event, the `ionChange` event is not necessarily fired for each alteration to an element's value.  The `ionChange` event is fired when the value has been committed by the user. This can happen when the element loses focus or when the "Enter" key is pressed. `ionChange` can also fire when clicking the clear or cancel buttons.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SearchbarChangeEventDetail>>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the clear input button is clicked.
    /// </summary>
    public static void OnIonClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionClear", action);
    }

    /// <summary>
    /// Emitted when the clear input button is clicked.
    /// </summary>
    public static void OnIonClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonClear(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the clear input button is clicked.
    /// </summary>
    public static void OnIonClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionClear", action);
    }

    /// <summary>
    /// Emitted when the clear input button is clicked.
    /// </summary>
    public static void OnIonClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonClear(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the `value` of the `ion-searchbar` element has changed.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

    /// <summary>
    /// Emitted when the `value` of the `ion-searchbar` element has changed.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the `value` of the `ion-searchbar` element has changed.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

    /// <summary>
    /// Emitted when the `value` of the `ion-searchbar` element has changed.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonSearchbar
    {
        b.OnIonInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the `value` of the `ion-searchbar` element has changed.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SearchbarInputEventDetail>>> action) where T: IonSearchbar
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

}