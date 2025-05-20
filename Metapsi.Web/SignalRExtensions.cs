using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Html;
using System.Threading.Tasks;
using System;
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

public static partial class SignalRClient
{
    public const string RaiseEventCode = "raiseEvent";

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
