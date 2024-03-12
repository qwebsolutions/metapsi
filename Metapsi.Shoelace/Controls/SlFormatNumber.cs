using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlFormatNumber
{
}

public static partial class SlFormatNumberControl
{
    /// <summary>
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Var<IVNode> SlFormatNumber(this LayoutBuilder b, Action<PropsBuilder<SlFormatNumber>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-format-number", buildProps, children);
    }
    /// <summary>
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Var<IVNode> SlFormatNumber(this LayoutBuilder b, Action<PropsBuilder<SlFormatNumber>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-format-number", buildProps, children);
    }
    /// <summary>
    /// The number to format.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlFormatNumber> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The number to format.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlFormatNumber> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }

    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetTypeCurrency(this PropsBuilder<SlFormatNumber> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("currency"));
    }
    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetTypeDecimal(this PropsBuilder<SlFormatNumber> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("decimal"));
    }
    /// <summary>
    /// The formatting style to use.
    /// </summary>
    public static void SetTypePercent(this PropsBuilder<SlFormatNumber> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("percent"));
    }

    /// <summary>
    /// Turns off grouping separators.
    /// </summary>
    public static void SetNoGrouping(this PropsBuilder<SlFormatNumber> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("noGrouping"), b.Const(true));
    }

    /// <summary>
    /// The [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code to use when formatting.
    /// </summary>
    public static void SetCurrency(this PropsBuilder<SlFormatNumber> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("currency"), value);
    }
    /// <summary>
    /// The [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code to use when formatting.
    /// </summary>
    public static void SetCurrency(this PropsBuilder<SlFormatNumber> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("currency"), b.Const(value));
    }

    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplaySymbol(this PropsBuilder<SlFormatNumber> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("currencyDisplay"), b.Const("symbol"));
    }
    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayNarrowSymbol(this PropsBuilder<SlFormatNumber> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("currencyDisplay"), b.Const("narrowSymbol"));
    }
    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayCode(this PropsBuilder<SlFormatNumber> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("currencyDisplay"), b.Const("code"));
    }
    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayName(this PropsBuilder<SlFormatNumber> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("currencyDisplay"), b.Const("name"));
    }

    /// <summary>
    /// The minimum number of integer digits to use. Possible values are 1-21.
    /// </summary>
    public static void SetMinimumIntegerDigits(this PropsBuilder<SlFormatNumber> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimumIntegerDigits"), value);
    }
    /// <summary>
    /// The minimum number of integer digits to use. Possible values are 1-21.
    /// </summary>
    public static void SetMinimumIntegerDigits(this PropsBuilder<SlFormatNumber> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimumIntegerDigits"), b.Const(value));
    }

    /// <summary>
    /// The minimum number of fraction digits to use. Possible values are 0-20.
    /// </summary>
    public static void SetMinimumFractionDigits(this PropsBuilder<SlFormatNumber> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimumFractionDigits"), value);
    }
    /// <summary>
    /// The minimum number of fraction digits to use. Possible values are 0-20.
    /// </summary>
    public static void SetMinimumFractionDigits(this PropsBuilder<SlFormatNumber> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimumFractionDigits"), b.Const(value));
    }

    /// <summary>
    /// The maximum number of fraction digits to use. Possible values are 0-0.
    /// </summary>
    public static void SetMaximumFractionDigits(this PropsBuilder<SlFormatNumber> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maximumFractionDigits"), value);
    }
    /// <summary>
    /// The maximum number of fraction digits to use. Possible values are 0-0.
    /// </summary>
    public static void SetMaximumFractionDigits(this PropsBuilder<SlFormatNumber> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maximumFractionDigits"), b.Const(value));
    }

    /// <summary>
    /// The minimum number of significant digits to use. Possible values are 1-21.
    /// </summary>
    public static void SetMinimumSignificantDigits(this PropsBuilder<SlFormatNumber> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimumSignificantDigits"), value);
    }
    /// <summary>
    /// The minimum number of significant digits to use. Possible values are 1-21.
    /// </summary>
    public static void SetMinimumSignificantDigits(this PropsBuilder<SlFormatNumber> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimumSignificantDigits"), b.Const(value));
    }

    /// <summary>
    /// The maximum number of significant digits to use,. Possible values are 1-21.
    /// </summary>
    public static void SetMaximumSignificantDigits(this PropsBuilder<SlFormatNumber> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maximumSignificantDigits"), value);
    }
    /// <summary>
    /// The maximum number of significant digits to use,. Possible values are 1-21.
    /// </summary>
    public static void SetMaximumSignificantDigits(this PropsBuilder<SlFormatNumber> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maximumSignificantDigits"), b.Const(value));
    }

}

