using Metapsi.Syntax;

namespace Metapsi.Html;

public static partial class FetchExtensions
{
    /// <summary>
    /// Sets content type and body properties
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="body"></param>
    public static void SetJsonBody<T>(this PropsBuilder<RequestInit> b, Var<T> body)
    {
        b.SetHeaders(b => b.AddContentTypeJson());
        b.SetBody(b.Serialize(body));
    }
}