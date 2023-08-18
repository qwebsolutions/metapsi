using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.ChoicesJs;

public static class Event
{
    public static void SetOnChoice<TState>(BlockBuilder b, Var<HyperNode> control, Var<HyperType.Action<TState, Choice>> onChoice)
    {
        var extractInputValue = b.MakeAction<TState, DynamicObject, Choice>((BlockBuilder b, Var<TState> state, Var<DynamicObject> @event) =>
        {
            b.Log("OnChoice @event", @event);
            b.CallExternal(nameof(Native), "stopPropagation", @event);
            //var value = b.Get(target, x => x.value);
            var detail = b.Get(@event, new DynamicProperty<DynamicObject>("detail"));
            var choice = b.Get(detail, new DynamicProperty<Choice>("choice"));
            return b.MakeActionDescriptor<TState, Choice>(onChoice, choice);
        });

        b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DynamicObject>>("onchoice"), extractInputValue);
    }

    public static void SetOnChoiceSelected<TState, TId>(this BlockBuilder b, Var<HyperNode> control, System.Action<BlockBuilder, Var<TState>, Var<TId>> clientAction)
    {
        SetOnChange<TState>(b, control, b.MakeAction<TState, string>((BlockBuilder b, Var<TState> state, Var<string> selectedValue) =>
        {
            var id = b.ParseScalar<TId>(selectedValue);
            b.Call(clientAction, state, id);
            return b.Clone(state);
        }));
    }

    public static void SetOnChange<TState>(BlockBuilder b, Var<HyperNode> control, Var<HyperType.Action<TState, string>> onChange)
    {
        var extractInputValue = b.MakeAction<TState, DynamicObject, string>((BlockBuilder b, Var<TState> state, Var<DynamicObject> @event) =>
        {
            b.Log("OnChange @event", @event);
            b.CallExternal(nameof(Native), "stopPropagation", @event);
            //var detail = b.Get(@event, new DynamicProperty<DynamicObject>("detail"));
            //var value = b.Get(detail, new DynamicProperty<string>("value"));
            //return b.MakeActionDescriptor<TState, string>(onChange, value);

            var target = b.Get(@event, new DynamicProperty<DynamicObject>("target"));
            var value = b.Get(target, new DynamicProperty<string>("value"));
            return b.MakeActionDescriptor<TState, string>(onChange, value);
        });

        b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DynamicObject>>("onchange"), extractInputValue);
    }

    public static void MultiBindTo<TState>(this BlockBuilder b, Var<HyperNode> control, System.Linq.Expressions.Expression<Func<TState, List<string>>> multipleValues)
    {
        SetOnChange(b, control, b.MakeAction((BlockBuilder b, Var<TState> state, Var<string> _selectedValueNotUsed) =>
        {
            var container = b.GetElementById(b.GetAttr(control, Html.id));
            b.Log("container", container);

            var choicesControl = b.Get(container.As<DynamicObject>(), new DynamicProperty<DynamicObject>("choices"));
            b.Log("choicesControl", choicesControl);
            var values = b.CallExternal<List<string>>("metapsi.choices", "GetValue", choicesControl);
            b.Log("values", values);
            b.Set(state, multipleValues, values);
            return b.Clone(state);
        }));
    }

    public static void SingleBindTo<TState>(this BlockBuilder b, Var<HyperNode> control, System.Linq.Expressions.Expression<Func<TState, string>> singleValue)
    {
        SetOnChange(b, control, b.MakeAction((BlockBuilder b, Var<TState> state, Var<string> selectedValue) =>
        {
            var container = b.GetElementById(b.GetAttr(control, Html.id));
            b.Log("container", container);
            var choicesControl = b.Get(container.As<DynamicObject>(), new DynamicProperty<DynamicObject>("choices"));
            b.Log("choicesControl", choicesControl);
            var value = b.CallExternal<string>("metapsi.choices", "GetValue", choicesControl);
            b.Log("value", value);
            b.Set(state, singleValue, value);

            return b.Clone(state);
        }));
    }

    public static void SingleBindTo<TState, TItem, TId>(
        this BlockBuilder b, 
        Var<HyperNode> control, 
        Var<Func<TState, TItem>> getItem,
        System.Linq.Expressions.Expression<Func<TItem, TId>> singleValue)
    {
        SetOnChange(b, control, b.MakeAction((BlockBuilder b, Var<TState> state, Var<string> selectedValue) =>
        {
            var container = b.GetElementById(b.GetAttr(control, Html.id));
            b.Log("container", container);
            var choicesControl = b.Get(container.As<DynamicObject>(), new DynamicProperty<DynamicObject>("choices"));
            b.Log("choicesControl", choicesControl);
            var value = b.CallExternal<string>("metapsi.choices", "GetValue", choicesControl);
            b.Log("value", value);

            var item = b.Call(getItem, state);
            b.Set(item, singleValue, b.ParseScalar<TId>(value));

            return b.Clone(state);
        }));
    }
}