/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
    return function(selector, count) {
        var $selector = $(selector);
        var countValidator = +count;

        if (!isNaN(countValidator) && countValidator < 1) {
            throw Error('Count must be a positive number');
        }

        if (isNaN(countValidator) || count === undefined) {
            throw Error("Count is either not given or it is not a valid number");
        }

        if (typeof selector !== 'string') {
            throw Error('Wrong selector type');
        }

        if ($selector.length) {
            var $ul = $('<ul>')
                .addClass('items-list');
            for (var i = 0; i < count; i += 1) {
                $('<li>')
                    .text(`List item #${i}`)
                    .addClass('list-item')
                    .appendTo($ul);
            }
            $ul.appendTo($selector);
        }
    };
};

module.exports = solve;