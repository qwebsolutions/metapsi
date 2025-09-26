using Metapsi;
using Metapsi.Html;
using Microsoft.AspNetCore.Http;
using System;

public static partial class Scenario
{
    public static IResult PageResult()
    {
        return Page.Result(
            DateTime.UtcNow,
            (DateTime utc) =>
            {
                return HtmlBuilder.FromEmpty(
                    b =>
                    {
                        b.BodyAppend(b.Text(utc.ItalianFormat()));
                    });
            });
    }
}
