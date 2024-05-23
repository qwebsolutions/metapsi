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
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("activated", "");
    }
    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFab> b, bool value)
    {
        if (value) b.SetAttribute("activated", "");
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("edge", "");
    }
    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge(this AttributesBuilder<IonFab> b, bool value)
    {
        if (value) b.SetAttribute("edge", "");
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontal(this AttributesBuilder<IonFab> b, string value)
    {
        b.SetAttribute("horizontal", value);
    }
    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalCenter(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("horizontal", "center");
    }
    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalEnd(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("horizontal", "end");
    }
    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalStart(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("horizontal", "start");
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVertical(this AttributesBuilder<IonFab> b, string value)
    {
        b.SetAttribute("vertical", value);
    }
    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalBottom(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("vertical", "bottom");
    }
    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalCenter(this AttributesBuilder<IonFab> b)
    {
        b.SetAttribute("vertical", "center");
    }
    /// <summary>
    /// Where to align the fab vertically in the viewport.
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
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("activated"), b.Const(true));
    }
    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("activated"), value);
    }
    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b, bool value) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("activated"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("edge"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("edge"), value);
    }
    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge<T>(this PropsBuilder<T> b, bool value) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("edge"), b.Const(value));
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalCenter<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.String("horizontal"), b.Const("center"));
    }
    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalEnd<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.String("horizontal"), b.Const("end"));
    }
    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalStart<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.String("horizontal"), b.Const("start"));
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalBottom<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.String("vertical"), b.Const("bottom"));
    }
    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalCenter<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.String("vertical"), b.Const("center"));
    }
    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalTop<T>(this PropsBuilder<T> b) where T: IonFab
    {
        b.SetDynamic(b.Props, DynamicProperty.String("vertical"), b.Const("top"));
    }

}

