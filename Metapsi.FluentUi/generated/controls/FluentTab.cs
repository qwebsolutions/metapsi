using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentTab
{
    public static class Slot
    {
    }
}
public static partial class FluentTabExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTab(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTab>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-tab", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTab(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTab>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTab(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTab(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTab(b => { }, children);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTab> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTab> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTab> b) 
    {
        b.SetDisabled(b.Const(true));
    }
}