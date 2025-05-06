using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Html;

public static class ServerAction
{
    public class Call
    {
        public string MethodName { get; set; }
        public List<string> Parameters { get; set; }
    }

    private static Reference<string> ServerActionUrl = new Reference<string>();

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
        return b.PostJsonEffect<TModel, ServerAction.Call, TOutput>(
            b.GetRef(b.Const(ServerActionUrl)),
            b.NewObj<ServerAction.Call>(
                b =>
                {
                    b.Set(x => x.MethodName, serverAction.Method.Name);
                    b.Set(x => x.Parameters, b.Map(parameters, (b, item) => b.Serialize(item)));
                }),
            onSuccess,
            onError);
    }
}