using Metapsi.Syntax;

namespace Metapsi.Html
{
    /// <summary>
    /// The ExtendableEvent interface extends the lifetime of the install and activate events dispatched on the global scope as part of the service worker lifecycle. This ensures that any functional events (like FetchEvent) are not dispatched until it upgrades database schemas and deletes the outdated cache entries.
    /// </summary>
    public interface ExtendableEvent : Event
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public static class ExtendableEventExtensions
    {
        /// <summary>
        /// The ExtendableEvent.waitUntil() method tells the event dispatcher that work is ongoing. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <param name="promise">A Promise that extends the lifetime of the event.</param>
        public static void ExtendableEventWaitUntil<T>(this SyntaxBuilder b, Var<T> e, Var<Promise> promise)
            where T: ExtendableEvent
        {
            b.CallOnObject(e, "waitUntil", promise);
        }
    }
}
