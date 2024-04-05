using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlRating : SlComponent
{
    public SlRating() : base("sl-rating") { }
    /// <summary>
    /// A label that describes the rating to assistive devices.
    /// </summary>
    public string label
    {
        get
        {
            return this.GetTag().GetAttribute<string>("label");
        }
        set
        {
            this.GetTag().SetAttribute("label", value.ToString());
        }
    }

    /// <summary>
    /// The current rating.
    /// </summary>
    public int value
    {
        get
        {
            return this.GetTag().GetAttribute<int>("value");
        }
        set
        {
            this.GetTag().SetAttribute("value", value.ToString());
        }
    }

    /// <summary>
    /// The highest rating to show.
    /// </summary>
    public int max
    {
        get
        {
            return this.GetTag().GetAttribute<int>("max");
        }
        set
        {
            this.GetTag().SetAttribute("max", value.ToString());
        }
    }

    /// <summary>
    /// The precision at which the rating will increase and decrease. For example, to allow half-star ratings, set this attribute to `0.5`.
    /// </summary>
    public int precision
    {
        get
        {
            return this.GetTag().GetAttribute<int>("precision");
        }
        set
        {
            this.GetTag().SetAttribute("precision", value.ToString());
        }
    }

    /// <summary>
    /// Makes the rating readonly.
    /// </summary>
    public bool @readonly
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("readonly");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("readonly", value.ToString());
        }
    }

    /// <summary>
    /// Disables the rating.
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
    /// A function that customizes the symbol to be rendered. The first and only argument is the rating's current value. The function should return a string containing trusted HTML of the symbol to render at the specified value. Works well with `<sl-icon>` elements.
    /// </summary>
    public System.Func<int,string> getSymbol
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<int,string>>("getSymbol");
        }
        set
        {
            this.GetTag().SetAttribute("getSymbol", value.ToString());
        }
    }

    public static class Method
    {
        /// <summary> 
        /// Sets focus on the rating.
        /// </summary>
        public const string Focus = "focus";
        /// <summary> 
        /// Removes focus from the rating.
        /// </summary>
        public const string Blur = "blur";
    }
}

public static partial class SlRatingControl
{
    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Var<IVNode> SlRating(this LayoutBuilder b, Action<PropsBuilder<SlRating>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-rating", buildProps, children);
    }
    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Var<IVNode> SlRating(this LayoutBuilder b, Action<PropsBuilder<SlRating>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-rating", buildProps, children);
    }
    /// <summary>
    /// A label that describes the rating to assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlRating> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// A label that describes the rating to assistive devices.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlRating> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// The current rating.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRating> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// The current rating.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRating> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }

    /// <summary>
    /// The highest rating to show.
    /// </summary>
    public static void SetMax(this PropsBuilder<SlRating> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), value);
    }
    /// <summary>
    /// The highest rating to show.
    /// </summary>
    public static void SetMax(this PropsBuilder<SlRating> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max"), b.Const(value));
    }

    /// <summary>
    /// The precision at which the rating will increase and decrease. For example, to allow half-star ratings, set this attribute to `0.5`.
    /// </summary>
    public static void SetPrecision(this PropsBuilder<SlRating> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("precision"), value);
    }
    /// <summary>
    /// The precision at which the rating will increase and decrease. For example, to allow half-star ratings, set this attribute to `0.5`.
    /// </summary>
    public static void SetPrecision(this PropsBuilder<SlRating> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("precision"), b.Const(value));
    }

    /// <summary>
    /// Makes the rating readonly.
    /// </summary>
    public static void SetReadonly(this PropsBuilder<SlRating> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("readonly"), b.Const(string.Empty));
    }

    /// <summary>
    /// Disables the rating.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlRating> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("disabled"), b.Const(string.Empty));
    }

    /// <summary>
    /// A function that customizes the symbol to be rendered. The first and only argument is the rating's current value. The function should return a string containing trusted HTML of the symbol to render at the specified value. Works well with `<sl-icon>` elements.
    /// </summary>
    public static void SetGetSymbol(this PropsBuilder<SlRating> b, Var<Func<int,string>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,string>>("getSymbol"), f);
    }
    /// <summary>
    /// A function that customizes the symbol to be rendered. The first and only argument is the rating's current value. The function should return a string containing trusted HTML of the symbol to render at the specified value. Works well with `<sl-icon>` elements.
    /// </summary>
    public static void SetGetSymbol(this PropsBuilder<SlRating> b, Func<SyntaxBuilder,Var<int>,Var<string>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<int,string>>("getSymbol"), b.Def(f));
    }

    /// <summary>
    /// Emitted when the rating's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRating> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when the rating's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRating> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the rating's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRating> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when the rating's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRating> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// </summary>
    public static void OnSlHover<TModel>(this PropsBuilder<SlRating> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-hover", action);
    }
    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// </summary>
    public static void OnSlHover<TModel>(this PropsBuilder<SlRating> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hover", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// </summary>
    public static void OnSlHover<TModel>(this PropsBuilder<SlRating> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-hover", action);
    }
    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// </summary>
    public static void OnSlHover<TModel>(this PropsBuilder<SlRating> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hover", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// </summary>
    public static void OnSlHover<TModel>(this PropsBuilder<SlRating> b, Var<HyperType.Action<TModel, SlHoverEventArgs>> action)
    {
        b.OnEventAction("onsl-hover", action, "detail");
    }
    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// </summary>
    public static void OnSlHover<TModel>(this PropsBuilder<SlRating> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlHoverEventArgs>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hover", b.MakeAction(action), "detail");
    }

}

