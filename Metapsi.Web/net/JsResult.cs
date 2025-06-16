using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi;

internal class JsResult : IResult
{
    internal Metapsi.Syntax.Module module;

    internal JsResult(Metapsi.Syntax.Module module)
    {
        this.module = module;
    }

    public async Task ExecuteAsync(HttpContext httpContext)
    {
        try
        {
            var js = module.ToJs();
            httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.JavaScript;
            httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(js);
            httpContext.Response.StatusCode = StatusCodes.Status200OK;
            await httpContext.Response.WriteAsync(js);
        }
        catch (Exception ex)
        {
#if DEBUG
            var builder = new ModuleBuilder();
            builder.Call(builder.AddFunction("main", b =>
            {
                b.Call(new Var<Action<string>>("alert"), b.Const(ex.Message));
            }));
#endif
            
        }
    }
}

public static class Js
{
    public static IResult Result(this Action<SyntaxBuilder> b)
    {
        ModuleBuilder moduleBuilder = new ModuleBuilder();
        var main = moduleBuilder.AddFunction("main", b);
        moduleBuilder.Call(main);
        return new JsResult(moduleBuilder.Module);
    }
}