using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonFabList
{
}

public static partial class IonFabListControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonFabList(this HtmlBuilder b, Action<AttributesBuilder<IonFabList>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-fab-list", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonFabList(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-fab-list", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonFabList(this HtmlBuilder b, Action<AttributesBuilder<IonFabList>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-fab-list", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonFabList(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-fab-list", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the fab list will show all fab buttons in the list. </para>
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFabList> b)
    {
        b.SetAttribute("activated", "");
    }

    /// <summary>
    /// <para> If `true`, the fab list will show all fab buttons in the list. </para>
    /// </summary>
    public static void SetActivated(this AttributesBuilder<IonFabList> b, bool activated)
    {
        if (activated) b.SetAttribute("activated", "");
    }

    /// <summary>
    /// <para> The side the fab list will show on relative to the main fab button. </para>
    /// </summary>
    public static void SetSide(this AttributesBuilder<IonFabList> b, string side)
    {
        b.SetAttribute("side", side);
    }

    /// <summary>
    /// <para> The side the fab list will show on relative to the main fab button. </para>
    /// </summary>
    public static void SetSideBottom(this AttributesBuilder<IonFabList> b)
    {
        b.SetAttribute("side", "bottom");
    }

    /// <summary>
    /// <para> The side the fab list will show on relative to the main fab button. </para>
    /// </summary>
    public static void SetSideEnd(this AttributesBuilder<IonFabList> b)
    {
        b.SetAttribute("side", "end");
    }

    /// <summary>
    /// <para> The side the fab list will show on relative to the main fab button. </para>
    /// </summary>
    public static void SetSideStart(this AttributesBuilder<IonFabList> b)
    {
        b.SetAttribute("side", "start");
    }

    /// <summary>
    /// <para> The side the fab list will show on relative to the main fab button. </para>
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
    /// <para> If `true`, the fab list will show all fab buttons in the list. </para>
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b) where T: IonFabList
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("activated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the fab list will show all fab buttons in the list. </para>
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b, Var<bool> activated) where T: IonFabList
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("activated"), activated);
    }

    /// <summary>
    /// <para> If `true`, the fab list will show all fab buttons in the list. </para>
    /// </summary>
    public static void SetActivated<T>(this PropsBuilder<T> b, bool activated) where T: IonFabList
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("activated"), b.Const(activated));
    }


    /// <summary>
    /// <para> The side the fab list will show on relative to the main fab button. </para>
    /// </summary>
    public static void SetSideBottom<T>(this PropsBuilder<T> b) where T: IonFabList
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("bottom"));
    }


    /// <summary>
    /// <para> The side the fab list will show on relative to the main fab button. </para>
    /// </summary>
    public static void SetSideEnd<T>(this PropsBuilder<T> b) where T: IonFabList
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("end"));
    }


    /// <summary>
    /// <para> The side the fab list will show on relative to the main fab button. </para>
    /// </summary>
    public static void SetSideStart<T>(this PropsBuilder<T> b) where T: IonFabList
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("start"));
    }


    /// <summary>
    /// <para> The side the fab list will show on relative to the main fab button. </para>
    /// </summary>
    public static void SetSideTop<T>(this PropsBuilder<T> b) where T: IonFabList
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("top"));
    }


}

