using Metapsi.Dom;
using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

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

public partial class SlCheckbox : IAllowsBinding<SlCheckbox>
{
    ControlBinder<SlCheckbox> IAllowsBinding<SlCheckbox>.GetControlBinder()
    {
        return new ControlBinder<SlCheckbox>()
        {
            NewValueEventName = "sl-change",
            GetEventValue = (b, @event) =>
            {
                b.Log("sl-change event", @event);
                var isChecked = b.NavigateProperties<DomEvent, string>(@event, "target", "checked");
                var returnValueString = b.AsString(isChecked);
                b.Log("returnValue", returnValueString);
                return returnValueString;
            },
            SetControlValue = (b, value) =>
            {
                b.Log("SetControlValue", value);

                b.If(
                    b.AreEqual(value, b.AsString(b.Const(true))),
                    b =>
                    {
                        b.Log("SetChecked!");
                        b.SetChecked();
                    });
            }
        };
    }
}