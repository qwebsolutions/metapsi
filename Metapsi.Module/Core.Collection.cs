using System.Collections.Generic;
using System;

namespace Metapsi.Syntax
{
    public interface IForeachBuilder<TSyntaxBuilder>
    {
        void Foreach<TItem>(
            Var<List<TItem>> collection,
            Action<TSyntaxBuilder, Var<TItem>, Var<int>> onItem);

        void Foreach<TItem>(
            Var<List<TItem>> collection,
            Action<TSyntaxBuilder, Var<TItem>> onItem);
    }

    public static partial class Core
    {
        public static void Foreach<TSyntaxBuilder, TItem>(
            this TSyntaxBuilder b,
            Var<List<TItem>> collection,
            Action<TSyntaxBuilder, Var<TItem>, Var<int>> onItem)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            var mForEach = ImportFn(b, "mForEach");

            var forEachBlockAssignment = new AssignmentNode()
            {
                Name = (b as ISyntaxBuilder).ModuleBuilder.NewName(),
                Node = new SyntaxNode() { Fn = FnNodeExtensions.FromDelegate(b, onItem) }
            };

            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode() { Assignment = forEachBlockAssignment });

            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode()
            {
                Call = new CallNode()
                {
                    Fn = new SyntaxNode()
                    {
                        Identifier = new IdentifierNode()
                        {
                            Name = (mForEach as IClientVar).Name
                        }
                    },
                    Arguments = new List<SyntaxNode>()
                    {
                        new SyntaxNode()
                        {
                            Identifier = new IdentifierNode()
                            {
                                Name = (collection as IClientVar) .Name
                            }
                        },
                        new SyntaxNode()
                        {
                            Identifier = new IdentifierNode()
                            {
                                Name = forEachBlockAssignment.Name
                            }
                        }
                    }
                }
            });
        }

        public static void Foreach<TSyntaxBuilder, TItem>(
            this TSyntaxBuilder b,
            Var<List<TItem>> collection,
            Action<TSyntaxBuilder, Var<TItem>> onItem)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            var mForEach = ImportFn(b, "mForEach");

            var forEachBlockAssignment = new AssignmentNode()
            {
                Name = (b as ISyntaxBuilder).ModuleBuilder.NewName(),
                Node = new SyntaxNode() { Fn = FnNodeExtensions.FromDelegate(b, onItem) }
            };

            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode() { Assignment = forEachBlockAssignment });

            (b as ISyntaxBuilder).AddSyntaxNode(new SyntaxNode()
            {
                Call = new CallNode()
                {
                    Fn = new SyntaxNode() 
                    { 
                        Identifier = new IdentifierNode() 
                        { 
                            Name = (mForEach as IClientVar).Name 
                        }
                    },
                    Arguments = new List<SyntaxNode>()
                    {
                        new SyntaxNode()
                        {
                            Identifier = new IdentifierNode()
                            {
                                Name = (collection as IClientVar) .Name
                            }
                        },
                        new SyntaxNode()
                        {
                            Identifier = new IdentifierNode()
                            {
                                Name = forEachBlockAssignment.Name 
                            }
                        }
                    }
                }
            });
        }

        public static Var<List<TOut>> Map<TSyntaxBuilder, TIn, TOut>(
            this TSyntaxBuilder b,
            Var<List<TIn>> list,
            Var<Func<TIn, TOut>> transform)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return b.CallOnObject<List<TOut>>(list, "map", transform);
        }

        public static Var<List<TOut>> Map<TSyntaxBuilder, TIn, TOut>(
            this TSyntaxBuilder b,
            Var<List<TIn>> list,
            Func<TSyntaxBuilder, Var<TIn>, Var<TOut>> transform)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return b.Map(list, b.Def(transform));
        }


        public static Var<List<TItem>> Filter<TItem>(this SyntaxBuilder b, Var<List<TItem>> list, Var<Func<TItem, bool>> predicate)
        {
            return b.On(list, b => b.Call<List<TItem>>("filter", predicate));
        }

        public static Var<List<T>> Filter<T>(this SyntaxBuilder b, Var<List<T>> list, Func<SyntaxBuilder, Var<T>, Var<bool>> predicate)
        {
            return b.Filter(list, b.Def(predicate));
        }
    }
}
