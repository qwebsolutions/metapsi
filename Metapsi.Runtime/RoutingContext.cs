using System;
using System.Threading.Tasks;

namespace Metapsi
{
    /// <summary>
    /// It is created when an external operation is called
    /// </summary>
    public class RoutingContext
    {
        public RoutingContext(
            ApplicationSetup applicationSetup,
            FunctionCall functionCall,
            CallStack callstack)
        {
            this.CallStack = callstack;
            this.FunctionCall = functionCall;
            this.ApplicationSetup = applicationSetup;
            this.Logger = new Logger(this.CallStack, applicationSetup.LogMessages);
        }

        public CallStack CallStack { get; set; }
        private FunctionCall FunctionCall { get; set; }
        private ApplicationSetup ApplicationSetup { get; set; }
        public Logger Logger { get; private set; }

        public QueueState<TExecutionQueueState> Add<TExecutionQueueState>() where TExecutionQueueState : class, new()
        {
            string name = Guid.NewGuid().ToString();
            return ApplicationSetup.ExecutionQueues.Add<TExecutionQueueState>(name);
        }

        public QueueState<TExecutionQueueState> Add<TExecutionQueueState>(string name) where TExecutionQueueState : class, new()
        {
            return ApplicationSetup.ExecutionQueues.Add<TExecutionQueueState>(name);
        }

        public QueueState<TExecutionQueueState> Create<TExecutionQueueState>(string name, TExecutionQueueState state)
        {
            return ApplicationSetup.ExecutionQueues.Create(name, state);
        }

        public StackEnqueuer<TBusinessState> Using<TBusinessState>(TBusinessState businessState, ImplementationGroup implementationGroup)
        {
            var q = ApplicationSetup.ExecutionQueues.ByState(businessState);
            return new StackEnqueuer<TBusinessState>(ApplicationSetup, implementationGroup, q, this.CallStack);
        }

        public StackEnqueuer<TBusinessState> ByName<TBusinessState>(string queueName, ImplementationGroup implementationGroup)
        {
            var q = ApplicationSetup.ExecutionQueues.ByName(queueName);
            return new StackEnqueuer<TBusinessState>(ApplicationSetup, implementationGroup, q, this.CallStack);
        }

        //public void RemoveByState<TExecutionQueueState>(TExecutionQueueState stateReference)
        //{
        //    ApplicationSetup.ExecutionQueues.RemoveByState(stateReference);
        //}

        //public void RemoveByName(string queueName)
        //{
        //    ApplicationSetup.ExecutionQueues.RemoveByName(queueName);
        //}

        public async Task<Task> PerformExternalOperation(params object[] parameters)
        {
            foreach (object parameter in parameters)
            {
                this.FunctionCall.Parameters.Add(parameter);
            }

            Task task = await FunctionCall.CallAsyncWith(this);
            return task;
        }
    }
}

