using Metapsi.Html;
using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Ionic;

/// <summary>
/// Options for action sheet
/// </summary>
public interface ActionSheetOptions
{
    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    string header { get; set; }

    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    string subHeader { get; set; }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    string cssClass { get; set; }

    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    List<ActionSheetButton> buttons { get; set; }

    /// <summary>
    /// If true, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    bool backdropDismiss { get; set; }

    /// <summary>
    /// If true, the action sheet will be translucent. Only applies when the mode is "ios" and the device supports backdrop-filter.
    /// </summary>
    bool translucent { get; set; }

    /// <summary>
    /// If true, the action sheet will animate.
    /// </summary>
    bool animated { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    string mode { get; set; }

    /// <summary>
    /// If true, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    bool keyboardClose { get; set; }

    /// <summary>
    /// ID
    /// </summary>
    string id { get; set; }

    /// <summary>
    /// Additional attributes to pass to the action sheet.
    /// </summary>
    object htmlAttributes { get; set; }
    /// <summary>
    /// Animation to use when the action sheet is presented.
    /// </summary>
    AnimationBuilder enterAnimation { get; set; }

    /// <summary>
    /// Animation to use when the action sheet is dismissed.
    /// </summary>
    AnimationBuilder leaveAnimation { get; set; }
}

public static partial class IonActionSheetControl
{

    /// <summary>
    /// Returns a promise resolving to the action sheet
    /// </summary>
    /// <param name="b"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<Promise> ActionSheetControllerCreate(this SyntaxBuilder b, Var<ActionSheetOptions> options)
    {
        var controller = b.ImportController("actionSheetController");
        return b.CallOnObject<Promise>(controller, "create", options);
    }

    /// <summary>
    /// Creates and presents an action sheet. Returns a promise resolving to the action sheet
    /// </summary>
    /// <param name="b"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<Promise> ActionSheetControllerPresent(this SyntaxBuilder b, Var<ActionSheetOptions> options)
    {
        var createPromise = b.ActionSheetControllerCreate(options);

        return b.PromiseThen(createPromise, (SyntaxBuilder b, Var<object> actionSheet) =>
        {
            return b.PromiseThen(
                b.CallOnObject<Promise>(actionSheet, "present"),
                (SyntaxBuilder b, Var<object> _) =>
                {
                    return actionSheet;
                });
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<Promise> ActionSheetControllerPresent(this SyntaxBuilder b, System.Action<PropsBuilder<ActionSheetOptions>> setOptions)
    {
        return b.ActionSheetControllerPresent(b.SetProps(b.NewObj(), setOptions));
    }

    public static Var<Promise> ActionSheetControllerDismiss(this SyntaxBuilder b, IVariable data, Var<string> role, Var<string> id)
    {
        var controller = b.ImportController("actionSheetController");
        return b.CallOnObject<Promise>(controller, "dismiss", data, role, id);
    }

    public static Var<Promise> ActionSheetControllerDismiss(this SyntaxBuilder b, IVariable data, Var<string> role)
    {
        var controller = b.ImportController("actionSheetController");
        return b.CallOnObject<Promise>(controller, "dismiss", data, role);
    }

    public static Var<Promise> ActionSheetControllerDismiss(this SyntaxBuilder b, IVariable data)
    {
        var controller = b.ImportController("actionSheetController");
        return b.CallOnObject<Promise>(controller, "dismiss", data);
    }

    public static Var<Promise> ActionSheetControllerDismiss(this SyntaxBuilder b)
    {
        var controller = b.ImportController("actionSheetController");
        return b.CallOnObject<Promise>(controller, "dismiss");
    }
}

