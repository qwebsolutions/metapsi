using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentMenuItem
{
    public static class Slot
    {
        public const string Indicator = "indicator";
        public const string Start = "start";
        public const string End = "end";
        public const string SubmenuGlyph = "submenu-glyph";
        public const string Submenu = "submenu";
    }
}
public static partial class FluentMenuItemExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMenuItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentMenuItem>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-menu-item", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMenuItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentMenuItem>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentMenuItem(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMenuItem(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentMenuItem(b => { }, children);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b, Metapsi.Syntax.Var<bool> disabled) 
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b, bool disabled) 
    {
        b.SetDisabled(b.Const(disabled));
    }
    public static void SetDisabled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b) 
    {
        b.SetDisabled(b.Const(true));
    }
    public static void SetDisabledChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b, Metapsi.Syntax.Var<System.Action<bool, bool>> disabledChanged) 
    {
        b.SetProperty(b.Props, b.Const("disabledChanged"), disabledChanged);
    }
    public static void SetRoleMenuitem(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b) 
    {
        b.SetProperty(b.Props, b.Const("role"), b.Const("menuitem"));
    }
    public static void SetRoleMenuitemcheckbox(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b) 
    {
        b.SetProperty(b.Props, b.Const("role"), b.Const("menuitemcheckbox"));
    }
    public static void SetRoleMenuitemradio(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b) 
    {
        b.SetProperty(b.Props, b.Const("role"), b.Const("menuitemradio"));
    }
    public static void SetRoleChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b, Metapsi.Syntax.Var<System.Action<string, string>> roleChanged) 
    {
        b.SetProperty(b.Props, b.Const("roleChanged"), roleChanged);
    }
    public static void SetChecked(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b, Metapsi.Syntax.Var<bool> @checked) 
    {
        b.SetProperty(b.Props, b.Const("checked"), @checked);
    }
    public static void SetChecked(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b, bool @checked) 
    {
        b.SetChecked(b.Const(@checked));
    }
    public static void SetChecked(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b) 
    {
        b.SetChecked(b.Const(true));
    }
    public static void SetHidden(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b, Metapsi.Syntax.Var<bool> hidden) 
    {
        b.SetProperty(b.Props, b.Const("hidden"), hidden);
    }
    public static void SetHidden(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b, bool hidden) 
    {
        b.SetHidden(b.Const(hidden));
    }
    public static void SetHidden(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b) 
    {
        b.SetHidden(b.Const(true));
    }
    public static void OnFluentChangeAction<TModel>(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenuItem> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) 
    {
        b.OnEventAction("change", action);
    }
}