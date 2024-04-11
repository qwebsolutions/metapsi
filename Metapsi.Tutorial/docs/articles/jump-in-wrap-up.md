# Wrap up

Now that we have a basic understanding of working with HTML, branching and looping, we can put it all together to create a slighly more useful control.

CodeSample:WrapUpTable

<div class="block-note">This sample uses the grid CSS classes from <a href="https://tailwindcss.com/docs/grid-template-rows" target="_blank">tailwind.css</a>.</div> 

There are several things to notice:

* The users are ordered descending by last login time. This works client side because the ISO 8601 date format allows correct sorting of string dates.
* The zebra stripes are created by checking if the current index is even. CSS is just a string so it can be concatenated based on any condition you need to use.
* <span class="inline-code">Optional</span> allows you to display content based on a specific condition
* <span class="inline-code">FormatDateTime</span> formats the date using the browser locale


#### Hope you had fun

This section covered the basics of client-side rendering. What you learned so far will get you a long way in styling controls and structuring layout. The problem is, everything is still read-only. In the next section we will move on to user interaction. We will explore event handling and setters (yes, surprisingly, that is quite an advanced topic). Are you ready?