export const Self = () => self;
export const Throw = (message) => { throw new Error(message) }
export const New = (f, ...args) => new f(...args);
export const In = (value, obj) => value in obj;