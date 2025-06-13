# Metapsi roadmap

As of June 2025

- __Server-side rendering__ : complete, stable
  
  HtmlBuilder renders any server-side tag, including custom components, which it automatically imports
  
- __Client side rendering__: complete, stable
  
  LayoutBuilder creates Hyperapp virtual nodes, including custom components, which it automatically imports
  
- __Ionic out of the box__ : complete, stable

  Full support for Ionic with LayoutBuilder and HtmlBuilder
  
- __Shoelace out of the box__: complete, stable

  Full support for Shoelace with LayoutBuilder and HtmlBuilder

- __Generic typescript -> C# generator__: usable, in progress

  Node module that outputs C#. Works, not fun to use yet

- __Web component definition -> C# generator__: usable, in progress

  Node module that outputs C#. Works, based on JSON documentation. Should probably switch to TypeScript type definition as input. This would allow the import of the full DOM API as well.
  
- __Hyperapp-defined custom elements__: works, in progress

  It's easy to convert any client-side Hyperapp panel to a custom element. This is rather simple, as the main difference is to return javascript from the HTTP request instead of adding it in the HTML document.

- __Feature-based app configuration__: in progress

  Attempt to treat the whole application as a single structure. Apps become "self-aware", consumer can query feature configurations and urls. Apps can be packed as Nugets and simply mapped with webapp.MapApp(importedApp)

- __NET Framework support__: in progress, proven to work

  While NET is going to work "out of the box", an application can as well be imported in NET Framework and wired-up by hand. This allows incremental adoption.
  Should work in Blazor as well.

- __Full DOM support__: usable, in progress

  At this point the DOM JS types and signatures are imported by hand. I either continue that or adjust the C# generator to import everything at once

- __Convert all JS types to interfaces__: planned

  Make all client-side types match their original definitions. This would also improve code suggestions, as the list of JS functions is growing large

- __More builders__ : thinking about it

  Since the SyntaxBuilder is the core of everything client-side, all extensions are defined on it. Find a way to be more specific based on context.  

- __Better documentation__: planned

  Overhaul of http://metapsi.dev to allow easier publishing of articles and more obvious navigation.

- __Web component libraries__: under consideration

  IBM Carbon? Fluent UI?

- __Generate static sites__ : under consideration

  Very much possible, maybe quite easy to implement.

- __Implement RealWorld__: under consideration
  
  https://github.com/gothinkster/realworld

  Two versions, server-side and client-side

### Features

 I call _features_ pieces of application that are separately developed and distributed. It relates to "feature-based app configuration" described earlier. 
 A feature packs the (cross-framework) HTTP listener with the related server-side and client-side rendering + required resources as well. This would allow the consumer to simply import a Nuget, then:
 ```C#
app.ConfigureFeature(
    b=>
    {
        // feature settings here
    }
```

- __Server-side pages__: in progress

  They can be function based or OOP based
  
- __Client-side pages__: in progress

  They can be function based or OOP based

- __Server actions__ : in progress, proven to work

  This would create "automatic proxies", basically run server-side event handlers written in-place.
  While it works, there are several issues to consider:
  - security - you wouldn't want to run just about any C# method by name. At this point, this is handled by a white-list on parent class when executing the event handler
  - performance - default implementation uses a lot of reflection
  - distributed app - globally storing the allowed handlers when rending the page is safer and faster, but the action request might come on a different server than the one who rendered the app

    There are possibly multiple ways to register the allowed handlers. I'm considering which need to be supported at framework level.
  
- __PWA app template__

  Create a base 'default' app from which to jumpstart PWA projects. The app will already include features for loading the homepage, easy navigation, easy diff-based upgrades.

- Typed navigation: planned, experimental

  If support for OOP definitions exist, maybe links can also be typed, so the correct parameters are set when building the URL.




