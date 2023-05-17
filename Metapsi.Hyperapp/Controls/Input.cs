using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Hyperapp
{
    public static class Input
    {
        public class Props<TState>
        {
            public bool IsPassword { get; set; }
            public string Value { get; set; } = string.Empty;
            public string Placeholder { get; set; } = string.Empty;
            public HyperType.Action<TState, string> OnInput { get; set; }
            public string CssClass { get; set; } = "hyper-input";
            public bool Enabled { get; set; } = true;
        }

        public static Var<HyperNode> Render<TState>(BlockBuilder b, Var<Props<TState>> props)
        {
            var input = b.Node("input", b.Concat(b.Get(props, x => x.CssClass), b.Const(" w-full")));
            var isPassword = b.Get(props, x => x.IsPassword);
            b.If(isPassword, b =>
            {
                b.SetAttr(input, Html.type, "password");
            },
            b =>
            {
                b.SetAttr(input, Html.type, "text");
            });

            var placeholder = b.Get(props, x => x.Placeholder);
            b.If(b.HasValue(placeholder), b => b.SetAttr(input, Html.placeholder, b.Get(props, x => x.Placeholder)));

            b.SetAttr(input, Html.value, b.Get(props, x => x.Value));
            b.SetOnInput(input, b.Get(props, x => x.OnInput));

            var enabled = b.Get(props, x => x.Enabled);
            b.If(b.Not(enabled), b => b.SetAttr(input, Html.disabled, true));
            //b.SetAttr(input, new DynamicProperty<System.Func<object, InputEvent, object>>("oninput"), onInput);

            return input;
        }
    }

    public static partial class Controls
    {
        public static Var<HyperNode> Input<TState>(
            this BlockBuilder b,
            Var<string> value,
            Var<HyperType.Action<TState, string>> onInput,
            Var<string> placeholder,
            System.Action<Modifier<Input.Props<TState>>> optional = null)
        {
            var props = b.NewObj<Hyperapp.Input.Props<TState>>(b =>
                {
                    b.Set(x => x.OnInput, onInput);
                    b.Set(x => x.Value, value);
                    b.Set(x => x.Placeholder, placeholder);
                });
            b.Modify(props, optional);
            return b.Call(Hyperapp.Input.Render, props);
        }

        public static Var<HyperNode> BoundInput<TEntity, TProp>(
            this BlockBuilder b,
            Var<TEntity> entity,
            System.Linq.Expressions.Expression<System.Func<TEntity, TProp>> onProperty,
            Var<string> placeholder,
            System.Action<Modifier<Input.Props<object>>> optional = null)
        {
            Var<TProp> value = b.Get(entity, onProperty);

            var setProperty = b.MakeAction<object, string>((BlockBuilder b, Var<object> state, Var<string> inputValue) =>
            {
                b.Set(entity, onProperty, inputValue.As<TProp>());
                return b.Clone(state);
            });

            var props = b.NewObj<Metapsi.Hyperapp.Input.Props<object>>(b =>
            {
                b.Set(x => x.OnInput, setProperty);
                b.Set(x => x.Value, value.As<string>());
                b.Set(x => x.Placeholder, placeholder);
            });

            b.Modify(props, optional);

            return b.Call(Hyperapp.Input.Render, props);
        }

        public static Var<HyperNode> BoundInput<TState, TEntity>(
            this BlockBuilder b,
            Var<TState> state,
            System.Linq.Expressions.Expression<System.Func<TState, TEntity>> onEntity,
            System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty,
            Var<string> placeholder)
        {
            Var<TEntity> entity = b.Get(state, onEntity);
            Var<string> value = b.Get(entity, onProperty);

            var setProperty = b.MakeAction<TState, string>((BlockBuilder b, Var<TState> state, Var<string> inputValue) =>
            {
                var entity = b.Get(state, onEntity);
                b.Set(entity, onProperty, inputValue);
                return b.Clone(state);
            });

            var props = b.NewObj<Metapsi.Hyperapp.Input.Props<TState>>(b =>
            {
                b.Set(x => x.OnInput, setProperty);
                b.Set(x => x.Value, value);
                b.Set(x => x.Placeholder, placeholder);
            });

            return b.Call(Hyperapp.Input.Render, props);
        }

        public static Var<HyperNode> BoundInput<TState, TEntity>(
            this BlockBuilder b,
            Var<TState> state,
            System.Linq.Expressions.Expression<System.Func<TState, TEntity>> onEntity,
            System.Linq.Expressions.Expression<System.Func<TEntity, int>> onProperty,
            Var<string> placeholder)
        {
            Var<TEntity> entity = b.Get(state, onEntity);
            Var<int> value = b.Get(entity, onProperty);

            var setProperty = b.MakeAction<TState, string>((BlockBuilder b, Var<TState> state, Var<string> inputValue) =>
            {
                Var<TEntity> entity = b.Get(state, onEntity);
                b.Set(entity, onProperty, b.ParseInt(inputValue));
                return b.Clone(state);
            });

            var stringValue = b.AsString(value);

            var props = b.NewObj<Metapsi.Hyperapp.Input.Props<TState>>(b =>
            {
                b.Set(x => x.OnInput, setProperty);
                b.Set(x => x.Value, stringValue);
                b.Set(x => x.Placeholder, placeholder);
            });

            return b.Call(Hyperapp.Input.Render, props);
        }

        public static Var<HyperNode> BoundInput<TState, TEntity, TId>(
            this BlockBuilder b,
            Var<TState> state,
            Var<TId> id,
            System.Linq.Expressions.Expression<System.Func<TState, TId, TEntity>> onEntity,
            System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty,
            Var<string> placeholder)
        {
            Var<TEntity> entity = b.Get(state, id, onEntity);
            Var<string> value = b.Get(entity, onProperty);

            var setProperty = b.MakeAction<TState, string>((BlockBuilder b, Var<TState> state, Var<string> inputValue) =>
            {
                var entity = b.Get(state, id, onEntity);
                b.Set(entity, onProperty, inputValue);
                return b.Clone(state);
            });

            var props = b.NewObj<Metapsi.Hyperapp.Input.Props<TState>>(b =>
            {
                b.Set(x => x.OnInput, setProperty);
                b.Set(x => x.Value, value);
                b.Set(x => x.Placeholder, placeholder);
            });

            return b.Call(Hyperapp.Input.Render, props);
        }

        public static Var<HyperNode> BoundInput<TState, TEntity>(
            this BlockBuilder b,
            Var<TState> state,
            System.Linq.Expressions.Expression<System.Func<TState, TEntity>> onEntity,
            System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty,
            string placeholder = "")
        {
            return b.BoundInput(state, onEntity, onProperty, b.Const(placeholder));
        }
    }
}

