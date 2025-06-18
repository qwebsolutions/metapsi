using Metapsi.Html;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi;

/// <summary>
/// Namespace-like class for a self-contained app
/// </summary>
public static class App
{
    /// <summary>
    /// A technical entity that contains all the feature-related data in the application.
    /// It represents the actual serializable values the app runs with after it is attached to the web server.
    /// While the App.Setup represents the logic, the App.Map allows feature self-discovery, as it contains absolute paths
    /// </summary>
    public class Map
    {
        /// <summary>
        /// This is the data that features 'publish' for cross-feature access
        /// </summary>
        public Dictionary<string, object> Features { get; set; } = new Dictionary<string, object>();
    }

    /// <summary>
    /// A set of app features that represent the application definition. Self-contained, not serializable
    /// </summary>
    public class Setup
    {
        public string InstanceName { get; set; } = Guid.NewGuid().ToString();
        public Dictionary<string, Feature> Features { get; set; } = new();
    }

    /// <summary>
    /// The untyped configuration of a feature. Multiple features make up the <see cref="App.Setup"/>
    /// </summary>
    public class Feature
    {
        public object Configuration { get; set; }
        public System.Func<System.Func<RouteDescription, string>, object> GetDetails { get; set; }
    }

    /// <summary>
    /// Configures a new <see cref="App.Setup"/>
    /// </summary>
    /// <param name="configure"></param>
    /// <returns></returns>
    public static App.Setup New(System.Action<ConfigurationBuilder<App.Setup>> configure)
    {
        return ConfigurationBuilder.Configure(configure);
    }

    /// <summary>
    /// Converts the application logic to a serializable entity that allows feature discovery.
    /// </summary>
    /// <param name="appSetup"></param>
    /// <param name="findRoute"></param>
    /// <returns></returns>
    public static App.Map GetAppMap(this App.Setup appSetup, System.Func<RouteDescription, string> findRoute)
    {
        Map appMap = new Map();

        foreach (var featureConfiguration in appSetup.Features)
        {
            if (featureConfiguration.Value != null)
            {
                // HttpContext is needed for API names
                if (featureConfiguration.Value.GetDetails != null)
                {
                    appMap.Features[featureConfiguration.Key] = featureConfiguration.Value.GetDetails(findRoute);
                }
            }
        }

        return appMap;
    }
}

public static class AppMapExtensions
{
    /// <summary>
    /// Adds a feature configuration to the application
    /// </summary>
    /// <param name="b"></param>
    /// <param name="featureName"></param>
    /// <param name="feature"></param>
    public static void AddFeature(this ConfigurationBuilder<App.Setup> b, string featureName, App.Feature feature)
    {
        b.Configuration.Features.Add(featureName, feature);
    }

    internal static Reference<App.Map> appMapReference = new Reference<App.Map>();

    /// <summary>
    /// Sets the <see cref="App.Map"/> in a known client-side 'static-like' placeholder
    /// </summary>
    /// <param name="b"></param>
    /// <param name="appMap"></param>
    public static void SetAppMap(SyntaxBuilder b, App.Map appMap)
    {
        b.SetRef(b.Const(appMapReference), b.Const(appMap));
    }

    /// <summary>
    /// Gets the <see cref="App.Map"/> from the known client-side 'static-like' placeholder
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<App.Map> GetAppMap(SyntaxBuilder b)
    {
        return b.GetRef(b.Const(appMapReference));
    }

    /// <summary>
    /// Returns the feature details of <paramref name="featureName"/> as <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="featureName"></param>
    /// <returns></returns>
    public static Var<T> GetFeature<T>(this SyntaxBuilder b, string featureName)
    {
        return b.GetFeature<T>(b.Const(featureName));
    }

    /// <summary>
    /// Returns the feature details of <paramref name="featureName"/> as <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="featureName"></param>
    /// <returns></returns>
    public static Var<T> GetFeature<T>(this SyntaxBuilder b, Var<string> featureName)
    {
        var features = b.Get(GetAppMap(b), x => x.Features);
        return b.GetProperty<T>(features, featureName);
    }
}
