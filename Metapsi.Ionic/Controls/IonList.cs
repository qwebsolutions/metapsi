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
    public static IHtmlNode IonList(this HtmlBuilder b, Action<AttributesBuilder<IonList>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-list", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonList(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-list", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the list will have margin around it and rounded corners.
    /// </summary>
    public static void SetInset(this AttributesBuilder<IonList> b)
    {
        b.SetAttribute("inset", "");
    }
    /// <summary>
    /// If `true`, the list will have margin around it and rounded corners.
    /// </summary>
    public static void SetInset(this AttributesBuilder<IonList> b, bool value)
    {
        if (value) b.SetAttribute("inset", "");
    }

    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLines(this AttributesBuilder<IonList> b, string value)
    {
        b.SetAttribute("lines", value);
    }
    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesFull(this AttributesBuilder<IonList> b)
    {
        b.SetAttribute("lines", "full");
    }
    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesInset(this AttributesBuilder<IonList> b)
    {
        b.SetAttribute("lines", "inset");
    }
    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesNone(this AttributesBuilder<IonList> b)
    {
        b.SetAttribute("lines", "none");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonList> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonList> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonList> b)
    {
        b.SetAttribute("mode", "md");
    }

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
    /// 
    /// </summary>
    public static Var<IVNode> IonList(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-list", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonList(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-list", children);
    }
    /// <summary>
    /// If `true`, the list will have margin around it and rounded corners.
    /// </summary>
    public static void SetInset<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("inset"), b.Const(true));
    }

    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesFull<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("full"));
    }
    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesInset<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("inset"));
    }
    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesNone<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("none"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

}

