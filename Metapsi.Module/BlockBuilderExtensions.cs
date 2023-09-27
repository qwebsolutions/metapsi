using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Metapsi.Syntax
{
    public static class BlockBuilderExtensions
    {
        public static Var<TResult> Get<TInput, TResult>(
            this BlockBuilder b,
            Var<TInput> input,
            LambdaExpression expression)
        {
            b.ModuleBuilder.AddImport("linq", "Enumerable");
            var constExpr = b.ModuleBuilder.AddExpression(expression);
            return b.CallFunction<TResult>(constExpr, input);
        }

        public static Var<TResult> Get<TInput, TResult>(
            this BlockBuilder b,
            Var<TInput> input,
            Expression<Func<TInput, TResult>> expression)
        {
            b.ModuleBuilder.AddImport("linq", "Enumerable");
            var constExpr = b.ModuleBuilder.AddExpression(expression);
            return b.CallFunction<TResult>(constExpr, input);
        }

        public static Var<TResult> Get<TInput, TResult>(
            this BlockBuilder b,
            Var<TInput> input,
            Expression<Func<TInput, TResult>> expr,
            TResult defaultValue)
        {
            var v = b.Get(input, expr);
            var outRef = b.Ref(v);
            b.If(b.IsEmpty(v.As<object>()), b => b.SetRef(outRef, b.Const(defaultValue)));
            return b.GetRef(outRef);
        }

        public static Var<TResult> Get<TInput1, TInput2, TResult>(
            this BlockBuilder b,
            Var<TInput1> input1,
            Var<TInput2> input2,
            Expression<Func<TInput1, TInput2, TResult>> expression)
        {
            b.ModuleBuilder.AddImport("linq", "Enumerable");
            var constExpr = b.ModuleBuilder.AddExpression(expression);
            return b.CallFunction<TResult>(constExpr, input1, input2);
        }

        public static Var<TResult> Get<TInput1, TInput2, TInput3, TResult>(
            this BlockBuilder b,
            Var<TInput1> input1,
            Var<TInput2> input2,
            Var<TInput3> input3,
            Expression<Func<TInput1, TInput2, TInput3, TResult>> expression)
        {
            b.ModuleBuilder.AddImport("linq", "Enumerable");
            var constExpr = b.ModuleBuilder.AddExpression(expression);
            return b.CallFunction<TResult>(constExpr, input1, input2, input3);
        }

        public static Var<TResult> Get<TInput1, TInput2, TInput3, TInput4, TResult>(
            this BlockBuilder b,
            Var<TInput1> input1,
            Var<TInput2> input2,
            Var<TInput3> input3,
            Var<TInput4> input4,
            Expression<Func<TInput1, TInput2, TInput3, TInput4, TResult>> expression)
        {
            b.ModuleBuilder.AddImport("linq", "Enumerable");
            var constExpr = b.ModuleBuilder.AddExpression(expression);
            return b.CallFunction<TResult>(constExpr, input1, input2, input3, input4);
        }

        public static Var<TResult> Get<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>(
            this BlockBuilder b,
            Var<TInput1> input1,
            Var<TInput2> input2,
            Var<TInput3> input3,
            Var<TInput4> input4,
            Var<TInput5> input5,
            Expression<Func<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>> expression)
        {
            b.ModuleBuilder.AddImport("linq", "Enumerable");
            var constExpr = b.ModuleBuilder.AddExpression(expression);
            return b.CallFunction<TResult>(constExpr, input1, input2, input3, input4, input5);
        }

        public static void Foreach<T>(
            this BlockBuilder b,
            Var<List<T>> collection,
            Action<BlockBuilder, Var<T>, Var<int>> action)
        {
            var index = b.Ref(b.Const(0));
            b.Foreach(collection, (b, item) =>
            {
                b.Call(action, item, b.GetRef(index));
                b.SetRef(index, b.Get(b.GetRef(index), x => x + 1));
            });
        }

        public static Var<TResult> Switch<TResult, TInput>(
            this BlockBuilder b,
            Var<TInput> v,
            Func<BlockBuilder, Var<TResult>> @default,
            params (TInput, Func<BlockBuilder, Var<TResult>>)[] cases)
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
            this BlockBuilder b,
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

        public static Var<Reference<T>> Ref<T>(this BlockBuilder b, Var<T> value)
        {
            return b.NewObj<Reference<T>>(b => b.Set(x => x.Value, value));
        }

        public static void SetRef<T>(this BlockBuilder b, Var<Reference<T>> reference, Var<T> value)
        {
            b.Set(reference, x => x.Value, value);
        }

        public static Var<T> GetRef<T>(this BlockBuilder b, Var<Reference<T>> reference)
        {
            return b.Get(reference, x => x.Value);
        }

        public static Var<T> As<T>(this IVariable variable)
        {
            return new Var<T>(variable.Name);
        }

        public static Var<List<TOut>> Map<TIn,TOut>(this BlockBuilder b, Var<List<TIn>> list, Var<Func<TIn, TOut>> transform)
        {
            var outList = b.NewObj<List<TOut>>();
            b.Foreach(list, (b, item) =>
            {
                b.Push(outList, b.Call(transform, item));
            });

            return outList;
        }

        public static Var<List<TOut>> Map<TIn, TOut>(this BlockBuilder b, Var<List<TIn>> list, Func<BlockBuilder, Var<TIn>, Var<TOut>> transform)
        {
            return b.Map(list, b.Def(transform));
        }
    }
}

