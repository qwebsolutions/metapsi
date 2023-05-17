using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static class Toggle
    {
        public class Props
        {
            public bool IsOn { get; set; }
            public string OnLabel { get; set; }
            public string OffLabel { get; set; }
            //public Command OnChange { get; set; }
            public bool Enabled { get; set; } = true;
            public string PillClass { get; set; } = "toggle-pill";
            public string DotClass { get; set; } = "toggle-dot";
            public string LabelClass { get; set; } = string.Empty;
        }

        public class ToggleTarget
        {
            public bool @checked { get; set; }
        }

        internal static Var<HyperNode> Render<TState>(BlockBuilder b, Var<Props> props, Var<HyperType.Action<TState, bool>> onToggle)
        {
            var isOn = b.Get(props, x => x.IsOn);
            var container = b.Div("flex items-center justify-left");
            var label = b.Add(container, b.Node("label", "flex items-center"));
            var div = b.Add(label, b.Div("relative"));
            var input = b.Add(div, b.Node("input", "sr-only peer"));
            b.SetAttr(input,  Html.type, "checkbox");
            b.SetAttr(input, Html.@checked, isOn);

            b.SetAttr(
                input,
                new DynamicProperty<HyperType.Action<TState, DomEvent<ToggleTarget>>>("onclick"),
                b.MakeAction((BlockBuilder b, Var<TState> state, Var<DomEvent<ToggleTarget>> @event) =>
                {
                    b.CallExternal(nameof(Metapsi.Syntax.Native), "stopPropagation", @event);
                    var target = b.Get(@event, x => x.target);
                    var value = b.Get(target, x => x.@checked);
                    return b.MakeActionDescriptor(onToggle, value);
                }));

            b.If(b.Get(props, x => x.Enabled), b =>
            {
                b.AddClass(label, " cursor-pointer");
            },
            b =>
            {
                b.SetAttr(input, Html.disabled, true);
                //b.AddClass(label, "cursor-not-allowed");
            });
            var pill = b.Add(div, b.Div("block "));
            b.AddClass(pill, b.Get(props, x => x.PillClass));
            
            var dot = b.Add(div, b.Div("dot absolute "));
            b.AddClass(dot, b.Get(props, x => x.DotClass));
            var lc = b.Add(label, b.Div("ml-3"));
            var labelText = b.Add(lc, b.Text(b.Get(props, isOn, (props, isOn) => isOn ? props.OnLabel : props.OffLabel)));
            b.AddClass(labelText, b.Get(props, x => x.LabelClass));
            return container;
        }
    }

    public static partial class Controls
    {
        public static void Modify<T>(this BlockBuilder b, Var<T> obj, System.Action<Modifier<T>> update)
        {
            if (update != null)
            {
                update(new Modifier<T>(b, obj));
            }
        }

        public static void Modify<T, TProp>(
            this BlockBuilder b,
            Var<T> obj,
            System.Linq.Expressions.Expression<System.Func<T, TProp>> by,
            System.Action<Modifier<TProp>> update)
        {
            var prop = b.Get(obj, by);

            if (update != null)
            {
                update(new Modifier<TProp>(b, prop));
            }
        }

        public static Var<HyperNode> Toggle<TState>(
            this BlockBuilder b,
            Var<bool> isOn,
            Var<HyperType.Action<TState, bool>> onToggle,
            Var<string> onLabel,
            Var<string> offLabel,
            System.Action<Modifier<Toggle.Props>> optional = null)
        {
            var props = b.NewObj<Toggle.Props>(b =>
            {
                b.Set(x => x.IsOn, isOn);
                b.Set(x => x.OnLabel, onLabel);
                b.Set(x => x.OffLabel, offLabel);
            });
            
            b.Modify(props, optional);
            return b.Call(Hyperapp.Toggle.Render, props, onToggle);
        }

        public static Var<HyperNode> BoundToggle<TEntity>(
            this BlockBuilder b,
            Var<TEntity> entity,
            System.Linq.Expressions.Expression<System.Func<TEntity, bool>> onProperty,
            Var<string> onLabel,
            Var<string> offLabel,
            System.Action<Modifier<Toggle.Props>> optional = null)
        {
            var isOn = b.Get(entity, onProperty);

            return b.Toggle(
                isOn,
                b.MakeAction((BlockBuilder b, Var<object> state, Var<bool> isOn) =>
                {
                    b.Set(entity, onProperty, isOn);
                    return b.Clone(state);
                }),
                onLabel,
                offLabel,
                optional);
        }

        //public static Var<HyperNode> BoundToggle<TState, TEntity>(
        //    this BlockBuilder b,
        //    Var<TState> state,
        //    System.Linq.Expressions.Expression<System.Func<TState, TEntity>> onEntity,
        //    System.Linq.Expressions.Expression<System.Func<TEntity, bool>> onProperty,
        //    Var<string> onLabel,
        //    Var<string> offLabel,
        //    System.Action<Modifier<Toggle.Props>> optional = null)
        //{
        //    var entity = b.Get(state, onEntity);
        //    var isOn = b.Get(entity, onProperty);

        //    return b.Toggle(
        //        isOn,
        //        b.MakeAction((BlockBuilder b, Var<TState> state, Var<bool> isOn) =>
        //        {
        //            var entity = b.Get(state, onEntity);
        //            b.Set(entity, onProperty, isOn);
        //            return b.Clone(state);
        //        }),
        //        onLabel,
        //        offLabel,
        //        optional); ;
        //}
    }

}

