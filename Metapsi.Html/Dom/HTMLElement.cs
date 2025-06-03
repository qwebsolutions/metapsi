
using Metapsi;
using Metapsi.Html;
using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The HTMLElement interface represents any HTML element
/// </summary>
public interface HTMLElement : Element
{

}

/// <summary>
/// An optional object for controlling aspects of the focusing process.
/// </summary>
public interface FocusOptions
{
    /// <summary>
    /// A boolean value indicating whether or not the browser should scroll the document to bring the newly-focused element into view. A value of false for preventScroll (the default) means that the browser will scroll the element into view after focusing it. If preventScroll is set to true, no scrolling will occur.
    /// </summary>
    bool preventScroll { get; set; }
}

/// <summary>
/// 
/// </summary>
public static class HTMLElementExtensions
{
    /// <summary>
    /// The HTMLElement.blur() method removes keyboard focus from the current element.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="element"></param>
    public static void HtmlElementBlur(this SyntaxBuilder b, Var<HTMLElement> element)
    {
        b.CallOnObject(element, "blur");
    }

    /// <summary>
    /// The HTMLElement.click() method simulates a mouse click on an element. When called on an element, the element's click event is fired (unless its disabled attribute is set).
    /// </summary>
    /// <param name="b"></param>
    /// <param name="element"></param>
    public static void HtmlElementClick(this SyntaxBuilder b, Var<HTMLElement> element)
    {
        b.CallOnObject(element, "click");
    }

    /// <summary>
    /// The HTMLElement.focus() method sets focus on the specified element, if it can be focused. The focused element is the element that will receive keyboard and similar events by default.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="element"></param>
    public static void HtmlElementFocus(this SyntaxBuilder b, Var<HTMLElement> element)
    {
        b.CallOnObject(element, "focus");
    }

    /// <summary>
    /// The HTMLElement.focus() method sets focus on the specified element, if it can be focused. The focused element is the element that will receive keyboard and similar events by default.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="element"></param>
    /// <param name="setOptions"></param>
    public static void HtmlElementFocus(this SyntaxBuilder b, Var<HTMLElement> element, System.Action<PropsBuilder<FocusOptions>> setOptions)
    {
        b.CallOnObject(element, "focus", b.SetProps(b.NewObj<object>(), setOptions));
    }
}