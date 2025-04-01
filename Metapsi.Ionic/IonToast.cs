using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Ionic;

public static partial class IonToastControl
{
    /// <summary>
    /// Creates and displays a ion-toast on the spot. The element will be automatically removed from DOM when dismissed
    /// </summary>
    /// <param name="b"></param>
    /// <param name="setOptions"></param>
    /// <remarks>This runs outside of the virtual DOM. You cannot directly attach event handlers in <paramref name="setOptions"/></remarks>
    public static Var<Promise> IonToastPresent(this SyntaxBuilder b, System.Action<PropsBuilder<IonToast>> setOptions)
    {
        var toast = b.CreateElement(b.Const("ion-toast"));
        b.SetProps(toast, setOptions);
        b.AddEventListener(toast, b.Const("didDismiss"), b.Def((SyntaxBuilder b, Var<Metapsi.Html.Event> e) =>
        {
            // I don't know why, but the toast is added back to the DOM if it is removed without some delay
            b.RequestAnimationFrame(b =>
            {
                var currentTarget = b.Get(e, x => x.target);
                b.CallOnObject(currentTarget, "remove");
            });
        }));

        b.NodeAppendChild(b.QuerySelector("ion-app"), toast);
        return b.CallOnObject<Promise>(toast, "present");
    }
}