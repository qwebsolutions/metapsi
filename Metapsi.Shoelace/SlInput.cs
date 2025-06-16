using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;


public static partial class SlInputControl
{
    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="action"></param>
    public static void OnSlChange<T, TModel>(this PropsBuilder<T> b, Var<HyperType.Action<TModel, string>> action) where T : SlInput
    {
        b.OnSlChange(b.MakeAction((SyntaxBuilder b, Var<TModel> model, Var<Html.Event> e) =>
        {
            return b.MakeActionDescriptor(action, b.GetTargetValue(e));
        }));
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