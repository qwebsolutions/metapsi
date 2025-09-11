using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentDrawer
{
    public static class Slot
    {
    }
}
public static partial class FluentDrawerExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDrawer(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentDrawer>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-drawer", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDrawer(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentDrawer>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentDrawer(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDrawer(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentDrawer(b => { }, children);
    }
    public static void SetTypeModal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("modal"));
    }
    public static void SetTypeNonModal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("non-modal"));
    }
    public static void SetTypeInline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b) 
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("inline"));
    }
    public static void SetAriaLabelledby(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b, Metapsi.Syntax.Var<string> ariaLabelledby) 
    {
        b.SetProperty(b.Props, b.Const("ariaLabelledby"), ariaLabelledby);
    }
    public static void SetAriaLabelledby(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b, string ariaLabelledby) 
    {
        b.SetAriaLabelledby(b.Const(ariaLabelledby));
    }
    public static void SetAriaDescribedby(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b, Metapsi.Syntax.Var<string> ariaDescribedby) 
    {
        b.SetProperty(b.Props, b.Const("ariaDescribedby"), ariaDescribedby);
    }
    public static void SetAriaDescribedby(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b, string ariaDescribedby) 
    {
        b.SetAriaDescribedby(b.Const(ariaDescribedby));
    }
    public static void SetPositionStart(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b) 
    {
        b.SetProperty(b.Props, b.Const("position"), b.Const("start"));
    }
    public static void SetPositionEnd(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b) 
    {
        b.SetProperty(b.Props, b.Const("position"), b.Const("end"));
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetSizeLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }
    public static void SetSizeFull(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("full"));
    }
    public static void SetDialog(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b, Metapsi.Syntax.Var<HTMLDialogElement> dialog) 
    {
        b.SetProperty(b.Props, b.Const("dialog"), dialog);
    }
    public static void SetEmitToggle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b, Metapsi.Syntax.Var<System.Action> emitToggle) 
    {
        b.SetProperty(b.Props, b.Const("emitToggle"), emitToggle);
    }
    public static void SetEmitBeforeToggle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b, Metapsi.Syntax.Var<System.Action> emitBeforeToggle) 
    {
        b.SetProperty(b.Props, b.Const("emitBeforeToggle"), emitBeforeToggle);
    }
    public static void SetClickHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b, Metapsi.Syntax.Var<System.Func<Event, bool>> clickHandler) 
    {
        b.SetProperty(b.Props, b.Const("clickHandler"), clickHandler);
    }
    public static void SetCancelHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b, Metapsi.Syntax.Var<System.Action> cancelHandler) 
    {
        b.SetProperty(b.Props, b.Const("cancelHandler"), cancelHandler);
    }
    public static void Show(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentDrawer> b) 
    {
        b.Call("show");
    }
    public static void Hide(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentDrawer> b) 
    {
        b.Call("hide");
    }
    public static void OnFluentToggleAction<TModel>(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) 
    {
        b.OnEventAction("toggle", action);
    }
    public static void OnFluentBeforetoggleAction<TModel>(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDrawer> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) 
    {
        b.OnEventAction("beforetoggle", action);
    }
}