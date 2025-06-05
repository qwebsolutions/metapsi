using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Ionic;

//...

// TODO:
// IonActionSheetButtonsBuilder - combine string + Action sheet button
// enterAnimation, etc - AnimationsBuilder
// IonicSafeString

public delegate Animation AnimationBuilder(object baseEl, object opts);

public static class TestExtensions
{
    public static void SetEnterAnimation(this PropsBuilder<IonActionSheet> b, Var<AnimationBuilder> enterAnimation)
    {
        b.SetProperty(b.Props, b.Const("animationBuilder"), enterAnimation);
    }
}