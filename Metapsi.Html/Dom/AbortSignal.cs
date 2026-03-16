using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The AbortSignal interface represents a signal object that allows you to communicate with an asynchronous operation (such as a fetch request) and abort it if required via an AbortController object.
/// </summary>
public interface AbortSignal : EventTarget
{
    /// <summary>
    /// The aborted read-only property returns a value that indicates whether the asynchronous operations the signal is communicating with are aborted (true) or not (false).
    /// </summary>
    bool aborted { get; }

    /// <summary>
    /// The reason read-only property returns a JavaScript value that indicates the abort reason.
    /// </summary>
    object reason { get; }
}

/// <summary>
/// 
/// </summary>
public static partial class AbortSignalExtensions
{
    /// <summary>
    /// The AbortSignal.abort() static method returns an AbortSignal that is already set as aborted (and which does not trigger an abort event).
    /// </summary>
    /// <param name="b"></param>
    /// <returns>An AbortSignal instance with the AbortSignal.aborted property set to true, and AbortSignal.reason set to the specified or default reason value.</returns>
    public static ObjBuilder<AbortSignal> abort(
        this ObjBuilder<ClassDef<AbortSignal>> b)
    {
        return b.Call<AbortSignal>(nameof(abort));
    }

    /// <summary>
    /// The AbortSignal.abort() static method returns an AbortSignal that is already set as aborted (and which does not trigger an abort event).
    /// </summary>
    /// <param name="b"></param>
    /// <param name="reason">The reason why the operation was aborted, which can be any JavaScript value. If not specified, the reason is set to "AbortError" DOMException.</param>
    /// <returns>An AbortSignal instance with the AbortSignal.aborted property set to true, and AbortSignal.reason set to the specified or default reason value.</returns>
    public static ObjBuilder<AbortSignal> abort(
        this ObjBuilder<ClassDef<AbortSignal>> b,
        IVariable reason)
    {
        return b.Call<AbortSignal>(nameof(abort), reason);
    }

    /// <summary>
    /// The reason why the operation was aborted, which can be any JavaScript value. If not specified, the reason is set to "AbortError" DOMException.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="iterable">An iterable (such as an Array) of abort signals.</param>
    /// <returns>An AbortSignal that is:
    /// <para> Already aborted, if any of the abort signals given is already aborted.The returned AbortSignal's reason will be already set to the reason of the first abort signal that was already aborted.</para>
    /// <para> Asynchronously aborted, when any abort signal in iterable aborts. The reason will be set to the reason of the first abort signal that is aborted.</para>
    /// </returns>
    public static ObjBuilder<AbortSignal> any(
        this ObjBuilder<ClassDef<AbortSignal>> b,
        IVariable iterable)
    {
        return b.Call<AbortSignal>(nameof(any), iterable);
    }

    /// <summary>
    /// The AbortSignal.timeout() static method returns an AbortSignal that will automatically abort after a specified time.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="time">The "active" time in milliseconds before the returned AbortSignal will abort. The value must be within range of 0 and Number.MAX_SAFE_INTEGER.</param>
    /// <returns>An AbortSignal. The signal will abort with its AbortSignal.reason property set to a TimeoutError DOMException on timeout, or an AbortError DOMException if the operation was user-triggered.</returns>
    public static ObjBuilder<AbortSignal> timeout(
        this ObjBuilder<ClassDef<AbortSignal>> b,
        Var<int> time)
    {
        return b.Call<AbortSignal>(nameof(timeout), time);
    }

    /// <summary>
    /// The throwIfAborted() method throws the signal's abort reason if the signal has been aborted; otherwise it does nothing.
    /// </summary>
    /// <param name="b"></param>
    public static void throwIfAborted(this ObjBuilder<AbortSignal> b)
    {
        b.Call(nameof(throwIfAborted));
    }
}