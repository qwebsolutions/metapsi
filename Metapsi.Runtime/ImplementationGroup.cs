using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi
{
    public class ImplementationGroup
    {
        internal ApplicationSetup ApplicationSetup { get; set; }
        // Request name
        internal Dictionary<string, ExternalOperationMapping> Implementations { get; set; } = new Dictionary<string, ExternalOperationMapping>();

        public ExternalOperationMapping MapCommand(
            Command command, Func<CommandRoutingContext, Task> implementation)
        {
            return MapInternal(command, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapCommand<TParam1>(
            Command<TParam1> command, Func<CommandRoutingContext, TParam1, Task> implementation)
        {
            return MapInternal(command, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapCommand<TParam1, TParam2>(
            Command<TParam1, TParam2> command, Func<CommandRoutingContext, TParam1, TParam2, Task> implementation)
        {
            return MapInternal(command, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapCommand<TParam1, TParam2, TParam3>(
            Command<TParam1, TParam2, TParam3> command, Func<CommandRoutingContext, TParam1, TParam2, TParam3, Task> implementation)
        {
            return MapInternal(command, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapCommand<TParam1, TParam2, TParam3, TParam4>(
            Command<TParam1, TParam2, TParam3, TParam4> command, Func<CommandRoutingContext, TParam1, TParam2, TParam3, TParam4, Task> implementation)
        {
            return MapInternal(command, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapCommand<TParam1, TParam2, TParam3, TParam4, TParam5>(
            Command<TParam1, TParam2, TParam3, TParam4, TParam5> command, Func<CommandRoutingContext, TParam1, TParam2, TParam3, TParam4, TParam5, Task> implementation)
        {
            return MapInternal(command, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapCommand<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>(
            Command<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> command, Func<CommandRoutingContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, Task> implementation)
        {
            return MapInternal(command, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapCommand<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>(
            Command<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7> command, Func<CommandRoutingContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, Task> implementation)
        {
            return MapInternal(command, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapRequest<TResult>(
            Request<TResult> request, Func<RequestRoutingContext, Task<TResult>> implementation)
        {
            return MapInternal(request, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapRequest<TResult, TParam1>(
            Request<TResult, TParam1> request, Func<RequestRoutingContext, TParam1, Task<TResult>> implementation)
        {
            return MapInternal(request, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapRequest<TResult, TParam1, TParam2>(
            Request<TResult, TParam1, TParam2> request, Func<RequestRoutingContext, TParam1, TParam2, Task<TResult>> implementation)
        {
            return MapInternal(request, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapRequest<TResult, TParam1, TParam2, TParam3>(
            Request<TResult, TParam1, TParam2, TParam3> request, Func<RequestRoutingContext, TParam1, TParam2, TParam3, Task<TResult>> implementation)
        {
            return MapInternal(request, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapRequest<TResult, TParam1, TParam2, TParam3, TParam4>(
            Request<TResult, TParam1, TParam2, TParam3, TParam4> request, Func<RequestRoutingContext, TParam1, TParam2, TParam3, TParam4, Task<TResult>> implementation)
        {
            return MapInternal(request, implementation.Method, implementation.Target);
        }

        public ExternalOperationMapping MapRequest<TResult, TParam1, TParam2, TParam3, TParam4, TParam5>(
            Request<TResult, TParam1, TParam2, TParam3, TParam4, TParam5> request, Func<RequestRoutingContext, TParam1, TParam2, TParam3, TParam4, TParam5, Task<TResult>> implementation)
        {
            return MapInternal(request, implementation.Method, implementation.Target);
        }

        private ExternalOperationMapping MapInternal(
            ExternalOperation request, 
            System.Reflection.MethodInfo method, 
            object target)
        {
            if (ApplicationSetup.Revived)
                throw new Exception("Cannot modify application setup after it started!");

            var requestMapping = new ExternalOperationMapping()
            {
                RequestName = request.Name,
                ImplementationMethod = method,
                Target = target
            };

            Implementations.Add(request.Name, requestMapping);
            return requestMapping;
        }

        internal FunctionCall CreateFunctionCall(ExternalOperation externalOperation)
        {
            FunctionCall implementationCall = new FunctionCall();
            // Implementation group is selected BEFORE the parent Queue/CommandContext is instantiated & it is passed along
            // rc.Using is used to CHANGE the implementation group when enqueueing the next time
            //if (ImplementationGroup == null)
            //{
            //    throw new NotSupportedException($"Calling {externalOperation.Name} is not possible without a specified implementation group");
            //}

            if (!Implementations.ContainsKey(externalOperation.Name))
            {
                throw new NotImplementedException($"{externalOperation.Name} has no implementation in the specified group");
            }

            ExternalOperationMapping requestMapping = Implementations[externalOperation.Name];
            implementationCall = new FunctionCall()
            {
                MethodInfo = requestMapping.ImplementationMethod,
                Target = requestMapping.Target
            };

            return implementationCall;
        }
    }
}