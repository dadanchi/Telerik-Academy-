/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function(selector) {
        var $selector = $(selector),
            $buttons = $selector.find('.button');

        $buttons.text("hide");

        if (typeof selector !== 'string') {
            throw Error("Id must be a string");
        }

        if (!($selector.length)) {
            throw Error('No such element found');
        }

        $buttons.on("click", function() {
            var $this = $(this),
                $nextContent = $this.nextAll('.content').first(),
                $nextButton = $nextContent.nextAll('.button').first();

            if ($nextContent.length) {
                if ($nextContent.css('display') === 'none') {
                    $this.text("hide");
                    $nextContent.css('display', '');
                } else {
                    $this.text("show");
                    $nextContent.css('display', 'none');
                }
            }
        });
    };
};

module.exports = solve;