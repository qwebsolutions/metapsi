using Metapsi.Html;
using Metapsi.Syntax;

namespace Metapsi.Ionic;

public partial class IonInput : IHasEditableValue<string> { }
public partial class IonTextarea : IHasEditableValue<string> { }

public partial class IonSelect : IHasEditableValue<string>, IHasEditableValue<int> { }

/// <summary>
/// Typed version of IonSelect for <typeparamref name="TValue"/> value property
/// </summary>
/// <typeparam name="TValue"></typeparam>
public partial class IonSelect<TValue> : IonSelect, IHasEditableValue<TValue>
{

}

public static class Binding
{
    public static void Register()
    {
        Metapsi.Html.Binding.Registry.Register<IonInput, string>(
            IonInputControl.SetValue,
            (b, e) => b.Get(e.As<CustomEvent<InputInputEventDetail>>(), x => x.detail.value),
            (b, updateAction) => b.OnIonInput(updateAction));

        Metapsi.Html.Binding.Registry.Register<IonTextarea, string>(
            IonTextareaControl.SetValue,
            (b, e) => b.Get(e.As<CustomEvent<TextareaInputEventDetail>>(), x => x.detail.value),
            (b, updateAction) => b.OnIonInput(updateAction));

        Metapsi.Html.Binding.Registry.Register<IonSelect, int>(
            (b, value) =>
            {
                b.SetValue(value.As<object>());
            },
            (b, e) => b.Get(e.As<CustomEvent<SelectChangeEventDetail>>(), x => x.detail.value).As<int>(),
            (b, updateAction) => b.OnIonChange(updateAction));

        Metapsi.Html.Binding.Registry.Register<IonSelect, string>(
            (b, value) =>
            {
                b.SetValue(value.As<object>());
            },
            (b, e) => b.Get(e.As<CustomEvent<SelectChangeEventDetail>>(), x => x.detail.value).As<string>(),
            (b, updateAction) => b.OnIonChange(updateAction));

        Metapsi.Html.Binding.Registry.Register<IonSelect, int>(
            (b, value) =>
            {
                b.SetValue(value.As<object>());
            },
            (b, e) => b.Get(e.As<CustomEvent<SelectChangeEventDetail>>(), x => x.detail.value).As<int>(),
            (b, updateAction) => b.OnIonChange(updateAction));
    }
}