using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentField
{
    public static class Slot
    {
    }
}
public static partial class FluentFieldExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentField(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentField>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-field", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentField(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentField>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentField(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentField(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentField(b => { }, children);
    }
    public static void SetLabelPositionAbove(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentField> b) 
    {
        b.SetProperty(b.Props, b.Const("labelPosition"), b.Const("above"));
    }
    public static void SetLabelPositionAfter(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentField> b) 
    {
        b.SetProperty(b.Props, b.Const("labelPosition"), b.Const("after"));
    }
    public static void SetLabelPositionBefore(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentField> b) 
    {
        b.SetProperty(b.Props, b.Const("labelPosition"), b.Const("before"));
    }
    public static void SetInput(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentField> b, Metapsi.Syntax.Var<HTMLElement> input) 
    {
        b.SetProperty(b.Props, b.Const("input"), input);
    }
    public static void SetInputChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentField> b, Metapsi.Syntax.Var<System.Action<HTMLElement, HTMLElement>> inputChanged) 
    {
        b.SetProperty(b.Props, b.Const("inputChanged"), inputChanged);
    }
    public static void SetValidationStates(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentField> b) 
    {
        b.Call("setValidationStates");
    }
}