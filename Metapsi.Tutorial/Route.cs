using Metapsi.Ui;
using System;

namespace Metapsi.Tutorial.Routes;

public class Home : Metapsi.Route.IGet { }

public class Docs : Metapsi.Route.IGet<string> { }

public static class Tutorial
{
    public class Step : Metapsi.Route.IGet<int> { }
}