import { basicSetup, EditorView } from "codemirror/codemirror/dist/index.js"
import { StreamLanguage } from "codemirror/language/dist/index.js"
import { json } from "codemirror/lang-json/dist/index.js"
import { csharp } from "codemirror/legacy-modes/mode/clike.js"

const editors = new Map();// container id -> editor reference

export const AttachCodeMirror = (props) => {
    var container = document.getElementById(props.EditorId);

    // Container is not yet on screen, need to attach later
    if (!container) {
        console.log("Not added");
        return;
    }

    var extensions = [
        basicSetup,
        EditorView.updateListener.of((v) => {
            if (v.docChanged) {
                container.dispatchEvent(
                    new CustomEvent(
                        "editor-change",
                        {
                            detail: v.state.doc.toString()
                        }))
            }
        })]

    if (props.mode == "json") {
        extensions.push(json())
    }
    else {
        extensions.push(StreamLanguage.define(csharp))
    }

    // Only attach if not already attached before
    if (!editors.has(props.EditorId)) {
        var editorReference = new EditorView({
            doc: props.value,
            extensions: extensions,
            parent: container,
            root: document
        })

        editors.set(props.EditorId, editorReference);
    }
    else {
        // If already attached the text could still be different, so refresh it
        var editorReference = editors.get(props.EditorId);
        if (editorReference) {
            // only set new value only if text is different
            // otherwise caret always jumps at start
            // in a sort of feedback loop that makes you write backwards
            // which is quite interesting, now that I think about it

            if (editorReference.state.doc.toString() != props.value) {
                editorReference.dispatch({
                    changes: { from: 0, to: editorReference.state.doc.length, insert: props.value }
                })
            }
        }
    }
}