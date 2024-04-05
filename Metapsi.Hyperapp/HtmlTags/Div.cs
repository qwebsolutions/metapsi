using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Hyperapp
{
    public static partial class LayoutBuilderExtensions
    {
        //public static Var<IVNode> Div(this LayoutBuilder b, string css, params Var<IVNode>[] children)
        //{
        //    return b.H(
        //        "div",
        //        (b, props) => b.SetClass(props, css),
        //        children);
        //}

        //public static Var<IVNode> Div(this LayoutBuilder b, string css, Var<List<IVNode>> children)
        //{
        //    var props = b.NewObj<DynamicObject>();
        //    b.SetDynamic(props, Html.@class, b.Const(css));
        //    return b.H(
        //        b.Const("div"),
        //        props,
        //        children);
        //}

        //public static Var<IVNode> Span(this LayoutBuilder b, string css, params Var<IVNode>[] children)
        //{
        //    return b.H(
        //        "span",
        //        (b, props) => b.SetClass(props, css),
        //        children);
        //}

        //public static Var<IVNode> SvgNew(this LayoutBuilder b, string css, string svgIcon)
        //{
        //    var props = b.NewObj<DynamicObject>();
        //    b.SetDynamic(props, Html.@class, b.Const(css));
        //    b.SetDynamic(props, Html.innerHTML, b.Const(svgIcon));
        //    return b.Div(props);
        //}
    }
}
