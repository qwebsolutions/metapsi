using Metapsi.Hyperapp;
using Metapsi.Syntax;
using static Metapsi.Html.Binding;

namespace Metapsi.Html;

public partial class HtmlInput : IHasEditableValue<string>, IHasEditableValue<bool>
{
    /// <summary>
    /// 
    /// </summary>
    public string value { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool @checked { get; set; }
}

public static class HtmlAccessors
{
    public static void RegisterHtmlAccessors()
    {
        Binding.Registry.Register<HtmlInput, string>(
            (b, value) =>
            {
                b.Set(x => x.value, value);
            },
            (b, update) =>
            {
                b.OnEventAction("input", b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
                {
                    b.Call(
                        update,
                        model,
                        b.Get(b.Get(e, x => x.currentTarget).As<HTMLInputElement>(), x => x.value));
                    return b.Clone(model);
                }));
            });

        Binding.Registry.Register<HtmlInput, bool>(
            (b, value) =>
            {
                b.Set(x => x.@checked, value);
            },
            (b, update) =>
            {
                b.OnEventAction("click", b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
                {
                    b.Call(
                        update,
                        model,
                        b.Get(b.Get(e, x => x.currentTarget).As<HTMLInputElement>(), x => x.@checked));
                    return b.Clone(model);
                }));
            });
    }
}
