using System.Collections.Generic;
using System;

namespace Metapsi.Syntax
{
    public interface IIfStatementBuilder<TSyntaxBuilder>
        where TSyntaxBuilder : ISyntaxBuilder
    {
        void If(Var<bool> check, Action<TSyntaxBuilder> ifTrue, Action<TSyntaxBuilder> ifFalse);
        void If(Var<bool> check, Action<TSyntaxBuilder> ifTrue);
    }

    public interface IIfExpressionBuilder<TSyntaxBuilder>
    {
        Var<TResult> If<TResult>(
            Var<bool> check,
            Func<TSyntaxBuilder, Var<TResult>> ifTrue,
            Func<TSyntaxBuilder, Var<TResult>> ifFalse);

        Var<TResult> Switch<TResult, TInput>(
            Var<TInput> v,
            Func<TSyntaxBuilder, Var<TResult>> @default,
            params (TInput, Func<TSyntaxBuilder, Var<TResult>>)[] cases);
    }

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
            where TSyntaxBuilder : ISyntaxBuilder
        {
            var ifFn = ImportFn(b, "mIf");

            var ifTrueBlockAsignmentNode = new AssignmentNode()
            {
                Name = (b as ISyntaxBuilder).ModuleBuilder.NewName(),
                Node = new SyntaxNode() { Fn = FnNodeExtensions.FromDelegate(b, ifTrue) }
            };
            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode() { Assignment = ifTrueBlockAsignmentNode });

            var ifFalseBlockAsignmentNode = new AssignmentNode()
            {
                Name = (b as ISyntaxBuilder).ModuleBuilder.NewName(),
                Node = new SyntaxNode() { Fn = FnNodeExtensions.FromDelegate(b, ifFalse) }
            };

            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode() { Assignment = ifFalseBlockAsignmentNode });

            var ifResultAssignmentNode = new AssignmentNode()
            {
                Name = (b as ISyntaxBuilder).ModuleBuilder.NewName(),
                Node = new SyntaxNode()
                {
                    Call = new CallNode()
                    {
                        Fn = new SyntaxNode()
                        {
                            Identifier = new IdentifierNode()
                            {
                                Name = (ifFn as IClientVar).Name,
                            }
                        },
                        Arguments = new List<SyntaxNode>()
                        {
                            new SyntaxNode(){
                                Identifier = new IdentifierNode()
                                {
                                    Name = (check as IClientVar).Name
                                }
                            },
                            new SyntaxNode()
                            {
                                Identifier = new IdentifierNode()
                                {
                                    Name = ifTrueBlockAsignmentNode.Name
                                }
                            },
                            new SyntaxNode()
                            {
                                Identifier = new IdentifierNode()
                                {
                                    Name = ifFalseBlockAsignmentNode.Name
                                }
                            },
                        },
                    }
                }
            };

            ifResultAssignmentNode.AddDebugType(typeof(TResult));

            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode() { Assignment = ifResultAssignmentNode });
            return new ClientVar<TResult>(ifResultAssignmentNode.Name) { AssignmentNode = ifResultAssignmentNode };
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
            where TSyntaxBuilder : ISyntaxBuilder
        {
            var ifFn = ImportFn(b, "mIf");

            var ifTrueBlockAsignmentNode = new AssignmentNode()
            {
                Name = (b as ISyntaxBuilder).ModuleBuilder.NewName(),
                Node = new SyntaxNode() { Fn = FnNodeExtensions.FromDelegate(b, ifTrue) }
            };
            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode() { Assignment = ifTrueBlockAsignmentNode });

            var ifFalseBlockAsignmentNode = new AssignmentNode()
            {
                Name = (b as ISyntaxBuilder).ModuleBuilder.NewName(),
                Node = new SyntaxNode() { Fn = FnNodeExtensions.FromDelegate(b, ifFalse) }
            };

            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode() { Assignment = ifFalseBlockAsignmentNode });

            var ifStatmentNode = new CallNode()
            {
                Fn = new SyntaxNode()
                {
                    Identifier = new IdentifierNode()
                    {
                        Name = (ifFn as IClientVar).Name,
                    }
                },
                Arguments = new List<SyntaxNode>()
                {
                    new SyntaxNode()
                    {
                        Identifier = new IdentifierNode()
                        {
                            Name = (check as IClientVar) .Name
                        }
                    },
                    new SyntaxNode()
                    {
                        Identifier = new IdentifierNode()
                        {
                            Name = ifTrueBlockAsignmentNode.Name
                        } 
                    },
                    new SyntaxNode()
                    {
                        Identifier = new IdentifierNode()
                        {
                            Name = ifFalseBlockAsignmentNode.Name
                        }
                    },
                },
            };

            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode() { Call = ifStatmentNode });
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
            where TSyntaxBuilder : ISyntaxBuilder
        {
            var ifFn = ImportFn(b, "mIf");

            var ifTrueBlockAsignmentNode = new AssignmentNode()
            {
                Name = (b as ISyntaxBuilder).ModuleBuilder.NewName(),
                Node = new SyntaxNode() { Fn = FnNodeExtensions.FromDelegate(b, ifTrue) }
            };
            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode() { Assignment = ifTrueBlockAsignmentNode });

            var ifStatementNode = new CallNode()
            {
                Fn = new SyntaxNode()
                {
                    Identifier = new IdentifierNode()
                    {
                        Name = (ifFn as IClientVar).Name,
                    }
                },
                Arguments = new List<SyntaxNode>()
                {
                    new SyntaxNode(){Identifier = new IdentifierNode(){Name = (check as IClientVar).Name} },
                    new SyntaxNode()
                    {
                        Identifier = new IdentifierNode()
                        {
                            Name = ifTrueBlockAsignmentNode.Name
                        }
                    }
                }
            };

            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode() { Call = ifStatementNode });
        }

        /// <summary>
        /// Switch expression
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
            where TSyntaxBuilder : ISyntaxBuilder
        {
            var caseFuncRef = b.Ref(b.Def(@default));

            foreach (var @case in cases)
            {
                var eq = b.AreEqual(v, b.Const(@case.Item1));
                If(b, eq, b => b.SetRef(caseFuncRef, b.Def(@case.Item2)));
            }

            return b.Call(b.GetRef(caseFuncRef));
        }
    }
}
