using Metapsi.Html;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Web;

public class JsModuleProvider
{
    internal Dictionary<string, Func<Module>> modules { get; set; } = new();

    internal static JsModuleProvider Singleton { get; set; } = new JsModuleProvider();
}

public class JsModuleProviderOptions
{
    internal Dictionary<string, Func<Module>> modules { get; set; } = new();
}

public static partial class JsModuleProviderExtensions
{
    public static void AddModule(this JsModuleProviderOptions options, string name, Func<Module> getModule)
    {
        options.modules.Add(name, getModule);
    }

    public static void AddModule(this JsModuleProviderOptions options, string name, Module module)
    {
        options.AddModule(name, () => module);
    }

    public static void AddModule(this JsModuleProviderOptions options, IModuleResource module)
    {
        options.AddModule(module.ModulePath, module.Module);
    }

    public static void AddModule<T>(this JsModuleProviderOptions options)
        where T : IModuleResource, new()
    {
        var module = new T();
        options.AddModule(module);
    }

    public static void AutoRegisterFrom(this JsModuleProviderOptions options, System.Reflection.Assembly assembly)
    {
        var allModuleResources = AutoLoader.FindAll<Metapsi.Html.IModuleResource>(new List<System.Reflection.Assembly>() { assembly });
        foreach (var resource in allModuleResources)
        {
            options.AddModule(resource.ModulePath, resource.Module);
        }
    }
}
