using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonFab : IonComponent
{
    public IonFab() : base("ion-fab") { }
    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public bool activated
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("activated");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("activated", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public bool edge
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("edge");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("edge", value.ToString());
        }
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public string horizontal
    {
        get
        {
            return this.GetTag().GetAttribute<string>("horizontal");
        }
        set
        {
            this.GetTag().SetAttribute("horizontal", value.ToString());
        }
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public string vertical
    {
        get
        {
            return this.GetTag().GetAttribute<string>("vertical");
        }
        set
        {
            this.GetTag().SetAttribute("vertical", value.ToString());
        }
    }

    public static class Method
    {
        /// <summary> 
        /// Close an active FAB list container.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string Close = "close";
    }
}

public static partial class IonFabControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFab(this LayoutBuilder b, Action<PropsBuilder<IonFab>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-fab", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFab(this LayoutBuilder b, Action<PropsBuilder<IonFab>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-fab", buildProps, children);
    }
    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated(this PropsBuilder<IonFab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("activated"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge(this PropsBuilder<IonFab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("edge"), b.Const(true));
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalCenter(this PropsBuilder<IonFab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("horizontal"), b.Const("center"));
    }
    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalEnd(this PropsBuilder<IonFab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("horizontal"), b.Const("end"));
    }
    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalStart(this PropsBuilder<IonFab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("horizontal"), b.Const("start"));
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalBottom(this PropsBuilder<IonFab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("vertical"), b.Const("bottom"));
    }
    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalCenter(this PropsBuilder<IonFab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("vertical"), b.Const("center"));
    }
    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalTop(this PropsBuilder<IonFab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("vertical"), b.Const("top"));
    }

}

