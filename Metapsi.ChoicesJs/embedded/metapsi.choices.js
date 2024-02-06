class ChoicesCustomElement extends HTMLElement {
    _choices;
    _props;
    _options;

    createInput() { return null; }

    addShadowCss(container) {
        var css = document.createElement("link");
        css.setAttribute("rel", "stylesheet");
        css.setAttribute("href", "/choices.min.css");
        container.appendChild(css);

        var js = document.createElement("script");
        js.setAttribute("src", "/choices.min.js");
        container.appendChild(js);
    }

    refreshChoices() { // direct
        if (this._choices) {
            var passedInput = this._choices.passedElement.element;
            this._choices.destroy();
            this.removeChild(passedInput);
        }
        var inputControl = this.createInput();
        this.appendChild(inputControl);
        this._choices = new Choices(inputControl, this._props);
        console.log("refreshChoices", this._options);
    }

    connectedCallback() {
        this.refreshChoices();
    }

    disconnectedCallback() {
        if (this._choices)
            this._choices.destroy();
    }

    //static get observedAttributes() {
    //    return ["options"];
    //}

    set props(value) {
        this._props = value;
    }

    set options(value) {
        if (JSON.stringify(value) != JSON.stringify(this._options)) {
            this._options = value;
            this.refreshChoices();
        }
    }
}

window.customElements.define(
    'metapsi-choices-text',
    class extends ChoicesCustomElement {
        createInput() { return document.createElement("input") }
    });

window.customElements.define(
    'metapsi-choices-select-one',
    class extends ChoicesCustomElement {
        createInput() {
            var select = document.createElement("select")
            var placeholderOption = document.createElement("option");
            placeholderOption.setAttribute("value", "")
            //placeholderOption.setAttribute("placeholder", "");
            placeholderOption.appendChild(document.createTextNode("Not selected"));
            if (!this._options.some((x => x.selected))) {
                placeholderOption.setAttribute("selected", true);
            }
            select.appendChild(placeholderOption)

            this._options.forEach((input) => {
                var option = document.createElement("option");
                option.setAttribute("value", input.value)
                if (input.selected) {
                    option.setAttribute("selected", input.selected)
                }
                option.appendChild(document.createTextNode(input.label));
                select.appendChild(option)
            });
            return select;
        }
    });

window.customElements.define(
    'metapsi-choices-select-multiple',
    class extends ChoicesCustomElement {
        createInput() {
            var select = document.createElement("select");
            select.setAttribute("multiple", "");
            return select
        }
    });

export const GetValue = (c) => c.getValue(true);

//const highlightOnShowDropdown = (choices) => {
//    choices.passedElement.element.addEventListener('showDropdown', () => {
//        const selected = choices.getValue()
//        if (typeof selected === 'string' || Array.isArray(selected)) {
//            return
//        }

//        const selectedEl = choices.dropdown.element.querySelector < HTMLElement > (`[data-value="${selected.value}"]`)
//        if (selectedEl === null) {
//            return
//        }

//        //choices.highlightAll();
//        choices._highlightChoice(selectedEl)
//    })
//}