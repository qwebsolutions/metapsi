# User interaction

The Hyperapp framework not only provides a virtual DOM but also its own architecture, making event handling and model updates predictable. The basic idea is

* When rendering, the data model is read-only. This is exactly what we did so far
* When handling events, the page is read-only, but the model is not
* An updated model will trigger a new render

To achieve this we use a special type of event handler called **action**. An action implicitly receives the latest data model as input and, in the simplest case, returns an updated model.

CodeSample:SimpleAction:View

Well, clicking the button definitely does nothing. How did we achieve this magnificent result?

### Actions are also properties

Yes, actions are configured the same way as any property of the control, like <span class='inline-code'>class</span> or <span class='inline-code'>id</span>, only in this case the property happens to be a function. Notice the mandatory *model* parameter. Why <span class='inline-code'>SyntaxBuilder b</span> though? 

### The page is read-only

A <span class='inline-code'>SyntaxBuilder</span> is the most basic JavaScript builder possible. It can use logical operations, but it does not have access to the layout of the page. With the <span class='inline-code'>SyntaxBuilder</span> you can only perform operations on the received model. Because we return the exact model that we received no page refresh is triggered.