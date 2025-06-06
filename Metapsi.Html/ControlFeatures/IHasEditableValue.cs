//using Metapsi.Hyperapp;
//using Metapsi.Syntax;
//using System;
//using System.Linq.Expressions;

//namespace Metapsi.Html;


//public static class NewBindingExtensions
//{
//    public static void BindTo<T>(this PropsBuilder<HtmlInput> b, Var<T> entity, System.Linq.Expressions.Expression<Func<T, string>> property)
//    {
//        b.Set(x => x.value, b.Get(entity, property));
//        b.OnEventAction("input", b.MakeAction((SyntaxBuilder b, Var<object> model, Var<InputEvent> e) =>
//        {
//            var value = b.Get(
//                b.Get(e, x => x.target).As<HTMLInputElement>(),
//                x => x.value);
//            b.Set(entity, property, value);
//            return b.Clone(model);
//        }));
//    }

//    public static void BindTo<TState, TControl, TValue>(this PropsBuilder<TControl> b, System.Linq.Expressions.Expression<Func<TState, TValue>> modelProperty)
//    {

//    }
//}