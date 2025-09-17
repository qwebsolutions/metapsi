using Metapsi.Html;
using Metapsi.Syntax;

namespace Metapsi.Ionic;

/// <summary>
/// Options for the loading overlay
/// </summary>
public interface LoadingOptions
{
    /// <summary>
    /// The name of the spinner to display.
    /// <para> "bubbles" | "circles" | "circular" | "crescent" | "dots" | "lines" | "lines-sharp" | "lines-sharp-small" | "lines-small" </para>
    /// </summary>
    string spinner { get; set; }

    /// <summary>
    /// Optional text content to display in the loading indicator.
    /// </summary>
    string message { get; set; }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    string cssClass { get; set; }

    /// <summary>
    /// If true, a backdrop will be displayed behind the loading indicator.
    /// </summary>
    bool showBackdrop { get; set; }

    /// <summary>
    /// Number of milliseconds to wait before dismissing the loading indicator.
    /// </summary>
    int duration { get; set; }

    /// <summary>
    /// If true, the loading indicator will be translucent. Only applies when the mode is "ios" and the device supports backdrop-filter.
    /// </summary>
    bool translucent { get; set; }

    /// <summary>
    /// If true, the loading indicator will animate.
    /// </summary>
    bool animated { get; set; }

    /// <summary>
    /// If true, the loading indicator will be dismissed when the backdrop is clicked.
    /// </summary>
    bool backdropDismiss { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// <para>"ios" | "md"</para>
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
    /// Additional attributes to pass to the loader.
    /// </summary>
    object htmlAttributes { get; set; }

    /// <summary>
    /// Animation to use when the loading indicator is presented.
    /// </summary>
    /// <remarks>(baseEl: any, opts?: any) => Animation</remarks>
    AnimationBuilder enterAnimation { get; set; }

    /// <summary>
    /// Animation to use when the loading indicator is dismissed.
    /// </summary>
    /// <remarks>(baseEl: any, opts?: any) => Animation</remarks>
    AnimationBuilder leaveAnimation { get; set; }
}


public static partial class IonLoadingControl
{
    /// <summary>
    /// Returns a promise resolving to the loading element
    /// </summary>
    /// <param name="b"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<Promise> LoadingControllerCreate(this SyntaxBuilder b, Var<LoadingOptions> options)
    {
        var controller = b.ImportController("loadingController");
        return b.CallOnObject<Promise>(controller, "create", options);
    }

    /// <summary>
    /// Creates and presents a loading overlay
    /// </summary>
    /// <param name="b"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<Promise> LoadingControllerPresent(this SyntaxBuilder b, Var<LoadingOptions> options)
    {
        var createPromise = b.LoadingControllerCreate(options);

        return b.PromiseThen(createPromise, (SyntaxBuilder b, Var<object> loading) =>
        {
            return b.CallOnObject<Promise>(loading, "present");
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<Promise> LoadingControllerPresent(this SyntaxBuilder b, System.Action<PropsBuilder<LoadingOptions>> setOptions)
    {
        return b.LoadingControllerPresent(b.SetProps(b.NewObj(), setOptions));
    }

    public static Var<Promise> LoadingControllerDismiss(this SyntaxBuilder b, Var<object> data, Var<string> role, Var<string> id)
    {
        var loadingController = b.ImportController("loadingController");
        return b.CallOnObject<Promise>(loadingController, "dismiss", data, role, id);
    }

    public static Var<Promise> LoadingControllerDismiss(this SyntaxBuilder b, Var<object> data, Var<string> role)
    {
        var loadingController = b.ImportController("loadingController");
        return b.CallOnObject<Promise>(loadingController, "dismiss", data, role);
    }

    public static Var<Promise> LoadingControllerDismiss(this SyntaxBuilder b, Var<object> data)
    {
        var loadingController = b.ImportController("loadingController");
        return b.CallOnObject<Promise>(loadingController, "dismiss", data);
    }

    public static Var<Promise> LoadingControllerDismiss(this SyntaxBuilder b, Var<string> data)
    {
        return b.LoadingControllerDismiss(data.As<object>());
    }

    public static Var<Promise> LoadingControllerDismiss(this SyntaxBuilder b)
    {
        var loadingController = b.ImportController("loadingController");
        return b.CallOnObject<Promise>(loadingController, "dismiss");
    }
}

