using Metapsi.Dom;
using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.ChoicesJs;

public static partial class Control
{


    public static void OnChoice<TControl, TState>(this PropsBuilder<TControl> b, Var<HyperType.Action<TState, Choice>> onChoice)
        where TControl : IChoicesSelect, new()
    {
        //var extractInputValue = b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<IDomEvent> @event) =>
        //{
        //    b.StopPropagation(@event);
        //    var detail = b.GetDynamic(@event, new DynamicProperty<DynamicObject>("detail"));
        //    b.Log("OnChoice detail", detail);
        //    var choice = b.GetDynamic(detail, new DynamicProperty<Choice>("choice"));
        //    return b.MakeActionDescriptor<TState, Choice>(onChoice, choice);
        //});

        //b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TState, IDomEvent>>("onchoice"), extractInputValue);
        b.OnEventAction("choice", onChoice, "detail", "choice");
    }

    /// <summary>
    /// WARNING! This event might recurse if you add items based on it. Better use 'change' and compare with data source instead
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TState"></typeparam>
    /// <param name="b"></param>
    /// <param name="onAddItem"></param>
    public static void OnAddItem<TControl, TState>(this PropsBuilder<TControl> b, Var<HyperType.Action<TState, AddItemArgs>> onAddItem)
        where TControl : IChoices, new()
    {
        b.OnEventAction("addItem", onAddItem, "detail");
    }

    public static void OnRemoveItem<TControl, TState>(this PropsBuilder<TControl> b, Var<HyperType.Action<TState, RemoveItemArgs>> onRemoveItem)
        where TControl : IChoices, new()
    {
        b.OnEventAction("removeItem", onRemoveItem, "detail");
    }

    public static void OnChange<TControl, TState>(this PropsBuilder<TControl> b, Var<HyperType.Action<TState, string>> onChange)
        where TControl : IChoices, new()
    {
        b.OnEventAction("change", onChange, "detail", "value");
    }

    public static void OnSearch<TControl, TState>(this PropsBuilder<TControl> b, Var<HyperType.Action<TState, SearchArgs>> onSearch)
        where TControl : IChoicesSelect, new()
    {
        b.OnEventAction("search", onSearch, "detail");
    }
}