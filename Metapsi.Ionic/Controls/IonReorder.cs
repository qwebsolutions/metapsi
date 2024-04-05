using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonReorder : IonComponent
{
    public IonReorder() : base("ion-reorder") { }
}

public static partial class IonReorderControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonReorder(this LayoutBuilder b, Action<PropsBuilder<IonReorder>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-reorder", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonReorder(this LayoutBuilder b, Action<PropsBuilder<IonReorder>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-reorder", buildProps, children);
    }
}

