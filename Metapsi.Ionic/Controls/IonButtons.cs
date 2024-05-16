using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonButtons : IonComponent
{
    public IonButtons() : base("ion-buttons") { }
}

public static partial class IonButtonsControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonButtons(this HtmlBuilder b, Action<AttributesBuilder<IonButtons>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-buttons", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonButtons(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-buttons", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If true, buttons will disappear when its parent toolbar has fully collapsed if the toolbar is not the first toolbar. If the toolbar is the first toolbar, the buttons will be hidden and will only be shown once all toolbars have fully collapsed.  Only applies in `ios` mode with `collapse` set to `true` on `ion-header`.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapse(this AttributesBuilder<IonButtons> b)
    {
        b.SetAttribute("collapse", "");
    }
    /// <summary>
    /// If true, buttons will disappear when its parent toolbar has fully collapsed if the toolbar is not the first toolbar. If the toolbar is the first toolbar, the buttons will be hidden and will only be shown once all toolbars have fully collapsed.  Only applies in `ios` mode with `collapse` set to `true` on `ion-header`.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapse(this AttributesBuilder<IonButtons> b, bool value)
    {
        if (value) b.SetAttribute("collapse", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonButtons(this LayoutBuilder b, Action<PropsBuilder<IonButtons>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-buttons", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonButtons(this LayoutBuilder b, Action<PropsBuilder<IonButtons>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-buttons", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonButtons(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-buttons", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonButtons(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-buttons", children);
    }
    /// <summary>
    /// If true, buttons will disappear when its parent toolbar has fully collapsed if the toolbar is not the first toolbar. If the toolbar is the first toolbar, the buttons will be hidden and will only be shown once all toolbars have fully collapsed.  Only applies in `ios` mode with `collapse` set to `true` on `ion-header`.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapse<T>(this PropsBuilder<T> b) where T: IonButtons
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("collapse"), b.Const(true));
    }

}

