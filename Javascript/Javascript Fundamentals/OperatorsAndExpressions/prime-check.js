function solve(args) {
    var n = +args[0];

    if (n <= 1) {
        return false;
    }
    else  if (n <= 3) {
        return true;
    }
    else if (n % 2 === 0 || n % 3 === 0) {
        return false;
    }

    var i = 5;

    while (i * i <= n) {
        if (n % i === 0 || n % (i + 2) === 0) {
            return false;
        }

        i = i + 6;
    }

    return true;
}