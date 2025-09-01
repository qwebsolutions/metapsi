using Metapsi.Html;
using Metapsi.Syntax;

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
    public static Var<HyperType.Action<TState, Html.Error>> AlertOnException<TState>(this SyntaxBuilder b)
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
    public static Var<Promise> ThrowIfErrorResponse(this SyntaxBuilder b, Var<Metapsi.Html.Response> response)
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
                                return b.PromiseThen(b.ResponseJson(response), (SyntaxBuilder b, Var<object> problem) =>
                                {
                                    var detail = b.GetProperty<string>(problem, "detail");
                                    b.If(
                                        b.HasValue(detail),
                                        b =>
                                        {
                                            b.Throw(detail);
                                        },
                                        b =>
                                        {
                                            var title = b.GetProperty<string>(problem, "title");
                                            b.Throw(title);
                                        });
                                });
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
                return response.As<Promise>();
            });
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
        this SyntaxBuilder b,
        Var<string> fromUrl,
        Var<HyperType.Action<TModel, TOut>> successAction,
        Var<HyperType.Action<TModel, Error>> errorAction)
    {
        return b.MakeEffect(
            (b, dispatch) =>
            {
                var fetchPromise = b.Fetch(fromUrl);
                var httpResponsePromise = b.PromiseThen(
                    fetchPromise,
                    (SyntaxBuilder b, Var<Html.Response> response) =>
                    {
                        return b.PromiseThen(
                            b.ThrowIfErrorResponse(response),
                            (SyntaxBuilder b, Var<Html.Response> response) => b.ResponseJson(response));
                    });

                var handleActionPromise = b.PromiseThen(httpResponsePromise, (SyntaxBuilder b, Var<TOut> response) =>
                {
                    b.RequestAnimationFrame(b => b.Dispatch(dispatch, successAction, response));
                });

                b.PromiseCatch(handleActionPromise, (SyntaxBuilder b, Var<Error> error) =>
                {
                    b.RequestAnimationFrame(b => b.Dispatch(dispatch, errorAction, error));
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
    public static Var<HyperType.Effect> PostJsonEffect<TModel>(
        this SyntaxBuilder b,
        Var<string> toUrl,
        Var<HyperType.Action<TModel>> successAction,
        Var<HyperType.Action<TModel, Error>> errorAction)
    {
        return b.MakeEffect(
            (b, dispatch) =>
            {
                var fetchPromise = b.Fetch(
                    toUrl,
                    b =>
                    {
                        b.SetMethodPost();
                    });
                var responsePromise = b.PromiseThen(
                    fetchPromise,
                    (SyntaxBuilder b, Var<Response> response) =>
                    {
                        return b.PromiseThen(
                            b.ThrowIfErrorResponse(response),
                            (SyntaxBuilder b, Var<object> _) => b.RequestAnimationFrame(b => b.Dispatch(dispatch, successAction)));
                    });
                b.PromiseCatch(responsePromise, (SyntaxBuilder b, Var<Error> error) =>
                {
                    b.RequestAnimationFrame(b => b.Dispatch(dispatch, errorAction, error));
                });
            });
    }

    /// <summary>
    /// Posts to url with no request body, expects TOut as json in reponse body. Dispatches success or error action on result
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
        return b.MakeEffect(
            (b, dispatch) =>
            {
                var fetchPromise = b.Fetch(
                    toUrl,
                    b =>
                    {
                        b.SetMethodPost();
                    });

                var jsonPromise = b.PromiseThen(fetchPromise, (SyntaxBuilder b, Var<Response> response) =>
                {
                    return b.PromiseThen(
                        b.ThrowIfErrorResponse(response),
                        (SyntaxBuilder b, Var<Response> response) => b.ResponseJson(response));
                });

                var handleActionPromise = b.PromiseThen(jsonPromise, (SyntaxBuilder b, Var<TOut> response) =>
                {
                    b.RequestAnimationFrame(b => b.Dispatch(dispatch, successAction, response));
                });

                b.PromiseCatch(jsonPromise, (SyntaxBuilder b, Var<Error> error) =>
                {
                    b.RequestAnimationFrame(b => b.Dispatch(dispatch, errorAction, error));
                });
            });
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
        return b.MakeEffect(
            (b, dispatch) =>
            {
                var fetchPromise = b.Fetch(
                    toUrl,
                    b =>
                    {
                        b.SetMethodPost();
                        b.SetJsonBody(input);
                    });
                var responsePromise = b.PromiseThen(
                    fetchPromise,
                    (SyntaxBuilder b, Var<Response> response) =>
                    {
                        return b.PromiseThen(
                            b.ThrowIfErrorResponse(response),
                            (SyntaxBuilder b, Var<object> _) =>
                            {
                                b.RequestAnimationFrame(b => b.Dispatch(dispatch, successAction));
                            });
                    });
                b.PromiseCatch(responsePromise, (SyntaxBuilder b, Var<Error> error) =>
                {
                    b.RequestAnimationFrame(b => b.Dispatch(dispatch, errorAction, error));
                });
            });
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
        return b.MakeEffect(
            (b, dispatch) =>
            {
                var fetchPromise = b.Fetch(
                    toUrl,
                    b =>
                    {
                        b.SetMethodPost();
                        b.SetJsonBody(input);
                    });

                var jsonPromise = b.PromiseThen(fetchPromise, (SyntaxBuilder b, Var<Response> response) =>
                {
                    return b.PromiseThen(
                        b.ThrowIfErrorResponse(response),
                        (SyntaxBuilder b, Var<Response> response) => b.ResponseJson(response));
                });

                var handleActionPromise = b.PromiseThen(jsonPromise, (SyntaxBuilder b, Var<TOut> response) =>
                {
                    b.RequestAnimationFrame(b => b.Dispatch(dispatch, successAction, response));
                });

                b.PromiseCatch(jsonPromise, (SyntaxBuilder b, Var<Error> error) =>
                {
                    b.RequestAnimationFrame(b => b.Dispatch(dispatch, errorAction, error));
                });
            });
    }
}
