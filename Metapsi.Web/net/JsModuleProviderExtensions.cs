using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace Metapsi.Web;

public static partial class JsModuleProviderExtensions
{
    public static void AddJsModules(
        this IServiceCollection services,
        Action<JsModuleProviderOptions> register)
    {
        services.TryAddSingleton(JsModuleProvider.Singleton);
        JsModuleProviderOptions options = new JsModuleProviderOptions();
        register(options);
        foreach (var module in options.modules)
        {
            JsModuleProvider.Singleton.modules.Add(module.Key, module.Value);
        }
    }
}
