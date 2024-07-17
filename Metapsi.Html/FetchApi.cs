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
    private FetchOptions() { }

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
    public DynamicObject headers { get; set; }
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

    public static void SetJsonBody<T>(this PropsBuilder<FetchOptions> b, Var<T> body)
    {
        b.SetProperty(b.Props, b.Const("body"), b.Serialize(body));
    }

    public static void SetBody<T>(this PropsBuilder<FetchOptions> b, Var<T> body)
    {
        b.SetProperty(b.Props, b.Const("body"), body);
    }

    public static void AddHeaders(this PropsBuilder<FetchOptions> b, Var<string> header, Var<string> value)
    {
        var headers = b.Get(b.Props, x => x.headers);
        b.If(
            b.Not(
                b.HasObject(headers)),
            b=> b.Set(b.Props, x => x.headers, b.NewObj<DynamicObject>()));
        headers = b.Get(b.Props, x => x.headers);
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
        var fetchOptions = b.SetProps(b.NewObj<DynamicObject>(), setProps);
        return b.CallOnObject<Promise>(b.Self(), "fetch", url, fetchOptions);
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
            b.SetJsonBody(postObject);
            b.SetJsonContentTypeHeaders();
        });
        b.HandleJsonResponse(fetchPost, onSuccess, onFailure);
    }

    public static void PostJson<TIn>(this SyntaxBuilder b, Var<string> postUrl, Var<TIn> postObject, Var<System.Action> onSuccess, Var<System.Action<ClientSideException>> onFailure)
    {
        var fetchPost = b.Fetch(postUrl, b =>
        {
            b.SetMethod("POST");
            b.SetJsonBody(postObject);
            b.SetJsonContentTypeHeaders();
        });
        b.HandleResponse(fetchPost, onSuccess, onFailure);
    }

    public static Var<Promise> HandleResponse(
        this SyntaxBuilder b,
        Var<Promise> fetchPromise,
        Var<System.Action> onSuccess,
        Var<System.Action<ClientSideException>> onFailure)
    {
        var networkPromise = b.Then(
            fetchPromise,
            b.Def((SyntaxBuilder b, Var<object> r) =>
            {
                var isOk = b.GetProperty<bool>(r, "ok");
                return b.If(
                    isOk,
                    b =>
                    {
                        b.Call(onSuccess);
                        return b.Const(string.Empty).As<Promise>();
                    },
                    b =>
                    {
                        var bodyTextPromise = b.CallOnObject<Promise>(r, "text");
                        var errorPromise = b.Then(
                            bodyTextPromise,
                            b.Def((SyntaxBuilder b, Var<object> body) =>
                            {
                                var bodyText = b.AsString(body);
                                return b.Throw(
                                    b.If(
                                        b.HasValue(bodyText),
                                        b => bodyText,
                                        b => b.GetProperty<string>(r, b.Const("statusText")))).As<Promise>();
                            }));
                        return errorPromise;
                    });
            }));

        var catchPromise = b.Catch(
            networkPromise,
            b.Def((SyntaxBuilder b, Var<ClientSideException> ex) =>
            {
                b.Log(ex);
                b.Call(onFailure, ex);
            }));
        return catchPromise;
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
                        var bodyTextPromise = b.CallOnObject<Promise>(r, "text");
                        var errorPromise = b.Then(
                            bodyTextPromise,
                            b.Def((SyntaxBuilder b, Var<object> body) =>
                            {
                                var bodyText = b.AsString(body);
                                return b.Throw(
                                    b.If(
                                        b.HasValue(bodyText),
                                        b => bodyText,
                                        b => b.GetProperty<string>(r, b.Const("statusText")))).As<Promise>();
                            }));
                        return errorPromise;
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
            (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch) =>
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

    public static Var<HyperType.Effect> Fetch<TModel>(
        this SyntaxBuilder b,
        Var<string> url,
        Action<PropsBuilder<FetchOptions>> fetchOptions,
        Var<HyperType.Action<TModel>> onSucces,
        Var<HyperType.Action<TModel, ClientSideException>> onError)
    {
        return b.MakeEffect(
            (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch) =>
            {
                var fetchPromise = b.Fetch(url, fetchOptions);
                b.HandleResponse(
                    fetchPromise,
                    b.Def((SyntaxBuilder b) =>
                    {
                        b.Dispatch(dispatch, onSucces);
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
                b.SetJsonBody(input);
            },
            onSucces,
            onError);
    }

    public static Var<HyperType.Effect> PostJson<TModel, TIn>(
        this SyntaxBuilder b,
        Var<string> url,
        Var<TIn> input,
        Var<HyperType.Action<TModel>> onSucces,
        Var<HyperType.Action<TModel, ClientSideException>> onError)
    {
        return b.Fetch(
            url,
            b =>
            {
                b.SetMethod("POST");
                b.SetJsonContentTypeHeaders();
                b.SetJsonBody(input);
            },
            onSucces,
            onError);
    }
}
