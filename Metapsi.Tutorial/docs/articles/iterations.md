# Iterations


Metapsi supports the C# <span class="inline-code">System.Collections.Generic.List</span> data type for client side iterations.

CodeSample:IterationsSimple:View

<span class="inline-code">Foreach</span> takes two arguments: the client side variable to iterate on and the action that builds the code to be executed for each iteration. 
The action receives the local iteration builder, the current item variable and an *optional* index.

Take into consideration that <span class="inline-code">Foreach</span> *only* works on <span class="inline-code">List</span>, not on 
<span class="inline-code">System.Collections.Generic.IEnumerable</span> as directly returned by LINQ expressions.

CodeSample:IterationsIEnumerable:View

You must call <span class="inline-code">.ToList()</span> on the LINQ expression.

<div class="block-note">To run LINQ in JavaScript we use <a href="https://github.com/mihaifm/linq" target="_blank">github.com/mihaifm/linq</a></div>

<span class="inline-code">Foreach</span> works as a statement. If you want to convert a list into another list, you can use <span class="inline-code">Map</span>.

### Map

CodeSample:IterationsMap:View

<div class="block-note"><span class="inline-code">Map</span> is the common name used in functional programming and in JavaScript also. 
It is equivalent to the C# <span class="inline-code">Select</span> LINQ function.</div>

This code sample maps each user to a string message, then maps that resulting string collection to actual text controls which can all be added to the parent container at once using
<span class="inline-code">AddChildren</span>.


