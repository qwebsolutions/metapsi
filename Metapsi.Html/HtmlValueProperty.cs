using Metapsi.Syntax;

namespace Metapsi.Html;

public static partial class HtmlInputControl
{
    public static void SetValue(this PropsBuilder<HtmlInput> b, Var<string> value)
    {
        b.Set(x => x.value, value);
    }

    public static void SetValue(this PropsBuilder<HtmlInput> b, string value)
    {
        b.SetValue(b.Const(value));
    }
}

public static partial class HtmlTextareaControl
{
    public static void SetValue(this PropsBuilder<HtmlTextarea> b, Var<string> value)
    {
        b.Set(x => x.value, value);
    }

    public static void SetValue(this PropsBuilder<HtmlTextarea> b, string value)
    {
        b.SetValue(b.Const(value));
    }
}


public static partial class HtmlSelectControl
{
    public static void SetValue(this PropsBuilder<HtmlSelect> b, Var<string> value)
    {
        b.Set(x => x.value, value);
    }

    public static void SetValue(this PropsBuilder<HtmlSelect> b, string value)
    {
        b.SetValue(b.Const(value));
    }
}

public static partial class HtmlButtonControl
{
    public static void SetValue(this PropsBuilder<HtmlButton> b, Var<string> value)
    {
        b.SetAttribute("value", value);
    }

    public static void SetValue(this PropsBuilder<HtmlButton> b, string value)
    {
        b.SetValue(b.Const(value));
    }
}