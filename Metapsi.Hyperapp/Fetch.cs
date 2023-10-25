using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    public class ApiError
    {
        public string ErrorMessage { get; set; }
    }

    public class FetchOptions
    {
        public string method { get; set; } // GET/POST
        public object headers { get; set; } = new();
        public string body { get; set; }
    }

    public static class FetchExtensions
    {
        public static void Fetch<TResult>(
            this SyntaxBuilder b, 
            Var<string> url, 
            Var<FetchOptions> options, 
            Var<Action<TResult>> onResult, 
            Var<Action<ApiError>> onError)
        {
            b.CallExternal("fetch", "Fetch", url, options, onResult, onError);
        }
    }
}
