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


<div class="block-note">In fancy terms you could call it <i><strong>metaprogramming</strong></i>. Hence, the project name <sl-icon name='emoji-smile'></sl-icon></div>
   

