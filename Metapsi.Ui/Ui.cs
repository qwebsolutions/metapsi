using System;
using System.Collections.Generic;
using System.Text;

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

public interface IHtmlNode { }

public interface IHtmlTag
{
    HtmlTag ToTag();
}

public class HtmlTag : IHtmlNode, IHtmlTag
{
    public string Tag { get; set; } = string.Empty;
    public Dictionary<string, string> Attributes { get; set; } = new();
    public List<IHtmlNode> Children { get; set; } = new();

    public HtmlTag() { }

    public HtmlTag(string tag)
    {
        this.Tag = tag;
    }

    public HtmlTag ToTag()
    {
        return this;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        HtmlWriters.HtmlTag(
            builder,
            this,
            (b, c) =>
            {
                b.Append(c.ToString());
            });
        return builder.ToString();
    }
}

public class HtmlText : IHtmlNode
{
    public string Text { get; set; } = string.Empty;

    public HtmlText() { }

    public HtmlText(string text)
    {
        this.Text = text;
    }

    public override string ToString()
    {
        return this.Text;
    }
}

public static class HtmlNodeExtensions
{
    public static HtmlTag AddChild(this HtmlTag tag, IHtmlTag child)
    {
        return tag.AddChild(child.ToTag());
    }

    public static TChild AddChild<TChild>(this HtmlTag tag, TChild child)
        where TChild : IHtmlNode
    {
        if (tag.Children == null)
            tag.Children = new List<IHtmlNode>();

        tag.Children.Add(child);
        return child;
    }

    public static HtmlTag AddAttribute(this HtmlTag tag, string name, string value)
    {
        tag.Attributes[name] = value;
        return tag;
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