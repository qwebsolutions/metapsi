using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;


public partial class SlCheckbox : IHasEditableValue<bool>
{
    public bool @checked { get; set; }
}

public partial class SlInput : IHasEditableValue<string>, IHasEditableValue<int>
{
    public string value { get; set; }
}

public partial class SlSelect : IHasEditableValue<string>
{
    public string value { get; set; }
}

public static class Binding
{
    public static void Register()
    {
        Metapsi.Html.Binding.Registry.Register<SlInput, string>(
            SlInputControl.SetValue,
            (b, e) => b.Get(b.Get(e, x => x.target).As<SlSelect>(), x => x.value),
            SlInputControl.OnSlInput);

        Metapsi.Html.Binding.Registry.Register<SlInput, int>(
            (b, value) =>
            {
                b.SetValueAsNumber(value);
            },
            (b, e) => b.Get(b.Get(e, x => x.target).As<SlSelect>(), x => x.value).As<int>(),
            SlInputControl.OnSlInput);

        Metapsi.Html.Binding.Registry.Register<SlSelect, string>(
            SlSelectControl.SetValue,
            (b, e) => b.Get(b.Get(e, x => x.target).As<SlSelect>(), x => x.value),
            (b, updateAction) =>
            {
                b.OnSlChange(updateAction);
            });

        Metapsi.Html.Binding.Registry.Register<SlCheckbox, bool>(
            SlCheckboxControl.SetChecked,
            (b, e) => b.Get(b.Get(e, x => x.target).As<SlCheckbox>(), x => x.@checked),
            (b, updateAction) =>
            {
                b.OnSlChange(updateAction);
            });
    }
}


//public partial class SlSelect : IHasEditableValue<SlSelect>
//{
//    ValueAccessor<SlSelect> IHasEditableValue<SlSelect>.GetValueAccessor()
//    {
//        return new ValueAccessor<SlSelect>()
//        {
//            NewValueEventName = "sl-change",
//            GetNewValue = (b, @event) =>
//            {
//                return b.NavigateProperties<Event, string>(@event, "target", "value");
//            },
//            SetControlValue = SlSelectControl.SetValue
//        };
//    }
//}