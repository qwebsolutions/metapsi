using Metapsi.Html;
using Metapsi.Syntax;
using System;

namespace Metapsi.Shoelace;

public static partial class SlNodeExtensions
{
    public static void SlToast(this SyntaxBuilder b, Action<PropsBuilder<SlAlert>> buildProps, params Var<DomElement>[] children)
    {
        ImportShoelaceTag(b, "sl-alert");
        var alert = b.CreateElement("sl-alert", buildProps, children);
        var body = b.GetProperty<DomElement>(b.Document(), "body");
        b.AppendChild(body, alert);
        var customElements = b.GetProperty<object>(b.Self(), "customElements");
        var whenDefined = b.CallOnObject<Promise>(customElements,"whenDefined", b.Const("sl-alert"));
        b.Then(whenDefined, b.Def((SyntaxBuilder b, Var<object> p) =>
        {
            b.CallOnObject(alert, "toast");
        }));
    }
}