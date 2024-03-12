using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonRippleEffect
{
    public static class Method
    {
        /// <summary> 
        /// Adds the ripple effect to the parent element.
        /// <para>(x: number, y: number) =&gt; Promise&lt;() =&gt; void&gt;</para>
        /// <para>x The horizontal coordinate of where the ripple should start.</para>
        /// <para>y The vertical coordinate of where the ripple should start.</para>
        /// </summary>
        public const string AddRipple = "addRipple";
    }
}

public static partial class IonRippleEffectControl
{
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
    /// Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible.
    /// </summary>
    public static void SetTypeBounded(this PropsBuilder<IonRippleEffect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("bounded"));
    }
    /// <summary>
    /// Sets the type of ripple-effect:  - `bounded`: the ripple effect expands from the user's click position - `unbounded`: the ripple effect expands from the center of the button and overflows the container.  NOTE: Surfaces for bounded ripples should have the overflow property set to hidden, while surfaces for unbounded ripples should have it set to visible.
    /// </summary>
    public static void SetTypeUnbounded(this PropsBuilder<IonRippleEffect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("unbounded"));
    }

}

