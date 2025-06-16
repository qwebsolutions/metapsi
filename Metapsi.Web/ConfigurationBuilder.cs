using System;

namespace Metapsi;


public class ConfigurationBuilder<TConfiguration>
    where TConfiguration : class, new()
{
    public TConfiguration Configuration { get; set; } = new TConfiguration();
}

public static class ConfigurationBuilder
{
    public static TConfiguration Configure<TConfiguration>(this ConfigurationBuilder<TConfiguration> b, Action<ConfigurationBuilder<TConfiguration>> configure)
        where TConfiguration : class, new()
    {
        if (configure != null)
        {
            configure(b);
        }
        return b.Configuration;
    }

    public static TConfiguration Configure<TConfiguration>(Action<ConfigurationBuilder<TConfiguration>> configure)
        where TConfiguration : class, new()
    {
        return new ConfigurationBuilder<TConfiguration>().Configure(configure);
    }
}