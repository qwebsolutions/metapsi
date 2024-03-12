using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonRow
{
}

public static partial class IonRowControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRow(this LayoutBuilder b, Action<PropsBuilder<IonRow>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-row", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRow(this LayoutBuilder b, Action<PropsBuilder<IonRow>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-row", buildProps, children);
    }
}

