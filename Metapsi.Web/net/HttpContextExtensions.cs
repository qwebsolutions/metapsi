using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading.Tasks;
using static Metapsi.WebServer;

namespace Metapsi
{
    public static class HttpContextExtensions
    {
        //public static string EntityId(this HttpContext httpContext)
        //{
        //    return httpContext.Request.Path.Value.Split("/").Last();
        //}

        //public static Metapsi.Ui.User User(this HttpContext httpContext)
        //{
        //    Metapsi.Ui.User user = new();

        //    if (!string.IsNullOrEmpty(httpContext.User.Identity.Name))
        //    {
        //        //user.AuthType = AuthType.Windows;
        //        user.Name = httpContext.User.Identity.Name;
        //    }
        //    else
        //    {
        //        var claim = httpContext.User.FindFirst(System.Security.Claims.ClaimTypes.GivenName);
        //        if (claim != null)
        //            user.Name = claim.Value;

        //        claim = httpContext.User.FindFirst(System.Security.Claims.ClaimTypes.Surname);
        //        if (claim != null)
        //        {
        //            user.Name += " " + claim.Value;
        //        }

        //        //user.AuthType = AuthType.Oidc;
        //    }

        //    if (string.IsNullOrEmpty(user.Name))
        //    {
        //        var claim = httpContext.User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
        //        if (claim != null)
        //        {
        //            user.Name = claim.Value;
        //        }
        //    }

        //    if (httpContext.User.Identity != null)
        //    {
        //        if (httpContext.User.Identity.AuthenticationType != null)
        //        {
        //            switch (httpContext.User.Identity.AuthenticationType.ToLower())
        //            {
        //                case "ldap":
        //                    user.AuthType = Metapsi.Ui.AuthType.Windows;
        //                    break;
        //                case "oidc":
        //                    user.AuthType = Metapsi.Ui.AuthType.Oidc;
        //                    break;
        //            }
        //        }
        //    }

        //    return user;
        //}

        //public static async Task<string> Payload(this HttpContext httpContext)
        //{
        //    if (httpContext.Request.Method.ToLower() == "get")
        //        return string.Empty;

        //    var form = await httpContext.Request.ReadFormAsync();
        //    if(form.ContainsKey("payload"))
        //        return form["payload"];

        //    return string.Empty;
        //}

        //public static async Task<T> Payload<T>(this HttpContext httpContext)
        //{
        //    var stringPayload = await httpContext.Payload();
        //    if (string.IsNullOrEmpty(stringPayload))
        //        return default(T);

        //    return Metapsi.Serialize.FromJson<T>(stringPayload);
        //}

        //public static async Task<string> UiState(this HttpContext httpContext)
        //{
        //    if (httpContext.Request.Method.ToLower() == "get")
        //        return string.Empty;

        //    var form = await httpContext.Request.ReadFormAsync();
        //    if (form.ContainsKey("uistate"))
        //        return form["uistate"];

        //    return string.Empty;
        //}

        //public const string RootPathHeaderKey = "X-RootPath";

        //public static string GetHostedRootPath(this HttpContext httpContext)
        //{
        //    if (httpContext.Request.Headers.ContainsKey(RootPathHeaderKey))
        //    {
        //        return $"{httpContext.Request.Headers["X-Forwarded-Proto"]}://{httpContext.Request.Headers.Host}{httpContext.Request.Headers[RootPathHeaderKey]}";
        //    }

        //    return string.Empty;
        //}

        //public static string GetRelativeRootPath(this HttpContext httpContext)
        //{
        //    if (httpContext.Request.Headers.ContainsKey(RootPathHeaderKey))
        //    {
        //        return httpContext.Request.Headers[RootPathHeaderKey];
        //    }

        //    return string.Empty;
        //}
    }
}