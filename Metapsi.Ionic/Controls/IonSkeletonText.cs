using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonSkeletonText : IonComponent
{
    public IonSkeletonText() : base("ion-skeleton-text") { }
    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public bool animated
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("animated");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("animated", value.ToString());
        }
    }

}

public static partial class IonSkeletonTextControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSkeletonText(this LayoutBuilder b, Action<PropsBuilder<IonSkeletonText>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-skeleton-text", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSkeletonText(this LayoutBuilder b, Action<PropsBuilder<IonSkeletonText>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-skeleton-text", buildProps, children);
    }
    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonSkeletonText> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

}

