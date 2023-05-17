using System.Threading.Channels;

namespace Metapsi
{
    public class Logger
    {
        private readonly CallStack callStack;
        private readonly Channel<LogMessage> logMessages;

        internal Logger(CallStack callStack, Channel<LogMessage> logMessages)
        {
            this.callStack = callStack;
            this.logMessages = logMessages;
        }

        public void Log(ILogMessage logMessage)
        {
            this.logMessages.Writer.TryWrite(new LogMessage()
            {
                CallStack = callStack,
                Message = logMessage
            });
        }

        public void LogInfo(string message)
        {
            this.Log(new Log.Info(message));
        }

        public void LogError(string message)
        {
            this.Log(new Log.Error(message));
        }

        public void LogDebug(string message, int managedThreadId = -1)
        {
            if (managedThreadId == -1)
            {
                managedThreadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
            }

            this.Log(new Log.Debug(message, managedThreadId));
        }

        public void LogException(System.Exception exception, string description = "")
        {
            if (exception is MetapsiException)
            {
                // Metapsi exceptions are created only after they are already logged
                return;
            }

            this.Log(new Log.Exception(exception, description));
        }
    }

    /// <summary>
    /// Used just to find all references
    /// </summary>
    public interface ILogMessage
    {

    }

    public class LogMessage
    {
        public System.DateTime TimestampUtc { get; } = System.DateTime.UtcNow;
        public CallStack CallStack { get; set; } = new CallStack();
        public ILogMessage Message { get; set; }

        public override string ToString()
        {
            if (CallStack == null)
                return Message.ToString();

            string callstackString = CallStack.ToString();
            if (string.IsNullOrWhiteSpace(callstackString))
                return Message.ToString();

            return $"{TimestampUtc.ToString("O", System.Globalization.CultureInfo.InvariantCulture)}: {Message}\n{callstackString}";
        }
    }

    /// <summary>
    /// Exception that is already logged but rethrown to unwind the stack.
    /// </summary>
    public class MetapsiException : System.Exception
    {
        public MetapsiException(CallStack callStack, System.Exception fromException, string description) : base(description, fromException)
        {
            MetapsiCallStack = callStack;
        }

        public MetapsiException(CallStack callStack, System.Exception fromException): base("Internal error, check events log", fromException)
        {
            MetapsiCallStack = callStack;
        }

        public CallStack MetapsiCallStack { get; }
    }
}

namespace Metapsi.Log
{
    /// <summary>
    /// Error as data, with Metapsi-specific callstack & general exception
    /// </summary>
    public class Exception : ILogMessage
    {
        public Exception(System.Exception exception)
        {
            this.exception = exception;
            this.description = string.Empty;
        }

        public Exception(System.Exception exception, string description)
        {
            this.exception = exception;
            this.description = description;
        }

        private System.Exception exception;
        private readonly string description;

        public override string ToString()
        {
            if (string.IsNullOrEmpty(description))
                return this.exception.ToString();

            return $"{description}\n{exception}";
        }
    }

    public class Info : ILogMessage
    {
        public Info(string message)
        {
            this.Message = message;
        }
        public string Message { get; set; }

        public override string ToString()
        {
            return Message;
        }
    }

    public class Error : ILogMessage
    {
        public Error(string message)
        {
            this.message = message;
        }
        private string message { get; set; }

        public override string ToString()
        {
            return message;
        }
    }

    public class Debug : ILogMessage
    {
        public Debug(string message, int managedThreadId)
        {
            this.Message = message;
            this.ManagedThreadId = managedThreadId;
        }

        public string Message { get; set; }
        public int ManagedThreadId { get; set; }

        public override string ToString()
        {
            return $"{ManagedThreadId.ToString().PadRight(10)} {Message}";
        }
    }
}