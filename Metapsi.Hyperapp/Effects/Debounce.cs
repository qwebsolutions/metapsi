﻿using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{


    public static class Effect
    {
        //private static class Debounce
        //{
        //    public class Props<TState>
        //    {
        //        public int WaitMs { get; set; }
        //        public HyperType.Action<TState> Action { get; set; }
        //    }
        //}

        public static Var<HyperType.Effect> Debounce<TState>(
            this BlockBuilder b,
            Var<int> delayMs,
            Var<HyperType.Action<TState>> action)
        {
            var debounceProps = b.NewObj<DynamicObject>();
            b.Set(debounceProps, new DynamicProperty<int>("wait"), delayMs);
            b.Set(debounceProps, new DynamicProperty<HyperType.Action<TState>>("action"), action);

            var debounceEffect = b.CallExternal<HyperType.Effect>("Debounce", "Debounce", debounceProps);
            return debounceEffect;
        }
    }
}
