using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// The Document interface represents any web page loaded in the browser and serves as an entry point into the web page's content, which is the DOM tree.
/// </summary>
public interface Document : Node
{
    /// <summary>
    /// The activeElement read-only property of the Document interface returns the Element within the DOM that is receiving keyboard events such as keydown and keyup. This is usually analogous to the focused element.
    /// </summary>
    Element activeElement { get; }

    /// <summary>
    /// The adoptedStyleSheets property of the Document interface is used for setting an array of constructed stylesheets to be used by the document.
    /// </summary>
    List<CSSStyleSheet> adoptedStyleSheets { get; set; }

    /// <summary>
    /// The Document.body property represents the &lt;body&gt; or &lt;frameset&gt; node of the current document, or null if no such element exists.
    /// </summary>
    HTMLElement body { get; }

    /// <summary>
    /// The Document.characterSet read-only property returns the character encoding of the document that it's currently rendered with.
    /// </summary>
    /// <remarks>Note: A "character set" and a "character encoding" are related, but different. Despite the name of this property, it returns the encoding.</remarks>
    string characterSet { get; }

    /// <summary>
    /// The Document.childElementCount read-only property returns the number of child elements of the document.
    /// </summary>
    int childElementCount { get; }

    /// <summary>
    /// The read-only children property returns a live HTMLCollection which contains all of the child elements of the document upon which it was called. 
    /// For HTML documents, this is usually only the root &lt;html&gt; element.
    /// See Element.children for child elements of specific HTML elements within the document.
    /// </summary>
    HTMLCollection children { get; }

    /// <summary>
    /// The Document.compatMode read-only property indicates whether the document is rendered in Quirks mode or Standards mode.
    /// <para>"BackCompat" if the document is in quirks mode.</para>
    /// <para>"CSS1Compat" if the document is in no-quirks (also known as "standards") mode or limited-quirks(also known as "almost standards") mode.</para>
    /// </summary>
    /// <remarks>Note: All these modes are now standardized, so the older "standards" and "almost standards" names are nonsensical and no longer used in standards.</remarks>
    string compatMode { get; }

    /// <summary>
    /// The Document.contentType read-only property returns the MIME type that the document is being rendered as. This may come from HTTP headers or other sources of MIME information, and might be affected by automatic type conversions performed by either the browser or extensions.
    /// </summary>
    string contentType { get; }

    /// <summary>
    /// The Document property cookie lets you read and write cookies associated with the document. It serves as a getter and setter for the actual values of the cookies.
    /// </summary>
    string cookie { get; set; }

    /// <summary>
    /// The Document.currentScript property returns the &lt;script&gt; element whose script is currently being processed and isn't a JavaScript module. (For modules use import.meta instead.)
    /// </summary>
    HTMLScriptElement currentScript { get; }

    /// <summary>
    /// In browsers, document.defaultView returns the window object associated with a document, or null if none is available.
    /// </summary>
    Window defaultView { get; }

    /// <summary>
    /// document.designMode controls whether the entire document is editable. Valid values are "on" and "off". According to the specification, this property is meant to default to "off". 
    /// </summary>
    string designMode { get; set; }

    /// <summary>
    /// The Document.dir property is a string representing the directionality of the text of the document, whether left to right (default) or right to left. Possible values are 'rtl', right to left, and 'ltr', left to right.
    /// </summary>
    string dir { get; set; }

    /// <summary>
    /// The doctype read-only property of the Document interface is a DocumentType object representing the Document Type Declaration (DTD) associated with the current document.
    /// </summary>
    DocumentType doctype { get; }

    /// <summary>
    /// The documentElement read-only property of the Document interface returns the Element that is the root element of the document (for example, the &lt;html&gt; element for HTML documents).
    /// </summary>
    Element documentElement { get; }

    /// <summary>
    /// The documentURI read-only property of the Document interface returns the document location as a string.
    /// </summary>
    string documentURI { get; }

    /// <summary>
    /// The embeds read-only property of the Document interface returns a list of the embedded &lt;embed&gt; elements within the current document.
    /// </summary>
    HTMLCollection embeds { get; }

    /// <summary>
    /// The Document.firstElementChild read-only property returns the document's first child Element, or null if there are no child elements.
    /// For HTML documents, this is usually the only child, the root &lt;html&gt; element.
    /// </summary>
    Element firstElementChild { get; }

    /// <summary>
    /// The fonts property of the Document interface returns the FontFaceSet interface of the document.
    /// </summary>
    FontFaceSet fonts { get; set; }

    /// <summary>
    /// The forms read-only property of the Document interface returns an HTMLCollection listing all the &lt;form&gt; elements contained in the document.
    /// </summary>
    HTMLCollection forms { get; }

    /// <summary>
    /// The head read-only property of the Document interface returns the &lt;head&gt; element of the current document.
    /// </summary>
    HTMLHeadElement head { get; }

    /// <summary>
    /// The Document.hidden read-only property returns a Boolean value indicating if the page is considered hidden or not.
    /// The Document.visibilityState property provides an alternative way to determine whether the page is hidden.
    /// </summary>
    bool hidden { get; }

    /// <summary>
    /// The images read-only property of the Document interface returns a collection of the images in the current HTML document.
    /// </summary>
    HTMLCollection images { get; }

    /// <summary>
    /// The Document.implementation property returns a DOMImplementation object associated with the current document.
    /// </summary>
    DOMImplementation implementation { get; set; }

    /// <summary>
    /// The Document.lastElementChild read-only property returns the document's last child Element, or null if there are no child elements.
    /// For HTML documents, this is usually the only child, the root &lt;html&gt; element.
    /// </summary>
    Element lastElementChild { get; }

    /// <summary>
    /// The lastModified property of the Document interface returns a string containing the date and local time on which the current document was last modified.
    /// </summary>
    string lastModified { get; set; }

    /// <summary>
    /// The links read-only property of the Document interface returns a collection of all &lt;area&gt; elements and &lt;a&gt; elements in a document with a value for the href attribute.
    /// </summary>
    HTMLCollection links { get; }

    /// <summary>
    /// The Document.location read-only property returns a Location object, which contains information about the URL of the document and provides methods for changing that URL and loading another URL.
    /// </summary>
    Location location { get; }

    /// <summary>
    /// The plugins read-only property of the Document interface returns an HTMLCollection object containing one or more HTMLEmbedElements representing the &lt;embed&gt; elements in the current document.
    /// </summary>
    HTMLCollection plugins { get; }

    /// <summary>
    /// The Document.readyState property describes the loading state of the document. When the value of this property changes, a readystatechange event fires on the document object.
    /// The readyState of a document can be one of following:
    /// <para> loading - The document is still loading.</para>
    /// <para> interactive - The document has finished loading and the document has been parsed but sub-resources such as scripts, images, stylesheets and frames are still loading. The state indicates that the DOMContentLoaded event is about to fire.</para>
    /// <para> complete - The document and all sub-resources have finished loading. The state indicates that the load event is about to fire.</para>
    /// </summary>
    string readyState { get; }

    /// <summary>
    /// The Document.referrer property returns the URI of the page that linked to this page.
    /// </summary>
    string referrer { get; }

    /// <summary>
    /// The scripts property of the Document interface returns a list of the &lt;script&gtl elements in the document. The returned object is an HTMLCollection.
    /// </summary>
    HTMLCollection scripts { get; }

    /// <summary>
    /// The scrollingElement read-only property of the Document interface returns a reference to the Element that scrolls the document. In standards mode, this is the root element of the document, document.documentElement.
    /// </summary>
    /// <remarks>When in quirks mode, the scrollingElement attribute returns the HTML body element if it exists and is not potentially scrollable, otherwise it returns null. This may look surprising but is true according to both the specification and browsers.</remarks>
    Element scrollingElement { get; }

    /// <summary>
    /// The styleSheets read-only property of the Document interface returns a StyleSheetList of CSSStyleSheet objects, for stylesheets explicitly linked into or embedded in a document.
    /// </summary>
    StyleSheetList styleSheets { get; }

    /// <summary>
    /// The timeline readonly property of the Document interface represents the default timeline of the current document. This timeline is a special instance of DocumentTimeline.
    /// </summary>
    DocumentTimeline timeline { get; }

    /// <summary>
    /// The document.title property gets or sets the current title of the document. When present, it defaults to the value of the &lt;title&gt;.
    /// </summary>
    string title { get; set; }

    /// <summary>
    /// The URL read-only property of the Document interface returns the document location as a string.
    /// </summary>
    string URL { get; }

    /// <summary>
    /// The Document.visibilityState read-only property returns the visibility of the document. It can be used to check whether the document is in the background or in a minimized window, or is otherwise not visible to the user.
    /// When the value of this property changes, the visibilitychange event is sent to the Document.
    /// The Document.hidden property provides an alternative way to determine whether the page is hidden.
    /// <para> visible - The page content may be at least partially visible.In practice this means that the page is the foreground tab of a non-minimized window.</para>
    /// <para> hidden - The page content is not visible to the user.In practice this means that the document is either a background tab or part of a minimized window, or the OS screen lock is active.</para>
    /// </summary>
    string visibilityState { get; }
}

/// <summary>
/// 
/// </summary>
public static class DocumentExtensions
{
    public static Var<Element> QuerySelector(this SyntaxBuilder b, Var<Document> document, Var<string> selectors)
    {
        return b.CallOnObject<Element>(document, "querySelector", selectors);
    }

    public static Var<Element> QuerySelector(this SyntaxBuilder b, Var<string> selector)
    {
        return b.QuerySelector(b.Document(), selector);
    }

    public static Var<Element> QuerySelector(this SyntaxBuilder b, string selector)
    {
        return b.QuerySelector(b.Const(selector));
    }
}