using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.Shoelace;

public static partial class DialogExtensions
{
    public static void ShowDialog(this SyntaxBuilder b, Var<string> dialogId)
    {
        var popup = b.GetElementById(dialogId);
        b.SetDynamic(popup, DynamicProperty.Bool("open"), b.Const(true));
    }

    public static void ShowDialog(this SyntaxBuilder b, string dialogId)
    {
        b.ShowDialog(b.Const(dialogId));
    }

    public static void HideDialog(this SyntaxBuilder b, Var<string> dialogId)
    {
        var popup = b.GetElementById(dialogId);
        b.SetDynamic(popup, DynamicProperty.Bool("open"), b.Const(false));
    }

    public static void HideDialog(this SyntaxBuilder b, string dialogId)
    {
        b.HideDialog(b.Const(dialogId));
    }
}