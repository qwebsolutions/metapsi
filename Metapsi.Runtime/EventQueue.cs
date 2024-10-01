using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi
{
    public class EventQueue
    {
        private TaskQueue<List<Func<object, Task>>> handlersQueue = new TaskQueue<List<Func<object, Task>>>(new List<Func<object, Task>>());

        public void Raise<T>(T e)
        {
            var _ = handlersQueue.Enqueue(async (handlers) =>
            {
                foreach (var handler in handlers)
                {
                    await handler(e);
                }
            });
        }

        public void On<T>(Func<T, Task> handle)
        {
            var _ = handlersQueue.Enqueue(async (handlers) =>
            {
                handlers.Add(async (object e) =>
                {
                    if (e is T match)
                    {
                        await handle(match);
                    }
                });
            });
        }
    }
}
