export const stopPropagation = (e) => e.stopPropagation();
export const GetElementById = (id) => document.getElementById(id);
export const CreateElement = (tag) => document.createElement(tag);
export const AppendChild = (parent, child) => parent.appendChild(child);
export const RequestAnimationFrame = requestAnimationFrame;
export const AddEventListener = (domElement, eventName, handler) => { domElement.addEventListener(eventName, handler); }
export const GetAttribute = (domElement, attributeName) => domElement.getAttribute(attributeName);
export const SetAttribute = (domElement, attributeName, attributeValue) => { domElement.setAttribute(attributeName, attributeValue); }
export const RemoveEventListener = removeEventListener;
export const DispatchEvent = (eventType, payload) => {
    dispatchEvent(new CustomEvent(eventType, { detail: payload }));
};
export const ScrollIntoView = (element) => {
    if (element)
        element.scrollIntoView({ behavior: "smooth" });
}
export const ScrollBy = scrollBy
export const ScrollTo = (x, y) => scrollTo(x, y);
export const SetUrl = (newUrl) => {
    location.href = newUrl;
}
export const GetUrl = () => location.pathname;
export const CreateObjectUrl = URL.createObjectURL;
export const Click = (domElement) => domElement.click()