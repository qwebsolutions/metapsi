using Metapsi;
using Metapsi.Ui;
using System;

public static partial class Render
{

    public class Homepage : HtmlPage<Handler.Home.Model>
    {
        public override IHtmlNode GetHtml(Handler.Home.Model dataModel)
        {
            var html = new HtmlTag("html");
            var body = html.AddChild(new HtmlTag("body"));

            foreach (var solution in dataModel.Solutions)
            {
                var link = body.AddChild(new HtmlTag("a").AddAttribute("href", Metapsi.Route.Path<Metapsi.Live.Route.Sln, Guid>(solution.Id)));
                link.AddChild(new HtmlText(solution.Path));
            }

            return html;
        }
    }
}