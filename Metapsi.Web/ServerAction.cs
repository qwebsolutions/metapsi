using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;


namespace Metapsi;

public static partial class ServerAction
{
    internal class ServerActionDelegate
    {
        internal Delegate Delegate { get; set; }

        // Store types once so we avoid reflection on every call
        internal List<Type> ParameterTypes { get; set; } = new List<Type>();
        internal Type ReturnType { get; set; }
    }

    private static TaskQueue<Dictionary<string, ServerActionDelegate>> actionsQueue = new(new Dictionary<string, ServerActionDelegate>());

    public static string PostPath = "/_Server_Action_";

    public class Call
    {
        public string MethodName { get; set; }
        public List<string> Parameters { get; set; }
    }

    public static void Store(Delegate action)
    {
        var _ = actionsQueue.Enqueue(async (actions) =>
        {
            if (!actions.ContainsKey(action.Method.Name))
            {
                ServerActionDelegate serverActionDelegate = new ServerActionDelegate()
                {
                    Delegate = action
                };

                foreach (var parameter in action.Method.GetParameters())
                {
                    serverActionDelegate.ParameterTypes.Add(parameter.ParameterType);
                }

                actions[action.Method.Name] = serverActionDelegate;
            }
        });
    }

    internal static async Task<ServerActionDelegate> Get(string name)
    {
        return await actionsQueue.Enqueue(async (actions) =>
        {
            var found = actions.TryGetValue(name, out ServerActionDelegate action);
            if (!found)
            {
                throw new Exception($"Action {name} not registered!");
            }
            return action;
        });
    }

    public static async Task<dynamic> Run(ServerAction.Call serverCall)
    {
        var serverActionDelegate = await ServerAction.Get(serverCall.MethodName);
        object[] parameters = new object[serverActionDelegate.ParameterTypes.Count];
        for (int i = 0; i < serverActionDelegate.ParameterTypes.Count; i++)
        {
            parameters[i] = Metapsi.Serialize.FromJson(serverActionDelegate.ParameterTypes[i], serverCall.Parameters[i]);
        }

        var result = serverActionDelegate.Delegate.DynamicInvoke(parameters);
        if (result is Task)
        {
            await (Task)result;
            result = ((dynamic)result).Result;
        }

        return result;
    }
}