# Binding

Consider the sequence:
* Take some data from the model
* Render a control based on that
* Update the data back into the model when the control is edited

This sequence is so common that it would be a great idea to somehow encapsulate it. Metapsi does just that.

CodeSample:BindingOnModel:View

Biding is not a special feature at all. It does not need it's own syntax or any new concepts. All it does is it configures the 'input' event (whichever that is, depending on control) and the 'value' property of the control at the same time.

<div class="rounded p-4 bg-blue-100">
Keep in mind that the binding already adds and action for an event. Make sure to not overwrite it as this might break the binding.
</div>

### Bind to references


You can also bind to some entity inside the data model by providing a function that identifies that entity.

CodeSample:BindingOnEntity:View

Notice <span class='inline-code'>getInEditUser</span> , which receives the model and returns the entity to bind to. We call the function to get the user for rendering and pass the same function to <span class='inline-code'>BindTo</span>.