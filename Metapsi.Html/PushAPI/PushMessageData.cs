using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The PushMessageData interface of the Push API provides methods which let you retrieve the push data sent by a server in various formats.
/// </summary>
public interface PushMessageData
{

}

/// <summary>
/// 
/// </summary>
public static class PushMessageDataExtensions
{
    /// <summary>
    /// The arrayBuffer() method of the PushMessageData interface extracts push message data as an ArrayBuffer object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="pushMessageData"></param>
    /// <returns>An ArrayBuffer.</returns>
    public static Var<ArrayBuffer> PushMessageDataArrayBuffer(this SyntaxBuilder b, Var<PushMessageData> pushMessageData)
    {
        return b.CallOnObject<ArrayBuffer>(pushMessageData, "arrayBuffer");
    }

    /// <summary>
    /// The blob() method of the PushMessageData interface extracts push message data as a Blob object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="pushMessageData"></param>
    /// <returns>A Blob</returns>
    public static Var<Blob> PushMessageDataBlob(this SyntaxBuilder b, Var<PushMessageData> pushMessageData)
    {
        return b.CallOnObject<Blob>(pushMessageData, "blob");
    }

    /// <summary>
    /// The bytes() method of the PushMessageData interface extracts push message data as an Uint8Array object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="pushMessageData"></param>
    /// <returns>An Uint8Array.</returns>
    public static Var<Uint8Array> PushMessageDataBytes(this SyntaxBuilder b, Var<PushMessageData> pushMessageData)
    {
        return b.CallOnObject<Uint8Array>(pushMessageData, "bytes");
    }

    /// <summary>
    /// The json() method of the PushMessageData interface extracts push message data by parsing it as a JSON string and returning the result.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="pushMessageData"></param>
    /// <returns>The result of parsing push event data as JSON. This could be anything that can be represented by JSON — an object, an array, a string, a number…</returns>
    public static Var<object> PushMessageDataJson(this SyntaxBuilder b, Var<PushMessageData> pushMessageData)
    {
        return b.CallOnObject<object>(pushMessageData, "json");
    }

    /// <summary>
    /// The json() method of the PushMessageData interface extracts push message data by parsing it as a JSON string and returning the result.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="pushMessageData"></param>
    /// <returns>The result of parsing push event data as T</returns>
    public static Var<T> PushMessageDataJson<T>(this SyntaxBuilder b, Var<PushMessageData> pushMessageData)
    {
        return b.CallOnObject<T>(pushMessageData, "json");
    }

    /// <summary>
    /// The text() method of the PushMessageData interface extracts push message data as a plain text string.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="pushMessageData"></param>
    /// <returns>A string.</returns>
    public static Var<string> PushMessageDataText(this SyntaxBuilder b, Var<PushMessageData> pushMessageData)
    {
        return b.CallOnObject<string>(pushMessageData, "text");
    }
}