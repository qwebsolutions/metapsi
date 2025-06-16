using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

///// <summary>
///// 
///// </summary>
//public class HyperappCustomElementProps<TModel>
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    public Func<SyntaxBuilder, Var<Element>, Var<HyperType.StateWithEffects>> Init { get; set; }
//    /// <summary>
//    /// 
//    /// </summary>
//    public Func<LayoutBuilder, string, Var<TModel>, Var<IVNode>> Render { get; set; }
//    /// <summary>
//    /// 
//    /// </summary>
//    public List<Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>> Subscriptions { get; set; }
//}

//public static partial class CustomElementExtensions
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    /// <typeparam name="TModel"></typeparam>
//    /// <param name="b"></param>
//    /// <param name="model"></param>
//    public static void SetInitModel<TModel>(
//        this PropsBuilder<HyperappCustomElementProps<TModel>> b,
//        Var<TModel> model)
//    {
//        b.Set(x => x.Init, b.MakeInit(b.Def((SyntaxBuilder b, Var<Element> e) => model)));
//    }
//}
