using Metapsi.Hyperapp;
using Metapsi.Syntax;
using static Metapsi.Html.Binding;

namespace Metapsi.Html;

public partial class HtmlInput : IHasEditableValue<string>, IHasEditableValue<bool>
{
    /// <summary>
    /// 
    /// </summary>
    public string value { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool @checked { get; set; }
}

public partial class HtmlTextarea : IHasEditableValue<string>
{
    public string value { get; set; }
}

public partial class HtmlSelect : IHasEditableValue<string>
{
    public string value { get; set; }
}

public static class HtmlAccessors
{
    public static void RegisterHtmlAccessors()
    {
        Binding.Registry.Register<HtmlInput, string>(
            HtmlInputControl.SetValue,
            (b, e) => b.Get(b.Get(e, x => x.currentTarget).As<HTMLInputElement>(), x => x.value),
            (b, action) => b.OnEventAction("input", action));

        Binding.Registry.Register<HtmlInput, bool>(
            (b, value) => b.Set(x => x.@checked, value),
            (b, e) => b.Get(b.Get(e, x => x.currentTarget).As<HTMLInputElement>(), x => x.@checked),
            (b, action) => b.OnEventAction("click", action));
    }
}
