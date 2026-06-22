using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Html;

/// <summary>
/// Control has a value that can be edited
/// </summary>
/// <remarks> The interface is just a marker. The HTML controls are just interfaces which are never actually instantiated. Bindings are registered using <see cref="Binding.Registry"/> </remarks>
public interface IHasEditableValue
{
}

public class Binding
{
    /// <summary>
    /// The action that sets a value on the control props
    /// </summary>
    internal Action<SyntaxBuilder, Var<object>, Var<object>> SetControlValue { get; set; } // control reference, value

    /// <summary>
    /// The function that extracts the new value from the DOM event
    /// </summary>
    public Func<SyntaxBuilder, Var<Html.Event>, Var<object>> GetEventValue { get; set; }

    /// <summary>
    /// An action that registers the event listener for updated values. Receives control props. Will invoke callback with model + new value
    /// </summary>
    internal Action<SyntaxBuilder, Var<object>, Var<Action<object, object>>> ListenForUpdates { get; set; } // control reference, onUpdate(model,newValue)

    internal static ConcurrentDictionary<string, Binding> bindings = new ConcurrentDictionary<string, Binding>();

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static Binding Get<TControl>()
    {
        var key = typeof(TControl).GetSemiQualifiedTypeName();
        return bindings.GetOrAdd(key, key =>
        {
            var forType = AutoLoader.FindAllLoaded<IAutoRegisterBinding>().SingleOrDefault(x => x.ControlType == typeof(TControl));
            if (forType == null)
                throw new Exception("Binding not found for " + typeof(TControl).Name);
            return forType.GetBinding();
        });
    }

    public static Binding New<TControl>(
        Action<PropsBuilder<TControl>, Var<object>> setValue,
        Func<SyntaxBuilder, Var<Html.Event>, Var<object>> getValue,
        Action<PropsBuilder<TControl>, Var<HyperType.Action<object, Html.Event>>> listenForUpdates)
        where TControl : IHasEditableValue
    {
        var accessor = new Binding()
        {
            SetControlValue = (SyntaxBuilder b, Var<object> props, Var<object> value) =>
            {
                b.SetProps<TControl>(props, b =>
                {
                    setValue(b, value);
                });
            },
            GetEventValue = (SyntaxBuilder b, Var<Html.Event> e) =>
            {
                return getValue(b, e).As<object>();
            },
            ListenForUpdates = (SyntaxBuilder b, Var<object> props, Var<Action<object, object>> onUpdate) =>
            {
                b.SetProps<TControl>(props, b =>
                {
                    listenForUpdates(b, b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
                    {
                        var newValue = getValue(b, e);
                        b.Call(onUpdate, model, newValue.As<object>());
                        return b.Clone(model);
                    }));
                });
            }
        };

        return accessor;
    }
}

/// <summary>
/// 
/// </summary>
public static class BindingExtensions
{
    internal static void BindToReference<TControl, TValue>(
        PropsBuilder<TControl> b,
        Var<Func<TValue>> getEntityValue,
        Var<Action<object, TValue>> setEntityValue)
        where TControl : IHasEditableValue
    {
        var value = b.Call(getEntityValue);
        var accessor = Binding.Get<TControl>();
        b.Call(accessor.SetControlValue, b.Props.As<object>(), value.As<object>());
        b.Call(accessor.ListenForUpdates, b.Props.As<object>(), setEntityValue.As<Action<object, object>>());
    }


    private static void BindToReference<TControl, TEntity, TValue>(
        this PropsBuilder<TControl> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, TValue>> onProperty)
        where TControl : IHasEditableValue
    {
        var getEntityValue = b.Def((SyntaxBuilder b) =>
        {
            Var<TValue> value = b.Get(entityRef, onProperty);
            return value;
        });

        var setNewValue = b.Def((SyntaxBuilder b, Var<object> _, Var<TValue> newValue) =>
        {
            b.Set(entityRef, onProperty, newValue);
        });
        b.Call<PropsBuilder<TControl>, Func<TValue>, Action<object, TValue>>(BindToReference<TControl, TValue>, getEntityValue, setNewValue);
    }

    public static void BindTo<TControl, TEntity>(
        this PropsBuilder<TControl> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
        where TControl : IHasEditableValue
    {
        b.BindToReference(entityRef, onProperty);
    }

    public static void BindTo<TControl, TEntity>(
        this PropsBuilder<TControl> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, bool>> onProperty)
        where TControl : IHasEditableValue
    {
        b.BindToReference(entityRef, onProperty);
    }

    public static void BindTo<TControl, TEntity>(
        this PropsBuilder<TControl> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, int>> onProperty)
        where TControl : IHasEditableValue
    {
        b.BindToReference(entityRef, onProperty);
    }
}
