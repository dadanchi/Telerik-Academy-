function solve() {
    return function(selector) {
        var counter = 5;

        var $dropDownList = $('<div>')
            .addClass("dropdown-list")
            .appendTo('body');

        var $selector = $(selector)
            .css('display', 'none')
            .appendTo($dropDownList);

        var $options = $selector.find('option');

        var $currentDiv = $('<div>')
            .addClass("current")
            .attr('data-value', "")
            .text($($options[0]).text())
            .appendTo($dropDownList);

        var $containerDiv = $("<div>")
            .addClass('options-container')
            .css("position", "absolute")
            .css("display", "none")
            .appendTo($dropDownList);

        for (var i = 0; i < counter; i += 1) {
            $('<div>')
                .addClass("dropdown-item")
                .text($($options[i]).text())
                .attr("data-value", $($options[i]).val())
                .attr("data-index", i)
                .appendTo($containerDiv);
        }

        $currentDiv.on("click", function() {
            $containerDiv.css('display', 'inline-block');
        });

        $containerDiv.on("click", function(e) {
            $clickedDiv = $(e.target);
            $currentDiv.text($clickedDiv.text());
            $selector.val($clickedDiv.attr("data-value"));

            $containerDiv.css('display', 'none');

        });
    };
}

module.exports = solve;