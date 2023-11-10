using Metapsi.Dom;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;

namespace Metapsi.Shoelace;

public static class EventExtensions
{
    public static void SetOnSlChange<TState>(
       this LayoutBuilder b,
       Var<HyperNode> control,
       Var<HyperType.Action<TState, string>> onChange)
    {
        var onChangeEvent = b.MakeAction(
            (SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                b.Comment("SetOnSlChange");
                b.Log(@event);
                return b.MakeActionDescriptor(
                    onChange,
                    b.GetDynamic(
                        b.Get(@event, x => x.target).As<DynamicObject>(),
                        new DynamicProperty<string>("value")));
            });

        b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onsl-change"), onChangeEvent);
    }

    public static void SetOnSlChange<TState>(
       this LayoutBuilder b,
       Var<HyperNode> control,
       Var<HyperType.Action<TState, bool>> onChange)
    {
        var onChangeEvent = b.MakeAction(
            (SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                b.Comment("SetOnSlChange");
                b.Log(@event);
                return b.MakeActionDescriptor(
                    onChange,
                    b.GetDynamic(
                        b.Get(@event, x => x.target).As<DynamicObject>(),
                        new DynamicProperty<bool>("checked")));
            });

        b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onsl-change"), onChangeEvent);
    }


    public static void OnSlInput<TModel>(
        this PropsBuilder b,
        Var<DynamicObject> props,
        Var<HyperType.Action<TModel, string>> slInputAction)
    {
        var extractInputValue = b.MakeAction<TModel, DomEvent<InputTarget>>((SyntaxBuilder b, Var<TModel> state, Var<DomEvent<InputTarget>> @event) =>
        {
            var target = b.Get(@event, x => x.target);
            var value = b.Get(target, x => x.value);
            return b.MakeActionDescriptor<TModel, string>(slInputAction, value);
        });

        b.SetDynamic(props, new DynamicProperty<HyperType.Action<TModel, DomEvent<InputTarget>>>("onsl-input"), extractInputValue);
    }

    public static void BindSlInputValue<TModel, TContext>(
        this PropsBuilder b,
        Var<DynamicObject> props,
        Var<DataContext<TModel, TContext>> dataContext,
        System.Linq.Expressions.Expression<Func<TContext, string>> onProperty)
    {
        b.SetDynamic(props, Html.value, b.Get(b.Get(dataContext, x => x.InputData), onProperty));
        b.OnSlInput(props, b.MakeAction((SyntaxBuilder b, Var<TModel> model, Var<string> newValue) =>
        {
            var accessData = b.Get(dataContext, x => x.AccessData);
            var submodel = b.Call(accessData, model);
            b.Set(submodel, onProperty, newValue);
            return b.Clone(model);
        }));
    }

    public static void OnSlChange<TModel>(
        this PropsBuilder b,
        Var<DynamicObject> props,
        Var<HyperType.Action<TModel, bool>> slChangeAction)
    {
        var extractInputValue = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> @event) =>
        {
            var target = b.GetDynamic<object>(@event, new DynamicProperty<object>("target"));
            var value = b.GetDynamic(target, new DynamicProperty<bool>("checked"));
            return b.MakeActionDescriptor<TModel, bool>(slChangeAction, value);
        });

        b.SetDynamic(props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-change"), extractInputValue);
    }

    public static void BindSlCheckedValue<TModel, TContext>(
        this PropsBuilder b,
        Var<DynamicObject> props,
        Var<DataContext<TModel, TContext>> dataContext,
        System.Linq.Expressions.Expression<Func<TContext, bool>> onProperty)
    {
        b.SetDynamic(props, Html.@checked, b.Get(b.Get(dataContext, x => x.InputData), onProperty));
        b.OnSlChange(props, b.MakeAction((SyntaxBuilder b, Var<TModel> model, Var<bool> newValue) =>
        {
            var accessData = b.Get(dataContext, x => x.AccessData);
            var submodel = b.Call(accessData, model);
            b.Set(submodel, onProperty, newValue);
            return b.Clone(model);
        }));
    }
}
