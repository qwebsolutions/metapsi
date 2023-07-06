using Metapsi;
using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    public interface IApiSupportState
    {
        ApiSupport ApiSupport { get; set; }
    }

    public interface IApiResponse
    {
        public string ResultCode { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ApiResponse : IApiResponse
    {
        public string ResultCode { get; set; } = ApiResultCode.Ok;
        public string ErrorMessage { get; set; }
    }

    public class ApiResultCode
    {
        public const string Error = "Error";
        public const string Ok = "Ok";
    }

    public class ApiSupport
    {
        public string ErrorMessage { get; set; }
        public bool InProgress { get; set; }
    }

    public static class ApiSupportExtensions
    {
        public static Action<BlockBuilder, Var<HyperType.Dispatcher<TState>>> Request<TState, TResult, P1>(
            this BlockBuilder b,
            Request<TResult, P1> request,
            Var<P1> p1,
            Var<HyperType.Action<TState, TResult>> onResult)
            where TState : IApiSupportState
            where TResult : IApiResponse
        {
            return b.CallApi<TState, TResult, P1>(
                request,
                p1,
                b.MakeAction((BlockBuilder b, Var<TState> state, Var<TResult> result) =>
                {
                    // We can hide the panel even if it was not shown in the first place
                    state = b.HidePanel(state);

                    // Explicit API error
                    return b.If<HyperType.ActionDescriptor<TState, TResult>>(
                        b.Get(result, x => x.ResultCode == "Error"),
                        b =>
                        {
                            var apiSupport = b.Get(state, x => x.ApiSupport);
                            b.Set(apiSupport, x => x.ErrorMessage, b.Const("It seems there was an error. Try again, please"));
                            b.Log(b.Get(result, x => x.ErrorMessage));

                            return b.MakeActionDescriptor(
                                b.MakeAction(
                                    (BlockBuilder b, Var<TState> state, Var<TResult> result) => b.Clone(state)), result);
                        },
                        b => b.MakeActionDescriptor(onResult, result));
                }),
                b.MakeAction((BlockBuilder b, Var<TState> state, Var<ApiError> error) =>
                {
                    // Server/Network error
                    var apiSupport = b.Get(state, x => x.ApiSupport);
                    b.Set(apiSupport, x => x.ErrorMessage, b.Const("It seems there was an error. Try again, please"));
                    b.Log(error);
                    return b.HidePanel(state);
                }));
        }

        public static Action<BlockBuilder, Var<HyperType.Dispatcher<TState>>> Request<TState, TResult>(
                    this BlockBuilder b,
                    Request<TResult> request,
                    Var<HyperType.Action<TState, TResult>> onResult)
                    where TState : IApiSupportState
                    where TResult : IApiResponse
        {
            return b.CallApi<TState, TResult>(
                request,
                b.MakeAction((BlockBuilder b, Var<TState> state, Var<TResult> result) =>
                {
                    // We can hide the panel even if it was not shown in the first place
                    state = b.HidePanel(state);

                    // Explicit API error
                    return b.If<HyperType.ActionDescriptor<TState, TResult>>(
                        b.Get(result, x => x.ResultCode == "Error"),
                        b =>
                        {
                            var apiSupport = b.Get(state, x => x.ApiSupport);
                            b.Set(apiSupport, x => x.ErrorMessage, b.Const("It seems there was an error. Try again, please"));
                            b.Log(b.Get(result, x => x.ErrorMessage));

                            return b.MakeActionDescriptor(
                                b.MakeAction(
                                    (BlockBuilder b, Var<TState> state, Var<TResult> result) => b.Clone(state)), result);
                        },
                        b => b.MakeActionDescriptor(onResult, result));
                }),
                b.MakeAction((BlockBuilder b, Var<TState> state, Var<ApiError> error) =>
                {
                    // Server/Network error
                    var apiSupport = b.Get(state, x => x.ApiSupport);
                    b.Set(apiSupport, x => x.ErrorMessage, b.Const("It seems there was an error. Try again, please"));
                    b.Log(error);
                    return b.HidePanel(state);
                }));
        }

        public static Var<TState> ShowPanel<TState>(this BlockBuilder b, Var<TState> page)
            where TState: IApiSupportState
        {
            var apiSupport = b.Get(page, x => x.ApiSupport);
            b.Set(apiSupport, x => x.InProgress, b.Const(true));
            return b.Clone(page);
        }

        public static Var<TState> HidePanel<TState>(this BlockBuilder b, Var<TState> page)
            where TState : IApiSupportState
        {
            var apiSupport = b.Get(page, x => x.ApiSupport);
            b.Set(apiSupport, x => x.InProgress, b.Const(false));
            return b.Clone(page);
        }

        public static Var<HyperNode> WaitPanel<TState>(this BlockBuilder b, Var<TState> page)
            where TState : IApiSupportState
        {
            return b.Optional(
                b.Get(page, x => x.ApiSupport.InProgress),
                b => b.Div("bg-black opacity-50 fixed inset-0 z-40 items-center"));
        }

        //public static Var<HyperNode> ErrorPanel<TState>(this BlockBuilder b, Var<TState> page)
        //    where TState : IApiSupportState
        //{
        //    return b.Optional(
        //        b.HasValue(b.Get(page, x => x.ApiSupport.ErrorMessage)),
        //        b => b.Popup(
        //            b.Div("bg-white p-24 text-red-500 font-semibold", b => b.Text(b.Get(page, x => x.ApiSupport.ErrorMessage))),
        //            b.MakeAction((BlockBuilder b, Var<TState> page) =>
        //            {
        //                var apiSupport = b.Get(page, x => x.ApiSupport);
        //                b.Set(apiSupport, x => x.ErrorMessage, b.Const(string.Empty));
        //                return b.Clone(page);
        //            })));
        //}

        public static Var<bool> IsErrorResult<TResult>(this BlockBuilder b, Var<TResult> response)
            where TResult : IApiResponse
        {
            return b.Get(response, x => x.ResultCode == "Error");
        }

        public static Var<bool> IsOkResult<TResult>(this BlockBuilder b, Var<TResult> response)
            where TResult : IApiResponse
        {
            return b.Get(response, x => x.ResultCode == "Ok");
        }
    }
}