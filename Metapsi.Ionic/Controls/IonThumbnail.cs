using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonThumbnail
{
}

public static partial class IonThumbnailControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonThumbnail(this LayoutBuilder b, Action<PropsBuilder<IonThumbnail>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-thumbnail", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonThumbnail(this LayoutBuilder b, Action<PropsBuilder<IonThumbnail>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-thumbnail", buildProps, children);
    }
}

