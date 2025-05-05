using System.Collections.Generic;
using System;

namespace Metapsi.Syntax
{
    public static partial class Core
    {
        /// <summary>
        /// If expression
        /// </summary>
        /// <typeparam name="TSyntaxBuilder"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="b"></param>
        /// <param name="check"></param>
        /// <param name="ifTrue"></param>
        /// <param name="ifFalse"></param>
        /// <returns></returns>
        public static Var<TResult> If<TSyntaxBuilder, TResult>(
            this TSyntaxBuilder b,
            Var<bool> check,
            Func<TSyntaxBuilder, Var<TResult>> ifTrue,
            Func<TSyntaxBuilder, Var<TResult>> ifFalse)
            where TSyntaxBuilder : SyntaxBuilder
        {
            var ifFn = ImportFn(b, "mIf");

            var assignmentNode = new AssignmentNode()
            {
                Name = b.NewVarName(),
                Node = new CallNode()
                {
                    Fn = new IdentifierNode()
                    {
                        Name = ifFn.Name,
                    },
                    Arguments = new List<ISyntaxNode>()
                    {
                        new IdentifierNode()
                        {
                            Name = check.Name
                        },
                        FnNodeExtensions.FromDelegate(b, ifTrue),
                        FnNodeExtensions.FromDelegate(b, ifFalse)
                    },
                }
            };

            b.nodes.Add(assignmentNode);
            return new Var<TResult>(assignmentNode.Name);
        }

        /// <summary>
        /// If statement
        /// </summary>
        /// <typeparam name="TSyntaxBuilder"></typeparam>
        /// <param name="b"></param>
        /// <param name="check"></param>
        /// <param name="ifTrue"></param>
        /// <param name="ifFalse"></param>
        public static void If<TSyntaxBuilder>(
            this TSyntaxBuilder b,
            Var<bool> check,
            Action<TSyntaxBuilder> ifTrue,
            Action<TSyntaxBuilder> ifFalse)
            where TSyntaxBuilder : SyntaxBuilder
        {
            var ifFn = ImportFn(b, "mIf");

            var ifStatmentNode = new CallNode()
            {
                Fn = new IdentifierNode()
                {
                    Name = ifFn.Name,
                },
                Arguments = new List<ISyntaxNode>()
                {
                    new IdentifierNode()
                    {
                        Name = check.Name
                    },
                    FnNodeExtensions.FromDelegate(b, ifTrue),
                    FnNodeExtensions.FromDelegate(b, ifFalse)
                },
            };

            b.nodes.Add(ifStatmentNode);
        }

        /// <summary>
        /// If statement
        /// </summary>
        /// <typeparam name="TSyntaxBuilder"></typeparam>
        /// <param name="b"></param>
        /// <param name="check"></param>
        /// <param name="ifTrue"></param>
        public static void If<TSyntaxBuilder>(
            this TSyntaxBuilder b,
            Var<bool> check,
            Action<TSyntaxBuilder> ifTrue)
            where TSyntaxBuilder : SyntaxBuilder
        {
            var ifFn = ImportFn(b, "mIf");

            var ifStatementNode = new CallNode()
            {
                Fn = new IdentifierNode()
                {
                    Name = ifFn.Name,
                },
                Arguments = new List<ISyntaxNode>()
                {
                    new IdentifierNode()
                    {
                        Name = check.Name
                    },
                    FnNodeExtensions.FromDelegate(b, ifTrue)
                }
            };

            b.nodes.Add(ifStatementNode);
        }

        /// <summary>
        /// Swith expression
        /// </summary>
        /// <typeparam name="TSyntaxBuilder"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="b"></param>
        /// <param name="v"></param>
        /// <param name="default"></param>
        /// <param name="cases"></param>
        /// <returns></returns>
        public static Var<TResult> Switch<TSyntaxBuilder, TResult, TInput>(
            this TSyntaxBuilder b,
            Var<TInput> v,
            Func<TSyntaxBuilder, Var<TResult>> @default,
            params (TInput, Func<TSyntaxBuilder, Var<TResult>>)[] cases)
            where TSyntaxBuilder : SyntaxBuilder
        {
            var caseFuncRef = b.Ref(b.Def(@default));

            foreach (var @case in cases)
            {
                var eq = b.AreEqual(v, b.Const(@case.Item1));
                b.If(eq, b => b.SetRef(caseFuncRef, b.Def(@case.Item2)));
            }

            return b.Call(b.GetRef(caseFuncRef));
        }
    }
}
