using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentProgressBar
{
    public static class Slot
    {
    }
}
public static partial class FluentProgressBarExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentProgressBar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentProgressBar>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-progress-bar", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentProgressBar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentProgressBar>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentProgressBar(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentProgressBar(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentProgressBar(b => { }, children);
    }
    public static void SetThicknessMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentProgressBar> b) 
    {
        b.SetProperty(b.Props, b.Const("thickness"), b.Const("medium"));
    }
    public static void SetThicknessLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentProgressBar> b) 
    {
        b.SetProperty(b.Props, b.Const("thickness"), b.Const("large"));
    }
    public static void SetShapeRounded(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentProgressBar> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("rounded"));
    }
    public static void SetShapeSquare(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentProgressBar> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("square"));
    }
    public static void SetValidationStateSuccess(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentProgressBar> b) 
    {
        b.SetProperty(b.Props, b.Const("validationState"), b.Const("success"));
    }
    public static void SetValidationStateWarning(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentProgressBar> b) 
    {
        b.SetProperty(b.Props, b.Const("validationState"), b.Const("warning"));
    }
    public static void SetValidationStateError(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentProgressBar> b) 
    {
        b.SetProperty(b.Props, b.Const("validationState"), b.Const("error"));
    }
    public static void SetValidationStateChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentProgressBar> b, Metapsi.Syntax.Var<System.Action<string, string>> validationStateChanged) 
    {
        b.SetProperty(b.Props, b.Const("validationStateChanged"), validationStateChanged);
    }
}