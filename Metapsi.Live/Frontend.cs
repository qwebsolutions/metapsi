using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Live;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;

public static class Frontend
{
    public class SolutionEntitiesResponse : ApiResponse
    {
        public bool IsLoading { get; set; }
        public Metapsi.Live.SolutionEntities SolutionEntities { get; set; } = new();
        public string CurrentlyCompiling { get; set; } = string.Empty;
        public List<string> AlreadyCompiled { get; set; } = new List<string>();
        public int TotalProjects { get; set; } = 0;
    }

    public static Request<ApiResponse, Guid> SelectSolution { get; set; } = new(nameof(SelectSolution));
    public static Request<SolutionEntitiesResponse> GetSolutionEntities { get; set; } = new(nameof(GetSolutionEntities));
    public static Request<Backend.RendererResponse, SymbolKey> SelectRenderer { get; set; } = new(nameof(SelectRenderer));
    public static Request<ApiResponse, Guid> SetInputId { get; set; } = new(nameof(SetInputId));
    public static Request<Backend.RendererResponse, SymbolKey> AddRendererInput { get; set; } = new(nameof(AddRendererInput));


    public class ServerActionInput
    {
        public string SerializedModel { get; set; } = string.Empty;
        public string SerializedPayload { get; set; } = string.Empty;
        public string QualifiedHandlerClass { get; set; } = string.Empty;
        public string HandlerMethod { get; set; } = string.Empty;
    }

    public class ServerActionResponse : ApiResponse
    {
        public string SerializedModel { get; set; } = string.Empty;
    }

    public static Request<ServerActionResponse, ServerActionInput> ServerAction { get; set; } = new(nameof(ServerAction));

    public static void MapFrontend(this RouteGroupBuilder apiEndpoint)
    {
        apiEndpoint.MapRequest(Frontend.SelectSolution, async (CommandContext commandContext, HttpContext httpContext, Guid slnId) =>
        {
            var solutions = await commandContext.Do(Storage.GetSolutions);
            var selectedSolution = solutions.Solutions.Single(x => x.Id == slnId);

            commandContext.PostEvent(new SolutionSelected()
            {
                Solution = selectedSolution
            });

            return new ApiResponse()
            {
                ResultCode = "Ok"
            };
        }, WebServer.Authorization.Public);

        apiEndpoint.MapRequest(Frontend.GetSolutionEntities, async (CommandContext commandContext, HttpContext httpContext) =>
        {
            var solutionEntities = await commandContext.Do(Backend.GetSolutionEntities);
            var compilationStatus = await commandContext.Do(Backend.GetCompilationStatus);

            return new Frontend.SolutionEntitiesResponse()
            {
                IsLoading = compilationStatus.IsCompiling,
                AlreadyCompiled = compilationStatus.AlreadyCompiled,
                CurrentlyCompiling = compilationStatus.CurrentlyCompiling,
                SolutionEntities = solutionEntities,
                TotalProjects = compilationStatus.TotalProjects,
                ResultCode = ApiResultCode.Ok
            };
        },
        WebServer.Authorization.Public);

        apiEndpoint.MapRequest(Frontend.SelectRenderer, async (CommandContext commandContext, HttpContext httpContext, SymbolKey renderer) =>
        {
            await commandContext.Do(Backend.SetFocusedRenderer, renderer);
            return await commandContext.Do(Backend.GetFocusedRenderer);
        },
        WebServer.Authorization.Public);

        apiEndpoint.MapRequest(Frontend.AddRendererInput, async (CommandContext commandContext, HttpContext httpContext, SymbolKey rendererKey) =>
        {
            var emptyModel = await commandContext.Do(Backend.CreateEmptyModel, rendererKey);
            //var emptyModel = await CompileEnvironment.CreateEmptyModel(commandContext, compileEnvironment, rendererName);

            await commandContext.Do(Storage.SaveInput, rendererKey, emptyModel);
            var renderer = await commandContext.Do(Backend.GetFocusedRenderer);

            return renderer;
        },
        WebServer.Authorization.Public);

        apiEndpoint.MapRequest(Frontend.SetInputId, async (CommandContext commandContext, HttpContext httpContext, Guid inputId) =>
        {
            var focusedRenderer = await commandContext.Do(Backend.GetFocusedRenderer);
            var selectedInput = focusedRenderer.Inputs.SingleOrDefault(x => x.Id == inputId);

            await commandContext.Do(Backend.SetCurrentInput, selectedInput);
            return new ApiResponse();
        },
        WebServer.Authorization.Public);

        apiEndpoint.MapRequest(Frontend.ServerAction, async (CommandContext commandContext, HttpContext httpContext, ServerActionInput input) =>
        {
            try
            {
                var handlerClass = Type.GetType(input.QualifiedHandlerClass);
                var method = handlerClass.GetMethod(
                    input.HandlerMethod,
                    System.Reflection.BindingFlags.Public |
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.Instance);

                var methodParameters = method.GetParameters();

                if (!methodParameters.Any())
                    throw new NotSupportedException("Server action must receive the model as parameter");


                var stateParameter = methodParameters.FirstOrDefault(x => x.ParameterType != typeof(CommandContext) && x.ParameterType != typeof(HttpContext));
                if (stateParameter == null)
                {
                    throw new NotSupportedException("Server action must receive the model as parameter");
                }

                var payloadParameter = methodParameters.FirstOrDefault(
                    x => x.ParameterType != typeof(CommandContext)
                    && x.ParameterType != typeof(HttpContext)
                    && x.ParameterType != stateParameter.ParameterType);

                List<object> invokeParameters = new();


                foreach (var parameterInfo in methodParameters)
                {
                    if (parameterInfo.ParameterType == typeof(CommandContext))
                    {
                        invokeParameters.Add(commandContext);
                    }

                    if (parameterInfo.ParameterType == typeof(HttpContext))
                    {
                        invokeParameters.Add(httpContext);
                    }

                    if (parameterInfo == stateParameter)
                    {
                        var stateObject = Metapsi.Serialize.FromJson(parameterInfo.ParameterType, input.SerializedModel);
                        invokeParameters.Add(stateObject);
                    }

                    if (parameterInfo == payloadParameter)
                    {
                        var payloadObject = Metapsi.Serialize.FromJson(parameterInfo.ParameterType, input.SerializedPayload);
                        invokeParameters.Add(payloadObject);
                    }
                }

                object result;

                if (method.IsStatic)
                {
                    result = method.Invoke(null, invokeParameters.ToArray());
                }
                else
                {
                    var invokeInstance = Activator.CreateInstance(handlerClass);
                    result = method.Invoke(invokeInstance, invokeParameters.ToArray());
                }

                var isAsync = method.ReturnType.Namespace == "System.Threading.Tasks";

                if (isAsync)
                    result = await (dynamic)result;

                var serializedResult = Metapsi.Serialize.ToJson(result);

                return new Frontend.ServerActionResponse()
                {
                    SerializedModel = serializedResult
                };
            }
            catch (Exception ex)
            {
                return new Frontend.ServerActionResponse()
                {
                    ResultCode = ApiResultCode.Error,
                    ErrorMessage = ex.Message
                };
            }
        },
        WebServer.Authorization.Public);
    }
}
