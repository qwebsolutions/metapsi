using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentDropdownOption
{
    public static class Slot
    {
        public const string CheckedIndicator = "checked-indicator";
        public const string Description = "description";
    }
}
public static partial class FluentDropdownOptionExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDropdownOption(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentDropdownOption>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-dropdown-option", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDropdownOption(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentDropdownOption>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentDropdownOption(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDropdownOption(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentDropdownOption(b => { }, children);
    }
    public static void SetActive(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<bool> active) 
    {
        b.SetProperty(b.Props, b.Const("active"), active);
    }
    public static void SetActive(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, bool active) 
    {
        b.SetActive(b.Const(active));
    }
    public static void SetActive(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b) 
    {
        b.SetActive(b.Const(true));
    }
    public static void SetDefaultSelected(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<bool> defaultSelected) 
    {
        b.SetProperty(b.Props, b.Const("defaultSelected"), defaultSelected);
    }
    public static void SetDefaultSelected(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, bool defaultSelected) 
    {
        b.SetDefaultSelected(b.Const(defaultSelected));
    }
    public static void SetDefaultSelected(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b) 
    {
        b.SetDefaultSelected(b.Const(true));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b) 
    {
        b.SetDisabled(b.Const(true));
    }
    public static void SetDisabledAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<bool> disabledAttribute) 
    {
        b.SetProperty(b.Props, b.Const("disabledAttribute"), disabledAttribute);
    }
    public static void SetDisabledAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, bool disabledAttribute) 
    {
        b.SetDisabledAttribute(b.Const(disabledAttribute));
    }
    public static void SetDisabledAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b) 
    {
        b.SetDisabledAttribute(b.Const(true));
    }
    public static void SetFormAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<string> formAttribute) 
    {
        b.SetProperty(b.Props, b.Const("formAttribute"), formAttribute);
    }
    public static void SetFormAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, string formAttribute) 
    {
        b.SetFormAttribute(b.Const(formAttribute));
    }
    public static void SetFreeform(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<bool> freeform) 
    {
        b.SetProperty(b.Props, b.Const("freeform"), freeform);
    }
    public static void SetFreeform(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, bool freeform) 
    {
        b.SetFreeform(b.Const(freeform));
    }
    public static void SetFreeform(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b) 
    {
        b.SetFreeform(b.Const(true));
    }
    public static void SetId(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<string> id) 
    {
        b.SetProperty(b.Props, b.Const("id"), id);
    }
    public static void SetId(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, string id) 
    {
        b.SetId(b.Const(id));
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<string> initialValue) 
    {
        b.SetProperty(b.Props, b.Const("initialValue"), initialValue);
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, string initialValue) 
    {
        b.SetInitialValue(b.Const(initialValue));
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<bool> multiple) 
    {
        b.SetProperty(b.Props, b.Const("multiple"), multiple);
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, bool multiple) 
    {
        b.SetMultiple(b.Const(multiple));
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b) 
    {
        b.SetMultiple(b.Const(true));
    }
    public static void SetMultipleChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<System.Action<bool, bool>> multipleChanged) 
    {
        b.SetProperty(b.Props, b.Const("multipleChanged"), multipleChanged);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<string> name) 
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, string name) 
    {
        b.SetName(b.Const(name));
    }
    public static void SetTextAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<string> textAttribute) 
    {
        b.SetProperty(b.Props, b.Const("textAttribute"), textAttribute);
    }
    public static void SetTextAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, string textAttribute) 
    {
        b.SetTextAttribute(b.Const(textAttribute));
    }
    public static void SetForm(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<HTMLFormElement> form) 
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }
    public static void SetLabels(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<System.Collections.Generic.List<HTMLLabelElement>> labels) 
    {
        b.SetProperty(b.Props, b.Const("labels"), labels);
    }
    public static void SetSelected(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<bool> selected) 
    {
        b.SetProperty(b.Props, b.Const("selected"), selected);
    }
    public static void SetSelected(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, bool selected) 
    {
        b.SetSelected(b.Const(selected));
    }
    public static void SetSelected(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b) 
    {
        b.SetSelected(b.Const(true));
    }
    public static void SetText(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<string> text) 
    {
        b.SetProperty(b.Props, b.Const("text"), text);
    }
    public static void SetText(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, string text) 
    {
        b.SetText(b.Const(text));
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<string> value) 
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDropdownOption> b, string value) 
    {
        b.SetValue(b.Const(value));
    }
    public static void ToggleSelected(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentDropdownOption> b, Metapsi.Syntax.Var<bool> force) 
    {
        b.Call("toggleSelected", force);
    }
}