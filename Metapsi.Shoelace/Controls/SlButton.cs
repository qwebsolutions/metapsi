using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlButton
{
    public static class Slot
    {
        /// <summary> 
        /// A presentational prefix icon or similar element.
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary> 
        /// A presentational suffix icon or similar element.
        /// </summary>
        public const string Suffix = "suffix";
    }
    public static class Method
    {
        /// <summary> 
        /// Simulates a click on the button.
        /// </summary>
        public const string Click = "click";
        /// <summary> 
        /// Sets focus on the button.
        /// </summary>
        public const string Focus = "focus";
        /// <summary> 
        /// Removes focus from the button.
        /// </summary>
        public const string Blur = "blur";
        /// <summary> 
        /// Checks for validity but does not show a validation message. Returns `true` when valid and `false` when invalid.
        /// </summary>
        public const string CheckValidity = "checkValidity";
        /// <summary> 
        /// Gets the associated form, if one exists.
        /// </summary>
        public const string GetForm = "getForm";
        /// <summary> 
        /// Checks for validity and shows the browser's validation message if the control is invalid.
        /// </summary>
        public const string ReportValidity = "reportValidity";
        /// <summary> 
        /// Sets a custom validation message. Pass an empty string to restore validity.
        /// </summary>
        public const string SetCustomValidity = "setCustomValidity";
    }
}

public static partial class SlButtonControl
{
    /// <summary>
    /// Buttons represent actions that are available to the user.
    /// </summary>
    public static Var<IVNode> SlButton(this LayoutBuilder b, Action<PropsBuilder<SlButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-button", buildProps, children);
    }
    /// <summary>
    /// Buttons represent actions that are available to the user.
    /// </summary>
    public static Var<IVNode> SlButton(this LayoutBuilder b, Action<PropsBuilder<SlButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-button", buildProps, children);
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantDefault(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("default"));
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantPrimary(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("primary"));
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantSuccess(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("success"));
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantNeutral(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("neutral"));
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantWarning(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("warning"));
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantDanger(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("danger"));
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantText(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("text"));
    }

    /// <summary>
    /// The button's size.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// The button's size.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// The button's size.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }

    /// <summary>
    /// Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior.
    /// </summary>
    public static void SetCaret(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("caret"), b.Const(true));
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Draws the button in a loading state.
    /// </summary>
    public static void SetLoading(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("loading"), b.Const(true));
    }

    /// <summary>
    /// Draws an outlined button.
    /// </summary>
    public static void SetOutline(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("outline"), b.Const(true));
    }

    /// <summary>
    /// Draws a pill-style button with rounded edges.
    /// </summary>
    public static void SetPill(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("pill"), b.Const(true));
    }

    /// <summary>
    /// Draws a circular icon button. When this attribute is present, the button expects a single `<sl-icon>` in the default slot.
    /// </summary>
    public static void SetCircle(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("circle"), b.Const(true));
    }

    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `<button>` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static void SetTypeButton(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("button"));
    }
    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `<button>` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static void SetTypeSubmit(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("submit"));
    }
    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `<button>` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static void SetTypeReset(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reset"));
    }

    /// <summary>
    /// The name of the button, submitted as a name/value pair with form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static void SetName(this PropsBuilder<SlButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the button, submitted as a name/value pair with form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static void SetName(this PropsBuilder<SlButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// The value of the button, submitted as a pair with the button's name as part of the form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The value of the button, submitted as a pair with the button's name as part of the form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// When set, the underlying button will be rendered as an `<a>` with this `href` instead of a `<button>`.
    /// </summary>
    public static void SetHref(this PropsBuilder<SlButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// When set, the underlying button will be rendered as an `<a>` with this `href` instead of a `<button>`.
    /// </summary>
    public static void SetHref(this PropsBuilder<SlButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_blank(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_blank"));
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_parent(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_parent"));
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_self(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_self"));
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_top(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_top"));
    }

    /// <summary>
    /// When using `href`, this attribute will map to the underlying link's `rel` attribute. Unlike regular links, the default is `noreferrer noopener` to prevent security exploits. However, if you're using `target` to point to a specific tab/window, this will prevent that from working correctly. You can remove or change the default value by setting the attribute to an empty string or a value of your choice, respectively.
    /// </summary>
    public static void SetRel(this PropsBuilder<SlButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// When using `href`, this attribute will map to the underlying link's `rel` attribute. Unlike regular links, the default is `noreferrer noopener` to prevent security exploits. However, if you're using `target` to point to a specific tab/window, this will prevent that from working correctly. You can remove or change the default value by setting the attribute to an empty string or a value of your choice, respectively.
    /// </summary>
    public static void SetRel(this PropsBuilder<SlButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

    /// <summary>
    /// Tells the browser to download the linked file as this filename. Only used when `href` is present.
    /// </summary>
    public static void SetDownload(this PropsBuilder<SlButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// Tells the browser to download the linked file as this filename. Only used when `href` is present.
    /// </summary>
    public static void SetDownload(this PropsBuilder<SlButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// The "form owner" to associate the button with. If omitted, the closest containing form will be used instead. The value of this attribute must be an id of a form in the same document or shadow root as the button.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// The "form owner" to associate the button with. If omitted, the closest containing form will be used instead. The value of this attribute must be an id of a form in the same document or shadow root as the button.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }

    /// <summary>
    /// Used to override the form owner's `action` attribute.
    /// </summary>
    public static void SetFormAction(this PropsBuilder<SlButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("formAction"), value);
    }
    /// <summary>
    /// Used to override the form owner's `action` attribute.
    /// </summary>
    public static void SetFormAction(this PropsBuilder<SlButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("formAction"), b.Const(value));
    }

    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static void SetFormEnctypeApplicationXWwwFormUrlencoded(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formEnctype"), b.Const("application/x-www-form-urlencoded"));
    }
    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static void SetFormEnctypeMultipartFormData(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formEnctype"), b.Const("multipart/form-data"));
    }
    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static void SetFormEnctypeTextPlain(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formEnctype"), b.Const("text/plain"));
    }

    /// <summary>
    /// Used to override the form owner's `method` attribute.
    /// </summary>
    public static void SetFormMethodPost(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formMethod"), b.Const("post"));
    }
    /// <summary>
    /// Used to override the form owner's `method` attribute.
    /// </summary>
    public static void SetFormMethodGet(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formMethod"), b.Const("get"));
    }

    /// <summary>
    /// Used to override the form owner's `novalidate` attribute.
    /// </summary>
    public static void SetFormNoValidate(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("formNoValidate"), b.Const(true));
    }

    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormTarget_self(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formTarget"), b.Const("_self"));
    }
    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormTarget_blank(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formTarget"), b.Const("_blank"));
    }
    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormTarget_parent(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formTarget"), b.Const("_parent"));
    }
    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormTarget_top(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formTarget"), b.Const("_top"));
    }
    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormTarget(this PropsBuilder<SlButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("formTarget"), value);
    }
    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormTarget(this PropsBuilder<SlButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("formTarget"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlButton> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-blur"), eventAction);
    }
    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-blur"), eventAction);
    }

    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlButton> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-focus"), eventAction);
    }
    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-focus"), eventAction);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlButton> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-invalid"), eventAction);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-invalid"), eventAction);
    }

}

