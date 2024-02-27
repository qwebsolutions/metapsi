using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlButton
{
    public string value { get; set; }
}
public partial class SlButtonBlurArgs
{
    public IClientSideSlButton target { get; set; }
}
public partial class SlButtonFocusArgs
{
    public IClientSideSlButton target { get; set; }
}
public partial class SlButtonInvalidArgs
{
    public IClientSideSlButton target { get; set; }
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
    public static void SetFormEnctypeApplicationxwwwformurlencoded(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formEnctype"), b.Const("application/x-www-form-urlencoded"));
    }
    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static void SetFormEnctypeMultipartformdata(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formEnctype"), b.Const("multipart/form-data"));
    }
    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static void SetFormEnctypeTextplain(this PropsBuilder<SlButton> b)
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
    public static void SetFormTargetString(this PropsBuilder<SlButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("formTarget"), b.Const("string"));
    }
    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlButton> b, Var<HyperType.Action<TModel, SlButtonBlurArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlButtonBlurArgs>>("onsl-blur"), action);
    }
    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlButtonBlurArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlButtonBlurArgs>>("onsl-blur"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlButton> b, Var<HyperType.Action<TModel, SlButtonFocusArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlButtonFocusArgs>>("onsl-focus"), action);
    }
    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlButtonFocusArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlButtonFocusArgs>>("onsl-focus"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlButton> b, Var<HyperType.Action<TModel, SlButtonInvalidArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlButtonInvalidArgs>>("onsl-invalid"), action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlButtonInvalidArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlButtonInvalidArgs>>("onsl-invalid"), b.MakeAction(action));
    }
}

/// <summary>
/// Buttons represent actions that are available to the user.
/// </summary>
public partial class SlButton : HtmlTag
{
    public SlButton()
    {
        this.Tag = "sl-button";
    }

    public static SlButton New()
    {
        return new SlButton();
    }
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
}

public static partial class SlButtonControl
{
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static SlButton SetVariantDefault(this SlButton tag)
    {
        return tag.SetAttribute("variant", "default");
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static SlButton SetVariantPrimary(this SlButton tag)
    {
        return tag.SetAttribute("variant", "primary");
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static SlButton SetVariantSuccess(this SlButton tag)
    {
        return tag.SetAttribute("variant", "success");
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static SlButton SetVariantNeutral(this SlButton tag)
    {
        return tag.SetAttribute("variant", "neutral");
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static SlButton SetVariantWarning(this SlButton tag)
    {
        return tag.SetAttribute("variant", "warning");
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static SlButton SetVariantDanger(this SlButton tag)
    {
        return tag.SetAttribute("variant", "danger");
    }
    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static SlButton SetVariantText(this SlButton tag)
    {
        return tag.SetAttribute("variant", "text");
    }
    /// <summary>
    /// The button's size.
    /// </summary>
    public static SlButton SetSizeSmall(this SlButton tag)
    {
        return tag.SetAttribute("size", "small");
    }
    /// <summary>
    /// The button's size.
    /// </summary>
    public static SlButton SetSizeMedium(this SlButton tag)
    {
        return tag.SetAttribute("size", "medium");
    }
    /// <summary>
    /// The button's size.
    /// </summary>
    public static SlButton SetSizeLarge(this SlButton tag)
    {
        return tag.SetAttribute("size", "large");
    }
    /// <summary>
    /// Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior.
    /// </summary>
    public static SlButton SetCaret(this SlButton tag)
    {
        return tag.SetAttribute("caret", "true");
    }
    /// <summary>
    /// Disables the button.
    /// </summary>
    public static SlButton SetDisabled(this SlButton tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// Draws the button in a loading state.
    /// </summary>
    public static SlButton SetLoading(this SlButton tag)
    {
        return tag.SetAttribute("loading", "true");
    }
    /// <summary>
    /// Draws an outlined button.
    /// </summary>
    public static SlButton SetOutline(this SlButton tag)
    {
        return tag.SetAttribute("outline", "true");
    }
    /// <summary>
    /// Draws a pill-style button with rounded edges.
    /// </summary>
    public static SlButton SetPill(this SlButton tag)
    {
        return tag.SetAttribute("pill", "true");
    }
    /// <summary>
    /// Draws a circular icon button. When this attribute is present, the button expects a single `<sl-icon>` in the default slot.
    /// </summary>
    public static SlButton SetCircle(this SlButton tag)
    {
        return tag.SetAttribute("circle", "true");
    }
    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `<button>` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static SlButton SetTypeButton(this SlButton tag)
    {
        return tag.SetAttribute("type", "button");
    }
    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `<button>` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static SlButton SetTypeSubmit(this SlButton tag)
    {
        return tag.SetAttribute("type", "submit");
    }
    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `<button>` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static SlButton SetTypeReset(this SlButton tag)
    {
        return tag.SetAttribute("type", "reset");
    }
    /// <summary>
    /// The name of the button, submitted as a name/value pair with form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static SlButton SetName(this SlButton tag, string value)
    {
        return tag.SetAttribute("name", value.ToString());
    }
    /// <summary>
    /// The value of the button, submitted as a pair with the button's name as part of the form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static SlButton SetValue(this SlButton tag, string value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// When set, the underlying button will be rendered as an `<a>` with this `href` instead of a `<button>`.
    /// </summary>
    public static SlButton SetHref(this SlButton tag, string value)
    {
        return tag.SetAttribute("href", value.ToString());
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static SlButton SetTarget_blank(this SlButton tag)
    {
        return tag.SetAttribute("target", "_blank");
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static SlButton SetTarget_parent(this SlButton tag)
    {
        return tag.SetAttribute("target", "_parent");
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static SlButton SetTarget_self(this SlButton tag)
    {
        return tag.SetAttribute("target", "_self");
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static SlButton SetTarget_top(this SlButton tag)
    {
        return tag.SetAttribute("target", "_top");
    }
    /// <summary>
    /// When using `href`, this attribute will map to the underlying link's `rel` attribute. Unlike regular links, the default is `noreferrer noopener` to prevent security exploits. However, if you're using `target` to point to a specific tab/window, this will prevent that from working correctly. You can remove or change the default value by setting the attribute to an empty string or a value of your choice, respectively.
    /// </summary>
    public static SlButton SetRel(this SlButton tag, string value)
    {
        return tag.SetAttribute("rel", value.ToString());
    }
    /// <summary>
    /// Tells the browser to download the linked file as this filename. Only used when `href` is present.
    /// </summary>
    public static SlButton SetDownload(this SlButton tag, string value)
    {
        return tag.SetAttribute("download", value.ToString());
    }
    /// <summary>
    /// The "form owner" to associate the button with. If omitted, the closest containing form will be used instead. The value of this attribute must be an id of a form in the same document or shadow root as the button.
    /// </summary>
    public static SlButton SetForm(this SlButton tag, string value)
    {
        return tag.SetAttribute("form", value.ToString());
    }
    /// <summary>
    /// Used to override the form owner's `action` attribute.
    /// </summary>
    public static SlButton SetFormAction(this SlButton tag, string value)
    {
        return tag.SetAttribute("formAction", value.ToString());
    }
    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static SlButton SetFormEnctypeApplicationxwwwformurlencoded(this SlButton tag)
    {
        return tag.SetAttribute("formEnctype", "application/x-www-form-urlencoded");
    }
    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static SlButton SetFormEnctypeMultipartformdata(this SlButton tag)
    {
        return tag.SetAttribute("formEnctype", "multipart/form-data");
    }
    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static SlButton SetFormEnctypeTextplain(this SlButton tag)
    {
        return tag.SetAttribute("formEnctype", "text/plain");
    }
    /// <summary>
    /// Used to override the form owner's `method` attribute.
    /// </summary>
    public static SlButton SetFormMethodPost(this SlButton tag)
    {
        return tag.SetAttribute("formMethod", "post");
    }
    /// <summary>
    /// Used to override the form owner's `method` attribute.
    /// </summary>
    public static SlButton SetFormMethodGet(this SlButton tag)
    {
        return tag.SetAttribute("formMethod", "get");
    }
    /// <summary>
    /// Used to override the form owner's `novalidate` attribute.
    /// </summary>
    public static SlButton SetFormNoValidate(this SlButton tag)
    {
        return tag.SetAttribute("formNoValidate", "true");
    }
    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static SlButton SetFormTarget_self(this SlButton tag)
    {
        return tag.SetAttribute("formTarget", "_self");
    }
    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static SlButton SetFormTarget_blank(this SlButton tag)
    {
        return tag.SetAttribute("formTarget", "_blank");
    }
    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static SlButton SetFormTarget_parent(this SlButton tag)
    {
        return tag.SetAttribute("formTarget", "_parent");
    }
    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static SlButton SetFormTarget_top(this SlButton tag)
    {
        return tag.SetAttribute("formTarget", "_top");
    }
    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static SlButton SetFormTargetString(this SlButton tag)
    {
        return tag.SetAttribute("formTarget", "string");
    }
}

