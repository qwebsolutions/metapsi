using Metapsi.Html;
using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Ionic;

/// <summary>
/// Toast options
/// </summary>
public interface ToastOptions
{
    /// <summary>
    /// Header to be shown in the toast.
    /// </summary>
    string header { get; set; }

    /// <summary>
    /// Header to be shown in the toast.
    /// </summary>
    /// <remarks> string | IonicSafeString</remarks>
    string message { get; set; }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    /// <remarks>string | string[];</remarks>
    string cssClass { get; set; }

    /// <summary>
    /// How many milliseconds to wait before hiding the toast. By default, it will show until dismiss() is called.
    /// </summary>
    int duration { get; set; }

    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    /// <remarks> (ToastButton | string)[]</remarks>
    List<ToastButton> buttons { get; set; }

    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the positionAnchor property.
    /// </summary>
    /// <remarks> 'top' | 'bottom' | 'middle' </remarks>
    string position { get; set; }

    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With position="bottom", the toast will sit above the chosen element. With position="top", the toast will sit below the chosen element. With position="middle", the value of positionAnchor is ignored.
    /// </summary>
    /// <remarks>HTMLElement | string</remarks>
    string positionAnchor { get; set; }

    /// <summary>
    /// If set to 'vertical', the Toast can be dismissed with a swipe gesture. The swipe direction is determined by the value of the position property: top: The Toast can be swiped up to dismiss. bottom: The Toast can be swiped down to dismiss. middle: The Toast can be swiped up or down to dismiss.
    /// </summary>
    /// <remarks>ToastSwipeGestureDirection = 'vertical'</remarks>
    string swipeGesture { get; set; }

    /// <summary>
    /// If true, the toast will be translucent. Only applies when the mode is "ios" and the device supports backdrop-filter.
    /// </summary>
    bool translucent { get; set; }

    /// <summary>
    /// If true, the toast will animate.
    /// </summary>
    bool animated { get; set; }

    /// <summary>
    /// The name of the icon to display, or the path to a valid SVG file. See <see cref="IonIcon"/> <seealso href="https://ionic.io/ionicons"/> 
    /// </summary>
    string icon { get; set; }

    /// <summary>
    /// Additional attributes to pass to the toast.
    /// </summary>
    /// <remarks> { [key: string]: any }</remarks>
    object htmlAttributes { get; set; }

    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    /// <remarks>'baseline' | 'stacked'</remarks>
    string layout { get; set; }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: "primary", "secondary", "tertiary", "success", "warning", "danger", "light", "medium", and "dark"
    /// </summary>
    string color { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    /// <remarks>'ios' | 'md'</remarks>
    string mode { get; set; }

    /// <summary>
    /// If true, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    bool keyboardClose { get; set; }

    /// <summary>
    /// 
    /// </summary>
    string id { get; set; }

    /// <summary>
    /// Animation to use when the toast is presented.
    /// </summary>
    /// <remarks>(baseEl: any, opts?: any) => Animation</remarks>
    AnimationBuilder enterAnimation { get; set; }

    /// <summary>
    /// Animation to use when the toast is dismissed.
    /// </summary>
    /// <remarks>(baseEl: any, opts?: any) => Animation</remarks>
    AnimationBuilder leaveAnimation { get; set; }
}

public static partial class IonToastControl
{
    /// <summary>
    /// Returns a promise resolving to the toast
    /// </summary>
    /// <param name="b"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<Promise> ToastControllerCreate(this SyntaxBuilder b, Var<ToastOptions> options)
    {
        var controller = b.ImportController("toastController");
        return b.CallOnObject<Promise>(controller, "create", options);
    }

    /// <summary>
    /// Creates and presents a toast
    /// </summary>
    /// <param name="b"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<Promise> ToastControllerPresent(this SyntaxBuilder b, Var<ToastOptions> options)
    {
        var createPromise = b.ToastControllerCreate(options);

        return b.PromiseThen(createPromise, (SyntaxBuilder b, Var<object> toast) =>
        {
            return b.CallOnObject<Promise>(toast, "present");
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<Promise> ToastControllerPresent(this SyntaxBuilder b, System.Action<PropsBuilder<ToastOptions>> setOptions)
    {
        return b.ToastControllerPresent(b.SetProps(b.NewObj(), setOptions));
    }

    public static Var<Promise> ToastControllerDismiss(this SyntaxBuilder b, IVariable data, Var<string> role, Var<string> id)
    {
        var controller = b.ImportController("toastController");
        return b.CallOnObject<Promise>(controller, "dismiss", data, role, id);
    }

    public static Var<Promise> ToastControllerDismiss(this SyntaxBuilder b, IVariable data, Var<string> role)
    {
        var controller = b.ImportController("toastController");
        return b.CallOnObject<Promise>(controller, "dismiss", data, role);
    }

    public static Var<Promise> ToastControllerDismiss(this SyntaxBuilder b, IVariable data)
    {
        var controller = b.ImportController("toastController");
        return b.CallOnObject<Promise>(controller, "dismiss", data);
    }

    public static Var<Promise> ToastControllerDismiss(this SyntaxBuilder b)
    {
        var controller = b.ImportController("toastController");
        return b.CallOnObject<Promise>(controller, "dismiss");
    }
}
