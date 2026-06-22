using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Html;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.SignalR;

namespace Metapsi.SignalR;

public class HubContext
{
    public HubContext(IHubContext context)
    {
        Context = context;
    }

    public IHubContext Context { get; set; }
}

public class ClientProxy
{
    public static IClientProxy From(IClientProxy clientProxy)
    {
        return clientProxy;
    }
}

public class DefaultMetapsiSignalRHub : Hub
{
}

public static partial class SignalRClient
{
    public static async Task RaiseEvent(this IClientProxy clientProxy, string eventName)
    {
        await clientProxy.SendAsync(RaiseEventCode, new RaiseEventArgs<object>()
        {
            EventName = eventName
        });
    }

    public static async Task RaiseCustomEvent<T>(this IClientProxy clientProxy, string eventName, T eventArgs)
    {
        await clientProxy.SendAsync(RaiseEventCode, new RaiseEventArgs<T>()
        {
            EventName = eventName,
            EventArgs = eventArgs
        });
    }

    public static void Connect(SyntaxBuilder b, string hubPath, Var<System.Action<SignalRConnection>> register, Var<System.Action> onConnect)
    {
        b.Call(b.Def<SyntaxBuilder, string, Action<SignalRConnection>, Action>(SignalRConnect), b.Const(hubPath), register, onConnect);
    }

    private static void SignalRConnect(SyntaxBuilder b, Var<string> hubPath, Var<System.Action<SignalRConnection>> register, Var<System.Action> onConnect)
    {
        var signalRJsPath = b.ResolvePath(new HashedEmbeddedResource()
        {
            Assembly = typeof(SignalRClient).Assembly,
            LogicalName = "signalr.js"
        });

        var hubConnectionBuilder = b.ImportName<ClassDef<object>>(signalRJsPath, "HubConnectionBuilder");
        var logLevel = b.ImportName<object>(signalRJsPath, "LogLevel");
        var logLevelInformation = b.GetProperty<object>(logLevel, "Information");

        var connection = b.On(
            hubConnectionBuilder,
            b =>
            {
                return b.Construct().Call<object>("withUrl", hubPath).Call<object>("configureLogging", logLevelInformation).Call<SignalRConnection>("build");
            });

        b.Call(register, connection);
        b.On(connection,
            b =>
            {
                b.Call("onclose", b.Def((SyntaxBuilder b) =>
                {
                    return b.Call(Start, connection, onConnect);
                }));
            });
        b.Call(Start, connection, onConnect);
    }

    private static Var<Promise> RetryOnError(this ISyntaxBuilder b, Var<SignalRConnection> connection, Var<System.Action> onConnect)
    {
        return b.On(
            b.GetClass<Promise>(),
            b =>
            {
                var newPromise = b.Construct(b.Def((SyntaxBuilder b, Var<Action> resolve) =>
                {
                    b.SetTimeout(resolve, b.Const(5000));
                }));

                return b.On(newPromise,
                    b =>
                    {
                        return b.Call<Promise>("then", b.Def((SyntaxBuilder b) =>
                        {
                            return b.Call(Start, connection, onConnect);
                        }));
                    });
            });
    }

    private static Var<Promise> Start(this SyntaxBuilder b, Var<SignalRConnection> connection, Var<System.Action> onConnect)
    {
        var onConnectPromise = b.PromiseThen(b.CallOnObject<Promise>(connection, "start"), (SyntaxBuilder b, Var<object> _) =>
        {
            b.Call(onConnect);
            b.Log("SignalR Connected.");
        });

        return b.PromiseCatch(onConnectPromise, (SyntaxBuilder b, Var<Error> err) =>
        {
            b.Log(err);
            return b.Call(RetryOnError, connection, onConnect);
        });
    }
}
