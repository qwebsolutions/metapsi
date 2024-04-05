using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlMutationObserver : SlComponent
{
    public SlMutationObserver() : base("sl-mutation-observer") { }
    /// <summary>
    /// Watches for changes to attributes. To watch only specific attributes, separate them by a space, e.g. `attr="class id title"`. To watch all attributes, use `*`.
    /// </summary>
    public string attr
    {
        get
        {
            return this.GetTag().GetAttribute<string>("attr");
        }
        set
        {
            this.GetTag().SetAttribute("attr", value.ToString());
        }
    }

    /// <summary>
    /// Indicates whether or not the attribute's previous value should be recorded when monitoring changes.
    /// </summary>
    public bool attrOldValue
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("attrOldValue");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("attrOldValue", value.ToString());
        }
    }

    /// <summary>
    /// Watches for changes to the character data contained within the node.
    /// </summary>
    public bool charData
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("charData");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("charData", value.ToString());
        }
    }

    /// <summary>
    /// Indicates whether or not the previous value of the node's text should be recorded.
    /// </summary>
    public bool charDataOldValue
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("charDataOldValue");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("charDataOldValue", value.ToString());
        }
    }

    /// <summary>
    /// Watches for the addition or removal of new child nodes.
    /// </summary>
    public bool childList
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("childList");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("childList", value.ToString());
        }
    }

    /// <summary>
    /// Disables the observer.
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

}

public static partial class SlMutationObserverControl
{
    /// <summary>
    /// The Mutation Observer component offers a thin, declarative interface to the [`MutationObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/MutationObserver).
    /// </summary>
    public static Var<IVNode> SlMutationObserver(this LayoutBuilder b, Action<PropsBuilder<SlMutationObserver>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-mutation-observer", buildProps, children);
    }
    /// <summary>
    /// The Mutation Observer component offers a thin, declarative interface to the [`MutationObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/MutationObserver).
    /// </summary>
    public static Var<IVNode> SlMutationObserver(this LayoutBuilder b, Action<PropsBuilder<SlMutationObserver>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-mutation-observer", buildProps, children);
    }
    /// <summary>
    /// Watches for changes to attributes. To watch only specific attributes, separate them by a space, e.g. `attr="class id title"`. To watch all attributes, use `*`.
    /// </summary>
    public static void SetAttr(this PropsBuilder<SlMutationObserver> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("attr"), value);
    }
    /// <summary>
    /// Watches for changes to attributes. To watch only specific attributes, separate them by a space, e.g. `attr="class id title"`. To watch all attributes, use `*`.
    /// </summary>
    public static void SetAttr(this PropsBuilder<SlMutationObserver> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("attr"), b.Const(value));
    }

    /// <summary>
    /// Indicates whether or not the attribute's previous value should be recorded when monitoring changes.
    /// </summary>
    public static void SetAttrOldValue(this PropsBuilder<SlMutationObserver> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("attrOldValue"), b.Const(true));
    }

    /// <summary>
    /// Watches for changes to the character data contained within the node.
    /// </summary>
    public static void SetCharData(this PropsBuilder<SlMutationObserver> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("charData"), b.Const(true));
    }

    /// <summary>
    /// Indicates whether or not the previous value of the node's text should be recorded.
    /// </summary>
    public static void SetCharDataOldValue(this PropsBuilder<SlMutationObserver> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("charDataOldValue"), b.Const(true));
    }

    /// <summary>
    /// Watches for the addition or removal of new child nodes.
    /// </summary>
    public static void SetChildList(this PropsBuilder<SlMutationObserver> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("childList"), b.Const(true));
    }

    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlMutationObserver> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Emitted when a mutation occurs.
    /// </summary>
    public static void OnSlMutation<TModel>(this PropsBuilder<SlMutationObserver> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-mutation", action);
    }
    /// <summary>
    /// Emitted when a mutation occurs.
    /// </summary>
    public static void OnSlMutation<TModel>(this PropsBuilder<SlMutationObserver> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-mutation", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a mutation occurs.
    /// </summary>
    public static void OnSlMutation<TModel>(this PropsBuilder<SlMutationObserver> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-mutation", action);
    }
    /// <summary>
    /// Emitted when a mutation occurs.
    /// </summary>
    public static void OnSlMutation<TModel>(this PropsBuilder<SlMutationObserver> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-mutation", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a mutation occurs.
    /// </summary>
    public static void OnSlMutation<TModel>(this PropsBuilder<SlMutationObserver> b, Var<HyperType.Action<TModel, SlMutationEventArgs>> action)
    {
        b.OnEventAction("onsl-mutation", action, "detail");
    }
    /// <summary>
    /// Emitted when a mutation occurs.
    /// </summary>
    public static void OnSlMutation<TModel>(this PropsBuilder<SlMutationObserver> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlMutationEventArgs>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-mutation", b.MakeAction(action), "detail");
    }

}

