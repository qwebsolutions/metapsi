using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentCompoundButton
{
    public static class Slot
    {
        public const string Start = "start";
        public const string End = "end";
    }
}
public static partial class FluentCompoundButtonExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentCompoundButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentCompoundButton>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-compound-button", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentCompoundButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentCompoundButton>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentCompoundButton(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentCompoundButton(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentCompoundButton(b => { }, children);
    }
    public static void SetAppearancePrimary(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("primary"));
    }
    public static void SetAppearanceOutline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("outline"));
    }
    public static void SetAppearanceSubtle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("subtle"));
    }
    public static void SetAppearanceTransparent(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("transparent"));
    }
    public static void SetShapeCircular(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("circular"));
    }
    public static void SetShapeRounded(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("rounded"));
    }
    public static void SetShapeSquare(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("square"));
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetSizeLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }
    public static void SetIconOnly(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<bool> iconOnly) 
    {
        b.SetProperty(b.Props, b.Const("iconOnly"), iconOnly);
    }
    public static void SetIconOnly(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, bool iconOnly) 
    {
        b.SetIconOnly(b.Const(iconOnly));
    }
    public static void SetIconOnly(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetIconOnly(b.Const(true));
    }
    public static void SetAutofocus(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<bool> autofocus) 
    {
        b.SetProperty(b.Props, b.Const("autofocus"), autofocus);
    }
    public static void SetAutofocus(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, bool autofocus) 
    {
        b.SetAutofocus(b.Const(autofocus));
    }
    public static void SetAutofocus(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetAutofocus(b.Const(true));
    }
    public static void SetDefaultSlottedContent(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<System.Collections.Generic.List<HTMLElement>> defaultSlottedContent) 
    {
        b.SetProperty(b.Props, b.Const("defaultSlottedContent"), defaultSlottedContent);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetDisabled(b.Const(true));
    }
    public static void SetDisabledFocusable(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<bool> disabledFocusable) 
    {
        b.SetProperty(b.Props, b.Const("disabledFocusable"), disabledFocusable);
    }
    public static void SetDisabledFocusable(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, bool disabledFocusable) 
    {
        b.SetDisabledFocusable(b.Const(disabledFocusable));
    }
    public static void SetDisabledFocusable(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetDisabledFocusable(b.Const(true));
    }
    public static void SetForm(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<HTMLFormElement> form) 
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }
    public static void SetFormAction(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<string> formAction) 
    {
        b.SetProperty(b.Props, b.Const("formAction"), formAction);
    }
    public static void SetFormAction(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, string formAction) 
    {
        b.SetFormAction(b.Const(formAction));
    }
    public static void SetFormAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<string> formAttribute) 
    {
        b.SetProperty(b.Props, b.Const("formAttribute"), formAttribute);
    }
    public static void SetFormAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, string formAttribute) 
    {
        b.SetFormAttribute(b.Const(formAttribute));
    }
    public static void SetFormEnctype(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<string> formEnctype) 
    {
        b.SetProperty(b.Props, b.Const("formEnctype"), formEnctype);
    }
    public static void SetFormEnctype(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, string formEnctype) 
    {
        b.SetFormEnctype(b.Const(formEnctype));
    }
    public static void SetFormMethod(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<string> formMethod) 
    {
        b.SetProperty(b.Props, b.Const("formMethod"), formMethod);
    }
    public static void SetFormMethod(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, string formMethod) 
    {
        b.SetFormMethod(b.Const(formMethod));
    }
    public static void SetFormNoValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<bool> formNoValidate) 
    {
        b.SetProperty(b.Props, b.Const("formNoValidate"), formNoValidate);
    }
    public static void SetFormNoValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, bool formNoValidate) 
    {
        b.SetFormNoValidate(b.Const(formNoValidate));
    }
    public static void SetFormNoValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetFormNoValidate(b.Const(true));
    }
    public static void SetFormTarget_blank(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_blank"));
    }
    public static void SetFormTarget_self(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_self"));
    }
    public static void SetFormTarget_parent(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_parent"));
    }
    public static void SetFormTarget_top(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_top"));
    }
    public static void SetLabels(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<System.Collections.Generic.List<Node>> labels) 
    {
        b.SetProperty(b.Props, b.Const("labels"), labels);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<string> name) 
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, string name) 
    {
        b.SetName(b.Const(name));
    }
    public static void SetTypeSubmit(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("submit"));
    }
    public static void SetTypeReset(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("reset"));
    }
    public static void SetTypeButton(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("button"));
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<string> value) 
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, string value) 
    {
        b.SetValue(b.Const(value));
    }
    public static void SetKeypressHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<System.Func<KeyboardEvent, bool>> keypressHandler) 
    {
        b.SetProperty(b.Props, b.Const("keypressHandler"), keypressHandler);
    }
    public static void SetKeypressHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCompoundButton> b, Metapsi.Syntax.Var<System.Action<KeyboardEvent>> keypressHandler) 
    {
        b.SetProperty(b.Props, b.Const("keypressHandler"), keypressHandler);
    }
    public static void Press(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.Call("press");
    }
    public static void ResetForm(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentCompoundButton> b) 
    {
        b.Call("resetForm");
    }
}