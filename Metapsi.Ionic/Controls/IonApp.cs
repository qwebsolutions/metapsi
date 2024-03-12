using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonApp
{
}

public static partial class IonAppControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, Action<PropsBuilder<IonApp>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-app", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, Action<PropsBuilder<IonApp>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-app", buildProps, children);
    }
}

