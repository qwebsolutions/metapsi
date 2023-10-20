using Metapsi.Dom;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.ChoicesJs;

public static class Event
{
    public static void SetOnChoice<TState>(LayoutBuilder b, Var<HyperNode> control, Var<HyperType.Action<TState, Choice>> onChoice)
    {
        var extractInputValue = b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<IDomEvent> @event) =>
        {
            b.StopPropagation(@event);
            var detail = b.GetDynamic(@event, new DynamicProperty<DynamicObject>("detail"));
            var choice = b.GetDynamic(detail, new DynamicProperty<Choice>("choice"));
            return b.MakeActionDescriptor<TState, Choice>(onChoice, choice);
        });
        
        b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, IDomEvent>>("onchoice"), extractInputValue);
    }

    public static void SetOnChoiceSelected<TState, TId>(this LayoutBuilder b, Var<HyperNode> control, System.Action<SyntaxBuilder, Var<TState>, Var<TId>> clientAction)
    {
        SetOnChange<TState>(b, control, b.MakeAction<TState, string>((SyntaxBuilder b, Var<TState> state, Var<string> selectedValue) =>
        {
            var id = b.ParseScalar<TId>(selectedValue);
            b.Call(clientAction, state, id);
            return b.Clone(state);
        }));
    }

    public static void SetOnChange<TState>(LayoutBuilder b, Var<HyperNode> control, Var<HyperType.Action<TState, string>> onChange)
    {
        var extractInputValue = b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<IDomEvent> @event) =>
        {
            b.StopPropagation(@event);
            var target = b.GetDynamic(@event, new DynamicProperty<DynamicObject>("target"));
            var value = b.GetDynamic(target, new DynamicProperty<string>("value"));
            return b.MakeActionDescriptor<TState, string>(onChange, value);
        });

        b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, IDomEvent>>("onchange"), extractInputValue);
    }

    public static void MultiBindTo<TState>(this LayoutBuilder b, Var<HyperNode> control, System.Linq.Expressions.Expression<Func<TState, List<string>>> multipleValues)
    {
        SetOnChange(b, control, b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<string> _selectedValueNotUsed) =>
        {
            var container = b.GetElementById(b.GetAttr(control, Html.id));
            var choicesControl = b.GetDynamic(container.As<DynamicObject>(), new DynamicProperty<DynamicObject>("choices"));
            var values = b.CallExternal<List<string>>("metapsi.choices", "GetValue", choicesControl);
            b.Set(state, multipleValues, values);
            return b.Clone(state);
        }));
    }

    public static void SingleBindTo<TState>(this LayoutBuilder b, Var<HyperNode> control, System.Linq.Expressions.Expression<Func<TState, string>> singleValue)
    {
        SetOnChange(b, control, b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<string> selectedValue) =>
        {
            var container = b.GetElementById(b.GetAttr(control, Html.id));
            var choicesControl = b.GetDynamic(container.As<DynamicObject>(), new DynamicProperty<DynamicObject>("choices"));
            var value = b.CallExternal<string>("metapsi.choices", "GetValue", choicesControl);
            b.Set(state, singleValue, value);

            return b.Clone(state);
        }));
    }

    public static void SingleBindTo<TState, TItem, TId>(
        this LayoutBuilder b, 
        Var<HyperNode> control, 
        Var<Func<TState, TItem>> getItem,
        System.Linq.Expressions.Expression<Func<TItem, TId>> singleValue)
    {
        SetOnChange(b, control, b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<string> selectedValue) =>
        {
            var container = b.GetElementById(b.GetAttr(control, Html.id));
            var choicesControl = b.GetDynamic(container.As<DynamicObject>(), new DynamicProperty<DynamicObject>("choices"));
            var value = b.CallExternal<string>("metapsi.choices", "GetValue", choicesControl);
            var item = b.Call(getItem, state);
            b.Set(item, singleValue, b.ParseScalar<TId>(value));

            return b.Clone(state);
        }));
    }
}