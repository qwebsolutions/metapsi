# Other HTML tags


Functions like <span class="inline-code">HtmlDiv</span> or <span class="inline-code">SlBadge</span> are just helpers for known tags. 
If Metapsi does not provide a builder for a particular tag, you can use the general <span class="inline-code">H</span> function to create it. This is needed when using various web component libraries, which are actually completely custom tags that Metapsi could not know beforehand. For example, to add a <a href="https://web-components.carbondesignsystem.com/?path=/story/introduction-welcome--page">Carbon drop down</a> 

CodeSample:CustomTagsCarbonComponent:View


### Why H?

Under the hood Metapsi uses <a href="https://github.com/jorgebucaran/hyperapp">Hyperapp</a>, a very minimal web framework that handles the virtual DOM and event handling. <span class="inline-code">H</span> is the function that creates virtual nodes. The other function that you already know is <span class="inline-code">Text</span>, which just adds the text node itself to the virtual DOM.