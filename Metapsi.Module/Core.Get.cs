using System;
using System.Linq;
using System.Linq.Expressions;

namespace Metapsi.Syntax
{
    public static partial class Core
    {
        /// <summary>
        /// Dynamically runs any lambda expression. Used when the parameter and return types are not statically known
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public static IVariable GetLax(
            SyntaxBuilder b,
            LambdaExpression expression,
            params IVariable[] arguments)
        {
            b.AddEmbeddedResourceMetadata(typeof(Metapsi.Syntax.ObjBuilder<>).Assembly, "linq.js");
            b.ImportDefault("linq.js", "Enumerable");
            var assignmentNode = new AssignmentNode()
            {
                Name = b.NewVarName(),
                Node = new SyntaxNode()
                {
                    Call = new CallNode()
                    {
                        Fn = new SyntaxNode() { Linq = LinqNodeExtensions.FromLambda(expression) },
                        Arguments = arguments.Select(x => new SyntaxNode() { Identifier = new IdentifierNode() { Name = x.Name } }).ToList(),
                    }
                }
            };

            assignmentNode.AddDebugType(expression.ReturnType);

            b.nodes.Add(new SyntaxNode() { Assignment = assignmentNode });
            return new Var<object>(assignmentNode.Name);
        }

        /// <summary>
        /// Runs a lambda expression
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="b"></param>
        /// <param name="input"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static Var<TResult> Get<TInput, TResult>(
            this SyntaxBuilder b,
            Var<TInput> input,
            Expression<Func<TInput, TResult>> expression)
        {
            return GetLax(b, expression, input).As<TResult>();
        }

        /// <summary>
        /// Runs a lambda expression
        /// </summary>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="b"></param>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static Var<TResult> Get<TInput1, TInput2, TResult>(
            this SyntaxBuilder b,
            Var<TInput1> input1,
            Var<TInput2> input2,
            Expression<Func<TInput1, TInput2, TResult>> expression)
        {
            return GetLax(b, expression, input1, input2).As<TResult>();
        }

        /// <summary>
        /// Runs a lambda expression
        /// </summary>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TInput3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="b"></param>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static Var<TResult> Get<TInput1, TInput2, TInput3, TResult>(
            this SyntaxBuilder b,
            Var<TInput1> input1,
            Var<TInput2> input2,
            Var<TInput3> input3,
            Expression<Func<TInput1, TInput2, TInput3, TResult>> expression)
        {
            return GetLax(b, expression, input1, input2, input3).As<TResult>();
        }

        /// <summary>
        /// Runs a lambda expression
        /// </summary>
        /// <typeparam name="TInput1"></typeparam>
        /// <typeparam name="TInput2"></typeparam>
        /// <typeparam name="TInput3"></typeparam>
        /// <typeparam name="TInput4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="b"></param>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <param name="input4"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static Var<TResult> Get<TInput1, TInput2, TInput3, TInput4, TResult>(
            this SyntaxBuilder b,
            Var<TInput1> input1,
            Var<TInput2> input2,
            Var<TInput3> input3,
            Var<TInput4> input4,
            Expression<Func<TInput1, TInput2, TInput3, TInput4, TResult>> expression)
        {
            return GetLax(b, expression, input1, input2, input3, input4).As<TResult>();
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
        /// <param name="b"></param>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <param name="input4"></param>
        /// <param name="input5"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static Var<TResult> Get<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>(
            this SyntaxBuilder b,
            Var<TInput1> input1,
            Var<TInput2> input2,
            Var<TInput3> input3,
            Var<TInput4> input4,
            Var<TInput5> input5,
            Expression<Func<TInput1, TInput2, TInput3, TInput4, TInput5, TResult>> expression)
        {
            return GetLax(b, expression, input1, input2, input3, input4, input5).As<TResult>();
        }
    }
}
