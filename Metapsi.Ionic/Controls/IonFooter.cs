using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonFooter : IonComponent
{
    public IonFooter() : base("ion-footer") { }
    /// <summary>
    /// Describes the scroll effect that will be applied to the footer. Only applies in iOS mode.
    /// </summary>
    public string collapse
    {
        get
        {
            return this.GetTag().GetAttribute<string>("collapse");
        }
        set
        {
            this.GetTag().SetAttribute("collapse", value.ToString());
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

    /// <summary>
    /// If `true`, the footer will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the footer, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public bool translucent
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("translucent");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("translucent", value.ToString());
        }
    }

}

public static partial class IonFooterControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFooter(this LayoutBuilder b, Action<PropsBuilder<IonFooter>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-footer", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonFooter(this LayoutBuilder b, Action<PropsBuilder<IonFooter>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-footer", buildProps, children);
    }
    /// <summary>
    /// Describes the scroll effect that will be applied to the footer. Only applies in iOS mode.
    /// </summary>
    public static void SetCollapseFade(this PropsBuilder<IonFooter> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("collapse"), b.Const("fade"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonFooter> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonFooter> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the footer will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the footer, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent(this PropsBuilder<IonFooter> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

}

