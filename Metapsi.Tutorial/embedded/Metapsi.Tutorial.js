import * as monaco from 'https://cdn.jsdelivr.net/npm/monaco-editor@0.43.0/+esm';

export const SetIframeContent = (iframe, content) => {
    iframe.contentWindow.document.open();
    iframe.contentWindow.document.write(content);
    iframe.contentWindow.document.close();
}

export const HighlightWhenDefined = () => {
    window.customElements.whenDefined("sl-tab").then(_ => {
        window.Prism.highlightAll();
    });
}

export const ApplyCodeFlask = () => {
    //const editorElem = document.getElementById("id-live-sample-renderer");
    //console.log(editorElem)
    //const flask = new CodeFlask(editorElem, { language: 'js' });
}

var modelMonaco = null;
var jsonMonaco = null;
var viewMonaco = null;

export const MonacoAdded = () => {
    dispatchEvent(new CustomEvent("monaco-added"));
}

const resizeObserver = new ResizeObserver((entries) => {
    if (modelMonaco) {
        modelMonaco.layout();
    }
    console.log("Size changed");
});

const editors = new Map();// container id -> editor reference

export const AttachMonaco = (props) => {
    var container = document.getElementById(props.EditorId);

    // Container is not yet on screen, need to attach later
    if (!container) return;

    // Only attach if not already attached before
    if (!editors.has(props.EditorId)) {
        var editorReference = monaco.editor.create(container, props);
        editors.set(props.EditorId, editorReference);
        new ResizeObserver(() => { editorReference.layout() }).observe(container);
    }
    else {
        // If already attached the text could still be different, so refresh it
        var editorReference = editors.get(props.EditorId);
        if (editorReference) {
            editorReference.getModel().setValue(props.value);
        }
    }
}

export const AddModelMonaco = (tabPanel, intoElement, props) => {
    var tabGroup = document.getElementById("id-sandbox-tab-group");

    //resizeObserver.observe(tabPanel);

    if (tabGroup.updateComplete) {
        tabGroup.updateComplete.then(() => {
            if (tabPanel.updateComplete) {
                tabPanel.updateComplete.then(() => {
                    if (!modelMonaco) {
                        var monacoContainer = document.getElementById("id-monaco-CSharpModel");
                        
                        console.log("modelMonacoCreated");
                    }
                    modelMonaco.getModel().setValue(props.value);                    
                });
            }
        })
    }
}

export const AddJsonMonaco = (tabPanel, intoElement, props) => {

    var testDiv = document.createElement("div");
    testDiv.style.width = "100px";
    testDiv.style.height = "100px";
    testDiv.style.backgroundColor = "green";
    intoElement.appendChild(testDiv);

    if (tabPanel.updateComplete) {
        tabPanel.updateComplete.then(() => {
            //if (!jsonMonaco) {
                jsonMonaco = monaco.editor.create(testDiv, props);
                console.log("jsonMonacoCreated");
            //}
            jsonMonaco.getModel().setValue(props.value);
            jsonMonaco.layout();
        })
    }
}

export const AddViewMonaco = (tabPanel, intoElement, props) => {

    var testDiv = document.createElement("div");
    testDiv.style.width = "100px";
    testDiv.style.height = "100px";
    testDiv.style.backgroundColor = "blue";
    intoElement.appendChild(testDiv);
    //if (tabPanel.updateComplete) {
    //    tabPanel.updateComplete.then(() => {

    //        if (viewMonaco) {
    //            viewMonaco.dispose();
    //            viewMonaco = null;
    //        }

    //        if (!viewMonaco) {
    //            viewMonaco = monaco.editor.create(intoElement, props);
    //            console.log("viewMonacoCreated");
    //        }
    //    });
    //}
}