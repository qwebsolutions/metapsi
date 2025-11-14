using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentAccordion
{
    public static class Slot
    {
    }
}
public static partial class FluentAccordionExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentAccordion(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentAccordion>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-accordion", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentAccordion(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentAccordion>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentAccordion(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentAccordion(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentAccordion(b => { }, children);
    }
    public static void SetExpandmodeSingle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordion> b) 
    {
        b.SetProperty(b.Props, b.Const("expandmode"), b.Const("single"));
    }
    public static void SetExpandmodeMulti(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordion> b) 
    {
        b.SetProperty(b.Props, b.Const("expandmode"), b.Const("multi"));
    }
    public static void SetExpandmodeChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordion> b, Metapsi.Syntax.Var<System.Action<string, string>> expandmodeChanged) 
    {
        b.SetProperty(b.Props, b.Const("expandmodeChanged"), expandmodeChanged);
    }
    public static void OnFluentChangeAction<TModel>(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordion> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) 
    {
        b.OnEventAction("change", action);
    }
}