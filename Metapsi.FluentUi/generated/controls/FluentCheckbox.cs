using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentCheckbox
{
    public static class Slot
    {
    }
}
public static partial class FluentCheckboxExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentCheckbox(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentCheckbox>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-checkbox", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentCheckbox(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentCheckbox>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentCheckbox(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentCheckbox(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentCheckbox(b => { }, children);
    }
    public static void SetIndeterminate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<bool> indeterminate) 
    {
        b.SetProperty(b.Props, b.Const("indeterminate"), indeterminate);
    }
    public static void SetIndeterminate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, bool indeterminate) 
    {
        b.SetIndeterminate(b.Const(indeterminate));
    }
    public static void SetIndeterminate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetIndeterminate(b.Const(true));
    }
    public static void SetShapeCircular(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("circular"));
    }
    public static void SetShapeSquare(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("square"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetSizeLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }
    public static void SetAutofocus(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<bool> autofocus) 
    {
        b.SetProperty(b.Props, b.Const("autofocus"), autofocus);
    }
    public static void SetAutofocus(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, bool autofocus) 
    {
        b.SetAutofocus(b.Const(autofocus));
    }
    public static void SetAutofocus(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetAutofocus(b.Const(true));
    }
    public static void SetChecked(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<bool> @checked) 
    {
        b.SetProperty(b.Props, b.Const("checked"), @checked);
    }
    public static void SetChecked(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, bool @checked) 
    {
        b.SetChecked(b.Const(@checked));
    }
    public static void SetChecked(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetChecked(b.Const(true));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetDisabled(b.Const(true));
    }
    public static void SetDisabledAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<bool> disabledAttribute) 
    {
        b.SetProperty(b.Props, b.Const("disabledAttribute"), disabledAttribute);
    }
    public static void SetDisabledAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, bool disabledAttribute) 
    {
        b.SetDisabledAttribute(b.Const(disabledAttribute));
    }
    public static void SetDisabledAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetDisabledAttribute(b.Const(true));
    }
    public static void SetFormAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<string> formAttribute) 
    {
        b.SetProperty(b.Props, b.Const("formAttribute"), formAttribute);
    }
    public static void SetFormAttribute(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, string formAttribute) 
    {
        b.SetFormAttribute(b.Const(formAttribute));
    }
    public static void SetInitialChecked(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<bool> initialChecked) 
    {
        b.SetProperty(b.Props, b.Const("initialChecked"), initialChecked);
    }
    public static void SetInitialChecked(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, bool initialChecked) 
    {
        b.SetInitialChecked(b.Const(initialChecked));
    }
    public static void SetInitialChecked(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetInitialChecked(b.Const(true));
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<string> initialValue) 
    {
        b.SetProperty(b.Props, b.Const("initialValue"), initialValue);
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, string initialValue) 
    {
        b.SetInitialValue(b.Const(initialValue));
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<string> name) 
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, string name) 
    {
        b.SetName(b.Const(name));
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<bool> required) 
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, bool required) 
    {
        b.SetRequired(b.Const(required));
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetRequired(b.Const(true));
    }
    public static void SetForm(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<HTMLFormElement> form) 
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }
    public static void SetLabels(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<System.Collections.Generic.List<HTMLLabelElement>> labels) 
    {
        b.SetProperty(b.Props, b.Const("labels"), labels);
    }
    public static void SetValidationMessage(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<string> validationMessage) 
    {
        b.SetProperty(b.Props, b.Const("validationMessage"), validationMessage);
    }
    public static void SetValidationMessage(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, string validationMessage) 
    {
        b.SetValidationMessage(b.Const(validationMessage));
    }
    public static void SetValidity(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<ValidityState> validity) 
    {
        b.SetProperty(b.Props, b.Const("validity"), validity);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<string> value) 
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, string value) 
    {
        b.SetValue(b.Const(value));
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<bool> willValidate) 
    {
        b.SetProperty(b.Props, b.Const("willValidate"), willValidate);
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b, bool willValidate) 
    {
        b.SetWillValidate(b.Const(willValidate));
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        b.SetWillValidate(b.Const(true));
    }
    public static void ToggleChecked(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<bool> force) 
    {
        b.Call("toggleChecked", force);
    }
    public static Metapsi.Syntax.ObjBuilder<bool> CheckValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        return b.Call<bool>("checkValidity");
    }
    public static Metapsi.Syntax.ObjBuilder<bool> ReportValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentCheckbox> b) 
    {
        return b.Call<bool>("reportValidity");
    }
    public static void SetCustomValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentCheckbox> b, Metapsi.Syntax.Var<string> message) 
    {
        b.Call("setCustomValidity", message);
    }
}