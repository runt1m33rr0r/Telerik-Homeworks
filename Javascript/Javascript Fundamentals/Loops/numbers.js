function solve(args) {
    var number = +args[0];

    for (var i = 1; i <= number; i += 1) {
        process.stdout.write(i + ' ');
    }
}