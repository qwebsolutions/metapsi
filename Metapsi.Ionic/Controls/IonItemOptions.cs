using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonItemOptions
{
}

public static partial class IonItemOptionsControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemOptions(this LayoutBuilder b, Action<PropsBuilder<IonItemOptions>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-options", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemOptions(this LayoutBuilder b, Action<PropsBuilder<IonItemOptions>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-options", buildProps, children);
    }
    /// <summary>
    /// The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each.
    /// </summary>
    public static void SetSideEnd(this PropsBuilder<IonItemOptions> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("end"));
    }
    /// <summary>
    /// The side the option button should be on. Possible values: `"start"` and `"end"`. If you have multiple `ion-item-options`, a side must be provided for each.
    /// </summary>
    public static void SetSideStart(this PropsBuilder<IonItemOptions> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("start"));
    }

    /// <summary>
    /// Emitted when the item has been fully swiped.
    /// </summary>
    public static void OnIonSwipe<TModel>(this PropsBuilder<IonItemOptions> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionSwipe"), eventAction);
    }
    /// <summary>
    /// Emitted when the item has been fully swiped.
    /// </summary>
    public static void OnIonSwipe<TModel>(this PropsBuilder<IonItemOptions> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionSwipe"), eventAction);
    }

}

