using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Html;

public interface IHasDisabledAttribute
{

}

public partial class HtmlButton : IHasDisabledAttribute { }
public partial class HtmlFieldset : IHasDisabledAttribute { }
public partial class HtmlInput : IHasDisabledAttribute { }
public partial class HtmlOptgroup : IHasDisabledAttribute { }
public partial class HtmlOption : IHasDisabledAttribute { }
public partial class HtmlSelect : IHasDisabledAttribute { }
public partial class HtmlTextarea : IHasDisabledAttribute { }

public static class HtmlDisabledAttributeExtensions
{
    public static void SetDisabled<TControl>(this PropsBuilder<TControl> b)
        where TControl : IHasDisabledAttribute, new()
    {
        b.SetAttribute("disabled");
    }

    public static void SetDisabled<TControl>(this PropsBuilder<TControl> b, Var<bool> value)
        where TControl : IHasDisabledAttribute, new()
    {
        b.SetAttribute("disabled", value);
    }

    public static void SetDisabled<TControl>(this PropsBuilder<TControl> b, bool value)
        where TControl : IHasDisabledAttribute, new()
    {
        b.SetDisabled(b.Const(value));
    }
}