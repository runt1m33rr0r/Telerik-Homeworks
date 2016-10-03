function findPrimes(start, end) {
    'use strict';

    var two = 2,
        zero = 0,
        nonConvertibleErrorMessage = 'Both parameters must be convertible to "number"!',
        missingArgumentErrorMessage = 'Both parameters must be passed!';

    function isPrime(n) {
        if (n < 2) {
            return false;
        }

        let q = Math.floor(Math.sqrt(n));

        for (var i = two; i <= q; i += 1) {
            if (n % i === zero) {
                return false;
            }
        }

        return true;
    }

    if (arguments.length != two) {
        throw new Error(missingArgumentErrorMessage);
    } else if (isNaN(start) || isNaN(end)) {
        throw new Error(nonConvertibleErrorMessage);
    } else {
        var primes = [];

        start = Number(start);
        end = Number(end);

        for (var i = start; i <= end; i += 1) {
            if (isPrime(i)) {
                primes.push(i);
            }
        }

        return primes;
    }
}

module.exports = findPrimes;
