# HTML attributes

Nesting tags creates the tree structure of the HTML page but each element also has attributes. 
Let's create a link.

CodeSample:HtmlAttributesCreateLink:View

You set attributes with the <span class="inline-code">b.SetAttribute()</span> call. That's simple, but quite verbose.

## Typed builders

Some attributes are more common that others and they might only work in a specific context. For our particular example, an HTML <span class='inline-code'>&lt;a&gt;</span> tag requently needs setting the <span class='inline-code'>href</span> and <span class='inline-code'>target</span> attributes. For this reason some node builders offer specific helper functions for a quicker development experience.


CodeSample:HtmlAttributesCreateLinkWithHelpers:View

This especially comes in handy when exploring the supported web components.

CodeSample:HtmlAttributesWebComponents:View

<div class="block-note">This tutorial itself uses <a href="https://shoelace.style" target="_blank">Shoelace web components</a>, for which Metapsi provides support out of the box through the Metapsi.Shoelace nuget</div>