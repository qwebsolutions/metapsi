using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentSlider
{
    public static class Slot
    {
        public const string Thumb = "thumb";
    }
}
public static partial class FluentSliderExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentSlider(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentSlider>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-slider", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentSlider(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentSlider>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentSlider(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentSlider(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentSlider(b => { }, children);
    }
    public static void SetLabels(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<System.Collections.Generic.List<Node>> labels) 
    {
        b.SetProperty(b.Props, b.Const("labels"), labels);
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<string> initialValue) 
    {
        b.SetProperty(b.Props, b.Const("initialValue"), initialValue);
    }
    public static void SetInitialValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, string initialValue) 
    {
        b.SetInitialValue(b.Const(initialValue));
    }
    public static void SetValidity(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<ValidityState> validity) 
    {
        b.SetProperty(b.Props, b.Const("validity"), validity);
    }
    public static void SetValidationMessage(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<string> validationMessage) 
    {
        b.SetProperty(b.Props, b.Const("validationMessage"), validationMessage);
    }
    public static void SetValidationMessage(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, string validationMessage) 
    {
        b.SetValidationMessage(b.Const(validationMessage));
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<bool> willValidate) 
    {
        b.SetProperty(b.Props, b.Const("willValidate"), willValidate);
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, bool willValidate) 
    {
        b.SetWillValidate(b.Const(willValidate));
    }
    public static void SetWillValidate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b) 
    {
        b.SetWillValidate(b.Const(true));
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<string> value) 
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, string value) 
    {
        b.SetValue(b.Const(value));
    }
    public static void SetDirectionChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<System.Action> directionChanged) 
    {
        b.SetProperty(b.Props, b.Const("directionChanged"), directionChanged);
    }
    public static void SetValueAsNumber(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<int> valueAsNumber) 
    {
        b.SetProperty(b.Props, b.Const("valueAsNumber"), valueAsNumber);
    }
    public static void SetValueAsNumber(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<decimal> valueAsNumber) 
    {
        b.SetProperty(b.Props, b.Const("valueAsNumber"), valueAsNumber);
    }
    public static void SetValueTextFormatter(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<System.Func<string, string>> valueTextFormatter) 
    {
        b.SetProperty(b.Props, b.Const("valueTextFormatter"), valueTextFormatter);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b) 
    {
        b.SetDisabled(b.Const(true));
    }
    public static void SetMin(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<string> min) 
    {
        b.SetProperty(b.Props, b.Const("min"), min);
    }
    public static void SetMin(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, string min) 
    {
        b.SetMin(b.Const(min));
    }
    public static void SetMax(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<string> max) 
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }
    public static void SetMax(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, string max) 
    {
        b.SetMax(b.Const(max));
    }
    public static void SetStep(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<string> step) 
    {
        b.SetProperty(b.Props, b.Const("step"), step);
    }
    public static void SetStep(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, string step) 
    {
        b.SetStep(b.Const(step));
    }
    public static void SetOrientationHorizontal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b) 
    {
        b.SetProperty(b.Props, b.Const("orientation"), b.Const("horizontal"));
    }
    public static void SetOrientationVertical(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b) 
    {
        b.SetProperty(b.Props, b.Const("orientation"), b.Const("vertical"));
    }
    public static void SetModeSingleValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b) 
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("single-value"));
    }
    public static void SetHandleThumbPointerDown(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<System.Func<PointerEvent, bool>> handleThumbPointerDown) 
    {
        b.SetProperty(b.Props, b.Const("handleThumbPointerDown"), handleThumbPointerDown);
    }
    public static void SetHandlePointerDown(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<System.Func<PointerEvent, bool>> handlePointerDown) 
    {
        b.SetProperty(b.Props, b.Const("handlePointerDown"), handlePointerDown);
    }
    public static void HandleChange(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<object> _, Metapsi.Syntax.Var<string> propertyName) 
    {
        b.Call("handleChange", _, propertyName);
    }
    public static Metapsi.Syntax.ObjBuilder<bool> CheckValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentSlider> b) 
    {
        return b.Call<bool>("checkValidity");
    }
    public static Metapsi.Syntax.ObjBuilder<bool> ReportValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentSlider> b) 
    {
        return b.Call<bool>("reportValidity");
    }
    public static void SetCustomValidity(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<string> message) 
    {
        b.Call("setCustomValidity", message);
    }
    public static void Increment(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentSlider> b) 
    {
        b.Call("increment");
    }
    public static void Decrement(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentSlider> b) 
    {
        b.Call("decrement");
    }
    public static Metapsi.Syntax.ObjBuilder<bool> HandleKeydown(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<KeyboardEvent> @event) 
    {
        return b.Call<bool>("handleKeydown", @event);
    }
    public static void OnFluentChangeAction<TModel>(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSlider> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) 
    {
        b.OnEventAction("change", action);
    }
}