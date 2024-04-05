using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonThumbnail : IonComponent
{
    public IonThumbnail() : base("ion-thumbnail") { }
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

