using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentRadioGroup
{
    public static class Slot
    {
    }
}
public static partial class FluentRadioGroupExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentRadioGroup>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-radio-group", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentRadioGroup>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentRadioGroup(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentRadioGroup(b => { }, children);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b) 
    {
        b.SetDisabled(b.Const(true));
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, Metapsi.Syntax.Var<string> initialValue) 
    {
        b.SetProperty(b.Props, b.Const("initialValue"), initialValue);
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, string initialValue) 
    {
        b.SetInitialValue(b.Const(initialValue));
    }
    public static void SetInitialValueChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, Metapsi.Syntax.Var<System.Action<string, string>> initialValueChanged) 
    {
        b.SetProperty(b.Props, b.Const("initialValueChanged"), initialValueChanged);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, Metapsi.Syntax.Var<string> name) 
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, string name) 
    {
        b.SetName(b.Const(name));
    }
    public static void SetOrientationHorizontal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b) 
    {
        b.SetProperty(b.Props, b.Const("orientation"), b.Const("horizontal"));
    }
    public static void SetOrientationVertical(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b) 
    {
        b.SetProperty(b.Props, b.Const("orientation"), b.Const("vertical"));
    }
    public static void SetRadios(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, Metapsi.Syntax.Var<System.Collections.Generic.List<FluentRadio>> radios) 
    {
        b.SetProperty(b.Props, b.Const("radios"), radios);
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, Metapsi.Syntax.Var<bool> required) 
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, bool required) 
    {
        b.SetRequired(b.Const(required));
    }
    public static void SetRequired(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b) 
    {
        b.SetRequired(b.Const(true));
    }
    public static void SetRequiredChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, Metapsi.Syntax.Var<System.Action<bool, bool>> requiredChanged) 
    {
        b.SetProperty(b.Props, b.Const("requiredChanged"), requiredChanged);
    }
    public static void SetValidity(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, Metapsi.Syntax.Var<ValidityState> validity) 
    {
        b.SetProperty(b.Props, b.Const("validity"), validity);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, Metapsi.Syntax.Var<string> value) 
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, string value) 
    {
        b.SetValue(b.Const(value));
    }
    public static void SetChangeHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, Metapsi.Syntax.Var<System.Func<Event, bool>> changeHandler) 
    {
        b.SetProperty(b.Props, b.Const("changeHandler"), changeHandler);
    }
    public static void SetChangeHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRadioGroup> b, Metapsi.Syntax.Var<System.Action<Event>> changeHandler) 
    {
        b.SetProperty(b.Props, b.Const("changeHandler"), changeHandler);
    }
    public static Metapsi.Syntax.ObjBuilder<bool> CheckValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentRadioGroup> b) 
    {
        return b.Call<bool>("checkValidity");
    }
    public static Metapsi.Syntax.ObjBuilder<bool> ReportValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentRadioGroup> b) 
    {
        return b.Call<bool>("reportValidity");
    }
}