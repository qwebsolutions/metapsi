
using Metapsi;
using Metapsi.Html;
using Metapsi.Syntax;
using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Metapsi.Html;

/// <summary>
/// The HTMLElement interface represents any HTML element
/// </summary>
public interface HTMLElement : Element
{
    /// <summary>
    /// The autofocus property of the HTMLElement interface represents a boolean value reflecting the autofocus HTML global attribute.
    /// </summary>
    bool autofocus { get; set; }

    /// <summary>
    /// The contentEditable property of the HTMLElement interface specifies whether or not the element is editable. This enumerated attribute can have the following values:
    /// <para> "true" indicates that the element is contenteditable. </para>
    /// <para> "false" indicates that the element cannot be edited. </para>
    /// <para> "plaintext-only" indicates that the element's raw text is editable, but rich text formatting is disabled.</para>
    /// </summary>
    string contentEditable { get; set; }

    /// <summary>
    /// The dataset read-only property of the HTMLElement interface provides read/write access to custom data attributes (data-*) on elements. It exposes a map of strings (DOMStringMap) with an entry for each data-* attribute.
    /// </summary>
    object dataset { get; }

    /// <summary>
    /// The HTMLElement.dir property indicates the text writing directionality of the content of the current element. It reflects the element's dir attribute.
    /// </summary>
    string dir { get; set; }

    /// <summary>
    /// The draggable property of the HTMLElement interface gets and sets a Boolean primitive indicating if the element is draggable.
    /// </summary>
    bool draggable { get; set; }

    /// <summary>
    /// The enterKeyHint property is an enumerated property defining what action label (or icon) to present for the enter key on virtual keyboards.
    /// </summary>
    string enterKeyHint { get; set; }

    /// <summary>
    /// The HTMLElement property hidden reflects the value of the element's hidden attribute.
    /// </summary>
    bool hidden { get; set; }

    /// <summary>
    /// The HTMLElement property inert reflects the value of the element's inert attribute.
    /// </summary>
    bool inert { get; set; }

    /// <summary>
    /// The innerText property of the HTMLElement interface represents the rendered text content of a node and its descendants. 
    /// As a getter, it approximates the text the user would get if they highlighted the contents of the element with the cursor and then copied it to the clipboard.As a setter this will replace the element's children with the given value, converting any line breaks into &lt;br&gt; elements.
    /// </summary>
    string innerText { get; set; }

    /// <summary>
    /// The HTMLElement property inputMode reflects the value of the element's inputmode attribute.
    /// </summary>
    string inputMode { get; set; }

    /// <summary>
    /// The HTMLElement.isContentEditable read-only property returns a boolean value that is true if the contents of the element are editable; otherwise it returns false.
    /// </summary>
    bool isContentEditable { get; }

    /// <summary>
    /// The lang property of the HTMLElement interface indicates the base language of an element's attribute values and text content, in the form of a BCP 47 language tag. It reflects the element's lang attribute
    /// </summary>
    string lang { get; set; }

    /// <summary>
    /// The offsetHeight read-only property of the HTMLElement interface returns the height of an element, including vertical padding and borders, as an integer.
    /// </summary>
    int offsetHeight { get; }

    /// <summary>
    /// The offsetLeft read-only property of the HTMLElement interface returns the number of pixels that the upper left corner of the current element is offset to the left within the HTMLElement.offsetParent node.
    /// </summary>
    int offsetLeft { get; }

    /// <summary>
    /// The HTMLElement.offsetParent read-only property returns a reference to the element which is the closest (nearest in the containment hierarchy) positioned ancestor element.
    /// </summary>
    Element offsetParent { get; }

    /// <summary>
    /// The offsetTop read-only property of the HTMLElement interface returns the distance from the outer border of the current element (including its margin) to the top padding edge of the offsetParent, the closest positioned ancestor element.
    /// </summary>
    int offsetTop { get; }

    /// <summary>
    /// The offsetWidth read-only property of the HTMLElement interface returns the layout width of an element as an integer.
    /// </summary>
    int offsetWidth { get; }

    /// <summary>
    /// The outerText property of the HTMLElement interface returns the same value as HTMLElement.innerText. When used as a setter it replaces the whole current node with the given text (this differs from innerText, which replaces the content inside the current node).
    /// </summary>
    string outerText { get; set; }

    /// <summary>
    /// The popover property of the HTMLElement interface gets and sets an element's popover state via JavaScript ("auto", "hint", or "manual"), and can be used for feature detection. It reflects the value of the popover global HTML attribute.
    /// </summary>
    string popover { get; set; }

    /// <summary>
    /// The spellcheck property of the HTMLElement interface represents a boolean value that controls the spell-checking hint. It is available on all HTML elements, though it doesn't affect all of them. It reflects the value of the spellcheck HTML global attribute.
    /// </summary>
    bool spellcheck { get; set; }

    /// <summary>
    /// The read-only style property of the HTMLElement interface returns the inline style of an element in the form of a live CSSStyleProperties object. This object can be used to get and set the inline styles of an element.
    /// </summary>
    CSSStyleProperties style { get; }

    /// <summary>
    /// The tabIndex property of the HTMLElement interface represents the tab order of the current element.
    /// </summary>
    int tabIndex { get; set; }

    /// <summary>
    /// The HTMLElement.title property represents the title of the element: the text usually displayed in a 'tooltip' popup when the mouse is over the node.
    /// </summary>
    string title { get; set; }

    /// <summary>
    /// The translate property of the HTMLElement interface indicates whether an element's attribute values and the values of its Text node children are to be translated when the page is localized, or whether to leave them unchanged.
    /// It reflects the value of the translate HTML global attribute.
    /// </summary>
    bool translate { get; set; }
}
