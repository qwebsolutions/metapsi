using Metapsi;
using Metapsi.Syntax;
using Metapsi.Ui;
using System;

namespace Metapsi.Hyperapp
{
    public interface IApiSupportState
    {
        ApiSupport ApiSupport { get; set; }
    }

    public class ApiSupport
    {
        public string ErrorMessage { get; set; }
        public bool InProgress { get; set; }
    }

    public class ApiSupportModel : IApiSupportState
    {
        public ApiSupport ApiSupport { get; set; } = new();
    }

    public static class ApiSupportExtensions
    {
        public static Action<SyntaxBuilder, Var<HyperType.Dispatcher<TState>>> Request<TState, TResult, P1>(
            this SyntaxBuilder b,
            Request<TResult, P1> request,
            Var<P1> p1,
            Var<HyperType.Action<TState, TResult>> onResult)
            where TState : IApiSupportState
            where TResult : IApiResponse
        {
            return b.CallApi<TState, TResult, P1>(
                request,
                p1,
                b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<TResult> result) =>
                {
                    // We can hide the panel even if it was not shown in the first place
                    state = b.HidePanel(state);

                    // Explicit API error
                    return b.If(
                        b.Get(result, x => x.ResultCode == "Error"),
                        b =>
                        {
                            var apiSupport = b.Get(state, x => x.ApiSupport);
                            b.Set(apiSupport, x => x.ErrorMessage, b.Const("It seems there was an error. Try again, please"));
                            b.Log(b.Get(result, x => x.ErrorMessage));

                            return b.MakeActionDescriptor(
                                b.MakeAction(
                                    (SyntaxBuilder b, Var<TState> state, Var<TResult> result) => b.Clone(state)), result);
                        },
                        b => b.MakeActionDescriptor(onResult, result));
                }),
                b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<ApiError> error) =>
                {
                    // Server/Network error
                    var apiSupport = b.Get(state, x => x.ApiSupport);
                    b.Set(apiSupport, x => x.ErrorMessage, b.Const("It seems there was an error. Try again, please"));
                    b.Log(error);
                    return b.HidePanel(state);
                }));
        }

        public static Action<SyntaxBuilder, Var<HyperType.Dispatcher<TState>>> Request<TState, TResult>(
                    this SyntaxBuilder b,
                    Request<TResult> request,
                    Var<HyperType.Action<TState, TResult>> onResult)
                    where TState : IApiSupportState
                    where TResult : IApiResponse
        {
            return b.CallApi<TState, TResult>(
                request,
                b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<TResult> result) =>
                {
                    // We can hide the panel even if it was not shown in the first place
                    state = b.HidePanel(state);

                    // Explicit API error
                    return b.If(
                        b.Get(result, x => x.ResultCode == "Error"),
                        b =>
                        {
                            var apiSupport = b.Get(state, x => x.ApiSupport);
                            b.Set(apiSupport, x => x.ErrorMessage, b.Const("It seems there was an error. Try again, please"));
                            b.Log(b.Get(result, x => x.ErrorMessage));

                            return b.MakeActionDescriptor(
                                b.MakeAction(
                                    (SyntaxBuilder b, Var<TState> state, Var<TResult> result) => b.Clone(state)), result);
                        },
                        b => b.MakeActionDescriptor(onResult, result));
                }),
                b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<ApiError> error) =>
                {
                    // Server/Network error
                    var apiSupport = b.Get(state, x => x.ApiSupport);
                    b.Set(apiSupport, x => x.ErrorMessage, b.Const("It seems there was an error. Try again, please"));
                    b.Log(error);
                    return b.HidePanel(state);
                }));
        }

        public static Var<TState> ShowPanel<TState>(this SyntaxBuilder b, Var<TState> page)
            where TState: IApiSupportState
        {
            var apiSupport = b.Get(page, x => x.ApiSupport);
            b.Set(apiSupport, x => x.InProgress, b.Const(true));
            return b.Clone(page);
        }

        public static Var<TState> HidePanel<TState>(this SyntaxBuilder b, Var<TState> page)
            where TState : IApiSupportState
        {
            var apiSupport = b.Get(page, x => x.ApiSupport);
            b.Set(apiSupport, x => x.InProgress, b.Const(false));
            return b.Clone(page);
        }

        public static Var<HyperNode> WaitPanel<TState>(this LayoutBuilder b, Var<TState> page)
            where TState : IApiSupportState
        {
            return b.Optional(
                b.Get(page, x => x.ApiSupport.InProgress),
                b => b.Div("bg-black opacity-50 fixed inset-0 z-40 items-center"));
        }

        public static Var<bool> IsErrorResult<TResult>(this SyntaxBuilder b, Var<TResult> response)
            where TResult : IApiResponse
        {
            return b.Get(response, x => x.ResultCode == "Error");
        }

        public static Var<bool> IsOkResult<TResult>(this SyntaxBuilder b, Var<TResult> response)
            where TResult : IApiResponse
        {
            return b.Get(response, x => x.ResultCode == "Ok");
        }
    }
}