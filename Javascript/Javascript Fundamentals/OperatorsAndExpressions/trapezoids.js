function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var h = +args[2];

    return ((a + b) * h / 2).toFixed(7);
}