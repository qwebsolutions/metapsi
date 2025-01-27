using Metapsi.Html;

namespace Metapsi.Shoelace;

public partial class SlInput : IAllowsBinding<SlInput>
{
    ControlBinder<SlInput> IAllowsBinding<SlInput>.GetControlBinder()
    {
        return new ControlBinder<SlInput>()
        {
            NewValueEventName = "sl-input",
            GetEventValue = (b, @event) =>
            {
                return b.NavigateProperties<DomEvent, string>(@event, "target", "value");
            },
            SetControlValue = SlInputControl.SetValue
        };
    }
}


public partial class SlInput : IHasInputTextEvent<SlInput>
{
    InputTextEventDescription<SlInput> IHasInputTextEvent<SlInput>.GetInputTextEventDescription()
    {
        return new InputTextEventDescription<SlInput>()
        {
            InputTextEventName = "sl-input",
            GetEventValue = (b, @event) =>
            {
                return b.NavigateProperties<DomEvent, string>(@event, "target", "value");
            }
        };
    }
}

public partial class SlSelect : IAllowsBinding<SlSelect>
{
    ControlBinder<SlSelect> IAllowsBinding<SlSelect>.GetControlBinder()
    {
        return new ControlBinder<SlSelect>()
        {
            NewValueEventName = "sl-change",
            GetEventValue = (b, @event) =>
            {
                return b.NavigateProperties<DomEvent, string>(@event, "target", "value");
            },
            SetControlValue = SlSelectControl.SetValue
        };
    }
}