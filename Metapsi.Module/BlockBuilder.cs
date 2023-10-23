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

    internal class BlockBuilder
    {
        public BlockBuilder(ModuleBuilder moduleBuilder, Block block)
        {
            this.ModuleBuilder = moduleBuilder;
            this.Block = block;
        }

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
                init(new Modifier<T>(new SyntaxBuilder(this), newObj));
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

        public void SetLax<TItem, TProp>(Var<TItem> var, LambdaExpression access, Var<TProp> value)
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

        public void Set<TItem, TProp>(Var<TItem> var, Expression<Func<TItem, TProp>> access, TProp value)
        {
            Set<TItem, TProp>(var, access, Const(value));
        }

        public void Comment(string comment)
        {
            Block.Lines.Add(new LineComment() { Comment = comment });
        }

        public (bool alreadyDefined, IFunction functionRef) PlaceDefinition<TFunc>(TFunc builder) where TFunc : Delegate
        {
            if (builder.Target != null)
            {
                var func = new Function<TFunc>() { Name = NewName() };
                this.Block.Lines.Add(func);
                return (false, func);
            }
            else
            {
                var func = new Function<TFunc>() { Name = ModuleBuilder.QualifiedName(builder.Method) };
                var isNew = this.ModuleBuilder.AddFunction(func);
                return (!isNew, func);
            }
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

        internal IVariable DefineAction(Delegate builder)
        {
            var (alreadyDefined, clientAction) = PlaceDefinition(builder);
            if (!alreadyDefined)
            {
                ModuleBuilder.BuildBody(clientAction, builder);
            }
            return ModuleBuilder.MakeVar(clientAction.Name, ModuleBuilder.ClientActionType(builder));
        }

        internal IVariable DefineFunc(Delegate builder)
        {
            var (alreadyDefined, clientFunc) = PlaceDefinition(builder);
            if (!alreadyDefined)
            {
                ModuleBuilder.BuildBody(clientFunc, builder);
            }
            return ModuleBuilder.MakeVar(clientFunc.Name, ModuleBuilder.ClientFuncType(builder));
        }

    }
}

