using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlFormatNumber : SlComponent
{
    public SlFormatNumber() : base("sl-format-number") { }
    /// <summary>
    /// The number to format.
    /// </summary>
    public int value
    {
        get
        {
            return this.GetTag().GetAttribute<int>("value");
        }
        set
        {
            this.GetTag().SetAttribute("value", value.ToString());
        }
    }

    /// <summary>
    /// The formatting style to use.
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
    /// Turns off grouping separators.
    /// </summary>
    public bool noGrouping
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("no-grouping");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("no-grouping", value.ToString());
        }
    }

    /// <summary>
    /// The [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217) currency code to use when formatting.
    /// </summary>
    public string currency
    {
        get
        {
            return this.GetTag().GetAttribute<string>("currency");
        }
        set
        {
            this.GetTag().SetAttribute("currency", value.ToString());
        }
    }

    /// <summary>
    /// How to display the currency.
    /// </summary>
    public string currencyDisplay
    {
        get
        {
            return this.GetTag().GetAttribute<string>("currency-display");
        }
        set
        {
            this.GetTag().SetAttribute("currency-display", value.ToString());
        }
    }

    /// <summary>
    /// The minimum number of integer digits to use. Possible values are 1-21.
    /// </summary>
    public int minimumIntegerDigits
    {
        get
        {
            return this.GetTag().GetAttribute<int>("minimum-integer-digits");
        }
        set
        {
            this.GetTag().SetAttribute("minimum-integer-digits", value.ToString());
        }
    }

    /// <summary>
    /// The minimum number of fraction digits to use. Possible values are 0-20.
    /// </summary>
    public int minimumFractionDigits
    {
        get
        {
            return this.GetTag().GetAttribute<int>("minimum-fraction-digits");
        }
        set
        {
            this.GetTag().SetAttribute("minimum-fraction-digits", value.ToString());
        }
    }

    /// <summary>
    /// The maximum number of fraction digits to use. Possible values are 0-0.
    /// </summary>
    public int maximumFractionDigits
    {
        get
        {
            return this.GetTag().GetAttribute<int>("maximum-fraction-digits");
        }
        set
        {
            this.GetTag().SetAttribute("maximum-fraction-digits", value.ToString());
        }
    }

    /// <summary>
    /// The minimum number of significant digits to use. Possible values are 1-21.
    /// </summary>
    public int minimumSignificantDigits
    {
        get
        {
            return this.GetTag().GetAttribute<int>("minimum-significant-digits");
        }
        set
        {
            this.GetTag().SetAttribute("minimum-significant-digits", value.ToString());
        }
    }

    /// <summary>
    /// The maximum number of significant digits to use,. Possible values are 1-21.
    /// </summary>
    public int maximumSignificantDigits
    {
        get
        {
            return this.GetTag().GetAttribute<int>("maximum-significant-digits");
        }
        set
        {
            this.GetTag().SetAttribute("maximum-significant-digits", value.ToString());
        }
    }

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
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Var<IVNode> SlFormatNumber(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-format-number", children);
    }
    /// <summary>
    /// Formats a number using the specified locale and options.
    /// </summary>
    public static Var<IVNode> SlFormatNumber(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-format-number", children);
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
        b.SetDynamic(b.Props, DynamicProperty.String("currency-display"), b.Const("symbol"));
    }
    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayNarrowSymbol(this PropsBuilder<SlFormatNumber> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("currency-display"), b.Const("narrowSymbol"));
    }
    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayCode(this PropsBuilder<SlFormatNumber> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("currency-display"), b.Const("code"));
    }
    /// <summary>
    /// How to display the currency.
    /// </summary>
    public static void SetCurrencyDisplayName(this PropsBuilder<SlFormatNumber> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("currency-display"), b.Const("name"));
    }

    /// <summary>
    /// The minimum number of integer digits to use. Possible values are 1-21.
    /// </summary>
    public static void SetMinimumIntegerDigits(this PropsBuilder<SlFormatNumber> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimum-integer-digits"), value);
    }
    /// <summary>
    /// The minimum number of integer digits to use. Possible values are 1-21.
    /// </summary>
    public static void SetMinimumIntegerDigits(this PropsBuilder<SlFormatNumber> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimum-integer-digits"), b.Const(value));
    }

    /// <summary>
    /// The minimum number of fraction digits to use. Possible values are 0-20.
    /// </summary>
    public static void SetMinimumFractionDigits(this PropsBuilder<SlFormatNumber> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimum-fraction-digits"), value);
    }
    /// <summary>
    /// The minimum number of fraction digits to use. Possible values are 0-20.
    /// </summary>
    public static void SetMinimumFractionDigits(this PropsBuilder<SlFormatNumber> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimum-fraction-digits"), b.Const(value));
    }

    /// <summary>
    /// The maximum number of fraction digits to use. Possible values are 0-0.
    /// </summary>
    public static void SetMaximumFractionDigits(this PropsBuilder<SlFormatNumber> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maximum-fraction-digits"), value);
    }
    /// <summary>
    /// The maximum number of fraction digits to use. Possible values are 0-0.
    /// </summary>
    public static void SetMaximumFractionDigits(this PropsBuilder<SlFormatNumber> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maximum-fraction-digits"), b.Const(value));
    }

    /// <summary>
    /// The minimum number of significant digits to use. Possible values are 1-21.
    /// </summary>
    public static void SetMinimumSignificantDigits(this PropsBuilder<SlFormatNumber> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimum-significant-digits"), value);
    }
    /// <summary>
    /// The minimum number of significant digits to use. Possible values are 1-21.
    /// </summary>
    public static void SetMinimumSignificantDigits(this PropsBuilder<SlFormatNumber> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("minimum-significant-digits"), b.Const(value));
    }

    /// <summary>
    /// The maximum number of significant digits to use,. Possible values are 1-21.
    /// </summary>
    public static void SetMaximumSignificantDigits(this PropsBuilder<SlFormatNumber> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maximum-significant-digits"), value);
    }
    /// <summary>
    /// The maximum number of significant digits to use,. Possible values are 1-21.
    /// </summary>
    public static void SetMaximumSignificantDigits(this PropsBuilder<SlFormatNumber> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maximum-significant-digits"), b.Const(value));
    }

}

