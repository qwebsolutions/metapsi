using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using Metapsi.Dom;
using Metapsi.Ui;
using System.Collections.Generic;

public static class ServerExtensions
{
    public static Var<HyperType.Action<TState, TPayload>> MakeServerAction<TState, TPayload>(
        this SyntaxBuilder b,
        Var<TState> model,
        Func<TState, TPayload, TState> onServerAction)
        where TState : IApiSupportState
    {
        return MakeServerAction<TState, TPayload>(b, model, onServerAction.Method);
    }

    public static Var<HyperType.Action<TState, TPayload>> MakeServerAction<TState, TPayload>(
        this SyntaxBuilder b,
        Var<TState> model,
        Func<CommandContext, TState, TPayload, System.Threading.Tasks.Task<TState>> onServerAction)
        where TState : IApiSupportState
    {
        return MakeServerAction<TState, TPayload>(b, model, onServerAction.Method);
    }

    public static Var<HyperType.Action<TState>> MakeServerAction<TState>(
        this SyntaxBuilder b,
        Var<TState> model,
        Func<CommandContext, TState, System.Threading.Tasks.Task<TState>> onServerAction)
        where TState : IApiSupportState
    {
        return MakeServerAction<TState>(b, model, onServerAction.Method);
    }

    //public class CallApiPayload<TDataPayload>
    //{
    //    public Request<TDataPayload> Request { get; set; }
    //    public TDataPayload Payload { get; set; }
    //}

    public class CallApiEffecterInput<TState, TPayload, TResult>
    {
        public string Url { get; set; }
        public TPayload DataPayload { get; set; }
        public HyperType.Action<TState, TResult> OnResult { get; set; }
        public HyperType.Action<TState, ApiError> OnError { get; set; }
    }

    public static Var<CallApiEffecterInput<TState, TPayload, TResult>> MakeCallApiEffecterPayload<TState, TPayload, TResult>(
        this SyntaxBuilder b,
        Request<TResult, TPayload> request,
        Var<TPayload> payload,
        Var<HyperType.Action<TState, TResult>> onResult,
        Var<HyperType.Action<TState, ApiError>> onError)
    {
        var callApiEffecterInput = b.NewObj<CallApiEffecterInput<TState, TPayload, TResult>>();

        if (Api.AreScalarTypes(typeof(TPayload)))
        {
            b.Set(callApiEffecterInput, x => x.Url, b.Concat(b.Const($"/api/{request.Name}/"), payload.As<string>()));
        }
        else
        {
            b.Set(callApiEffecterInput, x => x.Url, b.Const($"/api/{request.Name}"));
            b.Set(callApiEffecterInput, x => x.DataPayload, payload);
        }
        b.Set(callApiEffecterInput, x => x.OnResult, onResult);
        b.Set(callApiEffecterInput, x => x.OnError, onError);

        return callApiEffecterInput;
    }

    public static void CallApiEffecter<TState, TData, TResult>(
        SyntaxBuilder b, 
        Var<HyperType.Dispatcher<TState>> dispatcher, 
        Var<CallApiEffecterInput<TState, TData, TResult>> callApiParameters)
    {
        var fetchOptions = b.NewObj<FetchOptions>();

        b.If(
            b.HasObject(
                b.Get(callApiParameters, x => x.DataPayload)),
            b =>
            {
                b.SetDynamic(b.Get(fetchOptions, x => x.headers), DynamicProperty.String("Content-Type"), b.Const("application/json"));
                b.Set(fetchOptions, x => x.method, "POST");
                var fetchPayload = b.NewObj<Api.PostBody<TData>>();
                b.Set(fetchPayload, x => x.P1, b.Get(callApiParameters, x => x.DataPayload));
                b.Set(fetchOptions, x => x.body, b.Serialize(fetchPayload));
            },
            b =>
            {
                b.Set(fetchOptions, x => x.method, "GET");
            });

        b.Fetch(
            b.Get(callApiParameters, x => x.Url),
            fetchOptions,
            b.Def((SyntaxBuilder b, Var<TResult> result) =>
            {
                b.Dispatch(dispatcher, b.MakeActionDescriptor(b.Get(callApiParameters, x => x.OnResult), result));
            }),
            b.Def((SyntaxBuilder b, Var<ApiError> error) =>
            {
                b.Dispatch(dispatcher, b.MakeActionDescriptor(b.Get(callApiParameters, x => x.OnError), error));
            }));
    }

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

    public static Var<HyperType.Effect> CallServer<TSyntaxBuilder, TState, TInputData, TPayload>(
        this TSyntaxBuilder b,
        Var<TInputData> inputData,
        Var<TPayload> payload,
        Func<CommandContext, TInputData, TPayload, System.Threading.Tasks.Task<TInputData>> onServerAction,
        Var<HyperType.Action<TState, TInputData>> onResult,
        Var<HyperType.Action<TState, ApiError>> onError)
        where TSyntaxBuilder: SyntaxBuilder
    {
        var serverActionInput = b.NewObj<Metapsi.Ui.ServerActionInput>();
        b.Set(serverActionInput, x => x.SerializedModel, b.Serialize(inputData));
        b.Set(serverActionInput, x => x.SerializedPayload, b.Serialize(payload));
        b.Set(serverActionInput, x => x.HandlerMethod, b.Const(onServerAction.Method.Name));
        b.Set(serverActionInput, x => x.QualifiedHandlerClass, b.Const(onServerAction.Method.DeclaringType.AssemblyQualifiedName));

        var input = b.MakeCallApiEffecterPayload(
            Metapsi.Ui.ServerActionEndpoint.ServerAction, 
            serverActionInput, 
            b.MakeAction((SyntaxBuilder b, Var<TState> model, Var<Metapsi.Ui.ServerActionResponse> result) =>
            {
                var resultObject = b.Deserialize<TInputData>(b.Get(result, x => x.SerializedModel));
                return b.MakeActionDescriptor(onResult, resultObject);
            }), 
            onError);

        var def = b.Def<
            SyntaxBuilder,
            HyperType.Dispatcher<TState>,
            CallApiEffecterInput<TState, ServerActionInput, ServerActionResponse>>(CallApiEffecter<TState, ServerActionInput, ServerActionResponse>);

        var effecter = b.MakeEffect<TState, CallApiEffecterInput<TState, ServerActionInput, ServerActionResponse>>(def, input);
        //b.MakeCallApiEffecter().As<HyperType.Effecter<CallApiEffecterInput<TState, ServerActionInput, Metapsi.Ui.ServerActionResponse>>>();

        return effecter;
        //b.Log("effecter", effecter);

        //return b.MakeEffectWithPayload<CallApiEffecterInput<TState, ServerActionInput, Metapsi.Ui.ServerActionResponse>>(effecter, input);
    }

    private static Var<HyperType.Action<TState, TPayload>> MakeServerAction<TState, TPayload>(
            this SyntaxBuilder b,
            Var<TState> model,
            System.Reflection.MethodInfo method)
            where TState : IApiSupportState
    {
        var clientAction = b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<TPayload> payload) =>
        {
            var serverActionInput = b.NewObj<Metapsi.Ui.ServerActionInput>();
            b.Set(serverActionInput, x => x.SerializedModel, b.Serialize(state));
            b.Set(serverActionInput, x => x.SerializedPayload, b.Serialize(payload));
            b.Set(serverActionInput, x => x.HandlerMethod, b.Const(method.Name));
            b.Set(serverActionInput, x => x.QualifiedHandlerClass, b.Const(method.DeclaringType.AssemblyQualifiedName));

            return b.MakeStateWithEffects(
                b.ShowPanel(model),
                b.MakeEffect(
                    b.Def(
                        b.Request(
                            Metapsi.Ui.ServerActionEndpoint.ServerAction,
                            serverActionInput,
                            b.MakeAction((SyntaxBuilder b, Var<TState> model, Var<Metapsi.Ui.ServerActionResponse> result) =>
                            {
                                return b.Deserialize<TState>(b.Get(result, x => x.SerializedModel));
                            })))));
        });

        return clientAction;
    }

    private static Var<HyperType.Action<TState>> MakeServerAction<TState>(
        this SyntaxBuilder b,
        Var<TState> model,
        System.Reflection.MethodInfo method)
        where TState : IApiSupportState
    {
        var clientAction = b.MakeAction((SyntaxBuilder b, Var<TState> state) =>
        {
            var serverActionInput = b.NewObj<Metapsi.Ui.ServerActionInput>();
            b.Set(serverActionInput, x => x.SerializedModel, b.Serialize(state));
            b.Set(serverActionInput, x => x.HandlerMethod, b.Const(method.Name));
            b.Set(serverActionInput, x => x.QualifiedHandlerClass, b.Const(method.DeclaringType.AssemblyQualifiedName));

            return b.MakeStateWithEffects(
                b.ShowPanel(model),
                b.MakeEffect(
                    b.Def(
                        b.Request(
                            Metapsi.Ui.ServerActionEndpoint.ServerAction,
                            serverActionInput,
                            b.MakeAction((SyntaxBuilder b, Var<TState> model, Var<Metapsi.Ui.ServerActionResponse> result) =>
                            {
                                var newModel = b.Deserialize<TState>(b.Get(result, x => x.SerializedModel));
                                b.DispatchEvent(b.Const("sharedStateUpdate"), newModel);
                                return newModel;
                            })))));
        });

        return clientAction;
    }
}
