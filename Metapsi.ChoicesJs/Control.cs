using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.ChoicesJs;

public class Choice
{
    public string value { get; set; } = string.Empty;
    public string label { get; set; } = string.Empty;
    public bool selected { get; set; }
    public bool disabled { get; set; }
}

public class ClassNames
{
    public string containerOuter { get; set; } = "choices";
    public string containerInner { get; set; } = "choices__inner";
    public string input { get; set; } = "choices__input";
    public string inputCloned { get; set; } = "choices__input--cloned";
    public string list { get; set; } = "choices__list";
    public string listItems { get; set; } = "choices__list--multiple";
    public string listSingle { get; set; } = "choices__list--single";
    public string listDropdown { get; set; } = "choices__list--dropdown";
    public string item { get; set; } = "choices__item";
    public string itemSelectable { get; set; } = "choices__item--selectable";
    public string itemDisabled { get; set; } = "choices__item--disabled";
    public string itemOption { get; set; } = "choices__item--choice";
    public string group { get; set; } = "choices__group";
    public string groupHeading { get; set; } = "choices__heading";
    public string button { get; set; } = "choices__button";
    public string activeState { get; set; } = "is-active";
    public string focusState { get; set; } = "is-focused";
    public string openState { get; set; } = "is-open";
    public string disabledState { get; set; } = "is-disabled";
    public string highlightedState { get; set; } = "is-highlighted";
    public string selectedState { get; set; } = "is-selected";
    public string flippedState { get; set; } = "is-flipped";
}

public class Props
{
    public bool silent { get; set; } = false;
    public List<Choice> choices { get; set; } = new();
    public int renderChoiceLimit { get; set; } = -1;
    public int maxItemCount { get; set; } = -1;
    public bool addItems { get; set; } = true;
    public bool removeItems { get; set; } = true;
    public bool removeItemButton { get; set; } = false;
    public bool editItems { get; set; } = false;
    public bool allowHTML { get; set; } = true;
    public bool duplicateItemsAllowed { get; set; } = true;
    public string delimiter { get; set; } = ",";
    public bool paste { get; set; } = true;
    public bool searchEnabled { get; set; } = true;
    public bool searchChoices { get; set; } = true;
    public List<string> searchFields { get; set; } = new() { "label", "value" };
    public int searchFloor { get; set; } = 1;
    public int searchResultLimit { get; set; } = 4;
    public string position { get; set; } = "auto";
    public bool resetScrollPosition { get; set; } = true;
    //addItemFilter
    public bool shouldSort { get; set; } = true;
    public bool shouldSortItems { get; set; } = false;
    // sorter
    public bool placeholder { get; set; } = true;
    public string placeholderValue { get; set; } = null;
    public string searchPlaceholderValue { get; set; } = null;
    public string prependValue { get; set; } = null;
    public string appendValue { get; set; } = null;
    public string renderSelectedChoices { get; set; } = "auto"; // auto/always
    public string loadingText { get; set; } = "Loading...";
    public string noResultsText { get; set; } = "No results found";
    public string noChoicesText { get; set; } = "No choices to choose from";
    public string itemSelectText { get; set; } = "Press to select";

    public string addItemText { get; set; } = null;
    public string maxItemText { get; set; } = null;
    public System.Func<object, object> valueComparer { get; set; } = null;
    public string labelId { get; set; } = string.Empty;

    public ClassNames classNames { get; set; } = new();
}

public static class Control
{
    public static void SetAddItemTextFn(this BlockBuilder b, Var<Props> props, Var<System.Func<string, string>> addItemTextFn)
    {
        b.SetDynamic(props.As<DynamicObject>(), new DynamicProperty<System.Func<string, string>>(nameof(Props.addItemText)), addItemTextFn);
    }

    public static void SetMaxItemTextFn(this BlockBuilder b, Var<Props> props, Var<System.Func<string, string>> maxItemTextFn)
    {
        b.SetDynamic(props.As<DynamicObject>(), new DynamicProperty<System.Func<string, string>>(nameof(Props.addItemText)), maxItemTextFn);
    }

    public static void SetValueComparerFn(this BlockBuilder b, Var<Props> props, Var<System.Func<object, object>> valueComparerFn)
    {
        b.SetDynamic(props.As<DynamicObject>(), new DynamicProperty<System.Func<object, object>>(nameof(Props.valueComparer)), valueComparerFn);
    }


    public static Var<HyperNode> ChoicesText(this BlockBuilder b, Var<Props> props)
    {
        b.AddStaticFiles();
        var node = b.Node("metapsi-choices-text");
        b.SetControlProps(node, props);
        return node;
    }

    public static Var<HyperNode> ChoicesSelectOne(this BlockBuilder b, Var<Props> props)
    {
        b.AddStaticFiles();
        var node = b.Node("metapsi-choices-select-one");
        b.SetControlProps(node, props);
        return node;
    }

    public static Var<HyperNode> ChoicesSelectMultiple(this BlockBuilder b, Var<Props> props)
    {
        b.AddStaticFiles();
        var node = b.Node("metapsi-choices-select-multiple");
        b.SetControlProps(node, props);

        return node;
    }

    public static Var<List<Choice>> MapChoices<TItem, TId>(
        this BlockBuilder b,
        Var<List<TItem>> items,
        Var<System.Func<TItem, TId>> valueProp,
        Var<System.Func<TItem, string>> labelProp,
        Var<TId> selectedId)
    {
        return b.Map(items, (b, item) =>
        {
            var value = b.AsString(b.Call(valueProp, item));
            var label = b.AsString(b.Call(labelProp, item));

            var choice = b.NewObj<Choice>(b =>
            {
                b.Set(x => x.value, value);
                b.Set(x => x.label, label);
            });

            if (selectedId != null)
            {
                b.If(
                    b.AreEqual(selectedId, b.Call(valueProp, item)),
                    b =>
                    {
                        b.Set(choice, x => x.selected, b.Const(true));
                    });
            }

            return choice;
        });
    }

    public static Var<List<Choice>> MapChoices<TItem, TId>(
        this BlockBuilder b,
        Var<List<TItem>> items,
        System.Linq.Expressions.Expression<System.Func<TItem, TId>> valueProp,
        System.Linq.Expressions.Expression<System.Func<TItem, string>> labelProp,
        Var<TId> selectedId = null)
    {
        return b.Map(items, (b, item) =>
        {
            var value = b.AsString(b.Get(item, valueProp));
            var label = b.AsString(b.Get(item, labelProp));

            var choice = b.NewObj<Choice>(b =>
            {
                b.Set(x => x.value, value);
                b.Set(x => x.label, label);
            });

            if (selectedId != null)
            {
                b.If(
                    b.AreEqual(selectedId, b.Get(item, valueProp)),
                    b =>
                    {
                        b.Set(choice, x => x.selected, b.Const(true));
                    });
            }

            return choice;
        });
    }

    public static Var<List<Choice>> MapChoices<TItem>(
            this BlockBuilder b,
            Var<List<TItem>> items,
            System.Linq.Expressions.Expression<System.Func<TItem, string>> valueProp,
            System.Linq.Expressions.Expression<System.Func<TItem, string>> labelProp,
            Var<string> selectedId = null)
    {
        return b.MapChoices<TItem, string>(items, valueProp, labelProp, selectedId);
    }

    public static void SetSelectedChoice<TValue>(this BlockBuilder b, Var<List<Choice>> choices, Var<TValue> selectedValue)
    {
        b.Foreach(choices, (b, choice) =>
        {
            b.If(b.AreEqual(b.AsString(selectedValue), b.Get(choice, x => x.value)),
                b =>
                {
                    b.Set(choice, x => x.selected, b.Const(true));
                });
        });
    }

    

    private static void AddStaticFiles(this BlockBuilder b)
    {
        b.AddStylesheet("choices.min.css");
        b.AddScript("choices.min.js");
        b.AddScript("metapsi.choices.js", "module");
    }
}
