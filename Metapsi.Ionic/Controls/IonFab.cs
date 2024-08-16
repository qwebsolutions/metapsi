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
    public static class Method
    {
        /// <summary>
        /// <para> Close an active FAB list container. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
        /// </summary>
        public const string Close = "close";
    }
}

public static partial class IonFabControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonFab(this HtmlBuilder b, Action<AttributesBuilder<IonFab>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-fab", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonFab(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-fab", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible. </para>
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("activated", "");
    }

    /// <summary>
    /// <para> If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible. </para>
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFab> b,bool activated)
    {
        if (activated) b.SetAttribute("activated", "");
    }

    /// <summary>
    /// <para> If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot. </para>
    /// </summary>
    public static void SetEdge(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("edge", "");
    }

    /// <summary>
    /// <para> If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot. </para>
    /// </summary>
    public static void SetEdge(this AttributesBuilder<IonFab> b,bool edge)
    {
        if (edge) b.SetAttribute("edge", "");
    }

    /// <summary>
    /// <para> Where to align the fab horizontally in the viewport. </para>
    /// </summary>
    public static void SetHorizontal(this AttributesBuilder<IonFab> b,string horizontal)
    {
        b.SetAttribute("horizontal", horizontal);
    }

    /// <summary>
    /// <para> Where to align the fab horizontally in the viewport. </para>
    /// </summary>
    public static void SetHorizontalCenter(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("horizontal", "center");
    }

    /// <summary>
    /// <para> Where to align the fab horizontally in the viewport. </para>
    /// </summary>
    public static void SetHorizontalEnd(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("horizontal", "end");
    }

    /// <summary>
    /// <para> Where to align the fab horizontally in the viewport. </para>
    /// </summary>
    public static void SetHorizontalStart(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("horizontal", "start");
    }

    /// <summary>
    /// <para> Where to align the fab vertically in the viewport. </para>
    /// </summary>
    public static void SetVertical(this AttributesBuilder<IonFab> b,string vertical)
    {
        b.SetAttribute("vertical", vertical);
    }

    /// <summary>
    /// <para> Where to align the fab vertically in the viewport. </para>
    /// </summary>
    public static void SetVerticalBottom(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("vertical", "bottom");
    }

    /// <summary>
    /// <para> Where to align the fab vertically in the viewport. </para>
    /// </summary>
    public static void SetVerticalCenter(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("vertical", "center");
    }

    /// <summary>
    /// <para> Where to align the fab vertically in the viewport. </para>
    /// </summary>
    public static void SetVerticalTop(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("vertical", "top");
    }

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
    ///
    /// </summary>
    public static Var<IVNode> IonFab(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-fab", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonFab(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-fab", children);
    }
    /// <summary>
    /// <para> If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible. </para>
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("activated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible. </para>
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b, Var<bool> activated) where T: IonFab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("activated"), activated);
    }

    /// <summary>
    /// <para> If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible. </para>
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b, bool activated) where T: IonFab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("activated"), b.Const(activated));
    }


    /// <summary>
    /// <para> If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot. </para>
    /// </summary>
    public static void SetEdge<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("edge"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot. </para>
    /// </summary>
    public static void SetEdge<T>(this PropsBuilder<T> b, Var<bool> edge) where T: IonFab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("edge"), edge);
    }

    /// <summary>
    /// <para> If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot. </para>
    /// </summary>
    public static void SetEdge<T>(this PropsBuilder<T> b, bool edge) where T: IonFab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("edge"), b.Const(edge));
    }


    /// <summary>
    /// <para> Where to align the fab horizontally in the viewport. </para>
    /// </summary>
    public static void SetHorizontalCenter<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("horizontal"), b.Const("center"));
    }


    /// <summary>
    /// <para> Where to align the fab vertically in the viewport. </para>
    /// </summary>
    public static void SetVerticalBottom<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("vertical"), b.Const("bottom"));
    }


}

