using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonList
{
    public static class Method
    {
        /// <summary>
        /// <para> If `ion-item-sliding` are used inside the list, this method closes any open sliding item.  Returns `true` if an actual `ion-item-sliding` is closed. </para>
        /// <para> () =&gt; Promise&lt;boolean&gt; </para>
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
        return b.IonicTag("ion-list", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonList(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-list", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonList(this HtmlBuilder b, Action<AttributesBuilder<IonList>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-list", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonList(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-list", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the list will have margin around it and rounded corners. </para>
    /// </summary>
    public static void SetInset(this AttributesBuilder<IonList> b)
    {
        b.SetAttribute("inset", "");
    }

    /// <summary>
    /// <para> If `true`, the list will have margin around it and rounded corners. </para>
    /// </summary>
    public static void SetInset(this AttributesBuilder<IonList> b, bool inset)
    {
        if (inset) b.SetAttribute("inset", "");
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on all items. </para>
    /// </summary>
    public static void SetLines(this AttributesBuilder<IonList> b, string lines)
    {
        b.SetAttribute("lines", lines);
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on all items. </para>
    /// </summary>
    public static void SetLinesFull(this AttributesBuilder<IonList> b)
    {
        b.SetAttribute("lines", "full");
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on all items. </para>
    /// </summary>
    public static void SetLinesInset(this AttributesBuilder<IonList> b)
    {
        b.SetAttribute("lines", "inset");
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on all items. </para>
    /// </summary>
    public static void SetLinesNone(this AttributesBuilder<IonList> b)
    {
        b.SetAttribute("lines", "none");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonList> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonList> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
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
    /// <para> If `true`, the list will have margin around it and rounded corners. </para>
    /// </summary>
    public static void SetInset<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("inset"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the list will have margin around it and rounded corners. </para>
    /// </summary>
    public static void SetInset<T>(this PropsBuilder<T> b, Var<bool> inset) where T: IonList
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("inset"), inset);
    }

    /// <summary>
    /// <para> If `true`, the list will have margin around it and rounded corners. </para>
    /// </summary>
    public static void SetInset<T>(this PropsBuilder<T> b, bool inset) where T: IonList
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("inset"), b.Const(inset));
    }


    /// <summary>
    /// <para> How the bottom border should be displayed on all items. </para>
    /// </summary>
    public static void SetLinesFull<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("lines"), b.Const("full"));
    }


    /// <summary>
    /// <para> How the bottom border should be displayed on all items. </para>
    /// </summary>
    public static void SetLinesInset<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("lines"), b.Const("inset"));
    }


    /// <summary>
    /// <para> How the bottom border should be displayed on all items. </para>
    /// </summary>
    public static void SetLinesNone<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("lines"), b.Const("none"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonList
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


}

