using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi
{
    public class ExecutionQueues
    {
        private Dictionary<string, ExecutionQueue> executionQueues = new Dictionary<string, ExecutionQueue>();

        private object lockObject = new object();
        private readonly ApplicationSetup applicationSetup;

        public ExecutionQueues(ApplicationSetup applicationSetup)
        {
            this.applicationSetup = applicationSetup;
        }

        /// <summary>
        /// Ensures a queue with specified name is created. It does not throw error if queue with correct type already exists.
        /// Throws error if the type is different.
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public QueueState<TState> Add<TState>(string name) where TState : class, new()
        {
            lock (lockObject)
            {
                if (!executionQueues.ContainsKey(name))
                {
                    TState state = new TState();
                    var q = new ExecutionQueue(this.applicationSetup, name, state);
                    executionQueues.Add(name, q);
                    q.StartProcessingUpdates();
                    return new QueueState<TState>()
                    {
                        Name = name,
                        State = state
                    };
                }
                else
                {
                    if (typeof(TState) != executionQueues[name].State.GetType())
                    {
                        throw new Exception($"Queue {name} is already in use, type {executionQueues[name].State.GetType().FullName} cannot be changed to {typeof(TState).FullName}");
                    }
                }

                return new QueueState<TState>()
                {
                    Name = name,
                    State = executionQueues[name].State as TState
                };
            }
        }

        /// <summary>
        /// Creates a queue with specified name and specified state reference.
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public QueueState<TState> Create<TState>(string name, TState state)
        {
            lock (lockObject)
            {
                if (executionQueues.ContainsKey(name))
                    throw new Exception($"Execution queue cannot be created, name already in use: {name}");

                var q = new ExecutionQueue(this.applicationSetup, name, state);
                executionQueues.Add(name, q);
                q.StartProcessingUpdates();
                return new QueueState<TState>()
                {
                    Name = name,
                    State = state
                };
            }
        }

        public void RemoveByName(string name)
        {
            lock (lockObject)
            {
                bool found = executionQueues.TryGetValue(name, out ExecutionQueue q);
                if (found)
                {
                    q.StopProcessingUpdates();
                    executionQueues.Remove(name);
                }
            }
        }

        public void RemoveByState(object state)
        {
            lock (lockObject)
            {
                var q = executionQueues.SingleOrDefault(x => x.Value.State == state);
                if (!default(KeyValuePair<string, object>).Equals(q))
                {
                    q.Value.StopProcessingUpdates();
                    executionQueues.Remove(q.Key);
                }
            }
        }

        public ExecutionQueue ByName(string name)
        {
            lock (lockObject)
            {
                return executionQueues[name];
            }
        }

        public ExecutionQueue ByState(object state)
        {
            lock (lockObject)
            {
                var q = executionQueues.Values.Single(x => x.State == state);
                return q;
            }
        }

        public void Clear()
        {
            lock (lockObject)
            {
                List<string> queueNames = executionQueues.Keys.ToList();
                foreach (string name in queueNames)
                {
                    RemoveByName(name);
                }
            }
        }
    }

    public class QueueState<TState>
    {
        public string Name { get; set; }
        public TState State { get; set; }
    }
}
