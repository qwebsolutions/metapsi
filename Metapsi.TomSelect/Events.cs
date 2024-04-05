using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.TomSelect;

public static class Events
{
    public static void OnChange<TState>(this PropsBuilder<TomSelect> b, Var<HyperType.Action<TState, string>> onChange)
    {
        b.OnEventAction("change", onChange, "detail");
    }
}
