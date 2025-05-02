using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Metapsi.Syntax
{
    public class SyntaxBuilder
    {
        public virtual void InitializeFrom(SyntaxBuilder parent)
        {
            if (this.blockBuilder == null)
            {
                this.blockBuilder = parent.blockBuilder; // TODO: Seems shady?
            }
        }

        internal static TSyntaxBuilder New<TSyntaxBuilder>(BlockBuilder b, TSyntaxBuilder source)
            where TSyntaxBuilder : SyntaxBuilder, new()
        {
            TSyntaxBuilder syntaxBuilder = new() { blockBuilder = b };
            syntaxBuilder.InitializeFrom(source);
            return syntaxBuilder;
        }

        //public static TSyntaxBuilder New<TSyntaxBuilder>(TSyntaxBuilder source)
        //    where TSyntaxBuilder : SyntaxBuilder, new()
        //{
        //    TSyntaxBuilder syntaxBuilder = new() { blockBuilder = b };
        //    return syntaxBuilder;
        //}

        internal BlockBuilder blockBuilder;

        public Module Module => blockBuilder.ModuleBuilder.Module;

        public SyntaxBuilder()
        {
        }

        public SyntaxBuilder(SyntaxBuilder b)
        {
            this.blockBuilder = b.blockBuilder;
        }

        public Var<T> Const<T>(T constant)
        {
            if (constant is IVariable)
                throw new ArgumentException("Constant is not a server-side value");
            return blockBuilder.Const(constant);
        }

        public Var<T> Const<T>(T constant, string name)
        {
            return blockBuilder.Const(constant, name);
        }

        public Var<T> NewObj<T>() where T : new()
        {
            return blockBuilder.NewObj<T>();
        }

        public Var<List<T>> NewCollection<T>()
        {
            return blockBuilder.NewCollection<T>();
        }

        public Var<TOut> CallExternal<TOut>(string module, string function, params IVariable[] arguments)
        {
            return blockBuilder.CallExternal<TOut>(module, function, arguments);
        }

        public void CallExternal(string module, string function, params IVariable[] arguments)
        {
            blockBuilder.CallExternal(module, function, arguments);
        }

        public void Set<TItem, TProp>(Var<TItem> var, Expression<Func<TItem, TProp>> access, Var<TProp> value)
        {
            blockBuilder.Set<TItem, TProp>(var, access, value);
        }

        public void SetLax<TItem>(Var<TItem> var, LambdaExpression access, IVariable value)
        {
            blockBuilder.SetLax(var, access, value);
        }

        public void Set<TItem, TProp>(Var<TItem> var, Expression<Func<TItem, TProp>> access, TProp value)
        {
            // Guard against 'double clienting'
            if (value is IVariable)
            {
                SetLax(var, access, value as IVariable);
            }
            else
            {
                Set<TItem, TProp>(var, access, Const(value));
            }
        }

        public void SetDynamic<TProp>(IVariable item, DynamicProperty<TProp> property, Var<TProp> value)
        {
            this.SetProperty(item, Const(property.PropertyName), value);
        }

        public Var<TProp> GetDynamic<TProp>(IVariable item, DynamicProperty<TProp> property)
        {
            return this.GetProperty<TProp>(item, Const(property.PropertyName));
        }

        public void Comment(string comment,
            [System.Runtime.CompilerServices.CallerFilePath] String file = "",
            [System.Runtime.CompilerServices.CallerLineNumber] Int32 line = 0)
        {
            blockBuilder.Comment(comment, file, line);
        }
        /// <summary>
        /// Dynamically runs any lambda expression. Used when the parameter and return types are not statically known
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public IVariable GetLax(
            LambdaExpression expression,
            params IVariable[] arguments)
        {
            blockBuilder.ModuleBuilder.AddImport("linq", "Enumerable");
            var constExpr = blockBuilder.ModuleBuilder.AddExpression(expression);
            return blockBuilder.CallFunction<object>(constExpr, arguments);
        }

        /// <summary>
        /// Runs a lambda expression
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public Var<TResult> Get<TInput, TResult>(
            Var<TInput> input,
            Expression<Func<TInput, TResult>> expression)
        {
            return GetLax(expression, input).As<TResult>();
        }

        /// <summary>
        /// Runs a lambda expression
        /// </summary>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public Var<TResult> Get<TInput1, TInput2, TResult>(
            Var<TInput1> input1,
            Var<TInput2> input2,
            Expression<Func<TInput1, TInput2, TResult>> expression)
        {
            return GetLax(expression, input1, input2).As<TResult>();
        }

        /// <summary>
        /// Runs a lambda expression
        /// </summary>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TInput3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public Var<TResult> Get<TInput1, TInput2, TInput3, TResult>(
            Var<TInput1> input1,
            Var<TInput2> input2,
            Var<TInput3> input3,
            Expression<Func<TInput1, TInput2, TInput3, TResult>> expression)
        {
            return GetLax(expression, input1, input2, input3).As<TResult>();
        }

        /// <summary>
        /// Runs a lambda expression
        /// </summary>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TInput3"></typeparam>
        /// <typeparam name="TInput4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <param name="input4"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public Var<TResult> Get<TInput1, TInput2, TInput3, TInput4, TResult>(
            Var<TInput1> input1,
            Var<TInput2> input2,
            Var<TInput3> input3,
            Var<TInput4> input4,
            Expression<Func<TInput1, TInput2, TInput3, TInput4, TResult>> expression)
        {
            return GetLax(expression, input1, input2, input3, input4).As<TResult>();
        }

        /// <summary>
        /// Runs a lambda expression
        /// </summary>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TInput3"></typeparam>
        /// <typeparam name="TInput4"></typeparam>
        /// <typeparam name="TInput5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <param name="input4"></param>
        /// <param name="input5"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public Var<TResult> Get<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>(
            Var<TInput1> input1,
            Var<TInput2> input2,
            Var<TInput3> input3,
            Var<TInput4> input4,
            Var<TInput5> input5,
            Expression<Func<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>> expression)
        {
            return GetLax(expression, input1, input2, input3, input4, input5).As<TResult>();
        }
    }
}

