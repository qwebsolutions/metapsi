using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonCol
{
}

public static partial class IonColControl
{
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
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffset(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offset"), value);
    }
    /// <summary>
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffset(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offset"), b.Const(value));
    }

    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetLg(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetLg"), value);
    }
    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetLg(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetLg"), b.Const(value));
    }

    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetMd(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetMd"), value);
    }
    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetMd(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetMd"), b.Const(value));
    }

    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetSm(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetSm"), value);
    }
    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetSm(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetSm"), b.Const(value));
    }

    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXl(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXl"), value);
    }
    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXl(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXl"), b.Const(value));
    }

    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXs(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXs"), value);
    }
    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXs(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("offsetXs"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPull(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pull"), value);
    }
    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPull(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pull"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullLg(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullLg"), value);
    }
    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullLg(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullLg"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullMd(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullMd"), value);
    }
    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullMd(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullMd"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullSm(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullSm"), value);
    }
    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullSm(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullSm"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXl(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXl"), value);
    }
    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXl(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXl"), b.Const(value));
    }

    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXs(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXs"), value);
    }
    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXs(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pullXs"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPush(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("push"), value);
    }
    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPush(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("push"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushLg(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushLg"), value);
    }
    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushLg(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushLg"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushMd(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushMd"), value);
    }
    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushMd(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushMd"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushSm(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushSm"), value);
    }
    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushSm(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushSm"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXl(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXl"), value);
    }
    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXl(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXl"), b.Const(value));
    }

    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXs(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXs"), value);
    }
    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXs(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("pushXs"), b.Const(value));
    }

    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSize(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), value);
    }
    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSize(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const(value));
    }

    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeLg(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeLg"), value);
    }
    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeLg(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeLg"), b.Const(value));
    }

    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeMd(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeMd"), value);
    }
    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeMd(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeMd"), b.Const(value));
    }

    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeSm(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeSm"), value);
    }
    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeSm(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeSm"), b.Const(value));
    }

    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXl(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXl"), value);
    }
    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXl(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXl"), b.Const(value));
    }

    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXs(this PropsBuilder<IonCol> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXs"), value);
    }
    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXs(this PropsBuilder<IonCol> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("sizeXs"), b.Const(value));
    }

}

