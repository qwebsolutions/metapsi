using System;

namespace Metapsi
{
    public class EventContext<TEvent> where TEvent : IData
    {
        private ApplicationSetup ApplicationSetup { get; set; }
        public TEvent EventData { get; private set; }

        public Logger Logger { get; private set; }

        public EventContext(ApplicationSetup applicationSetup, TEvent eventData)
        {
            this.ApplicationSetup = applicationSetup;
            this.EventData = eventData;
            this.Logger = new Logger(new CallStack(EventData), this.ApplicationSetup.LogMessages);
        }

        public RootEnqueuer<TExecutionQueueState, TEvent> Using<TExecutionQueueState>(TExecutionQueueState businessState, ImplementationGroup implementationGroup = null)
        {
            ExecutionQueue q = ApplicationSetup.ExecutionQueues.ByState(businessState);
            return new RootEnqueuer<TExecutionQueueState, TEvent>(ApplicationSetup, q, implementationGroup, EventData);
        }

        public RootEnqueuer<TExecutionQueueState, TEvent> ByName<TExecutionQueueState>(string queueName, ImplementationGroup implementationGroup = null)
        {
            ExecutionQueue q = ApplicationSetup.ExecutionQueues.ByName(queueName);
            return new RootEnqueuer<TExecutionQueueState, TEvent>(ApplicationSetup, q, implementationGroup, EventData);
        }

        public QueueState<TExecutionQueueState> Add<TExecutionQueueState>(string queueName) where TExecutionQueueState : class, new()
        {
            return ApplicationSetup.ExecutionQueues.Add<TExecutionQueueState>(queueName);
        }

        public QueueState<TExecutionQueueState> Add<TExecutionQueueState>() where TExecutionQueueState : class, new()
        {
            string queueName = Guid.NewGuid().ToString();
            return ApplicationSetup.ExecutionQueues.Add<TExecutionQueueState>(queueName);
        }

        public QueueState<TExecutionQueueState> Create<TExecutionQueueState>(string queueName, TExecutionQueueState state)
        {
            return ApplicationSetup.ExecutionQueues.Create(queueName, state);
        }

        public QueueState<TExecutionQueueState> Create<TExecutionQueueState>(TExecutionQueueState state)
        {
            string queueName = Guid.NewGuid().ToString();
            return ApplicationSetup.ExecutionQueues.Create(queueName, state);
        }
    }
}