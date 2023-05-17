using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Metapsi
{
    public class ApplicationSetup
    {
        internal Dictionary<Type, List<IEventMapping>> EventMappings { get; set; } = new Dictionary<Type, List<IEventMapping>>();
        internal Channel<IData> Events = Channel.CreateUnbounded<IData>();
        internal ExecutionQueues ExecutionQueues { get; set; }
        internal List<ImplementationGroup> ImplementationGroups { get; set; } = new List<ImplementationGroup>();

        internal Channel<LogMessage> LogMessages { get; set; } = Channel.CreateUnbounded<LogMessage>();

        public Func<LogMessage, Task> OnLogMessage { get; set; } = async (logMessage) =>
        {
            Console.WriteLine(logMessage.ToString());
        };

        internal bool Revived = false;
        internal Application Application { get; set; }

        //public string ServiceName { get; private set; }

        internal Task ShutdownMappingsProcessed { get; set; } = new Task(() => { });

        public static ApplicationSetup New()
        {
            //if (string.IsNullOrEmpty(serviceName))
            //    throw new Exception("Empty service name!");

            var applicationSetup = new ApplicationSetup();

            //applicationSetup.ServiceName = serviceName;

            return applicationSetup;
        }

        public ApplicationSetup()
        {
            this.ExecutionQueues = new ExecutionQueues(this);
        }

        public ImplementationGroup AddImplementationGroup()
        {
            ImplementationGroup implementationGroup = new ImplementationGroup();
            implementationGroup.ApplicationSetup = this;
            ImplementationGroups.Add(implementationGroup);
            return implementationGroup;
        }

        public IEventMapping MapEvent<TEventData>(
            Action<EventContext<TEventData>> onEvent)
            where TEventData : IData
        {
            return MapEventIf(null, onEvent);
        }

        public IEventMapping MapEventIf<TEventData>(
            Func<TEventData, bool> guard,
            Action<EventContext<TEventData>> onEvent)
            where TEventData : IData
        {
            if (Revived)
                throw new System.Exception("Cannot modify application setup after it started!");

            if (!EventMappings.ContainsKey(typeof(TEventData)))
            {
                EventMappings.Add(typeof(TEventData), new List<IEventMapping>());
            }

            EventMapping<TEventData> eventMapping = new EventMapping<TEventData>()
            {
                EventType = typeof(TEventData),
                Guard = guard,
                OnEvent = onEvent,
                ApplicationSetup = this
            };

            EventMappings[typeof(TEventData)].Add(eventMapping);

            return eventMapping;
        }

        public Application Revive()
        {
            Revived = true;
            Application application = new Application()
            {
                ApplicationSetup = this
            };
            Application = application;

            new TaskFactory().StartNew(async () =>
            {
                while (true)
                {
                    LogMessage logData = await application.ApplicationSetup.LogMessages.Reader.ReadAsync();

                    try
                    {
                        await application.ApplicationSetup.OnLogMessage(logData);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine(ex.ToString());
                    }
                }
            });

            StartedEventsContainer startedEventsContainer = new StartedEventsContainer();


            new TaskFactory().StartNew(async () =>
            {
                while (true)
                {
                    await Task.Delay(10000);
                    lock (startedEventsContainer.Lock)
                    {
                        foreach (StartedEvent startedEvent in startedEventsContainer.StartedEvents)
                        {
                            if (startedEvent.Stopwatch.ElapsedMilliseconds > 10000)
                            {
                                string message = $"Event handler for {startedEvent.Data.GetType().FullName} is blocking execution.";
                                message += "Please enqueue processing in a component or start a separate task\n";
                                message += $"Data: {Metapsi.Serialize.ToJson(startedEvent.Data)}\n";
                                message += startedEvent.EventMapping.ToString();

                                LogMessages.Writer.TryWrite(new LogMessage()
                                {
                                    CallStack = new CallStack(startedEvent.Data),
                                    Message = new Log.Error(message)
                                });
                            }
                        }
                    }
                }
            });

            Task.Run(async () => await ProcessEvents(new ProcessEventsReferences()
            {
                EventsReader = application.ApplicationSetup.Events.Reader,
                EventMappings = application.ApplicationSetup.EventMappings,
                StartedEventsContainer = startedEventsContainer,
                LogData = LogMessages,
                ShutdownMappingsProcessed = ShutdownMappingsProcessed
            }));

            application.ApplicationSetup.Events.Writer.TryWrite(new ApplicationRevived()
            {
                EventMappingsCount = application.ApplicationSetup.EventMappings.Sum(x => x.Value.Count),
                ImplementationGroupsCount = application.ApplicationSetup.ImplementationGroups.Count,
                ImplementationsCount = application.ApplicationSetup.ImplementationGroups.Sum(x => x.Implementations.Count)
            });

            return application;
        }

        internal static async Task ProcessEvents(ProcessEventsReferences references)
        {
            while(true)
            {
                IData data = await references.EventsReader.ReadAsync();
                if (references.EventMappings.ContainsKey(data.GetType()))
                {
                    var mappings = references.EventMappings[data.GetType()];

                    foreach (var mapping in mappings)
                    {
                        StartedEvent startedEvent = null;

                        try
                        {
                            if (mapping.CheckGuard(data))
                            {
                                //Console.WriteLine($"Event data:{Metapsi.Serialize.ToJson(data)}");

                                startedEvent = new StartedEvent() { EventMapping = mapping, Data = data };
                                lock (references.StartedEventsContainer.Lock)
                                {
                                    references.StartedEventsContainer.StartedEvents.Add(startedEvent);
                                }

                                mapping.Run(data);
                            }
                        }

                        catch (Exception ex)
                        {
                            LogMessage logMessage = new LogMessage();
                            logMessage.CallStack = new CallStack(data);
                            logMessage.Message = new Log.Exception(ex, $"Could not handle {data.GetType().FullName} {mapping} ");
                            await references.LogData.Writer.WriteAsync(logMessage);
                        }
                        finally
                        {
                            if (startedEvent != null)
                            {
                                startedEvent.Stopwatch.Stop();
                                lock (references.StartedEventsContainer.Lock)
                                {
                                    references.StartedEventsContainer.StartedEvents.Remove(startedEvent);
                                }
                            }
                        }
                    }
                }
                if (data.GetType() == typeof(ApplicationIsShuttingDown))
                {
                    references.ShutdownMappingsProcessed.Start();
                }
            }
        }

        internal class StartedEventsContainer
        {
            internal object Lock = new object();
            internal List<StartedEvent> StartedEvents = new List<StartedEvent>();
        }

        internal class StartedEvent
        {
            internal System.Diagnostics.Stopwatch Stopwatch { get; set; } = new System.Diagnostics.Stopwatch();
            internal IEventMapping EventMapping { get; set; }
            internal IData Data { get; set; }

            internal StartedEvent()
            {
                Stopwatch.Start();
            }
        }

        internal class ProcessEventsReferences
        {
            internal ChannelReader<IData> EventsReader { get; set; }
            internal Dictionary<Type, List<IEventMapping>> EventMappings { get; set; }
            internal StartedEventsContainer StartedEventsContainer { get; set; }
            internal Channel<LogMessage> LogData { get; set; }
            internal Task ShutdownMappingsProcessed { get; set; }
        }
    }



}
