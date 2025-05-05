////using System;
////using System.Collections.Generic;
////using System.Linq.Expressions;

////namespace Metapsi.Module
////{
////    public static class SyntaxBuilderExtensions
////    {
////        /// <summary>
////        /// Creates an empty object
////        /// </summary>
////        /// <param name="b"></param>
////        /// <returns></returns>
////        public static Var<DynamicObject> NewObj(this SyntaxBuilder b)
////        {
////            return b.NewObj<DynamicObject>();
////        }

////        internal static void DebugComment(this BlockBuilder b, string comment)
////        {
////#if DEBUG
////            b.Comment(comment);
////#endif
////        }

////        public static void DebugComment(this SyntaxBuilder b, string comment)
////        {
////            b.blockBuilder.DebugComment(comment);
////        }

////        public static Var<TResult> If<TSyntaxBuilder, TResult>(
////            this TSyntaxBuilder b,
////            Var<bool> varIsTrue,
////            Func<TSyntaxBuilder, Var<TResult>> bTrue, Func<TSyntaxBuilder, Var<TResult>> bFalse)
////            where TSyntaxBuilder : SyntaxBuilder, new()
////        {
////            Var<Reference<TResult>> outRef = b.NewObj<Reference<TResult>>();

////            b.If(varIsTrue,
////                b => { b.Set(outRef, x => x.Value, bTrue(b)); },
////                b => { b.Set(outRef, x => x.Value, bFalse(b)); });

////            return b.Get(outRef, x => x.Value);
////        }

////        public static void If<TSyntaxBuilder>(
////            this TSyntaxBuilder syntaxBuilder,
////            Var<bool> varIsTrue,
////            Action<TSyntaxBuilder> bTrue)
////            where TSyntaxBuilder : SyntaxBuilder, new()
////        {
////            syntaxBuilder.blockBuilder.If(
////                varIsTrue,
////                b => bTrue(SyntaxBuilder.New<TSyntaxBuilder>(b, syntaxBuilder)));
////        }

////        public static void If<TSyntaxBuilder>(
////            this TSyntaxBuilder syntaxBuilder,
////            Var<bool> varIsTrue,
////            Action<TSyntaxBuilder> bTrue,
////            Action<TSyntaxBuilder> bFalse)
////            where TSyntaxBuilder : SyntaxBuilder, new()
////        {
////            syntaxBuilder.blockBuilder.If(
////                varIsTrue,
////                b => bTrue(SyntaxBuilder.New<TSyntaxBuilder>(b, syntaxBuilder)),
////                b => bFalse(SyntaxBuilder.New<TSyntaxBuilder>(b, syntaxBuilder)));
////        }

////        public static void Foreach<TSyntaxBuilder, T>(
////            this TSyntaxBuilder syntaxBuilder,
////            Var<List<T>> collection, Action<TSyntaxBuilder, Var<T>> build)
////            where TSyntaxBuilder : SyntaxBuilder, new()
////        {
////            syntaxBuilder.blockBuilder.Foreach(collection, (b, var) => build(SyntaxBuilder.New<TSyntaxBuilder>(b, syntaxBuilder), var));
////        }

////        public static void Foreach<TSyntaxBuilder, T>(
////            this TSyntaxBuilder b,
////            Var<List<T>> collection,
////            Action<TSyntaxBuilder, Var<T>, Var<int>> action)
////            where TSyntaxBuilder : SyntaxBuilder, new()
////        {
////            var index = b.Ref(b.Const(0));
////            b.Foreach(collection, (b, item) =>
////            {
////                b.Call(action, item, b.GetRef(index));
////                b.SetRef(index, b.Get(b.GetRef(index), x => x + 1));
////            });
////        }



////        public static Var<TResult> Get<TInput, TResult>(
////            this SyntaxBuilder b,
////            Var<TInput> input,
////            Expression<Func<TInput, TResult>> expr,
////            TResult defaultValue)
////        {
////            var v = b.Get(input, expr);
////            var outRef = b.Ref(v);
////            b.If(b.IsEmpty(v.As<object>()), b => b.SetRef(outRef, b.Const(defaultValue)));
////            return b.GetRef(outRef);
////        }

////        public static Var<TResult> Switch<TSyntaxBuilder, TResult, TInput>(
////            this TSyntaxBuilder b,
////            Var<TInput> v,
////            Func<TSyntaxBuilder, Var<TResult>> @default,
////            params (TInput, Func<TSyntaxBuilder, Var<TResult>>)[] cases)
////            where TSyntaxBuilder : SyntaxBuilder, new()
////        {
////            var caseFuncRef = b.Ref(b.Def(@default));

////            foreach (var @case in cases)
////            {
////                var eq = b.AreEqual(v, b.Const(@case.Item1));
////                b.If(eq, b => b.SetRef(caseFuncRef, b.Def(@case.Item2)));
////            }

////            return b.Call(b.GetRef(caseFuncRef));
////        }

////        public static void SetIfEmpty<TObj, TProp>(
////            this SyntaxBuilder b,
////            Var<TObj> onObject,
////            System.Linq.Expressions.Expression<Func<TObj, TProp>> onProperty,
////            Var<TProp> val)
////        {
////            b.If(b.Not(b.HasObject(b.Get(onObject, onProperty))),
////                b =>
////                {
////                    b.Set(onObject, onProperty, val);
////                });
////        }

////    }
////}

