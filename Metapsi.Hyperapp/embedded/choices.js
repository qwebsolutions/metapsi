const options = new Map();
const controls = new Map();

const requiresUpdate = new Map();

// called on each render to register drop down options. Options can change after control was initialized
export const addDropDown = (containerId, newOptions) => {
    var areDifferent = false;

    if (options.has(containerId)) {

        var prevOptions = options.get(containerId);
        if (prevOptions.Enabled != newOptions.Enabled) {
            areDifferent = true;
        }
        else
        if (prevOptions.Options.length != newOptions.Options.length) {
            areDifferent = true;
        }
        else {
            for (let i = 0; i < prevOptions.Options.length; i++) {
                var prevEntry = prevOptions.Options[i];
                var currentEntry = newOptions.Options[i];

                //console.log(prevEntry);
                //console.log(currentEntry);

                if (prevEntry.value != currentEntry.value) {
                    areDifferent = true;
                    break;
                }

                if (prevEntry.label != currentEntry.label) {
                    areDifferent = true;
                    break;
                }

                if (prevEntry.disabled != currentEntry.disabled) {
                    areDifferent = true;
                    break;
                }
            }
        }
    }
    else {
        areDifferent = true;
    }

    if (areDifferent) {
        options.set(containerId, newOptions);
        requiresUpdate.set(containerId, true);
    }
    else {
        requiresUpdate.set(containerId, false);
    }
}

export const removeDropDown = (id) => options.delete(id);

export const renderDropDown = (state) => {
    Array.from(options.keys()).forEach(id => {
        let container = document.querySelector('#' + id);

        if (!container) {
            let choicesControl = controls.get(id);
            if (choicesControl) {
                options.delete(id);
                controls.delete(id);
                choicesControl.destroy();
            }
        } else {
            if (container.childNodes.length == 0) {
                // page was refreshed, parent id was recreated but it's a different reference
                let choicesControl = controls.get(id);
                if (choicesControl) {
                    // destroy old control, but keep options
                    options.delete(id);
                    controls.delete(id);
                }
            }

            // container exists, but there are no options to display
            if (!options.has(id)) {
            }
            else {
                let choiceData = options.get(id);
                if (!controls.has(id)) {
                    var select = container.appendChild(document.createElement('select'));

                    select.addEventListener(
                        'choice',
                        function (event) {
                            var choiceEvent = new Event("onChoice");
                            choiceEvent.detail = { id: id, value: event.detail.choice.value };
                            dispatchEvent(choiceEvent)
                        },
                        false);

                    var choicesRef = new Choices(select,
                        {
                            itemSelectText: '',
                            classNames: {
                                containerInner: 'hyper-input',
                                listSingle: '',
                                disabledState: 'cursor-default',
                                itemDisabled: 'cursor-default',
                                itemSelectable: choiceData.Enabled ? 'choices__item--selectable' : 'cursor-default'
                            },
                            shouldSort: false,
                            allowHTML: false
                        });

                    if (!choiceData.Enabled) {
                        choicesRef.disable();
                        choiceData.Options.forEach(item => item.disabled = true);
                        choiceData.Options.forEach(item => item.disabled = true);
                    };

                    controls.set(id, choicesRef);
                }
                if (requiresUpdate.get(id)) {
                    controls.get(id).setChoices(choiceData.Options, 'value', 'label', true)
                }
            }
        }
    })

    return state;
}

export const onChoiceAction = (state, payload) => {
    var choiceData = options.get(payload.id);
    return choiceData.OnChanged(state, payload.value);
}