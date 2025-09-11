using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentTooltip
{
    public static class Slot
    {
    }
}
public static partial class FluentTooltipExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTooltip(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTooltip>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-tooltip", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTooltip(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTooltip>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTooltip(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTooltip(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTooltip(b => { }, children);
    }
    public static void SetElementInternals(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTooltip> b, Metapsi.Syntax.Var<ElementInternals> elementInternals) 
    {
        b.SetProperty(b.Props, b.Const("elementInternals"), elementInternals);
    }
    public static void SetId(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTooltip> b, Metapsi.Syntax.Var<string> id) 
    {
        b.SetProperty(b.Props, b.Const("id"), id);
    }
    public static void SetId(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTooltip> b, string id) 
    {
        b.SetId(b.Const(id));
    }
    public static void SetDelay(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTooltip> b, Metapsi.Syntax.Var<int> delay) 
    {
        b.SetProperty(b.Props, b.Const("delay"), delay);
    }
    public static void SetAnchor(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTooltip> b, Metapsi.Syntax.Var<string> anchor) 
    {
        b.SetProperty(b.Props, b.Const("anchor"), anchor);
    }
    public static void SetAnchor(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTooltip> b, string anchor) 
    {
        b.SetAnchor(b.Const(anchor));
    }
    public static void SetMouseenterAnchorHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTooltip> b, Metapsi.Syntax.Var<System.Action> mouseenterAnchorHandler) 
    {
        b.SetProperty(b.Props, b.Const("mouseenterAnchorHandler"), mouseenterAnchorHandler);
    }
    public static void SetMouseleaveAnchorHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTooltip> b, Metapsi.Syntax.Var<System.Action> mouseleaveAnchorHandler) 
    {
        b.SetProperty(b.Props, b.Const("mouseleaveAnchorHandler"), mouseleaveAnchorHandler);
    }
    public static void SetFocusAnchorHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTooltip> b, Metapsi.Syntax.Var<System.Action> focusAnchorHandler) 
    {
        b.SetProperty(b.Props, b.Const("focusAnchorHandler"), focusAnchorHandler);
    }
    public static void SetBlurAnchorHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTooltip> b, Metapsi.Syntax.Var<System.Action> blurAnchorHandler) 
    {
        b.SetProperty(b.Props, b.Const("blurAnchorHandler"), blurAnchorHandler);
    }
}