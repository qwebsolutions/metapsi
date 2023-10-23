using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public class Icon
{
    public string Name { get; set; }
}

public class IconButton
{
    public string Name { get; set; }
}

public static partial class Control
{
    public static Var<HyperNode> Icon(this LayoutBuilder b, Var<string> iconName)
    {
        var icon = b.SlNode("sl-icon");
        b.SetAttr(icon, new DynamicProperty<string>("name"), iconName);
        return icon;
    }

    public static Var<HyperNode> Icon(this LayoutBuilder b, string iconName)
    {
        return b.Icon(b.Const(iconName));
    }

    public static Var<HyperNode> IconButton(this LayoutBuilder b, string iconName)
    {
        var iconButton = b.SlNode("sl-icon-button");
        b.SetAttr(iconButton, new DynamicProperty<string>("name"), iconName);

        return iconButton;
    }
}
