using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Metapsi.Syntax
{
    public static class SyntaxBuilderExtensions
    {
        //public static void If<TSyntaxBuilder>(
        //    this TSyntaxBuilder b,
        //    Var<bool> varIsTrue, Action<TSyntaxBuilder> bTrue, Action<TSyntaxBuilder> bFalse = null)
        //    where TSyntaxBuilder : SyntaxBuilder
        //{
        //    b.If(varIsTrue, bTrue, bFalse);
        //}

        public static Var<TResult> If<TSyntaxBuilder, TResult>(
            this TSyntaxBuilder b,
            Var<bool> varIsTrue,
            Func<TSyntaxBuilder, Var<TResult>> bTrue, Func<TSyntaxBuilder, Var<TResult>> bFalse)
            where TSyntaxBuilder: SyntaxBuilder
        {
            Var<Reference<TResult>> outRef = b.NewObj<Reference<TResult>>();

            b.If(varIsTrue,
                b => { b.Set(outRef, x => x.Value, bTrue(b)); },
                b => { b.Set(outRef, x => x.Value, bFalse(b)); });

            return b.Get(outRef, x => x.Value);
        }

        public static void If<TSyntaxBuilder>(
            this TSyntaxBuilder syntaxBuilder,
            Var<bool> varIsTrue,
            Action<TSyntaxBuilder> bTrue,
            Action<TSyntaxBuilder> bFalse = null)
            where TSyntaxBuilder : SyntaxBuilder
        {
            syntaxBuilder.blockBuilder.If(
                varIsTrue,
                b => bTrue(syntaxBuilder),
                b => bFalse(syntaxBuilder));
        }

        public static void Foreach<TSyntaxBuilder, T>(
            this TSyntaxBuilder syntaxBuilder,
            Var<List<T>> collection, Action<TSyntaxBuilder, Var<T>> build)
            where TSyntaxBuilder : SyntaxBuilder
        {
            syntaxBuilder.blockBuilder.Foreach(collection, (b, var) => build(syntaxBuilder, var));
        }

        // Define global actions
        public static Var<Action> Def<TSyntaxBuilder>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.ModuleBuilder.DefineAction(name, builder).As<Action>();
        }

        public static Var<Action<P1>> Def<TSyntaxBuilder, P1>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.ModuleBuilder.DefineAction(name, builder).As<Action<P1>>();
        }

        public static Var<Action<P1, P2>> Def<TSyntaxBuilder, P1, P2>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.ModuleBuilder.DefineAction(name, builder).As<Action<P1, P2>>();
        }

        public static Var<Action<P1, P2, P3>> Def<TSyntaxBuilder, P1, P2, P3>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.ModuleBuilder.DefineAction(name, builder).As<Action<P1, P2, P3>>();
        }

        public static Var<Action<P1, P2, P3, P4>> Def<TSyntaxBuilder, P1, P2, P3, P4>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.ModuleBuilder.DefineAction(name, builder).As<Action<P1, P2, P3, P4>>();
        }

        // Define actions
        public static Var<Action> Def<TSyntaxBuilder>(this SyntaxBuilder b, Action<TSyntaxBuilder> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.DefineAction(builder).As<Action>();
        }

        public static Var<Action<P1>> Def<TSyntaxBuilder, P1>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.DefineAction(builder).As<Action<P1>>();
        }

        public static Var<Action<P1, P2>> Def<TSyntaxBuilder, P1, P2>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>> builder) 
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.DefineAction(builder).As<Action<P1, P2>>();
        }

        public static Var<Action<P1, P2, P3>> Def<TSyntaxBuilder, P1, P2, P3>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>> builder) 
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.DefineAction(builder).As<Action<P1, P2, P3>>();
        }

        public static Var<Action<P1, P2, P3, P4>> Def<TSyntaxBuilder, P1, P2, P3, P4>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> builder) 
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.DefineAction(builder).As<Action<P1, P2, P3, P4>>();
        }


        // Define global functions

        public static Var<Func<TOut>> Def<TSyntaxBuilder, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.ModuleBuilder.DefineFunc(name, builder).As<Func<TOut>>();
        }

        public static Var<Func<P1, TOut>> Def<TSyntaxBuilder, P1, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.ModuleBuilder.DefineFunc(name, builder).As<Func<P1, TOut>>();
        }

        public static Var<Func<P1, P2, TOut>> Def<TSyntaxBuilder, P1, P2, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.ModuleBuilder.DefineFunc(name, builder).As<Func<P1, P2, TOut>>();
        }

        public static Var<Func<P1, P2, P3, TOut>> Def<TSyntaxBuilder, P1, P2, P3, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.ModuleBuilder.DefineFunc(name, builder).As<Func<P1, P2, P3, TOut>>();
        }

        // Define functions

        public static Var<Func<TOut>> Def<TSyntaxBuilder, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<TOut>> builder)
            where TSyntaxBuilder: SyntaxBuilder
        {
            return b.blockBuilder.DefineFunc(builder).As<Func<TOut>>();
        }

        public static Var<Func<P1, TOut>> Def<TSyntaxBuilder, P1, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<TOut>> builder) 
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.DefineFunc(builder).As<Func<P1, TOut>>();
        }

        public static Var<Func<P1, P2, TOut>> Def<TSyntaxBuilder, P1, P2, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<TOut>> builder) 
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.DefineFunc(builder).As<Func<P1, P2, TOut>>();
        }

        public static Var<Func<P1, P2, P3, TOut>> Def<TSyntaxBuilder, P1, P2, P3, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.blockBuilder.DefineFunc(builder).As<Func<P1, P2, P3, TOut>>();
        }

        // Call actions

        public static void Call(this SyntaxBuilder b, Var<Action> action)
        {
            b.blockBuilder.CallAction(action);
        }

        public static void Call<P1>(this SyntaxBuilder b, Var<Action<P1>> action, Var<P1> p1)
        {
            b.blockBuilder.CallAction(action, p1);
        }

        public static void Call<P1, P2>(this SyntaxBuilder b, Var<Action<P1,P2>> action, Var<P1> p1, Var<P2> p2)
        {
            b.blockBuilder.CallAction(action, p1, p2);
        }

        public static void Call<P1, P2, P3>(this SyntaxBuilder b, Var<Action<P1, P2, P3>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3)
        {
            b.blockBuilder.CallAction(action, p1, p2, p3);
        }

        public static void Call<P1, P2, P3, P4>(this SyntaxBuilder b, Var<Action<P1, P2, P3, P4>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
        {
            b.blockBuilder.CallAction(action, p1, p2, p3, p4);
        }

        // Call functions

        public static Var<TOut> Call<TOut>(this SyntaxBuilder b, Var<Func<TOut>> func)
        {
            return b.blockBuilder.CallFunction<TOut>(func);
        }

        public static Var<TOut> Call<P1, TOut>(this SyntaxBuilder b, Var<Func<P1, TOut>> func, Var<P1> p1)
        {
            return b.blockBuilder.CallFunction<TOut>(func, p1);
        }

        public static Var<TOut> Call<P1, P2, TOut>(this SyntaxBuilder b, Var<Func<P1, P2, TOut>> func, Var<P1> p1, Var<P2> p2)
        {
            return b.blockBuilder.CallFunction<TOut>(func, p1, p2);
        }

        public static Var<TOut> Call<P1, P2, P3, TOut>(this SyntaxBuilder b, Var<Func<P1, P2, P3, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3) 
        {
            return b.blockBuilder.CallFunction<TOut>(func, p1, p2, p3);
        }

        // Define & call actions

        public static void Call<TSyntaxBuilder>(this SyntaxBuilder b, Action<TSyntaxBuilder> action)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action));
        }

        public static void Call<TSyntaxBuilder, P1>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>> action, Var<P1> p1)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1);
        }

        public static void Call<TSyntaxBuilder,P1, P2>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>> action, Var<P1> p1, Var<P2> p2)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3, P4>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4) 
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3, p4);
        }

        // Define & call functions

        public static Var<TOut> Call<TSyntaxBuilder, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<TOut>> func)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def<TSyntaxBuilder, TOut>(func));
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<TOut>> func, Var<P1> p1)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def(func), p1);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<TOut>> func, Var<P1> p1, Var<P2> p2)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3)
            where TSyntaxBuilder: SyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3);
        }

        public static Var<TResult> Get<TInput, TResult>(
            this SyntaxBuilder b,
            Var<TInput> input,
            Expression<Func<TInput, TResult>> expr,
            TResult defaultValue)
        {
            var v = b.Get(input, expr);
            var outRef = b.Ref(v);
            b.If(b.IsEmpty(v.As<object>()), b => b.SetRef(outRef, b.Const(defaultValue)));
            return b.GetRef(outRef);
        }

        public static void Foreach<T>(
            this SyntaxBuilder b,
            Var<List<T>> collection,
            Action<SyntaxBuilder, Var<T>, Var<int>> action)
        {
            var index = b.Ref(b.Const(0));
            b.Foreach(collection, (b, item) =>
            {
                b.Call(action, item, b.GetRef(index));
                b.SetRef(index, b.Get(b.GetRef(index), x => x + 1));
            });
        }

        public static Var<TResult> Switch<TSyntaxBuilder, TResult, TInput>(
            this TSyntaxBuilder b,
            Var<TInput> v,
            Func<TSyntaxBuilder, Var<TResult>> @default,
            params (TInput, Func<TSyntaxBuilder, Var<TResult>>)[] cases)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Comment($"case default");
            var resultContainer = b.Ref(@default(b));

            foreach (var @case in cases)
            {
                b.Comment($"case {@case.Item1}");
                var eq = b.AreEqual(v, b.Const(@case.Item1));
                b.If(eq, b => b.SetRef(resultContainer, @case.Item2(b)));
            }

            return b.GetRef(resultContainer);
        }

        public static void SetIfEmpty<TObj, TProp>(
            this SyntaxBuilder b,
            Var<TObj> onObject,
            System.Linq.Expressions.Expression<Func<TObj, TProp>> onProperty,
            Var<TProp> val)
        {
            b.If(b.Not(b.HasObject(b.Get(onObject, onProperty))),
                b =>
                {
                    b.Set(onObject, onProperty, val);
                });
        }

        public static Var<Reference<T>> Ref<T>(this SyntaxBuilder b, Var<T> value)
        {
            return b.NewObj<Reference<T>>(b => b.Set(x => x.Value, value));
        }

        public static void SetRef<TSyntaxBuilder, T>(this TSyntaxBuilder b, Var<Reference<T>> reference, Var<T> value)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Set(reference, x => x.Value, value);
        }

        public static Var<T> GetRef<T>(this SyntaxBuilder b, Var<Reference<T>> reference)
        {
            return b.Get(reference, x => x.Value);
        }

        public static Var<T> As<T>(this IVariable variable)
        {
            return new Var<T>(variable.Name);
        }

        public static Var<List<TItem>> Filter<TItem>(this SyntaxBuilder b, Var<List<TItem>> list, Var<Func<TItem, bool>> predicate)
        {
            var outList = b.NewObj<List<TItem>>();
            b.Foreach(list, (b, item) =>
            {
                b.If(
                    b.Call(predicate, item),
                    b =>
                    {
                        b.Push(outList, item);
                    });
            });

            return outList;
        }

        public static Var<List<T>> Filter<T>(this SyntaxBuilder b, Var<List<T>> list, Func<SyntaxBuilder, Var<T>, Var<bool>> predicate)
        {
            return b.Filter(list, b.Def(predicate));
        }

        public static Var<List<TOut>> Map<TSyntaxBuilder, TIn, TOut>(this TSyntaxBuilder b, Var<List<TIn>> list, Var<Func<TIn, TOut>> transform)
            where TSyntaxBuilder : SyntaxBuilder
        {
            var outList = b.NewObj<List<TOut>>();
            b.Foreach(list, (b, item) =>
            {
                b.Push(outList, b.Call(transform, item));
            });

            return outList;
        }

        public static Var<List<TOut>> Map<TSyntaxBuilder, TIn, TOut>(this TSyntaxBuilder b, Var<List<TIn>> list, Func<TSyntaxBuilder, Var<TIn>, Var<TOut>> transform)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Map(list, b.Def(transform));
        }

    }
}

