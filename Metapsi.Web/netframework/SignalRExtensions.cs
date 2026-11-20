using Metapsi.Syntax;
namespace Metapsi.SignalR;

public static partial class SignalRClient
{
    //private static readonly EmbeddedResource MetapsiSignalRJs = EmbeddedResource.Hashed(typeof(SignalRClient).Assembly, "metapsi-signalr.js");

    //public static async Task RaiseEvent(this IClientNotifier clientNotifier, string eventName)
    //{
    //    await clientProxy.Invoke(RaiseEventCode, new RaiseEventArgs<object>()
    //    {
    //        EventName = eventName
    //    });
    //}

    //public static async Task RaiseCustomEvent<T>(this IClientNotifier clientProxy, string eventName, T eventArgs)
    //{
    //    await clientProxy.

    //    await clientProxy.Invoke(RaiseEventCode, new RaiseEventArgs<T>()
    //    {
    //        EventName = eventName,
    //        EventArgs = eventArgs
    //    });
    //}

    public static void Connect(SyntaxBuilder b, string hubPath, Var<System.Action<SignalRConnection>> register, Var<System.Action> onConnect)
    {
        var signalRNoJQueryPath = b.ResolvePath(
            EmbeddedResource.Versioned(
                typeof(SignalRClient).Assembly,
                "0.2.1",
                "signalr-no-jquery@0.2.1.js"));

        var signalrNoJquery = b.ImportName<object>(signalRNoJQueryPath, "signalrNoJquery");
        b.On(signalrNoJquery, b =>
        {
            var connection = b.Call<object>("hubConnection", b.Const("/signalR"));
            var signalRConnection = b.On(connection, b => b.Call<SignalRConnection>("createHubProxy", b.Const(hubPath)));
            b.Call(register, signalRConnection);

            b.On(
                connection, b =>
                b.Call<object>("start")
                .Call<object>("done", b.Def((SyntaxBuilder b) => b.Call(onConnect)))
                .Call("fail", b.Def((SyntaxBuilder b) => b.Log("Could not connect"))));
        });
    }
}
