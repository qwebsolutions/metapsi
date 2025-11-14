using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentDialog
{
    public static class Slot
    {
    }
}
public static partial class FluentDialogExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDialog(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentDialog>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-dialog", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDialog(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentDialog>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentDialog(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDialog(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentDialog(b => { }, children);
    }
    public static void SetDialog(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDialog> b, Metapsi.Syntax.Var<HTMLDialogElement> dialog) 
    {
        b.SetProperty(b.Props, b.Const("dialog"), dialog);
    }
    public static void SetAriaDescribedby(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDialog> b, Metapsi.Syntax.Var<string> ariaDescribedby) 
    {
        b.SetProperty(b.Props, b.Const("ariaDescribedby"), ariaDescribedby);
    }
    public static void SetAriaDescribedby(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDialog> b, string ariaDescribedby) 
    {
        b.SetAriaDescribedby(b.Const(ariaDescribedby));
    }
    public static void SetAriaLabelledby(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDialog> b, Metapsi.Syntax.Var<string> ariaLabelledby) 
    {
        b.SetProperty(b.Props, b.Const("ariaLabelledby"), ariaLabelledby);
    }
    public static void SetAriaLabelledby(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDialog> b, string ariaLabelledby) 
    {
        b.SetAriaLabelledby(b.Const(ariaLabelledby));
    }
    public static void SetTypeModal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDialog> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("modal"));
    }
    public static void SetTypeAlert(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDialog> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("alert"));
    }
    public static void SetTypeNonModal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDialog> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("non-modal"));
    }
    public static void SetEmitBeforeToggle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDialog> b, Metapsi.Syntax.Var<System.Action> emitBeforeToggle) 
    {
        b.SetProperty(b.Props, b.Const("emitBeforeToggle"), emitBeforeToggle);
    }
    public static void SetEmitToggle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDialog> b, Metapsi.Syntax.Var<System.Action> emitToggle) 
    {
        b.SetProperty(b.Props, b.Const("emitToggle"), emitToggle);
    }
    public static void SetClickHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDialog> b, Metapsi.Syntax.Var<System.Func<Event, bool>> clickHandler) 
    {
        b.SetProperty(b.Props, b.Const("clickHandler"), clickHandler);
    }
    public static void Show(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentDialog> b) 
    {
        b.Call("show");
    }
    public static void Hide(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentDialog> b) 
    {
        b.Call("hide");
    }
}