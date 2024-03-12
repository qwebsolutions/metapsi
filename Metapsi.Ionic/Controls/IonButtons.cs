using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonButtons
{
}

public static partial class IonButtonsControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonButtons(this LayoutBuilder b, Action<PropsBuilder<IonButtons>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-buttons", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonButtons(this LayoutBuilder b, Action<PropsBuilder<IonButtons>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-buttons", buildProps, children);
    }
    /// <summary>
    /// If true, buttons will disappear when its parent toolbar has fully collapsed if the toolbar is not the first toolbar. If the toolbar is the first toolbar, the buttons will be hidden and will only be shown once all toolbars have fully collapsed.  Only applies in `ios` mode with `collapse` set to `true` on `ion-header`.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapse(this PropsBuilder<IonButtons> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("collapse"), b.Const(true));
    }

}

