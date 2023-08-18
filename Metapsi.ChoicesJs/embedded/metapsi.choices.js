import { TakeProps, propsStore } from "/Metapsi.PropsStore.js";

class ChoicesCustomElement extends HTMLElement {
    choices;
    props;

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

    //createChoices() { // Shadow DOM does not work with Choices.js

    //    var shadowDom = this.attachShadow({ mode: 'open' });
    //    this.addShadowCss(shadowDom);
    //    var inputControl = this.createInput();
    //    shadowDom.appendChild(inputControl);
    //    return new Choices(inputControl, this.props);
    //}

    createChoices() { // direct
        var inputControl = this.createInput();
        this.appendChild(inputControl);
        return new Choices(inputControl, this.props);
    }

    connectedCallback() {
        this.choices = this.createChoices();
    }

    disconnectedCallback() {
        if (this.choices)
            this.choices.destroy();
    }

    set id(value) {
        this.setAttribute("id", value);
        this.props = TakeProps(value);
        if (this.choices) {
            this.choices.setChoices(this.props.choices, 'value', 'label', true);

            var allValues = this.props.choices.map((x) => x.value);
            var activeValues = this.choices.getValue(true);
            if (Array.isArray(activeValues)) {
                activeValues.forEach((v) => {
                    if (!allValues.includes(v)) {
                        this.choices.removeActiveItemsByValue(v);
                    }
                });
            }
            else {
                if (!allValues.includes(activeValues)) {
                    this.choices.removeActiveItemsByValue(activeValues);
                }
            }
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
        createInput() { return document.createElement("select")  }
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