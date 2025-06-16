using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Formats a number using the specified locale and options.
/// </summary>
public partial class SlFormatNumber
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
    }
}
/// <summary>
/// Setter extensions of SlFormatNumber
/// </summary>
public static partial class SlFormatNumberControl
{
    /// <summary>
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatNumber(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlFormatNumber>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-format-number", buildAttributes, children);
    }

    /// <summary>
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatNumber(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-format-number", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatNumber(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlFormatNumber>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-format-number", buildAttributes, children);
    }

    /// <summary>
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlFormatNumber(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-format-number", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetTypeCurrency(this Metapsi.Html.AttributesBuilder<SlFormatNumber> b) 
    {
        b.SetAttribute("type", "currency");
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetTypeDecimal(this Metapsi.Html.AttributesBuilder<SlFormatNumber> b) 
    {
        b.SetAttribute("type", "decimal");
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetTypePercent(this Metapsi.Html.AttributesBuilder<SlFormatNumber> b) 
    {
        b.SetAttribute("type", "percent");
    }

    /// <summary>
    /// Turns off grouping separators.
    /// </summary>
    public static void SetNoGrouping(this Metapsi.Html.AttributesBuilder<SlFormatNumber> b, bool noGrouping) 
    {
        if (noGrouping) b.SetAttribute("no-grouping", "");
    }

    /// <summary>
    /// Turns off grouping separators.
    /// </summary>
    public static void SetNoGrouping(this Metapsi.Html.AttributesBuilder<SlFormatNumber> b) 
    {
        b.SetAttribute("no-grouping", "");
    }

    /// <summary>
    /// The [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code to use when formatting.
    /// </summary>
    public static void SetCurrency(this Metapsi.Html.AttributesBuilder<SlFormatNumber> b, string currency) 
    {
        b.SetAttribute("currency", currency);
    }

    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplaySymbol(this Metapsi.Html.AttributesBuilder<SlFormatNumber> b) 
    {
        b.SetAttribute("currency-display", "symbol");
    }

    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayNarrowSymbol(this Metapsi.Html.AttributesBuilder<SlFormatNumber> b) 
    {
        b.SetAttribute("currency-display", "narrowSymbol");
    }

    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayCode(this Metapsi.Html.AttributesBuilder<SlFormatNumber> b) 
    {
        b.SetAttribute("currency-display", "code");
    }

    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayName(this Metapsi.Html.AttributesBuilder<SlFormatNumber> b) 
    {
        b.SetAttribute("currency-display", "name");
    }

    /// <summary>
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatNumber(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlFormatNumber>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-format-number", buildProps, children);
    }

    /// <summary>
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatNumber(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-format-number", children);
    }

    /// <summary>
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatNumber(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlFormatNumber>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-format-number", buildProps, children);
    }

    /// <summary>
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlFormatNumber(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-format-number", children);
    }

    /// <summary>
    /// The number to format.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> value) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The number to format.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> value) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetTypeCurrency<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("currency"));
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetTypeDecimal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("decimal"));
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetTypePercent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("percent"));
    }

    /// <summary>
    /// Turns off grouping separators.
    /// </summary>
    public static void SetNoGrouping<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetNoGrouping(b.Const(true));
    }

    /// <summary>
    /// Turns off grouping separators.
    /// </summary>
    public static void SetNoGrouping<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> noGrouping) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("noGrouping"), noGrouping);
    }

    /// <summary>
    /// Turns off grouping separators.
    /// </summary>
    public static void SetNoGrouping<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool noGrouping) where T: SlFormatNumber
    {
        b.SetNoGrouping(b.Const(noGrouping));
    }

    /// <summary>
    /// The [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code to use when formatting.
    /// </summary>
    public static void SetCurrency<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> currency) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("currency"), currency);
    }

    /// <summary>
    /// The [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code to use when formatting.
    /// </summary>
    public static void SetCurrency<T>(this Metapsi.Syntax.PropsBuilder<T> b, string currency) where T: SlFormatNumber
    {
        b.SetCurrency(b.Const(currency));
    }

    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplaySymbol<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("currencyDisplay"), b.Const("symbol"));
    }

    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayNarrowSymbol<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("currencyDisplay"), b.Const("narrowSymbol"));
    }

    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayCode<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("currencyDisplay"), b.Const("code"));
    }

    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayName<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("currencyDisplay"), b.Const("name"));
    }

    /// <summary>
    /// The minimum number of integer digits to use. Possible values are 1-21.
    /// </summary>
    public static void SetMinimumIntegerDigits<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> minimumIntegerDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("minimumIntegerDigits"), minimumIntegerDigits);
    }

    /// <summary>
    /// The minimum number of fraction digits to use. Possible values are 0-20.
    /// </summary>
    public static void SetMinimumFractionDigits<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> minimumFractionDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("minimumFractionDigits"), minimumFractionDigits);
    }

    /// <summary>
    /// The maximum number of fraction digits to use. Possible values are 0-0.
    /// </summary>
    public static void SetMaximumFractionDigits<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> maximumFractionDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("maximumFractionDigits"), maximumFractionDigits);
    }

    /// <summary>
    /// The minimum number of significant digits to use. Possible values are 1-21.
    /// </summary>
    public static void SetMinimumSignificantDigits<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> minimumSignificantDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("minimumSignificantDigits"), minimumSignificantDigits);
    }

    /// <summary>
    /// The maximum number of significant digits to use,. Possible values are 1-21.
    /// </summary>
    public static void SetMaximumSignificantDigits<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> maximumSignificantDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("maximumSignificantDigits"), maximumSignificantDigits);
    }

}