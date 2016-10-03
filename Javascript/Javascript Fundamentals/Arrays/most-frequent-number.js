function solve(args) {
    var input = args[0].split('\n');
    var mostFrequent = +args[0];

    var times = 0;

    for (var number of input) {
        var currentTimes = 0;

        for (var i = input.indexOf(number); i < input.length; i += 1) {
            if (+input[i] === +number) {
                currentTimes += 1;
            }
        }

        if (currentTimes > times) {
            times = currentTimes;
            mostFrequent = +number;
        }
    }

    console.log(mostFrequent + " (" + times + " times)")
}