using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi
{
    public class Application
    {
        public ApplicationSetup ApplicationSetup { get; set; }
        public Dictionary<Guid, string> PendingTopCommands { get; set; } = new Dictionary<Guid, string>();
        public Task SuspendComplete { get; set; } = new Task(() => { });
        public DateTime StartTime { get; set; } = DateTime.Now;

        public async Task Suspend(params Task[] awaitedTasks)
        {
            var suspendAttemptStart = System.DateTime.UtcNow;

            ApplicationSetup.LogMessages.Writer.TryWrite(new LogMessage()
            {
                Message = new Log.Info($"Suspend: started at {suspendAttemptStart.Roundtrip()}, waiting {awaitedTasks.Length} explicit tasks, {ApplicationSetup.Events.Reader.Count} events, {PendingTopCommands.Count} top commands")
            });

            int maxSuspendSeconds = 10;

            ApplicationSetup.Events.Writer.TryWrite(new ApplicationIsShuttingDown());
            await ApplicationSetup.ShutdownMappingsProcessed;

            await Task.WhenAll(awaitedTasks);

            ApplicationSetup.LogMessages.Writer.TryWrite(new LogMessage()
            {
                Message = new Log.Info($"Suspend: explicit tasks complete")
            });

            int attempt = 0;

            while (true)
            {
                attempt++;
                lock (PendingTopCommands)
                {
                    bool eventsDone = ApplicationSetup.Events.Reader.Count == 0;
                    bool commandsDone = PendingTopCommands.Count == 0;

                    if (eventsDone && commandsDone)
                    {
                        ApplicationSetup.LogMessages.Writer.TryWrite(new LogMessage()
                        {
                            Message = new Log.Info($"Suspend: attempt {attempt} success")
                        });

                        // BREAKS out of while here!
                        break;
                    }
                    else
                    {
                        string pendingCommands = string.Join("\n", PendingTopCommands.Values);
                        ApplicationSetup.LogMessages.Writer.TryWrite(new LogMessage()
                        {
                            Message = new Log.Info($"Suspend: attempt {attempt}, pending events {ApplicationSetup.Events.Reader.Count}, pending top commands {PendingTopCommands.Count} ({pendingCommands})")
                        });
                    }
                }

                if ((System.DateTime.UtcNow - suspendAttemptStart).TotalSeconds > maxSuspendSeconds)
                {
                    await ApplicationSetup.OnLogMessage(new LogMessage()
                    {
                        Message = new Log.Error($"Suspend took longer than {maxSuspendSeconds} seconds")
                    });
                    break;
                }

                await Task.Delay(500);
            }

            ApplicationSetup.Events.Writer.Complete();
            ApplicationSetup.ExecutionQueues.Clear();
            await ApplicationSetup.OnLogMessage(new LogMessage()
            {
                Message = new Log.Info("Shutdown complete")
            });
            SuspendComplete.Start();
        }
    }
}