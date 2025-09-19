using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Ionic;

public static partial class IonListControl
{
    /// <summary>
    /// Construct a ion-list that takes both header and a list of items as children
    /// </summary>
    /// <param name="b"></param>
    /// <param name="buildProps"></param>
    /// <param name="listHeader"></param>
    /// <param name="children"></param>
    /// <returns></returns>
    public static Var<IVNode> IonList(
        this LayoutBuilder b,
        System.Action<Metapsi.Syntax.PropsBuilder<IonList>> buildProps,
        Var<IVNode> listHeader,
        Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        var childNodes = b.NewCollection<IVNode>();
        b.Push(childNodes, listHeader);
        b.PushRange(childNodes, children);
        return b.IonList(buildProps, childNodes);
    }

    /// <summary>
    /// Construct a ion-list that takes both header and a list of items as children
    /// </summary>
    public static Var<IVNode> IonList(
        this LayoutBuilder b,
        Var<IVNode> listHeader,
        Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        var childNodes = b.NewCollection<IVNode>();
        b.Push(childNodes, listHeader);
        b.PushRange(childNodes, children);
        return b.IonList(b => { }, childNodes);
    }
}
