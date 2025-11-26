using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using static Metapsi.Html.Binding;

namespace Metapsi.Html;

public partial class HtmlInput : IHasEditableValue
{
    /// <summary>
    /// 
    /// </summary>
    public string type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string value { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool @checked { get; set; }
}

public partial class HtmlTextarea : IHasEditableValue
{
    public string value { get; set; }
}

public partial class HtmlSelect : IHasEditableValue
{
    public string value { get; set; }
}

/// <summary>
/// 
/// </summary>
public interface IAutoRegisterBinding : IAutoLoader
{
    /// <summary>
    /// 
    /// </summary>
    Type ControlType { get; }

    /// <summary>
    /// 
    /// </summary>
    Binding GetBinding();
}
