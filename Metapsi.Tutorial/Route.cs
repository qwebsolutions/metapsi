using Metapsi.Ui;
using System;

namespace Metapsi.Tutorial.Routes;

public class Paragraph : Metapsi.Route.IGet<string> { }

public class Home : Metapsi.Route.IGet { }

public class Docs : Metapsi.Route.IGet<string> { }

public class Tutorial : Metapsi.Route.IGet<string> { }
public class MTutorial : Metapsi.Route.IGet<string> { }

public class XXX : Metapsi.Route.IGet<string, string> { }