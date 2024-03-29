﻿using Metapsi.Syntax;
using Metapsi.Ui;
using Metapsi.Dom;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Metapsi.Tutorial;

public interface IServerSideBreakpoint
{
    string AssumedBreakpoint { get; set; }
}


public static class Breakpoint
{
    public static class Name
    {
        public const string S = "sm";

        public const string M = "md";

        public const string L = "lg";

        public const string XL = "xl";

        public const string XXL = "2xl";
    }

    public class Size
    {
        public string Name { get; set; }

        public int Pixels { get; set; }
    }

    public static List<Size> Breakpoints = new List<Size>
    {
        new Size
        {
            Name = "sm",
            Pixels = 640
        },
        new Size
        {
            Name = "md",
            Pixels = 768
        },
        new Size
        {
            Name = "lg",
            Pixels = 1024
        },
        new Size
        {
            Name = "xl",
            Pixels = 1280
        },
        new Size
        {
            Name = "2xl",
            Pixels = 1536
        }
    };
}

public class EditorProps
{
    public string EditorId { get; set; }

    public string Class { get; set; } = "w-full h-72 bg-white";


    public string value { get; set; }

    public string language { get; set; }
}


public class CodeMirrorProps
{
    public string EditorId { get; set; }

    public string value { get; set; }

    public string mode { get; set; }
}

public class MinimapProps
{
    public bool enabled { get; set; }
}

public class MonacoProps
{
    public string EditorId { get; set; }

    public string value { get; set; }

    public string language { get; set; }

    public MinimapProps minimap { get; set; } = new MinimapProps();

}

public static class ServerSideBreakpointExtensions
{
    private const string BreakpointCookie = "bp";

    public static void BreakpointProbingPage(DocumentTag documentTag)
    {
        var titleTag = documentTag.Head.AddChild(new HtmlTag() { Tag = "title" });
        titleTag.AddText("Metapsi - Redirecting ...");

        documentTag.AddJs(delegate (SyntaxBuilder b)
        {
            Var<string> bp = b.AssumeBreakpoint();
            b.RedirectWithBreakpoint(bp);
        });
    }

    public static async Task<TModel> WithBreakpointProbing<TModel>(this HttpContext httpContext, Func<TModel, Task> fillModel) where TModel : IServerSideBreakpoint, new()
    {
        TModel model = new TModel();
        model.AssumedBreakpoint = httpContext.Request.Query["bp"];
        if (!string.IsNullOrEmpty(model.AssumedBreakpoint))
        {
            httpContext.Response.Cookies.Append("bp", model.AssumedBreakpoint);
        }
        else
        {
            model.AssumedBreakpoint = httpContext.Request.Cookies["bp"];
        }
        await fillModel(model);
        return model;
    }

    public static void WithBreakpointProbingPage<TModel>(this DocumentTag documentTag, TModel model, Action<TModel> buildPage) where TModel : IServerSideBreakpoint
    {
        if (string.IsNullOrEmpty(model.AssumedBreakpoint))
        {
            BreakpointProbingPage(documentTag);
            return;
        }
        buildPage(model);
    }

    private static void RedirectWithBreakpoint(this SyntaxBuilder b, Var<string> bp)
    {
        b.SetUrl(b.Concat(b.GetUrl(), b.Const("?bp="), bp));
    }

    private static Var<string> GetWindowBreakpoint(this SyntaxBuilder b)
    {
        return b.CallExternal<string>("Metapsi.Tutorial", "GetWindowBreakpoint", Array.Empty<IVariable>());
    }

    public static Var<bool> HasTouchScreen(this SyntaxBuilder b)
    {
        return b.CallExternal<bool>("Metapsi.Breakpoint", "HasTouchScreen", Array.Empty<IVariable>());
    }

    public static Var<int> WindowWidth(this SyntaxBuilder b)
    {
        return b.GetDynamic(b.Window().As<DynamicObject>(), DynamicProperty.Int("innerWidth"));
    }

    public static Var<int> WindowHeight(this SyntaxBuilder b)
    {
        return b.GetDynamic(b.Window().As<DynamicObject>(), DynamicProperty.Int("innerHeight"));
    }

    public static Var<string> MatchBreakpoint(this SyntaxBuilder b, Var<int> width)
    {
        Var<List<Breakpoint.Size>> breapointsList = b.Const(Breakpoint.Breakpoints);
        Var<Reference<string>> match = b.Ref(b.Const(string.Empty));
        b.Foreach(breapointsList, delegate (SyntaxBuilder b, Var<Breakpoint.Size> bp)
        {
            b.If(b.Get(bp, width, (Breakpoint.Size bp, int width) => width <= bp.Pixels), delegate (SyntaxBuilder b)
            {
                b.If(b.Not(b.HasValue(b.GetRef(match))), delegate (SyntaxBuilder b)
                {
                    b.SetRef(match, b.Get(bp, (Breakpoint.Size x) => x.Name));
                });
            });
        });
        b.If(b.Not(b.HasValue(b.GetRef(match))), delegate (SyntaxBuilder b)
        {
            b.SetRef(match, b.Get(breapointsList, (List<Breakpoint.Size> x) => x.Last().Name));
        });
        return b.GetRef(match);
    }

    public static Var<string> AssumeBreakpoint(this SyntaxBuilder b)
    {
        return b.If(b.HasTouchScreen(), delegate (SyntaxBuilder b)
        {
            Var<List<int>> var = b.NewCollection<int>();
            b.Push(var, b.WindowWidth());
            b.Push(var, b.WindowHeight());
            Var<int> width = b.Get(var, (List<int> x) => x.Min());
            return b.MatchBreakpoint(width);
        }, (SyntaxBuilder b) => b.MatchBreakpoint(b.WindowWidth()));
    }

    public static void RedirectMismatchedBreakpoint(this SyntaxBuilder b, List<string> serverAssumedBreakpoints)
    {
        b.If(b.Not(b.CallExternal<bool>("Metapsi.Breakpoint", "HasQueryParam", new IVariable[1] { b.Const("bp") })), delegate (SyntaxBuilder b)
        {
            Var<string> clientAssumedBreakpoint = b.AssumeBreakpoint();
            b.If(b.Not(b.Includes(b.Const(serverAssumedBreakpoints), clientAssumedBreakpoint)), delegate (SyntaxBuilder b)
            {
                b.RedirectWithBreakpoint(clientAssumedBreakpoint);
            });
        });
    }

    public static void AddRedirectMismatchedBreakpoint(this IHtmlElement htmlElement, List<string> serverAssumedBreakpoints)
    {
        htmlElement.AddJs(delegate (SyntaxBuilder b)
        {
            b.RedirectMismatchedBreakpoint(serverAssumedBreakpoints);
        });
    }
}
