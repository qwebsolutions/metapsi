using System;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi
{
    /// <summary>
    /// rc.Using() generates one of these when inside a operation mapping context
    /// Can enqueue both commands and requests, they can be awaited
    /// </summary>
    /// <typeparam name="TBusinessState"></typeparam>
    public class StackEnqueuer<TBusinessState> : IEnqueuer
    {
        public ApplicationSetup ApplicationSetup { get; set; }
        public ImplementationGroup ImplementationGroup { get; set; }
        public ExecutionQueue ExecutionQueue { get; set; }
        public CallStack ParentCallStack { get; set; }
        //public CommandContext FromCommandContext { get; set; }
        //private int TimeoutMilliseconds { get; set; } = 10000;

        // Used when configuring command/request implementation

        public StackEnqueuer(
            ApplicationSetup applicationSetup,
            ImplementationGroup implementationGroup,
            ExecutionQueue executionQueue,
            CallStack parentCallstack)
        {
            this.ApplicationSetup = applicationSetup;
            this.ImplementationGroup = implementationGroup;
            this.ExecutionQueue = executionQueue;
            this.ParentCallStack = parentCallstack;
        }

        public Task EnqueueCommand(Func<CommandContext, TBusinessState, Task> function)
        {
            return EnqueueCommandInternal(function.Method, function.Target);
        }

        public Task EnqueueCommand<TParam1>(
            Func<CommandContext, TBusinessState, TParam1, Task> function,
            TParam1 param1)
        {
            return EnqueueCommandInternal(function.Method, function.Target, param1);
        }

        public Task EnqueueCommand<TParam1, TParam2>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, Task> function,
            TParam1 param1,
            TParam2 param2)
        {
            return EnqueueCommandInternal(function.Method, function.Target, param1, param2);
        }

        public Task EnqueueCommand<TParam1, TParam2, TParam3>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, TParam3, Task> function,
            TParam1 param1,
            TParam2 param2,
            TParam3 param3)
        {
            return EnqueueCommandInternal(function.Method, function.Target, param1, param2, param3);
        }

        public Task EnqueueCommand<TParam1, TParam2, TParam3, TParam4>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, TParam3, TParam4, Task> function,
            TParam1 param1,
            TParam2 param2,
            TParam3 param3,
            TParam4 param4)
        {
            return EnqueueCommandInternal(function.Method, function.Target, param1, param2, param3, param4);
        }

        public Task EnqueueCommand<TParam1, TParam2, TParam3, TParam4, TParam5>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, TParam3, TParam4, TParam5, Task> function,
            TParam1 param1,
            TParam2 param2,
            TParam3 param3,
            TParam4 param4,
            TParam5 param5)
        {
            return EnqueueCommandInternal(function.Method, function.Target, param1, param2, param3, param4, param5);
        }

        public Task<TResult> EnqueueRequest<TResult>(
            Func<CommandContext, TBusinessState, Task<TResult>> function)
        {
            return EnqueueRequestInternal<TResult>(function.Method, function.Target);
        }

        public Task<TResult> EnqueueRequest<TResult, TParam1>(
            Func<CommandContext, TBusinessState, TParam1, Task<TResult>> function,
            TParam1 param1)
        {
            return EnqueueRequestInternal<TResult>(function.Method, function.Target, param1);
        }

        public Task<TResult> EnqueueRequest<TResult, TParam1, TParam2>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, Task<TResult>> function,
            TParam1 param1,
            TParam2 param2)
        {
            return EnqueueRequestInternal<TResult>(function.Method, function.Target, param1, param2);
        }

        public Task<TResult> EnqueueRequest<TResult, TParam1, TParam2, TParam3>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, TParam3, Task<TResult>> function,
            TParam1 param1,
            TParam2 param2,
            TParam3 param3)
        {
            return EnqueueRequestInternal<TResult>(function.Method, function.Target, param1, param2, param3);
        }

        public Task<TResult> EnqueueRequest<TResult, TParam1, TParam2, TParam3, TParam4>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, TParam3, TParam4, Task<TResult>> function,
            TParam1 param1,
            TParam2 param2,
            TParam3 param3,
            TParam4 param4)
        {
            return EnqueueRequestInternal<TResult>(function.Method, function.Target, param1, param2, param3, param4);
        }

        public Task<TResult> EnqueueRequest<TResult, TParam1, TParam2, TParam3, TParam4, TParam5>(
            Func<CommandContext, TBusinessState, TParam1, TParam2, TParam3, TParam4, TParam5, Task<TResult>> function,
            TParam1 param1,
            TParam2 param2,
            TParam3 param3,
            TParam4 param4,
            TParam5 param5)
        {
            return EnqueueRequestInternal<TResult>(function.Method, function.Target, param1, param2, param3, param4, param5);
        }

        //public StackEnqueuer<TBusinessState> WithTimeout(int timeoutMilliseconds)
        //{
        //    this.TimeoutMilliseconds = timeoutMilliseconds;
        //    return this;
        //}

        private async Task EnqueueCommandInternal(
            System.Reflection.MethodInfo methodInfo,
            object target,
            params object[] parameters)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            var enqueuedCommand = EnqueuedOperation.CreateOperation<EnqueuedCommand>(
                this.ImplementationGroup,
                this.ParentCallStack,
                this.ExecutionQueue,
                methodInfo, 
                target, 
                parameters);

            if (enqueuedCommand.CallStack.AlreadyAwaitingOnState())
            {
                throw new Exception("Deadlock detected!");
            }

            await ExecutionQueue.Enqueue(enqueuedCommand);

            await enqueuedCommand.OperationDone;
            await this.ApplicationSetup.LogMessages.Writer.WriteAsync(new LogMessage()
            {
                Message = new Log.Debug($"{enqueuedCommand.GetHashCode()} {enqueuedCommand.FunctionCall.MethodInfo.Name} awaited {stopwatch.ElapsedMilliseconds} ms", System.Threading.Thread.CurrentThread.ManagedThreadId)
            });
        }

        private async Task<TResult> EnqueueRequestInternal<TResult>(
            System.Reflection.MethodInfo methodInfo,
            object target,
            params object[] parameters)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            var enqueuedRequest = EnqueuedOperation.CreateOperation<EnqueuedRequest>(
                this.ImplementationGroup,
                this.ParentCallStack,
                this.ExecutionQueue,
                methodInfo, 
                target, 
                parameters);

            if (enqueuedRequest.CallStack.AlreadyAwaitingOnState())
            {
                throw new Exception("Deadlock detected!");
            }

            await ExecutionQueue.Enqueue(enqueuedRequest);

            await enqueuedRequest.OperationDone;
            await this.ApplicationSetup.LogMessages.Writer.WriteAsync(new LogMessage()
            {
                Message = new Log.Debug($"{enqueuedRequest.GetHashCode()} {enqueuedRequest.FunctionCall.MethodInfo.Name} awaited {stopwatch.ElapsedMilliseconds} ms", System.Threading.Thread.CurrentThread.ManagedThreadId)
            });

            return (TResult)enqueuedRequest.Result;
        }
    }
}