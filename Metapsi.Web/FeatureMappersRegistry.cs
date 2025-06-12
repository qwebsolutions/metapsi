using System.Collections.Generic;

namespace Metapsi;

//public class FeatureMapperRegistry
//{
//    public Dictionary<string, System.Action<App.Setup, object>> RegisterActions { get; set; } = new();
//}

public static class FeatureMapperExtensions
{
    //public static void OnRegisterFeature<TFeature>(
    //    this FeatureMapperRegistry mappers,
    //    string featureName, System.Action<App.Setup, TFeature> onRegister)
    //    where TFeature : class
    //{
    //    mappers.RegisterActions[featureName] = (app, featureConfiguration) => onRegister(app, featureConfiguration as TFeature);
    //}

    //private static System.Action<TFeature> GetOnRegister<TFeature>(FeatureMapperRegistry mappers, App.Setup app, string featureName)
    //{
    //    if (mappers.RegisterActions.TryGetValue(featureName, out var action))
    //    {
    //        return (TFeature featureConfiguration) => action(app, featureConfiguration);
    //    }

    //    throw new System.Exception($"Feature {featureName} has no registration handler");
    //}

    //public static void Register<TFeature>(this FeatureMapperRegistry mappers, string featureName, App.Setup app, TFeature feature)
    //{
    //    GetOnRegister<TFeature>(mappers, app, featureName)(feature);
    //}
}
