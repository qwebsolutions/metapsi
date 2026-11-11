using Metapsi.Html;
using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp;

/// <summary>
/// 
/// </summary>
public static class FetchEffects
{
    /// <summary>
    /// Creates a Hyperapp action that shows a simple JS alert with ex.message as alert message
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<HyperType.Action<TState, Html.Error>> AlertOnException<TState>(this ISyntaxBuilder b)
    {
        return b.MakeAction((SyntaxBuilder b, Var<TState> model, Var<Html.Error> ex) =>
        {
            b.Alert(b.Get(ex, x => x.message));
            return model;
        });
    }

    /// <summary>
    /// Throws error if response is not ok. In case response content type is 'application/problem+json', error message is detail if not empty, otherwise title.
    /// In case response has different content type, error message is response.statusText
    /// </summary>
    /// <param name="b"></param>
    /// <param name="response"></param>
    public static Var<Promise> ThrowIfErrorResponse(SyntaxBuilder b, Var<Metapsi.Html.Response> response)
    {
        return b.If(
            b.Get(response, x => !x.ok),
            b =>
            {
                var contentTypeHeaders = b.HeadersGet(b.Get(response, x => x.headers), b.Const("Content-Type"));
                return b.If(
                    b.HasValue(contentTypeHeaders),
                    b =>
                    {
                        return b.If(
                            b.StringIncludes(contentTypeHeaders, b.Const("application/problem+json")),
                            b =>
                            {
                                var fake = b.On<Response, Promise>(
                                    response,
                                    b =>
                                    {
                                        var otherFake = b.Call<Promise<object>>("json").then((SyntaxBuilder b, Var<object> problem) =>
                                        {
                                            var detail = b.GetProperty<string>(problem, "detail");
                                            return b.If(
                                                b.HasValue(detail),
                                                b =>
                                                {
                                                    return b.Throw(detail).As<Promise>();
                                                },
                                                b =>
                                                {
                                                    var title = b.GetProperty<string>(problem, "title");
                                                    return b.Throw(title).As<Promise>();
                                                });
                                        });

                                        return otherFake;
                                    });

                                return fake;
                            },
                            b =>
                            {
                                return b.Throw(b.Get(response, x => x.statusText)).As<Promise>();
                            });
                    },
                    b =>
                    {
                        return b.Throw(b.Get(response, x => x.statusText)).As<Promise>();
                    });
            },
            b =>
            {
                return b.On(b.GetClass<Promise>(), b => b.resolve());
            });
    }

    public static Var<Promise<TOut>> TryGetJson<TOut>(SyntaxBuilder b, Var<Response> response)
    {
        return b.On(
            ThrowIfErrorResponse(b, response),
            b => b.then<TOut>(
                (SyntaxBuilder b) =>
                {
                    var result = b.On(response, b =>
                    {
                        return b.Call<Promise<TOut>>("json");
                    });

                    return result;
                }));
    }

    public static Var<HyperType.Effect> GetEffect(
        this ISyntaxBuilder b,
        Var<string> fromUrl,
        Var<System.Action<HyperType.Dispatcher>> onResult,
        Var<System.Action<HyperType.Dispatcher, Error>> onError)
    {
        return b.MakeEffect(
            (b, dispatch) =>
            {
                b.On(
                    b.Fetch(fromUrl),
                    b =>
                    {
                        return b
                        .then(ThrowIfErrorResponse)
                        .then((SyntaxBuilder b) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onResult, dispatch));
                        })
                        .@catch((SyntaxBuilder b, Var<Error> error) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onError, dispatch, error));
                        });
                    });
            });
    }

    public static Var<HyperType.Effect> GetJsonEffect<TOut>(
        this ISyntaxBuilder b,
        Var<string> fromUrl,
        Var<System.Action<HyperType.Dispatcher, TOut>> onResult,
        Var<System.Action<HyperType.Dispatcher, Error>> onError)
    {
        return b.MakeEffect(
            (b, dispatch) =>
            {
                b.On(
                    b.Fetch(fromUrl),
                    b =>
                    {
                        return b
                        .then(TryGetJson<TOut>)
                        .then((SyntaxBuilder b, Var<TOut> result) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onResult, dispatch, result));
                        })
                        .@catch((SyntaxBuilder b, Var<Error> error) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onError, dispatch, error));
                        });
                    });
            });
    }

    public static Var<HyperType.Effect> GetJsonEffect<TOut>(
        this ISyntaxBuilder b,
        Var<string> fromUrl,
        System.Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<TOut>> onResult,
        System.Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Error>> onError)
    {
        return b.GetJsonEffect<TOut>(fromUrl, b.Def(onResult), b.Def(onError));
    }

    /// <summary>
    /// Gets json object from url. Dispatches success or error action on result
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="fromUrl"></param>
    /// <param name="successAction"></param>
    /// <param name="errorAction"></param>
    /// <returns></returns>
    public static Var<HyperType.Effect> GetJsonEffect<TModel, TOut>(
        this ISyntaxBuilder b,
        Var<string> fromUrl,
        Var<HyperType.Action<TModel, TOut>> successAction,
        Var<HyperType.Action<TModel, Error>> errorAction)
    {
        return b.GetJsonEffect(
            fromUrl,
            (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<TOut> result) => b.Dispatch(dispatch, successAction, result),
            (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<Error> error) => b.Dispatch(dispatch, errorAction, error));
    }

    public static Var<HyperType.Effect> PostEffect(
        this ISyntaxBuilder b,
        Var<string> toUrl,
        Var<System.Action<HyperType.Dispatcher>> onResult,
        Var<System.Action<HyperType.Dispatcher, Error>> onError)
    {
        return b.MakeEffect(
            (b, dispatch) =>
            {
                b.On(
                    b.Fetch(toUrl,
                    b =>
                    {
                        b.SetMethodPost();
                    }),
                    b =>
                    {
                        return b
                        .then(ThrowIfErrorResponse)
                        .then((SyntaxBuilder b) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onResult, dispatch));
                        })
                        .@catch((SyntaxBuilder b, Var<Error> error) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onError, dispatch, error));
                        });
                    });
            });
    }

    public static Var<HyperType.Effect> PostEffect(
        this ISyntaxBuilder b,
        Var<string> toUrl,
        System.Action<SyntaxBuilder, Var<HyperType.Dispatcher>> onResult,
        System.Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Error>> onError)
    {
        return PostEffect(b, toUrl, b.Def(onResult), b.Def(onError));
    }

    public static Var<HyperType.Effect> PostJsonEffect<TIn>(
        this SyntaxBuilder b,
        Var<string> toUrl,
        Var<TIn> input,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>> onResult,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Error>> onError)
    {
        return b.MakeEffect(
            (b, dispatch) =>
            {
                b.On(
                    b.Fetch(toUrl,
                    b =>
                    {
                        b.SetMethodPost();
                        b.SetJsonBody(input);
                    }),
                    b =>
                    {
                        return b
                        .then(ThrowIfErrorResponse)
                        .then((SyntaxBuilder b) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onResult, dispatch));
                        })
                        .@catch((SyntaxBuilder b, Var<Error> error) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onError, dispatch, error));
                        });
                    });
            });
    }

    public static Var<HyperType.Effect> PostJsonEffect<TIn, TOut>(
        this SyntaxBuilder b,
        Var<string> toUrl,
        Var<TIn> input,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<TOut>> onResult,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Error>> onError)
    {
        return b.MakeEffect(
            (b, dispatch) =>
            {
                b.On(
                    b.Fetch(toUrl,
                    b =>
                    {
                        b.SetMethodPost();
                        b.SetJsonBody(input);
                    }),
                    b =>
                    {
                        return b
                        .then(TryGetJson<TOut>)
                        .then(b.Def((SyntaxBuilder b, Var<TOut> result) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onResult, dispatch, result));
                        }))
                        .@catch(b.Def((SyntaxBuilder b, Var<Error> error) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onError, dispatch, error));
                        }));
                    });
            });
    }

    public static Var<HyperType.Effect> PostJsonEffect<TOut>(
        this SyntaxBuilder b,
        Var<string> toUrl,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<TOut>> onResult,
        Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<Error>> onError)
    {
        return b.MakeEffect(
            (b, dispatch) =>
            {
                b.On(
                    b.Fetch(toUrl,
                    b =>
                    {
                        b.SetMethodPost();
                    }),
                    b =>
                    {
                        return b
                        .then(TryGetJson<TOut>)
                        .then(b.Def((SyntaxBuilder b, Var<TOut> result) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onResult, dispatch, result));
                        }))
                        .@catch(b.Def((SyntaxBuilder b, Var<Error> error) =>
                        {
                            b.RequestAnimationFrame(b => b.Call(onError, dispatch, error));
                        }));
                    });
            });
    }

    /// <summary>
    /// Posts to url with no request body, expects no content in response body. Dispatches success or error action on result
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="toUrl"></param>
    /// <param name="successAction"></param>
    /// <param name="errorAction"></param>
    /// <returns></returns>
    public static Var<HyperType.Effect> PostEffect<TModel>(
        this SyntaxBuilder b,
        Var<string> toUrl,
        Var<HyperType.Action<TModel>> successAction,
        Var<HyperType.Action<TModel, Error>> errorAction)
    {
        return b.PostEffect(
            toUrl,
            (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch) => b.Dispatch(dispatch, successAction),
            (SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<Error> error) => b.Dispatch(dispatch, errorAction, error));
    }

    /// <summary>
    /// Posts to url with no request body, expects TOut as json in response body. Dispatches success or error action on result
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="toUrl"></param>
    /// <param name="successAction"></param>
    /// <param name="errorAction"></param>
    /// <returns></returns>
    public static Var<HyperType.Effect> PostJsonEffect<TModel, TOut>(
        this SyntaxBuilder b,
        Var<string> toUrl,
        Var<HyperType.Action<TModel, TOut>> successAction,
        Var<HyperType.Action<TModel, Error>> errorAction)
    {
        return PostJsonEffect<TOut>(
            b,
            toUrl,
            (b, dispatch, result) => b.Dispatch(dispatch, successAction, result),
            (b, dispatch, error) => b.Dispatch(dispatch, errorAction, error));
    }

    /// <summary>
    /// Posts 'input' object to url as json. Dispatches success or error action on result
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TIn"></typeparam>
    /// <param name="b"></param>
    /// <param name="toUrl"></param>
    /// <param name="input"></param>
    /// <param name="successAction"></param>
    /// <param name="errorAction"></param>
    /// <returns></returns>
    public static Var<HyperType.Effect> PostJsonEffect<TModel, TIn>(
        this SyntaxBuilder b,
        Var<string> toUrl,
        Var<TIn> input,
        Var<HyperType.Action<TModel>> successAction,
        Var<HyperType.Action<TModel, Error>> errorAction)
    {
        return PostJsonEffect(
            b,
            toUrl,
            input,
            (b, dispatch) => b.Dispatch(dispatch, successAction),
            (b, dispatch, error) => b.Dispatch(dispatch, errorAction, error));
    }

    /// <summary>
    /// Posts 'input' object to url as json. Dispatches success or error action on result
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TIn"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="toUrl"></param>
    /// <param name="input"></param>
    /// <param name="successAction"></param>
    /// <param name="errorAction"></param>
    /// <returns></returns>
    public static Var<HyperType.Effect> PostJsonEffect<TModel, TIn, TOut>(
        this SyntaxBuilder b,
        Var<string> toUrl,
        Var<TIn> input,
        Var<HyperType.Action<TModel, TOut>> successAction,
        Var<HyperType.Action<TModel, Error>> errorAction)
    {
        return PostJsonEffect<TIn, TOut>(
            b,
            toUrl,
            input,
            (b, dispatch, result) => b.Dispatch(dispatch, successAction, result),
            (b, dispatch, error) => b.Dispatch(dispatch, errorAction, error));
    }
}
