using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Ionic;

public partial class IonInput : IHasEditableValue<string> { }
public partial class IonTextarea: IHasEditableValue<string> { }

public static class Binding
{
    public static void Register()
    {
        Metapsi.Html.Binding.Registry.Register<IonInput, string>(
            (b, value) =>
            {
                b.SetValue(value);
            },
            (b, update) =>
            {
                b.OnIonInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<InputInputEventDetail>> e) =>
                {
                    var newValue = b.Get(e, x => x.detail.value);
                    b.Call(update, model, newValue);
                    return b.Clone(model);
                }));
            });

        Metapsi.Html.Binding.Registry.Register<IonTextarea, string>(
            (b, value) =>
            {
                b.SetValue(value);
            },
            (b, update) =>
            {
                b.OnIonInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<TextareaInputEventDetail>> e) =>
                {
                    var newValue = b.Get(e, x => x.detail.value);
                    b.Call(update, model, newValue);
                    return b.Clone(model);
                }));
            });
    }
}