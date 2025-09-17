using Metapsi.Html;
using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Ionic;

/// <summary>
/// Alert options
/// </summary>
public interface AlertOptions
{
    /// <summary>
    /// The main title in the heading of the alert.
    /// </summary>
    string header { get; set; }

    /// <summary>
    /// The subtitle in the heading of the alert. Displayed under the title.
    /// </summary>
    string subHeader { get; set; }

    /// <summary>
    /// The main message to be displayed in the alert. message can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example &lt;Ionic&gt; would become &amp;lt;Ionic&amp;gt;.
    /// This property accepts custom HTML as a string. Content is parsed as plaintext by default. innerHTMLTemplatesEnabled must be set to true in the Ionic config before custom HTML can be used.
    /// </summary>
    string message { get; set; }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    string cssClass { get; set; }

    /// <summary>
    /// Array of input to show in the alert.
    /// </summary>
    List<AlertInput> inputs { get; set; }

    /// <summary>
    /// Array of buttons to be added to the alert.
    /// </summary>
    List<AlertButton> buttons { get; set; }

    /// <summary>
    /// If true, the alert will be dismissed when the backdrop is clicked.
    /// </summary>
    bool backdropDismiss { get; set; }

    /// <summary>
    /// If true, the alert will be translucent. Only applies when the mode is "ios" and the device supports backdrop-filter.
    /// </summary>
    bool translucent { get; set; }

    /// <summary>
    /// If true, the alert will animate.
    /// </summary>
    bool animated { get; set; }

    /// <summary>
    /// Additional attributes to pass to the alert.
    /// </summary>
    object htmlAttributes { get; set; }

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
    /// Animation to use when the alert is presented.
    /// </summary>
    AnimationBuilder enterAnimation { get; set; }

    /// <summary>
    /// Animation to use when the alert is dismissed.
    /// </summary>
    AnimationBuilder leaveAnimation { get; set; }
}


public static partial class IonAlertControl
{
    /// <summary>
    /// Returns a promise resolving to the alert
    /// </summary>
    /// <param name="b"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<Promise> AlertControllerCreate(this SyntaxBuilder b, Var<AlertOptions> options)
    {
        var alertController = b.ImportController("alertController");
        return b.CallOnObject<Promise>(alertController, "create", options);
    }

    /// <summary>
    /// Creates and presents an alert
    /// </summary>
    /// <param name="b"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<Promise> AlertControllerPresent(this SyntaxBuilder b, Var<AlertOptions> options)
    {
        var createPromise = b.AlertControllerCreate(options);

        return b.PromiseThen(createPromise, (SyntaxBuilder b, Var<object> alert) =>
        {
            return b.CallOnObject<Promise>(alert, "present");
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<Promise> AlertControllerPresent(this SyntaxBuilder b, System.Action<PropsBuilder<AlertOptions>> setOptions)
    {
        return b.AlertControllerPresent(b.SetProps(b.NewObj(), setOptions));
    }

    public static Var<Promise> AlertControllerDismiss(this SyntaxBuilder b, Var<object> data, Var<string> role, Var<string> id)
    {
        var alertController = b.ImportController("alertController");
        return b.CallOnObject<Promise>(alertController, "dismiss", data, role, id);
    }

    public static Var<Promise> AlertControllerDismiss(this SyntaxBuilder b, Var<object> data, Var<string> role)
    {
        var alertController = b.ImportController("alertController");
        return b.CallOnObject<Promise>(alertController, "dismiss", data, role);
    }

    public static Var<Promise> AlertControllerDismiss(this SyntaxBuilder b, Var<object> data)
    {
        var alertController = b.ImportController("alertController");
        return b.CallOnObject<Promise>(alertController, "dismiss", data);
    }

    public static Var<Promise> AlertControllerDismiss(this SyntaxBuilder b, Var<string> data)
    {
        return b.AlertControllerDismiss(data.As<object>());
    }

    public static Var<Promise> AlertControllerDismiss(this SyntaxBuilder b)
    {
        var alertController = b.ImportController("alertController");
        return b.CallOnObject<Promise>(alertController, "dismiss");
    }
}