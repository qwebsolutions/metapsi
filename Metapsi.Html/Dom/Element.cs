﻿using Metapsi.Syntax;

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
    /// The Element.firstElementChild read-only property returns an element's first child Element, or null if there are no child elements.
    /// </summary>
    Element firstElementChild { get; }

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
    /// The Element.shadowRoot read-only property represents the shadow root hosted by the element.
    /// </summary>
    public ShadowRoot shadowRoot { get; }

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
public interface AttachShadowOptions
{
    /// <summary>
    /// A string specifying the encapsulation mode for the shadow DOM tree. 
    /// </summary>
    string mode { get; set; }

    /// <summary>
    /// A boolean that specifies whether the shadow root is clonable: when set to true, the shadow host cloned with Node.cloneNode() or Document.importNode() will include shadow root in the copy. Its default value is false.
    /// </summary>
    bool clonable { get; set; }

    /// <summary>
    /// A boolean that, when set to true, specifies behavior that mitigates custom element issues around focusability. When a non-focusable part of the shadow DOM is clicked, the first focusable part is given focus, and the shadow host is given any available :focus styling. Its default value is false.
    /// </summary>
    bool delegatesFocus { get; set; }

    /// <summary>
    /// A boolean that, when set to true, indicates that the shadow root is serializable. If set, the shadow root may be serialized by calling the Element.getHTML() or ShadowRoot.getHTML() methods with the options.serializableShadowRoots parameter set true. Its default value is false.
    /// </summary>
    bool serializable { get; set; }

    /// <summary>
    /// A string specifying the slot assignment mode for the shadow DOM tree.
    /// </summary>
    string slotAssignment { get; set; }
}

/// <summary>
/// 
/// </summary>
public static class ElementExtensions
{

    /// <summary>
    /// The Element.attachShadow() method attaches a shadow DOM tree to the specified element and returns a reference to its ShadowRoot.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="element"></param>
    /// <param name="setOptions"></param>
    /// <returns>Returns a <see cref="ShadowRoot"/> object.</returns>
    public static Var<ShadowRoot> ElementAttachShadow<T>(this SyntaxBuilder b, Var<T> element, System.Action<PropsBuilder<AttachShadowOptions>> setOptions)
        where T : Element
    {
        return b.CallOnObject<ShadowRoot>(element, "attachShadow", b.SetProps(b.NewObj(), setOptions));
    }

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
        b.CallOnObject(element, "scroll", b.SetProps(b.NewObj<object>(), setOptions));
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
        b.CallOnObject(element, "scrollBy", b.SetProps(b.NewObj<object>(), setOptions));
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
        b.CallOnObject(element, "scrollIntoView", b.SetProps(b.NewObj<object>(), setOptions));
    }
}