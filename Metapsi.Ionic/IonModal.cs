using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Ionic;

public static partial class IonModalControl
{
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
                var dismissPromise = b.DismissIonModal(modalId, data, role);
                if (thenAction != null)
                {
                    b.PromiseThen(dismissPromise, (SyntaxBuilder b, Var<bool> result) =>
                    {
                        b.Dispatch(dispatch, thenAction);
                    });
                }
            });
    }

    public static Var<HyperType.Effect> DismissIonModalEffect<TModel>(this SyntaxBuilder b, string modalId, IVariable data = null, Var<string> role = null, Var<HyperType.Action<TModel>> thenAction = null)
    {
        return b.DismissIonModalEffect(b.Const(modalId), data, role, thenAction);
    }

    public static Var<HyperType.Effect> DismissIonModalEffect(this SyntaxBuilder b, Var<string> modalId, IVariable data = null, Var<string> role = null)
    {
        return b.DismissIonModalEffect<DynamicObject>(modalId, data, role);
    }

    public static Var<HyperType.Effect> DismissIonModalEffect(this SyntaxBuilder b, string modalId, IVariable data = null, Var<string> role = null)
    {
        return b.DismissIonModalEffect<DynamicObject>(b.Const(modalId), data, role);
    }
}
