using System;

namespace Metapsi.Syntax
{
    public static class FunctionExtensions
    {
        // Define actions
        public static Var<Action> Def(this BlockBuilder b, Action<BlockBuilder> builder)
        {
            return b.DefineAction(builder);
        }

        public static Var<Action<P1>> Def<P1>(this BlockBuilder b, Action<BlockBuilder, Var<P1>> builder)
        {
            return b.DefineAction(builder);
        }

        public static Var<Action<P1, P2>> Def<P1, P2>(this BlockBuilder b, Action<BlockBuilder, Var<P1>, Var<P2>> builder)
        {
            return b.DefineAction(builder);
        }

        public static Var<Action<P1, P2, P3>> Def<P1, P2, P3>(this BlockBuilder b, Action<BlockBuilder, Var<P1>, Var<P2>, Var<P3>> builder)
        {
            return b.DefineAction(builder);
        }

        public static Var<Action<P1, P2, P3, P4>> Def<P1, P2, P3, P4>(this BlockBuilder b, Action<BlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> builder)
        {
            return b.DefineAction(builder);
        }

        // Define functions

        public static Var<Func<TOut>> Def<TOut>(this BlockBuilder b, Func<BlockBuilder, Var<TOut>> builder)
        {
            return b.DefineFunc<TOut>(builder);
        }

        public static Var<Func<P1, TOut>> Def<P1, TOut>(this BlockBuilder b, Func<BlockBuilder, Var<P1>, Var<TOut>> builder)
        {
            return b.DefineFunc(builder);
        }

        public static Var<Func<P1, P2, TOut>> Def<P1, P2, TOut>(this BlockBuilder b, Func<BlockBuilder, Var<P1>, Var<P2>, Var<TOut>> builder)
        {
            return b.DefineFunc(builder);
        }

        public static Var<Func<P1, P2, P3, TOut>> Def<P1, P2, P3, TOut>(this BlockBuilder b, Func<BlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> builder)
        {
            return b.DefineFunc(builder);
        }

        // Call actions

        public static void Call(this ISyntaxBuilder b, Var<Action> action)
        {
            b.CallAction(action);
        }

        public static void Call<P1>(this ISyntaxBuilder b, Var<Action<P1>> action, Var<P1> p1)
        {
            b.CallAction(action, p1);
        }

        public static void Call<P1, P2>(this BlockBuilder b, Var<Action<P1,P2>> action, Var<P1> p1, Var<P2> p2)
        {
            b.CallAction(action, p1, p2);
        }

        public static void Call<P1, P2, P3>(this BlockBuilder b, Var<Action<P1, P2, P3>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3)
        {
            b.CallAction(action, p1, p2, p3);
        }

        public static void Call<P1, P2, P3, P4>(this BlockBuilder b, Var<Action<P1, P2, P3, P4>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
        {
            b.CallAction(action, p1, p2, p3, p4);
        }

        // Call functions

        public static Var<TOut> Call<TOut>(this ISyntaxBuilder b, Var<Func<TOut>> func)
        {
            return b.CallFunction<TOut>(func);
        }

        public static Var<TOut> Call<P1, TOut>(this BlockBuilder b, Var<Func<P1, TOut>> func, Var<P1> p1)
        {
            return b.CallFunction<TOut>(func, p1);
        }

        public static Var<TOut> Call<P1, P2, TOut>(this BlockBuilder b, Var<Func<P1, P2, TOut>> func, Var<P1> p1, Var<P2> p2)
        {
            return b.CallFunction<TOut>(func, p1, p2);
        }

        public static Var<TOut> Call<P1, P2, P3, TOut>(this BlockBuilder b, Var<Func<P1, P2, P3, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3)
        {
            return b.CallFunction<TOut>(func, p1, p2, p3);
        }

        // Define & call actions

        public static void Call(this BlockBuilder b, Action<BlockBuilder> action)
        {
            b.Call(b.Def(action));
        }

        public static void Call<P1>(this BlockBuilder b, Action<BlockBuilder, Var<P1>> action, Var<P1> p1)
        {
            b.Call(b.Def(action), p1);
        }

        public static void Call<P1, P2>(this BlockBuilder b, Action<BlockBuilder, Var<P1>, Var<P2>> action, Var<P1> p1, Var<P2> p2)
        {
            b.Call(b.Def(action), p1, p2);
        }

        public static void Call<P1, P2, P3>(this BlockBuilder b, Action<BlockBuilder, Var<P1>, Var<P2>, Var<P3>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3)
        {
            b.Call(b.Def(action), p1, p2, p3);
        }

        public static void Call<P1, P2, P3, P4>(this BlockBuilder b, Action<BlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
        {
            b.Call(b.Def(action), p1, p2, p3, p4);
        }

        // Define & call functions

        public static Var<TOut> Call<TSyntaxBuilder, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<TOut>> func)
            where TSyntaxBuilder: ISyntaxBuilder
        {
            return b.Call(b.Def(func));
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder , Var<P1>, Var<TOut>> func, Var<P1> p1)
            where TSyntaxBuilder: ISyntaxBuilder
        {
            return b.Call(b.Def(func), p1);
        }

        public static Var<TOut> Call<P1, P2, TOut>(this BlockBuilder b, Func<BlockBuilder, Var<P1>, Var<P2>, Var<TOut>> func, Var<P1> p1, Var<P2> p2)
        {
            return b.Call(b.Def(func), p1, p2);
        }

        public static Var<TOut> Call<P1, P2, P3, TOut>(this BlockBuilder b, Func<BlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3)
        {
            return b.Call(b.Def(func), p1, p2, p3);
        }
    }
}

