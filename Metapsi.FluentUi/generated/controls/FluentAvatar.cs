using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentAvatar
{
    public static class Slot
    {
    }
}
public static partial class FluentAvatarExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentAvatar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentAvatar>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-avatar", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentAvatar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentAvatar>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentAvatar(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentAvatar(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentAvatar(b => { }, children);
    }
    public static void SetActiveActive(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("active"), b.Const("active"));
    }
    public static void SetActiveInactive(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("active"), b.Const("inactive"));
    }
    public static void SetShapeCircular(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("circular"));
    }
    public static void SetShapeSquare(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("square"));
    }
    public static void SetAppearanceRing(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("ring"));
    }
    public static void SetAppearanceShadow(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("shadow"));
    }
    public static void SetAppearanceRingShadow(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("ring-shadow"));
    }
    public static void SetSize16(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(16));
    }
    public static void SetSize20(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(20));
    }
    public static void SetSize24(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(24));
    }
    public static void SetSize28(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(28));
    }
    public static void SetSize32(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(32));
    }
    public static void SetSize36(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(36));
    }
    public static void SetSize40(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(40));
    }
    public static void SetSize48(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(48));
    }
    public static void SetSize56(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(56));
    }
    public static void SetSize64(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(64));
    }
    public static void SetSize72(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(72));
    }
    public static void SetSize96(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(96));
    }
    public static void SetSize120(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(120));
    }
    public static void SetSize128(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const(128));
    }
    public static void SetColorCranberry(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("cranberry"));
    }
    public static void SetColorRed(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("red"));
    }
    public static void SetColorPumpkin(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("pumpkin"));
    }
    public static void SetColorPeach(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("peach"));
    }
    public static void SetColorMarigold(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("marigold"));
    }
    public static void SetColorGold(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("gold"));
    }
    public static void SetColorBrass(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("brass"));
    }
    public static void SetColorBrown(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("brown"));
    }
    public static void SetColorForest(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("forest"));
    }
    public static void SetColorSeafoam(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("seafoam"));
    }
    public static void SetColorTeal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("teal"));
    }
    public static void SetColorSteel(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("steel"));
    }
    public static void SetColorBlue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("blue"));
    }
    public static void SetColorCornflower(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("cornflower"));
    }
    public static void SetColorNavy(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("navy"));
    }
    public static void SetColorLavender(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("lavender"));
    }
    public static void SetColorPurple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("purple"));
    }
    public static void SetColorGrape(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("grape"));
    }
    public static void SetColorLilac(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("lilac"));
    }
    public static void SetColorPink(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("pink"));
    }
    public static void SetColorMagenta(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("magenta"));
    }
    public static void SetColorPlum(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("plum"));
    }
    public static void SetColorBeige(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("beige"));
    }
    public static void SetColorMink(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("mink"));
    }
    public static void SetColorPlatinum(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("platinum"));
    }
    public static void SetColorAnchor(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("anchor"));
    }
    public static void SetColorNeutral(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("neutral"));
    }
    public static void SetColorBrand(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("brand"));
    }
    public static void SetColorColorful(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("colorful"));
    }
    public static void SetColorDarkRed(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark-red"));
    }
    public static void SetColorDarkGreen(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark-green"));
    }
    public static void SetColorLightTeal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light-teal"));
    }
    public static void SetColorRoyalBlue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("royal-blue"));
    }
    public static void SetColorIdCranberry(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("cranberry"));
    }
    public static void SetColorIdRed(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("red"));
    }
    public static void SetColorIdPumpkin(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("pumpkin"));
    }
    public static void SetColorIdPeach(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("peach"));
    }
    public static void SetColorIdMarigold(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("marigold"));
    }
    public static void SetColorIdGold(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("gold"));
    }
    public static void SetColorIdBrass(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("brass"));
    }
    public static void SetColorIdBrown(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("brown"));
    }
    public static void SetColorIdForest(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("forest"));
    }
    public static void SetColorIdSeafoam(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("seafoam"));
    }
    public static void SetColorIdTeal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("teal"));
    }
    public static void SetColorIdSteel(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("steel"));
    }
    public static void SetColorIdBlue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("blue"));
    }
    public static void SetColorIdCornflower(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("cornflower"));
    }
    public static void SetColorIdNavy(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("navy"));
    }
    public static void SetColorIdLavender(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("lavender"));
    }
    public static void SetColorIdPurple(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("purple"));
    }
    public static void SetColorIdGrape(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("grape"));
    }
    public static void SetColorIdLilac(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("lilac"));
    }
    public static void SetColorIdPink(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("pink"));
    }
    public static void SetColorIdMagenta(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("magenta"));
    }
    public static void SetColorIdPlum(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("plum"));
    }
    public static void SetColorIdBeige(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("beige"));
    }
    public static void SetColorIdMink(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("mink"));
    }
    public static void SetColorIdPlatinum(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("platinum"));
    }
    public static void SetColorIdAnchor(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("anchor"));
    }
    public static void SetColorIdDarkRed(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("dark-red"));
    }
    public static void SetColorIdDarkGreen(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("dark-green"));
    }
    public static void SetColorIdLightTeal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("light-teal"));
    }
    public static void SetColorIdRoyalBlue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b) 
    {
        b.SetProperty(b.Props, b.Const("colorId"), b.Const("royal-blue"));
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b, Metapsi.Syntax.Var<string> name) 
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }
    public static void SetName(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b, string name) 
    {
        b.SetName(b.Const(name));
    }
    public static void SetInitials(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b, Metapsi.Syntax.Var<string> initials) 
    {
        b.SetProperty(b.Props, b.Const("initials"), initials);
    }
    public static void SetInitials(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentAvatar> b, string initials) 
    {
        b.SetInitials(b.Const(initials));
    }
}