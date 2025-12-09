using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;

namespace Metapsi.Ionic;

public class ComponentProps
{

}

public static partial class IonNavControl
{
    public static void SetInitProps(this PropsBuilder<ComponentProps> b, IVariable initProps)
    {
        b.SetProperty(b.Props, "props", initProps);
    }

    public static void SetProperty(this PropsBuilder<ComponentProps> b, Var<string> property, IVariable value)
    {
        b.SetProperty(b.Props, property, value);
    }

    public static void SetProperty(this PropsBuilder<ComponentProps> b, string property, IVariable value)
    {
        b.SetProperty(b.Const(property), value);
    }

    public static Var<HyperType.Effect> IonNavSetRootEffect(
        this SyntaxBuilder b,
        Var<string> component,
        Action<PropsBuilder<ComponentProps>> setProps = null)
    {
        return b.MakeEffect(
            b =>
            {
                b.RequestAnimationFrame(b =>
                {
                    var ionNav = b.QuerySelector("ion-nav");
                    b.If(
                        b.HasObject(ionNav),
                        b =>
                        {
                            if (setProps != null)
                            {
                                var componentProps = b.SetProps(b.NewObj(), setProps);
                                b.CallOnObject(ionNav, Metapsi.Ionic.IonNav.Method.SetRoot, component, componentProps);
                            }
                            else
                            {
                                b.CallOnObject(ionNav, Metapsi.Ionic.IonNav.Method.SetRoot, component);
                            }
                        },
                        b =>
                        {
                            b.Log("ion-nav not found, cannot set root component");
                        });
                });
            });
    }


    public static Var<HyperType.Effect> IonNavPushEffect(
        this SyntaxBuilder b,
        Var<string> component,
        Action<PropsBuilder<ComponentProps>> setProps = null)
    {
        return b.MakeEffect(
            b =>
            {
                b.RequestAnimationFrame(b =>
                {
                    var ionNav = b.QuerySelector("ion-nav");
                    b.If(
                        b.HasObject(ionNav),
                        b =>
                        {
                            if (setProps != null)
                            {
                                var componentProps = b.SetProps(b.NewObj(), setProps);
                                b.CallOnObject(ionNav, Metapsi.Ionic.IonNav.Method.Push, component, componentProps);
                            }
                            else
                            {
                                b.CallOnObject(ionNav, Metapsi.Ionic.IonNav.Method.Push, component);
                            }
                        },
                        b =>
                        {
                            b.Log("ion-nav not found, cannot push component");
                        });
                });
            });
    }
}