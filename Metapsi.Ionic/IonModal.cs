using Metapsi.Html;
using Metapsi.Syntax;

namespace Metapsi.Ionic;

public static partial class IonModalControl
{
    public static Var<Promise> PresentIonModal<TElement>(this SyntaxBuilder b, Var<TElement> domElement) where TElement: Html.Element
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

    public static Var<Promise> DismissIonModal<TElement>(this SyntaxBuilder b, Var<TElement> domElement) where TElement : Html.Element
    {
        return b.CallOnObject<Promise>(domElement, "dismiss");
    }

    public static Var<Promise> DismissIonModal(this SyntaxBuilder b, Var<string> modalId)
    {
        return b.DismissIonModal(b.GetElementById(modalId));
    }

    public static Var<Promise> DismissIonModal(this SyntaxBuilder b, string modalId)
    {
        return b.DismissIonModal(b.Const(modalId));
    }
}