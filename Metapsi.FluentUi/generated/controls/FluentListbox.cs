using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentListbox
{
    public static class Slot
    {
    }
}
public static partial class FluentListboxExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentListbox(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentListbox>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-listbox", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentListbox(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentListbox>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentListbox(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentListbox(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentListbox(b => { }, children);
    }
    public static void SetId(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentListbox> b, Metapsi.Syntax.Var<string> id) 
    {
        b.SetProperty(b.Props, b.Const("id"), id);
    }
    public static void SetId(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentListbox> b, string id) 
    {
        b.SetId(b.Const(id));
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentListbox> b, Metapsi.Syntax.Var<bool> multiple) 
    {
        b.SetProperty(b.Props, b.Const("multiple"), multiple);
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentListbox> b, bool multiple) 
    {
        b.SetMultiple(b.Const(multiple));
    }
    public static void SetMultiple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentListbox> b) 
    {
        b.SetMultiple(b.Const(true));
    }
    public static void SetMultipleChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentListbox> b, Metapsi.Syntax.Var<System.Action<bool, bool>> multipleChanged) 
    {
        b.SetProperty(b.Props, b.Const("multipleChanged"), multipleChanged);
    }
    public static void SetOptions(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentListbox> b, Metapsi.Syntax.Var<System.Collections.Generic.List<FluentDropdownOption>> options) 
    {
        b.SetProperty(b.Props, b.Const("options"), options);
    }
    public static void SetSelectedOptions(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentListbox> b, Metapsi.Syntax.Var<System.Collections.Generic.List<FluentDropdownOption>> selectedOptions) 
    {
        b.SetProperty(b.Props, b.Const("selectedOptions"), selectedOptions);
    }
    public static void SetClickHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentListbox> b, Metapsi.Syntax.Var<System.Func<PointerEvent, bool>> clickHandler) 
    {
        b.SetProperty(b.Props, b.Const("clickHandler"), clickHandler);
    }
    public static void SetClickHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentListbox> b, Metapsi.Syntax.Var<System.Action<PointerEvent>> clickHandler) 
    {
        b.SetProperty(b.Props, b.Const("clickHandler"), clickHandler);
    }
    public static void SetSlotchangeHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentListbox> b, Metapsi.Syntax.Var<System.Action<Event>> slotchangeHandler) 
    {
        b.SetProperty(b.Props, b.Const("slotchangeHandler"), slotchangeHandler);
    }
    public static void SelectOption(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentListbox> b, Metapsi.Syntax.Var<int> index) 
    {
        b.Call("selectOption", index);
    }
}