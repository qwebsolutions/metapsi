using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlMenu
{
}

public static partial class SlMenuControl
{
    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Var<IVNode> SlMenu(this LayoutBuilder b, Action<PropsBuilder<SlMenu>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-menu", buildProps, children);
    }
    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Var<IVNode> SlMenu(this LayoutBuilder b, Action<PropsBuilder<SlMenu>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-menu", buildProps, children);
    }
    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<TModel>(this PropsBuilder<SlMenu> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-select"), eventAction);
    }
    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<TModel>(this PropsBuilder<SlMenu> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-select"), eventAction);
    }

}

