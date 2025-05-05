using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonItemSliding
{
    public static class Method
    {
        /// <summary>
        /// <para> Close the sliding item. Items can also be closed from the [List](./list). </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
        /// </summary>
        public const string Close = "close";
        /// <summary>
        /// <para> Close all of the sliding items in the list. Items can also be closed from the [List](./list). </para>
        /// <para> () =&gt; Promise&lt;boolean&gt; </para>
        /// </summary>
        public const string CloseOpened = "closeOpened";
        /// <summary>
        /// <para> Get the amount the item is open in pixels. </para>
        /// <para> () =&gt; Promise&lt;number&gt; </para>
        /// </summary>
        public const string GetOpenAmount = "getOpenAmount";
        /// <summary>
        /// <para> Get the ratio of the open amount of the item compared to the width of the options. If the number returned is positive, then the options on the right side are open. If the number returned is negative, then the options on the left side are open. If the absolute value of the number is greater than 1, the item is open more than the width of the options. </para>
        /// <para> () =&gt; Promise&lt;number&gt; </para>
        /// </summary>
        public const string GetSlidingRatio = "getSlidingRatio";
        /// <summary>
        /// <para> Open the sliding item. </para>
        /// <para> (side: Side | undefined) =&gt; Promise&lt;void&gt; </para>
        /// <para> side The side of the options to open. If a side is not provided, it will open the first set of options it finds within the item. </para>
        /// </summary>
        public const string Open = "open";
    }
}

public static partial class IonItemSlidingControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemSliding(this HtmlBuilder b, Action<AttributesBuilder<IonItemSliding>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-sliding", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemSliding(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-sliding", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemSliding(this HtmlBuilder b, Action<AttributesBuilder<IonItemSliding>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-item-sliding", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemSliding(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-item-sliding", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the user cannot interact with the sliding item. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonItemSliding> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the sliding item. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonItemSliding> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemSliding(this LayoutBuilder b, Action<PropsBuilder<IonItemSliding>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-sliding", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemSliding(this LayoutBuilder b, Action<PropsBuilder<IonItemSliding>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-sliding", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemSliding(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-sliding", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemSliding(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-sliding", children);
    }
    /// <summary>
    /// <para> If `true`, the user cannot interact with the sliding item. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonItemSliding
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the sliding item. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonItemSliding
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the sliding item. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonItemSliding
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Emitted when the sliding position changes. </para>
    /// </summary>
    public static void OnIonDrag<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DynamicObject>> action) where TComponent: IonItemSliding
    {
        b.OnEventAction("onionDrag", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the sliding position changes. </para>
    /// </summary>
    public static void OnIonDrag<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DynamicObject>, Var<TModel>> action) where TComponent: IonItemSliding
    {
        b.OnEventAction("onionDrag", b.MakeAction(action), "detail");
    }

}

