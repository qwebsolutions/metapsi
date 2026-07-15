using System;

namespace Metapsi.Html;

public class InternalStylesheetDependency : IDependency, IDependencyDefaultImport
{
    private readonly Action<CssBuilder> build;

    public InternalStylesheetDependency(System.Action<CssBuilder> build)
    {
        this.build = build;
    }

    public string DependencyId => build.Method.Name;

    public void Import(HtmlBuilder b)
    {
        b.HeadAppend(b.HtmlStyleSheet(build));
    }
}

public static class InternalStylesheetExtensions
{
    public static void RequireInternalStylesheet(this ICanRequireDependency b, Action<CssBuilder> build)
    {
        b.Require(new InternalStylesheetDependency(build));
    }
}
