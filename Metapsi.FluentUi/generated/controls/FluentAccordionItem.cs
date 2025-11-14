using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentAccordionItem
{
    public static class Slot
    {
        public const string Start = "start";
        public const string Heading = "heading";
        public const string MarkerExpanded = "marker-expanded";
        public const string MarkerCollapsed = "marker-collapsed";
    }
}
public static partial class FluentAccordionItemExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentAccordionItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentAccordionItem>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-accordion-item", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentAccordionItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentAccordionItem>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentAccordionItem(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentAccordionItem(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentAccordionItem(b => { }, children);
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetSizeLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }
    public static void SetSizeExtraLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("extra-large"));
    }
    public static void SetMarkerPositionStart(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("markerPosition"), b.Const("start"));
    }
    public static void SetMarkerPositionEnd(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("markerPosition"), b.Const("end"));
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b, Metapsi.Syntax.Var<bool> block) 
    {
        b.SetProperty(b.Props, b.Const("block"), block);
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b, bool block) 
    {
        b.SetBlock(b.Const(block));
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetBlock(b.Const(true));
    }
    public static void SetHeadinglevel1(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("headinglevel"), b.Const(1));
    }
    public static void SetHeadinglevel2(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("headinglevel"), b.Const(2));
    }
    public static void SetHeadinglevel3(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("headinglevel"), b.Const(3));
    }
    public static void SetHeadinglevel4(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("headinglevel"), b.Const(4));
    }
    public static void SetHeadinglevel5(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("headinglevel"), b.Const(5));
    }
    public static void SetHeadinglevel6(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetProperty(b.Props, b.Const("headinglevel"), b.Const(6));
    }
    public static void SetExpanded(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b, Metapsi.Syntax.Var<bool> expanded) 
    {
        b.SetProperty(b.Props, b.Const("expanded"), expanded);
    }
    public static void SetExpanded(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b, bool expanded) 
    {
        b.SetExpanded(b.Const(expanded));
    }
    public static void SetExpanded(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetExpanded(b.Const(true));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b) 
    {
        b.SetDisabled(b.Const(true));
    }
    public static void SetId(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b, Metapsi.Syntax.Var<string> id) 
    {
        b.SetProperty(b.Props, b.Const("id"), id);
    }
    public static void SetId(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAccordionItem> b, string id) 
    {
        b.SetId(b.Const(id));
    }
}