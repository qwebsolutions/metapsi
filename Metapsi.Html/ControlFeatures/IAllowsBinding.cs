using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// Control has a value that can be edited
/// </summary>
/// <remarks> The interface is just a marker. The HTML controls are just interfaces which are never actually instantiated. Bindings are registered using <see cref="Binding.Registry"/> </remarks>
public interface IHasEditableValue
{
}

public static class Binding
{
    /// <summary>
    /// A control-related pair of value setter and event handler for value update
    /// </summary>
    public class Accessor
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
    }

    /// <summary>
    /// Registers value accessors
    /// </summary>
    public static AccessorRegistry Registry { get; } = new AccessorRegistry();

    /// <summary>
    /// 
    /// </summary>
    public class AccessorRegistry
    {
        internal Dictionary<string, Accessor> accessors = new Dictionary<string, Accessor>();
        //static AccessorRegistry()
        //{
        //    HtmlAccessors.RegisterHtmlAccessors();
        //}
    }

    public static void Register(AccessorRegistry r, string key, Accessor valueAccessor)
    {
        r.accessors[key] = valueAccessor;
    }

    public static Accessor Get(AccessorRegistry r, string key)
    {
        return r.accessors[key];
    }

    public static void Register<TControl>(
        this AccessorRegistry r,
        Action<PropsBuilder<TControl>, Var<object>> setValue,
        Func<SyntaxBuilder, Var<Html.Event>, Var<object>> getValue,
        Action<PropsBuilder<TControl>, Var<HyperType.Action<object, Html.Event>>> listenForUpdates)
        where TControl : IHasEditableValue
    {
        var accessor = new Accessor()
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

        r.accessors[typeof(TControl).GetSemiQualifiedTypeName()] = accessor;
    }

    public static Accessor Get<TControl>(this AccessorRegistry r)
    {
        return r.accessors[typeof(TControl).GetSemiQualifiedTypeName()];
    }

    internal static void BindToInternal<TControl, TValue>(
        PropsBuilder<TControl> b,
        Var<Func<TValue>> getEntityValue,
        Var<Action<object, TValue>> setEntityValue)
        where TControl : IHasEditableValue
    {
        var value = b.Call(getEntityValue);
        var accessor = Binding.Registry.Get<TControl>();
        b.Call(accessor.SetControlValue, b.Props.As<object>(), value.As<object>());
        b.Call(accessor.ListenForUpdates, b.Props.As<object>(), setEntityValue.As<Action<object, object>>());
    }

    /// <summary>
    /// Synchronizes control value and property <paramref name="onProperty"/> of object reference <paramref name="onEntity"/> obtained from <paramref name="model"/>
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="b"></param>
    /// <param name="model"></param>
    /// <param name="onEntity"></param>
    /// <param name="onProperty"></param>
    public static void BindTo<TControl, TModel, TEntity, TValue>(
        this PropsBuilder<TControl> b,
        Var<TModel> model,
        Var<System.Func<TModel, TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, TValue>> onProperty)
        where TControl : IHasEditableValue
    {
        var getEntityValue = b.Def((SyntaxBuilder b) =>
        {
            Var<TEntity> entity = b.Call(onEntity, model);
            Var<TValue> value = b.Get(entity, onProperty);
            return value;
        });

        var setNewValue = b.Def((SyntaxBuilder b, Var<object> model, Var<TValue> newValue) =>
        {
            Var<TEntity> entity = b.Call(onEntity, model.As<TModel>());
            b.Set(entity, onProperty, newValue);
        });

        BindToInternal(b, getEntityValue, setNewValue);
    }

    /// <summary>
    /// Synchronizes control value and property <paramref name="onProperty"/> of object reference <paramref name="onEntity"/> obtained from <paramref name="model"/>
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="b"></param>
    /// <param name="model"></param>
    /// <param name="onEntity"></param>
    /// <param name="onProperty"></param>
    public static void BindTo<TControl, TModel, TEntity, TValue>(
        this PropsBuilder<TControl> b,
        Var<TModel> model,
        System.Func<SyntaxBuilder, Var<TModel>, Var<TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, TValue>> onProperty)
        where TControl : IHasEditableValue
    {
        b.BindTo(model, b.Def(onEntity), onProperty);
    }

    /// <summary>
    /// Synchronizes control value and property <paramref name="onProperty"/> of object reference <paramref name="onEntity"/> obtained from <paramref name="model"/>
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="b"></param>
    /// <param name="model"></param>
    /// <param name="onEntity"></param>
    /// <param name="onProperty"></param>
    public static void BindTo<TControl, TModel, TEntity, TValue>(
        this PropsBuilder<TControl> b,
        Var<TModel> model,
        System.Linq.Expressions.Expression<System.Func<TModel, TEntity>> onEntity,
        System.Linq.Expressions.Expression<System.Func<TEntity, TValue>> onProperty)
        where TControl : IHasEditableValue
    {
        b.BindTo(model, b.Def((SyntaxBuilder b, Var<TModel> model) => b.Get(model, onEntity)), onProperty);
    }

    public static void BindTo<TControl, TModel, TValue>(
        this PropsBuilder<TControl> b,
        Var<TModel> model,
        System.Linq.Expressions.Expression<System.Func<TModel, TValue>> onProperty)
        where TControl : IHasEditableValue
    {
        b.BindTo(model, (SyntaxBuilder b, Var<TModel> model) => model, onProperty);
    }

    public static void BindTo<TControl, TModel>(
        this PropsBuilder<TControl> b,
        Var<TModel> model,
        System.Linq.Expressions.Expression<System.Func<TModel, string>> onProperty)
        where TControl : IHasEditableValue
    {
        b.BindTo(model, (SyntaxBuilder b, Var<TModel> model) => model, onProperty);
    }

    public static void BindTo<TControl, TModel>(
        this PropsBuilder<TControl> b,
        Var<TModel> model,
        System.Linq.Expressions.Expression<System.Func<TModel, int>> onProperty)
        where TControl : IHasEditableValue
    {
        b.BindTo(model, (SyntaxBuilder b, Var<TModel> model) => model, onProperty);
    }

    //public static void BindTo<TControl, TState, TEntity>(
    //    this PropsBuilder<TControl> b,
    //    Var<TState> state,
    //    Var<System.Func<TState, TEntity>> onEntity,
    //    System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    //    where TControl : IHasEditableValue<string>
    //{
    //    Var<TEntity> entity = b.Call(onEntity, state);
    //    Var<string> value = b.Get(entity, onProperty);

    //    var setProperty = b.MakeAction<TState, string>((SyntaxBuilder b, Var<TState> state, Var<string> inputValue) =>
    //    {
    //        Var<TEntity> entity = b.Call(onEntity, state);
    //        b.Set(entity, onProperty, inputValue);
    //        return b.Clone(state);
    //    });

    //    var binder = new TControl().GetValueAccessor();
    //    binder.SetControlValue(b, value);
    //    b.OnEventAction(binder.NewValueEventName, setProperty, b.Def(binder.GetNewValue));
    //}

    //public static void BindTo<TControl, TState, TEntity>(
    //    this PropsBuilder<TControl> b,
    //    Var<TState> state,
    //    System.Func<SyntaxBuilder, Var<TState>, Var<TEntity>> onEntity,
    //    System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    //    where TControl : IHasEditableValue<TControl>, new()
    //{
    //    b.BindTo(state, b.Def(onEntity), onProperty);
    //}

    //public static void BindTo<TControl, TState, TEntity>(this PropsBuilder<TControl> b,
    //    Var<TState> state,
    //    System.Linq.Expressions.Expression<System.Func<TState, TEntity>> onEntity,
    //    System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    //    where TControl : IHasEditableValue<TControl>, new()
    //{
    //    b.BindTo(state, b.Def((SyntaxBuilder b, Var<TState> state) => b.Get(state, onEntity)), onProperty);
    //}

    //public static void BindTo<TControl, TState, TEntity>(
    //    this PropsBuilder<TControl> b,
    //    Var<TState> state,
    //    System.Func<SyntaxBuilder, Var<TState>, Var<TEntity>> onEntity,
    //    System.Linq.Expressions.Expression<System.Func<TEntity, Guid>> onProperty)
    //    where TControl : IHasEditableValue<TControl>, new()
    //{
    //    b.BindTo(state, b.Def(onEntity), onProperty, Converter.GuidConverter);
    //}

    //public static void BindTo<TControl, TState, TEntity>(
    //    this PropsBuilder<TControl> b,
    //    Var<TState> state,
    //    System.Func<SyntaxBuilder, Var<TState>, Var<TEntity>> onEntity,
    //    System.Linq.Expressions.Expression<System.Func<TEntity, int>> onProperty)
    //    where TControl : IHasEditableValue<TControl>, new()
    //{
    //    b.BindTo(state, b.Def(onEntity), onProperty, Converter.IntConverter);
    //}

    //public static void BindTo<TControl, TState, TEntity>(
    //    this PropsBuilder<TControl> b,
    //    Var<TState> state,
    //    System.Func<SyntaxBuilder, Var<TState>, Var<TEntity>> onEntity,
    //    System.Linq.Expressions.Expression<System.Func<TEntity, bool>> onProperty)
    //    where TControl : IHasEditableValue<TControl>, new()
    //{
    //    b.BindTo(state, b.Def(onEntity), onProperty, Converter.BoolConverter);
    //}

    //public static void BindTo<TControl, TState, TEntity>(
    //    this PropsBuilder<TControl> b,
    //    Var<TState> state,
    //    System.Linq.Expressions.Expression<System.Func<TState, TEntity>> onEntity,
    //    System.Linq.Expressions.Expression<System.Func<TEntity, int>> onProperty)
    //    where TControl : IHasEditableValue<TControl>, new()
    //{
    //    b.BindTo(state, (SyntaxBuilder b, Var<TState> state) => b.Get(state, onEntity), onProperty);
    //}
}
