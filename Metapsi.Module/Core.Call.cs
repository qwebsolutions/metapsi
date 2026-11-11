using System;
using System.Collections.Generic;

namespace Metapsi.Syntax
{
    public interface ICallArguments
    {
        List<object> Fixed { get; set; }
        List<object> Rest { get; set; }
    }

    public class CallArguments : ICallArguments
    {
        public List<object> Fixed { get; set; }
        public List<object> Rest { get; set; }
    }

    public class MethodCallArguments : ICallArguments
    {
        public object OnObject { get; set; }
        public string FunctionName { get; set; }
        public List<object> Fixed { get; set; }
        public List<object> Rest { get; set; }
    }

    public class FunctionCallArguments : ICallArguments
    {
        public Delegate FunctionReference { get; set; }
        public List<object> Fixed { get; set; }
        public List<object> Rest { get; set; }
    }

    public class ConstructArguments : ICallArguments
    {
        public object Class { get; set; }
        public List<object> Fixed { get; set; }
        public List<object> Rest { get; set; }
    }

    public static partial class Core
    {
        public static void SetFixed<T>(this PropsBuilder<T> b, IEnumerable<IVariable> arguments)
            where T : ICallArguments
        {
            var list = b.NewCollection<object>();
            foreach (var item in arguments)
            {
                // null IS a valid argument, it means optional but missing
                b.Push(list, item?.As<object>());
            }
            b.Set(x => x.Fixed, list);
        }

        public static void SetRest<T, TItem>(this PropsBuilder<T> b, Var<List<TItem>> rest)
            where T : ICallArguments
        {
            if (rest == null)
                return;
            b.Set(x => x.Rest, rest.As<List<object>>());
        }

        public static void SetRest<T>(this PropsBuilder<T> b, IEnumerable<IVariable> restArguments)
            where T : ICallArguments
        {
            var list = b.NewCollection<object>();
            foreach (var item in restArguments)
            {
                // null IS a valid argument, it means optional but missing
                b.Push(list, item?.As<object>());
            }
            b.Set(x => x.Rest, list);
        }

        public static Var<TResult> Call<TResult>(this ISyntaxBuilder b, Var<MethodCallArguments> args)
        {
            var callMethod = ImportCore<Delegate>(b, "CallMethod");
            return b.CallDynamic<TResult>(callMethod, args);
        }

        public static void Call(this ISyntaxBuilder b, Var<MethodCallArguments> args)
        {
            var callMethod = ImportCore<Delegate>(b, "CallMethod");
            b.CallDynamic(callMethod, args);
        }

        public static Var<TResult> Call<TResult>(this ISyntaxBuilder b, Var<FunctionCallArguments> args)
        {
            var callFunction = ImportCore<Delegate>(b, "CallFunction");
            return b.CallDynamic<TResult>(callFunction, args);
        }

        public static void Call(this ISyntaxBuilder b, Var<FunctionCallArguments> args)
        {
            var callFunction = ImportCore<Delegate>(b, "CallFunction");
            b.CallDynamic(callFunction, args);
        }

        public static Var<T> Construct<T>(this ISyntaxBuilder b, Var<ConstructArguments> args)
        {
            var constructClass = ImportCore<Delegate>(b, "ConstructClass");
            return b.CallDynamic<T>(constructClass, args);
        }
    }
}