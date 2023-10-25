using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public class CallApiInput<TState, TPayload, TResult>
    {
        public string Url { get; set; }
        public TPayload DataPayload { get; set; }
        public HyperType.Action<TState, TResult> OnResult { get; set; }
        public HyperType.Action<TState, ApiError> OnError { get; set; }
    }

    public static class CallApiExtensions
    {
        public static Var<CallApiInput<TState, TPayload, TResult>> MakeCallApiEffecterPayload<TState, TPayload, TResult>(
                   this SyntaxBuilder b,
                   Request<TResult, TPayload> request,
                   Var<TPayload> payload,
                   Var<HyperType.Action<TState, TResult>> onResult,
                   Var<HyperType.Action<TState, ApiError>> onError)
        {
            var callApiEffecterInput = b.NewObj<CallApiInput<TState, TPayload, TResult>>();

            if (Api.AreScalarTypes(typeof(TPayload)))
            {
                b.Set(callApiEffecterInput, x => x.Url, b.Concat(b.Const($"/api/{request.Name}/"), payload.As<string>()));
            }
            else
            {
                b.Set(callApiEffecterInput, x => x.Url, b.Const($"/api/{request.Name}"));
                b.Set(callApiEffecterInput, x => x.DataPayload, payload);
            }
            b.Set(callApiEffecterInput, x => x.OnResult, onResult);
            b.Set(callApiEffecterInput, x => x.OnError, onError);

            return callApiEffecterInput;
        }

        public static void CallApiEffecter<TState, TData, TResult>(
            SyntaxBuilder b,
            Var<HyperType.Dispatcher<TState>> dispatcher,
            Var<CallApiInput<TState, TData, TResult>> callApiParameters)
        {
            var fetchOptions = b.NewObj<FetchOptions>();

            b.If(
                b.HasObject(
                    b.Get(callApiParameters, x => x.DataPayload)),
                b =>
                {
                    b.SetDynamic(b.Get(fetchOptions, x => x.headers), DynamicProperty.String("Content-Type"), b.Const("application/json"));
                    b.Set(fetchOptions, x => x.method, "POST");
                    var fetchPayload = b.NewObj<Api.PostBody<TData>>();
                    b.Set(fetchPayload, x => x.P1, b.Get(callApiParameters, x => x.DataPayload));
                    b.Set(fetchOptions, x => x.body, b.Serialize(fetchPayload));
                },
                b =>
                {
                    b.Set(fetchOptions, x => x.method, "GET");
                });

            b.Fetch(
                b.Get(callApiParameters, x => x.Url),
                fetchOptions,
                b.Def((SyntaxBuilder b, Var<TResult> result) =>
                {
                    b.Dispatch(dispatcher, b.MakeActionDescriptor(b.Get(callApiParameters, x => x.OnResult), result));
                }),
                b.Def((SyntaxBuilder b, Var<ApiError> error) =>
                {
                    b.Dispatch(dispatcher, b.MakeActionDescriptor(b.Get(callApiParameters, x => x.OnError), error));
                }));
        }
    }
}
