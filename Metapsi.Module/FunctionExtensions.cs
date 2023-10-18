using System;

namespace Metapsi.Syntax
{
    public static class FunctionExtensions
    {
        // Define actions
        public static Var<Action> Def<TBlockBuilder>(this TBlockBuilder b, Action<TBlockBuilder> builder)
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.DefineAction(builder);
        }

        public static Var<Action<P1>> Def<TBlockBuilder, P1>(this TBlockBuilder b, Action<TBlockBuilder, Var<P1>> builder)
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.DefineAction(builder);
        }

        public static Var<Action<P1, P2>> Def<TBlockBuilder, P1, P2>(this TBlockBuilder b, Action<TBlockBuilder, Var<P1>, Var<P2>> builder) 
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.DefineAction(builder);
        }

        public static Var<Action<P1, P2, P3>> Def<TBlockBuilder, P1, P2, P3>(this TBlockBuilder b, Action<TBlockBuilder, Var<P1>, Var<P2>, Var<P3>> builder) 
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.DefineAction(builder);
        }

        public static Var<Action<P1, P2, P3, P4>> Def<TBlockBuilder, P1, P2, P3, P4>(this TBlockBuilder b, Action<TBlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> builder) 
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.DefineAction(builder);
        }

        // Define functions

        public static Var<Func<TOut>> Def<TBlockBuilder, TOut>(this TBlockBuilder b, Func<TBlockBuilder, Var<TOut>> builder)
            where TBlockBuilder: BlockBuilder, new()
        {
            return b.DefineFunc(builder);
        }

        public static Var<Func<P1, TOut>> Def<TBlockBuilder, P1, TOut>(this TBlockBuilder b, Func<TBlockBuilder, Var<P1>, Var<TOut>> builder) 
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.DefineFunc(builder);
        }

        public static Var<Func<P1, P2, TOut>> Def<TBlockBuilder, P1, P2, TOut>(this TBlockBuilder b, Func<TBlockBuilder, Var<P1>, Var<P2>, Var<TOut>> builder) 
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.DefineFunc(builder);
        }

        public static Var<Func<P1, P2, P3, TOut>> Def<TBlockBuilder, P1, P2, P3, TOut>(this TBlockBuilder b, Func<TBlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> builder)
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.DefineFunc(builder);
        }

        // Call actions

        public static void Call<TBlockBuilder>(this TBlockBuilder b, Var<Action> action)
            where TBlockBuilder: BlockBuilder
        {
            b.CallAction(action);
        }

        public static void Call<TBlockBuilder, P1>(this TBlockBuilder b, Var<Action<P1>> action, Var<P1> p1)
            where TBlockBuilder : BlockBuilder
        {
            b.CallAction(action, p1);
        }

        public static void Call<TBlockBuilder, P1, P2>(this TBlockBuilder b, Var<Action<P1,P2>> action, Var<P1> p1, Var<P2> p2)
            where TBlockBuilder : BlockBuilder
        {
            b.CallAction(action, p1, p2);
        }

        public static void Call<TBlockBuilder,P1, P2, P3>(this TBlockBuilder b, Var<Action<P1, P2, P3>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3)
            where TBlockBuilder : BlockBuilder
        {
            b.CallAction(action, p1, p2, p3);
        }

        public static void Call<TBlockBuilder,P1, P2, P3, P4>(this TBlockBuilder b, Var<Action<P1, P2, P3, P4>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
            where TBlockBuilder : BlockBuilder
        {
            b.CallAction(action, p1, p2, p3, p4);
        }

        // Call functions

        public static Var<TOut> Call<TBlockBuilder, TOut>(this TBlockBuilder b, Var<Func<TOut>> func)
            where TBlockBuilder : BlockBuilder
        {
            return b.CallFunction<TOut>(func);
        }

        public static Var<TOut> Call<TBlockBuilder, P1, TOut>(this TBlockBuilder b, Var<Func<P1, TOut>> func, Var<P1> p1)
            where TBlockBuilder : BlockBuilder
        {
            return b.CallFunction<TOut>(func, p1);
        }

        public static Var<TOut> Call<TBlockBuilder, P1, P2, TOut>(this TBlockBuilder b, Var<Func<P1, P2, TOut>> func, Var<P1> p1, Var<P2> p2)
            where TBlockBuilder : BlockBuilder
        {
            return b.CallFunction<TOut>(func, p1, p2);
        }

        public static Var<TOut> Call<TBlockBuilder, P1, P2, P3, TOut>(this TBlockBuilder b, Var<Func<P1, P2, P3, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3) 
            where TBlockBuilder : BlockBuilder
        {
            return b.CallFunction<TOut>(func, p1, p2, p3);
        }

        // Define & call actions

        public static void Call<TBlockBuilder>(this TBlockBuilder b, Action<TBlockBuilder> action)
            where TBlockBuilder : BlockBuilder, new()
        {
            b.Call(b.Def(action));
        }

        public static void Call<TBlockBuilder, P1>(this TBlockBuilder b, Action<TBlockBuilder, Var<P1>> action, Var<P1> p1)
            where TBlockBuilder : BlockBuilder, new()
        {
            b.Call(b.Def(action), p1);
        }

        public static void Call<TBlockBuilder,P1, P2>(this TBlockBuilder b, Action<TBlockBuilder, Var<P1>, Var<P2>> action, Var<P1> p1, Var<P2> p2)
            where TBlockBuilder : BlockBuilder, new()
        {
            b.Call(b.Def(action), p1, p2);
        }

        public static void Call<TBlockBuilder, P1, P2, P3>(this TBlockBuilder b, Action<TBlockBuilder, Var<P1>, Var<P2>, Var<P3>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3)
            where TBlockBuilder : BlockBuilder, new()
        {
            b.Call(b.Def(action), p1, p2, p3);
        }

        public static void Call<TBlockBuilder, P1, P2, P3, P4>(this TBlockBuilder b, Action<TBlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4) 
            where TBlockBuilder : BlockBuilder, new()
        {
            b.Call(b.Def(action), p1, p2, p3, p4);
        }

        // Define & call functions

        public static Var<TOut> Call<TBlockBuilder, TOut>(this TBlockBuilder b, Func<TBlockBuilder, Var<TOut>> func)
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.Call(b.Def<TBlockBuilder, TOut>(func));
        }

        public static Var<TOut> Call<TBlockBuilder, P1, TOut>(this TBlockBuilder b, Func<TBlockBuilder, Var<P1>, Var<TOut>> func, Var<P1> p1)
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.Call(b.Def(func), p1);
        }

        public static Var<TOut> Call<TBlockBuilder, P1, P2, TOut>(this TBlockBuilder b, Func<TBlockBuilder, Var<P1>, Var<P2>, Var<TOut>> func, Var<P1> p1, Var<P2> p2)
            where TBlockBuilder : BlockBuilder, new()
        {
            return b.Call(b.Def(func), p1, p2);
        }

        public static Var<TOut> Call<TBlockBuilder, P1, P2, P3, TOut>(this TBlockBuilder b, Func<TBlockBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3)
            where TBlockBuilder: BlockBuilder, new()
        {
            return b.Call(b.Def(func), p1, p2, p3);
        }
    }
}

