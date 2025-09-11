using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentTextArea
{
    public static class Slot
    {
        public const string Label = "label";
    }
}
public static partial class FluentTextAreaExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTextArea(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTextArea>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-text-area", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTextArea(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTextArea>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTextArea(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTextArea(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTextArea(b => { }, children);
    }
    public static void SetAppearanceOutline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("outline"));
    }
    public static void SetAppearanceFilledDarker(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("filled-darker"));
    }
    public static void SetAppearanceFilledLighter(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("filled-lighter"));
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<bool> block) 
    {
        b.SetProperty(b.Props, b.Const("block"), block);
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, bool block) 
    {
        b.SetBlock(b.Const(block));
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetBlock(b.Const(true));
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetSizeLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }
    public static void SetAutocompleteOn(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("on"));
    }
    public static void SetAutocompleteOff(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("autocomplete"), b.Const("off"));
    }
    public static void SetAutoResize(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<bool> autoResize) 
    {
        b.SetProperty(b.Props, b.Const("autoResize"), autoResize);
    }
    public static void SetAutoResize(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, bool autoResize) 
    {
        b.SetAutoResize(b.Const(autoResize));
    }
    public static void SetAutoResize(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetAutoResize(b.Const(true));
    }
    public static void SetDirName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<string> dirName) 
    {
        b.SetProperty(b.Props, b.Const("dirName"), dirName);
    }
    public static void SetDirName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, string dirName) 
    {
        b.SetDirName(b.Const(dirName));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetDisabled(b.Const(true));
    }
    public static void SetDisplayShadow(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<bool> displayShadow) 
    {
        b.SetProperty(b.Props, b.Const("displayShadow"), displayShadow);
    }
    public static void SetDisplayShadow(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, bool displayShadow) 
    {
        b.SetDisplayShadow(b.Const(displayShadow));
    }
    public static void SetDisplayShadow(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetDisplayShadow(b.Const(true));
    }
    public static void SetInitialForm(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<string> initialForm) 
    {
        b.SetProperty(b.Props, b.Const("initialForm"), initialForm);
    }
    public static void SetInitialForm(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, string initialForm) 
    {
        b.SetInitialForm(b.Const(initialForm));
    }
    public static void SetForm(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<HTMLFormElement> form) 
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }
    public static void SetLabels(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<NodeList> labels) 
    {
        b.SetProperty(b.Props, b.Const("labels"), labels);
    }
    public static void SetMaxLength(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<int> maxLength) 
    {
        b.SetProperty(b.Props, b.Const("maxLength"), maxLength);
    }
    public static void SetMinLength(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<int> minLength) 
    {
        b.SetProperty(b.Props, b.Const("minLength"), minLength);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<string> name) 
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, string name) 
    {
        b.SetName(b.Const(name));
    }
    public static void SetPlaceholder(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<string> placeholder) 
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }
    public static void SetPlaceholder(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, string placeholder) 
    {
        b.SetPlaceholder(b.Const(placeholder));
    }
    public static void SetReadOnly(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<bool> readOnly) 
    {
        b.SetProperty(b.Props, b.Const("readOnly"), readOnly);
    }
    public static void SetReadOnly(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, bool readOnly) 
    {
        b.SetReadOnly(b.Const(readOnly));
    }
    public static void SetReadOnly(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetReadOnly(b.Const(true));
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<bool> required) 
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, bool required) 
    {
        b.SetRequired(b.Const(required));
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetRequired(b.Const(true));
    }
    public static void SetResizeHorizontal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("resize"), b.Const("horizontal"));
    }
    public static void SetResizeVertical(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("resize"), b.Const("vertical"));
    }
    public static void SetResizeNone(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("resize"), b.Const("none"));
    }
    public static void SetResizeBoth(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("resize"), b.Const("both"));
    }
    public static void SetSpellcheck(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<bool> spellcheck) 
    {
        b.SetProperty(b.Props, b.Const("spellcheck"), spellcheck);
    }
    public static void SetSpellcheck(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, bool spellcheck) 
    {
        b.SetSpellcheck(b.Const(spellcheck));
    }
    public static void SetSpellcheck(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetSpellcheck(b.Const(true));
    }
    public static void SetTextLength(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<int> textLength) 
    {
        b.SetProperty(b.Props, b.Const("textLength"), textLength);
    }
    public static void SetTypeTextarea(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("textarea"));
    }
    public static void SetValidity(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<ValidityState> validity) 
    {
        b.SetProperty(b.Props, b.Const("validity"), validity);
    }
    public static void SetValidationMessage(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<string> validationMessage) 
    {
        b.SetProperty(b.Props, b.Const("validationMessage"), validationMessage);
    }
    public static void SetValidationMessage(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, string validationMessage) 
    {
        b.SetValidationMessage(b.Const(validationMessage));
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<bool> willValidate) 
    {
        b.SetProperty(b.Props, b.Const("willValidate"), willValidate);
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, bool willValidate) 
    {
        b.SetWillValidate(b.Const(willValidate));
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.SetWillValidate(b.Const(true));
    }
    public static void SetDefaultValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<string> defaultValue) 
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), defaultValue);
    }
    public static void SetDefaultValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, string defaultValue) 
    {
        b.SetDefaultValue(b.Const(defaultValue));
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<string> value) 
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, string value) 
    {
        b.SetValue(b.Const(value));
    }
    public static Metapsi.Syntax.ObjBuilder<bool> CheckValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        return b.Call<bool>("checkValidity");
    }
    public static Metapsi.Syntax.ObjBuilder<bool> ReportValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        return b.Call<bool>("reportValidity");
    }
    public static void SetCustomValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<string> message) 
    {
        b.Call("setCustomValidity", message);
    }
    public static void Select(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTextArea> b) 
    {
        b.Call("select");
    }
    public static void OnFluentChangeAction<TModel>(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) 
    {
        b.OnEventAction("change", action);
    }
    public static void OnFluentSelectAction<TModel>(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTextArea> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) 
    {
        b.OnEventAction("select", action);
    }
}