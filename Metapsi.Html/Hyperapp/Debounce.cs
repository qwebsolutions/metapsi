using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    public static class Effect
    {
        public static Var<HyperType.Effect> Debounce<TState>(
            this SyntaxBuilder b,
            Var<int> delayMs,
            Var<HyperType.Action<TState>> action)
        {
            var debounceProps = b.NewObj<object>();
            b.SetProperty(debounceProps, b.Const("wait"), delayMs);
            b.SetProperty(debounceProps, b.Const("action"), action);

            var debounce = b.ImportName<Func<object, HyperType.Effect>>("Debounce.js", "Debounce");
            return b.Call(debounce, debounceProps);
        }
    }
}
