using Metapsi.Syntax;
using Metapsi.Dom;

namespace Metapsi.Hyperapp
{
    public static class LocalStorage
    {
        public static void LocalStorageSetItem<T>(SyntaxBuilder b, Var<string> key, Var<T> item)
        {
            var asJson = b.Serialize(item);
            b.CallExternal(nameof(LocalStorage), "SetItem", key, asJson);
        }

        public static Var<T> LocalStorageGetItem<T>(SyntaxBuilder b, Var<string> key)
        {
            var json = b.CallExternal<string>(nameof(LocalStorage), "GetItem", key);
            b.Log(json);
            return b.Deserialize<T>(json);
        }

        public static void LocalStorageRemoveItem(SyntaxBuilder b, Var<string> key)
        {
            b.CallExternal(nameof(LocalStorage), "RemoveItem", key);
        }

        public static Var<HyperType.Effect> LocalStorageStore<TItem>(this SyntaxBuilder b, Var<string> key, Var<TItem> item)
        {
            return b.MakeEffect(b.Def((SyntaxBuilder b, Var<HyperType.Dispatcher<object>> dispatch) =>
            {
                b.RequestAnimationFrame(b.Def((SyntaxBuilder b) =>
                {
                    LocalStorageSetItem<TItem>(b, key, item);
                }));
            }));
        }

        public static Var<HyperType.Effect> LocalStorageLoad<TState, TItem>(this SyntaxBuilder b, Var<string> key, Var<HyperType.Action<TState, TItem>> onLoaded)
            where TItem: new()
        {
            var effecterAction = (SyntaxBuilder b, Var<HyperType.Dispatcher<TState>> dispatch, Var<TItem> item) =>
            {
                b.Dispatch(dispatch, b.MakeActionDescriptor(onLoaded, item));
            };

            //var effecter = b.MakeEffecter<TState, TItem>(effecterAction);

            var loadedItem = LocalStorageGetItem<TItem>(b, key);
            var returnedItem = b.If(
                b.HasObject(loadedItem),
                b => loadedItem,
                b => b.NewObj<TItem>());
            return b.MakeEffect(b.Def(effecterAction), returnedItem);
        }
    }
}
