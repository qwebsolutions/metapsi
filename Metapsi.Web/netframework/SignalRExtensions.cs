using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Html;
using System.Threading.Tasks;
using System;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

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
    public static IClientProxy From(dynamic clientProxy)
    {
        return clientProxy as IClientProxy;
    }
}

public class DefaultMetapsiSignalRHub : Hub
{
}

public static partial class SignalRClient
{
    public static async Task RaiseEvent(this IClientProxy clientProxy, string eventName)
    {
        await clientProxy.Invoke(RaiseEventCode, new RaiseEventArgs<object>()
        {
            EventName = eventName
        });
    }

    public static async Task RaiseCustomEvent<T>(this IClientProxy clientProxy, string eventName, T eventArgs)
    {
        await clientProxy.Invoke(RaiseEventCode, new RaiseEventArgs<T>()
        {
            EventName = eventName,
            EventArgs = eventArgs
        });
    }

    public static void Connect(SyntaxBuilder b, string hubPath, Var<System.Action<SignalRConnection>> register, Var<System.Action> onConnect)
    {
        var resource = b.AddEmbeddedResourceMetadata(typeof(SignalRClient).Assembly, "metapsi-signalr.js");
        var connect = b.ImportName<Action<string, Action<SignalRConnection>, Action>>(resource, "Connect");
        b.Call(connect, b.Const(hubPath), register, onConnect);
    }
}
