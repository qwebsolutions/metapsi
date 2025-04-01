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
                        b.If(
                            b.Get(response, x => !x.ok),
                            b =>
                            {
                                b.Throw(b.Get(response, x => x.statusText));
                            });
                        return b.ResponseJson(response);
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
                        b.If(
                            b.Get(response, x => !x.ok),
                            b =>
                            {
                                b.Throw(b.Get(response, x => x.statusText));
                            });
                        b.RequestAnimationFrame(b => b.Dispatch(dispatch, successAction));
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
                    b.If(
                        b.Get(response, x => !x.ok),
                        b =>
                        {
                            b.Throw(b.Get(response, x => x.statusText));
                        });
                    return b.ResponseJson(response);
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
