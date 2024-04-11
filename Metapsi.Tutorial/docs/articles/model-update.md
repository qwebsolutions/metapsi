# Model updates


CodeSample:UpdateModelActionSameReference:View

In order to show that the model update works, we display the current value in a separate span text. In the action we use a linq expression to take the current value from the model incremented by 1, which we then set on the model. This is equivalent to <span class='inline-code'>model.Value++</span> (in both C# and JavaScript)

### Setters

In order to set a value we need to use the object on which we set it (model), the typed name of the property (Value) and the value itself. 

## BUT THAT'S SO VERBOSE!!!

We cannot just run <span class='inline-code'>model.Value++</span> because, remember, we're writing a code builder, not the code itself. We need to <span class='inline-code'>b</span>. 

It is verbose, but
* It keeps the code C# typed
* You make up for it by having the client-side and server-side logic tighly integrated
* You don't update the model explicitly as often as you think


Oh, and we displayed the value to see if the update works. It doesn't.

CodeSample:UpdateModelAction:View

As long as you return the exact same object there is no 'old version' and 'new version' to be compared. The reference is the same. To get a layout update you need to return a clone of the object, which is a new reference.