using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonSegmentContent
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of IonSegmentContent
/// </summary>
public static partial class IonSegmentContentControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentContent(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSegmentContent>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-segment-content", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentContent(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-segment-content", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentContent(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSegmentContent>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-segment-content", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentContent(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-segment-content", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentContent(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSegmentContent>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-segment-content", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentContent(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-segment-content", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentContent(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSegmentContent>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-segment-content", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentContent(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-segment-content", children);
    }

}