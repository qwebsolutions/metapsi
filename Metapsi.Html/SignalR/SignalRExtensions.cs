using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Html;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.SignalR;

namespace Metapsi.SignalR;

public class SignalRConnection
{

}

public class RaiseEventArgs
{
    public string EventName { get; set; }
    public object EventArgs { get; set; }
}

public class RaiseEventArgs<T>
{
    public string EventName { get; set; }
    public T EventArgs { get; set; }
}

public static class SignalRExtensions
{
    public const string RaiseEventCode = "raiseEvent";

    ///// <summary>
    ///// Configures the SignalR serializer to work with json payloads
    ///// </summary>
    ///// <param name="builder"></param>
    ///// <returns></returns>
    //public static WebApplicationBuilder AddMetapsiSignalR(this WebApplicationBuilder builder)
    //{
    //    builder.Services.AddSignalR()
    //        .AddJsonProtocol(options =>
    //        {
    //            options.PayloadSerializerOptions.PropertyNamingPolicy = null;
    //        });
    //    return builder;
    //}

    ///// <summary>
    ///// Adds a SignalR hub on DefaultMetapsiSignalRHub.Path
    ///// </summary>
    ///// <param name="builder"></param>
    ///// <returns></returns>
    //public static HubEndpointConventionBuilder MapDefaultSignalRHub(this IEndpointRouteBuilder builder)
    //{
    //    var hubBuilder = builder.MapHub<DefaultMetapsiSignalRHub>(DefaultMetapsiSignalRHub.Path);
    //    DefaultMetapsiSignalRHub.HubContext = builder.ServiceProvider.GetService(typeof(IHubContext<DefaultMetapsiSignalRHub>)) as IHubContext<DefaultMetapsiSignalRHub>;
    //    return hubBuilder;
    //}

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

    public static Var<HyperType.Effect> SignalRConnect(
        this SyntaxBuilder b,
        string hubPath,
        System.Action<PropsBuilder<SignalRConnection>> setProps = null,
        System.Action<SyntaxBuilder, Var<HyperType.Dispatcher>> onConnected = null)
    {
        if (setProps == null)
        {
            setProps = b => b.ListenToServerEvents();
        }

        return b.MakeEffect(
            (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch) =>
            {
                Connect(b,
                    hubPath,
                    b.Def((SyntaxBuilder b, Var<SignalRConnection> connection) =>
                    {
                        b.SetProps(connection, setProps);
                    }),
                    b.Def((SyntaxBuilder b) =>
                    {
                        if (onConnected != null)
                            b.Call(onConnected, dispatch);
                    }));
            });
    }

    public static void Connect(SyntaxBuilder b, string hubPath, Var<System.Action<SignalRConnection>> register, Var<System.Action> onConnect)
    {
        b.AddEmbeddedResourceMetadata(typeof(SignalRExtensions).Assembly, "signalr.js");
        b.AddEmbeddedResourceMetadata(typeof(SignalRExtensions).Assembly, "metapsi-signalr.js");
        var connect = b.ImportName<Action<string, Action<SignalRConnection>, Action>>("metapsi-signalr", "Connect");
        b.Call(connect, b.Const(hubPath), register, onConnect);
    }

    public static void ListenToServerEvents(this PropsBuilder<SignalRConnection> b)
    {
        b.CallOnObject(b.Props, "on", b.Const(RaiseEventCode), b.Def((SyntaxBuilder b, Var<RaiseEventArgs> eventArgs) =>
        {
            b.Log("SignalR received event:", eventArgs);
            b.DispatchEvent(
                b.Window(), 
                b.NewCustomEvent(
                    b.Get(eventArgs, x => x.EventName), 
                    b.Get(eventArgs, x => x.EventArgs)));
        }));
    }
}
