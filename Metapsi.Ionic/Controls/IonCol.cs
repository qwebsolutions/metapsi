using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonCol : IonComponent
{
    public IonCol() : base("ion-col") { }
}

public static partial class IonColControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonCol(this HtmlBuilder b, Action<AttributesBuilder<IonCol>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-col", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonCol(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-col", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffset(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("offset", value);
    }

    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetLg(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("offset-lg", value);
    }

    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetMd(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("offset-md", value);
    }

    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetSm(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("offset-sm", value);
    }

    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXl(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("offset-xl", value);
    }

    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXs(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("offset-xs", value);
    }

    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPull(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("pull", value);
    }

    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullLg(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("pull-lg", value);
    }

    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullMd(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("pull-md", value);
    }

    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullSm(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("pull-sm", value);
    }

    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXl(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("pull-xl", value);
    }

    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXs(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("pull-xs", value);
    }

    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPush(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("push", value);
    }

    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushLg(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("push-lg", value);
    }

    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushMd(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("push-md", value);
    }

    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushSm(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("push-sm", value);
    }

    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXl(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("push-xl", value);
    }

    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXs(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("push-xs", value);
    }

    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSize(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("size", value);
    }

    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeLg(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("size-lg", value);
    }

    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeMd(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("size-md", value);
    }

    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeSm(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("size-sm", value);
    }

    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXl(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("size-xl", value);
    }

    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXs(this AttributesBuilder<IonCol> b, string value)
    {
        b.SetAttribute("size-xs", value);
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
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffset<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offset"), value);
    }
    /// <summary>
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffset<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offset"), b.Const(value));
    }

    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetLg<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetLg"), value);
    }
    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetLg<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetLg"), b.Const(value));
    }

    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetMd<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetMd"), value);
    }
    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetMd<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetMd"), b.Const(value));
    }

    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetSm<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetSm"), value);
    }
    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetSm<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetSm"), b.Const(value));
    }

    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXl<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXl"), value);
    }
    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXl<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXl"), b.Const(value));
    }

    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXs<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXs"), value);
    }
    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXs<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXs"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPull<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pull"), value);
    }
    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPull<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pull"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullLg<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullLg"), value);
    }
    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullLg<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullLg"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullMd<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullMd"), value);
    }
    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullMd<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullMd"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullSm<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullSm"), value);
    }
    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullSm<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullSm"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXl<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXl"), value);
    }
    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXl<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXl"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXs<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXs"), value);
    }
    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXs<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXs"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPush<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("push"), value);
    }
    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPush<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("push"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushLg<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushLg"), value);
    }
    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushLg<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushLg"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushMd<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushMd"), value);
    }
    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushMd<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushMd"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushSm<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushSm"), value);
    }
    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushSm<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushSm"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXl<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXl"), value);
    }
    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXl<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXl"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXs<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXs"), value);
    }
    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXs<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXs"), b.Const(value));
    }

    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSize<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), value);
    }
    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSize<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const(value));
    }

    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeLg<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeLg"), value);
    }
    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeLg<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeLg"), b.Const(value));
    }

    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeMd<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeMd"), value);
    }
    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeMd<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeMd"), b.Const(value));
    }

    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeSm<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeSm"), value);
    }
    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeSm<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeSm"), b.Const(value));
    }

    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXl<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXl"), value);
    }
    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXl<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXl"), b.Const(value));
    }

    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXs<T>(this PropsBuilder<T> b, Var<string> value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXs"), value);
    }
    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXs<T>(this PropsBuilder<T> b, string value) where T: IonCol
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXs"), b.Const(value));
    }

}

