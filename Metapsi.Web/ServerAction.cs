using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Reflection;


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

    public static Var<HyperType.Action<TModel, TInput>> CallServerAction<TModel, TInput, TOutput>(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
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
                b.CallDelegateServerActionEffect(serverActionUrl, action, parameters, onSuccess, onError));
        });
    }

    public static Var<HyperType.Action<TModel, TInput>> CallServerAction<TModel, TInput>(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
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
                    serverActionUrl,
                    action,
                    parameters,
                    onSuccess,
                    onError));
        });
    }

    public static Var<HyperType.Action<TModel>> CallServerAction<TModel>(
        this SyntaxBuilder b,
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

    public static Var<HyperType.Action<TModel>> CallServerAction<TModel, TInput, TOutput>(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
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
                b.CallDelegateServerActionEffect(serverActionUrl, action, parameters, onSuccess, onError));
        });
    }

    public static Var<HyperType.Action<TModel>> CallServerAction<TModel, TInput, TOutput>(
        this SyntaxBuilder b,
        Var<string> serverActionUrl,
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
                b.CallDelegateServerActionEffect(serverActionUrl, action, parameters, onSuccess, onError));
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
        b.AddMetadata(new Metadata() { Key = "server-action", Value = serverAction.Method.Name });
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

    //public static System.Delegate FindDelegate(this ServerAction.Call serverAction)
    //{
    //    var methodInfo = FindMethodInfo(serverAction);
    //    var d = System.Delegate.CreateDelegate(Type.GetType(serverAction.Delegate.DelegateType), methodInfo);
    //    return d;
    //}

    public static object GetParameterByName(this ServerAction.Call serverCall, string parameterName)
    {
        var methodInfo = serverCall.FindMethodInfo();
        var methodInfoParameters = methodInfo.GetParameters();
        for (int i = 0; i < methodInfoParameters.Count(); i++)
        {
            if (methodInfoParameters[i].Name == parameterName)
            {
                return Metapsi.Serialize.FromJson(methodInfoParameters[i].ParameterType, serverCall.JsonParameters[i]);
            }
        }

        throw new Exception($"Parameter {parameterName} not found!");
    }

    public static T GetParameterByName<T>(this ServerAction.Call serverCall, string parameterName)
    {
        var methodInfo = serverCall.FindMethodInfo();
        var methodInfoParameters = methodInfo.GetParameters();
        for (int i = 0; i < methodInfoParameters.Count(); i++)
        {
            if (methodInfoParameters[i].Name == parameterName)
            {
                return Metapsi.Serialize.FromJson<T>(serverCall.JsonParameters[i]);
            }
        }

        throw new Exception($"Parameter {parameterName} not found!");
    }

    public static object GetParameterByIndex(this ServerAction.Call serverCall, int index)
    {
        var methodInfo = serverCall.FindMethodInfo();
        var methodInfoParameters = methodInfo.GetParameters();
        if (methodInfoParameters.Length < index)
        {
            throw new Exception($"Parameter index {index} not found!");
        }
        var parameter = methodInfoParameters[index];

        return Metapsi.Serialize.FromJson(parameter.ParameterType, serverCall.JsonParameters[index]);
    }

    public static T GetParameterByIndex<T>(this ServerAction.Call serverCall, int index)
    {
        var methodInfo = serverCall.FindMethodInfo();
        var methodInfoParameters = methodInfo.GetParameters();
        if (methodInfoParameters.Length < index)
        {
            throw new Exception($"Parameter index {index} not found!");
        }
        var parameter = methodInfoParameters[index];

        return Metapsi.Serialize.FromJson<T>(serverCall.JsonParameters[index]);
    }

    public static T GetParameterByType<T>(this ServerAction.Call serverCall)
    {
        var methodInfo = serverCall.FindMethodInfo();
        var methodInfoParameters = methodInfo.GetParameters();
        var parametersOfType = methodInfoParameters.Where(x => x.ParameterType == typeof(T));
        if (!parametersOfType.Any())
        {
            throw new Exception($"Parameter of type {typeof(T).Name} not found");
        }
        if (parametersOfType.Count() > 1)
        {
            throw new Exception($"Multiple parameters of type {typeof(T).Name} in server call");
        }
        return Metapsi.Serialize.FromJson<T>(serverCall.JsonParameters[parametersOfType.Single().Position]);
    }

    public static void UpdateParameterByType<T>(this ServerAction.Call serverCall, Action<T> update)
    {
        var methodInfo = serverCall.FindMethodInfo();
        var methodInfoParameters = methodInfo.GetParameters();
        var parametersOfType = methodInfoParameters.Where(x => x.ParameterType == typeof(T));
        if (!parametersOfType.Any())
        {
            throw new Exception($"Parameter of type {typeof(T).Name} not found");
        }
        if (parametersOfType.Count() > 1)
        {
            throw new Exception($"Multiple parameters of type {typeof(T).Name} in server call");
        }
        var parameterObject = Metapsi.Serialize.FromJson<T>(serverCall.JsonParameters[parametersOfType.Single().Position]);
        update(parameterObject);
        serverCall.JsonParameters[parametersOfType.Single().Position] = Metapsi.Serialize.ToJson(parameterObject);
    }

    public static async Task<dynamic> Run(this ServerAction.Call serverCall, List<Type> whitelistClasses)
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
            parameters[i] = Metapsi.Serialize.FromJson(methodInfoParameters[i].ParameterType, serverCall.JsonParameters[i]);
        }

        var result = methodInfo.Invoke(target, parameters);
        if (result is Task)
        {
            await (Task)result;
            result = ((dynamic)result).Result;
        }

        return result;
    }
}