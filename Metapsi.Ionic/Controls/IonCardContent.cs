using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonCardContent : IonComponent
{
    public IonCardContent() : base("ion-card-content") { }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("mode");
        }
        set
        {
            this.GetTag().SetAttribute("mode", value.ToString());
        }
    }

}

public static partial class IonCardContentControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonCardContent(this LayoutBuilder b, Action<PropsBuilder<IonCardContent>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-card-content", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonCardContent(this LayoutBuilder b, Action<PropsBuilder<IonCardContent>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-card-content", buildProps, children);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonCardContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonCardContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

}

