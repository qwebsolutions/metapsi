# Hello world

Let's just display some text.
CodeSample:HelloWorldSimpleText:View

That was simple. Just call the <span class="inline-code">Text()</span> function. But, *what is b?*

### To *b* or not to *b*

When you're dealing with client side executed code, *you always b*.
*b* is the conventional name of the magical class that transforms C# code into JavaScript code.
You might notice that we're not really writing JavaScript, but we're not writing arbitrary C# code either.
*b* is the contextual **code builder**. It is a class that *outputs JavaScript code* that will get run client side. 
In simplified terms, you can think of it as a  <span class="inline-code">StringBuilder</span>. When you call  <span class="inline-code">b.Text("...")</span> the builder 
appends the necessary client side function calls to the returned JavaScript script.

So, as a pseudo-example (**not** actual implementation) this

<pre><code class="language-csharp">b.Text("Text output");</code></pre>

could be implemented like

<pre><code class="language-csharp">
public static class TextNodeBuilder
{
    public static void Text(this StringBuilder b, string t)
    {
        b.AppendLine("document.createTextNode(" + t + ");");
    }
}
</code></pre>

So calling 

<pre><code class="language-csharp">StringBuilder b = new StringBuilder();
b.Text("Text output");
string outputScript = b.ToString();</code></pre>

would result in

<pre><code class="language-js">document.createTextNode("Text output");</code></pre>

<div class="block-note">In fancy terms you could call it <i><strong>metaprogramming</strong></i>. Hence, the project name <sl-icon name='emoji-smile'></sl-icon></div>
   

Of course, we're grossly glancing over the fact that the text node is not returned and is not added to the HTML document but this is just to keep things
simple for now. Don't worry, we'll get to that later. Let's move on to color output text.
CodeSample:HelloWorldColorText:View

The styling of text is so common that Metapsi also provides a function signature that applies CSS classes to the text output.

Of course, you can apply any sort of CSS.


<div class="block-note">
This tutorial automatically imports a subset of the 
<a href="https://tailwindcss.com/docs/customizing-colors" target="_blank">tailwind.css</a> classes. 
You can use, among others, <span class="inline-code">bg-</span>, <span class="inline-code">text-</span>, <span class="inline-code">border-</span> for colors gray, red, green, blue, orange & yellow with intensities from 100 to 900</div>

CodeSample:HelloWorldMoreColorText:View