using Metapsi.Syntax;
using System.Linq;

namespace Metapsi.Ionic;

public partial class IonActionSheetControl
{
    /// <summary>
    /// <para> An array of buttons for the action sheet. </para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="setProps"></param>
    public static void SetButtons(this PropsBuilder<IonActionSheet> b, params System.Action<PropsBuilder<ActionSheetButton>>[] setProps)
    {
        var actions = b.NewCollection<ActionSheetButton>();
        foreach (var action in setProps)
        {
            b.Push(actions, b.SetProps(b.NewObj(), action));
        }
        b.SetButtons(b.Const(actions));
    }
}