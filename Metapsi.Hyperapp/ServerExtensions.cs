using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using Metapsi.Dom;
using Metapsi.Ui;
using System.Collections.Generic;

public static class ServerExtensions
{
//    public static Var<HyperType.Action<TState, TPayload>> MakeServerAction<TState, TPayload>(
//        this SyntaxBuilder b,
//        Var<TState> model,
//        Func<TState, TPayload, TState> onServerAction)
//        where TState : IApiSupportState
//    {
//        return MakeServerAction<TState, TPayload>(b, model, onServerAction.Method);
//    }

//    public static Var<HyperType.Action<TState, TPayload>> MakeServerAction<TState, TPayload>(
//        this SyntaxBuilder b,
//        Var<TState> model,
//        Func<CommandContext, TState, TPayload, System.Threading.Tasks.Task<TState>> onServerAction)
//        where TState : IApiSupportState
//    {
//        return MakeServerAction<TState, TPayload>(b, model, onServerAction.Method);
//    }

//    public static Var<HyperType.Action<TState>> MakeServerAction<TState>(
//        this SyntaxBuilder b,
//        Var<TState> model,
//        Func<CommandContext, TState, System.Threading.Tasks.Task<TState>> onServerAction)
//        where TState : IApiSupportState
//    {
//        return MakeServerAction<TState>(b, model, onServerAction.Method);
//    }

    //public class CallApiPayload<TDataPayload>
    //{
    //    public Request<TDataPayload> Request { get; set; }
    //    public TDataPayload Payload { get; set; }
    //}


    //public static Var<Action<HyperType.Dispatcher<TState>, CallApiEffecterInput<TState, TData, TResult>>> MakeCallApiEffecter<TState, TData, TResult>(
    //    this SyntaxBuilder b)
    //{
    //    return b.Def((SyntaxBuilder b, Var<HyperType.Dispatcher<TState>> dispatcher, Var<CallApiEffecterInput<TState, TData, TResult>> effecterInput) =>
    //    {
    //        b.Log("effecterInput", effecterInput);

    //        var fetchOptions = b.NewObj<FetchOptions>();

    //        b.If(
    //            b.HasObject(
    //                b.Get(effecterInput, x => x.DataPayload)),
    //            b =>
    //            {
    //                b.SetDynamic(b.Get(fetchOptions, x => x.headers), DynamicProperty.String("Content-Type"), b.Const("application/json"));
    //                b.Set(fetchOptions, x => x.method, "POST");
    //                var fetchPayload = b.NewObj<Api.PostBody<TData>>();
    //                b.Set(fetchPayload, x => x.P1, b.Get(effecterInput, x => x.DataPayload));
    //                b.Set(fetchOptions, x => x.body, b.Serialize(fetchPayload));
    //            },
    //            b =>
    //            {
    //                b.Set(fetchOptions, x => x.method, "GET");
    //            });

    //        b.Log("fetchOptions", fetchOptions);

    //        b.Fetch<TResult>(
    //            b.Get(effecterInput, x => x.Url),
    //            fetchOptions,
    //            b.Def((SyntaxBuilder b, Var<TResult> result) =>
    //            {
    //                b.Dispatch(dispatcher, b.MakeActionDescriptor(b.Get(effecterInput, x => x.OnResult), result));
    //            }),
    //            b.Def((SyntaxBuilder b, Var<ApiError> error) =>
    //            {
    //                b.Dispatch(dispatcher, b.MakeActionDescriptor(b.Get(effecterInput, x => x.OnError), error));
    //            }));
    //    });
    //}

    //public static Var<HyperType.Effect<TInput>> MakeEffect<TSyntaxBuilder, TState, TInput>(
    //    this SyntaxBuilder b, Action<TSyntaxBuilder, Var<HyperType.Dispatcher<TState>>, Var<TInput>> effecterAction)
    //    where TSyntaxBuilder: SyntaxBuilder
    //{
    //    return b.Def(effecterAction).As<HyperType.Effect<TInput>>();
    //}


    //public static Var<HyperType.Effect> MakeEffect<TState, TInput>(
    //    this SyntaxBuilder b,
    //    Var<Action<Dispatcher<TState>, TInput>> effecter, Var<TInput> payload)
    //{
    //    Var<List<object>> effectList = b.NewCollection<object>();
    //    b.Push(effectList, effecter.As<object>());
    //    b.Push(effectList, payload.As<object>());
    //    return effectList.As<HyperType.Effect>();
    //}


    //public static Var<HyperType.Effect> MakeEffect<TState, TInput>(
    //    this SyntaxBuilder b,
    //    Var<Action<Dispatcher<TState>, TInput>> effecter, Var<TInput> payload)
    //{
    //    Var<List<object>> effectList = b.NewCollection<object>();
    //    b.Push(effectList, effecter.As<object>());
    //    b.Push(effectList, payload.As<object>());
    //    return effectList.As<HyperType.Effect>();
    //}

}
