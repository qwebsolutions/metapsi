using Metapsi.Syntax;

namespace Metapsi.Html;

public static class HtmlFormExtensions
{
    public static void SetMethodPost(this AttributesBuilder<HtmlForm> b)
    {
        b.SetAttribute("method", "POST");
    }

    public static void SetMethodPost(this PropsBuilder<HtmlForm> b)
    {
        b.SetAttribute("method", "POST");
    }

    public static void SetAction(this PropsBuilder<HtmlForm> b, Var<string> action)
    {
        b.SetAttribute("action", action);
    }

    public static void SetAction(this PropsBuilder<HtmlForm> b, string action)
    {
        b.SetAction(b.Const(action));
    }
}