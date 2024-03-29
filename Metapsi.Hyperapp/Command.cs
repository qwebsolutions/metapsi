﻿using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi.Hyperapp
{
    //    public class Command
    //    {
    //        // state, payload -> new state
    //        public Func<object, object, object> InitialUpdate { get; set; }

    //        // state, payload, Action<newData>
    //        public Action<object, object, Action<object>> GetData { get; set; }

    //        // state, newData -> new state
    //        public Func<object, object, object> FinalUpdate { get; set; }
    //    }

    public static class CommandExtensions
    {
        // Request 0 parameters

        public static void FetchRequest<TResult>(
            this SyntaxBuilder b,
            Request<TResult> request,
            Var<System.Action<TResult>> onResult, Var<System.Action<ApiError>> onError)
        {
            var url = b.Const($"/api/{request.Name}/");
            b.CallExternal("fetch", "getRequest", url, onResult, onError);
        }

        public static System.Action<SyntaxBuilder, Var<HyperType.Dispatcher<TState>>> CallApi<TState, TResult>(
            this SyntaxBuilder b,
            Request<TResult> request,
            System.Func<SyntaxBuilder, Var<TState>, Var<TResult>, Var<TState>> onResult,
            System.Func<SyntaxBuilder, Var<TState>, Var<ApiError>, Var<TState>> onError)
        {
            return (SyntaxBuilder b, Var<HyperType.Dispatcher<TState>> dispatcher) =>
            {
                b.FetchRequest(
                    request,
                    b.Def((SyntaxBuilder b, Var<TResult> result) => b.Dispatch(dispatcher, b.MakeAction((SyntaxBuilder b, Var<TState> state) => b.Call(onResult, state, result)))),
                    b.Def((SyntaxBuilder b, Var<ApiError> error) => b.Dispatch(dispatcher, b.MakeAction((SyntaxBuilder b, Var<TState> state) => b.Call(onError, state, error)))));
            };
        }

        public static System.Action<SyntaxBuilder, Var<HyperType.Dispatcher<TState>>> CallApi<TState, TResult>(
            this SyntaxBuilder b,
            Request<TResult> request,
            Var<HyperType.Action<TState, TResult>> onResult,
            Var<HyperType.Action<TState, ApiError>> onError)
        {
            return (SyntaxBuilder b, Var<HyperType.Dispatcher<TState>> dispatcher) =>
            {
                b.FetchRequest(
                    request,
                    b.Def((SyntaxBuilder b, Var<TResult> result) => b.Dispatch(dispatcher, b.MakeActionDescriptor(onResult, result))),
                    b.Def((SyntaxBuilder b, Var<ApiError> error) => b.Dispatch(dispatcher, b.MakeActionDescriptor(onError, error))));
            };
        }

        // Command 1 param

        public static void FetchCommand<T1>(this SyntaxBuilder b, Command<T1> command, Var<T1> p1, Var<System.Action> onResult, Var<System.Action<ApiError>> onError)
        {
            if (Api.AreScalarTypes(typeof(T1)))
            {
                var url = b.Concat(b.Const($"/api/{command.Name}/"), p1.As<string>());
                b.CallExternal("fetch", "getCommand", url, onResult, onError);
            }
            else
            {
                var payload = b.NewObj<Api.PostBody<T1>>();
                b.Set(payload, x => x.P1, p1);
                b.CallExternal("fetch", "postCommand", b.Const($"/api/{command.Name}"), payload, onResult, onError);
            }
        }

        public static System.Action<SyntaxBuilder, Var<HyperType.Dispatcher<TState>>> CallApi<TState, T1>(
                    this SyntaxBuilder b,
                    Command<T1> command,
                    Var<T1> p1,
                    System.Func<SyntaxBuilder, Var<TState>, Var<TState>> onResult,
                    System.Func<SyntaxBuilder, Var<TState>, Var<ApiError>, Var<TState>> onError)
        {
            return (SyntaxBuilder b, Var<HyperType.Dispatcher<TState>> dispatcher) =>
            {
                b.FetchCommand(
                    command,
                    p1,
                    b.Def((SyntaxBuilder b) => b.Dispatch<TState>(dispatcher, b.MakeAction((SyntaxBuilder b, Var<TState> state) => b.Call(onResult, state)))),
                    b.Def((SyntaxBuilder b, Var<ApiError> error) => b.Dispatch<TState>(dispatcher, b.MakeAction((SyntaxBuilder b, Var<TState> state) => b.Call(onError, state, error)))));
            };
        }

        // Request 1 param

        public static void FetchRequest<TResult, T1>(
            this SyntaxBuilder b,
            Request<TResult, T1> request,
            Var<T1> p1,
            Var<System.Action<TResult>> onResult, Var<System.Action<ApiError>> onError)
        {
            if (Api.AreScalarTypes(typeof(T1)))
            {
                var url = b.Concat(b.Const($"/api/{request.Name}/"), p1.As<string>());
                b.CallExternal("fetch", "getRequest", url, onResult, onError);
            }
            else
            {
                var payload = b.NewObj<Api.PostBody<T1>>();
                b.Set(payload, x => x.P1, p1);
                b.CallExternal("fetch", "postRequest", b.Const($"/api/{request.Name}"), payload, onResult, onError);
            }
        }

        public static System.Action<SyntaxBuilder, Var<HyperType.Dispatcher<TState>>> CallApi<TState, TResult, T1>(
            this SyntaxBuilder b,
            Request<TResult, T1> request,
            Var<T1> p1,
            System.Func<SyntaxBuilder, Var<TState>, Var<TResult>, Var<TState>> onResult,
            System.Func<SyntaxBuilder, Var<TState>, Var<ApiError>, Var<TState>> onError)
        {
            return (SyntaxBuilder b, Var<HyperType.Dispatcher<TState>> dispatcher) =>
            {
                b.FetchRequest(
                    request,
                    p1,
                    b.Def((SyntaxBuilder b, Var<TResult> result) => b.Dispatch(dispatcher, b.MakeAction((SyntaxBuilder b, Var<TState> state) => b.Call(onResult, state, result)))),
                    b.Def((SyntaxBuilder b, Var<ApiError> error) => b.Dispatch(dispatcher, b.MakeAction((SyntaxBuilder b, Var<TState> state) => b.Call(onError, state, error)))));
            };
        }

        public static System.Action<SyntaxBuilder, Var<HyperType.Dispatcher<TState>>> CallApi<TState, TResult, T1>(
            this SyntaxBuilder b,
            Request<TResult, T1> request,
            Var<T1> p1,
            Var<HyperType.Action<TState, TResult>> onResult,
            Var<HyperType.Action<TState, ApiError>> onError)
        {
            return (SyntaxBuilder b, Var<HyperType.Dispatcher<TState>> dispatcher) =>
            {
                b.FetchRequest(
                    request,
                    p1,
                    b.Def((SyntaxBuilder b, Var<TResult> result) => b.Dispatch(dispatcher, b.MakeActionDescriptor(onResult, result))),
                    b.Def((SyntaxBuilder b, Var<ApiError> error) => b.Dispatch(dispatcher, b.MakeActionDescriptor(onError, error))));
            };
        }
    }
}
