export const IsSafari = () => {
    var isSafari = /^((?!chrome|android).)*safari/i.test(navigator.userAgent);
    return isSafari;
}

