function solve(args) {
    var max = Math.floor(+args[0]);
    var min = Math.floor(+args[0]);
    var sum = 0;

    // find min
    for (var j = 0; j < args.length; j += 1) {
        if (min > +args[j]) {
            min = +args[j];
        }

        if (max < +args[j]) {
            max = +args[j];
        }

        sum += +args[j];
    }

    console.log('min=' + (+min).toFixed(2));
    console.log('max=' + (+max).toFixed(2));
    console.log('sum=' + (+sum).toFixed(2));
    console.log('avg=' + (+sum / args.length).toFixed(2));
}