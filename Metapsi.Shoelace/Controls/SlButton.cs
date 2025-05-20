using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlButton
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> A presentational prefix icon or similar element. </para>
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// <para> A presentational suffix icon or similar element. </para>
        /// </summary>
        public const string Suffix = "suffix";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Simulates a click on the button. </para>
        /// </summary>
        public const string Click = "click";
        /// <summary>
        /// <para> Sets focus on the button. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the button. </para>
        /// </summary>
        public const string Blur = "blur";
        /// <summary>
        /// <para> Checks for validity but does not show a validation message. Returns `true` when valid and `false` when invalid. </para>
        /// </summary>
        public const string CheckValidity = "checkValidity";
        /// <summary>
        /// <para> Gets the associated form, if one exists. </para>
        /// </summary>
        public const string GetForm = "getForm";
        /// <summary>
        /// <para> Checks for validity and shows the browser's validation message if the control is invalid. </para>
        /// </summary>
        public const string ReportValidity = "reportValidity";
        /// <summary>
        /// <para> Sets a custom validation message. Pass an empty string to restore validity. </para>
        /// </summary>
        public const string SetCustomValidity = "setCustomValidity";
    }
}

public static partial class SlButtonControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlButton(this HtmlBuilder b, Action<AttributesBuilder<SlButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlButton(this HtmlBuilder b, Action<AttributesBuilder<SlButton>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlButton(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariant(this AttributesBuilder<SlButton> b, string variant)
    {
        b.SetAttribute("variant", variant);
    }

    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantDefault(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("variant", "default");
    }

    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantPrimary(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("variant", "primary");
    }

    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantSuccess(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("variant", "success");
    }

    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantNeutral(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("variant", "neutral");
    }

    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantWarning(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("variant", "warning");
    }

    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantDanger(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("variant", "danger");
    }

    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantText(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("variant", "text");
    }

    /// <summary>
    /// <para> The button's size. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlButton> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The button's size. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> The button's size. </para>
    /// </summary>
    public static void SetSizeMedium(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// <para> The button's size. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior. </para>
    /// </summary>
    public static void SetCaret(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("caret", "");
    }

    /// <summary>
    /// <para> Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior. </para>
    /// </summary>
    public static void SetCaret(this AttributesBuilder<SlButton> b, bool caret)
    {
        if (caret) b.SetAttribute("caret", "");
    }

    /// <summary>
    /// <para> Disables the button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlButton> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Draws the button in a loading state. </para>
    /// </summary>
    public static void SetLoading(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("loading", "");
    }

    /// <summary>
    /// <para> Draws the button in a loading state. </para>
    /// </summary>
    public static void SetLoading(this AttributesBuilder<SlButton> b, bool loading)
    {
        if (loading) b.SetAttribute("loading", "");
    }

    /// <summary>
    /// <para> Draws an outlined button. </para>
    /// </summary>
    public static void SetOutline(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("outline", "");
    }

    /// <summary>
    /// <para> Draws an outlined button. </para>
    /// </summary>
    public static void SetOutline(this AttributesBuilder<SlButton> b, bool outline)
    {
        if (outline) b.SetAttribute("outline", "");
    }

    /// <summary>
    /// <para> Draws a pill-style button with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// <para> Draws a pill-style button with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlButton> b, bool pill)
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    /// <para> Draws a circular icon button. When this attribute is present, the button expects a single `&lt;sl-icon&gt;` in the default slot. </para>
    /// </summary>
    public static void SetCircle(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("circle", "");
    }

    /// <summary>
    /// <para> Draws a circular icon button. When this attribute is present, the button expects a single `&lt;sl-icon&gt;` in the default slot. </para>
    /// </summary>
    public static void SetCircle(this AttributesBuilder<SlButton> b, bool circle)
    {
        if (circle) b.SetAttribute("circle", "");
    }

    /// <summary>
    /// <para> The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<SlButton> b, string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form. </para>
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("type", "button");
    }

    /// <summary>
    /// <para> The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form. </para>
    /// </summary>
    public static void SetTypeSubmit(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// <para> The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form. </para>
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// <para> The name of the button, submitted as a name/value pair with form data, but only when this button is the submitter. This attribute is ignored when `href` is present. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlButton> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The value of the button, submitted as a pair with the button's name as part of the form data, but only when this button is the submitter. This attribute is ignored when `href` is present. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlButton> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> When set, the underlying button will be rendered as an `&lt;a&gt;` with this `href` instead of a `&lt;button&gt;`. </para>
    /// </summary>
    public static void SetHref(this AttributesBuilder<SlButton> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is present. </para>
    /// </summary>
    public static void SetTarget(this AttributesBuilder<SlButton> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is present. </para>
    /// </summary>
    public static void SetTarget_blank(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("target", "_blank");
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is present. </para>
    /// </summary>
    public static void SetTarget_parent(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("target", "_parent");
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is present. </para>
    /// </summary>
    public static void SetTarget_self(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("target", "_self");
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is present. </para>
    /// </summary>
    public static void SetTarget_top(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("target", "_top");
    }

    /// <summary>
    /// <para> When using `href`, this attribute will map to the underlying link's `rel` attribute. Unlike regular links, the default is `noreferrer noopener` to prevent security exploits. However, if you're using `target` to point to a specific tab/window, this will prevent that from working correctly. You can remove or change the default value by setting the attribute to an empty string or a value of your choice, respectively. </para>
    /// </summary>
    public static void SetRel(this AttributesBuilder<SlButton> b, string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// <para> Tells the browser to download the linked file as this filename. Only used when `href` is present. </para>
    /// </summary>
    public static void SetDownload(this AttributesBuilder<SlButton> b, string download)
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// <para> The "form owner" to associate the button with. If omitted, the closest containing form will be used instead. The value of this attribute must be an id of a form in the same document or shadow root as the button. </para>
    /// </summary>
    public static void SetForm(this AttributesBuilder<SlButton> b, string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// <para> Used to override the form owner's `action` attribute. </para>
    /// </summary>
    public static void SetFormaction(this AttributesBuilder<SlButton> b, string formaction)
    {
        b.SetAttribute("formaction", formaction);
    }

    /// <summary>
    /// <para> Used to override the form owner's `enctype` attribute. </para>
    /// </summary>
    public static void SetFormenctype(this AttributesBuilder<SlButton> b, string formenctype)
    {
        b.SetAttribute("formenctype", formenctype);
    }

    /// <summary>
    /// <para> Used to override the form owner's `enctype` attribute. </para>
    /// </summary>
    public static void SetFormenctypeApplicationXWwwFormUrlencoded(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("formenctype", "application/x-www-form-urlencoded");
    }

    /// <summary>
    /// <para> Used to override the form owner's `enctype` attribute. </para>
    /// </summary>
    public static void SetFormenctypeMultipartFormData(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("formenctype", "multipart/form-data");
    }

    /// <summary>
    /// <para> Used to override the form owner's `enctype` attribute. </para>
    /// </summary>
    public static void SetFormenctypeTextPlain(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("formenctype", "text/plain");
    }

    /// <summary>
    /// <para> Used to override the form owner's `method` attribute. </para>
    /// </summary>
    public static void SetFormmethod(this AttributesBuilder<SlButton> b, string formmethod)
    {
        b.SetAttribute("formmethod", formmethod);
    }

    /// <summary>
    /// <para> Used to override the form owner's `method` attribute. </para>
    /// </summary>
    public static void SetFormmethodPost(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("formmethod", "post");
    }

    /// <summary>
    /// <para> Used to override the form owner's `method` attribute. </para>
    /// </summary>
    public static void SetFormmethodGet(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("formmethod", "get");
    }

    /// <summary>
    /// <para> Used to override the form owner's `novalidate` attribute. </para>
    /// </summary>
    public static void SetFormnovalidate(this AttributesBuilder<SlButton> b)
    {
        b.SetAttribute("formnovalidate", "");
    }

    /// <summary>
    /// <para> Used to override the form owner's `novalidate` attribute. </para>
    /// </summary>
    public static void SetFormnovalidate(this AttributesBuilder<SlButton> b, bool formnovalidate)
    {
        if (formnovalidate) b.SetAttribute("formnovalidate", "");
    }

    /// <summary>
    /// <para> Used to override the form owner's `target` attribute. </para>
    /// </summary>
    public static void SetFormtarget(this AttributesBuilder<SlButton> b, string formtarget)
    {
        b.SetAttribute("formtarget", formtarget);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButton(this LayoutBuilder b, Action<PropsBuilder<SlButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButton(this LayoutBuilder b, Action<PropsBuilder<SlButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-button", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-button", children);
    }
    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantDefault<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("default"));
    }


    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantPrimary<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantSuccess<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("success"));
    }


    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantNeutral<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("neutral"));
    }


    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantWarning<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("warning"));
    }


    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantDanger<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The button's theme variant. </para>
    /// </summary>
    public static void SetVariantText<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("text"));
    }


    /// <summary>
    /// <para> The button's size. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> The button's size. </para>
    /// </summary>
    public static void SetSizeMedium<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The button's size. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior. </para>
    /// </summary>
    public static void SetCaret<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("caret"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior. </para>
    /// </summary>
    public static void SetCaret<T>(this PropsBuilder<T> b, Var<bool> caret) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("caret"), caret);
    }

    /// <summary>
    /// <para> Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior. </para>
    /// </summary>
    public static void SetCaret<T>(this PropsBuilder<T> b, bool caret) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("caret"), b.Const(caret));
    }


    /// <summary>
    /// <para> Disables the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Draws the button in a loading state. </para>
    /// </summary>
    public static void SetLoading<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("loading"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the button in a loading state. </para>
    /// </summary>
    public static void SetLoading<T>(this PropsBuilder<T> b, Var<bool> loading) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("loading"), loading);
    }

    /// <summary>
    /// <para> Draws the button in a loading state. </para>
    /// </summary>
    public static void SetLoading<T>(this PropsBuilder<T> b, bool loading) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("loading"), b.Const(loading));
    }


    /// <summary>
    /// <para> Draws an outlined button. </para>
    /// </summary>
    public static void SetOutline<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("outline"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws an outlined button. </para>
    /// </summary>
    public static void SetOutline<T>(this PropsBuilder<T> b, Var<bool> outline) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("outline"), outline);
    }

    /// <summary>
    /// <para> Draws an outlined button. </para>
    /// </summary>
    public static void SetOutline<T>(this PropsBuilder<T> b, bool outline) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("outline"), b.Const(outline));
    }


    /// <summary>
    /// <para> Draws a pill-style button with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("pill"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws a pill-style button with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, Var<bool> pill) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("pill"), pill);
    }

    /// <summary>
    /// <para> Draws a pill-style button with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, bool pill) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("pill"), b.Const(pill));
    }


    /// <summary>
    /// <para> Draws a circular icon button. When this attribute is present, the button expects a single `&lt;sl-icon&gt;` in the default slot. </para>
    /// </summary>
    public static void SetCircle<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("circle"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws a circular icon button. When this attribute is present, the button expects a single `&lt;sl-icon&gt;` in the default slot. </para>
    /// </summary>
    public static void SetCircle<T>(this PropsBuilder<T> b, Var<bool> circle) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("circle"), circle);
    }

    /// <summary>
    /// <para> Draws a circular icon button. When this attribute is present, the button expects a single `&lt;sl-icon&gt;` in the default slot. </para>
    /// </summary>
    public static void SetCircle<T>(this PropsBuilder<T> b, bool circle) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("circle"), b.Const(circle));
    }


    /// <summary>
    /// <para> The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form. </para>
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("button"));
    }


    /// <summary>
    /// <para> The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form. </para>
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("submit"));
    }


    /// <summary>
    /// <para> The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form. </para>
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("reset"));
    }


    /// <summary>
    /// <para> The name of the button, submitted as a name/value pair with form data, but only when this button is the submitter. This attribute is ignored when `href` is present. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// <para> The name of the button, submitted as a name/value pair with form data, but only when this button is the submitter. This attribute is ignored when `href` is present. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The value of the button, submitted as a pair with the button's name as part of the form data, but only when this button is the submitter. This attribute is ignored when `href` is present. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> The value of the button, submitted as a pair with the button's name as part of the form data, but only when this button is the submitter. This attribute is ignored when `href` is present. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> When set, the underlying button will be rendered as an `&lt;a&gt;` with this `href` instead of a `&lt;button&gt;`. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> href) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("href"), href);
    }

    /// <summary>
    /// <para> When set, the underlying button will be rendered as an `&lt;a&gt;` with this `href` instead of a `&lt;button&gt;`. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string href) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("href"), b.Const(href));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is present. </para>
    /// </summary>
    public static void SetTarget_blank<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_blank"));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is present. </para>
    /// </summary>
    public static void SetTarget_parent<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_parent"));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is present. </para>
    /// </summary>
    public static void SetTarget_self<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_self"));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is present. </para>
    /// </summary>
    public static void SetTarget_top<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_top"));
    }


    /// <summary>
    /// <para> When using `href`, this attribute will map to the underlying link's `rel` attribute. Unlike regular links, the default is `noreferrer noopener` to prevent security exploits. However, if you're using `target` to point to a specific tab/window, this will prevent that from working correctly. You can remove or change the default value by setting the attribute to an empty string or a value of your choice, respectively. </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> rel) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("rel"), rel);
    }

    /// <summary>
    /// <para> When using `href`, this attribute will map to the underlying link's `rel` attribute. Unlike regular links, the default is `noreferrer noopener` to prevent security exploits. However, if you're using `target` to point to a specific tab/window, this will prevent that from working correctly. You can remove or change the default value by setting the attribute to an empty string or a value of your choice, respectively. </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string rel) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("rel"), b.Const(rel));
    }


    /// <summary>
    /// <para> Tells the browser to download the linked file as this filename. Only used when `href` is present. </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> download) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("download"), download);
    }

    /// <summary>
    /// <para> Tells the browser to download the linked file as this filename. Only used when `href` is present. </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string download) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("download"), b.Const(download));
    }


    /// <summary>
    /// <para> The "form owner" to associate the button with. If omitted, the closest containing form will be used instead. The value of this attribute must be an id of a form in the same document or shadow root as the button. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<string> form) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// <para> The "form owner" to associate the button with. If omitted, the closest containing form will be used instead. The value of this attribute must be an id of a form in the same document or shadow root as the button. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, string form) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("form"), b.Const(form));
    }


    /// <summary>
    /// <para> Used to override the form owner's `action` attribute. </para>
    /// </summary>
    public static void SetFormAction<T>(this PropsBuilder<T> b, Var<string> formAction) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formAction"), formAction);
    }

    /// <summary>
    /// <para> Used to override the form owner's `action` attribute. </para>
    /// </summary>
    public static void SetFormAction<T>(this PropsBuilder<T> b, string formAction) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formAction"), b.Const(formAction));
    }


    /// <summary>
    /// <para> Used to override the form owner's `enctype` attribute. </para>
    /// </summary>
    public static void SetFormEnctypeApplicationXWwwFormUrlencoded<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formEnctype"), b.Const("application/x-www-form-urlencoded"));
    }


    /// <summary>
    /// <para> Used to override the form owner's `enctype` attribute. </para>
    /// </summary>
    public static void SetFormEnctypeMultipartFormData<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formEnctype"), b.Const("multipart/form-data"));
    }


    /// <summary>
    /// <para> Used to override the form owner's `enctype` attribute. </para>
    /// </summary>
    public static void SetFormEnctypeTextPlain<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formEnctype"), b.Const("text/plain"));
    }


    /// <summary>
    /// <para> Used to override the form owner's `method` attribute. </para>
    /// </summary>
    public static void SetFormMethodPost<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formMethod"), b.Const("post"));
    }


    /// <summary>
    /// <para> Used to override the form owner's `method` attribute. </para>
    /// </summary>
    public static void SetFormMethodGet<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formMethod"), b.Const("get"));
    }


    /// <summary>
    /// <para> Used to override the form owner's `novalidate` attribute. </para>
    /// </summary>
    public static void SetFormNoValidate<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formNoValidate"), b.Const(true));
    }


    /// <summary>
    /// <para> Used to override the form owner's `novalidate` attribute. </para>
    /// </summary>
    public static void SetFormNoValidate<T>(this PropsBuilder<T> b, Var<bool> formNoValidate) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formNoValidate"), formNoValidate);
    }

    /// <summary>
    /// <para> Used to override the form owner's `novalidate` attribute. </para>
    /// </summary>
    public static void SetFormNoValidate<T>(this PropsBuilder<T> b, bool formNoValidate) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formNoValidate"), b.Const(formNoValidate));
    }


    /// <summary>
    /// <para> Used to override the form owner's `target` attribute. </para>
    /// </summary>
    public static void SetFormTarget_self<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_self"));
    }


    /// <summary>
    /// <para> Used to override the form owner's `target` attribute. </para>
    /// </summary>
    public static void SetFormTarget_blank<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_blank"));
    }


    /// <summary>
    /// <para> Used to override the form owner's `target` attribute. </para>
    /// </summary>
    public static void SetFormTarget_parent<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_parent"));
    }


    /// <summary>
    /// <para> Used to override the form owner's `target` attribute. </para>
    /// </summary>
    public static void SetFormTarget_top<T>(this PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_top"));
    }


    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlButton
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

