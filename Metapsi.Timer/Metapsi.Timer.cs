using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Metapsi
{
    public static partial class Timer
    {
        public static class Command
        {
            public class Set
            {
                public string Name { get; set; } = string.Empty;
                public int IntervalMilliseconds { get; set; }
                public int DelayMilliseconds { get; set; }
                public string Data { get; set; } = string.Empty;
            }

            public class Remove
            {
                public string Name { get; set; } = string.Empty;
            }
        }

        public static partial class Event
        {
            public partial class Tick : IData
            {
                public string Name { get; set; } = string.Empty;
                public string Data { get; set; } = string.Empty;
                public int TickCount { get; set; } = 0;
            }
        }

        public class State
        {
            internal Dictionary<string, TimerReferences> Timers { get; set; } = new Dictionary<string, TimerReferences>();
            public bool IsShuttingDown { get; set; } = false;
        }

        public static async Task SetTimer(CommandContext commandContext, State state, Command.Set setTimer)
        {
            RemoveTimer(state, setTimer.Name);

            int tickCount = 0;

            System.Threading.Timer newTimer = new System.Threading.Timer((_) =>
            {
                if (!state.IsShuttingDown)
                {
                    tickCount++;
                    commandContext.PostEvent(new Event.Tick()
                    {
                        Name = setTimer.Name,
                        Data = setTimer.Data,
                        TickCount = tickCount
                    });
                }
            }, null, setTimer.DelayMilliseconds, setTimer.IntervalMilliseconds);
            state.Timers[setTimer.Name] = new TimerReferences()
            {
                Setter = setTimer,
                Timer = newTimer
            };
        }

        public static async Task RemoveTimer(CommandContext commandContext, State state, Command.Remove removeTimer)
        {
            RemoveTimer(state, removeTimer.Name);
        }

        public static async Task RemoveByData(CommandContext commandContext, State state, string data)
        {
            List<string> removableKeys = new List<string>();

            foreach (string key in state.Timers.Keys)
            {
                if (state.Timers[key].Setter.Data == data)
                {
                    removableKeys.Add(key);
                }
            }

            foreach (string key in removableKeys)
            {
                RemoveTimer(state, key);
            }
        }

        public static async Task Shutdown(CommandContext commandContext, State state)
        {
            state.IsShuttingDown = true;
            List<string> allTimerNames = state.Timers.Keys.ToList();

            foreach (string key in allTimerNames)
            {
                RemoveTimer(state, key);
            }
        }

        private static void RemoveTimer(State state, string name)
        {
            if (state.Timers.ContainsKey(name))
            {
                TimerReferences oldTimerReferences = state.Timers[name];
                System.Threading.Timer oldTimer = oldTimerReferences.Timer;
                oldTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                oldTimer.Dispose();
                state.Timers.Remove(name);
            }
        }

        public static int FromMinutes(int minutes)
        {
            return minutes * 60 * 1000;
        }

        public static int FromSeconds(int seconds)
        {
            return seconds * 1000;
        }

        internal class TimerReferences
        {
            public System.Threading.Timer Timer { get; set; }
            public Command.Set Setter { get; set; }
        }
    }
}
