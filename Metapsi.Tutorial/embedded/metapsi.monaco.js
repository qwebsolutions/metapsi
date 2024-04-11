import * as monaco from 'https://cdn.jsdelivr.net/npm/monaco-editor@0.43.0/+esm';

const editors = new Map();// container id -> editor reference

export const AttachMonaco = (props) => {
    var container = document.getElementById(props.EditorId);

    // Container is not yet on screen, need to attach later
    if (!container) {
        //console.log("Not added");
        return;
    }
    //console.log("adding");

    // Only attach if not already attached before
    if (!editors.has(props.EditorId)) {
        var editorReference = monaco.editor.create(container, props);
        editors.set(props.EditorId, editorReference);
        new ResizeObserver(() => { editorReference.layout() }).observe(container);
        editorReference.onDidChangeModelContent(
            e => {
                container.dispatchEvent(
                    new CustomEvent(
                        "editor-change",
                        {
                            detail: editorReference.getValue()
                        }))
            });
    }
    else {
        // If already attached the text could still be different, so refresh it
        var editorReference = editors.get(props.EditorId);
        if (editorReference) {
            // only set new value only if text is different
            // otherwise caret always jumps at start
            // in a sort of feedback loop that makes you write backwards
            // which is quite interesting, now that I think about it
            if (editorReference.getValue() != props.value) {
                editorReference.getModel().setValue(props.value);
            }
        }
    }
}