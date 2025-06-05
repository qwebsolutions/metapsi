using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Buttons represent actions that are available to the user.
/// </summary>
public partial class SlButton
{
    /// <summary>
    /// 
    /// </summary>
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
    /// <summary>
    /// 
    /// </summary>
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
/// <summary>
/// Setter extensions of SlButton
/// </summary>
public static partial class SlButtonControl
{
    /// <summary>
    /// Buttons represent actions that are available to the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlButton>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-button", buildAttributes, children);
    }

    /// <summary>
    /// Buttons represent actions that are available to the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlButton(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Buttons represent actions that are available to the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlButton>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-button", buildAttributes, children);
    }

    /// <summary>
    /// Buttons represent actions that are available to the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlButton(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static void SetTitle(this Metapsi.Html.AttributesBuilder<SlButton> b, string title) 
    {
        b.SetAttribute("title", title);
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantDefault(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("variant", "default");
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantPrimary(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("variant", "primary");
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantSuccess(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("variant", "success");
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantNeutral(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("variant", "neutral");
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantWarning(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("variant", "warning");
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantDanger(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("variant", "danger");
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantText(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("variant", "text");
    }

    /// <summary>
    /// The button's size.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// The button's size.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// The button's size.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior.
    /// </summary>
    public static void SetCaret(this Metapsi.Html.AttributesBuilder<SlButton> b, bool caret) 
    {
        if (caret) b.SetAttribute("caret", "");
    }

    /// <summary>
    /// Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior.
    /// </summary>
    public static void SetCaret(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("caret", "");
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlButton> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Draws the button in a loading state.
    /// </summary>
    public static void SetLoading(this Metapsi.Html.AttributesBuilder<SlButton> b, bool loading) 
    {
        if (loading) b.SetAttribute("loading", "");
    }

    /// <summary>
    /// Draws the button in a loading state.
    /// </summary>
    public static void SetLoading(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("loading", "");
    }

    /// <summary>
    /// Draws an outlined button.
    /// </summary>
    public static void SetOutline(this Metapsi.Html.AttributesBuilder<SlButton> b, bool outline) 
    {
        if (outline) b.SetAttribute("outline", "");
    }

    /// <summary>
    /// Draws an outlined button.
    /// </summary>
    public static void SetOutline(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("outline", "");
    }

    /// <summary>
    /// Draws a pill-style button with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlButton> b, bool pill) 
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    /// Draws a pill-style button with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// Draws a circular icon button. When this attribute is present, the button expects a single `&lt;sl-icon&gt;` in the default slot.
    /// </summary>
    public static void SetCircle(this Metapsi.Html.AttributesBuilder<SlButton> b, bool circle) 
    {
        if (circle) b.SetAttribute("circle", "");
    }

    /// <summary>
    /// Draws a circular icon button. When this attribute is present, the button expects a single `&lt;sl-icon&gt;` in the default slot.
    /// </summary>
    public static void SetCircle(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("circle", "");
    }

    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static void SetTypeButton(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("type", "button");
    }

    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static void SetTypeSubmit(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static void SetTypeReset(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// The name of the button, submitted as a name/value pair with form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlButton> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// The value of the button, submitted as a pair with the button's name as part of the form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlButton> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// When set, the underlying button will be rendered as an `&lt;a&gt;` with this `href` instead of a `&lt;button&gt;`.
    /// </summary>
    public static void SetHref(this Metapsi.Html.AttributesBuilder<SlButton> b, string href) 
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_blank(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("target", "_blank");
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_parent(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("target", "_parent");
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_self(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("target", "_self");
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_top(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("target", "_top");
    }

    /// <summary>
    /// When using `href`, this attribute will map to the underlying link's `rel` attribute. Unlike regular links, the default is `noreferrer noopener` to prevent security exploits. However, if you're using `target` to point to a specific tab/window, this will prevent that from working correctly. You can remove or change the default value by setting the attribute to an empty string or a value of your choice, respectively.
    /// </summary>
    public static void SetRel(this Metapsi.Html.AttributesBuilder<SlButton> b, string rel) 
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// Tells the browser to download the linked file as this filename. Only used when `href` is present.
    /// </summary>
    public static void SetDownload(this Metapsi.Html.AttributesBuilder<SlButton> b, string download) 
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// The "form owner" to associate the button with. If omitted, the closest containing form will be used instead. The value of this attribute must be an id of a form in the same document or shadow root as the button.
    /// </summary>
    public static void SetForm(this Metapsi.Html.AttributesBuilder<SlButton> b, string form) 
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// Used to override the form owner's `action` attribute.
    /// </summary>
    public static void SetFormaction(this Metapsi.Html.AttributesBuilder<SlButton> b, string formaction) 
    {
        b.SetAttribute("formaction", formaction);
    }

    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static void SetFormenctypeApplicationXWwwFormUrlencoded(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("formenctype", "application/x-www-form-urlencoded");
    }

    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static void SetFormenctypeMultipartFormData(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("formenctype", "multipart/form-data");
    }

    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static void SetFormenctypeTextPlain(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("formenctype", "text/plain");
    }

    /// <summary>
    /// Used to override the form owner's `method` attribute.
    /// </summary>
    public static void SetFormmethodPost(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("formmethod", "post");
    }

    /// <summary>
    /// Used to override the form owner's `method` attribute.
    /// </summary>
    public static void SetFormmethodGet(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("formmethod", "get");
    }

    /// <summary>
    /// Used to override the form owner's `novalidate` attribute.
    /// </summary>
    public static void SetFormnovalidate(this Metapsi.Html.AttributesBuilder<SlButton> b, bool formnovalidate) 
    {
        if (formnovalidate) b.SetAttribute("formnovalidate", "");
    }

    /// <summary>
    /// Used to override the form owner's `novalidate` attribute.
    /// </summary>
    public static void SetFormnovalidate(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("formnovalidate", "");
    }

    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormtarget_self(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("formtarget", "_self");
    }

    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormtarget_blank(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("formtarget", "_blank");
    }

    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormtarget_parent(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("formtarget", "_parent");
    }

    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormtarget_top(this Metapsi.Html.AttributesBuilder<SlButton> b) 
    {
        b.SetAttribute("formtarget", "_top");
    }

    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormtarget(this Metapsi.Html.AttributesBuilder<SlButton> b, string formtarget) 
    {
        b.SetAttribute("formtarget", formtarget);
    }

    /// <summary>
    /// Buttons represent actions that are available to the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlButton>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-button", buildProps, children);
    }

    /// <summary>
    /// Buttons represent actions that are available to the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlButton(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-button", children);
    }

    /// <summary>
    /// Buttons represent actions that are available to the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlButton>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-button", buildProps, children);
    }

    /// <summary>
    /// Buttons represent actions that are available to the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlButton(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-button", children);
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantDefault<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("default"));
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("primary"));
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("success"));
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantNeutral<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("neutral"));
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("warning"));
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("danger"));
    }

    /// <summary>
    /// The button's theme variant.
    /// </summary>
    public static void SetVariantText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("text"));
    }

    /// <summary>
    /// The button's size.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The button's size.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The button's size.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior.
    /// </summary>
    public static void SetCaret<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetCaret(b.Const(true));
    }

    /// <summary>
    /// Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior.
    /// </summary>
    public static void SetCaret<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> caret) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("caret"), caret);
    }

    /// <summary>
    /// Draws the button with a caret. Used to indicate that the button triggers a dropdown menu or similar behavior.
    /// </summary>
    public static void SetCaret<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool caret) where T: SlButton
    {
        b.SetCaret(b.Const(caret));
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlButton
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Draws the button in a loading state.
    /// </summary>
    public static void SetLoading<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetLoading(b.Const(true));
    }

    /// <summary>
    /// Draws the button in a loading state.
    /// </summary>
    public static void SetLoading<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> loading) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("loading"), loading);
    }

    /// <summary>
    /// Draws the button in a loading state.
    /// </summary>
    public static void SetLoading<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool loading) where T: SlButton
    {
        b.SetLoading(b.Const(loading));
    }

    /// <summary>
    /// Draws an outlined button.
    /// </summary>
    public static void SetOutline<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetOutline(b.Const(true));
    }

    /// <summary>
    /// Draws an outlined button.
    /// </summary>
    public static void SetOutline<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> outline) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("outline"), outline);
    }

    /// <summary>
    /// Draws an outlined button.
    /// </summary>
    public static void SetOutline<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool outline) where T: SlButton
    {
        b.SetOutline(b.Const(outline));
    }

    /// <summary>
    /// Draws a pill-style button with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetPill(b.Const(true));
    }

    /// <summary>
    /// Draws a pill-style button with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> pill) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("pill"), pill);
    }

    /// <summary>
    /// Draws a pill-style button with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool pill) where T: SlButton
    {
        b.SetPill(b.Const(pill));
    }

    /// <summary>
    /// Draws a circular icon button. When this attribute is present, the button expects a single `&lt;sl-icon&gt;` in the default slot.
    /// </summary>
    public static void SetCircle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetCircle(b.Const(true));
    }

    /// <summary>
    /// Draws a circular icon button. When this attribute is present, the button expects a single `&lt;sl-icon&gt;` in the default slot.
    /// </summary>
    public static void SetCircle<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> circle) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("circle"), circle);
    }

    /// <summary>
    /// Draws a circular icon button. When this attribute is present, the button expects a single `&lt;sl-icon&gt;` in the default slot.
    /// </summary>
    public static void SetCircle<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool circle) where T: SlButton
    {
        b.SetCircle(b.Const(circle));
    }

    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static void SetTypeButton<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("button"));
    }

    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static void SetTypeSubmit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("submit"));
    }

    /// <summary>
    /// The type of button. Note that the default value is `button` instead of `submit`, which is opposite of how native `&lt;button&gt;` elements behave. When the type is `submit`, the button will submit the surrounding form.
    /// </summary>
    public static void SetTypeReset<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("reset"));
    }

    /// <summary>
    /// The name of the button, submitted as a name/value pair with form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the button, submitted as a name/value pair with form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlButton
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// The value of the button, submitted as a pair with the button's name as part of the form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The value of the button, submitted as a pair with the button's name as part of the form data, but only when this button is the submitter. This attribute is ignored when `href` is present.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlButton
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// When set, the underlying button will be rendered as an `&lt;a&gt;` with this `href` instead of a `&lt;button&gt;`.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("href"), href);
    }

    /// <summary>
    /// When set, the underlying button will be rendered as an `&lt;a&gt;` with this `href` instead of a `&lt;button&gt;`.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, string href) where T: SlButton
    {
        b.SetHref(b.Const(href));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_blank<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_blank"));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_parent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_parent"));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_self<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_self"));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is present.
    /// </summary>
    public static void SetTarget_top<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_top"));
    }

    /// <summary>
    /// When using `href`, this attribute will map to the underlying link's `rel` attribute. Unlike regular links, the default is `noreferrer noopener` to prevent security exploits. However, if you're using `target` to point to a specific tab/window, this will prevent that from working correctly. You can remove or change the default value by setting the attribute to an empty string or a value of your choice, respectively.
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("rel"), rel);
    }

    /// <summary>
    /// When using `href`, this attribute will map to the underlying link's `rel` attribute. Unlike regular links, the default is `noreferrer noopener` to prevent security exploits. However, if you're using `target` to point to a specific tab/window, this will prevent that from working correctly. You can remove or change the default value by setting the attribute to an empty string or a value of your choice, respectively.
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string rel) where T: SlButton
    {
        b.SetRel(b.Const(rel));
    }

    /// <summary>
    /// Tells the browser to download the linked file as this filename. Only used when `href` is present.
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("download"), download);
    }

    /// <summary>
    /// Tells the browser to download the linked file as this filename. Only used when `href` is present.
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, string download) where T: SlButton
    {
        b.SetDownload(b.Const(download));
    }

    /// <summary>
    /// The "form owner" to associate the button with. If omitted, the closest containing form will be used instead. The value of this attribute must be an id of a form in the same document or shadow root as the button.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// The "form owner" to associate the button with. If omitted, the closest containing form will be used instead. The value of this attribute must be an id of a form in the same document or shadow root as the button.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string form) where T: SlButton
    {
        b.SetForm(b.Const(form));
    }

    /// <summary>
    /// Used to override the form owner's `action` attribute.
    /// </summary>
    public static void SetFormAction<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> formAction) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formAction"), formAction);
    }

    /// <summary>
    /// Used to override the form owner's `action` attribute.
    /// </summary>
    public static void SetFormAction<T>(this Metapsi.Syntax.PropsBuilder<T> b, string formAction) where T: SlButton
    {
        b.SetFormAction(b.Const(formAction));
    }

    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static void SetFormEnctypeApplicationXWwwFormUrlencoded<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formEnctype"), b.Const("application/x-www-form-urlencoded"));
    }

    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static void SetFormEnctypeMultipartFormData<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formEnctype"), b.Const("multipart/form-data"));
    }

    /// <summary>
    /// Used to override the form owner's `enctype` attribute.
    /// </summary>
    public static void SetFormEnctypeTextPlain<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formEnctype"), b.Const("text/plain"));
    }

    /// <summary>
    /// Used to override the form owner's `method` attribute.
    /// </summary>
    public static void SetFormMethodPost<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formMethod"), b.Const("post"));
    }

    /// <summary>
    /// Used to override the form owner's `method` attribute.
    /// </summary>
    public static void SetFormMethodGet<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formMethod"), b.Const("get"));
    }

    /// <summary>
    /// Used to override the form owner's `novalidate` attribute.
    /// </summary>
    public static void SetFormNoValidate<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetFormNoValidate(b.Const(true));
    }

    /// <summary>
    /// Used to override the form owner's `novalidate` attribute.
    /// </summary>
    public static void SetFormNoValidate<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> formNoValidate) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formNoValidate"), formNoValidate);
    }

    /// <summary>
    /// Used to override the form owner's `novalidate` attribute.
    /// </summary>
    public static void SetFormNoValidate<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool formNoValidate) where T: SlButton
    {
        b.SetFormNoValidate(b.Const(formNoValidate));
    }

    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormTarget_self<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_self"));
    }

    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormTarget_blank<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_blank"));
    }

    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormTarget_parent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_parent"));
    }

    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormTarget_top<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formTarget"), b.Const("_top"));
    }

    /// <summary>
    /// Used to override the form owner's `target` attribute.
    /// </summary>
    public static void SetFormTarget<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> formTarget) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("formTarget"), formTarget);
    }

    /// <summary>
    /// Gets the validity state object
    /// </summary>
    public static void SetValidity<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> validity) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("validity"), validity);
    }

    /// <summary>
    /// Gets the validity state object
    /// </summary>
    public static void SetValidity<T>(this Metapsi.Syntax.PropsBuilder<T> b, string validity) where T: SlButton
    {
        b.SetValidity(b.Const(validity));
    }

    /// <summary>
    /// Gets the validation message
    /// </summary>
    public static void SetValidationMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> validationMessage) where T: SlButton
    {
        b.SetProperty(b.Props, b.Const("validationMessage"), validationMessage);
    }

    /// <summary>
    /// Gets the validation message
    /// </summary>
    public static void SetValidationMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, string validationMessage) where T: SlButton
    {
        b.SetValidationMessage(b.Const(validationMessage));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlButton
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlButton
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlButton
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlButton
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlButton
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlButton
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlButton
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlButton
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlButton
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlButton
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlButton
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlButton
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

}