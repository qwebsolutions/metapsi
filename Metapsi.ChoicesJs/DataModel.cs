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


public class ChoicesOptions
{
    public bool silent { get; set; } = false;
    public List<string> items { get; set; } = new();
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
    public string placeholderValue { get; set; } = "";
    public string searchPlaceholderValue { get; set; } = "Search...";
    public string prependValue { get; set; } = null;
    public string appendValue { get; set; } = null;
    public string renderSelectedChoices { get; set; } = "auto"; // auto/always
    public string loadingText { get; set; } = "Loading...";
    public string noResultsText { get; set; } = "No results found";
    public string noChoicesText { get; set; } = "No choices to choose from";
    public string itemSelectText { get; set; } = "Press to select";

    public System.Func<string, string> addItemText { get; set; } = null;
    public System.Func<string, string> maxItemText { get; set; } = null;
    public System.Func<object, object> valueComparer { get; set; } = null;
    public string labelId { get; set; } = string.Empty;

    public ClassNames classNames { get; set; } = new();
}

public class RemoveItemArgs
{
    public string id { get; set; }
    public string value { get; set; }
    public string label { get; set; }
    public object customProperties { get; set; }
    public string groupValue { get; set; }
}

public class AddItemArgs
{
    public string id { get; set; }
    public string value { get; set; }
    public string label { get; set; }
    public object customProperties { get; set; }
    public string groupValue { get; set; }
    public string keyCode { get; set; }
}

public class SearchArgs
{
    public string value { get; set; }
    public int resultCount { get; set; }
}