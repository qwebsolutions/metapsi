using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Metapsi.Syntax
{
    public static class BlockBuilderExtensions
    {


        public static Var<Action> DefineAction<TBlockBuilder>(this TBlockBuilder b, System.Action<TBlockBuilder> builder)
            where TBlockBuilder : BlockBuilder, new()
        {
            var action = b.PlaceDefinition(builder);
            if (!action.alreadyDefined)
            {
                b.ModuleBuilder.BuildActionBody(action.functionRef, builder);
            }
            return new(action.functionRef.Name);
        }

        public static Var<Action<P1>> DefineAction<TBlockBuilder, P1>(this TBlockBuilder b, System.Action<TBlockBuilder, Var<P1>> builder)
            where TBlockBuilder : BlockBuilder, new()
        {
            var action = b.PlaceDefinition(builder);
            if (!action.alreadyDefined)
            {
                b.ModuleBuilder.BuildActionBody(action.functionRef, builder);
            }
            return new(action.functionRef.Name);
        }

        public static Var<Action<P1, P2>> DefineAction<TBlockBuilder, P1, P2>(this TBlockBuilder b, System.Action<TBlockBuilder, Var<P1>, Var<P2>> builder)
            where TBlockBuilder : BlockBuilder, new()
        {
            var action = b.PlaceDefinition(builder);
            if (!action.alreadyDefined)
            {
                b.ModuleBuilder.BuildActionBody(action.functionRef, builder);
            }
            return new(action.functionRef.Name);
        }

        public static Var<Action<P1, P2, P3>> DefineAction<TBlockBuilder, P1, P2, P3>(this TBlockBuilder b, System.Action<TBlockBuilder, Var<P1>, Var<P2>, Var<P3>> builder)
            where TBlockBuilder: BlockBuilder, new()
        {
            var action = b.PlaceDefinition(builder);
            if (!action.alreadyDefined)
            {
                b.ModuleBuilder.BuildActionBody(action.functionRef, builder);
            }
            return new(action.functionRef.Name);
        }

        public static Var<Action<P1, P2, P3, P4>> DefineAction<TBlockBuilder, P1, P2, P3, P4>(this TBlockBuilder b,System.Action<TBlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> builder)
            where TBlockBuilder: BlockBuilder, new()
        {
            var action = b.PlaceDefinition(builder);
            if (!action.alreadyDefined)
            {
                b.ModuleBuilder.BuildActionBody(action.functionRef, builder);
            }
            return new(action.functionRef.Name);
        }


        public static Var<Func<P1, P2, P3, TOut>> DefineFunc<TBlockBuilder, P1, P2, P3, TOut>(this TBlockBuilder b, System.Func<TBlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> builder)
            where TBlockBuilder : BlockBuilder, new()
        {
            var func = b.PlaceDefinition(builder);
            if (!func.alreadyDefined)
            {
                b.ModuleBuilder.BuildFuncBody(func.functionRef, builder);
            }
            return new(func.functionRef.Name);
        }

        public static Var<Func<P1, P2, TOut>> DefineFunc<TBlockBuilder, P1, P2, TOut>(this TBlockBuilder b,System.Func<TBlockBuilder, Var<P1>, Var<P2>, Var<TOut>> builder)
            where TBlockBuilder: BlockBuilder, new()
        {
            var func = b.PlaceDefinition(builder);
            if (!func.alreadyDefined)
            {
                b.ModuleBuilder.BuildFuncBody(func.functionRef, builder);
            }
            return new(func.functionRef.Name);
        }

        public static Var<Func<P1, TOut>> DefineFunc<TBlockBuilder, P1, TOut>(this TBlockBuilder b, System.Func<TBlockBuilder, Var<P1>, Var<TOut>> builder)
            where TBlockBuilder : BlockBuilder, new()
        {
            var func = b.PlaceDefinition(builder);
            if (!func.alreadyDefined)
            {
                b.ModuleBuilder.BuildFuncBody(func.functionRef, builder);
            }
            return new(func.functionRef.Name);
        }

        public static Var<Func<TOut>> DefineFunc<TBlockBuilder, TOut>(this TBlockBuilder b, System.Func<TBlockBuilder, Var<TOut>> builder)
            where TBlockBuilder : BlockBuilder, new()
        {
            var func = b.PlaceDefinition(builder);
            if (!func.alreadyDefined)
            {
                b.ModuleBuilder.BuildFuncBody(func.functionRef, builder);
            }
            return new(func.functionRef.Name);
        }

        public static void If<T>(this T b, Var<bool> varIsTrue, Action<T> bTrue, Action<T> bFalse = null)
            where T : IBlockBuilder, new()
        {
            var ifBlock = new IfBlock() { Var = varIsTrue };

            T blockBuilder = BlockBuilder.New<T>(b.ModuleBuilder, ifBlock.TrueBlock);
            bTrue(blockBuilder);
            if (bFalse != null)
            {
                ifBlock.FalseBlock = new();
                blockBuilder = BlockBuilder.New<T>(b.ModuleBuilder, ifBlock.FalseBlock);
                bFalse(blockBuilder);
            }
            b.Block.Lines.Add(ifBlock);
        }

        public static Var<TResult> If<TBuilder, TResult>(
            this TBuilder b,
            Var<bool> varIsTrue,
            Func<TBuilder, Var<TResult>> bTrue, Func<TBuilder, Var<TResult>> bFalse)
            where TBuilder : BlockBuilder, new()
        {
            Var<Reference<TResult>> outRef = b.NewObj<Reference<TResult>>();

            b.If(varIsTrue,
                b => { b.Set(outRef, x => x.Value, bTrue(b)); },
                b => { b.Set(outRef, x => x.Value, bFalse(b)); });

            return b.Get(outRef, x => x.Value);
        }

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

        public static void Foreach<TBuilder, T>(this TBuilder b, Var<List<T>> collection, Action<TBuilder, Var<T>> build)
            where TBuilder : BlockBuilder, new()
        {
            var foreachBlock = new ForeachBlock<T>()
            {
                Collection = collection,
                OverVariable = new Var<T>(b.NewName())
            };

            TBuilder blockBuilder = BlockBuilder.New<TBuilder>(b.ModuleBuilder, foreachBlock.ChildBlock);
            build(blockBuilder, foreachBlock.OverVariable);
            b.Block.Lines.Add(foreachBlock);
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

        public static void SetRef<TBlockBuilder, T>(this TBlockBuilder b, Var<Reference<T>> reference, Var<T> value)
            where TBlockBuilder : BlockBuilder
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

        public static Var<List<TItem>> Filter<TBlockBuiler, TItem>(this TBlockBuiler b, Var<List<TItem>> list, Var<Func<TItem, bool>> predicate)
            where TBlockBuiler: BlockBuilder, new()
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

        public static Var<List<T>> Filter<T>(this BlockBuilder b, Var<List<T>> list, Func<BlockBuilder, Var<T>, Var<bool>> predicate)
        {
            return b.Filter(list, b.Def(predicate));
        }

        public static Var<List<TOut>> Map<TBlockBuilder, TIn,TOut>(this TBlockBuilder b, Var<List<TIn>> list, Var<Func<TIn, TOut>> transform)
            where TBlockBuilder: BlockBuilder, new()
        {
            var outList = b.NewObj<List<TOut>>();
            b.Foreach(list, (b, item) =>
            {
                b.Push(outList, b.Call(transform, item));
            });

            return outList;
        }

        public static Var<List<TOut>> Map<TBlockBuilder, TIn, TOut>(this TBlockBuilder b, Var<List<TIn>> list, Func<TBlockBuilder, Var<TIn>, Var<TOut>> transform)
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.Map(list, b.Def(transform));
        }
    }
}

