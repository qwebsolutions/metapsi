using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonCol
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of IonCol
/// </summary>
public static partial class IonColControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCol(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonCol>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-col", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCol(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-col", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCol(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonCol>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-col", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCol(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-col", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffset(this Metapsi.Html.AttributesBuilder<IonCol> b, string offset) 
    {
        b.SetAttribute("offset", offset);
    }

    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetLg(this Metapsi.Html.AttributesBuilder<IonCol> b, string offsetLg) 
    {
        b.SetAttribute("offsetLg", offsetLg);
    }

    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetMd(this Metapsi.Html.AttributesBuilder<IonCol> b, string offsetMd) 
    {
        b.SetAttribute("offsetMd", offsetMd);
    }

    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetSm(this Metapsi.Html.AttributesBuilder<IonCol> b, string offsetSm) 
    {
        b.SetAttribute("offsetSm", offsetSm);
    }

    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXl(this Metapsi.Html.AttributesBuilder<IonCol> b, string offsetXl) 
    {
        b.SetAttribute("offsetXl", offsetXl);
    }

    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXs(this Metapsi.Html.AttributesBuilder<IonCol> b, string offsetXs) 
    {
        b.SetAttribute("offsetXs", offsetXs);
    }

    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPull(this Metapsi.Html.AttributesBuilder<IonCol> b, string pull) 
    {
        b.SetAttribute("pull", pull);
    }

    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullLg(this Metapsi.Html.AttributesBuilder<IonCol> b, string pullLg) 
    {
        b.SetAttribute("pullLg", pullLg);
    }

    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullMd(this Metapsi.Html.AttributesBuilder<IonCol> b, string pullMd) 
    {
        b.SetAttribute("pullMd", pullMd);
    }

    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullSm(this Metapsi.Html.AttributesBuilder<IonCol> b, string pullSm) 
    {
        b.SetAttribute("pullSm", pullSm);
    }

    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXl(this Metapsi.Html.AttributesBuilder<IonCol> b, string pullXl) 
    {
        b.SetAttribute("pullXl", pullXl);
    }

    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXs(this Metapsi.Html.AttributesBuilder<IonCol> b, string pullXs) 
    {
        b.SetAttribute("pullXs", pullXs);
    }

    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPush(this Metapsi.Html.AttributesBuilder<IonCol> b, string push) 
    {
        b.SetAttribute("push", push);
    }

    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushLg(this Metapsi.Html.AttributesBuilder<IonCol> b, string pushLg) 
    {
        b.SetAttribute("pushLg", pushLg);
    }

    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushMd(this Metapsi.Html.AttributesBuilder<IonCol> b, string pushMd) 
    {
        b.SetAttribute("pushMd", pushMd);
    }

    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushSm(this Metapsi.Html.AttributesBuilder<IonCol> b, string pushSm) 
    {
        b.SetAttribute("pushSm", pushSm);
    }

    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXl(this Metapsi.Html.AttributesBuilder<IonCol> b, string pushXl) 
    {
        b.SetAttribute("pushXl", pushXl);
    }

    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXs(this Metapsi.Html.AttributesBuilder<IonCol> b, string pushXs) 
    {
        b.SetAttribute("pushXs", pushXs);
    }

    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSize(this Metapsi.Html.AttributesBuilder<IonCol> b, string size) 
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeLg(this Metapsi.Html.AttributesBuilder<IonCol> b, string sizeLg) 
    {
        b.SetAttribute("sizeLg", sizeLg);
    }

    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeMd(this Metapsi.Html.AttributesBuilder<IonCol> b, string sizeMd) 
    {
        b.SetAttribute("sizeMd", sizeMd);
    }

    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeSm(this Metapsi.Html.AttributesBuilder<IonCol> b, string sizeSm) 
    {
        b.SetAttribute("sizeSm", sizeSm);
    }

    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXl(this Metapsi.Html.AttributesBuilder<IonCol> b, string sizeXl) 
    {
        b.SetAttribute("sizeXl", sizeXl);
    }

    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXs(this Metapsi.Html.AttributesBuilder<IonCol> b, string sizeXs) 
    {
        b.SetAttribute("sizeXs", sizeXs);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCol(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonCol>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-col", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCol(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-col", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCol(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonCol>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-col", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCol(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-col", children);
    }

    /// <summary>
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffset<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offset) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("offset"), offset);
    }

    /// <summary>
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffset<T>(this Metapsi.Syntax.PropsBuilder<T> b, string offset) where T: IonCol
    {
        b.SetOffset(b.Const(offset));
    }

    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offsetLg) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("offsetLg"), offsetLg);
    }

    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, string offsetLg) where T: IonCol
    {
        b.SetOffsetLg(b.Const(offsetLg));
    }

    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offsetMd) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("offsetMd"), offsetMd);
    }

    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, string offsetMd) where T: IonCol
    {
        b.SetOffsetMd(b.Const(offsetMd));
    }

    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offsetSm) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("offsetSm"), offsetSm);
    }

    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string offsetSm) where T: IonCol
    {
        b.SetOffsetSm(b.Const(offsetSm));
    }

    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offsetXl) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("offsetXl"), offsetXl);
    }

    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, string offsetXl) where T: IonCol
    {
        b.SetOffsetXl(b.Const(offsetXl));
    }

    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offsetXs) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("offsetXs"), offsetXs);
    }

    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, string offsetXs) where T: IonCol
    {
        b.SetOffsetXs(b.Const(offsetXs));
    }

    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPull<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pull) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("pull"), pull);
    }

    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPull<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pull) where T: IonCol
    {
        b.SetPull(b.Const(pull));
    }

    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullLg) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("pullLg"), pullLg);
    }

    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pullLg) where T: IonCol
    {
        b.SetPullLg(b.Const(pullLg));
    }

    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullMd) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("pullMd"), pullMd);
    }

    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pullMd) where T: IonCol
    {
        b.SetPullMd(b.Const(pullMd));
    }

    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullSm) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("pullSm"), pullSm);
    }

    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pullSm) where T: IonCol
    {
        b.SetPullSm(b.Const(pullSm));
    }

    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullXl) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("pullXl"), pullXl);
    }

    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pullXl) where T: IonCol
    {
        b.SetPullXl(b.Const(pullXl));
    }

    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullXs) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("pullXs"), pullXs);
    }

    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pullXs) where T: IonCol
    {
        b.SetPullXs(b.Const(pullXs));
    }

    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPush<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> push) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("push"), push);
    }

    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPush<T>(this Metapsi.Syntax.PropsBuilder<T> b, string push) where T: IonCol
    {
        b.SetPush(b.Const(push));
    }

    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pushLg) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("pushLg"), pushLg);
    }

    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pushLg) where T: IonCol
    {
        b.SetPushLg(b.Const(pushLg));
    }

    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pushMd) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("pushMd"), pushMd);
    }

    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pushMd) where T: IonCol
    {
        b.SetPushMd(b.Const(pushMd));
    }

    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pushSm) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("pushSm"), pushSm);
    }

    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pushSm) where T: IonCol
    {
        b.SetPushSm(b.Const(pushSm));
    }

    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pushXl) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("pushXl"), pushXl);
    }

    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pushXl) where T: IonCol
    {
        b.SetPushXl(b.Const(pushXl));
    }

    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pushXs) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("pushXs"), pushXs);
    }

    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, string pushXs) where T: IonCol
    {
        b.SetPushXs(b.Const(pushXs));
    }

    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSize<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> size) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("size"), size);
    }

    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSize<T>(this Metapsi.Syntax.PropsBuilder<T> b, string size) where T: IonCol
    {
        b.SetSize(b.Const(size));
    }

    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> sizeLg) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("sizeLg"), sizeLg);
    }

    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, string sizeLg) where T: IonCol
    {
        b.SetSizeLg(b.Const(sizeLg));
    }

    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> sizeMd) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("sizeMd"), sizeMd);
    }

    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, string sizeMd) where T: IonCol
    {
        b.SetSizeMd(b.Const(sizeMd));
    }

    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> sizeSm) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("sizeSm"), sizeSm);
    }

    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string sizeSm) where T: IonCol
    {
        b.SetSizeSm(b.Const(sizeSm));
    }

    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> sizeXl) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("sizeXl"), sizeXl);
    }

    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, string sizeXl) where T: IonCol
    {
        b.SetSizeXl(b.Const(sizeXl));
    }

    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> sizeXs) where T: IonCol
    {
        b.SetProperty(b.Props, b.Const("sizeXs"), sizeXs);
    }

    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, string sizeXs) where T: IonCol
    {
        b.SetSizeXs(b.Const(sizeXs));
    }

}