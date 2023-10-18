using Metapsi.Dom;
using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static class EventProps
    {
        //public static void SetProp<T>(this PropsBuilder b, DynamicProperty<T> prop, Var<T> value)
        //{
        //    b.SetDynamic(b.Props, prop, value);
        //}

        //public static void SetProp<T>(this PropsBuilder b, DynamicProperty<T> prop, T value)
        //{
        //    b.SetDynamic(b.Props, prop, b.Const(value));
        //}

        //public static void OnInputAction<TState>(this PropsBuilder b, Var<HyperType.Action<TState, string>> onInput)
        //{
        //    var extractInputValue = b.MakeAction<TState, DomEvent<InputTarget>, string>((BlockBuilder b, Var<TState> state, Var<DomEvent<InputTarget>> @event) =>
        //    {
        //        var target = b.Get(@event, x => x.target);
        //        var value = b.Get(target, x => x.value);
        //        return b.MakeActionDescriptor<TState, string>(onInput, value);
        //    });

        //    b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TState, DomEvent<InputTarget>>>("oninput"), extractInputValue);
        //}

    }
}
