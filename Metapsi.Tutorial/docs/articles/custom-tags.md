# Other HTML tags


The <span class="inline-code">HtmlDiv</span> and <span class="inline-code">HtmlSpan</span> functions are just helpers for commonly used tags. 
If Metapsi does not provide a builder for a particular tag, you can use the general <span class="inline-code">H</span> function to create it. This really comes in handy when using web components, which are actually completely custom tags that Metapsi could not know beforehand. For example, 
to add a <a href="https://web-components.carbondesignsystem.com/?path=/story/introduction-welcome--page">Carbon drop down</a> 

CodeSample:CustomTagsCarbonComponent:View



<div class="block-note">This tutorial uses <a href="https://shoelace.style" target="_blank">Shoelace web components</a>, for which Metapsi provides support out of the box.</div>

