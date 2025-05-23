using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using Metapsi.Hyperapp;
using Metapsi.Syntax;


namespace Metapsi;

public static partial class ServerAction
{
    public class Call
    {
        public string MethodName { get; set; }
        public List<string> Parameters { get; set; }
    }

    private static Reference<string> ServerActionUrl = new Reference<string>();

    public static void SetServerActionUrl(this SyntaxBuilder b, string url)
    {
        b.Log("Set server action url", b.Const(url));
        b.SetRef(b.Const(ServerActionUrl), b.Const(url));
    }

    public static Var<HyperType.Action<TModel, TInput>> CallServer<TModel, TInput, TOutput>(
        this SyntaxBuilder b,
        Func<TModel, TInput, Task<TOutput>> action,
        Var<HyperType.Action<TModel, TOutput>> onSuccess,
        Var<HyperType.Action<TModel, Html.Error>> onError)
    {
        return b.MakeAction((SyntaxBuilder b, Var<TModel> model, Var<TInput> input) =>
        {
            var parameters = b.NewCollection<object>();
            b.Push(parameters, model.As<object>());
            b.Push(parameters, input.As<object>());
            return b.MakeStateWithEffects(
                model,
                b.CallDelegateServerActionEffect(parameters, action, onSuccess, onError));
        });
    }

    public static Var<HyperType.Action<TModel, TInput>> CallServer<TModel, TInput>(
        this SyntaxBuilder b,
        Func<TModel, TInput, Task<TModel>> action,
        Var<HyperType.Action<TModel, TModel>> onSuccess = null,
        Var<HyperType.Action<TModel, Html.Error>> onError = null)
    {
        if (onSuccess == null)
        {
            onSuccess = b.MakeAction((SyntaxBuilder b, Var<TModel> model, Var<TModel> newModel) => newModel);
        }

        if (onError == null)
        {
            onError = b.AlertOnException<TModel>();
        }

        return b.MakeAction((SyntaxBuilder b, Var<TModel> model, Var<TInput> input) =>
        {
            var parameters = b.NewCollection<object>();
            b.Push(parameters, model.As<object>());
            b.Push(parameters, input.As<object>());
            return b.MakeStateWithEffects(
                model,
                b.CallDelegateServerActionEffect(
                    parameters,
                    action,
                    onSuccess,
                    onError));
        });
    }

    public static Var<HyperType.Action<TModel>> CallServer<TModel>(
        this SyntaxBuilder b,
        Func<TModel, Task<TModel>> action,
        Var<HyperType.Action<TModel, TModel>> onSuccess = null,
        Var<HyperType.Action<TModel, Html.Error>> onError = null)
    {
        if (onSuccess == null)
        {
            onSuccess = b.MakeAction((SyntaxBuilder b, Var<TModel> model, Var<TModel> newModel) => newModel);
        }

        if (onError == null)
        {
            onError = b.AlertOnException<TModel>();
        }

        return b.MakeAction((SyntaxBuilder b, Var<TModel> model) =>
        {
            var parameters = b.NewCollection<object>();
            b.Push(parameters, model.As<object>());
            return b.MakeStateWithEffects(
                model,
                b.CallDelegateServerActionEffect(
                    parameters,
                    action,
                    onSuccess,
                    onError));
        });
    }

    public static Var<HyperType.Action<TModel>> CallServer<TModel, TInput, TOutput>(
        this SyntaxBuilder b,
        Var<TInput> input,
        Func<TInput, Task<TOutput>> action,
        Var<HyperType.Action<TModel, TOutput>> onSuccess,
        Var<HyperType.Action<TModel, Html.Error>> onError)
    {
        return b.MakeAction((SyntaxBuilder b, Var<TModel> model) =>
        {
            var parameters = b.NewCollection<object>();
            b.Push(parameters, input.As<object>());
            return b.MakeStateWithEffects(
                model,
                b.CallDelegateServerActionEffect(parameters, action, onSuccess, onError));
        });
    }

    public static Var<HyperType.Action<TModel>> CallServer<TModel, TInput, TOutput>(
        this SyntaxBuilder b,
        Var<TInput> input,
        Func<TModel, TInput, Task<TOutput>> action,
        Var<HyperType.Action<TModel, TOutput>> onSuccess,
        Var<HyperType.Action<TModel, Html.Error>> onError)
    {
        return b.MakeAction((SyntaxBuilder b, Var<TModel> model) =>
        {
            var parameters = b.NewCollection<object>();
            b.Push(parameters, model.As<object>());
            b.Push(parameters, input.As<object>());
            return b.MakeStateWithEffects(
                model,
                b.CallDelegateServerActionEffect(parameters, action, onSuccess, onError));
        });
    }

    public static Var<HyperType.Effect> CallDelegateServerActionEffect<TModel, TOutput>(
        this SyntaxBuilder b,
        Var<List<object>> parameters,
        Delegate serverAction,
        Var<HyperType.Action<TModel, TOutput>> onSuccess,
        Var<HyperType.Action<TModel, Html.Error>> onError)
    {
        b.AddMetadata(new Metadata() { Key = "server-action", Value = serverAction.Method.Name });
        ServerAction.Store(serverAction);
        var serverActionUrl = b.GetRef(b.Const(ServerActionUrl));
        b.Log("Call delegate server action url", serverActionUrl);
        return b.PostJsonEffect<TModel, ServerAction.Call, TOutput>(
            serverActionUrl,
            b.NewObj<ServerAction.Call>(
                b =>
                {
                    b.Set(x => x.MethodName, serverAction.Method.Name);
                    b.Set(x => x.Parameters, b.Map(parameters, (b, item) => b.Serialize(item)));
                }),
            onSuccess,
            onError);
    }

    internal class ServerActionDelegate
    {
        internal Delegate Delegate { get; set; }

        // Store types once so we avoid reflection on every call
        internal List<Type> ParameterTypes { get; set; } = new List<Type>();
        internal Type ReturnType { get; set; }
    }

    private static TaskQueue<Dictionary<string, ServerActionDelegate>> actionsQueue = new(new Dictionary<string, ServerActionDelegate>());

    public static string PostPath = "/_Server_Action_";

    //public class Call
    //{
    //    public string MethodName { get; set; }
    //    public List<string> Parameters { get; set; }
    //}

    public static void Store(Delegate action)
    {
        var _ = actionsQueue.Enqueue(async (actions) =>
        {
            if (!actions.ContainsKey(action.Method.Name))
            {
                ServerActionDelegate serverActionDelegate = new ServerActionDelegate()
                {
                    Delegate = action
                };

                foreach (var parameter in action.Method.GetParameters())
                {
                    serverActionDelegate.ParameterTypes.Add(parameter.ParameterType);
                }

                actions[action.Method.Name] = serverActionDelegate;
            }
        });
    }

    internal static async Task<ServerActionDelegate> Get(string name)
    {
        return await actionsQueue.Enqueue(async (actions) =>
        {
            var found = actions.TryGetValue(name, out ServerActionDelegate action);
            if (!found)
            {
                throw new Exception($"Action {name} not registered!");
            }
            return action;
        });
    }

    public static async Task<dynamic> Run(ServerAction.Call serverCall)
    {
        var serverActionDelegate = await ServerAction.Get(serverCall.MethodName);
        object[] parameters = new object[serverActionDelegate.ParameterTypes.Count];
        for (int i = 0; i < serverActionDelegate.ParameterTypes.Count; i++)
        {
            parameters[i] = Metapsi.Serialize.FromJson(serverActionDelegate.ParameterTypes[i], serverCall.Parameters[i]);
        }

        var result = serverActionDelegate.Delegate.DynamicInvoke(parameters);
        if (result is Task)
        {
            await (Task)result;
            result = ((dynamic)result).Result;
        }

        return result;
    }
}