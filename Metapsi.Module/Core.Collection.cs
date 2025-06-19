using System.Collections.Generic;
using System;

namespace Metapsi.Syntax
{
    public static partial class Core
    {
        public static void Foreach<TSyntaxBuilder, TItem>(
            this TSyntaxBuilder b,
            Var<List<TItem>> collection,
            Action<TSyntaxBuilder, Var<TItem>, Var<int>> onItem)
            where TSyntaxBuilder : SyntaxBuilder
        {
            var mForEach = ImportFn(b, "mForEach");

            b.nodes.Add(new SyntaxNode()
            {
                Call = new CallNode()
                {
                    Fn = new SyntaxNode() { Identifier = new IdentifierNode() { Name = mForEach.Name } },
                    Arguments = new List<SyntaxNode>()
                    {
                        new SyntaxNode() { Identifier = new IdentifierNode(){Name = collection.Name} },
                        new SyntaxNode(){ Fn = FnNodeExtensions.FromDelegate(b, onItem) }
                    }
                }
            });
        }

        public static void Foreach<TSyntaxBuilder, TItem>(
            this TSyntaxBuilder b,
            Var<List<TItem>> collection,
            Action<TSyntaxBuilder, Var<TItem>> onItem)
            where TSyntaxBuilder : SyntaxBuilder
        {
            var mForEach = ImportFn(b, "mForEach");

            b.nodes.Add(new SyntaxNode()
            {
                Call = new CallNode()
                {
                    Fn = new SyntaxNode() { Identifier = new IdentifierNode() { Name = mForEach.Name } },
                    Arguments = new List<SyntaxNode>()
                    {
                        new SyntaxNode(){Identifier = new IdentifierNode(){Name = collection.Name} },
                        new SyntaxNode(){Fn = FnNodeExtensions.FromDelegate(b, onItem) }
                    }
                }
            });
        }

        public static Var<List<TOut>> Map<TSyntaxBuilder, TIn, TOut>(
            this TSyntaxBuilder b,
            Var<List<TIn>> list,
            Var<Func<TIn, TOut>> transform)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.CallOnObject<List<TOut>>(list, "map", transform);
        }

        public static Var<List<TOut>> Map<TSyntaxBuilder, TIn, TOut>(
            this TSyntaxBuilder b,
            Var<List<TIn>> list,
            Func<TSyntaxBuilder, Var<TIn>, Var<TOut>> transform)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Map(list, b.Def(transform));
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
    }
}
