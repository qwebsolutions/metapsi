using Metapsi.Syntax;
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel;
using System.Xml.Linq;

namespace Metapsi.Html;

/// <summary>
/// Element is the most general base class from which all element objects (i.e. objects that represent elements) in a Document inherit. It only has methods and properties common to all kinds of elements. More specific classes inherit from Element.
/// </summary>
public interface Element : Node
{
    /// <summary>
    /// The id property of the Element interface represents the element's identifier, reflecting the id global attribute.
    /// </summary>
    public string id { get; set; }

    /// <summary>
    /// The Element property innerHTML gets or sets the HTML or XML markup contained within the element.
    /// </summary>
    public string innerHTML { get; set; }

    /// <summary>
    /// The outerHTML attribute of the Element DOM interface gets the serialized HTML fragment describing the element including its descendants. It can also be set to replace the element with nodes parsed from the given string.
    /// </summary>
    public string outerHTML { get; set; }

    /// <summary>
    /// The Element.previousElementSibling read-only property returns the Element immediately prior to the specified one in its parent's children list, or null if the specified element is the first one in the list.
    /// </summary>
    public Element previousElementSibling { get;  }

    /// <summary>
    /// The Element.scrollTop property gets or sets the number of pixels by which an element's content is scrolled from its top edge
    /// </summary>
    public decimal scrollTop { get; set; }

    /// <summary>
    /// The slot property of the Element interface returns the name of the shadow DOM slot the element is inserted in.
    /// </summary>
    public string slot { get; set; }

    /// <summary>
    /// The tagName read-only property of the Element interface returns the tag name of the element on which it's called.
    /// </summary>
    public string tagName { get; }
}

/// <summary>
/// 
/// </summary>
public class ScrollOptions
{
    /// <summary>
    /// Specifies the number of pixels along the Y axis to scroll the window or element.
    /// </summary>
    public int top { get; set; }

    /// <summary>
    /// Specifies the number of pixels along the X axis to scroll the window or element.
    /// </summary>
    public int left { get; set; }

    /// <summary>
    /// Determines whether scrolling is instant or animates smoothly.This option is a string which must take one of the following values:
    /// <para>smooth: scrolling should animate smoothly</para>
    /// <para>instant: scrolling should happen instantly in a single jump</para>
    /// <para>auto: scroll behavior is determined by the computed value of scroll-behavior</para>
    /// </summary>
    public string behavior { get; set; }
}

/// <summary>
/// 
/// </summary>
public class ScrollIntoViewOptions
{
    /// <summary>
    /// Determines whether scrolling is instant or animates smoothly.This option is a string which must take one of the following values:
    /// <para>smooth: scrolling should animate smoothly</para>
    /// <para>instant: scrolling should happen instantly in a single jump</para>
    /// <para>auto: scroll behavior is determined by the computed value of scroll-behavior</para>
    /// </summary>
    public string behavior { get; set; }

    /// <summary>
    /// Defines the vertical alignment of the element within the scrollable ancestor container.This option is a string and accepts one of the following values:
    /// <para>start: Aligns the element's top edge with the top of the scrollable container, making the element appear at the start of the visible area vertically.</para>
    /// <para>center: Aligns the element vertically at the center of the scrollable container, positioning it in the middle of the visible area.</para>
    /// <para>end: Aligns the element's bottom edge with the bottom of the scrollable container, placing the element at the end of the visible area vertically.</para>
    /// <para>nearest: Scrolls the element to the nearest edge in the vertical direction.If the element is closer to the top edge of the scrollable container, it will align to the top; if it's closer to the bottom edge, it will align to the bottom. This minimizes the scrolling distance.</para>
    /// <para>Defaults to start.</para>
    /// </summary>
    public string block { get; set; }

    /// <summary>
    /// Defines the horizontal alignment of the element within the scrollable ancestor container.This option is a string and accepts one of the following values:
    /// <para>start: Aligns the element's left edge with the left of the scrollable container, making the element appear at the start of the visible area horizontally.</para>
    /// <para>center: Aligns the element horizontally at the center of the scrollable container, positioning it in the middle of the visible area.</para>
    /// <para>end: Aligns the element's right edge with the right of the scrollable container, placing the element at the end of the visible area horizontally.</para>
    /// <para>nearest: Scrolls the element to the nearest edge in the horizontal direction.If the element is closer to the left edge of the scrollable container, it will align to the left; if it's closer to the right edge, it will align to the right. This minimizes the scrolling distance.</para>
    /// <para>Defaults to nearest.</para>
    /// </summary>
    public string inline { get; set; }
}

/// <summary>
/// 
/// </summary>
public static class ElementExtensions
{
    public static Var<Element> QuerySelector(this SyntaxBuilder b, Var<Element> parent, Var<string> selectors)
    {
        return b.CallOnObject<Element>(parent, "querySelector", selectors);
    }

    public static Var<Element> QuerySelector(this SyntaxBuilder b, Var<Element> parent, string selectors)
    {
        return b.QuerySelector(parent, b.Const(selectors));
    }

    /// <summary>
    /// The scroll() method of the Element interface scrolls the element to a particular set of coordinates inside a given element.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="element"></param>
    /// <param name="xCoord">The pixel along the horizontal axis of the element that you want displayed in the upper left.</param>
    /// <param name="yCoord">The pixel along the vertical axis of the element that you want displayed in the upper left.</param>
    public static void Scroll<T>(this SyntaxBuilder b, Var<T> element, Var<int> xCoord, Var<int> yCoord)
        where T : Element
    {
        b.CallOnObject(element, "scroll", xCoord, yCoord);
    }

    /// <summary>
    /// The scroll() method of the Element interface scrolls the element to a particular set of coordinates inside a given element.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="element"></param>
    /// <param name="setOptions"></param>
    public static void Scroll<T>(this SyntaxBuilder b, Var<T> element, System.Action<PropsBuilder<ScrollOptions>> setOptions)
        where T : Element
    {
        b.CallOnObject(element, "scroll", b.SetProps(setOptions));
    }

    /// <summary>
    /// The scrollBy() method of the Element interface scrolls an element by the given amount.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="element"></param>
    /// <param name="xCoord">The horizontal pixel value that you want to scroll by.</param>
    /// <param name="yCoord">The vertical pixel value that you want to scroll by.</param>
    public static void ScrollBy<T>(this SyntaxBuilder b, Var<T> element, Var<int> xCoord, Var<int> yCoord)
        where T : Element
    {
        b.CallOnObject(element, "scrollBy", xCoord, yCoord);
    }

    /// <summary>
    /// The scrollBy() method of the Element interface scrolls an element by the given amount.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="element"></param>
    /// <param name="setOptions"></param>
    public static void ScrollBy<T>(this SyntaxBuilder b, Var<T> element, System.Action<PropsBuilder<ScrollOptions>> setOptions)
        where T : Element
    {
        b.CallOnObject(element, "scrollBy", b.SetProps(setOptions));
    }

    /// <summary>
    /// The Element interface's scrollIntoView() method scrolls the element's ancestor containers such that the element on which scrollIntoView() is called is visible to the user.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="element"></param>
    public static void ScrollIntoView<T>(this SyntaxBuilder b, Var<T> element)
        where T: Element
    {
        b.CallOnObject(element, "scrollIntoView");
    }

    /// <summary>
    /// The Element interface's scrollIntoView() method scrolls the element's ancestor containers such that the element on which scrollIntoView() is called is visible to the user.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="element"></param>
    /// <param name="alignToTop">
    /// <para>If true, the top of the element will be aligned to the top of the visible area of the scrollable ancestor.Corresponds to scrollIntoViewOptions: {block: "start", inline: "nearest"}. This is the default value.</para>
    /// <para>If false, the bottom of the element will be aligned to the bottom of the visible area of the scrollable ancestor.Corresponds to scrollIntoViewOptions: {block: "end", inline: "nearest"}.</para>
    /// </param>
    public static void ScrollIntoView<T>(this SyntaxBuilder b, Var<T> element, Var<bool> alignToTop)
        where T : Element
    {
        b.CallOnObject(element, "scrollIntoView", alignToTop);
    }

    /// <summary>
    /// The Element interface's scrollIntoView() method scrolls the element's ancestor containers such that the element on which scrollIntoView() is called is visible to the user.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="element"></param>
    /// <param name="setOptions"></param>
    public static void ScrollIntoView<T>(this SyntaxBuilder b, Var<T> element, System.Action<PropsBuilder<ScrollIntoViewOptions>> setOptions)
        where T : Element
    {
        b.CallOnObject(element, "scrollIntoView", b.SetProps(setOptions));
    }
}