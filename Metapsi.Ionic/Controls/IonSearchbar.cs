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
    /// <summary>
    /// If `true`, enable searchbar animation.
    /// </summary>
    public bool animated
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("animated");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("animated", value.ToString());
        }
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public string autocomplete
    {
        get
        {
            return this.GetTag().GetAttribute<string>("autocomplete");
        }
        set
        {
            this.GetTag().SetAttribute("autocomplete", value.ToString());
        }
    }

    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public string autocorrect
    {
        get
        {
            return this.GetTag().GetAttribute<string>("autocorrect");
        }
        set
        {
            this.GetTag().SetAttribute("autocorrect", value.ToString());
        }
    }

    /// <summary>
    /// Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`.
    /// </summary>
    public string cancelButtonIcon
    {
        get
        {
            return this.GetTag().GetAttribute<string>("cancelButtonIcon");
        }
        set
        {
            this.GetTag().SetAttribute("cancelButtonIcon", value.ToString());
        }
    }

    /// <summary>
    /// Set the the cancel button text. Only applies to `ios` mode.
    /// </summary>
    public string cancelButtonText
    {
        get
        {
            return this.GetTag().GetAttribute<string>("cancelButtonText");
        }
        set
        {
            this.GetTag().SetAttribute("cancelButtonText", value.ToString());
        }
    }

    /// <summary>
    /// Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`.
    /// </summary>
    public string clearIcon
    {
        get
        {
            return this.GetTag().GetAttribute<string>("clearIcon");
        }
        set
        {
            this.GetTag().SetAttribute("clearIcon", value.ToString());
        }
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public string color
    {
        get
        {
            return this.GetTag().GetAttribute<string>("color");
        }
        set
        {
            this.GetTag().SetAttribute("color", value.ToString());
        }
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public int debounce
    {
        get
        {
            return this.GetTag().GetAttribute<int>("debounce");
        }
        set
        {
            this.GetTag().SetAttribute("debounce", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public bool disabled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("disabled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("disabled", value.ToString());
        }
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public string enterkeyhint
    {
        get
        {
            return this.GetTag().GetAttribute<string>("enterkeyhint");
        }
        set
        {
            this.GetTag().SetAttribute("enterkeyhint", value.ToString());
        }
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public string inputmode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("inputmode");
        }
        set
        {
            this.GetTag().SetAttribute("inputmode", value.ToString());
        }
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("mode");
        }
        set
        {
            this.GetTag().SetAttribute("mode", value.ToString());
        }
    }

    /// <summary>
    /// If used in a form, set the name of the control, which is submitted with the form data.
    /// </summary>
    public string name
    {
        get
        {
            return this.GetTag().GetAttribute<string>("name");
        }
        set
        {
            this.GetTag().SetAttribute("name", value.ToString());
        }
    }

    /// <summary>
    /// Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)
    /// </summary>
    public string placeholder
    {
        get
        {
            return this.GetTag().GetAttribute<string>("placeholder");
        }
        set
        {
            this.GetTag().SetAttribute("placeholder", value.ToString());
        }
    }

    /// <summary>
    /// The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode.
    /// </summary>
    public string searchIcon
    {
        get
        {
            return this.GetTag().GetAttribute<string>("searchIcon");
        }
        set
        {
            this.GetTag().SetAttribute("searchIcon", value.ToString());
        }
    }

    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public string showCancelButton
    {
        get
        {
            return this.GetTag().GetAttribute<string>("showCancelButton");
        }
        set
        {
            this.GetTag().SetAttribute("showCancelButton", value.ToString());
        }
    }

    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public string showClearButton
    {
        get
        {
            return this.GetTag().GetAttribute<string>("showClearButton");
        }
        set
        {
            this.GetTag().SetAttribute("showClearButton", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, enable spellcheck on the input.
    /// </summary>
    public bool spellcheck
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("spellcheck");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("spellcheck", value.ToString());
        }
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public string type
    {
        get
        {
            return this.GetTag().GetAttribute<string>("type");
        }
        set
        {
            this.GetTag().SetAttribute("type", value.ToString());
        }
    }

    /// <summary>
    /// the value of the searchbar.
    /// </summary>
    public string value
    {
        get
        {
            return this.GetTag().GetAttribute<string>("value");
        }
        set
        {
            this.GetTag().SetAttribute("value", value.ToString());
        }
    }

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
    /// If `true`, enable searchbar animation.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteName(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteEmail(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("email"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTel(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteUrl(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("url"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOn(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("on"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOff(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("off"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteHonorificPrefix(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("honorific-prefix"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteGivenName(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("given-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAdditionalName(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("additional-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteFamilyName(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("family-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteHonorificSuffix(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("honorific-suffix"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteNickname(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("nickname"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteUsername(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("username"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteNewPassword(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("new-password"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCurrentPassword(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("current-password"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOneTimeCode(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("one-time-code"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOrganizationTitle(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("organization-title"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteOrganization(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("organization"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteStreetAddress(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("street-address"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine1(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line1"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine2(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line2"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLine3(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-line3"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel4(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level4"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel3(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level3"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel2(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level2"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteAddressLevel1(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("address-level1"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCountry(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("country"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCountryName(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("country-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompletePostalCode(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("postal-code"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcName(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcGivenName(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-given-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcAdditionalName(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-additional-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcFamilyName(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-family-name"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcNumber(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-number"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExp(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExpMonth(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp-month"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcExpYear(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-exp-year"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcCsc(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-csc"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteCcType(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("cc-type"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTransactionCurrency(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("transaction-currency"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTransactionAmount(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("transaction-amount"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteLanguage(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("language"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBday(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayDay(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-day"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayMonth(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-month"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteBdayYear(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("bday-year"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteSex(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("sex"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelCountryCode(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-country-code"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelNational(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-national"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelAreaCode(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-area-code"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelLocal(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-local"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteTelExtension(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("tel-extension"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompleteImpp(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("impp"));
    }
    /// <summary>
    /// Set the input's autocomplete property.
    /// </summary>
    public static void SetAutocompletePhoto(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocomplete"), b.Const("photo"));
    }

    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public static void SetAutocorrectOff(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocorrect"), b.Const("off"));
    }
    /// <summary>
    /// Set the input's autocorrect property.
    /// </summary>
    public static void SetAutocorrectOn(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("autocorrect"), b.Const("on"));
    }

    /// <summary>
    /// Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`.
    /// </summary>
    public static void SetCancelButtonIcon(this PropsBuilder<IonSearchbar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonIcon"), value);
    }
    /// <summary>
    /// Set the cancel button icon. Only applies to `md` mode. Defaults to `arrow-back-sharp`.
    /// </summary>
    public static void SetCancelButtonIcon(this PropsBuilder<IonSearchbar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonIcon"), b.Const(value));
    }

    /// <summary>
    /// Set the the cancel button text. Only applies to `ios` mode.
    /// </summary>
    public static void SetCancelButtonText(this PropsBuilder<IonSearchbar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonText"), value);
    }
    /// <summary>
    /// Set the the cancel button text. Only applies to `ios` mode.
    /// </summary>
    public static void SetCancelButtonText(this PropsBuilder<IonSearchbar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cancelButtonText"), b.Const(value));
    }

    /// <summary>
    /// Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`.
    /// </summary>
    public static void SetClearIcon(this PropsBuilder<IonSearchbar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("clearIcon"), value);
    }
    /// <summary>
    /// Set the clear icon. Defaults to `close-circle` for `ios` and `close-sharp` for `md`.
    /// </summary>
    public static void SetClearIcon(this PropsBuilder<IonSearchbar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("clearIcon"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonSearchbar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonSearchbar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce(this PropsBuilder<IonSearchbar> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), value);
    }
    /// <summary>
    /// Set the amount of time, in milliseconds, to wait to trigger the `ionInput` event after each keystroke.
    /// </summary>
    public static void SetDebounce(this PropsBuilder<IonSearchbar> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("debounce"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintDone(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("done"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintEnter(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("enter"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintGo(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("go"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintNext(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("next"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintPrevious(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("previous"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSearch(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("search"));
    }
    /// <summary>
    /// A hint to the browser for which enter key to display. Possible values: `"enter"`, `"done"`, `"go"`, `"next"`, `"previous"`, `"search"`, and `"send"`.
    /// </summary>
    public static void SetEnterkeyhintSend(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("enterkeyhint"), b.Const("send"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeDecimal(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("decimal"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeEmail(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("email"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNone(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("none"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeNumeric(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("numeric"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeSearch(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("search"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeTel(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("tel"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeText(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("text"));
    }
    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.
    /// </summary>
    public static void SetInputmodeUrl(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If used in a form, set the name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonSearchbar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// If used in a form, set the name of the control, which is submitted with the form data.
    /// </summary>
    public static void SetName(this PropsBuilder<IonSearchbar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<IonSearchbar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), value);
    }
    /// <summary>
    /// Set the input's placeholder. `placeholder` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<IonSearchbar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(value));
    }

    /// <summary>
    /// The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode.
    /// </summary>
    public static void SetSearchIcon(this PropsBuilder<IonSearchbar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("searchIcon"), value);
    }
    /// <summary>
    /// The icon to use as the search icon. Defaults to `search-outline` in `ios` mode and `search-sharp` in `md` mode.
    /// </summary>
    public static void SetSearchIcon(this PropsBuilder<IonSearchbar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("searchIcon"), b.Const(value));
    }

    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonAlways(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showCancelButton"), b.Const("always"));
    }
    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonFocus(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showCancelButton"), b.Const("focus"));
    }
    /// <summary>
    /// Sets the behavior for the cancel button. Defaults to `"never"`. Setting to `"focus"` shows the cancel button on focus. Setting to `"never"` hides the cancel button. Setting to `"always"` shows the cancel button regardless of focus state.
    /// </summary>
    public static void SetShowCancelButtonNever(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showCancelButton"), b.Const("never"));
    }

    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonAlways(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showClearButton"), b.Const("always"));
    }
    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonFocus(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showClearButton"), b.Const("focus"));
    }
    /// <summary>
    /// Sets the behavior for the clear button. Defaults to `"focus"`. Setting to `"focus"` shows the clear button on focus if the input is not empty. Setting to `"never"` hides the clear button. Setting to `"always"` shows the clear button regardless of focus state, but only if the input is not empty.
    /// </summary>
    public static void SetShowClearButtonNever(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("showClearButton"), b.Const("never"));
    }

    /// <summary>
    /// If `true`, enable spellcheck on the input.
    /// </summary>
    public static void SetSpellcheck(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("spellcheck"), b.Const(true));
    }

    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeEmail(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("email"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeNumber(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("number"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypePassword(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("password"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeSearch(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("search"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeTel(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("tel"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeText(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("text"));
    }
    /// <summary>
    /// Set the type of the input.
    /// </summary>
    public static void SetTypeUrl(this PropsBuilder<IonSearchbar> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("url"));
    }

    /// <summary>
    /// the value of the searchbar.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonSearchbar> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// the value of the searchbar.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonSearchbar> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonSearchbar> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// Emitted when the input loses focus.
    /// </summary>
    public static void OnIonBlur<TModel>(this PropsBuilder<IonSearchbar> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the cancel button is clicked.
    /// </summary>
    public static void OnIonCancel<TModel>(this PropsBuilder<IonSearchbar> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionCancel", action);
    }
    /// <summary>
    /// Emitted when the cancel button is clicked.
    /// </summary>
    public static void OnIonCancel<TModel>(this PropsBuilder<IonSearchbar> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionCancel", b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired for `<ion-searchbar>` elements when the user modifies the element's value. Unlike the `ionInput` event, the `ionChange` event is not necessarily fired for each alteration to an element's value.  The `ionChange` event is fired when the value has been committed by the user. This can happen when the element loses focus or when the "Enter" key is pressed. `ionChange` can also fire when clicking the clear or cancel buttons.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonSearchbar> b, Var<HyperType.Action<TModel, SearchbarChangeEventDetail>> action)
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// The `ionChange` event is fired for `<ion-searchbar>` elements when the user modifies the element's value. Unlike the `ionInput` event, the `ionChange` event is not necessarily fired for each alteration to an element's value.  The `ionChange` event is fired when the value has been committed by the user. This can happen when the element loses focus or when the "Enter" key is pressed. `ionChange` can also fire when clicking the clear or cancel buttons.
    /// </summary>
    public static void OnIonChange<TModel>(this PropsBuilder<IonSearchbar> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SearchbarChangeEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the clear input button is clicked.
    /// </summary>
    public static void OnIonClear<TModel>(this PropsBuilder<IonSearchbar> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionClear", action);
    }
    /// <summary>
    /// Emitted when the clear input button is clicked.
    /// </summary>
    public static void OnIonClear<TModel>(this PropsBuilder<IonSearchbar> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionClear", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonSearchbar> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// Emitted when the input has focus.
    /// </summary>
    public static void OnIonFocus<TModel>(this PropsBuilder<IonSearchbar> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the `value` of the `ion-searchbar` element has changed.
    /// </summary>
    public static void OnIonInput<TModel>(this PropsBuilder<IonSearchbar> b, Var<HyperType.Action<TModel, SearchbarInputEventDetail>> action)
    {
        b.OnEventAction("onionInput", action, "detail");
    }
    /// <summary>
    /// Emitted when the `value` of the `ion-searchbar` element has changed.
    /// </summary>
    public static void OnIonInput<TModel>(this PropsBuilder<IonSearchbar> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SearchbarInputEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionInput", b.MakeAction(action), "detail");
    }

}

