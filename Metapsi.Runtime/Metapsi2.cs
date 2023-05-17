using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi
{
    public interface IData
    {

    }

    public class ApplicationRevived : IData
    {
        //public int StatesCount { get; set; }
        public int EventMappingsCount { get; set; }
        public int ImplementationGroupsCount { get; set; }
        public int ImplementationsCount { get; set; }
    }

    public class ApplicationIsShuttingDown : IData
    {

    }

    public class ExternalOperation
    {
        public string Name { get; private set; }
        public ExternalOperationType ExternalOperationType { get; private set; }

        public ExternalOperation(string name, ExternalOperationType externalOperationType)
        {
            Name = name;
            ExternalOperationType = externalOperationType;
        }
    }

    public class Command : ExternalOperation
    {
        public Command(string name) : base(name, ExternalOperationType.CommandOperation) { }
    }

    public class Command<TParam1> : ExternalOperation
    {
        public Command(string name) : base(name, ExternalOperationType.CommandOperation) { }
    }

    public class Command<TParam1, TParam2> : ExternalOperation
    {
        public Command(string name) : base(name, ExternalOperationType.CommandOperation) { }
    }

    public class Command<TParam1, TParam2, TParam3> : ExternalOperation
    {
        public Command(string name) : base(name, ExternalOperationType.CommandOperation) { }
    }

    public class Command<TParam1, TParam2, TParam3, TParam4> : ExternalOperation
    {
        public Command(string name) : base(name, ExternalOperationType.CommandOperation) { }
    }

    public class Command<TParam1, TParam2, TParam3, TParam4, TParam5> : ExternalOperation
    {
        public Command(string name) : base(name, ExternalOperationType.CommandOperation) { }
    }

    public class Command<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> : ExternalOperation
    {
        public Command(string name) : base(name, ExternalOperationType.CommandOperation) { }
    }

    public class Request<TResult> : ExternalOperation
    {
        public Request(string name) : base(name, ExternalOperationType.RequestOperation) { }
    }

    public class Request<TResult, TParam1> : ExternalOperation
    {
        public Request(string name) : base(name, ExternalOperationType.RequestOperation) { }
    }

    public class Request<TResult, TParam1, TParam2> : ExternalOperation
    {
        public Request(string name) : base(name, ExternalOperationType.RequestOperation) { }
    }

    public class Request<TResult, TParam1, TParam2, TParam3> : ExternalOperation
    {
        public Request(string name) : base(name, ExternalOperationType.RequestOperation) { }
    }

    public class Request<TResult, TParam1, TParam2, TParam3, TParam4> : ExternalOperation
    {
        public Request(string name) : base(name, ExternalOperationType.RequestOperation) { }
    }

    public class Request<TResult, TParam1, TParam2, TParam3, TParam4, TParam5> : ExternalOperation
    {
        public Request(string name) : base(name, ExternalOperationType.RequestOperation) { }
    }

    public class FunctionCall
    {
        public System.Reflection.MethodInfo MethodInfo { get; set; }
        public object Target { get; set; }
        public List<object> Parameters = new List<object>();

        public async Task<Task> CallAsyncWith(params object[] firstParameters)
        {
            object[] parameters = new object[Parameters.Count + (firstParameters.Length)];
            int index = 0;
            foreach (object parameter in firstParameters)
            {
                parameters[index] = parameter;
                index++;
            }

            foreach (object businessParameter in Parameters)
            {
                parameters[index] = businessParameter;
                index++;
            }
            Task asTask = (Task)MethodInfo.Invoke(Target, parameters);
            await asTask;
            return asTask;// Return task itself, so you can get the result from outside, if needed
        }
    }



    public class ExternalOperationMapping
    {
        public string RequestName { get; set; }
        public System.Reflection.MethodInfo ImplementationMethod { get; set; }
        public object Target { get; set; } // used in case of closures
    }

    public interface IEventMapping
    {
        public bool CheckGuard(IData data);
        public void Run(IData data);
    }

    public class EventMapping<TEventData> : IEventMapping where TEventData : IData
    {
        public Type EventType { get; set; }
        public Func<TEventData, bool> Guard { get; set; }
        public Action<EventContext<TEventData>> OnEvent { get; set; }

        public ApplicationSetup ApplicationSetup { get; set; }

        public bool CheckGuard(IData data)
        {
            if (Guard == null)
                return true;

            return Guard((TEventData)data);
        }

        public void Run(IData data)
        {
            OnEvent(new EventContext<TEventData>(ApplicationSetup, (TEventData)data));
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(Guard!=null)
            {
                stringBuilder.AppendLine($"Guard: {Guard.Method.Name}");
            }
            stringBuilder.AppendLine($"Handler: {OnEvent.Method.Name}");
            return stringBuilder.ToString();
        }
    }

    /// <summary>
    /// rc.Using() generates one of these
    /// </summary>
    public interface IEnqueuer
    {
        public ApplicationSetup ApplicationSetup { get; set; }
        public ImplementationGroup ImplementationGroup { get; set; }
        public ExecutionQueue ExecutionQueue { get; }
    }

    public static class ApplicationBuilder
    {
        public static string ExeName()
        {
            var serviceName = System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location);
            return serviceName;
        }

        public static ApplicationSetup New()
        {
            return ApplicationSetup.New();
        }

        public static TBusinessState AddBusinessState<TBusinessState>(
            this ApplicationSetup applicationSetup,
            TBusinessState businessState)
        {
            applicationSetup.MapEvent<ApplicationRevived>(e =>
            {
                e.Create(businessState);
            });

            return businessState;
        }
    }

    public enum ExternalOperationType
    {
        CommandOperation,
        RequestOperation
    }

    public abstract class EnqueuedOperation
    {
        public Guid Id { get; set; }
        public ImplementationGroup ImplementationGroup { get; set; }
        public CallStack CallStack { get; set; }
        public FunctionCall FunctionCall { get; set; }

        public Task OperationDone = new Task(() => { });

        internal static TOperationType CreateOperation<TOperationType>(
            ImplementationGroup implementationGroup,
            CallStack parentCallStack,
            ExecutionQueue executionQueue,
            System.Reflection.MethodInfo methodInfo,
            object target,
            params object[] parameters)
            where TOperationType : EnqueuedOperation, new()
        {
            FunctionCall functionCall = new FunctionCall()
            {
                MethodInfo = methodInfo,
                Target = target,
                Parameters = parameters.ToList()
            };

            TOperationType enqueuedOperation = new TOperationType()
            {
                Id = Guid.NewGuid(),
                FunctionCall = functionCall,
                ImplementationGroup = implementationGroup
            };

            enqueuedOperation.CallStack = new CallStack(parentCallStack, new EnqueuedStep()
            {
                EnqueuedOperation = enqueuedOperation,
                ExecutionQueue = executionQueue,
            });

            return enqueuedOperation;
        }
    }

    internal class EnqueuedCommand : EnqueuedOperation { }
    internal class EnqueuedRequest : EnqueuedOperation
    {
        public object Result { get; set; }
    }

    public class RoutingPassingContext
    {
        public object RoutedRequestFunction { get; set; }
        public Task ResultReady = new Task(() => { });
        public object Result { get; set; }
    }

    public class TResponse<TResultData>
    {
        public TResultData Data { get; set; }
        public Exception Exception { get; set; }

        public bool Success => Exception == null;
    }

    public class RequestRoutingContext : RoutingContext
    {
        public RequestRoutingContext(ApplicationSetup applicationSetup, FunctionCall functionCall, CallStack parentCallStack) : base(applicationSetup, functionCall, parentCallStack)
        {

        }
    }

    public class CommandRoutingContext : RoutingContext
    {
        public CommandRoutingContext(ApplicationSetup applicationSetup, FunctionCall functionCall, CallStack parentCallStack) : base(applicationSetup, functionCall, parentCallStack)
        {

        }
    }
}