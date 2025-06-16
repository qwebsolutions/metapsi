using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonInput
{
    /// <summary>
    /// 
    /// </summary>
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
        /// Sets focus on the native `input` in `ion-input`. Use this method instead of the global `input.focus()`.  Developers who wish to focus an input when a page enters should call `setFocus()` in the `ionViewDidEnter()` lifecycle method.  Developers who wish to focus an input when an overlay is presented should call `setFocus` after `didPresent` has resolved.  See [managing focus](/docs/developing/managing-focus) for more information.
        /// </summary>
        public const string SetFocus = "setFocus";
    }
}
/// <summary>
/// Setter extensions of IonInput
/// </summary>
public static partial class IonInputControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInput(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonInput>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-input", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInput(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-input", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInput(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonInput>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-input", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInput(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-input", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize(this Metapsi.Html.AttributesBuilder<IonInput> b, string autocapitalize) 
    {
        b.SetAttribute("autocapitalize", autocapitalize);
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteName(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "name");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteEmail(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "email");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTel(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "tel");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteUrl(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "url");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOn(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "on");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOff(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "off");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteHonorificPrefix(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "honorific-prefix");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteGivenName(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "given-name");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAdditionalName(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "additional-name");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteFamilyName(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "family-name");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteHonorificSuffix(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "honorific-suffix");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteNickname(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "nickname");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteUsername(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "username");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteNewPassword(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "new-password");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCurrentPassword(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "current-password");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOneTimeCode(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "one-time-code");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOrganizationTitle(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "organization-title");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOrganization(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "organization");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteStreetAddress(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "street-address");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine1(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "address-line1");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine2(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "address-line2");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine3(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "address-line3");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel4(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "address-level4");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel3(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "address-level3");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel2(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "address-level2");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel1(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "address-level1");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCountry(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "country");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCountryName(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "country-name");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompletePostalCode(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "postal-code");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcName(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "cc-name");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcGivenName(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "cc-given-name");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcAdditionalName(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "cc-additional-name");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcFamilyName(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "cc-family-name");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcNumber(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "cc-number");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExp(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "cc-exp");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExpMonth(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "cc-exp-month");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExpYear(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "cc-exp-year");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcCsc(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "cc-csc");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcType(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "cc-type");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTransactionCurrency(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "transaction-currency");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTransactionAmount(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "transaction-amount");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteLanguage(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "language");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBday(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "bday");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayDay(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "bday-day");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayMonth(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "bday-month");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayYear(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "bday-year");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteSex(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "sex");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelCountryCode(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "tel-country-code");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelNational(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "tel-national");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelAreaCode(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "tel-area-code");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelLocal(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "tel-local");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelExtension(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "tel-extension");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteImpp(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "impp");
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompletePhoto(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocomplete", "photo");
    }

    /// <summary>
    /// Whether auto correction should be enabled when the user is entering/editing the text value.
    /// </summary>
    public static void SetAutocorrectOff(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocorrect", "off");
    }

    /// <summary>
    /// Whether auto correction should be enabled when the user is entering/editing the text value.
    /// </summary>
    public static void SetAutocorrectOn(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autocorrect", "on");
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus(this Metapsi.Html.AttributesBuilder<IonInput> b, bool autofocus) 
    {
        if (autofocus) b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("autofocus", "");
    }

    /// <summary>
    /// If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input.
    /// </summary>
    public static void SetClearInput(this Metapsi.Html.AttributesBuilder<IonInput> b, bool clearInput) 
    {
        if (clearInput) b.SetAttribute("clearInput", "");
    }

    /// <summary>
    /// If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input.
    /// </summary>
    public static void SetClearInput(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("clearInput", "");
    }

    /// <summary>
    /// The icon to use for the clear button. Only applies when `clearInput` is set to `true`.
    /// </summary>
    public static void SetClearInputIcon(this Metapsi.Html.AttributesBuilder<IonInput> b, string clearInputIcon) 
    {
        b.SetAttribute("clearInputIcon", clearInputIcon);
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types.
    /// </summary>
    public static void SetClearOnEdit(this Metapsi.Html.AttributesBuilder<IonInput> b, bool clearOnEdit) 
    {
        if (clearOnEdit) b.SetAttribute("clearOnEdit", "");
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types.
    /// </summary>
    public static void SetClearOnEdit(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("clearOnEdit", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonInput> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter(this Metapsi.Html.AttributesBuilder<IonInput> b, bool counter) 
    {
        if (counter) b.SetAttribute("counter", "");
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("counter", "");
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce(this Metapsi.Html.AttributesBuilder<IonInput> b, string debounce) 
    {
        b.SetAttribute("debounce", debounce);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonInput> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("enterkeyhint", "done");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("enterkeyhint", "enter");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("enterkeyhint", "go");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("enterkeyhint", "next");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("enterkeyhint", "previous");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("enterkeyhint", "search");
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("enterkeyhint", "send");
    }

    /// <summary>
    /// Text that is placed under the input and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText(this Metapsi.Html.AttributesBuilder<IonInput> b, string errorText) 
    {
        b.SetAttribute("errorText", errorText);
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("fill", "outline");
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// Text that is placed under the input and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText(this Metapsi.Html.AttributesBuilder<IonInput> b, string helperText) 
    {
        b.SetAttribute("helperText", helperText);
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("inputmode", "decimal");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("inputmode", "email");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("inputmode", "none");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("inputmode", "numeric");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("inputmode", "search");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("inputmode", "tel");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("inputmode", "text");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// The visible label associated with the input.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<IonInput> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementEnd(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("labelPlacement", "end");
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFixed(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("labelPlacement", "fixed");
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFloating(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("labelPlacement", "floating");
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStacked(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("labelPlacement", "stacked");
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStart(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("labelPlacement", "start");
    }

    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax(this Metapsi.Html.AttributesBuilder<IonInput> b, string max) 
    {
        b.SetAttribute("max", max);
    }

    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength(this Metapsi.Html.AttributesBuilder<IonInput> b, string maxlength) 
    {
        b.SetAttribute("maxlength", maxlength);
    }

    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin(this Metapsi.Html.AttributesBuilder<IonInput> b, string min) 
    {
        b.SetAttribute("min", min);
    }

    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength(this Metapsi.Html.AttributesBuilder<IonInput> b, string minlength) 
    {
        b.SetAttribute("minlength", minlength);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored.
    /// </summary>
    public static void SetMultiple(this Metapsi.Html.AttributesBuilder<IonInput> b, bool multiple) 
    {
        if (multiple) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored.
    /// </summary>
    public static void SetMultiple(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<IonInput> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// A regular expression that the value is checked against. The pattern must match the entire value, not just some subset. Use the title attribute to describe the pattern to help the user. This attribute applies when the value of the type attribute is `"text"`, `"search"`, `"tel"`, `"url"`, `"email"`, `"date"`, or `"password"`, otherwise it is ignored. When the type attribute is `"date"`, `pattern` will only be used in browsers that do not support the `"date"` input type natively. See https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date for more information.
    /// </summary>
    public static void SetPattern(this Metapsi.Html.AttributesBuilder<IonInput> b, string pattern) 
    {
        b.SetAttribute("pattern", pattern);
    }

    /// <summary>
    /// Instructional text that shows before the input has a value. This property applies only when the `type` property is set to `"email"`, `"number"`, `"password"`, `"search"`, `"tel"`, `"text"`, or `"url"`, otherwise it is ignored.
    /// </summary>
    public static void SetPlaceholder(this Metapsi.Html.AttributesBuilder<IonInput> b, string placeholder) 
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<IonInput> b, bool @readonly) 
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<IonInput> b, bool required) 
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// The shape of the input. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck(this Metapsi.Html.AttributesBuilder<IonInput> b, bool spellcheck) 
    {
        if (spellcheck) b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("spellcheck", "");
    }

    /// <summary>
    /// Works with the min and max attributes to limit the increments at which a value can be set. Possible values are: `"any"` or a positive floating point number.
    /// </summary>
    public static void SetStep(this Metapsi.Html.AttributesBuilder<IonInput> b, string step) 
    {
        b.SetAttribute("step", step);
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeDate(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "date");
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeDatetimeLocal(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "datetime-local");
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeEmail(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "email");
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeMonth(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "month");
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeNumber(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "number");
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypePassword(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "password");
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeSearch(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "search");
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeTel(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "tel");
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeText(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "text");
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeTime(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "time");
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeUrl(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "url");
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeWeek(this Metapsi.Html.AttributesBuilder<IonInput> b) 
    {
        b.SetAttribute("type", "week");
    }

    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<IonInput> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInput(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonInput>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-input", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInput(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-input", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInput(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonInput>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-input", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInput(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-input", children);
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> autocapitalize) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocapitalize"), autocapitalize);
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this Metapsi.Syntax.PropsBuilder<T> b, string autocapitalize) where T: IonInput
    {
        b.SetAutocapitalize(b.Const(autocapitalize));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("name"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteEmail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("email"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("url"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOn<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("on"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOff<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("off"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteHonorificPrefix<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("honorific-prefix"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteGivenName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("given-name"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAdditionalName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("additional-name"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteFamilyName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("family-name"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteHonorificSuffix<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("honorific-suffix"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteNickname<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("nickname"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteUsername<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("username"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteNewPassword<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("new-password"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCurrentPassword<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("current-password"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOneTimeCode<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("one-time-code"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOrganizationTitle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("organization-title"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOrganization<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("organization"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteStreetAddress<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("street-address"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine1<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-line1"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine2<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-line2"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine3<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-line3"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel4<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-level4"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel3<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-level3"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel2<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-level2"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel1<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("address-level1"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCountry<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("country"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCountryName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("country-name"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompletePostalCode<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("postal-code"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-name"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcGivenName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-given-name"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcAdditionalName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-additional-name"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcFamilyName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-family-name"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcNumber<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-number"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExp<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-exp"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExpMonth<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-exp-month"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExpYear<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-exp-year"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcCsc<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-csc"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcType<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("cc-type"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTransactionCurrency<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("transaction-currency"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTransactionAmount<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("transaction-amount"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteLanguage<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("language"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBday<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("bday"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayDay<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("bday-day"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayMonth<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("bday-month"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayYear<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("bday-year"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteSex<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("sex"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelCountryCode<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel-country-code"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelNational<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel-national"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelAreaCode<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel-area-code"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelLocal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel-local"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelExtension<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("tel-extension"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteImpp<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("impp"));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompletePhoto<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("photo"));
    }

    /// <summary>
    /// Whether auto correction should be enabled when the user is entering/editing the text value.
    /// </summary>
    public static void SetAutocorrectOff<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocorrect"), b.Const("off"));
    }

    /// <summary>
    /// Whether auto correction should be enabled when the user is entering/editing the text value.
    /// </summary>
    public static void SetAutocorrectOn<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autocorrect"), b.Const("on"));
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetAutofocus(b.Const(true));
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> autofocus) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("autofocus"), autofocus);
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool autofocus) where T: IonInput
    {
        b.SetAutofocus(b.Const(autofocus));
    }

    /// <summary>
    /// If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input.
    /// </summary>
    public static void SetClearInput<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetClearInput(b.Const(true));
    }

    /// <summary>
    /// If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input.
    /// </summary>
    public static void SetClearInput<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> clearInput) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("clearInput"), clearInput);
    }

    /// <summary>
    /// If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input.
    /// </summary>
    public static void SetClearInput<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool clearInput) where T: IonInput
    {
        b.SetClearInput(b.Const(clearInput));
    }

    /// <summary>
    /// The icon to use for the clear button. Only applies when `clearInput` is set to `true`.
    /// </summary>
    public static void SetClearInputIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> clearInputIcon) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("clearInputIcon"), clearInputIcon);
    }

    /// <summary>
    /// The icon to use for the clear button. Only applies when `clearInput` is set to `true`.
    /// </summary>
    public static void SetClearInputIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, string clearInputIcon) where T: IonInput
    {
        b.SetClearInputIcon(b.Const(clearInputIcon));
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types.
    /// </summary>
    public static void SetClearOnEdit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetClearOnEdit(b.Const(true));
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types.
    /// </summary>
    public static void SetClearOnEdit<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> clearOnEdit) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("clearOnEdit"), clearOnEdit);
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types.
    /// </summary>
    public static void SetClearOnEdit<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool clearOnEdit) where T: IonInput
    {
        b.SetClearOnEdit(b.Const(clearOnEdit));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetCounter(b.Const(true));
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> counter) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("counter"), counter);
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool counter) where T: IonInput
    {
        b.SetCounter(b.Const(counter));
    }

    /// <summary>
    /// A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCounterFormatter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<int, int, string>> counterFormatter) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("counterFormatter"), counterFormatter);
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> debounce) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("debounce"), debounce);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonInput
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("done"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("enter"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("go"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("next"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("previous"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("search"));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("enterkeyhint"), b.Const("send"));
    }

    /// <summary>
    /// Text that is placed under the input and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> errorText) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("errorText"), errorText);
    }

    /// <summary>
    /// Text that is placed under the input and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string errorText) where T: IonInput
    {
        b.SetErrorText(b.Const(errorText));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const("outline"));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("fill"), b.Const("solid"));
    }

    /// <summary>
    /// Text that is placed under the input and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helperText) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("helperText"), helperText);
    }

    /// <summary>
    /// Text that is placed under the input and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helperText) where T: IonInput
    {
        b.SetHelperText(b.Const(helperText));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("decimal"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("email"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("none"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("numeric"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("search"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("tel"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("text"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// The visible label associated with the input.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The visible label associated with the input.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: IonInput
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("end"));
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFixed<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("fixed"));
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFloating<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("floating"));
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStacked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("stacked"));
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> max) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> max) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> maxlength) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("maxlength"), maxlength);
    }

    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> min) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("min"), min);
    }

    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> min) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("min"), min);
    }

    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> minlength) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("minlength"), minlength);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetMultiple(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> multiple) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("multiple"), multiple);
    }

    /// <summary>
    /// If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool multiple) where T: IonInput
    {
        b.SetMultiple(b.Const(multiple));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: IonInput
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// A regular expression that the value is checked against. The pattern must match the entire value, not just some subset. Use the title attribute to describe the pattern to help the user. This attribute applies when the value of the type attribute is `"text"`, `"search"`, `"tel"`, `"url"`, `"email"`, `"date"`, or `"password"`, otherwise it is ignored. When the type attribute is `"date"`, `pattern` will only be used in browsers that do not support the `"date"` input type natively. See https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date for more information.
    /// </summary>
    public static void SetPattern<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pattern) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("pattern"), pattern);
    }

    /// <summary>
    /// A regular expression that the value is checked against. The pattern must match the entire value, not just some subset. Use the title attribute to describe the pattern to help the user. This attribute applies when the value of the type attribute is `"text"`, `"search"`, `"tel"`, `"url"`, `"email"`, `"date"`, or `"password"`, otherwise it is ignored. When the type attribute is `"date"`, `pattern` will only be used in browsers that do not support the `"date"` input type natively. See https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date for more information.
    /// </summary>
    public static void SetPattern<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pattern) where T: IonInput
    {
        b.SetPattern(b.Const(pattern));
    }

    /// <summary>
    /// Instructional text that shows before the input has a value. This property applies only when the `type` property is set to `"email"`, `"number"`, `"password"`, `"search"`, `"tel"`, `"text"`, or `"url"`, otherwise it is ignored.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> placeholder) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }

    /// <summary>
    /// Instructional text that shows before the input has a value. This property applies only when the `type` property is set to `"email"`, `"number"`, `"password"`, `"search"`, `"tel"`, `"text"`, or `"url"`, otherwise it is ignored.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, string placeholder) where T: IonInput
    {
        b.SetPlaceholder(b.Const(placeholder));
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetReadonly(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @readonly) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("readonly"), @readonly);
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @readonly) where T: IonInput
    {
        b.SetReadonly(b.Const(@readonly));
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetRequired(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> required) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool required) where T: IonInput
    {
        b.SetRequired(b.Const(required));
    }

    /// <summary>
    /// The shape of the input. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("round"));
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetSpellcheck(b.Const(true));
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> spellcheck) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("spellcheck"), spellcheck);
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool spellcheck) where T: IonInput
    {
        b.SetSpellcheck(b.Const(spellcheck));
    }

    /// <summary>
    /// Works with the min and max attributes to limit the increments at which a value can be set. Possible values are: `"any"` or a positive floating point number.
    /// </summary>
    public static void SetStep<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> step) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("step"), step);
    }

    /// <summary>
    /// Works with the min and max attributes to limit the increments at which a value can be set. Possible values are: `"any"` or a positive floating point number.
    /// </summary>
    public static void SetStep<T>(this Metapsi.Syntax.PropsBuilder<T> b, string step) where T: IonInput
    {
        b.SetStep(b.Const(step));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeDate<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("date"));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeDatetimeLocal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("datetime-local"));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeEmail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("email"));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeMonth<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("month"));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeNumber<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("number"));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypePassword<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("password"));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("search"));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeTel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("tel"));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("text"));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeTime<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("time"));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("url"));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeWeek<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("week"));
    }

    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> value) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: IonInput
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonInput
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonInput
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<FocusEvent>>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionBlur", action);
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  Depending on the way the users interacts with the element, the `ionChange` event fires at a different moment: - When the user commits the change explicitly (e.g. by selecting a date from a date picker for `&lt;ion-input type="date"&gt;`, pressing the "Enter" key, etc.). - When the element loses focus after its value has changed: for elements where the user's interaction is typing.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  Depending on the way the users interacts with the element, the `ionChange` event fires at a different moment: - When the user commits the change explicitly (e.g. by selecting a date from a date picker for `&lt;ion-input type="date"&gt;`, pressing the "Enter" key, etc.). - When the element loses focus after its value has changed: for elements where the user's interaction is typing.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonInput
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  Depending on the way the users interacts with the element, the `ionChange` event fires at a different moment: - When the user commits the change explicitly (e.g. by selecting a date from a date picker for `&lt;ion-input type="date"&gt;`, pressing the "Enter" key, etc.). - When the element loses focus after its value has changed: for elements where the user's interaction is typing.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  Depending on the way the users interacts with the element, the `ionChange` event fires at a different moment: - When the user commits the change explicitly (e.g. by selecting a date from a date picker for `&lt;ion-input type="date"&gt;`, pressing the "Enter" key, etc.). - When the element loses focus after its value has changed: for elements where the user's interaction is typing.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonInput
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  Depending on the way the users interacts with the element, the `ionChange` event fires at a different moment: - When the user commits the change explicitly (e.g. by selecting a date from a date picker for `&lt;ion-input type="date"&gt;`, pressing the "Enter" key, etc.). - When the element loses focus after its value has changed: for elements where the user's interaction is typing.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<InputChangeEventDetail>>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionChange", action);
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonInput
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonInput
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<FocusEvent>>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionFocus", action);
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonInput
    {
        b.OnIonInput(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonInput
    {
        b.OnIonInput(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<InputInputEventDetail>>> action) where T: IonInput
    {
        b.SetProperty(b.Props, "onionInput", action);
    }

}