using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.Ionic;

/// <summary>
/// Modal options
/// </summary>
public interface ModalOptions
{
    /// <summary>
    /// Function | HTMLElement | string
    /// </summary>
    object component { get; set; }

    /// <summary>
    /// Passed to the component
    /// </summary>
    object componentProps { get; set; }

    /// <summary>
    /// 
    /// </summary>
    HTMLElement presentingElement { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool showBackdrop { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool backdropDismiss { get; set; }

    /// <summary>
    /// string | string[]
    /// </summary>
    object cssClass { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool animated { get; set; }

    /// <summary>
    /// boolean | ((data?: any, role?: string) => Promise&lt;boolean&gt;)
    /// </summary>
    object canDismiss { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool focusTrap { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool keyboardClose { get; set; }

    /// <summary>
    /// 
    /// </summary>
    string id { get; set; }

    /// <summary>
    /// [key: string]: any;
    /// </summary>
    object htmlAttributes { get; set; }

    /// <summary>
    /// 
    /// </summary>
    AnimationBuilder enterAnimation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    AnimationBuilder leaveAnimation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    System.Collections.Generic.List<decimal> breakpoints { get; set; }

    /// <summary>
    /// 
    /// </summary>
    decimal initialBreakpoint { get; set; }

    /// <summary>
    /// 
    /// </summary>
    decimal backdropBreakpoint { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool handle { get; set; }

    /// <summary>
    /// 'none' | 'cycle'
    /// </summary>
    string handleBehavior { get; set; }

    /// <summary>
    /// 
    /// </summary>
    bool expandToScroll { get; set; }
}

public static partial class IonModalControl
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public static Var<Promise> ModalControllerShowModal(this SyntaxBuilder b, Var<ModalOptions> options)
    {
        var modalController = b.ImportName<object>($"/ionic@{Cdn.Version}/index.esm.js", "modalController");
        //b.SetProperty(b.Window(), "modalController", modalController);
        var createPromise = b.CallOnObject<Promise>(modalController, "create", options);

        return b.PromiseThen(createPromise, (SyntaxBuilder b, Var<object> modal) =>
        {
            return b.CallOnObject<Promise>(modal, "present");
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<Promise> ModalControllerShowModal(this SyntaxBuilder b, System.Action<PropsBuilder<ModalOptions>> setOptions)
    {
        return b.ModalControllerShowModal(b.SetProps(b.NewObj(), setOptions));
    }

    public static Var<Promise> ModalControllerDismiss(this SyntaxBuilder b, Var<object> data, Var<string> role, Var<string> id)
    {
        var modalController = b.ImportName<object>($"/ionic@{Cdn.Version}/index.esm.js", "modalController");
        return b.CallOnObject<Promise>(modalController, "dismiss", data, role, id);
    }

    public static Var<Promise> ModalControllerDismiss(this SyntaxBuilder b, Var<object> data, Var<string> role)
    {
        var modalController = b.ImportName<object>($"/ionic@{Cdn.Version}/index.esm.js", "modalController");
        return b.CallOnObject<Promise>(modalController, "dismiss", data, role);
    }

    public static Var<Promise> ModalControllerDismiss(this SyntaxBuilder b, Var<object> data)
    {
        var modalController = b.ImportName<object>($"/ionic@{Cdn.Version}/index.esm.js", "modalController");
        return b.CallOnObject<Promise>(modalController, "dismiss", data);
    }

    public static Var<Promise> ModalControllerDismiss(this SyntaxBuilder b, Var<string> data)
    {
        return b.ModalControllerDismiss(data.As<object>());
    }

    public static Var<Promise> ModalControllerDismiss(this SyntaxBuilder b)
    {
        var modalController = b.ImportName<object>($"/ionic@{Cdn.Version}/index.esm.js", "modalController");
        return b.CallOnObject<Promise>(modalController, "dismiss");
    }

    public static void SetComponent(this PropsBuilder<ModalOptions> b, string componentTag)
    {
        b.Set(x => x.component, b.Const(componentTag).As<object>());
    }
}
