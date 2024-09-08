using System;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Metapsi
{
    public class TaskQueue
    {
        private Channel<Func<Task>> tasksChannel;

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        public TaskQueue()
        {
            this.tasksChannel = Channel.CreateUnbounded<Func<Task>>();
            StartProcessing();
        }

        private void StartProcessing()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    var nextTask = await this.tasksChannel.Reader.ReadAsync(cancellationTokenSource.Token);
                    await nextTask();
                }
            });
        }

        public void StopProcessing()
        {
            this.cancellationTokenSource.Cancel();
            this.tasksChannel.Writer.Complete();
        }

        public async Task<TResult> Enqueue<TResult>(System.Func<Task<TResult>> task)
        {
            var tcs = new TaskCompletionSource<TResult>();
            await this.tasksChannel.Writer.WriteAsync(async () =>
            {
                var result = await task();
                tcs.SetResult(result);
            });
            return await tcs.Task;
        }

        public async Task Enqueue(System.Func<Task> task)
        {
            var tcs = new TaskCompletionSource<bool>();
            await this.tasksChannel.Writer.WriteAsync(async () =>
            {
                await task();
                tcs.SetResult(true);
            });
            await tcs.Task;
        }
    }

    public class TaskQueue<T>
    {
        private TaskQueue taskQueue = new TaskQueue();
        private T state { get; set; } = default(T);

        public TaskQueue(T state)
        {
            this.state = state;
        }

        public void StopProcessing()
        {
            this.taskQueue.StopProcessing();
        }

        public async Task<TResult> Enqueue<TResult>(System.Func<T, Task<TResult>> task)
        {
            return await taskQueue.Enqueue(async () =>
            {
                return await task(this.state);
            });
        }

        public async Task Enqueue(System.Func<T, Task> task)
        {
            await taskQueue.Enqueue(async () =>
            {
                await task(this.state);
            });
        }

        public async Task<T> GetState()
        {
            // Get state through the queue so it's thread safe
            return await taskQueue.Enqueue(async () =>
            {
                return this.state;
            });
        }
    }
}
