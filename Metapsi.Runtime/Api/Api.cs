using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi
{
    public static class Api
    {
        public static List<Type> ScalarTypes = new List<Type>()
        {
            typeof(string),
            typeof(int),
            typeof(long),
            typeof(decimal),
            typeof(bool),
            typeof(Guid)
        };

        public class PostBody
        {
        }

        public class PostBody<T1>
        {
            public T1 P1 { get; set; }
        }

        public class PostBody<T1, T2>
        {
            public T1 P1 { get; set; }
            public T2 P2 { get; set; }
        }

        public class PostBody<T1, T2, T3>
        {
            public T1 P1 { get; set; }
            public T2 P2 { get; set; }
            public T3 P3 { get; set; }
        }

        public static async Task<TOut> Request<TOut>(this HttpClient httpClient, Request<TOut> request)
        {
            var r = await httpClient.GetAsync(request.Name);
            if (!r.IsSuccessStatusCode)
            {
                throw new Exception($"HTTP client code: {r.StatusCode}");
            }

            if (typeof(TOut) == typeof(string) && r.Content?.Headers?.ContentType?.MediaType == "text/plain")
            {
                return (TOut)(object)await r.Content.ReadAsStringAsync();
            }

            var json = await r.Content.ReadAsStringAsync();
            return Metapsi.Serialize.FromJson<TOut>(json);
        }

        public static async Task<TOut> Request<TOut, T1>(this HttpClient httpClient, Request<TOut, T1> request, T1 p1)
        {
            HttpResponseMessage r;
            if (AreScalarTypes(p1.GetType()))
            {
                r = await httpClient.GetAsync(httpClient.BuildUri(request.Name, p1));
            }
            else
            {
                r = await httpClient.PostAsync(
                    request.Name,
                    JsonContent(
                       new PostBody<T1>()
                       {
                           P1 = p1
                       }));
            }
            if (!r.IsSuccessStatusCode)
            {
                throw new Exception($"HTTP client code: {r.StatusCode}");
            }

            if (typeof(TOut) == typeof(string) && r.Content?.Headers?.ContentType?.MediaType == "text/plain")
            {
                return (TOut)(object)await r.Content.ReadAsStringAsync();
            }

            var json = await r.Content.ReadAsStringAsync();
            return Metapsi.Serialize.FromJson<TOut>(json);
        }

        public static async Task<TOut> Request<TOut, T1, T2>(this HttpClient httpClient, Request<TOut, T1, T2> request, T1 p1, T2 p2)
        {
            HttpResponseMessage r;
            if (AreScalarTypes(p1.GetType(), p2.GetType()))
            {
                r = await httpClient.GetAsync(httpClient.BuildUri(request.Name, p1, p2));
            }
            else
            {
                r = await httpClient.PostAsync(
                    request.Name,
                    JsonContent(
                       new PostBody<T1, T2>()
                       {
                           P1 = p1,
                           P2 = p2
                       }));
            }

            if (!r.IsSuccessStatusCode)
            {
                throw new Exception($"HTTP client code: {r.StatusCode}");
            }

            if (typeof(TOut) == typeof(string) && r.Content?.Headers?.ContentType?.MediaType == "text/plain")
            {
                return (TOut)(object)await r.Content.ReadAsStringAsync();
            }

            var json = await r.Content.ReadAsStringAsync();
            return Metapsi.Serialize.FromJson<TOut>(json);
        }

        public static async Task<TOut> Request<TOut, T1, T2, T3>(this HttpClient httpClient, Request<TOut, T1, T2, T3> request, T1 p1, T2 p2, T3 p3)
        {
            HttpResponseMessage r;
            if (AreScalarTypes(p1.GetType(), p2.GetType(), p3.GetType()))
            {
                r = await httpClient.GetAsync(httpClient.BuildUri(request.Name, p1, p2, p3));
            }
            else
            {
                r = await httpClient.PostAsync(
                    request.Name,
                    JsonContent(
                       new PostBody<T1, T2, T3>()
                       {
                           P1 = p1,
                           P2 = p2,
                           P3 = p3
                       }));
            }

            if (!r.IsSuccessStatusCode)
            {
                throw new Exception($"HTTP client code: {r.StatusCode}");
            }

            if (typeof(TOut) == typeof(string) && r.Content?.Headers?.ContentType?.MediaType == "text/plain")
            {
                return (TOut)(object)await r.Content.ReadAsStringAsync();
            }

            var json = await r.Content.ReadAsStringAsync();
            return Metapsi.Serialize.FromJson<TOut>(json);
        }

        public static async Task Command(this HttpClient httpClient, Command command)
        {
            var r = await httpClient.GetAsync(command.Name);
            if (!r.IsSuccessStatusCode)
            {
                throw new Exception($"HTTP client code: {r.StatusCode}");
            }
        }

        public static async Task Command<T1>(this HttpClient httpClient, Command<T1> command, T1 p1)
        {
            HttpResponseMessage r;
            if (AreScalarTypes(p1.GetType()))
            {
                r = await httpClient.GetAsync(httpClient.BuildUri(command.Name, p1));
            }
            else
            {
                r = await httpClient.PostAsync(
                    command.Name,
                    JsonContent(new PostBody<T1>()
                    {
                        P1 = p1
                    }));
            }

            if (!r.IsSuccessStatusCode)
            {
                throw new Exception($"HTTP client code: {r.StatusCode}");
            }
        }

        public static async Task Command<T1, T2>(this HttpClient httpClient, Command<T1, T2> command, T1 p1, T2 p2)
        {
            HttpResponseMessage r;
            if (AreScalarTypes(p1.GetType(), p2.GetType()))
            {
                r = await httpClient.GetAsync(httpClient.BuildUri(command.Name, p1, p2));
            }
            else
            {
                r = await httpClient.PostAsync(
                   command.Name,
                   JsonContent(new PostBody<T1, T2>()
                   {
                       P1 = p1,
                       P2 = p2
                   }));
            }

            if (!r.IsSuccessStatusCode)
            {
                throw new Exception($"HTTP client code: {r.StatusCode}");
            }
        }

        public static async Task Command<T1, T2, T3>(this HttpClient httpClient, Command<T1, T2, T3> command, T1 p1, T2 p2, T3 p3)
        {
            HttpResponseMessage r;
            if (AreScalarTypes(p1.GetType(), p2.GetType(), p3.GetType()))
            {
                r = await httpClient.GetAsync(httpClient.BuildUri(command.Name, p1, p2, p3));
            }
            else
            {
                r = await httpClient.PostAsync(
                   command.Name,
                   JsonContent(new PostBody<T1, T2, T3>()
                   {
                       P1 = p1,
                       P2 = p2,
                       P3 = p3
                   }));
            }

            if (!r.IsSuccessStatusCode)
            {
                throw new Exception($"HTTP client code: {r.StatusCode}");
            }
        }

        public static void MapRequest<TOut>(this ImplementationGroup ig, Request<TOut> request, HttpClient httpClient)
        {
            ig.MapRequest(request, async (rc) => await httpClient.Request(request));
        }

        public static void MapRequest<TOut, T1>(this ImplementationGroup ig, Request<TOut, T1> request, HttpClient httpClient)
        {
            ig.MapRequest(request, async (rc, p1) => await httpClient.Request(request, p1));
        }

        public static void MapRequest<TOut, T1, T2>(this ImplementationGroup ig, Request<TOut, T1, T2> request, HttpClient httpClient)
        {
            ig.MapRequest(request, async (rc, p1, p2) => await httpClient.Request(request, p1, p2));
        }

        public static void MapRequest<TOut, T1, T2, T3>(this ImplementationGroup ig, Request<TOut, T1, T2, T3> request, HttpClient httpClient)
        {
            ig.MapRequest(request, async (rc, p1, p2, p3) => await httpClient.Request(request, p1, p2, p3));
        }

        public static void MapCommand(this ImplementationGroup ig, Command command, HttpClient httpClient)
        {
            ig.MapCommand(command, async (rc) => await httpClient.Command(command));
        }

        public static void MapCommand<T1>(this ImplementationGroup ig, Command<T1> command, HttpClient httpClient)
        {
            ig.MapCommand(command, async (rc, p1) => await httpClient.Command(command, p1));
        }

        public static void MapCommand<T1, T2>(this ImplementationGroup ig, Command<T1, T2> command, HttpClient httpClient)
        {
            ig.MapCommand(command, async (rc, p1, p2) => await httpClient.Command(command, p1, p2));
        }

        public static void MapCommand<T1, T2, T3>(this ImplementationGroup ig, Command<T1, T2, T3> command, HttpClient httpClient)
        {
            ig.MapCommand(command, async (rc, p1, p2, p3) => await httpClient.Command(command, p1, p2, p3));
        }

        public static bool AreScalarTypes(params Type[] types)
        {
            foreach (Type t in types)
                if (!ScalarTypes.Contains(t))
                    return false;

            return true;
        }

        private static HttpContent JsonContent(object o)
        {
            var content = new StringContent(Serialize.ToJson(o));
            content.Headers.ContentType.MediaType = "application/json";
            return content;
        }

        public static Uri BuildUri(this HttpClient httpClient, params object[] segments)
        {
            Uri uri = httpClient.BaseAddress;

            foreach (var segment in segments)
            {
                uri = new Uri(uri, $"{Uri.EscapeDataString(segment.ToString())}/");
            }

            return uri;
        }
    }
}
