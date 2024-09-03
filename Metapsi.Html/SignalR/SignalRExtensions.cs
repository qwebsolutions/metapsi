using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Html;
namespace Metapsi.SignalR;

public class SignalRConnection
{

}

public class RaiseEventArgs
{
    public string EventName { get; set; }
    public DynamicObject EventArgs { get; set; }
}

public class RaiseEventArgs<T>
{
    public string EventName { get; set; }
    public T EventArgs { get; set; }
}

public static class SignalRExtensions
{
    public const string RaiseEventCode = "raiseEvent";

    public static Var<HyperType.Effect> InitializeSignalREffect(
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
        StaticFiles.AddAll(typeof(SignalRExtensions).Assembly);
        b.CallExternal("Metapsi.SignalR", "Connect", b.Const(hubPath), register, onConnect);
    }

    //public static async Task RaiseEvent<T>(this IClientProxy clientProxy, T eventArgs)
    //{
    //    await clientProxy.SendAsync(RaiseEventCode, new RaiseEventArgs<T>()
    //    {
    //        EventName = typeof(T).Name,
    //        EventArgs = eventArgs
    //    });
    //}

    public static void ListenToServerEvents(this PropsBuilder<SignalRConnection> b)
    {
        b.CallOnObject(b.Props, "on", b.Const(RaiseEventCode), b.Def((SyntaxBuilder b, Var<RaiseEventArgs> eventArgs) =>
        {
            b.Log("SignalR received event:", eventArgs);
            b.DispatchCustomEvent(b.Get(eventArgs, x => x.EventName), b.Get(eventArgs, x => x.EventArgs));
        }));
    }
}
