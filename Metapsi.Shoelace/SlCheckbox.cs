using Metapsi.Html;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public partial class SlCheckbox : IAllowsBinding<SlCheckbox>
{
    ControlBinder<SlCheckbox> IAllowsBinding<SlCheckbox>.GetControlBinder()
    {
        return new ControlBinder<SlCheckbox>()
        {
            NewValueEventName = "sl-change",
            GetEventValue = (b, @event) =>
            {
                var isChecked = b.NavigateProperties<DomEvent, string>(@event, "target", "checked");
                var returnValueString = b.AsString(isChecked);
                return returnValueString;
            },
            SetControlValue = (b, value) =>
            {
                b.If(
                    b.AreEqual(value, b.AsString(b.Const(true))),
                    b =>
                    {
                        b.SetChecked();
                    });
            }
        };
    }
}

public static partial class SlNodeExtensions
{
    public static void BindTo<TModel>(this PropsBuilder<SlCheckbox> b, Var<TModel> model, System.Linq.Expressions.Expression<System.Func<TModel, bool>> onProperty)
    {
        b.BindTo(model, onProperty, Converter.BoolConverter);
    }
}
