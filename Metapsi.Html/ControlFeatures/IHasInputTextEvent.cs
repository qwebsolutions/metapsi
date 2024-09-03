using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Html;

public class InputTextEventDescription<TControl>
    where TControl : new()
{
    public string InputTextEventName { get; set; }
    public System.Func<SyntaxBuilder, Var<DomEvent>, Var<string>> GetEventValue { get; set; }
}

public interface IHasInputTextEvent<TControl>
    where TControl : new()
{
    InputTextEventDescription<TControl> GetInputTextEventDescription();
}

public static class InputTextEvent
{
    public static InputTextEventDescription<TControl> GetHtmlDefaultInputTextEvent<TControl>()
        where TControl : new()
    {
        return new InputTextEventDescription<TControl>()
        {
            InputTextEventName = "input",
            GetEventValue = (SyntaxBuilder b, Var<DomEvent> @event) =>
            {
                return b.NavigateProperties<DomEvent, string>(@event, "currentTarget", "value");
            }
        };
    }
    /// <summary>
    /// Common input action for all controls that support the event
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TState"></typeparam>
    /// <param name="b"></param>
    /// <param name="action"></param>
    public static void OnInputAction<TControl, TState>(
        this PropsBuilder<TControl> b,
        Var<HyperType.Action<TState, string>> action)
        where TControl : IHasInputTextEvent<TControl>, new()
    {
        var eventDescription = new TControl().GetInputTextEventDescription();
        b.OnEventAction(eventDescription.InputTextEventName, action, b.Def(eventDescription.GetEventValue));
    }

    /// <summary>
    /// Common input action for all controls that support the event
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TState"></typeparam>
    /// <param name="b"></param>
    /// <param name="action"></param>
    public static void OnInputAction<TControl, TState>(
        this PropsBuilder<TControl> b,
        System.Func<SyntaxBuilder, Var<TState>, Var<string>, Var<TState>> action)
        where TControl : IHasInputTextEvent<TControl>, new()
    {
        var eventDescription = new TControl().GetInputTextEventDescription();
        b.OnEventAction(eventDescription.InputTextEventName, b.MakeAction(action), b.Def(eventDescription.GetEventValue));
    }
}