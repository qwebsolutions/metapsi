# Hello world

Let's just display some text.
CodeSample:HelloWorldSimpleText:View

That was simple. Just call the Text() function. But, *what is b?*

### To *b* or not to *b*

When you're dealing with client side executed code, you always *b*.
*b* is the conventional name of the magical class that transforms C# code into JavaScript code.
You might notice that we're not really writing JavaScript, but we're not writing arbitrary C# code either.
*b* is the contextual **code builder**. It is a class that *outputs JavaScript code* that will get run client side. 
In simplified terms, you can think of it as a  <span class="inline-code">StringBuilder</span>. When you call  <span class="inline-code">b.Text("...")</span> the builder 
appends the corresponding <span class="inline-code">text("...")</span> function call to the returned JavaScript script.

So, as a pseudo-example (**not** actual output code) this

<pre><code class="language-csharp">var t = b.Text("Text output");
b.Log("text node created");
</code></pre>
translates to
<pre><code class="language-js">var t = document.createTextNode("Text output");
console.log("text node created");
</code></pre>
by calling
<pre><code class="language-csharp">StringBuilder jsBuilder = new StringBuilder();
jsBuilder.AppendLine("var t = document.createTextNode(\"Text output\");");
jsBuilder.AppendLine("console.log(\"text node created\");");
</code></pre>

<div class="block-note">In fancy terms you could call it <i><strong>metaprogramming</strong></i>. Hence, the project name <sl-icon name='emoji-smile'></sl-icon></div>
   


But don't worry too much about it now. Let's move on to color output text.
CodeSample:HelloWorldColorText:View

The styling of text is so common that Metapsi also provides a function signature that applies CSS classes to the text output.

Of course, you can apply any sort of CSS.


<div class="block-note">
This tutorial automatically imports a subset of the 
<a href="https://tailwindcss.com/docs/customizing-colors" target="_blank">tailwind.css</a> classes. 
You can use, among others, <span class="inline-code">bg-</span>, <span class="inline-code">text-</span>, <span class="inline-code">border-</span> for colors gray, red, green, blue, orange & yellow with intensities from 100 to 900</div>

CodeSample:HelloWorldMoreColorText:View