using System;
using System.Collections.Generic;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Metapsi
{
    public class ExecutionQueue
    {
        //public long TotalCommandsCount { get; set; } = 0;
        //public int TotalExceptionsCount { get; set; } = 0;

        private ApplicationSetup ApplicationSetup { get; set; }

        public object Name { get; set; }
        public object State { get; set; }
        public Channel<EnqueuedOperation> CommandQueue { get; set; } = System.Threading.Channels.Channel.CreateUnbounded<EnqueuedOperation>();

        public ExecutionQueue(ApplicationSetup applicationSetup, string name, object state)
        {
            Name = name;
            State = state;
            this.ApplicationSetup = applicationSetup;
        }

        public void StartProcessingUpdates()
        {
            Task.Run(ProcessStateOperations);
        }

        public async Task ProcessStateOperations()
        {
            while (true)
            {
                EnqueuedOperation enqueuedOperation = await CommandQueue.Reader.ReadAsync();
                try
                {
                    var stopwatch = System.Diagnostics.Stopwatch.StartNew();

                    CommandContext commandContext = new CommandContext(ApplicationSetup, enqueuedOperation.ImplementationGroup, this, enqueuedOperation.CallStack);

                    Task asTask = await enqueuedOperation.FunctionCall.CallAsyncWith(commandContext, State);
                    if (enqueuedOperation is EnqueuedRequest)
                    {
                        (enqueuedOperation as EnqueuedRequest).Result = ((dynamic)asTask).Result;
                    }
                    enqueuedOperation.OperationDone.Start();
                    //commandContext.Logger.LogDebug($"{enqueuedOperation.GetHashCode()} {enqueuedOperation.FunctionCall.MethodInfo.Name} {stopwatch.ElapsedMilliseconds} ms");
                }

                catch (Exception ex)
                {
                    await ApplicationSetup.LogMessages.Writer.WriteAsync(new LogMessage()
                    {
                        CallStack = enqueuedOperation.CallStack,
                        Message = new Log.Exception(ex)
                    });
                    enqueuedOperation.OperationDone.Start();

                    // Never rethrow, this is a loop that must keep going
                }
            }
        }

        public void StopProcessingUpdates()
        {
            CommandQueue.Writer.Complete();
        }

        internal async Task Enqueue(EnqueuedOperation enqueuedOperation)
        {
            await CommandQueue.Writer.WriteAsync(enqueuedOperation);
        }
    }
}