using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi
{
    /// <summary>
    /// rc.Using() generates one of these in the context of an event.
    /// Can only enqueue commands, that's what the event context does
    /// </summary>
    public class RootEnqueuer<TBusinessState, TEvent> : IEnqueuer
    {
        public RootEnqueuer(
            ApplicationSetup applicationSetup,
            ExecutionQueue executionQueue,
            ImplementationGroup implementationGroup,
            TEvent eventData)
        {
            this.ApplicationSetup = applicationSetup;
            this.ExecutionQueue = executionQueue;
            this.ImplementationGroup = implementationGroup;
            this.EventData = eventData;
        }

        public ApplicationSetup ApplicationSetup { get; set; }
        public ExecutionQueue ExecutionQueue { get; set; }
        public ImplementationGroup ImplementationGroup { get; set; }
        public TEvent EventData { get; set; }
        public int TimeoutMilliseconds { get; set; }

        private System.Threading.Timer timeoutTimer;

        private void EnqueueTopCommand(
            System.Reflection.MethodInfo methodInfo,
            object target,
            params object[] parameters)
        {
            CallStack callStack = new CallStack(EventData as IData);
            var enqueuedCommand = EnqueuedOperation.CreateOperation<EnqueuedCommand>(
                this.ImplementationGroup,
                callStack,
                this.ExecutionQueue,
                methodInfo,
                target,
                parameters);

            enqueuedCommand.OperationDone.ContinueWith((ante) =>
            {
                lock (ApplicationSetup.Application.PendingTopCommands)
                {
                    ApplicationSetup.Application.PendingTopCommands.Remove(enqueuedCommand.Id);
                    if (timeoutTimer != null)
                    {
                        timeoutTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        timeoutTimer.Dispose();
                    }
                }
            });


            // Mark top command as being 'pending', so shutdown doesn't cut it short
            lock (ApplicationSetup.Application.PendingTopCommands)
            {
                ApplicationSetup.Application.PendingTopCommands[enqueuedCommand.Id] = $"Command:{enqueuedCommand.FunctionCall.MethodInfo.DeclaringType.Namespace}.{enqueuedCommand.FunctionCall.MethodInfo.DeclaringType.Name}.{enqueuedCommand.FunctionCall.MethodInfo.Name}";

                ExecutionQueue.Enqueue(enqueuedCommand).Wait();
                if (TimeoutMilliseconds > 0)
                {
                    this.timeoutTimer = new System.Threading.Timer((_) =>
                    {
                        var pendingOperationsCount =  this.ExecutionQueue.CommandQueue.Reader.Count;

                        string message = $"Pending: {pendingOperationsCount}";

                        ApplicationSetup.LogMessages.Writer.TryWrite(new LogMessage()
                        {
                            CallStack = callStack,
                            Message = new Log.Error(message)
                        });
                    }, null, TimeoutMilliseconds, System.Threading.Timeout.Infinite);
                }
            }
        }

        // Used when configuring commands for events

        public void EnqueueCommand(
            Func<CommandContext, TBusinessState, Task> command)
        {
            EnqueueTopCommand(command.Method, command.Target);
        }

        public void EnqueueCommand<TParam1>(
            Func<CommandContext, TBusinessState, TParam1, Task> command,
            TParam1 param1)
        {
            EnqueueTopCommand(command.Method, command.Target, param1);
        }

        public void EnqueueCommand<TParam1, TParam2>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, Task> command,
            TParam1 param1,
            TParam2 param2)
        {
            EnqueueTopCommand(command.Method, command.Target, param1, param2);
        }

        public void EnqueueCommand<TParam1, TParam2, TParam3>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, TParam3, Task> command,
            TParam1 param1,
            TParam2 param2,
            TParam3 param3)
        {
            EnqueueTopCommand(command.Method, command.Target, param1, param2, param3);
        }

        public void EnqueueCommand<TParam1, TParam2, TParam3, TParam4>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, TParam3, TParam4, Task> command,
            TParam1 param1,
            TParam2 param2,
            TParam3 param3,
            TParam4 param4)
        {
            EnqueueTopCommand(command.Method, command.Target, param1, param2, param3, param4);
        }

        public void EnqueueCommand<TParam1, TParam2, TParam3, TParam4, TParam5>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, TParam3, TParam4, TParam5, Task> command,
            TParam1 param1,
            TParam2 param2,
            TParam3 param3,
            TParam4 param4,
            TParam5 param5)
        {
            EnqueueTopCommand(command.Method, command.Target, param1, param2, param3, param4, param5);
        }

        public RootEnqueuer<TBusinessState, TEvent> WithTimeout(int timeoutMilliseconds)
        {
            this.TimeoutMilliseconds = timeoutMilliseconds;
            return this;
        }
    }
}