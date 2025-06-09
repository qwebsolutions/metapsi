using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;


public partial class SlCheckbox : IHasEditableValue
{
    public bool @checked { get; set; }
}

public partial class SlInput : IHasEditableValue
{
    public string value { get; set; }
}

public partial class SlSelect : IHasEditableValue
{
    public string value { get; set; }
}

public static class Binding
{
    public static void Register()
    {
        Metapsi.Html.Binding.Registry.Register<SlInput>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(b.Get(e, x => x.target).As<SlSelect>(), x => x.value).As<object>(),
            SlInputControl.OnSlInput);

        Metapsi.Html.Binding.Registry.Register<SlSelect>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(b.Get(e, x => x.target).As<SlSelect>(), x => x.value).As<object>(),
            (b, updateAction) =>
            {
                b.OnSlChange(updateAction);
            });

        Metapsi.Html.Binding.Registry.Register<SlCheckbox>(
            (b, value) =>
            {
                b.SetChecked(value.As<bool>());
            },
            (b, e) => b.Get(b.Get(e, x => x.target).As<SlCheckbox>(), x => x.@checked).As<object>(),
            (b, updateAction) =>
            {
                b.OnSlChange(updateAction);
            });
    }
}