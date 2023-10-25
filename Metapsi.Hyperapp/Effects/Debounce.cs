using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static class Effect
    {
        public static Var<HyperType.Effect> Debounce<TState>(
            this SyntaxBuilder b,
            Var<int> delayMs,
            Var<HyperType.Action<TState>> action)
        {
            var debounceProps = b.NewObj<DynamicObject>();
            b.SetDynamic(debounceProps, new DynamicProperty<int>("wait"), delayMs);
            b.SetDynamic(debounceProps, new DynamicProperty<HyperType.Action<TState>>("action"), action);

            var debounceEffect = b.CallExternal<HyperType.Effect>("Debounce", "Debounce", debounceProps);
            return debounceEffect;
        }
    }
}
