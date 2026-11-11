using Metapsi.Html;
using Metapsi.Syntax;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.Web;

public interface IResourceWriter
{
    Task WriteAsync(
        string package, 
        string version, 
        string fileName, 
        CfHttpResponse response,
        IResourceResolver resourceResolver);
}
