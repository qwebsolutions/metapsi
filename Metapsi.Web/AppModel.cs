﻿using Metapsi.Html;
using System;
using System.Collections.Generic;

namespace Metapsi;


public static class App
{
    /// <summary>
    /// A 'technical' model that represents all the feature-related data in the application
    /// </summary>
    public class Model
    {
        /// <summary>
        /// This is the data that features 'publish' for cross-feature access
        /// </summary>
        public Dictionary<string, object> FeatureModels { get; set; } = new Dictionary<string, object>();
    }

    /// <summary>
    /// The container off all app features
    /// </summary>
    public class Setup
    {
        public string InstanceName { get; set; } = Guid.NewGuid().ToString();
        public Dictionary<string, Feature> Features { get; set; } = new();
    }

    /// <summary>
    /// The setup actions to wire up a feature
    /// </summary>
    public class Feature
    {
        public object Configuration { get; set; }
        public System.Func<System.Func<RouteDescription, string>, object> GetData { get; set; }
        //public System.Action<HtmlBuilder, App.Model> Render { get; set; }
    }

    public static App.Setup New(System.Action<ConfigurationBuilder<App.Setup>> configure)
    {
        return ConfigurationBuilder.Configure(configure);
    }

    //public static void FillUrlAppKey(this Metapsi.App.Model model, string urlKey, Func<RouteDescription, string> findUrl)
    //{
    //    model.FeatureModels[urlKey] = findUrl(RouteDescription.New(urlKey));
    //}

    //public static App.Model MapHandlers(this App.Setup app, FeatureMapperRegistry mappers)
    //{
    //    var appModel = new App.Model();
    //    foreach (var featureConfiguration in app.Features)
    //    {
    //        if (featureConfiguration.Value.Register != null)
    //        {
    //            featureConfiguration.Value.Register(mappers);
    //        }
    //    }

    //    return appModel;
    //}

    public static App.Model GetAppModel(this App.Setup appSetup, System.Func<RouteDescription, string> findRoute)
    {
        Model model = new Model();

        foreach (var featureConfiguration in appSetup.Features)
        {
            if (featureConfiguration.Value != null)
            {
                // HttpContext is needed for API names
                if (featureConfiguration.Value.GetData != null)
                {
                    model.FeatureModels[featureConfiguration.Key] = featureConfiguration.Value.GetData(findRoute);
                }
            }
        }

        return model;
    }

    public static App.Model GetAppModel(this App.Setup appSetup, string rootUrl, System.Func<RouteDescription, string> findRoute)
    {
        Model model = new Model();
        model.FeatureModels["root-url"] = rootUrl;

        foreach (var featureConfiguration in appSetup.Features)
        {
            if (featureConfiguration.Value != null)
            {
                // HttpContext is needed for API names
                if (featureConfiguration.Value.GetData != null)
                {
                    model.FeatureModels[featureConfiguration.Key] = featureConfiguration.Value.GetData(findRoute);
                }
            }
        }

        return model;
    }
}
