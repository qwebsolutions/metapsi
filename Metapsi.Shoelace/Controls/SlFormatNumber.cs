using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlFormatNumber
{
}

public static partial class SlFormatNumberControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatNumber(this HtmlBuilder b, Action<AttributesBuilder<SlFormatNumber>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-format-number", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatNumber(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-format-number", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatNumber(this HtmlBuilder b, Action<AttributesBuilder<SlFormatNumber>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-format-number", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlFormatNumber(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-format-number", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The number to format. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlFormatNumber> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<SlFormatNumber> b, string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetTypeCurrency(this AttributesBuilder<SlFormatNumber> b)
    {
        b.SetAttribute("type", "currency");
    }

    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetTypeDecimal(this AttributesBuilder<SlFormatNumber> b)
    {
        b.SetAttribute("type", "decimal");
    }

    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetTypePercent(this AttributesBuilder<SlFormatNumber> b)
    {
        b.SetAttribute("type", "percent");
    }

    /// <summary>
    /// <para> Turns off grouping separators. </para>
    /// </summary>
    public static void SetNoGrouping(this AttributesBuilder<SlFormatNumber> b)
    {
        b.SetAttribute("no-grouping", "");
    }

    /// <summary>
    /// <para> Turns off grouping separators. </para>
    /// </summary>
    public static void SetNoGrouping(this AttributesBuilder<SlFormatNumber> b, bool noGrouping)
    {
        if (noGrouping) b.SetAttribute("no-grouping", "");
    }

    /// <summary>
    /// <para> The [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code to use when formatting. </para>
    /// </summary>
    public static void SetCurrency(this AttributesBuilder<SlFormatNumber> b, string currency)
    {
        b.SetAttribute("currency", currency);
    }

    /// <summary>
    /// <para> How to display the currency. </para>
    /// </summary>
    public static void SetCurrencyDisplay(this AttributesBuilder<SlFormatNumber> b, string currencyDisplay)
    {
        b.SetAttribute("currency-display", currencyDisplay);
    }

    /// <summary>
    /// <para> How to display the currency. </para>
    /// </summary>
    public static void SetCurrencyDisplaySymbol(this AttributesBuilder<SlFormatNumber> b)
    {
        b.SetAttribute("currency-display", "symbol");
    }

    /// <summary>
    /// <para> How to display the currency. </para>
    /// </summary>
    public static void SetCurrencyDisplayNarrowSymbol(this AttributesBuilder<SlFormatNumber> b)
    {
        b.SetAttribute("currency-display", "narrowSymbol");
    }

    /// <summary>
    /// <para> How to display the currency. </para>
    /// </summary>
    public static void SetCurrencyDisplayCode(this AttributesBuilder<SlFormatNumber> b)
    {
        b.SetAttribute("currency-display", "code");
    }

    /// <summary>
    /// <para> How to display the currency. </para>
    /// </summary>
    public static void SetCurrencyDisplayName(this AttributesBuilder<SlFormatNumber> b)
    {
        b.SetAttribute("currency-display", "name");
    }

    /// <summary>
    /// <para> The minimum number of integer digits to use. Possible values are 1-21. </para>
    /// </summary>
    public static void SetMinimumIntegerDigits(this AttributesBuilder<SlFormatNumber> b, string minimumIntegerDigits)
    {
        b.SetAttribute("minimum-integer-digits", minimumIntegerDigits);
    }

    /// <summary>
    /// <para> The minimum number of fraction digits to use. Possible values are 0-20. </para>
    /// </summary>
    public static void SetMinimumFractionDigits(this AttributesBuilder<SlFormatNumber> b, string minimumFractionDigits)
    {
        b.SetAttribute("minimum-fraction-digits", minimumFractionDigits);
    }

    /// <summary>
    /// <para> The maximum number of fraction digits to use. Possible values are 0-0. </para>
    /// </summary>
    public static void SetMaximumFractionDigits(this AttributesBuilder<SlFormatNumber> b, string maximumFractionDigits)
    {
        b.SetAttribute("maximum-fraction-digits", maximumFractionDigits);
    }

    /// <summary>
    /// <para> The minimum number of significant digits to use. Possible values are 1-21. </para>
    /// </summary>
    public static void SetMinimumSignificantDigits(this AttributesBuilder<SlFormatNumber> b, string minimumSignificantDigits)
    {
        b.SetAttribute("minimum-significant-digits", minimumSignificantDigits);
    }

    /// <summary>
    /// <para> The maximum number of significant digits to use,. Possible values are 1-21. </para>
    /// </summary>
    public static void SetMaximumSignificantDigits(this AttributesBuilder<SlFormatNumber> b, string maximumSignificantDigits)
    {
        b.SetAttribute("maximum-significant-digits", maximumSignificantDigits);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatNumber(this LayoutBuilder b, Action<PropsBuilder<SlFormatNumber>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-format-number", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatNumber(this LayoutBuilder b, Action<PropsBuilder<SlFormatNumber>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-format-number", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatNumber(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-format-number", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlFormatNumber(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-format-number", children);
    }
    /// <summary>
    /// <para> The number to format. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> The number to format. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetTypeCurrency<T>(this PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("currency"));
    }


    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetTypeDecimal<T>(this PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("decimal"));
    }


    /// <summary>
    /// <para> The formatting style to use. </para>
    /// </summary>
    public static void SetTypePercent<T>(this PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("percent"));
    }


    /// <summary>
    /// <para> Turns off grouping separators. </para>
    /// </summary>
    public static void SetNoGrouping<T>(this PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("noGrouping"), b.Const(true));
    }


    /// <summary>
    /// <para> Turns off grouping separators. </para>
    /// </summary>
    public static void SetNoGrouping<T>(this PropsBuilder<T> b, Var<bool> noGrouping) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("noGrouping"), noGrouping);
    }

    /// <summary>
    /// <para> Turns off grouping separators. </para>
    /// </summary>
    public static void SetNoGrouping<T>(this PropsBuilder<T> b, bool noGrouping) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("noGrouping"), b.Const(noGrouping));
    }


    /// <summary>
    /// <para> The [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code to use when formatting. </para>
    /// </summary>
    public static void SetCurrency<T>(this PropsBuilder<T> b, Var<string> currency) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("currency"), currency);
    }

    /// <summary>
    /// <para> The [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code to use when formatting. </para>
    /// </summary>
    public static void SetCurrency<T>(this PropsBuilder<T> b, string currency) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("currency"), b.Const(currency));
    }


    /// <summary>
    /// <para> How to display the currency. </para>
    /// </summary>
    public static void SetCurrencyDisplaySymbol<T>(this PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("currencyDisplay"), b.Const("symbol"));
    }


    /// <summary>
    /// <para> How to display the currency. </para>
    /// </summary>
    public static void SetCurrencyDisplayNarrowSymbol<T>(this PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("currencyDisplay"), b.Const("narrowSymbol"));
    }


    /// <summary>
    /// <para> How to display the currency. </para>
    /// </summary>
    public static void SetCurrencyDisplayCode<T>(this PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("currencyDisplay"), b.Const("code"));
    }


    /// <summary>
    /// <para> How to display the currency. </para>
    /// </summary>
    public static void SetCurrencyDisplayName<T>(this PropsBuilder<T> b) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("currencyDisplay"), b.Const("name"));
    }


    /// <summary>
    /// <para> The minimum number of integer digits to use. Possible values are 1-21. </para>
    /// </summary>
    public static void SetMinimumIntegerDigits<T>(this PropsBuilder<T> b, Var<int> minimumIntegerDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("minimumIntegerDigits"), minimumIntegerDigits);
    }

    /// <summary>
    /// <para> The minimum number of integer digits to use. Possible values are 1-21. </para>
    /// </summary>
    public static void SetMinimumIntegerDigits<T>(this PropsBuilder<T> b, int minimumIntegerDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("minimumIntegerDigits"), b.Const(minimumIntegerDigits));
    }


    /// <summary>
    /// <para> The minimum number of fraction digits to use. Possible values are 0-20. </para>
    /// </summary>
    public static void SetMinimumFractionDigits<T>(this PropsBuilder<T> b, Var<int> minimumFractionDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("minimumFractionDigits"), minimumFractionDigits);
    }

    /// <summary>
    /// <para> The minimum number of fraction digits to use. Possible values are 0-20. </para>
    /// </summary>
    public static void SetMinimumFractionDigits<T>(this PropsBuilder<T> b, int minimumFractionDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("minimumFractionDigits"), b.Const(minimumFractionDigits));
    }


    /// <summary>
    /// <para> The maximum number of fraction digits to use. Possible values are 0-0. </para>
    /// </summary>
    public static void SetMaximumFractionDigits<T>(this PropsBuilder<T> b, Var<int> maximumFractionDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("maximumFractionDigits"), maximumFractionDigits);
    }

    /// <summary>
    /// <para> The maximum number of fraction digits to use. Possible values are 0-0. </para>
    /// </summary>
    public static void SetMaximumFractionDigits<T>(this PropsBuilder<T> b, int maximumFractionDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("maximumFractionDigits"), b.Const(maximumFractionDigits));
    }


    /// <summary>
    /// <para> The minimum number of significant digits to use. Possible values are 1-21. </para>
    /// </summary>
    public static void SetMinimumSignificantDigits<T>(this PropsBuilder<T> b, Var<int> minimumSignificantDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("minimumSignificantDigits"), minimumSignificantDigits);
    }

    /// <summary>
    /// <para> The minimum number of significant digits to use. Possible values are 1-21. </para>
    /// </summary>
    public static void SetMinimumSignificantDigits<T>(this PropsBuilder<T> b, int minimumSignificantDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("minimumSignificantDigits"), b.Const(minimumSignificantDigits));
    }


    /// <summary>
    /// <para> The maximum number of significant digits to use,. Possible values are 1-21. </para>
    /// </summary>
    public static void SetMaximumSignificantDigits<T>(this PropsBuilder<T> b, Var<int> maximumSignificantDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("maximumSignificantDigits"), maximumSignificantDigits);
    }

    /// <summary>
    /// <para> The maximum number of significant digits to use,. Possible values are 1-21. </para>
    /// </summary>
    public static void SetMaximumSignificantDigits<T>(this PropsBuilder<T> b, int maximumSignificantDigits) where T: SlFormatNumber
    {
        b.SetProperty(b.Props, b.Const("maximumSignificantDigits"), b.Const(maximumSignificantDigits));
    }


}

