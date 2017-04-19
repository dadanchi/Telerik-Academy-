function solve() {
    return function() {
        $.fn.listview = function(data) {
            var hbTemplate = $('#' + this.attr('data-template')).html();
            var template = handlebars.compile(hbTemplate);
            var len = data.length;
            var i;

            for (i = 0; i < len; i += 1) {
                this.append(template(data[i]));
            }
        };
    };
}

module.exports = solve;