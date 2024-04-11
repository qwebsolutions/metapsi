# Model updates


CodeSample:UpdateModelActionSameReference:View

In order to show that the model update works, we display the model value in a separate span text. 

### Setters

To set a value we need to use the object on which we set it (model), the typed name of the property (Text) and the value itself (newValue). The property is not specified by a string, but by a Linq expression that allows us to keep track of the type. The resulting generated code is logically equivalent to  <span class='inline-code'>model.Text = newValue</span>.

Remember, we're writing a code builder, not the code itself. We need to <span class='inline-code'>b</span>. At this point <span class='inline-code'>model</span> is just a placeholder for a variable that will exist when the code is run client-side.

The setter syntax is a bit verbose, but:
* It keeps the code C# typed
* You make up for it by having the client-side and server-side logic tightly integrated
* You don't update the model explicitly as often as you think


Oh, and we displayed the value to see if the update works. **It doesn't.**

CodeSample:UpdateModelAction:View

As long as you return the exact same object there is no 'old version' and 'new version' to be compared. The reference is the same. To get a layout update you need to return a clone of the object, which is a new reference.

### The initial value

There's another problem, but quite a bit more subtle. If you edit the model in the 'JSON data, the control is not initialized with that value. That is because we did not set the value of the control when rendering it.

CodeSample:UpdateModelActionWithSetValue:View

Notice <span class='inline-code'>b.SetValue(b.Get(model, x => x.Text));</span>. This saves us from a lot of headaches, because we know the control is always in sync with the model, even when no action was yet performed. This is somewhat a guarantee that the model and the control are ...bound together.