using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonHeader
{
}

public static partial class IonHeaderControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonHeader(this LayoutBuilder b, Action<PropsBuilder<IonHeader>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-header", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonHeader(this LayoutBuilder b, Action<PropsBuilder<IonHeader>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-header", buildProps, children);
    }
    /// <summary>
    /// Describes the scroll effect that will be applied to the header. Only applies in iOS mode.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapseCondense(this PropsBuilder<IonHeader> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("collapse"), b.Const("condense"));
    }
    /// <summary>
    /// Describes the scroll effect that will be applied to the header. Only applies in iOS mode.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapseFade(this PropsBuilder<IonHeader> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("collapse"), b.Const("fade"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonHeader> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonHeader> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the header will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the header, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent(this PropsBuilder<IonHeader> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

}

