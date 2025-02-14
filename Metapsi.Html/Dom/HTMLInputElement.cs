using Metapsi.Html;
using Metapsi.Syntax;

/// <summary>
/// The value property of the HTMLInputElement interface represents the current value of the &lt;input&gt; element as a string.
/// </summary>
public interface HTMLInputElement : HTMLElement
{
    /// <summary>
    /// The value property of the HTMLInputElement interface represents the current value of the &lt;input&gt; element as a string.
    /// </summary>
    public string value { get; set; }

    /// <summary>
    /// The checked property of the HTMLInputElement interface specifies the current checkedness of the element; that is, whether the form control is checked or not.
    /// </summary>
    public bool @checked { get; set; }
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
}