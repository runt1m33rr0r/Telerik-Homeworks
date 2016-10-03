function sum(numbers) {
    'use strict';

    var zero = 0,
        number = 'number',
        undefinedParameterErrorMessage = 'Parameter must be passed!',
        nonConvertibleElementsErrorMessage = 'Elements must be convertible to a "number"';

    if (numbers.length === zero) {
        return null;
    } else if (numbers === undefined) {
        throw new Error(undefinedParameterErrorMessage);
    } else {
        var isAnyNaN = numbers.some(function (n) { return isNaN(n); });

        if (isAnyNaN) {
            throw new Error(nonConvertibleElementsErrorMessage);
        } else {
            return numbers
                .map(Number)
                .reduce(function (a, b) { return a + b; }, 0);
        }
    }
}

module.exports = sum;
