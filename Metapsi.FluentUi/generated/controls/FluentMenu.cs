using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentMenu
{
    public static class Slot
    {
        public const string PrimaryAction = "primary-action";
        public const string Trigger = "trigger";
    }
}
public static partial class FluentMenuExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMenu(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentMenu>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-menu", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMenu(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentMenu>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentMenu(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentMenu(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentMenu(b => { }, children);
    }
    public static void SetOpenOnHover(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<bool> openOnHover) 
    {
        b.SetProperty(b.Props, b.Const("openOnHover"), openOnHover);
    }
    public static void SetOpenOnHover(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, bool openOnHover) 
    {
        b.SetOpenOnHover(b.Const(openOnHover));
    }
    public static void SetOpenOnHover(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b) 
    {
        b.SetOpenOnHover(b.Const(true));
    }
    public static void SetOpenOnContext(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<bool> openOnContext) 
    {
        b.SetProperty(b.Props, b.Const("openOnContext"), openOnContext);
    }
    public static void SetOpenOnContext(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, bool openOnContext) 
    {
        b.SetOpenOnContext(b.Const(openOnContext));
    }
    public static void SetOpenOnContext(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b) 
    {
        b.SetOpenOnContext(b.Const(true));
    }
    public static void SetCloseOnScroll(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<bool> closeOnScroll) 
    {
        b.SetProperty(b.Props, b.Const("closeOnScroll"), closeOnScroll);
    }
    public static void SetCloseOnScroll(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, bool closeOnScroll) 
    {
        b.SetCloseOnScroll(b.Const(closeOnScroll));
    }
    public static void SetCloseOnScroll(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b) 
    {
        b.SetCloseOnScroll(b.Const(true));
    }
    public static void SetPersistOnItemClick(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<bool> persistOnItemClick) 
    {
        b.SetProperty(b.Props, b.Const("persistOnItemClick"), persistOnItemClick);
    }
    public static void SetPersistOnItemClick(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, bool persistOnItemClick) 
    {
        b.SetPersistOnItemClick(b.Const(persistOnItemClick));
    }
    public static void SetPersistOnItemClick(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b) 
    {
        b.SetPersistOnItemClick(b.Const(true));
    }
    public static void SetSplit(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<bool> split) 
    {
        b.SetProperty(b.Props, b.Const("split"), split);
    }
    public static void SetSplit(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, bool split) 
    {
        b.SetSplit(b.Const(split));
    }
    public static void SetSplit(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b) 
    {
        b.SetSplit(b.Const(true));
    }
    public static void SetSlottedMenuList(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Collections.Generic.List<FluentMenuList>> slottedMenuList) 
    {
        b.SetProperty(b.Props, b.Const("slottedMenuList"), slottedMenuList);
    }
    public static void SetSlottedTriggers(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Collections.Generic.List<HTMLElement>> slottedTriggers) 
    {
        b.SetProperty(b.Props, b.Const("slottedTriggers"), slottedTriggers);
    }
    public static void SetPrimaryAction(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<HTMLSlotElement> primaryAction) 
    {
        b.SetProperty(b.Props, b.Const("primaryAction"), primaryAction);
    }
    public static void SetToggleMenu(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Action> toggleMenu) 
    {
        b.SetProperty(b.Props, b.Const("toggleMenu"), toggleMenu);
    }
    public static void SetCloseMenu(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Action<Event>> closeMenu) 
    {
        b.SetProperty(b.Props, b.Const("closeMenu"), closeMenu);
    }
    public static void SetOpenMenu(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Action<Event>> openMenu) 
    {
        b.SetProperty(b.Props, b.Const("openMenu"), openMenu);
    }
    public static void SetToggleHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Action<Event>> toggleHandler) 
    {
        b.SetProperty(b.Props, b.Const("toggleHandler"), toggleHandler);
    }
    public static void SetOpenOnHoverChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Action<bool, bool>> openOnHoverChanged) 
    {
        b.SetProperty(b.Props, b.Const("openOnHoverChanged"), openOnHoverChanged);
    }
    public static void SetPersistOnItemClickChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Action<bool, bool>> persistOnItemClickChanged) 
    {
        b.SetProperty(b.Props, b.Const("persistOnItemClickChanged"), persistOnItemClickChanged);
    }
    public static void SetOpenOnContextChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Action<bool, bool>> openOnContextChanged) 
    {
        b.SetProperty(b.Props, b.Const("openOnContextChanged"), openOnContextChanged);
    }
    public static void SetCloseOnScrollChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Action<bool, bool>> closeOnScrollChanged) 
    {
        b.SetProperty(b.Props, b.Const("closeOnScrollChanged"), closeOnScrollChanged);
    }
    public static void SetMenuKeydownHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Func<KeyboardEvent, bool>> menuKeydownHandler) 
    {
        b.SetProperty(b.Props, b.Const("menuKeydownHandler"), menuKeydownHandler);
    }
    public static void SetMenuKeydownHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Action<KeyboardEvent>> menuKeydownHandler) 
    {
        b.SetProperty(b.Props, b.Const("menuKeydownHandler"), menuKeydownHandler);
    }
    public static void SetTriggerKeydownHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Func<KeyboardEvent, bool>> triggerKeydownHandler) 
    {
        b.SetProperty(b.Props, b.Const("triggerKeydownHandler"), triggerKeydownHandler);
    }
    public static void SetTriggerKeydownHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentMenu> b, Metapsi.Syntax.Var<System.Action<KeyboardEvent>> triggerKeydownHandler) 
    {
        b.SetProperty(b.Props, b.Const("triggerKeydownHandler"), triggerKeydownHandler);
    }
    public static void SetComponent(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentMenu> b) 
    {
        b.Call("setComponent");
    }
    public static void FocusMenuList(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentMenu> b) 
    {
        b.Call("focusMenuList");
    }
    public static void FocusTrigger(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentMenu> b) 
    {
        b.Call("focusTrigger");
    }
}