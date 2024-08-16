using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonRippleEffect : IonComponent
{
    public IonRippleEffect() : base("ion-ripple-effect") { }
    public static class Method
    {
        /// <summary>
        /// <para> Adds the ripple effect to the parent element. </para>
        /// <para> (x: number, y: number) =&gt; Promise&lt;() =&gt; void&gt; </para>
        /// <para> x The horizontal coordinate of where the ripple should start. </para>
        /// <para> y The vertical coordinate of where the ripple should start. </para>
        /// </summary>
        public const string AddRipple = "addRipple";
    }
}

public static partial class IonRippleEffectControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRippleEffect(this HtmlBuilder b, Action<AttributesBuilder<IonRippleEffect>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-ripple-effect", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRippleEffect(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-ripple-effect", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<IonRippleEffect> b,string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible. </para>
    /// </summary>
    public static void SetTypeBounded(this AttributesBuilder<IonRippleEffect> b)
    {
        b.SetAttribute("type", "bounded");
    }

    /// <summary>
    /// <para> Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible. </para>
    /// </summary>
    public static void SetTypeUnbounded(this AttributesBuilder<IonRippleEffect> b)
    {
        b.SetAttribute("type", "unbounded");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRippleEffect(this LayoutBuilder b, Action<PropsBuilder<IonRippleEffect>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-ripple-effect", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRippleEffect(this LayoutBuilder b, Action<PropsBuilder<IonRippleEffect>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-ripple-effect", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRippleEffect(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-ripple-effect", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRippleEffect(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-ripple-effect", children);
    }
    /// <summary>
    /// <para> Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible. </para>
    /// </summary>
    public static void SetTypeBounded<T>(this PropsBuilder<T> b) where T: IonRippleEffect
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("bounded"));
    }


}

