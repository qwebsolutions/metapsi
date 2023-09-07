using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;

public static class ServerExtensions
{
    public static Var<HyperType.Action<TState, TPayload>> MakeServerAction<TState, TPayload>(
        this BlockBuilder b,
        Var<TState> model,
        Func<TState, TPayload, TState> onServerAction)
        where TState : IApiSupportState
    {
        return MakeServerAction<TState, TPayload>(b, model, onServerAction.Method);
    }

    public static Var<HyperType.Action<TState, TPayload>> MakeServerAction<TState, TPayload>(
        this BlockBuilder b,
        Var<TState> model,
        Func<CommandContext, TState, TPayload, System.Threading.Tasks.Task<TState>> onServerAction)
        where TState : IApiSupportState
    {
        return MakeServerAction<TState, TPayload>(b, model, onServerAction.Method);
    }

    public static Var<HyperType.Action<TState>> MakeServerAction<TState>(
        this BlockBuilder b,
        Var<TState> model,
        Func<CommandContext, TState, System.Threading.Tasks.Task<TState>> onServerAction)
        where TState : IApiSupportState
    {
        return MakeServerAction<TState>(b, model, onServerAction.Method);
    }

    private static Var<HyperType.Action<TState, TPayload>> MakeServerAction<TState, TPayload>(
            this BlockBuilder b,
            Var<TState> model,
            System.Reflection.MethodInfo method)
            where TState : IApiSupportState
    {
        var clientAction = b.MakeAction((BlockBuilder b, Var<TState> state, Var<TPayload> payload) =>
        {
            var serverActionInput = b.NewObj<Metapsi.Ui.ServerActionInput>();
            b.Set(serverActionInput, x => x.SerializedModel, b.Serialize(state));
            b.Set(serverActionInput, x => x.SerializedPayload, b.Serialize(payload));
            b.Set(serverActionInput, x => x.HandlerMethod, b.Const(method.Name));
            b.Set(serverActionInput, x => x.QualifiedHandlerClass, b.Const(method.DeclaringType.AssemblyQualifiedName));

            return b.AsyncResult(
                b.ShowPanel(model),
                b.Request(
                    Metapsi.Ui.ServerActionEndpoint.ServerAction,
                    serverActionInput,
                    b.MakeAction((BlockBuilder b, Var<TState> model, Var<Metapsi.Ui.ServerActionResponse> result) =>
                    {
                        return b.Deserialize<TState>(b.Get(result, x => x.SerializedModel));
                    })));
        });

        return clientAction;
    }

    private static Var<HyperType.Action<TState>> MakeServerAction<TState>(
        this BlockBuilder b,
        Var<TState> model,
        System.Reflection.MethodInfo method)
        where TState : IApiSupportState
    {
        var clientAction = b.MakeAction((BlockBuilder b, Var<TState> state) =>
        {
            var serverActionInput = b.NewObj<Metapsi.Ui.ServerActionInput>();
            b.Set(serverActionInput, x => x.SerializedModel, b.Serialize(state));
            b.Set(serverActionInput, x => x.HandlerMethod, b.Const(method.Name));
            b.Set(serverActionInput, x => x.QualifiedHandlerClass, b.Const(method.DeclaringType.AssemblyQualifiedName));

            return b.AsyncResult(
                b.ShowPanel(model),
                b.Request(
                    Metapsi.Ui.ServerActionEndpoint.ServerAction,
                    serverActionInput,
                    b.MakeAction((BlockBuilder b, Var<TState> model, Var<Metapsi.Ui.ServerActionResponse> result) =>
                    {
                        var newModel = b.Deserialize<TState>(b.Get(result, x => x.SerializedModel));
                        b.DispatchEvent(b.Const("sharedStateUpdate"), newModel);
                        return newModel;
                    })));
        });

        return clientAction;
    }
}
