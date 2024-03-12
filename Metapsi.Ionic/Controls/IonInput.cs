using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonInput
{
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
    /// This attribute is ignored.
    /// </summary>
    public static void SetAccept(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("accept"), value);
    }
    /// <summary>
    /// This attribute is ignored.
    /// </summary>
    public static void SetAccept(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("accept"), b.Const(value));
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), value);
    }
    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("autocapitalize"), b.Const(value));
    }

    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteName(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteEmail(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("email"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTel(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteUrl(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("url"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOn(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("on"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOff(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("off"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteHonorificPrefix(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("honorific-prefix"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteGivenName(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("given-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAdditionalName(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("additional-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteFamilyName(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("family-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteHonorificSuffix(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("honorific-suffix"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteNickname(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("nickname"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteUsername(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("username"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteNewPassword(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("new-password"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCurrentPassword(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("current-password"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOneTimeCode(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("one-time-code"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOrganizationTitle(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("organization-title"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteOrganization(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("organization"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteStreetAddress(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("street-address"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine1(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line1"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine2(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line2"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLine3(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line3"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel4(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level4"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel3(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level3"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel2(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level2"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteAddressLevel1(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level1"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCountry(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("country"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCountryName(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("country-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompletePostalCode(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("postal-code"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcName(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcGivenName(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-given-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcAdditionalName(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-additional-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcFamilyName(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-family-name"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcNumber(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-number"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExp(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExpMonth(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp-month"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcExpYear(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp-year"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcCsc(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-csc"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteCcType(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-type"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTransactionCurrency(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("transaction-currency"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTransactionAmount(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("transaction-amount"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteLanguage(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("language"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBday(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayDay(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-day"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayMonth(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-month"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteBdayYear(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-year"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteSex(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("sex"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelCountryCode(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-country-code"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelNational(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-national"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelAreaCode(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-area-code"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelLocal(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-local"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteTelExtension(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-extension"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompleteImpp(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("impp"));
    }
    /// <summary>
    /// Indicates whether the value of the control can be automatically completed by the browser.
    /// </summary>
    public static void SetAutocompletePhoto(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("photo"));
    }

    /// <summary>
    /// Whether auto correction should be enabled when the user is entering/editing the text value.
    /// </summary>
    public static void SetAutocorrectOff(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocorrect"), b.Const("off"));
    }
    /// <summary>
    /// Whether auto correction should be enabled when the user is entering/editing the text value.
    /// </summary>
    public static void SetAutocorrectOn(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocorrect"), b.Const("on"));
    }

    /// <summary>
    /// Sets the [`autofocus` attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/autofocus) on the native input element.  This may not be sufficient for the element to be focused on page load. See [managing focus](/docs/developing/managing-focus) for more information.
    /// </summary>
    public static void SetAutofocus(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("autofocus"), b.Const(true));
    }

    /// <summary>
    /// If `true`, a clear icon will appear in the input when there is a value. Clicking it clears the input.
    /// </summary>
    public static void SetClearInput(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("clearInput"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the value will be cleared after focus upon edit. Defaults to `true` when `type` is `"password"`, `false` for all other types.
    /// </summary>
    public static void SetClearOnEdit(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("clearOnEdit"), b.Const(true));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a character counter will display the ratio of characters used and the total character limit. Developers must also set the `maxlength` property for the counter to be calculated correctly.
    /// </summary>
    public static void SetCounter(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("counter"), b.Const(true));
    }

    /// <summary>
    /// A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCounterFormatter(this PropsBuilder<IonInput> b, Var<Func<int,int,string>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,int,string>>("counterFormatter"), f);
    }
    /// <summary>
    /// A callback used to format the counter text. By default the counter text is set to "itemLength / maxLength".  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCounterFormatter(this PropsBuilder<IonInput> b, Func<SyntaxBuilder,Var<int>,Var<int>,Var<string>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,int,string>>("counterFormatter"), b.Def(f));
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce(this PropsBuilder<IonInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), value);
    }
    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce(this PropsBuilder<IonInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("done"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("enter"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("go"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("next"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("previous"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("search"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("send"));
    }

    /// <summary>
    /// Text that is placed under the input and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), value);
    }
    /// <summary>
    /// Text that is placed under the input and displayed when an error is detected.
    /// </summary>
    public static void SetErrorText(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("errorText"), b.Const(value));
    }

    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillOutline(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("outline"));
    }
    /// <summary>
    /// The fill for the item. If `"solid"` the item will have a background. If `"outline"` the item will be transparent with a border. Only available in `md` mode.
    /// </summary>
    public static void SetFillSolid(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("fill"), b.Const("solid"));
    }

    /// <summary>
    /// Text that is placed under the input and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), value);
    }
    /// <summary>
    /// Text that is placed under the input and displayed when no error is detected.
    /// </summary>
    public static void SetHelperText(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helperText"), b.Const(value));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("decimal"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("email"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("none"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("numeric"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("search"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("tel"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("text"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// The visible label associated with the input.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The visible label associated with the input.  Use this if you need to render a plaintext label.  The `label` property will take priority over the `label` slot if both are used.
    /// </summary>
    public static void SetLabel(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementEnd(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("end"));
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFixed(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("fixed"));
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementFloating(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("floating"));
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStacked(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("stacked"));
    }
    /// <summary>
    /// Where to place the label relative to the input. `"start"`: The label will appear to the left of the input in LTR and to the right in RTL. `"end"`: The label will appear to the right of the input in LTR and to the left in RTL. `"floating"`: The label will appear smaller and above the input when the input is focused or it has a value. Otherwise it will appear on top of the input. `"stacked"`: The label will appear smaller and above the input regardless even when the input is blurred or has no value. `"fixed"`: The label has the same behavior as `"start"` except it also has a fixed width. Long text will be truncated with ellipses ("...").
    /// </summary>
    public static void SetLabelPlacementStart(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("labelPlacement"), b.Const("start"));
    }

    /// <summary>
    /// Set the `legacy` property to `true` to forcibly use the legacy form control markup. Ionic will only opt components in to the modern form markup when they are using either the `aria-label` attribute or the `label` property. As a result, the `legacy` property should only be used as an escape hatch when you want to avoid this automatic opt-in behavior. Note that this property will be removed in an upcoming major release of Ionic, and all form components will be opted-in to using the modern form markup.
    /// </summary>
    public static void SetLegacy(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("legacy"), b.Const(true));
    }

    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax(this PropsBuilder<IonInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), value);
    }
    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax(this PropsBuilder<IonInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), b.Const(value));
    }
    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), value);
    }
    /// <summary>
    /// The maximum value, which must not be less than its minimum (min attribute) value.
    /// </summary>
    public static void SetMax(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("max"), b.Const(value));
    }

    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength(this PropsBuilder<IonInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), value);
    }
    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the maximum number of characters that the user can enter.
    /// </summary>
    public static void SetMaxlength(this PropsBuilder<IonInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxlength"), b.Const(value));
    }

    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin(this PropsBuilder<IonInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), value);
    }
    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin(this PropsBuilder<IonInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("min"), b.Const(value));
    }
    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), value);
    }
    /// <summary>
    /// The minimum value, which must not be greater than its maximum (max attribute) value.
    /// </summary>
    public static void SetMin(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("min"), b.Const(value));
    }

    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength(this PropsBuilder<IonInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), value);
    }
    /// <summary>
    /// If the value of the type attribute is `text`, `email`, `search`, `password`, `tel`, or `url`, this attribute specifies the minimum number of characters that the user can enter.
    /// </summary>
    public static void SetMinlength(this PropsBuilder<IonInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minlength"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the user can enter more than one value. This attribute applies when the type attribute is set to `"email"`, otherwise it is ignored.
    /// </summary>
    public static void SetMultiple(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), b.Const(true));
    }

    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// A regular expression that the value is checked against. The pattern must match the entire value, not just some subset. Use the title attribute to describe the pattern to help the user. This attribute applies when the value of the type attribute is `"text"`, `"search"`, `"tel"`, `"url"`, `"email"`, `"date"`, or `"password"`, otherwise it is ignored. When the type attribute is `"date"`, `pattern` will only be used in browsers that do not support the `"date"` input type natively. See https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date for more information.
    /// </summary>
    public static void SetPattern(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pattern"), value);
    }
    /// <summary>
    /// A regular expression that the value is checked against. The pattern must match the entire value, not just some subset. Use the title attribute to describe the pattern to help the user. This attribute applies when the value of the type attribute is `"text"`, `"search"`, `"tel"`, `"url"`, `"email"`, `"date"`, or `"password"`, otherwise it is ignored. When the type attribute is `"date"`, `pattern` will only be used in browsers that do not support the `"date"` input type natively. See https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date for more information.
    /// </summary>
    public static void SetPattern(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pattern"), b.Const(value));
    }

    /// <summary>
    /// Instructional text that shows before the input has a value. This property applies only when the `type` property is set to `"email"`, `"number"`, `"password"`, `"search"`, `"tel"`, `"text"`, or `"url"`, otherwise it is ignored.
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), value);
    }
    /// <summary>
    /// Instructional text that shows before the input has a value. This property applies only when the `type` property is set to `"email"`, `"number"`, `"password"`, `"search"`, `"tel"`, `"text"`, or `"url"`, otherwise it is ignored.
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("readonly"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the user must fill in a value before submitting a form.
    /// </summary>
    public static void SetRequired(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("required"), b.Const(true));
    }

    /// <summary>
    /// The shape of the input. If "round" it will have an increased border radius.
    /// </summary>
    public static void SetShapeRound(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("shape"), b.Const("round"));
    }

    /// <summary>
    /// 
    /// </summary>
    public static void SetSize(this PropsBuilder<IonInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("size"), value);
    }
    /// <summary>
    /// 
    /// </summary>
    public static void SetSize(this PropsBuilder<IonInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("size"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the element will have its spelling and grammar checked.
    /// </summary>
    public static void SetSpellcheck(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("spellcheck"), b.Const(true));
    }

    /// <summary>
    /// Works with the min and max attributes to limit the increments at which a value can be set. Possible values are: `"any"` or a positive floating point number.
    /// </summary>
    public static void SetStep(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("step"), value);
    }
    /// <summary>
    /// Works with the min and max attributes to limit the increments at which a value can be set. Possible values are: `"any"` or a positive floating point number.
    /// </summary>
    public static void SetStep(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("step"), b.Const(value));
    }

    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeDate(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("date"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeDatetimeLocal(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("datetime-local"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeEmail(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("email"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeMonth(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("month"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeNumber(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("number"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypePassword(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("password"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeSearch(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("search"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeTel(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("tel"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeText(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("text"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeTime(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("time"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeUrl(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("url"));
    }
    /// <summary>
    /// The type of control to display. The default type is text.
    /// </summary>
    public static void SetTypeWeek(this PropsBuilder<IonInput> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("week"));
    }

    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonInput> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonInput> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }
    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonInput> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The value of the input.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonInput> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonInput> b, Var<HyperType.Action<TModel, FocusEvent>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<FocusEvent>("detail"));
            return b.MakeActionDescriptor<TModel, FocusEvent>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionBlur"), eventAction);
    }
    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<FocusEvent>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<FocusEvent>("detail"));
            return b.MakeActionDescriptor<TModel, FocusEvent>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionBlur"), eventAction);
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  Depending on the way the users interacts with the element, the `ionChange` event fires at a different moment: - When the user commits the change explicitly (e.g. by selecting a date from a date picker for `<ion-input type="date">`, pressing the "Enter" key, etc.). - When the element loses focus after its value has changed: for elements where the user's interaction is typing.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonInput> b, Var<HyperType.Action<TModel, InputChangeEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<InputChangeEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, InputChangeEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionChange"), eventAction);
    }
    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  Depending on the way the users interacts with the element, the `ionChange` event fires at a different moment: - When the user commits the change explicitly (e.g. by selecting a date from a date picker for `<ion-input type="date">`, pressing the "Enter" key, etc.). - When the element loses focus after its value has changed: for elements where the user's interaction is typing.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<InputChangeEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<InputChangeEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, InputChangeEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionChange"), eventAction);
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonInput> b, Var<HyperType.Action<TModel, FocusEvent>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<FocusEvent>("detail"));
            return b.MakeActionDescriptor<TModel, FocusEvent>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionFocus"), eventAction);
    }
    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<FocusEvent>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<FocusEvent>("detail"));
            return b.MakeActionDescriptor<TModel, FocusEvent>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionFocus"), eventAction);
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<TModel>(this PropsBuilder<IonInput> b, Var<HyperType.Action<TModel, InputInputEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<InputInputEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, InputInputEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionInput"), eventAction);
    }
    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<TModel>(this PropsBuilder<IonInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<InputInputEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<InputInputEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, InputInputEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionInput"), eventAction);
    }

}

