
using Metapsi;
using Metapsi.Html;
using Metapsi.Syntax;

namespace Metapsi.Html;

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
