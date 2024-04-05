using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonSegmentButton : IonComponent
{
    public IonSegmentButton() : base("ion-segment-button") { }
    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public bool disabled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("disabled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("disabled", value.ToString());
        }
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public string layout
    {
        get
        {
            return this.GetTag().GetAttribute<string>("layout");
        }
        set
        {
            this.GetTag().SetAttribute("layout", value.ToString());
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
    /// The type of the button.
    /// </summary>
    public string type
    {
        get
        {
            return this.GetTag().GetAttribute<string>("type");
        }
        set
        {
            this.GetTag().SetAttribute("type", value.ToString());
        }
    }

    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public string value
    {
        get
        {
            return this.GetTag().GetAttribute<string>("value");
        }
        set
        {
            this.GetTag().SetAttribute("value", value.ToString());
        }
    }

}

public static partial class IonSegmentButtonControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSegmentButton(this LayoutBuilder b, Action<PropsBuilder<IonSegmentButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-segment-button", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSegmentButton(this LayoutBuilder b, Action<PropsBuilder<IonSegmentButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-segment-button", buildProps, children);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconBottom(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-bottom"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconEnd(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-end"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconHide(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-hide"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconStart(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-start"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconTop(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-top"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutLabelHide(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("label-hide"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("button"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reset"));
    }
    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this PropsBuilder<IonSegmentButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("submit"));
    }

    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonSegmentButton> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonSegmentButton> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }
    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonSegmentButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue(this PropsBuilder<IonSegmentButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

}

