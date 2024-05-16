using Metapsi.Dom;
using Metapsi.Html;

namespace Metapsi.Ionic;

public partial class IonInput : IAllowsBinding<IonInput>
{
    ControlBinder<IonInput> IAllowsBinding<IonInput>.GetControlBinder()
    {
        return new ControlBinder<IonInput>()
        {
            NewValueEventName = "ionInput",
            SetControlValue = (b, value) => b.SetValue(value),
            GetEventValue = (b, domEvent) => b.NavigateProperties<DomEvent, string>(domEvent, "detail", "value")
        };
    }
}