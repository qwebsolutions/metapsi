using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonApp
{
    public static class Method
    {
        /// <summary>
        /// <para> Used to set focus on an element that uses `ion-focusable`. Do not use this if focusing the element as a result of a keyboard event as the focus utility should handle this for us. This method should be used when we want to programmatically focus an element as a result of another user action. (Ex: We focus the first element inside of a popover when the user presents it, but the popover is not always presented as a result of keyboard action.) </para>
        /// <para> (elements: HTMLElement[]) =&gt; Promise&lt;void&gt; </para>
        /// <para> elements  </para>
        /// </summary>
        public const string SetFocus = "setFocus";
    }
}

public static partial class IonAppControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonApp(this HtmlBuilder b, Action<AttributesBuilder<IonApp>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-app", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonApp(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-app", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonApp(this HtmlBuilder b, Action<AttributesBuilder<IonApp>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-app", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonApp(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-app", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, Action<PropsBuilder<IonApp>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-app", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, Action<PropsBuilder<IonApp>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-app", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-app", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-app", children);
    }
}

