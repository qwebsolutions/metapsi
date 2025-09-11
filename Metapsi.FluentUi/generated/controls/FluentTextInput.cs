using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentTextInput
{
    public static class Slot
    {
        public const string Start = "start";
        public const string End = "end";
    }
}
public static partial class FluentTextInputExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTextInput(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTextInput>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-text-input", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTextInput(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTextInput>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTextInput(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTextInput(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTextInput(b => { }, children);
    }
    public static void SetAppearanceOutline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("outline"));
    }
    public static void SetAppearanceFilledDarker(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("filled-darker"));
    }
    public static void SetAppearanceFilledLighter(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("filled-lighter"));
    }
    public static void SetAppearanceUnderline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("underline"));
    }
    public static void SetControlSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("controlSize"), b.Const("small"));
    }
    public static void SetControlSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("controlSize"), b.Const("medium"));
    }
    public static void SetControlSizeLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("controlSize"), b.Const("large"));
    }
    public static void SetAutocomplete(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> autocomplete) 
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), autocomplete);
    }
    public static void SetAutocomplete(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, string autocomplete) 
    {
        b.SetAutocomplete(b.Const(autocomplete));
    }
    public static void SetAutofocus(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<bool> autofocus) 
    {
        b.SetProperty(b.Props, b.Const("autofocus"), autofocus);
    }
    public static void SetAutofocus(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, bool autofocus) 
    {
        b.SetAutofocus(b.Const(autofocus));
    }
    public static void SetAutofocus(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetAutofocus(b.Const(true));
    }
    public static void SetCurrentValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> currentValue) 
    {
        b.SetProperty(b.Props, b.Const("currentValue"), currentValue);
    }
    public static void SetCurrentValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, string currentValue) 
    {
        b.SetCurrentValue(b.Const(currentValue));
    }
    public static void SetDirname(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> dirname) 
    {
        b.SetProperty(b.Props, b.Const("dirname"), dirname);
    }
    public static void SetDirname(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, string dirname) 
    {
        b.SetDirname(b.Const(dirname));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetDisabled(b.Const(true));
    }
    public static void SetFormAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> formAttribute) 
    {
        b.SetProperty(b.Props, b.Const("formAttribute"), formAttribute);
    }
    public static void SetFormAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, string formAttribute) 
    {
        b.SetFormAttribute(b.Const(formAttribute));
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> initialValue) 
    {
        b.SetProperty(b.Props, b.Const("initialValue"), initialValue);
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, string initialValue) 
    {
        b.SetInitialValue(b.Const(initialValue));
    }
    public static void SetList(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> list) 
    {
        b.SetProperty(b.Props, b.Const("list"), list);
    }
    public static void SetList(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, string list) 
    {
        b.SetList(b.Const(list));
    }
    public static void SetMaxlength(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<int> maxlength) 
    {
        b.SetProperty(b.Props, b.Const("maxlength"), maxlength);
    }
    public static void SetMinlength(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<int> minlength) 
    {
        b.SetProperty(b.Props, b.Const("minlength"), minlength);
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<bool> multiple) 
    {
        b.SetProperty(b.Props, b.Const("multiple"), multiple);
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, bool multiple) 
    {
        b.SetMultiple(b.Const(multiple));
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetMultiple(b.Const(true));
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> name) 
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, string name) 
    {
        b.SetName(b.Const(name));
    }
    public static void SetPattern(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> pattern) 
    {
        b.SetProperty(b.Props, b.Const("pattern"), pattern);
    }
    public static void SetPattern(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, string pattern) 
    {
        b.SetPattern(b.Const(pattern));
    }
    public static void SetPlaceholder(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> placeholder) 
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }
    public static void SetPlaceholder(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, string placeholder) 
    {
        b.SetPlaceholder(b.Const(placeholder));
    }
    public static void SetReadOnly(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<bool> readOnly) 
    {
        b.SetProperty(b.Props, b.Const("readOnly"), readOnly);
    }
    public static void SetReadOnly(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, bool readOnly) 
    {
        b.SetReadOnly(b.Const(readOnly));
    }
    public static void SetReadOnly(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetReadOnly(b.Const(true));
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<bool> required) 
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, bool required) 
    {
        b.SetRequired(b.Const(required));
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetRequired(b.Const(true));
    }
    public static void SetSize(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<int> size) 
    {
        b.SetProperty(b.Props, b.Const("size"), size);
    }
    public static void SetSpellcheck(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<bool> spellcheck) 
    {
        b.SetProperty(b.Props, b.Const("spellcheck"), spellcheck);
    }
    public static void SetSpellcheck(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, bool spellcheck) 
    {
        b.SetSpellcheck(b.Const(spellcheck));
    }
    public static void SetSpellcheck(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetSpellcheck(b.Const(true));
    }
    public static void SetTypeEmail(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("email"));
    }
    public static void SetTypePassword(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("password"));
    }
    public static void SetTypeTel(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("tel"));
    }
    public static void SetTypeText(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("text"));
    }
    public static void SetTypeUrl(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("url"));
    }
    public static void SetValidity(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<ValidityState> validity) 
    {
        b.SetProperty(b.Props, b.Const("validity"), validity);
    }
    public static void SetValidationMessage(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> validationMessage) 
    {
        b.SetProperty(b.Props, b.Const("validationMessage"), validationMessage);
    }
    public static void SetValidationMessage(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, string validationMessage) 
    {
        b.SetValidationMessage(b.Const(validationMessage));
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> value) 
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, string value) 
    {
        b.SetValue(b.Const(value));
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<bool> willValidate) 
    {
        b.SetProperty(b.Props, b.Const("willValidate"), willValidate);
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, bool willValidate) 
    {
        b.SetWillValidate(b.Const(willValidate));
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.SetWillValidate(b.Const(true));
    }
    public static void SetForm(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<HTMLFormElement> form) 
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }
    public static void SetClickHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<System.Func<MouseEvent, bool>> clickHandler) 
    {
        b.SetProperty(b.Props, b.Const("clickHandler"), clickHandler);
    }
    public static void SetClickHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<System.Action<MouseEvent>> clickHandler) 
    {
        b.SetProperty(b.Props, b.Const("clickHandler"), clickHandler);
    }
    public static void SetFocusinHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<System.Func<FocusEvent, bool>> focusinHandler) 
    {
        b.SetProperty(b.Props, b.Const("focusinHandler"), focusinHandler);
    }
    public static void SetFocusinHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<System.Action<FocusEvent>> focusinHandler) 
    {
        b.SetProperty(b.Props, b.Const("focusinHandler"), focusinHandler);
    }
    public static Metapsi.Syntax.ObjBuilder<bool> CheckValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        return b.Call<bool>("checkValidity");
    }
    public static void Select(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        b.Call("select");
    }
    public static void SetCustomValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTextInput> b, Metapsi.Syntax.Var<string> message) 
    {
        b.Call("setCustomValidity", message);
    }
    public static Metapsi.Syntax.ObjBuilder<bool> ReportValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTextInput> b) 
    {
        return b.Call<bool>("reportValidity");
    }
}