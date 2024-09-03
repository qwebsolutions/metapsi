using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonItemOptions
{
}

public static partial class IonItemOptionsControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemOptions(this HtmlBuilder b, Action<AttributesBuilder<IonItemOptions>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-options", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemOptions(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-options", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemOptions(this HtmlBuilder b, Action<AttributesBuilder<IonItemOptions>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-item-options", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemOptions(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-item-options", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each. </para>
    /// </summary>
    public static void SetSide(this AttributesBuilder<IonItemOptions> b, string side)
    {
        b.SetAttribute("side", side);
    }

    /// <summary>
    /// <para> The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each. </para>
    /// </summary>
    public static void SetSideEnd(this AttributesBuilder<IonItemOptions> b)
    {
        b.SetAttribute("side", "end");
    }

    /// <summary>
    /// <para> The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each. </para>
    /// </summary>
    public static void SetSideStart(this AttributesBuilder<IonItemOptions> b)
    {
        b.SetAttribute("side", "start");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemOptions(this LayoutBuilder b, Action<PropsBuilder<IonItemOptions>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-options", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemOptions(this LayoutBuilder b, Action<PropsBuilder<IonItemOptions>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-options", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemOptions(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-options", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemOptions(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-options", children);
    }
    /// <summary>
    /// <para> The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each. </para>
    /// </summary>
    public static void SetSideEnd<T>(this PropsBuilder<T> b) where T: IonItemOptions
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("end"));
    }


    /// <summary>
    /// <para> The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each. </para>
    /// </summary>
    public static void SetSideStart<T>(this PropsBuilder<T> b) where T: IonItemOptions
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("start"));
    }


    /// <summary>
    /// <para> Emitted when the item has been fully swiped. </para>
    /// </summary>
    public static void OnIonSwipe<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, object>> action) where TComponent: IonItemOptions
    {
        b.OnEventAction("onionSwipe", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the item has been fully swiped. </para>
    /// </summary>
    public static void OnIonSwipe<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action) where TComponent: IonItemOptions
    {
        b.OnEventAction("onionSwipe", b.MakeAction(action), "detail");
    }

}

