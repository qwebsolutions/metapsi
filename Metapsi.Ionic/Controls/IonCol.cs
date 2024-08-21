using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonCol
{
}

public static partial class IonColControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCol(this HtmlBuilder b, Action<AttributesBuilder<IonCol>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-col", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCol(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-col", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCol(this HtmlBuilder b, Action<AttributesBuilder<IonCol>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-col", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonCol(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-col", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The amount to offset the column, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffset(this AttributesBuilder<IonCol> b, string offset)
    {
        b.SetAttribute("offset", offset);
    }

    /// <summary>
    /// <para> The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetLg(this AttributesBuilder<IonCol> b, string offsetLg)
    {
        b.SetAttribute("offset-lg", offsetLg);
    }

    /// <summary>
    /// <para> The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetMd(this AttributesBuilder<IonCol> b, string offsetMd)
    {
        b.SetAttribute("offset-md", offsetMd);
    }

    /// <summary>
    /// <para> The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetSm(this AttributesBuilder<IonCol> b, string offsetSm)
    {
        b.SetAttribute("offset-sm", offsetSm);
    }

    /// <summary>
    /// <para> The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetXl(this AttributesBuilder<IonCol> b, string offsetXl)
    {
        b.SetAttribute("offset-xl", offsetXl);
    }

    /// <summary>
    /// <para> The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetXs(this AttributesBuilder<IonCol> b, string offsetXs)
    {
        b.SetAttribute("offset-xs", offsetXs);
    }

    /// <summary>
    /// <para> The amount to pull the column, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPull(this AttributesBuilder<IonCol> b, string pull)
    {
        b.SetAttribute("pull", pull);
    }

    /// <summary>
    /// <para> The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullLg(this AttributesBuilder<IonCol> b, string pullLg)
    {
        b.SetAttribute("pull-lg", pullLg);
    }

    /// <summary>
    /// <para> The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullMd(this AttributesBuilder<IonCol> b, string pullMd)
    {
        b.SetAttribute("pull-md", pullMd);
    }

    /// <summary>
    /// <para> The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullSm(this AttributesBuilder<IonCol> b, string pullSm)
    {
        b.SetAttribute("pull-sm", pullSm);
    }

    /// <summary>
    /// <para> The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullXl(this AttributesBuilder<IonCol> b, string pullXl)
    {
        b.SetAttribute("pull-xl", pullXl);
    }

    /// <summary>
    /// <para> The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullXs(this AttributesBuilder<IonCol> b, string pullXs)
    {
        b.SetAttribute("pull-xs", pullXs);
    }

    /// <summary>
    /// <para> The amount to push the column, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPush(this AttributesBuilder<IonCol> b, string push)
    {
        b.SetAttribute("push", push);
    }

    /// <summary>
    /// <para> The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushLg(this AttributesBuilder<IonCol> b, string pushLg)
    {
        b.SetAttribute("push-lg", pushLg);
    }

    /// <summary>
    /// <para> The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushMd(this AttributesBuilder<IonCol> b, string pushMd)
    {
        b.SetAttribute("push-md", pushMd);
    }

    /// <summary>
    /// <para> The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushSm(this AttributesBuilder<IonCol> b, string pushSm)
    {
        b.SetAttribute("push-sm", pushSm);
    }

    /// <summary>
    /// <para> The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushXl(this AttributesBuilder<IonCol> b, string pushXl)
    {
        b.SetAttribute("push-xl", pushXl);
    }

    /// <summary>
    /// <para> The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushXs(this AttributesBuilder<IonCol> b, string pushXs)
    {
        b.SetAttribute("push-xs", pushXs);
    }

    /// <summary>
    /// <para> The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<IonCol> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeLg(this AttributesBuilder<IonCol> b, string sizeLg)
    {
        b.SetAttribute("size-lg", sizeLg);
    }

    /// <summary>
    /// <para> The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeMd(this AttributesBuilder<IonCol> b, string sizeMd)
    {
        b.SetAttribute("size-md", sizeMd);
    }

    /// <summary>
    /// <para> The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeSm(this AttributesBuilder<IonCol> b, string sizeSm)
    {
        b.SetAttribute("size-sm", sizeSm);
    }

    /// <summary>
    /// <para> The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeXl(this AttributesBuilder<IonCol> b, string sizeXl)
    {
        b.SetAttribute("size-xl", sizeXl);
    }

    /// <summary>
    /// <para> The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeXs(this AttributesBuilder<IonCol> b, string sizeXs)
    {
        b.SetAttribute("size-xs", sizeXs);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCol(this LayoutBuilder b, Action<PropsBuilder<IonCol>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-col", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCol(this LayoutBuilder b, Action<PropsBuilder<IonCol>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-col", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCol(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-col", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonCol(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-col", children);
    }
    /// <summary>
    /// <para> The amount to offset the column, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffset<T>(this PropsBuilder<T> b, Var<string> offset) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offset"), offset);
    }

    /// <summary>
    /// <para> The amount to offset the column, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffset<T>(this PropsBuilder<T> b, string offset) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offset"), b.Const(offset));
    }


    /// <summary>
    /// <para> The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetLg<T>(this PropsBuilder<T> b, Var<string> offsetLg) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetLg"), offsetLg);
    }

    /// <summary>
    /// <para> The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetLg<T>(this PropsBuilder<T> b, string offsetLg) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetLg"), b.Const(offsetLg));
    }


    /// <summary>
    /// <para> The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetMd<T>(this PropsBuilder<T> b, Var<string> offsetMd) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetMd"), offsetMd);
    }

    /// <summary>
    /// <para> The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetMd<T>(this PropsBuilder<T> b, string offsetMd) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetMd"), b.Const(offsetMd));
    }


    /// <summary>
    /// <para> The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetSm<T>(this PropsBuilder<T> b, Var<string> offsetSm) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetSm"), offsetSm);
    }

    /// <summary>
    /// <para> The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetSm<T>(this PropsBuilder<T> b, string offsetSm) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetSm"), b.Const(offsetSm));
    }


    /// <summary>
    /// <para> The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetXl<T>(this PropsBuilder<T> b, Var<string> offsetXl) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXl"), offsetXl);
    }

    /// <summary>
    /// <para> The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetXl<T>(this PropsBuilder<T> b, string offsetXl) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXl"), b.Const(offsetXl));
    }


    /// <summary>
    /// <para> The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetXs<T>(this PropsBuilder<T> b, Var<string> offsetXs) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXs"), offsetXs);
    }

    /// <summary>
    /// <para> The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetOffsetXs<T>(this PropsBuilder<T> b, string offsetXs) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXs"), b.Const(offsetXs));
    }


    /// <summary>
    /// <para> The amount to pull the column, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPull<T>(this PropsBuilder<T> b, Var<string> pull) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pull"), pull);
    }

    /// <summary>
    /// <para> The amount to pull the column, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPull<T>(this PropsBuilder<T> b, string pull) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pull"), b.Const(pull));
    }


    /// <summary>
    /// <para> The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullLg<T>(this PropsBuilder<T> b, Var<string> pullLg) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullLg"), pullLg);
    }

    /// <summary>
    /// <para> The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullLg<T>(this PropsBuilder<T> b, string pullLg) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullLg"), b.Const(pullLg));
    }


    /// <summary>
    /// <para> The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullMd<T>(this PropsBuilder<T> b, Var<string> pullMd) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullMd"), pullMd);
    }

    /// <summary>
    /// <para> The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullMd<T>(this PropsBuilder<T> b, string pullMd) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullMd"), b.Const(pullMd));
    }


    /// <summary>
    /// <para> The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullSm<T>(this PropsBuilder<T> b, Var<string> pullSm) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullSm"), pullSm);
    }

    /// <summary>
    /// <para> The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullSm<T>(this PropsBuilder<T> b, string pullSm) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullSm"), b.Const(pullSm));
    }


    /// <summary>
    /// <para> The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullXl<T>(this PropsBuilder<T> b, Var<string> pullXl) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXl"), pullXl);
    }

    /// <summary>
    /// <para> The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullXl<T>(this PropsBuilder<T> b, string pullXl) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXl"), b.Const(pullXl));
    }


    /// <summary>
    /// <para> The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullXs<T>(this PropsBuilder<T> b, Var<string> pullXs) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXs"), pullXs);
    }

    /// <summary>
    /// <para> The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available. </para>
    /// </summary>
    public static void SetPullXs<T>(this PropsBuilder<T> b, string pullXs) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXs"), b.Const(pullXs));
    }


    /// <summary>
    /// <para> The amount to push the column, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPush<T>(this PropsBuilder<T> b, Var<string> push) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("push"), push);
    }

    /// <summary>
    /// <para> The amount to push the column, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPush<T>(this PropsBuilder<T> b, string push) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("push"), b.Const(push));
    }


    /// <summary>
    /// <para> The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushLg<T>(this PropsBuilder<T> b, Var<string> pushLg) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushLg"), pushLg);
    }

    /// <summary>
    /// <para> The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushLg<T>(this PropsBuilder<T> b, string pushLg) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushLg"), b.Const(pushLg));
    }


    /// <summary>
    /// <para> The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushMd<T>(this PropsBuilder<T> b, Var<string> pushMd) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushMd"), pushMd);
    }

    /// <summary>
    /// <para> The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushMd<T>(this PropsBuilder<T> b, string pushMd) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushMd"), b.Const(pushMd));
    }


    /// <summary>
    /// <para> The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushSm<T>(this PropsBuilder<T> b, Var<string> pushSm) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushSm"), pushSm);
    }

    /// <summary>
    /// <para> The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushSm<T>(this PropsBuilder<T> b, string pushSm) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushSm"), b.Const(pushSm));
    }


    /// <summary>
    /// <para> The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushXl<T>(this PropsBuilder<T> b, Var<string> pushXl) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXl"), pushXl);
    }

    /// <summary>
    /// <para> The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushXl<T>(this PropsBuilder<T> b, string pushXl) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXl"), b.Const(pushXl));
    }


    /// <summary>
    /// <para> The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushXs<T>(this PropsBuilder<T> b, Var<string> pushXs) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXs"), pushXs);
    }

    /// <summary>
    /// <para> The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available. </para>
    /// </summary>
    public static void SetPushXs<T>(this PropsBuilder<T> b, string pushXs) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXs"), b.Const(pushXs));
    }


    /// <summary>
    /// <para> The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSize<T>(this PropsBuilder<T> b, Var<string> size) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), size);
    }

    /// <summary>
    /// <para> The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSize<T>(this PropsBuilder<T> b, string size) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const(size));
    }


    /// <summary>
    /// <para> The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeLg<T>(this PropsBuilder<T> b, Var<string> sizeLg) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeLg"), sizeLg);
    }

    /// <summary>
    /// <para> The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeLg<T>(this PropsBuilder<T> b, string sizeLg) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeLg"), b.Const(sizeLg));
    }


    /// <summary>
    /// <para> The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeMd<T>(this PropsBuilder<T> b, Var<string> sizeMd) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeMd"), sizeMd);
    }

    /// <summary>
    /// <para> The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeMd<T>(this PropsBuilder<T> b, string sizeMd) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeMd"), b.Const(sizeMd));
    }


    /// <summary>
    /// <para> The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeSm<T>(this PropsBuilder<T> b, Var<string> sizeSm) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeSm"), sizeSm);
    }

    /// <summary>
    /// <para> The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeSm<T>(this PropsBuilder<T> b, string sizeSm) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeSm"), b.Const(sizeSm));
    }


    /// <summary>
    /// <para> The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeXl<T>(this PropsBuilder<T> b, Var<string> sizeXl) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXl"), sizeXl);
    }

    /// <summary>
    /// <para> The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeXl<T>(this PropsBuilder<T> b, string sizeXl) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXl"), b.Const(sizeXl));
    }


    /// <summary>
    /// <para> The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeXs<T>(this PropsBuilder<T> b, Var<string> sizeXs) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXs"), sizeXs);
    }

    /// <summary>
    /// <para> The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content. </para>
    /// </summary>
    public static void SetSizeXs<T>(this PropsBuilder<T> b, string sizeXs) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXs"), b.Const(sizeXs));
    }


}

