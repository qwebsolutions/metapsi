using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlTab
{
    public static class Method
    {
        /// <summary> 
        /// Sets focus to the tab.
        /// </summary>
        public const string Focus = "focus";
        /// <summary> 
        /// Removes focus from the tab.
        /// </summary>
        public const string Blur = "blur";
    }
}

public static partial class SlTabControl
{
    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Var<IVNode> SlTab(this LayoutBuilder b, Action<PropsBuilder<SlTab>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tab", buildProps, children);
    }
    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Var<IVNode> SlTab(this LayoutBuilder b, Action<PropsBuilder<SlTab>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tab", buildProps, children);
    }
    /// <summary>
    /// The name of the tab panel this tab is associated with. The panel must be located in the same tab group.
    /// </summary>
    public static void SetPanel(this PropsBuilder<SlTab> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("panel"), value);
    }
    /// <summary>
    /// The name of the tab panel this tab is associated with. The panel must be located in the same tab group.
    /// </summary>
    public static void SetPanel(this PropsBuilder<SlTab> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("panel"), b.Const(value));
    }

    /// <summary>
    /// Draws the tab in an active state.
    /// </summary>
    public static void SetActive(this PropsBuilder<SlTab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("active"), b.Const(true));
    }

    /// <summary>
    /// Makes the tab closable and shows a close button.
    /// </summary>
    public static void SetClosable(this PropsBuilder<SlTab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("closable"), b.Const(true));
    }

    /// <summary>
    /// Disables the tab and prevents selection.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlTab> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the tab is closable and the close button is activated.
    /// </summary>
    public static void OnSlClose<TModel>(this PropsBuilder<SlTab> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-close"), eventAction);
    }
    /// <summary>
    /// Emitted when the tab is closable and the close button is activated.
    /// </summary>
    public static void OnSlClose<TModel>(this PropsBuilder<SlTab> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-close"), eventAction);
    }

}

