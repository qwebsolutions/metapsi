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
}
