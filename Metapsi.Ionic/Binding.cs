using Metapsi.Html;
using Metapsi.Syntax;

namespace Metapsi.Ionic;

public partial class IonInput : IHasEditableValue { }
public partial class IonTextarea : IHasEditableValue { }

public partial class IonSelect : IHasEditableValue { }

///// <summary>
///// Typed version of IonSelect for <typeparamref name="TValue"/> value property
///// </summary>
///// <typeparam name="TValue"></typeparam>
//public partial class IonSelect<TValue> : IonSelect, IHasEditableValue<TValue>
//{

//}

public static class Binding
{
    public static void Register()
    {
        Metapsi.Html.Binding.Registry.Register<IonInput>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(e.As<CustomEvent<InputInputEventDetail>>(), x => x.detail.value).As<object>(),
            (b, updateAction) => b.OnIonInput(updateAction));

        Metapsi.Html.Binding.Registry.Register<IonTextarea>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(e.As<CustomEvent<TextareaInputEventDetail>>(), x => x.detail.value).As<object>(),
            (b, updateAction) => b.OnIonInput(updateAction));

        Metapsi.Html.Binding.Registry.Register<IonSelect>(
            (b, value) =>
            {
                b.SetValue(value.As<object>());
            },
            (b, e) => b.Get(e.As<CustomEvent<SelectChangeEventDetail>>(), x => x.detail.value).As<object>(),
            (b, updateAction) => b.OnIonChange(updateAction));
    }
}