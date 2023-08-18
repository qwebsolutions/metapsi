export const propsStore = new Map();

export const PassProps = (id, props) => propsStore.set(id, props);
export const TakeProps = (id) => {
    if (propsStore.has(id)) {
        var props = propsStore.get(id);
        propsStore.delete(id);
        return props;
    }
    else return null;
}
