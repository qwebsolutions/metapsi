using System.Collections.Generic;
using System.Reflection;
using System;
using System.Linq;

namespace Metapsi;

public interface IAutoLoader
{
}

public static partial class AutoLoader
{
    public static List<Type> FindAllTypes(List<Assembly> inAssemblies)
    {
        List<Type> autoLoaders = new List<Type>();
        foreach (var assembly in inAssemblies)
        {
            try
            {
                autoLoaders.AddRange(assembly.GetTypes().Where(x => typeof(IAutoLoader).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract));
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        return autoLoaders;
    }

    public static List<T> FindAll<T>(List<Assembly> inAssemblies)
    {
        var allTTypes = FindAllTypes(inAssemblies).Where(x => typeof(T).IsAssignableFrom(x));
        return allTTypes.Select(x => (T)Activator.CreateInstance(x)).ToList();
    }

    public static List<T> FindAllLoaded<T>()
    {
        return FindAll<T>(AppDomain.CurrentDomain.GetAssemblies().Where(x => !x.GetName().Name.StartsWith("System.")).ToList());
    }
}

public class Initializer
{
    public Dictionary<string, Action> Actions { get; set; } = new Dictionary<string, Action>();

    public void RunAll()
    {
        foreach (var action in Actions)
        {
            action.Value();
        }
    }
}