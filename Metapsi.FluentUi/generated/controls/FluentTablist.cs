using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentTablist
{
    public static class Slot
    {
    }
}
public static partial class FluentTablistExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTablist(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTablist>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-tablist", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTablist(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTablist>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTablist(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTablist(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTablist(b => { }, children);
    }
    public static void SetAppearanceSubtle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("subtle"));
    }
    public static void SetAppearanceTransparent(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("transparent"));
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetSizeLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }
    public static void SetActiveidChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b, Metapsi.Syntax.Var<System.Action<string, string>> activeidChanged) 
    {
        b.SetProperty(b.Props, b.Const("activeidChanged"), activeidChanged);
    }
    public static void SetTabsChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b, Metapsi.Syntax.Var<System.Action> tabsChanged) 
    {
        b.SetProperty(b.Props, b.Const("tabsChanged"), tabsChanged);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b) 
    {
        b.SetDisabled(b.Const(true));
    }
    public static void SetOrientationHorizontal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b) 
    {
        b.SetProperty(b.Props, b.Const("orientation"), b.Const("horizontal"));
    }
    public static void SetOrientationVertical(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b) 
    {
        b.SetProperty(b.Props, b.Const("orientation"), b.Const("vertical"));
    }
    public static void SetActiveid(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b, Metapsi.Syntax.Var<string> activeid) 
    {
        b.SetProperty(b.Props, b.Const("activeid"), activeid);
    }
    public static void SetActiveid(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b, string activeid) 
    {
        b.SetActiveid(b.Const(activeid));
    }
    public static void SetActivetab(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTablist> b, Metapsi.Syntax.Var<FluentTab> activetab) 
    {
        b.SetProperty(b.Props, b.Const("activetab"), activetab);
    }
    public static void SetTabs(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTablist> b) 
    {
        b.Call("setTabs");
    }
    public static void Adjust(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTablist> b, Metapsi.Syntax.Var<int> adjustment) 
    {
        b.Call("adjust", adjustment);
    }
}