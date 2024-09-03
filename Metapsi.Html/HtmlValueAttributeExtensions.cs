using Metapsi.Syntax;

namespace Metapsi.Html;

public interface IHasValueAttribute
{

}

public partial class HtmlButton : IHasValueAttribute { }
public partial class HtmlInput : IHasValueAttribute { }
public partial class HtmlMeter : IHasValueAttribute { }
public partial class HtmlLi : IHasValueAttribute { }
public partial class HtmlOption : IHasValueAttribute { }
public partial class HtmlProgress : IHasValueAttribute { }
public partial class HtmlParam : IHasValueAttribute { }

public static class HtmlValueAttributeExtensions
{
    public static void SetValue<TControl>(this PropsBuilder<TControl> b, Var<string> value)
        where TControl : IHasValueAttribute, new()
    {
        b.SetAttribute("value", value);
    }

    public static void SetValue<TControl>(this PropsBuilder<TControl> b, string value)
        where TControl : IHasValueAttribute, new()
    {
        b.SetValue(b.Const(value));
    }
}