class ChoicesCustomElement extends HTMLElement {
    // the Choices control itself
    _choices;
    // The Choices props
    _props;

    createInput() { return null; }

    refreshChoices() {
        if (!this._choices) {
            var inputControl = this.createInput();
            this.appendChild(inputControl);
            this._choices = new Choices(inputControl, this._props);
        }
        else {
            this._choices.setChoices(
                this._props.choices,
                'value',
                'label',
                true
            );
        }
    }

    connectedCallback() {
        this.refreshChoices();
    }

    disconnectedCallback() {
        if (this._choices)
            this._choices.destroy();
    }
}

window.customElements.define(
    'metapsi-choices-text',
    class extends ChoicesCustomElement {


        set props(value) {
            if (JSON.stringify(this._props?.items) != JSON.stringify(value.items)) {
                this._props = {
                    ...value,
                    items: [ ...value.items ] // clone items to be sure the same reference is not compared
                };
                this.refreshChoices();
            }
        }

        createInput() { return document.createElement("input") }
    });

window.customElements.define(
    'metapsi-choices-select-one',
    class extends HTMLElement {

        // the Choices control itself
        _choices;
        // The Choices props
        _props;

        // the data source is extracted from _props.choices but kept separately
        // otherwise the choices would be duplicated
        // (once the.choices when control is created
        // & again when the data source is set with .setChoices)
        _dataSource;

        refreshChoices() {
            if (!this._choices) {
                var inputControl = this.createInput();
                this.appendChild(inputControl);
                this._choices = new Choices(inputControl, this._props);
            }
            else {
                this._choices.setChoices(this._dataSource, 'value', 'label', true);
                this._choices.setValue(this._props.items);
            }
        }

        connectedCallback() {
            this.refreshChoices();
        }

        disconnectedCallback() {
            if (this._choices)
                this._choices.destroy();
        }

        set props(value) {
            this._dataSource = [...value.choices];
            this._props = {
                ...value,
                choices: []
            }
            this.refreshChoices();
        }

        createInput() {
            var select = document.createElement("select")
            if (this._props.placeholder) {
                var placeholderOption = document.createElement("option");
                placeholderOption.setAttribute("value", "")
                var placeholderValue = this._props.placeholderValue;
                if (!placeholderValue) {
                    placeholderValue = "Not selected";
                }
                placeholderOption.appendChild(document.createTextNode(placeholderValue));
                if (!this._dataSource.some((x => x.selected))) {
                    placeholderOption.setAttribute("selected", true);
                }
                select.appendChild(placeholderOption)
            }

            return select;
        }
    });

window.customElements.define(
    'metapsi-choices-select-multiple',
    class extends ChoicesCustomElement {

        set props(value) {
            if (JSON.stringify(this._props?.choices) != JSON.stringify(value.choices)) {
                this._props = {
                    ...value,
                    choices: [ ...value.choices ] // clone choices to be sure the same reference is not compared
                }
                this.refreshChoices();
            }
        }

        createInput() {
            var select = document.createElement("select");
            select.setAttribute("multiple", "");
            return select
        }
    });