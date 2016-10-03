function solve(){
    return function (selector) {
        "use strict";

        if (typeof (selector) === "string") {
            selector = document.getElementById(selector);

            if ((selector instanceof HTMLElement) === false) {
                throw new Error();
            }
        }
        else {
            throw new Error();
        }

        let elements = selector.childNodes;

        for (let i = 0; i < elements.length; i += 1) {
            if (elements[i].className === 'button') {
                elements[i].innerHTML = 'hide';

                elements[i].addEventListener("click", clickButtonAction, false);
            }
        }

        function clickButtonAction(event) {
            event = event.target;

            let next = event.nextElementSibling;

            if (next.className === 'content') {
                let content = next;

                while (true) {
                    if (next.className === 'button') {

                        if (content.style.display === 'none') {
                            content.style.display = '';

                            event.innerHTML = 'hide';
                        }
                        else {
                            content.style.display = 'none';

                            event.innerHTML = 'show';
                        }
                        break;
                    }
                    next = next.nextElementSibling;
                }
            }
        }
    };
}