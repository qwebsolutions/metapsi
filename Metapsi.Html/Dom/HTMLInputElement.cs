using Metapsi.Html;
using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The value property of the HTMLInputElement interface represents the current value of the &lt;input&gt; element as a string.
/// </summary>
public interface HTMLInputElement : HTMLElement
{
    /// <summary>
    /// The type property of the HTMLInputElement interface indicates the kind of data allowed in the &lt;input&gt; element, for example a number, a date, or an email. Browsers will select the appropriate widget and behavior to help users to enter a valid value.
    /// </summary>
    public string type { get; set; }

    /// <summary>
    /// The value property of the HTMLInputElement interface represents the current value of the &lt;input&gt; element as a string.
    /// </summary>
    public string value { get; set; }

    /// <summary>
    /// The checked property of the HTMLInputElement interface specifies the current checkedness of the element; that is, whether the form control is checked or not.
    /// </summary>
    public bool @checked { get; set; }

    /// <summary>
    /// The HTMLInputElement.files property allows you to access the FileList selected with the &lt;input type="file"&gt; element.
    /// </summary>
    public FileList files { get; }
}

/// <summary>
/// 
/// </summary>
public static class HTMLInputElementExtensions
{
    /// <summary>
    /// Returns e.target
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    /// <param name="b"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    public static Var<HTMLInputElement> GetTargetHtmlInput<TEvent>(this SyntaxBuilder b, Var<TEvent> e)
        where TEvent : Event
    {
        return b.Get(e, x => x.target).As<HTMLInputElement>();
    }

    /// <summary>
    /// Returns e.target.value
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    /// <param name="b"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    public static Var<string> GetTargetValue<TEvent>(this SyntaxBuilder b, Var<TEvent> e)
        where TEvent : Event
    {
        return b.Get(b.GetTargetHtmlInput(e), x => x.value);
    }

    /// <summary>
    /// Returns e.target.checked
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    /// <param name="b"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    public static Var<bool> GetTargetChecked<TEvent>(this SyntaxBuilder b, Var<TEvent> e)
        where TEvent : Event
    {
        return b.Get(b.GetTargetHtmlInput(e), x => x.@checked);
    }

    /// <summary>
    /// Returns e.target.files
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    /// <param name="b"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    public static Var<FileList> GetTargetFiles<TEvent>(this SyntaxBuilder b, Var<TEvent> e)
        where TEvent : Event
    {
        return b.Get(b.GetTargetHtmlInput(e), x => x.files);
    }
}