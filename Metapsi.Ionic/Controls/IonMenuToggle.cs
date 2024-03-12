using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonMenuToggle
{
    /// <summary> 
    /// Content is placed inside the toggle to act as the click target.
    /// </summary>
    public static class Slot
    {
    }
}

public static partial class IonMenuToggleControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonMenuToggle(this LayoutBuilder b, Action<PropsBuilder<IonMenuToggle>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-menu-toggle", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonMenuToggle(this LayoutBuilder b, Action<PropsBuilder<IonMenuToggle>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-menu-toggle", buildProps, children);
    }
    /// <summary>
    /// Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu.
    /// </summary>
    public static void SetAutoHide(this PropsBuilder<IonMenuToggle> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("autoHide"), b.Const(true));
    }

    /// <summary>
    /// Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle.  If this property is not used, `ion-menu-toggle` will toggle the first menu that is active.
    /// </summary>
    public static void SetMenu(this PropsBuilder<IonMenuToggle> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menu"), value);
    }
    /// <summary>
    /// Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle.  If this property is not used, `ion-menu-toggle` will toggle the first menu that is active.
    /// </summary>
    public static void SetMenu(this PropsBuilder<IonMenuToggle> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menu"), b.Const(value));
    }

}

