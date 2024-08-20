using Metapsi.Dom;
using Metapsi.Syntax;

namespace Metapsi.Hyperapp;

public static class FocusEffects
{
    public static Var<HyperType.Effect> Focus(this SyntaxBuilder b, Var<string> id)
    {
        return b.MakeEffect(b =>
        {
            b.RequestAnimationFrame(b =>
            {
                var focusElement = b.GetElementById(id);
                b.CallOnObject(focusElement, "focus");
            });
        });
    }

    public static Var<HyperType.Effect> Focus(this SyntaxBuilder b, string id)
    {
        return b.Focus(b.Const(id));
    }

    public static Var<HyperType.Effect> Blur(this SyntaxBuilder b, Var<string> id)
    {
        return b.MakeEffect(b =>
        {
            b.CallOnObject(b.GetElementById(id), "blur");
        });
    }

    public static Var<HyperType.Effect> Blur(this SyntaxBuilder b, string id)
    {
        return b.Blur(b.Const(id));
    }
}