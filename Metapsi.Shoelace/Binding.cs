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
            (b, value) =>
            {
                b.SetValue(value);
            },
            (b, update) =>
            {
                b.Log("Binding update ", update);
                b.OnSlInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
                {
                    var newValue = b.Get(b.Get(e, x => x.target).As<SlInput>(), x => x.value);
                    b.Call(update, model, newValue);
                    b.Log("Binding update ", newValue);
                    return b.Clone(model);
                }));
            });

        Metapsi.Html.Binding.Registry.Register<SlInput, int>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, update) =>
            {
                b.OnSlInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
                {
                    var newValue = b.Get(b.Get(e, x => x.target).As<SlInput>(), x => x.value).As<int>();
                    b.Call(update, model, newValue);
                    return b.Clone(model);
                }));
            });

        Metapsi.Html.Binding.Registry.Register<SlSelect, string>(
            (b, value) =>
            {
                b.SetValue(value);
            },
            (b, update) =>
            {
                b.OnSlChange(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
                {
                    var newValue = b.Get(b.Get(e, x => x.target).As<SlSelect>(), x => x.value);
                    return b.Clone(model);
                }));
            });

        Metapsi.Html.Binding.Registry.Register<SlCheckbox, bool>(
            (b, value) =>
            {
                b.SetChecked(value);
            },
            (b, update) =>
            {
                b.OnSlChange((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
                {
                    var newValue = b.Get(b.Get(e, x => x.target).As<SlCheckbox>(), x => x.@checked);
                    b.Call(update, model, newValue);
                    return b.Clone(model);
                });
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