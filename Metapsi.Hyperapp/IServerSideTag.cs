namespace Metapsi.Hyperapp
{
    public interface IServerSideTag
    {
    }

    public record LinkTag(string rel, string href) : IServerSideTag;
    public record ScriptTag(string src) : IServerSideTag;
}