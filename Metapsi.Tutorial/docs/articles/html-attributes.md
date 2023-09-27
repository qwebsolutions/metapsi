# HTML attributes

Nesting tags creates the tree structure of the HTML page but each element also has attributes. 
Let's create a link.

CodeSample:HtmlAttributesCreateLink:View

You set attributes with the <span class="inline-code">b.SetAttr()</span> call using one of the predefined attributes in the <span class="inline-code">Html</span> static class.

<div class="block-note">Not all attributes are predefined. There is a much lower level concept, DynamicProperty, on which attributes are based. We don't cover that know, it's enough to know that any attribute can be set, even in web components.</div>

It doesn't really look like a link, though. Maybe we can fix that?
Up until now setting the CSS class was hidden from us by the call that builds the tag and sets the class attribute automatically. We can now presume that, under the hood, the CSS class works like any other attribute.

CodeSample:HtmlAttributesSetClass:View

<div class="block-note"><i>class</i> is a reserved keyword in C# so we use the <i>@</i> prefix.</div>
