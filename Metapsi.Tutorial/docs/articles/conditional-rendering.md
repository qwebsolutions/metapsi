# Conditional rendering  




If we need to render based on some condition we can use the <span class="inline-code">b.If</span> statement.

CodeSample:IfStatement:View

<div class="block-note"><span class="inline-code">Concat</span> concatenates strings. <span class="inline-code">Const</span> informs the builder
that a C# string (or any type, for that matter) is to also be used client side. Functions like <span class="inline-code">b.Text("string value here")</span>
automatically call <span class="inline-code">Const</span> so you might not see it all that often.
</div>

How does it work? The most important thing to notice in this sample is the <span class="inline-code">b => </span>  line. 

The <span class="inline-code">b.If</span> call takes two parameters, the client side variable to check for the condition and the action to be performed 
if the condition passes. The <span class="inline-code">b</span> in <span class="inline-code">b => </span> is a **different** code builder than the one we started
with.



<div class="warning-note"><strong>NEVER</strong> use a different name for the code builder</div>

It might be tempting to "clarify" execution by using a different builder name.

<pre><code class="language-csharp">
b.If(
    anyLoggedUser,
    whenAnyLogged =>
    {
        b.Add(container, ...)
    });
</code></pre>

This does not work and it **bites hard**. A <span class="inline-code">BlockBuilder</span> works with, well, blocks of code. 
Using <span class="inline-code">b.If</span> with a different name results in

<pre><code class="language-js">
// some code here from the initial builder (b)
if(anyLoggedUser){
    // NO code is added here by the If builder 
    // because we are not using whenAnyLogged
}
// the rest of the code is added here, because we are using b
container.appendChild(...)
</code></pre>

You will not see a compile error, you will not see a runtime error and you might even not notice the wrong output for a long time. 
Always naming the code builder <span class="inline-code">b</span> is much safer.
    
### Else

Going back to our sample, we notice that there will be no HTML output when there are no logged users. We can fix that by using the *else* branch.

CodeSample:IfElseStatement:View

There is no *else* keyword in itself. The <span class="inline-code">If</span> builder method takes a mandatory first action when the condition passes
and an optional second action when it does not.

<div class="block-note">Even though I sometimes use the terms <i>builder</i> and <i>action</i> interchangeably, there's a subtle difference. 
<span class="inline-code">b=> {}</span> actually <strong>is</strong> a C# <span class="inline-code">System.Action</span> that receives a <span class="inline-code">BlockBuilder</span> as its parameter</div>
  

Considering that now we are always returning some output text why don't we just work with the string itself?

CodeSample:IfExpression:View

<span class="inline-code">If</span> also works as an expression. This is not supported as such in either C# or JavaScript, but hey, we're metaprogramming, so why not?
The code sample returns a text node that receives the result of the <span class="inline-code">If</span> call itself. 
To use it this way both branches must return the same data type.

<div class="block-note">This is similar to the ternary conditional operator (?:) </div>

There's one more thing to fix. In case there is exactly one logged user, the grammar is off: "There are 1 logged users".

### Switch expression

As we hopefully agreed by now that we're metaprogramming, let's go all the way and use a switch expression.

CodeSample:SwitchExpression:View

Switch *only* works as an expression. All branches must return the exact same data type. The first action is the default action, the rest of the actions must exactly match a server side constant each.

<div class="block-note">
The default branch is the first one because C# only allows a variable number of parameters (the <span class="inline-code">params</span> keyword) at the end. 
The default action is mandatory, the other actions are not.</div>