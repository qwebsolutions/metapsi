# Data model

Up until now every example just used constants but we need to work with actual data. 
Let's declare a data model.

CodeSample:DataModelDeclare

Checkout the model definition. We just declared a simple string property <span class="inline-code">Name</span>.
In real life data could come from a database or maybe from an API call. In this tutorial we just use the JSON format. Load the sample in the sandbox, edit the name in the 'JSON model data' field & run it to see the results.

Yeah, it doesn't do much, it just outputs the JSON model itself.

We need to access the actual properties.

CodeSample:DataModelGet:View

There are several things to notice regarding this otherwise very short code.

### Model

What is <span class="inline-code">model</span> and where does it come from?

It's not a magic variable and it does not have a predefined name. It's just hidden in our code samples to keep them shorter.

The actual function signature of the rendering function is

<pre class="language-csharp"><code>public Var&lt;HyperNode&gt; Render(BlockBuilder b, Var&lt;Model&gt; model) 
{ 
// the code in the sample goes here
}</code></pre>

... which could be a bit confusing at this point. By now you might have a vague understanding of what <span class="inline-code">BlockBuilder</span> is, but <span class="inline-code">Var&lt;Model&gt;</span>?!

Just like the rendering function signature is hidden in the samples, the model definition is also hidden. In the previous code sample it actually is

<pre class="language-csharp"><code>
public class Model
{
    public string Name { get; set; }
}
</code></pre>

So <span class="inline-code">Model</span> is the implicit class name of all models from all the code samples in this tutorial.

<span class="inline-code">Var&lt;...&gt;</span> is a generic type wrapper that tracks the mapping of C# types to the generated JavaScript code.

<span class="inline-code">HyperNode</span> is <span class="text-sm text-gray-600">the node in </span><span class="text-sm text-gray-500">the virtual</span> <span class="text-sm text-gray-400"> dom</span> <span class="text-xs text-gray-300">of Hyperapp...</span> **Nevermind!** We'll get to that later!

### Getter

As you remember, you're building a script, not executing it, so 
<pre><code class="language-csharp">var name = b.Get(model, x => x.Name)</code></pre>
is actually appending a getter call to the output script, something somewhat similar to 
<pre><code class="language-js">var name = model.Name</code></pre>

#### Why *x=>* ?

This syntax looks rather verbose. We could, theoretically, use something a bit shorter, like
<pre><code class="language-csharp">var name = b.Get(model, "Name")</code></pre>

While this is about as clear, there are several fundamental differences in the development experience. When using the arrow syntax

* The script builder is **fully C# typed**
* The compiler catches wrong property names
* The code editor offers code-completion
* The code editor updates correctly all properties when they are renamed

This syntax is based on the <span class="inline-code">System.Linq.Expressions</span> standard namespace.

### Linq expressions

Considering that the getter syntax is based on LINQ expressions, there is nothing stopping us from using their full power.

CodeSample:DataModelLinq:Json

<div class="block-note"><span class="inline-code">b.AsString(...)</span> converts <i>any</i> type to string.</div>

You can run C# LINQ expressions client side. Take your time. Let that sink in. 