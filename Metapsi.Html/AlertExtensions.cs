using Metapsi.Syntax;

namespace Metapsi.Html;

public static class AlertExtensions
{
    public static void Alert(this SyntaxBuilder b, Var<string> message)
    {
        b.CallOnObject(b.Window(), "alert", message);
    }

    public static void Alert(this SyntaxBuilder b, string message)
    {
        b.Alert(b.Const(message));
    }
}