using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Metapsi;

internal class TaskQueue
{
    private Channel<Task> tasksChannel;

    CancellationTokenSource cancellationTokenSource = new();

    public TaskQueue()
    {
        this.tasksChannel = Channel.CreateUnbounded<Task>();
        StartProcessing();
    }

    private void StartProcessing()
    {
        Task.Run(async () =>
        {
            while (true)
            {
                var nextTask = await this.tasksChannel.Reader.ReadAsync(cancellationTokenSource.Token);
                await nextTask;
            }
        });
    }

    public void StopProcessing()
    {
        this.cancellationTokenSource.Cancel();
        this.tasksChannel.Writer.Complete();
    }

    public async Task<TResult> Enqueue<TResult>(Task<TResult> task)
    {
        await this.tasksChannel.Writer.WriteAsync(task);
        return task.Result;
    }

    public async Task<TResult> Enqueue<TResult>(System.Func<Task<TResult>> task)
    {
        var enqueuedTask = task();
        await this.tasksChannel.Writer.WriteAsync(enqueuedTask);
        return enqueuedTask.Result;
    }

    public async Task Enqueue(Task task)
    {
        await this.tasksChannel.Writer.WriteAsync(task);
    }

    public async Task Enqueue(System.Func<Task> task)
    {
        await this.tasksChannel.Writer.WriteAsync(task());
    }
}
