using Metapsi.Ui;
using System;

namespace Metapsi.Tutorial.Routes;

public class Docs : Metapsi.Route.IGet<string> { }

public static class Tutorial
{
    public class Step : Metapsi.Route.IGet<int> { }
}