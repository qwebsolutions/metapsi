using Metapsi.Dom;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;

namespace Metapsi.Html;

public class ControlBinder<TControl>
    where TControl : new()
{
    public string NewValueEventName { get; set; }
    public System.Func<SyntaxBuilder, Var<DomEvent>, Var<string>> GetEventValue { get; set; }
    public System.Action<PropsBuilder<TControl>, Var<string>> SetControlValue { get; set; }
}

public interface IAllowsBinding<TControl>
    where TControl : new()
{
    ControlBinder<TControl> GetControlBinder();
}

public class Converter<T>
{
    public System.Func<SyntaxBuilder, Var<string>, Var<T>> ConvertFromString { get; set; } = (b, v) => v.As<T>();
    public System.Func<SyntaxBuilder, Var<T>, Var<string>> ConvertToString { get; set; } = (b, v) => b.AsString(v);
}

public class Converter
{
    public static Converter<Guid> GuidConverter = new Converter<Guid>(); // guids are just strings

    public static Converter<int> IntConverter = new Converter<int>()
    {
        ConvertFromString = (b, v) => b.ParseInt(v),
        ConvertToString = (b, v) => b.AsString(v)
    };

    public static Converter<bool> BoolConverter = new()
    {
        ConvertFromString = (b, v) => b.ParseBool(v),
        ConvertToString = (b, v) => b.AsString(v)
    };
}

public static class Binding
{
    public static ControlBinder<TControl> GetHtmlDefaultBinder<TControl>()
        where TControl : new()
    {
        return new ControlBinder<TControl>()
        {
            NewValueEventName = "input",
            GetEventValue = (SyntaxBuilder b, Var<DomEvent> @event) =>
            {
                return b.NavigateProperties<DomEvent, string>(@event, "currentTarget", "value");
            },
            SetControlValue = (b, value) => b.SetAttribute("value", value)
        };
    }

    public static void BindTo<TControl, TState, TEntity, TValue>(
        this PropsBuilder<TControl> b,
        Var<TState> state,
        Var<System.Func<TState, TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, TValue>> onProperty,
        Converter<TValue> converter)
        where TControl : IAllowsBinding<TControl>, new()
    {
        Var<TEntity> entity = b.Call(onEntity, state);
        Var<TValue> value = b.Get(entity, onProperty);

        var setProperty = b.MakeAction<TState, string>((SyntaxBuilder b, Var<TState> state, Var<string> inputValue) =>
        {
            Var<TEntity> entity = b.Call(onEntity, state);
            b.Set(entity, onProperty, b.Call(converter.ConvertFromString, inputValue));
            return b.Clone(state);
        });

        var binder = new TControl().GetControlBinder();
        binder.SetControlValue(b, b.Call(converter.ConvertToString, value));
        b.OnEventAction(binder.NewValueEventName, setProperty, b.Def(binder.GetEventValue));
    }

    public static void BindTo<TControl, TState, TEntity, TValue>(
        this PropsBuilder<TControl> b,
        Var<TState> state,
        System.Func<SyntaxBuilder, Var<TState>, Var<TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, TValue>> onProperty,
        Converter<TValue> converter)
        where TControl : IAllowsBinding<TControl>, new()
    {
        b.BindTo(state, b.Def(onEntity), onProperty, converter);
    }

    public static void BindTo<TControl, TState, TValue>(
        this PropsBuilder<TControl> b,
        Var<TState> state,
        System.Linq.Expressions.Expression<System.Func<TState, TValue>> onProperty,
        Converter<TValue> converter)
        where TControl : IAllowsBinding<TControl>, new()
    {
        b.BindTo<TControl, TState, TState, TValue>(state, (SyntaxBuilder b, Var<TState> model) => model, onProperty, converter);
    }

    public static void BindTo<TControl, TState>(
        this PropsBuilder<TControl> b,
        Var<TState> state,
        System.Linq.Expressions.Expression<System.Func<TState, string>> onProperty)
        where TControl : IAllowsBinding<TControl>, new()
    {
        b.BindTo<TControl, TState, TState>(state, (SyntaxBuilder b, Var<TState> model) => model, onProperty);
    }

    public static void BindTo<TControl, TState, TEntity>(
        this PropsBuilder<TControl> b,
        Var<TState> state,
        Var<System.Func<TState, TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
        where TControl : IAllowsBinding<TControl>, new()
    {
        Var<TEntity> entity = b.Call(onEntity, state);
        Var<string> value = b.Get(entity, onProperty);

        var setProperty = b.MakeAction<TState, string>((SyntaxBuilder b, Var<TState> state, Var<string> inputValue) =>
        {
            Var<TEntity> entity = b.Call(onEntity, state);
            b.Set(entity, onProperty, inputValue);
            return b.Clone(state);
        });

        var binder = new TControl().GetControlBinder();
        binder.SetControlValue(b, value);
        b.OnEventAction(binder.NewValueEventName, setProperty, b.Def(binder.GetEventValue));
    }

    public static void BindTo<TControl, TState, TEntity>(
        this PropsBuilder<TControl> b,
        Var<TState> state,
        System.Func<SyntaxBuilder, Var<TState>, Var<TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
        where TControl : IAllowsBinding<TControl>, new()
    {
        b.BindTo(state, b.Def(onEntity), onProperty);
    }

    public static void BindTo<TControl, TState, TEntity>(this PropsBuilder<TControl> b,
        Var<TState> state,
        System.Linq.Expressions.Expression<System.Func<TState, TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
        where TControl : IAllowsBinding<TControl>, new()
    {
        b.BindTo(state, b.Def((SyntaxBuilder b, Var<TState> state) => b.Get(state, onEntity)), onProperty);
    }

    public static void BindTo<TControl, TState, TEntity>(
        this PropsBuilder<TControl> b,
        Var<TState> state,
        System.Func<SyntaxBuilder, Var<TState>, Var<TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, Guid>> onProperty)
        where TControl : IAllowsBinding<TControl>, new()
    {
        b.BindTo(state, b.Def(onEntity), onProperty, Converter.GuidConverter);
    }

    public static void BindTo<TControl, TState, TEntity>(
        this PropsBuilder<TControl> b,
        Var<TState> state,
        System.Func<SyntaxBuilder, Var<TState>, Var<TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, int>> onProperty)
        where TControl : IAllowsBinding<TControl>, new()
    {
        b.BindTo(state, b.Def(onEntity), onProperty, Converter.IntConverter);
    }

    public static void BindTo<TControl, TState, TEntity>(
        this PropsBuilder<TControl> b,
        Var<TState> state,
        System.Func<SyntaxBuilder, Var<TState>, Var<TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, bool>> onProperty)
        where TControl : IAllowsBinding<TControl>, new()
    {
        b.BindTo(state, b.Def(onEntity), onProperty, Converter.BoolConverter);
    }

    public static void BindTo<TControl, TState, TEntity>(
        this PropsBuilder<TControl> b,
        Var<TState> state,
        System.Linq.Expressions.Expression<System.Func<TState, TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, int>> onProperty)
        where TControl : IAllowsBinding<TControl>, new()
    {
        b.BindTo(state, (SyntaxBuilder b, Var<TState> state) => b.Get(state, onEntity), onProperty);
    }
}
