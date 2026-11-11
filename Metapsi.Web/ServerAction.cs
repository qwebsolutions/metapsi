using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Reflection;
using Metapsi.Html;


namespace Metapsi;

public static partial class ServerAction
{
    public class Delegate
    {
        //public string DelegateType { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
    }

    public class Call
    {
        public ServerAction.Delegate Delegate { get; set; }
        public List<string> JsonParameters { get; set; }
    }


    public static Var<HyperType.Effect> CallServerEffect<TIn, TServices, TOut>(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
        Var<TIn> requestPayload,
        Func<TIn, TServices, Task<TOut>> serverTask,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<TOut>> onResult,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Metapsi.Html.Error>> onError = null)
    {
        if (onError == null)
        {
            onError = (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<Metapsi.Html.Error> error) =>
            {
                b.Alert(b.Get(error, x => x.message));
            };
        }

        var parameters = b.NewCollection<object>();
        b.Push(parameters, requestPayload.As<object>());

        return b.PostJsonEffect(
            serverActionUrl,
            ServerAction.ToServerCall(
                b,
                ServerAction.ToServerAction(b, serverTask),
                parameters),
            onResult,
            onError);
    }

    public static Var<HyperType.Effect> CallServerEffect<TIn, TOut>(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
        Var<TIn> requestPayload,
        Func<TIn, Task<TOut>> serverTask,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<TOut>> onResult,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Metapsi.Html.Error>> onError = null)
    {
        if (onError == null)
        {
            onError = (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<Metapsi.Html.Error> error) =>
            {
                b.Alert(b.Get(error, x => x.message));
            };
        }

        var parameters = b.NewCollection<object>();
        b.Push(parameters, requestPayload.As<object>());

        return b.PostJsonEffect(
            serverActionUrl,
            ServerAction.ToServerCall(
                b,
                ServerAction.ToServerAction(b, serverTask),
                parameters),
            onResult,
            onError);
    }

    public static Var<HyperType.Effect> CallServerEffect<TIn, TServices>(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
        Var<TIn> requestPayload,
        Func<TIn, TServices, Task> serverTask,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>> onResult = null,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Metapsi.Html.Error>> onError = null)
    {
        if (onResult == null)
        {
            onResult = (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch) => { };
        }

        if (onError == null)
        {
            onError = (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<Metapsi.Html.Error> error) =>
            {
                b.Alert(b.Get(error, x => x.message));
            };
        }

        var parameters = b.NewCollection<object>();
        b.Push(parameters, requestPayload.As<object>());

        return b.PostJsonEffect(
            serverActionUrl,
            ServerAction.ToServerCall(
                b,
                ServerAction.ToServerAction(b, serverTask),
                parameters),
            onResult,
            onError);
    }

    public static Var<HyperType.Effect> CallServerEffect<TIn>(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
        Var<TIn> requestPayload,
        Func<TIn, Task> serverTask,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>> onResult = null,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Metapsi.Html.Error>> onError = null)
    {
        if (onResult == null)
        {
            onResult = (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch) => { };
        }

        if (onError == null)
        {
            onError = (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<Metapsi.Html.Error> error) =>
            {
                b.Alert(b.Get(error, x => x.message));
            };
        }

        var parameters = b.NewCollection<object>();
        b.Push(parameters, requestPayload.As<object>());

        return b.PostJsonEffect(
            serverActionUrl,
            ServerAction.ToServerCall(
                b,
                ServerAction.ToServerAction(b, serverTask),
                parameters),
            onResult,
            onError);
    }

    public static Var<HyperType.Effect> CallServerEffect<TServices, TOut>(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
        Func<TServices, Task<TOut>> serverTask,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<TOut>> onResult,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Metapsi.Html.Error>> onError = null)
    {
        if (onError == null)
        {
            onError = (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<Metapsi.Html.Error> error) =>
            {
                b.Alert(b.Get(error, x => x.message));
            };
        }

        var parameters = b.NewCollection<object>();

        return b.PostJsonEffect(
            serverActionUrl,
            ServerAction.ToServerCall(
                b,
                ServerAction.ToServerAction(b, serverTask),
                parameters),
            onResult,
            onError);
    }

    public static Var<HyperType.Effect> CallServerEffect<TServices>(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
        Func<TServices, Task> serverTask,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>> onResult = null,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Metapsi.Html.Error>> onError = null)
    {
        if (onResult == null)
        {
            onResult = (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch) => { };
        }

        if (onError == null)
        {
            onError = (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<Metapsi.Html.Error> error) =>
            {
                b.Alert(b.Get(error, x => x.message));
            };
        }

        var parameters = b.NewCollection<object>();

        return b.PostJsonEffect(
            serverActionUrl,
            ServerAction.ToServerCall(
                b,
                ServerAction.ToServerAction(b, serverTask),
                parameters),
            onResult,
            onError);
    }

    public static Var<HyperType.Effect> CallServerEffect(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
        Func<Task> serverTask,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>> onResult = null,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Metapsi.Html.Error>> onError = null)
    {
        if (onResult == null)
        {
            onResult = (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch) => { };
        }

        if (onError == null)
        {
            onError = (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<Metapsi.Html.Error> error) =>
            {
                b.Alert(b.Get(error, x => x.message));
            };
        }

        var parameters = b.NewCollection<object>();

        return b.PostJsonEffect(
            serverActionUrl,
            ServerAction.ToServerCall(
                b,
                ServerAction.ToServerAction(b, serverTask),
                parameters),
            onResult,
            onError);
    }

    /// <summary>
    /// Creates a client-side action that calls the server-side method <paramref name="action"/> passing in the model
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="serverActionUrl"></param>
    /// <param name="action"></param>
    /// <param name="onSuccess"></param>
    /// <param name="onError"></param>
    /// <returns></returns>
    public static Var<HyperType.Action<TModel>> CallServerAction<TModel>(
        this ISyntaxBuilder b,
        Var<string> serverActionUrl,
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
                    serverActionUrl,
                    action,
                    parameters,
                    onSuccess,
                    onError));
        });
    }

    /// <summary>
    /// Creates a client-side action that calls the server-side method <paramref name="action"/> passing in the model and <paramref name="argument"/>
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TArg"></typeparam>
    /// <param name="b"></param>
    /// <param name="serverActionUrl"></param>
    /// <param name="argument"></param>
    /// <param name="action"></param>
    /// <param name="onSuccess"></param>
    /// <param name="onError"></param>
    /// <returns></returns>
    public static Var<HyperType.Action<TModel>> CallServerAction<TModel, TArg>(
        this ISyntaxBuilder b,
        Var<string> serverActionUrl,
        Var<TArg> argument,
        Func<TModel, TArg, Task<TModel>> action,
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
            b.Push(parameters, argument.As<object>());
            return b.MakeStateWithEffects(
                model,
                b.CallDelegateServerActionEffect(
                    serverActionUrl,
                    action,
                    parameters,
                    onSuccess,
                    onError));
        });
    }

    /// <summary>
    /// Creates a client-side action that calls the server-side method <paramref name="action"/> passing in the model. <typeparamref name="TService"/> gets resolved server-side.
    /// See <see cref="ServerAction.Run(Call, IEnumerable{Type}, object[])"/>
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TService"></typeparam>
    /// <param name="b"></param>
    /// <param name="serverActionUrl"></param>
    /// <param name="action"></param>
    /// <param name="onSuccess"></param>
    /// <param name="onError"></param>
    /// <returns></returns>
    public static Var<HyperType.Action<TModel>> CallServerAction<TModel, TService>(
        this ISyntaxBuilder b,
        Var<string> serverActionUrl,
        Func<TModel, TService, Task<TModel>> action,
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
                    serverActionUrl,
                    action,
                    parameters,
                    onSuccess,
                    onError));
        });
    }

    /// <summary>
    /// Creates a client-side action that calls the server-side method <paramref name="action"/> passing in the model and <paramref name="argument"/>. <typeparamref name="TService"/> gets resolved server-side.
    /// See <see cref="ServerAction.Run(Call, IEnumerable{Type}, object[])"/>
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TArg"></typeparam>
    /// <typeparam name="TService"></typeparam>
    /// <param name="b"></param>
    /// <param name="serverActionUrl"></param>
    /// <param name="argument"></param>
    /// <param name="action"></param>
    /// <param name="onSuccess"></param>
    /// <param name="onError"></param>
    /// <returns></returns>
    public static Var<HyperType.Action<TModel>> CallServerAction<TModel, TArg, TService>(
        this ISyntaxBuilder b,
        Var<string> serverActionUrl,
        Var<TArg> argument,
        Func<TModel, TArg, TService, Task<TModel>> action,
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
            b.Push(parameters, argument.As<object>());
            return b.MakeStateWithEffects(
                model,
                b.CallDelegateServerActionEffect(
                    serverActionUrl,
                    action,
                    parameters,
                    onSuccess,
                    onError));
        });
    }


    public static Var<HyperType.Effect> CallDelegateServerActionEffect<TModel, TOutput>(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
        System.Delegate serverAction,
        Var<List<object>> parameters,
        Var<HyperType.Action<TModel, TOutput>> onSuccess,
        Var<HyperType.Action<TModel, Html.Error>> onError)
    {
        return b.PostJsonEffect<TModel, ServerAction.Call, TOutput>(
            serverActionUrl,
            ToServerCall(
                b,
                ToServerAction(b, serverAction),
                parameters),
            onSuccess,
            onError);
    }

    public static Var<ServerAction.Call> ToServerCall(SyntaxBuilder b, Var<ServerAction.Delegate> serverActionDelegate, Var<List<object>> parameters)
    {
        return b.NewObj<ServerAction.Call>(
            b =>
            {
                b.Set(x => x.Delegate, serverActionDelegate);
                b.Set(x => x.JsonParameters, b.Map(parameters, (b, item) => b.Serialize(item)));
            });
    }

    public static Var<ServerAction.Delegate> ToServerAction(SyntaxBuilder b, System.Delegate serverAction)
    {
        return b.NewObj<ServerAction.Delegate>(
            b =>
            {
                //b.Set(x => x.DelegateType, serverAction.GetType().GetSemiQualifiedTypeName());
                b.Set(x => x.ClassName, serverAction.Method.DeclaringType.GetParentNamedType().GetSemiQualifiedTypeName());
                b.Set(x => x.MethodName, serverAction.Method.Name);
            });
    }

    public static MethodInfo FindMethodInfo(this ServerAction.Call serverCall)
    {
        MethodInfo methodInfo = null;

        var declaringClass = Type.GetType(serverCall.Delegate.ClassName);
        Type[] nestedTypes = declaringClass.GetNestedTypes(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.DeclaredOnly);
        var allTypes = new List<Type>();
        allTypes.Add(declaringClass);
        allTypes.AddRange(nestedTypes);
        foreach (Type nestedType in allTypes)
        {
            // is static method
            methodInfo = nestedType.GetMethod(serverCall.Delegate.MethodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            if (methodInfo != null)
            {
                return methodInfo;
            }

            // is instance method, presume target type has default constructor
            methodInfo = nestedType.GetMethod(serverCall.Delegate.MethodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (methodInfo != null)
            {
                return methodInfo;
            }
        }

        throw new Exception($"Method info {serverCall.Delegate.ClassName}.{serverCall.Delegate.MethodName} not found!");
    }

    public static async Task<dynamic> Run(
        this ServerAction.Call serverCall,
        IEnumerable<Type> whitelistClasses,
        IJsonSerializer serializer,
        params object[] services)
    {
        if (!whitelistClasses.Any(x => x.GetSemiQualifiedTypeName() == serverCall.Delegate.ClassName))
            throw new Exception($"Class {serverCall.Delegate.ClassName} is not whitelisted");

        object target = null;
        MethodInfo methodInfo = null;

        var declaringClass = Type.GetType(serverCall.Delegate.ClassName);
        Type[] nestedTypes = declaringClass.GetNestedTypes(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.DeclaredOnly);
        var allTypes = new List<Type>();
        allTypes.Add(declaringClass);
        allTypes.AddRange(nestedTypes);
        foreach (Type nestedType in allTypes)
        {
            // is static method
            methodInfo = nestedType.GetMethod(serverCall.Delegate.MethodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            if (methodInfo != null)
            {
                break;
            }

            // is instance method, presume target type has default constructor
            methodInfo = nestedType.GetMethod(serverCall.Delegate.MethodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (methodInfo != null)
            {
                target = Activator.CreateInstance(nestedType);
                break;
            }
        }

        var methodInfoParameters = methodInfo.GetParameters();
        object[] parameters = new object[methodInfoParameters.Count()];
        for (int i = 0; i < methodInfoParameters.Count(); i++)
        {
            if (i < serverCall.JsonParameters.Count)
            {
                parameters[i] = serializer.FromJson(methodInfoParameters[i].ParameterType, serverCall.JsonParameters[i]);
            }
            else
            {
                var expectedServiceType = methodInfoParameters[i].ParameterType;
                var match = services.SingleOrDefault(x => expectedServiceType.IsAssignableFrom(x.GetType()));
                if (match != null)
                {
                    parameters[i] = match;
                }
                else
                {
                    throw new Exception("Could not match parameter type " + expectedServiceType.Name);
                }
            }
        }

        var result = methodInfo.Invoke(target, parameters);
        if (result is Task)
        {
            await (Task)result;
            if (
                methodInfo.ReturnType.IsGenericType &&
                methodInfo.ReturnType.GetGenericTypeDefinition() == typeof(Task<>))
            {
                // There's an actual return value to extract
                return ((dynamic)result).Result;
            }
            else
            {
                // The task returned nothing
                return string.Empty;
            }
        }

        // The method returned something but was not async
        return result;
    }
}