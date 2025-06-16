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
        var autoLoaders = inAssemblies.SelectMany(x => x.GetTypes()).Where(x => typeof(IAutoLoader).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract);
        return autoLoaders.ToList();
    }

    public static List<T> FindAll<T>(List<Assembly> inAssemblies)
    {
        var allTTypes = FindAllTypes(inAssemblies).Where(x => typeof(T).IsAssignableFrom(x));
        return allTTypes.Select(x => (T)Activator.CreateInstance(x)).ToList();
    }

    public static List<T> FindAllLoaded<T>()
    {
        return FindAll<T>(AppDomain.CurrentDomain.GetAssemblies().ToList());
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