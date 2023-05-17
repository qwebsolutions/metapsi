using System;
using System.Threading.Tasks;

namespace Metapsi
{
    public class CommandContext
    {
        public CommandContext(
            ApplicationSetup applicationSetup, 
            ImplementationGroup implementationGroup,
            ExecutionQueue executionQueue,
            CallStack callStack)
        {
            this.ApplicationSetup = applicationSetup;
            this.ImplementationGrup = implementationGroup;
            this.ExecutionQueue = executionQueue;
            this.CallStack = callStack;
            this.Logger = new Logger(CallStack, applicationSetup.LogMessages);
        }

        private ApplicationSetup ApplicationSetup { get; }
        private ImplementationGroup ImplementationGrup { get; }
        private ExecutionQueue ExecutionQueue { get; }

        public CallStack CallStack { get; private set; }
        public Logger Logger { get; set; }

        public void PostEvent(IData eventData)
        {
            ApplicationSetup.Events.Writer.TryWrite(eventData);
        }

        private async Task<TResultData> RequestInternal<TResultData>(
            ExternalOperation request,
            params object[] parameters)
        {
            CallStack callStack = this.CallStack;
            try
            {
                var functionCall = this.ImplementationGrup.CreateFunctionCall(request);
                callStack = new CallStack(this.CallStack, new ExternalOperationStep()
                {
                    ExternalOperation = request,
                    MappingFunction = functionCall.MethodInfo.Name
                });

                RequestRoutingContext requestRoutingContext = new RequestRoutingContext(ApplicationSetup, functionCall, callStack);
                Task externalOperationTask = await requestRoutingContext.PerformExternalOperation(parameters);
                TResultData result = ((dynamic)externalOperationTask).Result;
                return result;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                // throw to propagate the exception to the caller that is waiting for a result
                // This is not a processing loop like in ExecutionQueue, it is a stack of calls
                throw new MetapsiException(callStack, ex);
            }
        }

        private async Task CommandInternal(
            ExternalOperation command,
            params object[] parameters)
        {
            CallStack callStack = this.CallStack;
            try
            {
                var functionCall = this.ImplementationGrup.CreateFunctionCall(command);
                callStack = new CallStack(this.CallStack, new ExternalOperationStep()
                {
                    ExternalOperation = command,
                    MappingFunction = functionCall.MethodInfo.Name
                });
                CommandRoutingContext commandRoutingContext = new CommandRoutingContext(ApplicationSetup, functionCall, callStack);
                await commandRoutingContext.PerformExternalOperation(parameters);
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                // throw to propagate the exception to the caller that is waiting for a result
                // This is not a processing loop like in ExecutionQueue, it is a stack of calls
                throw new MetapsiException(callStack, ex);
            }
        }

        public async Task Do(Command command)
        {
            await CommandInternal(command);
        }

        public async Task Do<TParam1>(Command<TParam1> command, TParam1 param1)
        {
            await CommandInternal(command, param1);
        }

        public async Task Do<TParam1, TParam2>(Command<TParam1, TParam2> command, TParam1 param1, TParam2 param2)
        {
            await CommandInternal(command, param1, param2);
        }

        public async Task Do<TParam1, TParam2, TParam3>(Command<TParam1, TParam2, TParam3> command, TParam1 param1, TParam2 param2, TParam3 param3)
        {
            await CommandInternal(command, param1, param2, param3);
        }

        public async Task Do<TParam1, TParam2, TParam3, TParam4>(Command<TParam1, TParam2, TParam3, TParam4> command, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
        {
            await CommandInternal(command, param1, param2, param3, param4);
        }

        public async Task Do<TParam1, TParam2, TParam3, TParam4, TParam5>(Command<TParam1, TParam2, TParam3, TParam4, TParam5> command, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
        {
            await CommandInternal(command, param1, param2, param3, param4, param5);
        }

        public async Task Do<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>(Command<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> command, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6)
        {
            await CommandInternal(command, param1, param2, param3, param4, param5, param6);
        }


        public async Task<TResultData> Do<TResultData>(Request<TResultData> request)
        {
            return await RequestInternal<TResultData>(request);
        }

        public async Task<TResultData> Do<TResultData, TParam1>(Request<TResultData, TParam1> request, TParam1 param1)
        {
            return await RequestInternal<TResultData>(request, param1);
        }

        public async Task<TResultData> Do<TResultData, TParam1, TParam2>(Request<TResultData, TParam1, TParam2> request, TParam1 param1, TParam2 param2)
        {
            return await RequestInternal<TResultData>(request, param1, param2);
        }

        public async Task<TResultData> Do<TResultData, TParam1, TParam2, TParam3>(Request<TResultData, TParam1, TParam2, TParam3> request, TParam1 param1, TParam2 param2, TParam3 param3)
        {
            return await RequestInternal<TResultData>(request, param1, param2, param3);
        }

        public async Task<TResultData> Do<TResultData, TParam1, TParam2, TParam3, TParam4>(Request<TResultData, TParam1, TParam2, TParam3, TParam4> request, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
        {
            return await RequestInternal<TResultData>(request, param1, param2, param3, param4);
        }

        public async Task<TResultData> Do<TResultData, TParam1, TParam2, TParam3, TParam4, TParam5>(Request<TResultData, TParam1, TParam2, TParam3, TParam4, TParam5> request, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5)
        {
            return await RequestInternal<TResultData>(request, param1, param2, param3, param4, param5);
        }

        public QueueState<TExecutionQueueState> Add<TExecutionQueueState>() where TExecutionQueueState : class, new()
        {
            string name = Guid.NewGuid().ToString();
            return ApplicationSetup.ExecutionQueues.Add<TExecutionQueueState>(name);
        }

        public QueueState<TExecutionQueueState> Create<TExecutionQueueState>(string name, TExecutionQueueState state)
        {
            return ApplicationSetup.ExecutionQueues.Create<TExecutionQueueState>(name, state);
        }

        public QueueState<TExecutionQueueState> Add<TExecutionQueueState>(string name) where TExecutionQueueState : class, new()
        {
            return ApplicationSetup.ExecutionQueues.Add<TExecutionQueueState>(name);
        }

        public void RemoveByState<TExecutionQueueState>(TExecutionQueueState stateReference)
        {
            ApplicationSetup.ExecutionQueues.RemoveByState(stateReference);
        }

        public void RemoveByName(string queueName)
        {
            ApplicationSetup.ExecutionQueues.RemoveByName(queueName);
        }
    }
}
