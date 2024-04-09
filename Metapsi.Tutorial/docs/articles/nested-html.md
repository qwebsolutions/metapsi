# More HTML

Let's add some color to our example.

CodeSample:HelloWorldColorText:View

Metapsi provides builder functions for all HTML tags. All nodes follow the same pattern: a function that takes a properties builder as first parameter and then a collection of children. This allows nesting the controls and keeps the mental model very close to the HTML document itself. This type of signature allows us to keep nesting controls, creating the document tree.


CodeSample:NestedHtmlSpanMoreChildren:View


<div class="block-note">
This tutorial automatically imports a subset of the 
<a href="https://tailwindcss.com/docs/customizing-colors" target="_blank">tailwind.css</a> classes. 
You can use, among others, <span class="inline-code">bg-</span>, <span class="inline-code">text-</span>, <span class="inline-code">border-</span> for colors gray, red, green, blue, orange & yellow with intensities from 100 to 900</div>


### Separate calls

Sometimes when you need to add multiple nested tags, you might create them separately. This is invaluable as it allows you to combine pre-built HTML nodes. The downside is that this requires naming them (we all know that is <a href="https://twitter.com/codinghorror/status/506010907021828096" target="_blank"><i>hard</i></a>) and you might accidentally return the wrong node.

CodeSample:NestedHtmlWrongReturn:View

<div class="block-note">HtmlSpanText is a helper function to create an empty span with text inside. This makes it easier to build the layout. <br/><br/>The flex CSS classes used in this example also come from <a href="https://tailwindcss.com/docs/flex-direction" target="_blank">tailwind.css</a> </div>

Running this sample you will probably notice that something is off. <span class="inline-code">mainContainer</span> is just gone. Sure, it gets created, but it is not attached to anything and it cannot be, as it's local to our renderer, the outside world does not know about it.

### The ubiquitous b

To fix this, you might expect to be able to call something like

<pre><code class="language-csharp">
mainContainer.AddChild(container);
</code></pre>

The problem with that is that there is no <span class="inline-code">b</span> in the call. You need it, as there are actually no divs. Remember, you are just building a script that will run client side, sometime in the future. At this point you are only 
declaring the structure of the script, you are not actually running it. You don't actually work with HTML but with a <span class="inline-code">StringBuilder</span>. Always start with <span class="inline-code">b</span>.