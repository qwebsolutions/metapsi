using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using Metapsi.Html;

namespace Metapsi.Ionic;

// For some reason this is not part of the docs file

public partial class IonIcon 
{
}

public static class IonIconControl
{
    public static IHtmlNode IonIcon(this HtmlBuilder b, Action<AttributesBuilder<IonIcon>> buildAttributes)
    {
        return b.IonicTag("ion-icon", buildAttributes);
    }

    public static IHtmlNode IonIcon(this HtmlBuilder b, string name)
    {
        return b.IonIcon(b => b.SetAttribute("name", name));
    }

    public static Var<IVNode> IonIcon(this LayoutBuilder b, Action<PropsBuilder<IonIcon>> buildProps)
    {
        return b.IonicNode<IonIcon>("ion-icon", buildProps);
    }

    public static Var<IVNode> IonIcon(this LayoutBuilder b, Var<string> name)
    {
        return b.IonicNode<IonIcon>("ion-icon", b =>
        {
            b.SetAttribute("name", name);
        });
    }

    public static Var<IVNode> IonIcon(this LayoutBuilder b, string name)
    {
        return b.IonIcon(b.Const(name));
    }

    public static void SetName(this PropsBuilder<IonIcon> b, Var<string> name)
    {
        b.SetAttribute("name", name);
    }

    public static void SetName(this PropsBuilder<IonIcon> b, string name)
    {
        b.SetName(b.Const(name));
    }

    public static void SetColor(this PropsBuilder<IonIcon> b, Var<string> color)
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    public static void SetColor(this PropsBuilder<IonIcon> b, string color)
    {
        b.SetColor(b.Const(color));
    }

    public static void SetSize(this PropsBuilder<IonIcon> b, Var<string> size)
    {
        b.SetProperty(b.Props, b.Const("size"), size);
    }

    public static void SetSizeLarge(this PropsBuilder<IonIcon> b)
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    public static void SetSizeSmall(this PropsBuilder<IonIcon> b)
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
}
