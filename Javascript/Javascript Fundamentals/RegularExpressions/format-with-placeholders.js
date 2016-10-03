function solve(args) {
    var input = JSON.parse(args[0]);
    var text = args[1].toString();

    String.prototype.format = function(inp) {
        var s = this;

        for (var key in inp) {
            s = s.replace(new RegExp('\\#{' + key + '\\}', 'gm'), inp[key]);
        }

        return s;
    };

    console.log(text.format(input));
}