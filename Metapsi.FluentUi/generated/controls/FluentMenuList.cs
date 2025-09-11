using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentMenuList
{
    public static class Slot
    {
    }
}
public static partial class FluentMenuListExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMenuList(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentMenuList>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-menu-list", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMenuList(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentMenuList>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentMenuList(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMenuList(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentMenuList(b => { }, children);
    }
    public static void Focus(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentMenuList> b) 
    {
        b.Call("focus");
    }
    public static void HandleChange(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentMenuList> b, Metapsi.Syntax.Var<object> source, Metapsi.Syntax.Var<string> propertyName) 
    {
        b.Call("handleChange", source, propertyName);
    }
}