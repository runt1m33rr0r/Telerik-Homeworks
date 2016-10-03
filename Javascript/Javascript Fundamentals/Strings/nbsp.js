function solve(args) {
    var input = args[0];

    while (input.indexOf(' ') >= 0) {
        input = input.replace(' ', '&nbsp;');
    }

    console.log(input);
}