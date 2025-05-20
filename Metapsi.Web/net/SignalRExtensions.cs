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
        b.AddEmbeddedResourceMetadata(typeof(SignalRClient).Assembly, "signalr.js");
        b.AddEmbeddedResourceMetadata(typeof(SignalRClient).Assembly, "metapsi-signalr.js");
        var connect = b.ImportName<Action<string, Action<SignalRConnection>, Action>>("metapsi-signalr", "Connect");
        b.Call(connect, b.Const(hubPath), register, onConnect);
    }
}
