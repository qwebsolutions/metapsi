using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Metapsi.Hyperapp
{
    public static class DropDown
    {
        public class Props
        {
            public string Id { get; set; } = string.Empty; // The ID is mandatory
            public string Value { get; set; } = string.Empty;
            public string Placeholder { get; set; } = string.Empty;
            public List<Option> Options { get; set; }
            public HyperType.Action<object, string> OnChanged { get; set; }
            public bool Enabled { get; set; } = true;
        }

        public class Option
        {
            public string value { get; set; }
            public string label { get; set; }
            public bool selected { get; set; }
            public bool disabled { get; set; }
        }

        /// <summary>
        /// Needed in the forward of event
        /// </summary>
        private class ChoiceData
        {
            public List<Option> Options { get; set; }
            public HyperType.Action<object, string> OnChanged { get; set; }
            public bool Enabled { get; set; }
        }

        internal static Var<HyperNode> Render(BlockBuilder b, Var<Props> props)
        {
            b.AddScript("/choices.min.js");
            b.AddStylesheet("/choices.min.css");
            b.AddStylesheet("/metapsi.hyperapp.css");

            const string import = "choices";

            var renderAction = b.ModuleBuilder.AddImport(import, "renderDropDown").As<HyperType.Action<object, string>>();
            var choiceAction = b.ModuleBuilder.AddImport(import, "onChoiceAction").As<HyperType.Action<object, string>>();

            b.AddSubscription<object>(
                "onDropDownRender",
                (BlockBuilder b, Var<object> state) => b.Listen(b.Const("afterRender"), renderAction));

            b.AddSubscription<object>(
                "onDropDownChoice",
                (BlockBuilder b, Var<object> state) => b.Listen(b.Const("onChoice"), choiceAction));

            var selectId = b.Get(props, props => props.Id);

            var container = b.Span();
            b.SetAttr(container, Html.id, selectId);
            b.If(b.Get(props, x => x.Enabled), b => b.AddClass(container, "cursor-pointer"));
            var options = b.Get(props, x => x.Options);

            var selectedValue = b.Get(props, x => x.Value);
            var selectedOption = b.Get(options, selectedValue, (options, selectedValue) => options.SingleOrDefault(x => x.value == selectedValue));
            b.If(b.HasObject(selectedOption), b => b.Set(selectedOption, x => x.selected, b.Const(true)));

            var choiceData = b.NewObj<ChoiceData>();
            b.Set(choiceData, x => x.Enabled, b.Get(props, x => x.Enabled));
            b.Set(choiceData, x => x.Options, options);
            b.Set(choiceData, x => x.OnChanged, b.Get(props, props => props.OnChanged));
            b.CallExternal(import, "addDropDown", selectId, choiceData);

            return container;
        }

        internal static Var<List<Option>> WithNotSelected(this BlockBuilder b, Var<List<Option>> options, Var<string> selectedValue)
        {
            var shouldAddNotSelected =
                b.If(b.IsEmpty(selectedValue),
                b => b.Const(true),
                b => b.If(b.IsEmpty(selectedValue.As<System.Guid>()), b => b.Const(true), b => b.Const(false)));

            return b.If(shouldAddNotSelected,
                b =>
                {
                    var outOptions = b.NewCollection<Option>();
                    b.Push(outOptions, b.Const(new Option() { disabled = true, label = "(not selected)", selected = true, value = string.Empty }));
                    b.Foreach(options, (b, option) => b.Push(outOptions, option));
                    return outOptions;
                },
                b =>
                {
                    var outOptions = b.NewCollection<Option>();
                    b.Foreach(options, (b, option) => {
                        b.If(b.AreEqual(selectedValue, b.Get(option, x => x.value)),
                            b =>
                            {
                                b.Set(option, x => x.selected, b.Const(true));
                            },
                            b =>
                            {
                                b.Set(option, x => x.selected, b.Const(false));
                            });
                        b.Push(outOptions, option);
                    });
                    return outOptions;
                });
        }

        public static Var<string> ReplaceIfEmptyGuid(this BlockBuilder b, Var<string> selectedId)
        {
            return b.If<string>(b.IsEmpty(selectedId.As<System.Guid>()), b => b.Const(string.Empty), b => selectedId);
        }

        public static Var<System.Func<TSource, DropDown.Option>> TransformBy<TSource, TProp>(
            this BlockBuilder b,
            System.Linq.Expressions.Expression<System.Func<TSource, TProp>> valueSelector,
            System.Linq.Expressions.Expression<System.Func<TSource, string>> labelSelector)
        {
            return b.Def((BlockBuilder b, Var<TSource> source) =>
            {
                var label = b.Get(source, labelSelector);
                var value = b.Get(source, valueSelector);
                return b.NewObj<DropDown.Option>(b =>
                {
                    b.Set(x => x.label, label);
                    b.Set(x => x.value, value.As<string>());
                });
            });
        }
    }

    public static partial class Controls
    {
        public static Var<HyperNode> DropDown(
           this BlockBuilder b,
           Var<string> dropDownId,
           Var<string> value,
           Var<List<DropDown.Option>> options,
           Var<System.Action<string>> onInput,
           Var<string> placeholder,
           System.Action<Modifier<DropDown.Props>> optional = null)
        {
            var withNotSelected = b.WithNotSelected(options, value);
            var replacedValue = b.ReplaceIfEmptyGuid(value);

            var onChangedAction = b.MakeAction((BlockBuilder b, Var<object> page, Var<string> payload) =>
            {
                b.Call(onInput, payload);
                return b.Clone(page);
            });

            var props = b.NewObj<DropDown.Props>(b =>
            {
                b.Set(x => x.Id, dropDownId);
                b.Set(x => x.Value, replacedValue);
                b.Set(x => x.OnChanged, onChangedAction);
                b.Set(x => x.Options, withNotSelected);
                b.Set(x => x.Placeholder, placeholder);
              });

            b.Modify(props, optional);

            return b.Call(Hyperapp.DropDown.Render, props);
        }

        public static Var<HyperNode> DropDown<TState>(
           this BlockBuilder b,
           Var<string> dropDownId,
           Var<string> value,
           Var<List<DropDown.Option>> options,
           Var<HyperType.Action<TState, string>> onInput,
           Var<string> placeholder,
           System.Action<Modifier<DropDown.Props>> optional = null)
        {
            var withNotSelected = b.WithNotSelected(options, value);
            var replacedValue = b.ReplaceIfEmptyGuid(value);

            var props = b.NewObj<DropDown.Props>(b =>
            {
                b.Set(x => x.Id, dropDownId);
                b.Set(x => x.Value, replacedValue);
                b.Set(x => x.OnChanged, onInput.As<HyperType.Action<object, string>>());
                b.Set(x => x.Options, withNotSelected);
                b.Set(x => x.Placeholder, placeholder);
            });

            b.Modify(props, optional);

            return b.Call(Hyperapp.DropDown.Render, props);
        }

        public static Var<HyperNode> BoundDropDown<TObject, TOption, TProp>(
            this BlockBuilder b,
            Var<string> dropDownName,
            Var<TObject> obj,
            Expression<System.Func<TObject, TProp>> onProperty,
            Var<List<TOption>> optionsSource,
            Var<System.Func<TOption, DropDown.Option>> transform,
            System.Action<Modifier<DropDown.Props>> optional = null)
        {
            var selectedValue = b.Get(obj, onProperty).As<string>();
            var dropDownOptions = b.Get(optionsSource, transform, (x, transform) => x.Select(y => transform(y)).ToList());

            var onInputConverted = b.Def(
                (BlockBuilder b, Var<string> stringValue) =>
                {
                    b.Set(obj, onProperty, stringValue.As<TProp>());
                });

            return b.DropDown(dropDownName, selectedValue, dropDownOptions, onInputConverted, b.Const(string.Empty), optional);
        }

        public static Var<HyperNode> BoundDropDown<TObject, TOption, TProp>(
            this BlockBuilder b,
            Var<string> dropDownName,
            Var<TObject> obj,
            Expression<System.Func<TObject, TProp>> onProperty,
            Var<List<TOption>> optionsSource,
            Expression<System.Func<TOption, TProp>> valueSelector,
            Expression<System.Func<TOption, string>> labelSelector,
            System.Action<Modifier<DropDown.Props>> optional = null)
        {
            return b.BoundDropDown(
                dropDownName, 
                obj, 
                onProperty, 
                optionsSource, 
                b.TransformBy(valueSelector, labelSelector),
                optional);
        }
    }
}