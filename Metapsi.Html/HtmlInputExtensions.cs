using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Html;

//public class HtmlCheckbox : IHasEditableValue<bool>
//{

//}

public static class HtmlInputExtensions
{
    public static void SetName(this AttributesBuilder<HtmlInput> b, string name)
    {
        b.SetAttribute("name", name);
    }

    public static void SetType(this AttributesBuilder<HtmlInput> b, string type)
    {
        b.SetAttribute("type", type);
    }

    public static void SetType(this PropsBuilder<HtmlInput> b, string type)
    {
        b.SetType(b.Const(type));
    }

    public static void SetType(this PropsBuilder<HtmlInput> b, Var<string> type)
    {
        b.SetAttribute("type", type);
    }

    public static void SetPlaceholder(this PropsBuilder<HtmlInput> b, Var<string> placeholder)
    {
        b.SetAttribute("placeholder", placeholder);
    }

    public static void SetPlaceholder(this PropsBuilder<HtmlInput> b, string placeholder)
    {
        b.SetPlaceholder(b.Const(placeholder));
    }

    public static void OnInputAction<TModel>(this PropsBuilder<HtmlInput> b, Var<HyperType.Action<TModel, Html.Event>> action)
    {
        b.OnEventAction("input", action);
    }

    public static void OnInputAction<TModel>(this PropsBuilder<HtmlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Html.Event>, Var<TModel>> action)
    {
        b.OnInputAction(b.MakeAction(action));
    }

    public static void OnInputAction<TModel>(this PropsBuilder<HtmlInput> b, Var<HyperType.Action<TModel, string>> action)
    {
        b.OnInputAction(b.MakeAction((SyntaxBuilder b, Var<TModel> model, Var<Html.Event> e) =>
        {
            return b.MakeActionDescriptor(action, b.GetTargetValue(e));
        }));
    }

    public static void OnInputAction<TModel>(this PropsBuilder<HtmlInput> b, System.Func<SyntaxBuilder, Var<TModel>, Var<string>, Var<TModel>> action)
    {
        b.OnInputAction(b.MakeAction(action));
    }

    //public static Var<IVNode> HtmlCheckbox(this LayoutBuilder b, System.Action<PropsBuilder<HtmlCheckbox>> buildProps, params Var<IVNode>[] children)
    //{
    //    return b.HtmlInput(
    //        b =>
    //        {
    //            b.SetProps(b.Props, buildProps);
    //            b.SetType("checkbox");
    //        },
    //        children);
    //}

    //public static void SetChecked(this PropsBuilder<HtmlCheckbox> b, Var<bool> isChecked)
    //{
    //    // 'checked' is special, as property it means 'current value', as attribute it means 'initial value'
    //    // Hyperapp requires it to always be set, even if false, otherwise it gets confused and doesn't know
    //    // it needs to change the value
    //    b.SetProperty(b.Props, b.Const("checked"), isChecked);
    //}
}