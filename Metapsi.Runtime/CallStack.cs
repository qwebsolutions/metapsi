using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metapsi
{
    public class CallStack
    {
        private IData TriggerEvent { get; set; }

        private List<ICallStep> Steps { get; set; } = new List<ICallStep>();

        public override string ToString()
        {
            if (TriggerEvent == null)
                return string.Empty;

            int indentLevel = 0;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Source event: {TriggerEvent.GetType().FullName} {Metapsi.Serialize.ToJson(TriggerEvent)}");

            foreach (ICallStep callStep in Steps)
            {
                string indentSpace = new string(' ', indentLevel * 2);
                stringBuilder.AppendLine($"{indentSpace}{callStep}");
                indentLevel++;
            }

            return stringBuilder.ToString();
        }

        internal CallStack() { }

        public CallStack(IData triggerEvent)
        {
            this.TriggerEvent = triggerEvent;
        }

        public CallStack(CallStack parent, ExternalOperationStep externalStep)
        {
            this.TriggerEvent = parent.TriggerEvent;
            this.Steps.AddRange(parent.Steps);
            this.Steps.Add(externalStep);
        }

        public CallStack(CallStack parent, EnqueuedStep newStep)
        {
            this.TriggerEvent = parent.TriggerEvent;
            this.Steps.AddRange(parent.Steps);
            this.Steps.Add(newStep);
        }

        internal bool AlreadyAwaitingOnState()
        {
            ICallStep mostRecent = Steps.Last();
            if (!(mostRecent is EnqueuedStep))
                return false;

            EnqueuedStep lastEnqueued = mostRecent as EnqueuedStep;

            int stepsCount = Steps.Count;
            
            for (int i = 0; i < stepsCount-1; i++)
            {
                ICallStep callStep = Steps[i];

                if(callStep is EnqueuedStep)
                {
                    EnqueuedStep enqueuedStep = callStep as EnqueuedStep;
                    if (enqueuedStep.ExecutionQueue == lastEnqueued.ExecutionQueue)
                        return true;
                }
            }
            return false;
        }

        //public static CallStack Empty = new CallStack();
    }

    public interface ICallStep { }

    public class EnqueuedStep : ICallStep
    {
        public ExecutionQueue ExecutionQueue { get; set; }
        public EnqueuedOperation EnqueuedOperation { get; set; }

        public override string ToString()
        {
            return $"{ExecutionQueue.Name} ({ExecutionQueue.State.GetType().FullName}) : {EnqueuedOperation.FunctionCall.MethodInfo.DeclaringType.FullName}.{EnqueuedOperation.FunctionCall.MethodInfo.Name}";
        }
    }

    public class ExternalOperationStep : ICallStep
    {
        public ExternalOperation ExternalOperation { get; set; }
        public string MappingFunction { get; set; }

        public override string ToString()
        {
            return $"{ExternalOperation.Name} -> {MappingFunction}";
        }
    }
}