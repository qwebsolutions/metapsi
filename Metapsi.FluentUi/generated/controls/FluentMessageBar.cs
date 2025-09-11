using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentMessageBar
{
    public static class Slot
    {
        public const string Actions = "actions";
        public const string Dismiss = "dismiss";
    }
}
public static partial class FluentMessageBarExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMessageBar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentMessageBar>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-message-bar", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMessageBar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentMessageBar>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentMessageBar(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMessageBar(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentMessageBar(b => { }, children);
    }
    public static void SetShapeRounded(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMessageBar> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("rounded"));
    }
    public static void SetShapeSquare(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMessageBar> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("square"));
    }
    public static void SetLayoutMultiline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMessageBar> b) 
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("multiline"));
    }
    public static void SetLayoutSingleline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMessageBar> b) 
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("singleline"));
    }
    public static void SetIntentSuccess(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMessageBar> b) 
    {
        b.SetProperty(b.Props, b.Const("intent"), b.Const("success"));
    }
    public static void SetIntentWarning(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMessageBar> b) 
    {
        b.SetProperty(b.Props, b.Const("intent"), b.Const("warning"));
    }
    public static void SetIntentError(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMessageBar> b) 
    {
        b.SetProperty(b.Props, b.Const("intent"), b.Const("error"));
    }
    public static void SetIntentInfo(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMessageBar> b) 
    {
        b.SetProperty(b.Props, b.Const("intent"), b.Const("info"));
    }
    public static void SetDismissMessageBar(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMessageBar> b, Metapsi.Syntax.Var<System.Action> dismissMessageBar) 
    {
        b.SetProperty(b.Props, b.Const("dismissMessageBar"), dismissMessageBar);
    }
}