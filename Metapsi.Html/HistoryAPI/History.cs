using Metapsi.Syntax;
using System.Dynamic;
using System.Security.AccessControl;

namespace Metapsi.Html;

/// <summary>
/// The History interface of the History API allows manipulation of the browser session history, that is the pages visited in the tab or frame that the current page is loaded in. There is only one instance of history(It is a singleton.) accessible via the global object history.
/// </summary>
public interface History
{
    /// <summary>
    /// The length read-only property of the History interface returns an integer representing the number of entries in the session history, including the currently loaded page.
    /// </summary>
    int length { get; }

    /// <summary>
    /// The scrollRestoration property of the History interface allows web applications to explicitly set default scroll restoration behavior on history navigation. One of the following:
    /// <para> auto - The location on the page to which the user has scrolled will be restored.</para>
    /// <para> manual - The location on the page is not restored.The user will have to scroll to the location manually.</para>
    /// </summary>
    string scrollRestoration { get; set; }

    /// <summary>
    /// The state read-only property of the History interface returns a value representing the state at the top of the history stack. This is a way to look at the state without having to wait for a popstate event.
    /// </summary>
    DynamicObject state { get; }
}

/// <summary>
/// 
/// </summary>
public static class HistoryExtensions
{
    private static Var<History> HistorySingleton(this SyntaxBuilder b)
    {
        return b.Get(b.Window(), x => x.history);
    }

    /// <summary>
    /// The back() method of the History interface causes the browser to move back one page in the session history.
    /// <para> It has the same effect as calling history.go(-1). If there is no previous page, this method call does nothing.</para>
    /// <para> This method is asynchronous.Add a listener for the popstate event in order to determine when the navigation has completed.</para>
    /// </summary>
    /// <param name="b"></param>
    public static void HistoryBack(this SyntaxBuilder b)
    {
        b.CallOnObject(b.HistorySingleton(), "back");
    }

    /// <summary>
    /// The forward() method of the History interface causes the browser to move forward one page in the session history. It has the same effect as calling history.go(1).
    /// <para> This method is asynchronous.Add a listener for the popstate event in order to determine when the navigation has completed.</para> 
    /// </summary>
    /// <param name="b"></param>
    public static void HistoryForward(this SyntaxBuilder b)
    {
        b.CallOnObject(b.HistorySingleton(), "forward");
    }

    /// <summary>
    /// The go() method of the History interface loads a specific page from the session history. You can use it to move forwards and backwards through the history depending on the value of a parameter.
    /// <para> This method is asynchronous.Add a listener for the popstate event in order to determine when the navigation has completed.</para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="delta"></param>
    public static void HistoryGo(this SyntaxBuilder b, Var<int> delta)
    {
        b.CallOnObject(b.HistorySingleton(), "go", delta);
    }

    /// <summary>
    /// The go() method of the History interface loads a specific page from the session history. You can use it to move forwards and backwards through the history depending on the value of a parameter.
    /// <para> This method is asynchronous.Add a listener for the popstate event in order to determine when the navigation has completed.</para>
    /// </summary>
    /// <param name="b"></param>
    public static void HistoryGo(this SyntaxBuilder b)
    {
        b.CallOnObject(b.HistorySingleton(), "go");
    }

    /// <summary>
    /// The pushState() method of the History interface adds an entry to the browser's session history stack.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="state">The state object is a JavaScript object which is associated with the new history entry created by pushState(). Whenever the user navigates to the new state, a popstate event is fired, and the state property of the event contains a copy of the history entry's state object. The state object can be anything that can be serialized.</param>
    /// <param name="url">The new history entry's URL. Note that the browser won't attempt to load this URL after a call to pushState(), but it may attempt to load the URL later, for instance, after the user restarts the browser. The new URL does not need to be absolute; if it's relative, it's resolved relative to the current URL. The new URL must be of the same origin as the current URL; otherwise, pushState() will throw an exception. If this parameter isn't specified, it's set to the document's current URL.</param>
    /// <remarks>The pushState API specifies a mandatory, but obsolete parameter called 'unused', which we automatically pass in as an empty string</remarks>
    public static void HistoryPushState<T>(this SyntaxBuilder b, Var<T> state, Var<string> url)
    {
        b.CallOnObject(b.HistorySingleton(), "pushState", state, b.Const(string.Empty), url);
    }

    /// <summary>
    /// The pushState() method of the History interface adds an entry to the browser's session history stack.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="state">The state object is a JavaScript object which is associated with the new history entry created by pushState(). Whenever the user navigates to the new state, a popstate event is fired, and the state property of the event contains a copy of the history entry's state object. The state object can be anything that can be serialized.</param>
    /// <remarks>The pushState API specifies a mandatory, but obsolete parameter called 'unused', which we automatically pass in as an empty string</remarks>
    public static void HistoryPushState<T>(this SyntaxBuilder b, Var<T> state)
    {
        b.CallOnObject(b.HistorySingleton(), "pushState", state, b.Const(string.Empty));
    }

    /// <summary>
    /// The replaceState() method of the History interface modifies the current history entry, replacing it with the state object and URL passed in the method parameters. This method is particularly useful when you want to update the state object or URL of the current history entry in response to some user action.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="state">An object which is associated with the history entry passed to the replaceState() method. The state object can be null.</param>
    /// <param name="url">The URL of the history entry. The new URL must be of the same origin as the current URL; otherwise the replaceState() method throws an exception.</param>
    /// <remarks>The replaceState API specifies a mandatory, but obsolete parameter called 'unused', which we automatically pass in as an empty string</remarks>
    public static void HistoryReplaceState<T>(this SyntaxBuilder b, Var<T> state, Var<string> url)
    {
        b.CallOnObject(b.HistorySingleton(), "replaceState", state, b.Const(string.Empty), url);
    }

    /// <summary>
    /// The replaceState() method of the History interface modifies the current history entry, replacing it with the state object and URL passed in the method parameters. This method is particularly useful when you want to update the state object or URL of the current history entry in response to some user action.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="state">An object which is associated with the history entry passed to the replaceState() method. The state object can be null.</param>
    /// <remarks>The replaceState API specifies a mandatory, but obsolete parameter called 'unused', which we automatically pass in as an empty string</remarks>
    public static void HistoryReplaceState<T>(this SyntaxBuilder b, Var<T> state)
    {
        b.CallOnObject(b.HistorySingleton(), "replaceState", state, b.Const(string.Empty));
    }
}
