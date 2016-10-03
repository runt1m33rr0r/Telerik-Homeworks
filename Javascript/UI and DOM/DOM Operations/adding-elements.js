function solve() {
    return function (element, contents) {
        if (typeof (element) === "string") {
            element = document.getElementById(element);

            if (!element || !(element instanceof HTMLElement)) {
                throw new Error();
            }
        }

        var frag = document.createDocumentFragment(),
            div = document.createElement("div"),
            divClone,
            i;

        for (i = 0; i < contents.length; i += 1) {
            divClone = div.cloneNode(true);

            if (typeof (contents[i]) !== "string" && typeof (contents[i]) !== "number") {
                throw new Error();
            }

            divClone.innerHTML = contents[i];

            frag.appendChild(divClone);
        }

        element.innerHTML = '';
        element.appendChild(frag);
    }
}