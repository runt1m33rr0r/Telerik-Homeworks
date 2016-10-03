function solve(args) {
    var needle = args[0].toLowerCase();
    var haystack = args[1].toLowerCase();

    var re = new RegExp(needle,"g");
    var count = (haystack.match(re)).length;

    console.log(count);
}
