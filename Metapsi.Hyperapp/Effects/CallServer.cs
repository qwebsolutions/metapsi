using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using Microsoft.AspNetCore.Components.Forms;

namespace Metapsi.Hyperapp
{

    public static class CallServerEffects
    {
        public static Var<HyperType.Effect> CallServer<TSyntaxBuilder, TState, TInputData, TPayload>(
            this TSyntaxBuilder b,
            Var<TInputData> inputData,
            Var<TPayload> payload,
            Func<CommandContext, TInputData, TPayload, System.Threading.Tasks.Task<TInputData>> onServerAction,
            Var<HyperType.Action<TState, TInputData>> onResult,
            Var<HyperType.Action<TState, ApiError>> onError)
            where TSyntaxBuilder : SyntaxBuilder
        {
            var callServerPayload = b.MakeCallServerPayload(inputData, payload, onServerAction.Method, onResult, onError);

            var def = b.Def<
                SyntaxBuilder,
                HyperType.Dispatcher<TState>,
                CallApiInput<TState, ServerActionInput, ServerActionResponse>>(CallApiExtensions.CallApiEffecter<TState, ServerActionInput, ServerActionResponse>);

            var effecter = b.MakeEffect<TState, CallApiInput<TState, ServerActionInput, ServerActionResponse>>(def, callServerPayload);
            return effecter;
        }

        public static Var<HyperType.Effect> CallServer<TSyntaxBuilder, TState, TInputData>(
            this TSyntaxBuilder b,
            Var<TInputData> inputData,
            Func<CommandContext, TInputData, System.Threading.Tasks.Task<TInputData>> onServerAction,
            Var<HyperType.Action<TState, TInputData>> onResult,
            Var<HyperType.Action<TState, ApiError>> onError)
            where TSyntaxBuilder : SyntaxBuilder
        {
            var callServerPayload = b.MakeCallServerPayload(inputData, b.Const(string.Empty), onServerAction.Method, onResult, onError);
            var def = b.Def<
                SyntaxBuilder,
                HyperType.Dispatcher<TState>,
                CallApiInput<TState, ServerActionInput, ServerActionResponse>>(CallApiExtensions.CallApiEffecter<TState, ServerActionInput, ServerActionResponse>);

            var effecter = b.MakeEffect<TState, CallApiInput<TState, ServerActionInput, ServerActionResponse>>(def, callServerPayload);
            return effecter;
        }

        private static Var<CallApiInput<TState, ServerActionInput, ServerActionResponse>> MakeCallServerPayload<TState, TInputData, TPayload>(
            this SyntaxBuilder b,
            Var<TInputData> inputData,
            Var<TPayload> payload,
            System.Reflection.MethodInfo serverMethod,
            Var<HyperType.Action<TState, TInputData>> onResult,
            Var<HyperType.Action<TState, ApiError>> onError)
        {
            var serverActionInput = b.NewObj<Metapsi.Ui.ServerActionInput>();
            b.Set(serverActionInput, x => x.SerializedModel, b.Serialize(inputData));
            b.Set(serverActionInput, x => x.SerializedPayload, b.Serialize(payload));
            b.Set(serverActionInput, x => x.HandlerMethod, b.Const(serverMethod.Name));
            b.Set(serverActionInput, x => x.QualifiedHandlerClass, b.Const(serverMethod.DeclaringType.AssemblyQualifiedName));

            var input = b.MakeCallApiEffecterPayload(
                Metapsi.Ui.ServerActionEndpoint.ServerAction,
                serverActionInput,
                b.MakeAction((SyntaxBuilder b, Var<TState> model, Var<Metapsi.Ui.ServerActionResponse> result) =>
                {
                    var resultObject = b.Deserialize<TInputData>(b.Get(result, x => x.SerializedModel));
                    return b.MakeActionDescriptor(onResult, resultObject);
                }),
                onError);

            return input;
        }
    }
}
