using System.Collections.Generic;
using System.Reflection;
using System;
using System.Linq;
using System.Diagnostics.Contracts;

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
                foreach (var type in assembly.GetTypes())
                {
                    try
                    {
                        if (type.IsInterface) continue;
                        if (type.IsAbstract) continue;
                        if (typeof(IAutoLoader).IsAssignableFrom(type))
                        {
                            autoLoaders.Add(type);
                        }
                        //autoLoaders.AddRange(assembly.GetTypes().Where(x => typeof(IAutoLoader).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract));
                    }
                    catch(Exception ex)
                    {

                    }
                }
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
        var clientLibraries = AppDomain.CurrentDomain.GetAssemblies().Where(x => !IsSystemLibrary(x) && !x.IsDynamic).ToList();
        return FindAll<T>(clientLibraries);
    }

    private static bool IsSystemLibrary(Assembly assembly)
    {
        var assemblyName = assembly.GetName().Name;
        if (assemblyName.StartsWith("System")) return true;
        if (assemblyName.StartsWith("Microsoft")) return true;
        if(assemblyName == "mscorlib")
        {
            return true;
        }

        return false;
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