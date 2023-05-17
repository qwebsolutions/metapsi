using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Metapsi.Syntax
{
    public class Reference<T>
    {
        public T Value { get; set; }
    }

    public class BlockBuilder
    {
        public BlockBuilder(ModuleBuilder moduleBuilder, Block block)
        {
            this.ModuleBuilder = moduleBuilder;
            this.Block = block;
        }

        public Module Module { get => ModuleBuilder.Module; }

        public ModuleBuilder ModuleBuilder { get; private set; }

        public Block Block { get; set; }

        public string NewName()
        {
            return ModuleBuilder.NewName();
        }

        public Var<T> Const<T>(T constant)
        {
            return ModuleBuilder.Const(constant);
        }

        public Var<T> Const<T>(T constant, string name)
        {
            return ModuleBuilder.Const(constant, name);
        }

        public Var<T> NewObj<T>() where T : new()
        {
            Var<T> intoVar = new Var<T>(NewName());
            Block.Lines.Add(new ObjectConstructor<T>()
            {
                IntoVar = intoVar,
                From = new T(),
                Type = typeof(T)
            });

            return intoVar;
        }

        //public Var<string> EmptyString()
        //{
        //    Var<string> intoVar = new Var<string>() { Name = NewName() };
        //    Block.Lines.Add(new ObjectConstructor<string>()
        //    {
        //        IntoVar = intoVar,
        //        From = ""
        //    });

        //    return intoVar;
        //}

        public Var<T> NewObj<T>(T serverObject)
        {
            Var<T> intoVar = new Var<T>(NewName());
            Block.Lines.Add(new ObjectConstructor<T>()
            {
                IntoVar = intoVar,
                From = serverObject,
                Type = typeof(T)
            });

            return intoVar;
        }

        public Var<T> NewObj<T>(Action<Modifier<T>> init) where T : new()
        {
            var newObj = NewObj<T>();
            if (init != null)
            {
                init(new Modifier<T>(this, newObj));
            }
            return newObj;
        }

        public Var<List<T>> NewCollection<T>()
        {
            Var<List<T>> collection = new Var<List<T>>(NewName());
            Block.Lines.Add(new CollectionConstructor<T>()
            {
                IntoVar = collection
            });
            return collection;
        }

        public void CallAction(IVariable action, params IVariable[] arguments)
        {
            FunctionCall functionCall = new FunctionCall();
            functionCall.Function = action;
            functionCall.Arguments.AddRange(arguments);
            Block.Lines.Add(functionCall);
        }

        public Var<T> CallFunction<T>(IVariable function, params IVariable[] arguments)
        {
            var intoVar = new Var<T>(NewName());

            FunctionCall functionCall = new FunctionCall();
            functionCall.Function = function;
            functionCall.Arguments.AddRange(arguments);
            functionCall.IntoVariable = intoVar;
            Block.Lines.Add(functionCall);
            return intoVar;
        }

        public Var<TOut> CallExternal<TOut>(string module, string function, params IVariable[] arguments)
        {
            var import = ModuleBuilder.AddImport(module, function);
            return CallFunction<TOut>(import, arguments);
        }

        public void CallExternal(string module, string function, params IVariable[] arguments)
        {
            var import = ModuleBuilder.AddImport(module, function);
            CallAction(import, arguments);
        }

        private void Set(IVariable intoObject, IProperty property, IVariable newValue)
        {
            Block.Lines.Add(new PropertyAssignment()
            {
                FromVar = newValue == null ? Const("null") : newValue,
                ObjectVar = intoObject,
                Property = property
            });
        }

        private IVariable Get(IVariable fromVariable, IProperty property)
        {
            var outVar = new Var<dynamic>(NewName());
            Block.Lines.Add(new PropertyAccess
            {
                FromVar = fromVariable,
                IntoVar = outVar,
                Property = property
            });

            return outVar;
        }

        public void Set<TItem, TProp>(Var<TItem> var, Expression<Func<TItem, TProp>> access, Var<TProp> value)
        {
            if (!(access.Body is MemberExpression))
            {
                throw new Exception($"Expression {access} is not valid in setter. Setter can only be used on properties of accessor variable");
            }
            else if ((access.Body as MemberExpression).Expression is MemberExpression)
            {
                // If nested member expression
                throw new Exception($"Expression {access} is not valid in setter. Setter can only be used on properties of accessor variable");
            }

            Set(var, new Property()
            {
                InterfaceType = typeof(TItem),
                PropertyName = access.PropertyName()
            }, value);
        }

        public void Set<TDynamicItem, TProp>(Var<TDynamicItem> item, DynamicProperty<TProp> property, Var<TProp> value)
            where TDynamicItem : IDynamicObject
        {
            this.SetProperty(item, Const(property.PropertyName), value);
        }

        public Var<TProp> Get<TDynamicItem, TProp>(Var<TDynamicItem> item, DynamicProperty<TProp> property)
            where TDynamicItem : IDynamicObject
        {
            return this.GetProperty<TProp>(item, Const(property.PropertyName));
        }

        public void Foreach<T>(Var<List<T>> collection, Action<BlockBuilder, Var<T>> build)
        {
            var foreachBlock = new ForeachBlock<T>()
            {
                Collection = collection,
                OverVariable = new Var<T>(NewName())
            };

            BlockBuilder blockBuilder = new BlockBuilder(ModuleBuilder, foreachBlock.ChildBlock);
            build(blockBuilder, foreachBlock.OverVariable);
            Block.Lines.Add(foreachBlock);
        }

        public void If(Var<bool> varIsTrue, Action<BlockBuilder> bTrue, Action<BlockBuilder> bFalse = null)
        {
            var ifBlock = new IfBlock() { Var = varIsTrue };
            BlockBuilder blockBuilder = new BlockBuilder(ModuleBuilder, ifBlock.TrueBlock);
            bTrue(blockBuilder);
            if (bFalse != null)
            {
                ifBlock.FalseBlock = new();
                blockBuilder = new BlockBuilder(ModuleBuilder, ifBlock.FalseBlock);
                bFalse(blockBuilder);
            }
            Block.Lines.Add(ifBlock);
        }

        public Var<TResult> If<TResult>(
            Var<bool> varIsTrue,
            Func<BlockBuilder, Var<TResult>> bTrue, Func<BlockBuilder, Var<TResult>> bFalse)
        {
            Var<Reference<TResult>> outRef = NewObj<Reference<TResult>>();

            If(varIsTrue,
                b => { b.Set(outRef, x => x.Value, bTrue(b)); },
                b => { b.Set(outRef, x => x.Value, bFalse(b)); });

            return this.Get(outRef, x => x.Value);
        }

        public void Comment(string comment)
        {
            Block.Lines.Add(new LineComment() { Comment = comment });
        }

        public IFunction PlaceDefinition<TFunc>(TFunc builder) where TFunc : Delegate
        {
            if (builder.Target != null)
            {
                var func = new Function<TFunc>() { Name = NewName() };
                this.Block.Lines.Add(func);
                return func;
            }
            else
            {
                var func = new Function<TFunc>() { Name = ModuleBuilder.QualifiedName(builder.Method) };
                this.ModuleBuilder.AddFunction(func);
                return func;
            }
        }


        public Var<Action> DefineAction(System.Action<BlockBuilder> builder)
        {
            var action = PlaceDefinition(builder);
            ModuleBuilder.BuildActionBody(action, builder);
            return new (action.Name);
        }

        public Var<Action<P1>> DefineAction<P1>(System.Action<BlockBuilder,Var<P1>> builder)
        {
            var action = PlaceDefinition(builder);
            ModuleBuilder.BuildActionBody(action, builder);
            return new (action.Name);
        }

        public Var<Action<P1,P2>> DefineAction<P1, P2>(System.Action<BlockBuilder, Var<P1>,Var<P2>> builder)
        {
            var action = PlaceDefinition(builder);
            ModuleBuilder.BuildActionBody(action, builder);
            return new(action.Name);
        }

        public Var<Action<P1, P2, P3>> DefineAction<P1, P2, P3>(System.Action<BlockBuilder, Var<P1>, Var<P2>, Var<P3>> builder)
        {
            var action = PlaceDefinition(builder);
            ModuleBuilder.BuildActionBody(action, builder);
            return new(action.Name);
        }

        public Var<Action<P1, P2, P3, P4>> DefineAction<P1, P2, P3, P4>(System.Action<BlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> builder)
        {
            var action = PlaceDefinition(builder);
            ModuleBuilder.BuildActionBody(action, builder);
            return new(action.Name);
        }


        public Var<Func<P1, P2, P3, TOut>> DefineFunc<P1, P2, P3,TOut>(System.Func<BlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> builder)
        {
            var func = PlaceDefinition(builder);
            ModuleBuilder.BuildFuncBody(func, builder);
            return new(func.Name);
        }

        public Var<Func<P1, P2, TOut>> DefineFunc<P1, P2, TOut>(System.Func<BlockBuilder, Var<P1>, Var<P2>, Var<TOut>> builder)
        {
            var func = PlaceDefinition(builder);
            ModuleBuilder.BuildFuncBody(func, builder);
            return new(func.Name);
        }

        public Var<Func<P1, TOut>> DefineFunc<P1, TOut>(System.Func<BlockBuilder, Var<P1>, Var<TOut>> builder)
        {
            var func = PlaceDefinition(builder);
            ModuleBuilder.BuildFuncBody(func, builder);
            return new(func.Name);
        }

        public Var<Func<TOut>> DefineFunc<TOut>(System.Func<BlockBuilder, Var<TOut>> builder)
        {
            var func = PlaceDefinition(builder);
            ModuleBuilder.BuildFuncBody(func, builder);
            return new(func.Name);
        }

        //public IVariable Define<TFunc>(TFunc builder) where TFunc : Delegate
        //{
        //    Function<TFunc> action = null;
        //    if (builder.Target != null)
        //    {
        //        action = new Function<TFunc>() { Name = NewName() };

        //        this.Block.Lines.Add(action);
        //    }
        //    else
        //    {
        //        action = new Function<TFunc>() { Name = ModuleBuilder.QualifiedName(builder.Method), Value = builder };
        //        this.ModuleBuilder.Const(action);
        //    }

        //    var parameters = builder.Method.GetParameters();
        //    if (parameters.Count() == 0 || parameters.First().ParameterType != typeof(BlockBuilder))
        //        throw new NotSupportedException("All client-side actions must have a builder as first parameter");

        //    foreach (var p in parameters.Skip(1))
        //    {
        //        IVariable clientParameter = Activator.CreateInstance(p.ParameterType, new object[] { p.Name }) as IVariable;
        //        action.Parameters.Add(clientParameter);
        //    }

        //    List<object> invokeParameters = new List<object>();
        //    invokeParameters.Add(new BlockBuilder(ModuleBuilder, action.ChildBlock));
        //    invokeParameters.AddRange(action.Parameters);
        //    action.ReturnVariable = builder.Method.Invoke(builder.Target, invokeParameters.ToArray()) as IVariable;

        //    return new Var<object>(action.Name);
        //}
    }

    public static class BlockBuilderExtensions
    {
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

