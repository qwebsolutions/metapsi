using System;

namespace Metapsi.Ui;

public interface IHasSidePanel
{
    bool ShowSidePanel { get; set; }
}

public interface IHasValidationPanel
{
    string ValidationMessage { get; set; }
}

public interface IHasLoadingPanel
{
    bool IsLoading { get; set; }
}

public static class Menu
{
    public class Entry
    {
        public string Code { get; set; }
        public string Label { get; set; }
        public string Href { get; set; }
        public string SvgIcon { get; set; } = string.Empty;
    }
}

public enum AuthType
{
    Oidc,
    Windows
}

public class User
{
    public string Name { get; set; }
    public AuthType AuthType { get; set; }
}

public interface IHasUser
{
    User User { get; set; }
}

public static class UserExtensions
{
    public static bool IsSignedIn(this Metapsi.Ui.User user)
    {
        if (user == null)
            return false;

        return !string.IsNullOrEmpty(user.Name);
    }
}



public interface IApiResponse
{
    public string ResultCode { get; set; }
    public string ErrorMessage { get; set; }
}

public class ApiResponse : IApiResponse
{
    public string ResultCode { get; set; } = ApiResultCode.Ok;
    public string ErrorMessage { get; set; }
}

public class ApiResultCode
{
    public const string Error = "Error";
    public const string Ok = "Ok";
}



public class ServerActionInput
{
    public string SerializedModel { get; set; } = string.Empty;
    public string SerializedPayload { get; set; } = string.Empty;
    public string QualifiedHandlerClass { get; set; } = string.Empty;
    public string HandlerMethod { get; set; } = string.Empty;
}

public class ServerActionResponse : ApiResponse
{
    public string SerializedModel { get; set; } = string.Empty;
}

public static class ServerActionEndpoint
{
    public static Request<ServerActionResponse, ServerActionInput> ServerAction { get; set; } = new(nameof(ServerAction));
}