using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonFabList : IonComponent
{
    public IonFabList() : base("ion-fab-list") { }
}

public static partial class IonFabListControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonFabList(this HtmlBuilder b, Action<AttributesBuilder<IonFabList>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-fab-list", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonFabList(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-fab-list", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the fab list will show all fab buttons in the list.
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFabList> b)
    {
        b.SetAttribute("activated", "");
    }
    /// <summary>
    /// If `true`, the fab list will show all fab buttons in the list.
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFabList> b, bool value)
    {
        if (value) b.SetAttribute("activated", "");
    }

    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSide(this AttributesBuilder<IonFabList> b, string value)
    {
        b.SetAttribute("side", value);
    }
    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideBottom(this AttributesBuilder<IonFabList> b)
    {
        b.SetAttribute("side", "bottom");
    }
    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideEnd(this AttributesBuilder<IonFabList> b)
    {
        b.SetAttribute("side", "end");
    }
    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideStart(this AttributesBuilder<IonFabList> b)
    {
        b.SetAttribute("side", "start");
    }
    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideTop(this AttributesBuilder<IonFabList> b)
    {
        b.SetAttribute("side", "top");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFabList(this LayoutBuilder b, Action<PropsBuilder<IonFabList>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-fab-list", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFabList(this LayoutBuilder b, Action<PropsBuilder<IonFabList>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-fab-list", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFabList(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-fab-list", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFabList(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-fab-list", children);
    }
    /// <summary>
    /// If `true`, the fab list will show all fab buttons in the list.
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b) where T: IonFabList
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("activated"), b.Const(true));
    }

    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideBottom<T>(this PropsBuilder<T> b) where T: IonFabList
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("bottom"));
    }
    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideEnd<T>(this PropsBuilder<T> b) where T: IonFabList
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("end"));
    }
    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideStart<T>(this PropsBuilder<T> b) where T: IonFabList
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("start"));
    }
    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideTop<T>(this PropsBuilder<T> b) where T: IonFabList
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("top"));
    }

}

