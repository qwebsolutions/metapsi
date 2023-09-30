# More HTML

You won't get far just writing colored text. HTML elements are nested, so we need a way to create div & spans and add children to them.
CodeSample:NestedHtmlSimpleDiv:View

As you see, creating a div is not more difficult than creating text nodes. <span class='inline-code'>Add</span> attaches the child text to the container div.
What may come as a surprise, though, it that you don't call <span class="inline-code">div.Add</span> on the div itself, but on <span class="inline-code">b</span>, the code builder.

Of course you are, because there is no div & no text. Remember, you are just building a script that will run client side, sometime in the future. At this point you are only 
declaring the structure of the script, you are not actually running it. You don't actually work with HTML at this point, but with a <span class="inline-code">StringBuilder</span>.

CodeSample:NestedHtmlSpanMoreChildren:View

And you can nest HTML elements.

CodeSample:NestedHtmlLevels:View

<div class="block-note">The flex CSS classes used in this example also come from <a href="https://tailwindcss.com/docs/flex-direction" target="_blank">tailwind.css</a> </div>

### Nest the calls

Sometimes you need to add multiple nested tags. It is possible to create them all one by one. 
This requires naming them (we all know that is <a href="https://twitter.com/codinghorror/status/506010907021828096" target="_blank"><i>hard</i></a>) and you might accidentally return the wrong node.

CodeSample:NestedHtmlWrongReturn:View

Running this sample you will probably notice that something is off. <span class="inline-code">mainContainer</span> is just gone. Sure, it gets created, but it is not attached to anything and it cannot be, as it's local to our renderer, the outside world does not know about it.

In case you want to actually see the nested structure you can use a function signature that also builds children.

CodeSample:NestedHtmlNestedCalls:View

Sometimes it's more compact and clearer. Sometimes you go several levels deep and you might get completely lost. Use whatever style works better in each particular case
and if it suits you you can, of course, combine them.

CodeSample:NestedHtmlCombinedCalls:View