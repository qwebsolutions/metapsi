using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonList : IonComponent
{
    public IonList() : base("ion-list") { }
    /// <summary>
    /// If `true`, the list will have margin around it and rounded corners.
    /// </summary>
    public bool inset
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("inset");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("inset", value.ToString());
        }
    }

    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public string lines
    {
        get
        {
            return this.GetTag().GetAttribute<string>("lines");
        }
        set
        {
            this.GetTag().SetAttribute("lines", value.ToString());
        }
    }

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

    public static class Method
    {
        /// <summary> 
        /// If `ion-item-sliding` are used inside the list, this method closes any open sliding item.  Returns `true` if an actual `ion-item-sliding` is closed.
        /// <para>() =&gt; Promise&lt;boolean&gt;</para>
        /// </summary>
        public const string CloseSlidingItems = "closeSlidingItems";
    }
}

public static partial class IonListControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonList(this LayoutBuilder b, Action<PropsBuilder<IonList>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-list", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonList(this LayoutBuilder b, Action<PropsBuilder<IonList>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-list", buildProps, children);
    }
    /// <summary>
    /// If `true`, the list will have margin around it and rounded corners.
    /// </summary>
    public static void SetInset(this PropsBuilder<IonList> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("inset"), b.Const(true));
    }

    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesFull(this PropsBuilder<IonList> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("full"));
    }
    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesInset(this PropsBuilder<IonList> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("inset"));
    }
    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesNone(this PropsBuilder<IonList> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("none"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonList> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonList> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

}

