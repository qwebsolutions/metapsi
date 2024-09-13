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
                    try
                    {
                        var nextTask = await this.tasksChannel.Reader.ReadAsync(cancellationTokenSource.Token);
                        await nextTask(); // this only starts the task
                    }
                    catch (Exception ex)
                    {
                        // This should run forever, never rethrow here
                        Console.Error.WriteLine(ex.ToString());
                    }
                }
            });
        }

        public virtual void StopProcessing()
        {
            this.cancellationTokenSource.Cancel();
            this.tasksChannel.Writer.Complete();
        }

        public virtual async Task<TResult> Enqueue<TResult>(System.Func<Task<TResult>> task)
        {
            var tcs = new TaskCompletionSource<TResult>();
            await this.tasksChannel.Writer.WriteAsync(async () =>
            {
                try
                {
                    var result = await task();
                    tcs.SetResult(result);
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            });
            return await tcs.Task;
        }

        public virtual async Task Enqueue(System.Func<Task> task)
        {
            var tcs = new TaskCompletionSource<bool>();
            await this.tasksChannel.Writer.WriteAsync(async () =>
            {
                try
                {
                    await task();
                    tcs.SetResult(true);
                }
                catch(Exception ex)
                {
                    tcs.SetException(ex);
                }
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

        public virtual async Task<TResult> Enqueue<TResult>(System.Func<T, Task<TResult>> task)
        {
            return await taskQueue.Enqueue(async () =>
            {
                return await task(this.state);
            });
        }

        public virtual async Task Enqueue(System.Func<T, Task> task)
        {
            await taskQueue.Enqueue(async () =>
            {
                await task(this.state);
            });
        }

        public virtual async Task<T> GetState()
        {
            // Get state through the queue so it's thread safe
            return await taskQueue.Enqueue(async () =>
            {
                return this.state;
            });
        }
    }
}
