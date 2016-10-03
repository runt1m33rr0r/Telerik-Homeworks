function solve(args) {
    var input = args;

    for (var i = 0; i < input.length; i += 1) {
        input[i] = input[i].replace(/(\<.*?\>)/g, '').trim();
    }

    console.log(input.join(''));
}