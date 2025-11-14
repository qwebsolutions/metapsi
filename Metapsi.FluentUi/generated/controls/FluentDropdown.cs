using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentDropdown
{
    public static class Slot
    {
        public const string Indicator = "indicator";
        public const string Control = "control";
    }
}
public static partial class FluentDropdownExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDropdown(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentDropdown>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-dropdown", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDropdown(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentDropdown>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentDropdown(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDropdown(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentDropdown(b => { }, children);
    }
    public static void SetAppearance(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<string> appearance) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), appearance);
    }
    public static void SetAppearance(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, string appearance) 
    {
        b.SetAppearance(b.Const(appearance));
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetSizeLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }
    public static void SetActiveDescendant(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<string> activeDescendant) 
    {
        b.SetProperty(b.Props, b.Const("activeDescendant"), activeDescendant);
    }
    public static void SetActiveDescendant(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, string activeDescendant) 
    {
        b.SetActiveDescendant(b.Const(activeDescendant));
    }
    public static void SetAriaLabelledBy(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<string> ariaLabelledBy) 
    {
        b.SetProperty(b.Props, b.Const("ariaLabelledBy"), ariaLabelledBy);
    }
    public static void SetAriaLabelledBy(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, string ariaLabelledBy) 
    {
        b.SetAriaLabelledBy(b.Const(ariaLabelledBy));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.SetDisabled(b.Const(true));
    }
    public static void SetDisabledChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Action<bool, bool>> disabledChanged) 
    {
        b.SetProperty(b.Props, b.Const("disabledChanged"), disabledChanged);
    }
    public static void SetDisplayValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<string> displayValue) 
    {
        b.SetProperty(b.Props, b.Const("displayValue"), displayValue);
    }
    public static void SetDisplayValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, string displayValue) 
    {
        b.SetDisplayValue(b.Const(displayValue));
    }
    public static void SetId(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<string> id) 
    {
        b.SetProperty(b.Props, b.Const("id"), id);
    }
    public static void SetId(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, string id) 
    {
        b.SetId(b.Const(id));
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<string> initialValue) 
    {
        b.SetProperty(b.Props, b.Const("initialValue"), initialValue);
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, string initialValue) 
    {
        b.SetInitialValue(b.Const(initialValue));
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<bool> multiple) 
    {
        b.SetProperty(b.Props, b.Const("multiple"), multiple);
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, bool multiple) 
    {
        b.SetMultiple(b.Const(multiple));
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.SetMultiple(b.Const(true));
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<string> name) 
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, string name) 
    {
        b.SetName(b.Const(name));
    }
    public static void SetOpen(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<bool> open) 
    {
        b.SetProperty(b.Props, b.Const("open"), open);
    }
    public static void SetOpen(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, bool open) 
    {
        b.SetOpen(b.Const(open));
    }
    public static void SetOpen(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.SetOpen(b.Const(true));
    }
    public static void SetPlaceholder(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<string> placeholder) 
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }
    public static void SetPlaceholder(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, string placeholder) 
    {
        b.SetPlaceholder(b.Const(placeholder));
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<bool> required) 
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, bool required) 
    {
        b.SetRequired(b.Const(required));
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.SetRequired(b.Const(true));
    }
    public static void SetTypeCombobox(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("combobox"));
    }
    public static void SetTypeDropdown(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("dropdown"));
    }
    public static void SetTypeSelect(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("select"));
    }
    public static void SetValueAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<string> valueAttribute) 
    {
        b.SetProperty(b.Props, b.Const("valueAttribute"), valueAttribute);
    }
    public static void SetValueAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, string valueAttribute) 
    {
        b.SetValueAttribute(b.Const(valueAttribute));
    }
    public static void SetEnabledOptions(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Collections.Generic.List<FluentDropdownOption>> enabledOptions) 
    {
        b.SetProperty(b.Props, b.Const("enabledOptions"), enabledOptions);
    }
    public static void SetLabels(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Collections.Generic.List<Node>> labels) 
    {
        b.SetProperty(b.Props, b.Const("labels"), labels);
    }
    public static void SetOptions(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Collections.Generic.List<FluentDropdownOption>> options) 
    {
        b.SetProperty(b.Props, b.Const("options"), options);
    }
    public static void SetSelectedOptions(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Collections.Generic.List<FluentDropdownOption>> selectedOptions) 
    {
        b.SetProperty(b.Props, b.Const("selectedOptions"), selectedOptions);
    }
    public static void SetValidity(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<ValidityState> validity) 
    {
        b.SetProperty(b.Props, b.Const("validity"), validity);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<string> value) 
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, string value) 
    {
        b.SetValue(b.Const(value));
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<bool> willValidate) 
    {
        b.SetProperty(b.Props, b.Const("willValidate"), willValidate);
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, bool willValidate) 
    {
        b.SetWillValidate(b.Const(willValidate));
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.SetWillValidate(b.Const(true));
    }
    public static void SetChangeHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Func<Event, bool>> changeHandler) 
    {
        b.SetProperty(b.Props, b.Const("changeHandler"), changeHandler);
    }
    public static void SetChangeHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Action<Event>> changeHandler) 
    {
        b.SetProperty(b.Props, b.Const("changeHandler"), changeHandler);
    }
    public static void SetClickHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Func<PointerEvent, bool>> clickHandler) 
    {
        b.SetProperty(b.Props, b.Const("clickHandler"), clickHandler);
    }
    public static void SetClickHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Action<PointerEvent>> clickHandler) 
    {
        b.SetProperty(b.Props, b.Const("clickHandler"), clickHandler);
    }
    public static void SetInputHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Func<InputEvent, bool>> inputHandler) 
    {
        b.SetProperty(b.Props, b.Const("inputHandler"), inputHandler);
    }
    public static void SetInputHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Action<InputEvent>> inputHandler) 
    {
        b.SetProperty(b.Props, b.Const("inputHandler"), inputHandler);
    }
    public static void SetKeydownHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Func<KeyboardEvent, bool>> keydownHandler) 
    {
        b.SetProperty(b.Props, b.Const("keydownHandler"), keydownHandler);
    }
    public static void SetKeydownHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<System.Action<KeyboardEvent>> keydownHandler) 
    {
        b.SetProperty(b.Props, b.Const("keydownHandler"), keydownHandler);
    }
    public static Metapsi.Syntax.ObjBuilder<bool> CheckValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        return b.Call<bool>("checkValidity");
    }
    public static void InsertControl(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        b.Call("insertControl");
    }
    public static Metapsi.Syntax.ObjBuilder<bool> ReportValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentDropdown> b) 
    {
        return b.Call<bool>("reportValidity");
    }
    public static void SelectOption(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentDropdown> b, Metapsi.Syntax.Var<int> index, Metapsi.Syntax.Var<bool> shouldEmit) 
    {
        b.Call("selectOption", index, shouldEmit);
    }
}