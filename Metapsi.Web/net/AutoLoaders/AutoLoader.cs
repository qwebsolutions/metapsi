using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Metapsi.Web;

public interface IRegisterAppFeature : IAutoLoader
{
    string FeatureName { get; }

    void Register(IEndpointRouteBuilder endpoint, App.Setup appSetup, object configuration);
}