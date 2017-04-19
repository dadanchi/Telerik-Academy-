/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve() {
    return function(selector) {
        // Validations
        if (typeof selector !== "string" && !(selector instanceof HTMLElement)) {
            throw Error();
        }
        if (selector === undefined) {
            throw Error();
        }
        if (selector === null) {
            throw Error();
        }
        if (typeof selector === 'string') {
            var elements = document.getElementById(selector);
            if (elements === null) {
                throw Error();
            }
        } else {
            elements = selector;
        }
        // Action

        var buttons = [].slice.apply(elements.getElementsByClassName("button"));
        for (var i = 0; i < buttons.length; i += 1) {
            buttons[i].innerHTML = "hide";
        }

        elements.addEventListener("click", function(e) {
            if (e.target.className == "button") {
                var nextElement = e.target.nextElementSibling;
                if (nextElement.tagName === 'BR') {
                    nextElement = nextElement.nextElementSibling;
                }
                if (nextElement.className == "content" && nextElement.nextElementSibling.className == "button") {
                    if (nextElement.style.display == "") {
                        nextElement.style.display = "none";
                        e.target.innerHTML = "show";
                    } else {
                        nextElement.style.display = "";
                        e.target.innerHTML = "hide";
                    }
                }
            }
        });
    };
};

module.exports = solve;