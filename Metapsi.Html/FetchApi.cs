using Metapsi.Dom;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

public class ClientSideException
{
    public string message { get; set; }
}

public class FetchOptions
{
    /// <summary>
    /// *GET, POST, PUT, DELETE, etc.
    /// </summary>
    public string method { get; set; }
    /// <summary>
    /// no-cors, *cors, same-origin
    /// </summary>
    public string mode { get; set; }
    /// <summary>
    ///  *default, no-cache, reload, force-cache, only-if-cached
    /// </summary>
    public string cache { get; set; }
    /// <summary>
    /// include, *same-origin, omit
    /// </summary>
    public string credentials { get; set; }
    /// <summary>
    /// "Content-Type": "application/json", 'Content-Type': 'application/x-www-form-urlencoded'
    /// </summary>
    public Dictionary<string, string> headers { get; set; } = new Dictionary<string, string>() { { "Content-Type", "application/json" } };
    /// <summary>
    /// manual, *follow, error
    /// </summary>
    public string redirect { get; set; }
    /// <summary>
    /// no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
    /// </summary>
    public string referrerPolicy { get; set; }
    /// <summary>
    /// body data type must match "Content-Type" header
    /// </summary>
    public string body { get; set; }
}

public static class FetchApi
{
    public static void SetMethod(this PropsBuilder<FetchOptions> b, string method)
    {
        b.SetProperty(b.Props, b.Const("method"), b.Const(method));
    }

    public static void SetMethodPost(this PropsBuilder<FetchOptions> b)
    {
        b.SetProperty(b.Props, b.Const("method"), b.Const("POST"));
    }

    public static void SetCredentials(this PropsBuilder<FetchOptions> b, Var<string> credentials)
    {
        b.SetProperty(b.Props, b.Const(nameof(FetchOptions.credentials)), credentials);
    }

    public static void SetCredentialsInclude(this PropsBuilder<FetchOptions> b)
    {
        b.SetCredentials(b.Const("include"));
    }

    public static void SetBody<T>(this PropsBuilder<FetchOptions> b, Var<T> body)
    {
        b.SetProperty(b.Props, b.Const("body"), b.Serialize(body));
    }

    public static void AddHeaders(this PropsBuilder<FetchOptions> b, Var<string> header, Var<string> value)
    {
        var headers = b.Get(b.Props, x => x.headers);
        b.SetProperty(headers, header, value);
    }

    public static void SetJsonContentTypeHeaders(this PropsBuilder<FetchOptions> b)
    {
        b.AddHeaders(b.Const("Content-Type"), b.Const("application/json"));
    }

    public static Var<Promise> Fetch(this SyntaxBuilder b, Var<string> url)
    {
        return b.CallOnObject<Promise>(b.Self(), "fetch", url);
    }

    public static Var<Promise> Fetch(this SyntaxBuilder b, Var<string> url, Action<PropsBuilder<FetchOptions>> setProps)
    {
        PropsBuilder<FetchOptions> propsBuilder = new PropsBuilder<FetchOptions>();
        propsBuilder.InitializeFrom(b);
        propsBuilder.Props = b.NewObj<DynamicObject>().As<FetchOptions>();
        b.Set(propsBuilder.Props, x => x.headers, b.NewObj<DynamicObject>().As<Dictionary<string, string>>());
        setProps(propsBuilder);
        return b.CallOnObject<Promise>(b.Self(), "fetch", url, propsBuilder.Props);
    }

    public static void GetJson<T>(this SyntaxBuilder b, Var<string> getUrl, Var<System.Action<T>> onSuccess, Var<System.Action<ClientSideException>> onFailure)
    {
        var fetchGet = b.Fetch(getUrl);
        b.HandleJsonResponse(fetchGet, onSuccess, onFailure);
    }

    public static void GetJson<T>(this SyntaxBuilder b, Var<string> getUrl, Action<PropsBuilder<FetchOptions>> setProps, Var<System.Action<T>> onSuccess, Var<System.Action<ClientSideException>> onFailure)
    {
        var fetchGet = b.Fetch(getUrl, setProps);
        b.HandleJsonResponse(fetchGet, onSuccess, onFailure);
    }

    public static void PostJson<TOut>(this SyntaxBuilder b, Var<string> postUrl, Action<PropsBuilder<FetchOptions>> setProps, Var<System.Action<TOut>> onSuccess, Var<System.Action<ClientSideException>> onFailure)
    {
        var fetchPost = b.Fetch(postUrl, b =>
        {
            b.SetMethod("POST");
            b.SetJsonContentTypeHeaders();
            setProps(b);
        });
        b.HandleJsonResponse(fetchPost, onSuccess, onFailure);
    }

    public static void PostJson<TIn, TOut>(this SyntaxBuilder b, Var<string> postUrl, Var<TIn> postObject, Var<System.Action<TOut>> onSuccess, Var<System.Action<ClientSideException>> onFailure)
    {
        var fetchPost = b.Fetch(postUrl, b =>
        {
            b.SetMethod("POST");
            b.SetBody(postObject);
            b.SetJsonContentTypeHeaders();
        });
        b.HandleJsonResponse(fetchPost, onSuccess, onFailure);
    }

    public static Var<Promise> HandleJsonResponse<T>(
        this SyntaxBuilder b,
        Var<Promise> fetchPromise,
        Var<System.Action<T>> onSuccess,
        Var<System.Action<ClientSideException>> onFailure)
    {
        var networkPromise = b.Then(
            fetchPromise,
            b.Def((SyntaxBuilder b, Var<object> r) =>
            {
                var isOk = b.GetProperty<bool>(r, "ok");
                return b.If(
                    isOk,
                    b => b.CallOnObject<Promise>(r, "json"),
                    b =>
                    {
                        b.Log(r);
                        return b.Throw(b.GetProperty<string>(r, b.Const("statusText"))).As<Promise>();
                    });
            }));
        var successPromise = b.Then(
            networkPromise,
            b.Def((SyntaxBuilder b, Var<T> r) =>
            {
                b.Call(onSuccess, r);
            }));
        var catchPromise = b.Catch(
            successPromise,
            b.Def((SyntaxBuilder b, Var<ClientSideException> ex) =>
            {
                b.Log(ex);
                b.Call(onFailure, ex);
            }));
        return catchPromise;
    }

    public static Var<HyperType.Effect> Fetch<TModel, TResult>(
        this SyntaxBuilder b,
        Var<string> url,
        Action<PropsBuilder<FetchOptions>> fetchOptions,
        Var<HyperType.Action<TModel, TResult>> onSucces,
        Var<HyperType.Action<TModel, ClientSideException>> onError)
    {
        return b.MakeEffect(
            (SyntaxBuilder b, Var<HyperType.Dispatcher<TModel>> dispatch) =>
            {
                var fetchPromise = b.Fetch(url, fetchOptions);
                b.HandleJsonResponse(
                    fetchPromise,
                    b.Def((SyntaxBuilder b, Var<TResult> result) =>
                    {
                        b.Dispatch(dispatch, onSucces, result);
                    }),
                    b.Def((SyntaxBuilder b, Var<ClientSideException> ex) =>
                    {
                        b.Dispatch(dispatch, onError, ex);
                    }));
            });
    }

    public static Var<HyperType.Effect> GetJson<TModel, TResult>(
        this SyntaxBuilder b,
        Var<string> url,
        Var<HyperType.Action<TModel, TResult>> onSucces,
        Var<HyperType.Action<TModel, ClientSideException>> onError)
    {
        return b.Fetch(
            url,
            b => { },
            onSucces,
            onError);
    }

    public static Var<HyperType.Effect> PostJson<TModel, TIn, TResult>(
        this SyntaxBuilder b,
        Var<string> url,
        Var<TIn> input,
        Var<HyperType.Action<TModel, TResult>> onSucces,
        Var<HyperType.Action<TModel, ClientSideException>> onError)
    {
        return b.Fetch(
            url,
            b =>
            {
                b.SetMethod("POST");
                b.SetJsonContentTypeHeaders();
                b.SetBody(input);
            },
            onSucces,
            onError);
    }

    public static Var<HyperType.Effect> PostJson<TModel, TIn, TResult>(
        this SyntaxBuilder b,
        Request<TResult, TIn> request,
        Var<TIn> input,
        Var<HyperType.Action<TModel, TResult>> onSucces,
        Var<HyperType.Action<TModel, ClientSideException>> onError)
    {
        return b.PostJson(b.Const("/" + request.Name), input, onSucces, onError);
    }
}
