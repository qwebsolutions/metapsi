using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Ionic;

public static partial class IonModalControl
{
    /// <summary>
    /// The breakpoints to use when creating a sheet modal. Each value in the array must be a decimal between 0 and 1 where 0 indicates the modal is fully closed and 1 indicates the modal is fully open. Values are relative to the height of the modal, not the height of the screen. One of the values in this array must be the value of the `initialBreakpoint` property. For example: [0, .25, .5, 1]
    /// </summary>
    public static void SetBreakpoints<T>(this Metapsi.Syntax.PropsBuilder<T> b, params decimal[] breakpoints) where T : IonModal
    {
        b.SetBreakpoints(b.Const(new System.Collections.Generic.List<decimal>(breakpoints)));
    }

    public static Var<Promise> PresentIonModal<TElement>(this SyntaxBuilder b, Var<TElement> domElement) where TElement : Html.Element
    {
        return b.CallOnObject<Promise>(domElement, "present");
    }

    public static Var<Promise> PresentIonModal(this SyntaxBuilder b, Var<string> modalId)
    {
        return b.PresentIonModal(b.GetElementById(modalId));
    }

    public static Var<Promise> PresentIonModal(this SyntaxBuilder b, string modalId)
    {
        return b.PresentIonModal(b.Const(modalId));
    }

    public static Var<HyperType.Effect> PresentIonModalEffect(this SyntaxBuilder b, Var<string> modalId)
    {
        return b.MakeEffect(b => b.PresentIonModal(modalId));
    }

    public static Var<HyperType.Effect> PresentIonModalEffect<TModel>(this SyntaxBuilder b, Var<string> modalId, Var<HyperType.Action<TModel>> thenAction)
    {
        return b.MakeEffect(
        (b, dispatch) =>
        {
            var presentPromise = b.PresentIonModal(modalId);
            if (thenAction != null)
            {
                b.PromiseThen(presentPromise, (SyntaxBuilder b, Var<bool> result) =>
                {
                    b.Dispatch(dispatch, thenAction);
                });
            }
        });
    }

    public static Var<HyperType.Effect> PresentIonModalEffect(this SyntaxBuilder b, string modalId)
    {
        return b.PresentIonModalEffect(b.Const(modalId));
    }

    public static Var<Promise> DismissIonModal<TElement>(this SyntaxBuilder b, Var<TElement> domElement, IVariable data = null, Var<string> role = null) where TElement : Html.Element
    {
        if (data != null && role != null)
        {
            return b.CallOnObject<Promise>(domElement, "dismiss", data, role);
        }

        if (data != null)
        {
            return b.CallOnObject<Promise>(domElement, "dismiss", data);
        }

        return b.CallOnObject<Promise>(domElement, "dismiss");
    }

    public static Var<Promise> DismissIonModal(this SyntaxBuilder b, Var<string> modalId, IVariable data = null, Var<string> role = null)
    {
        return b.DismissIonModal(b.GetElementById(modalId), data, role);
    }

    public static Var<Promise> DismissIonModal(this SyntaxBuilder b, string modalId, IVariable data = null, Var<string> role = null)
    {
        return b.DismissIonModal(b.Const(modalId), data, role);
    }

    public static Var<HyperType.Effect> DismissIonModalEffect<TModel>(this SyntaxBuilder b, Var<string> modalId, IVariable data = null, Var<string> role = null, Var<HyperType.Action<TModel>> thenAction = null)
    {
        return b.MakeEffect(
            (b, dispatch) =>
            {
                b.RequestAnimationFrame(
                    b =>
                    {
                        var dismissPromise = b.DismissIonModal(modalId, data, role);
                        if (thenAction != null)
                        {
                            b.PromiseThen(dismissPromise, (SyntaxBuilder b, Var<bool> result) =>
                            {
                                b.Dispatch(dispatch, thenAction);
                            });
                        }
                    });
            });
    }

    public static Var<HyperType.Effect> DismissIonModalEffect<TModel>(this SyntaxBuilder b, string modalId, IVariable data = null, Var<string> role = null, Var<HyperType.Action<TModel>> thenAction = null)
    {
        return b.DismissIonModalEffect(b.Const(modalId), data, role, thenAction);
    }

    public static Var<HyperType.Effect> DismissIonModalEffect(this SyntaxBuilder b, Var<string> modalId, IVariable data = null, Var<string> role = null)
    {
        return b.DismissIonModalEffect<object>(modalId, data, role);
    }

    public static Var<HyperType.Effect> DismissIonModalEffect(this SyntaxBuilder b, string modalId, IVariable data = null, Var<string> role = null)
    {
        return b.DismissIonModalEffect<object>(b.Const(modalId), data, role);
    }
}
