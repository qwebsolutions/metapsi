using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonAvatar : IonComponent
{
    public IonAvatar() : base("ion-avatar") { }
}

public static partial class IonAvatarControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonAvatar(this LayoutBuilder b, Action<PropsBuilder<IonAvatar>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-avatar", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonAvatar(this LayoutBuilder b, Action<PropsBuilder<IonAvatar>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-avatar", buildProps, children);
    }
}

