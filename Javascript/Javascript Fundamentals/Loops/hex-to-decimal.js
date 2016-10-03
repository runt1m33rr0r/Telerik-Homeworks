function solve(args) {
    var input = args.toString().split('').reverse().join('');
    var power = 0;
    var result = 0;

    for (var char of input) {
        if (char == 'A')
        {
            result += 10 * Math.pow(16, power);
        }
        else if (char == 'B')
        {
            result += 11 * Math.pow(16, power);
        }
        else if (char == 'C')
        {
            result += 12 * Math.pow(16, power);
        }
        else if (char == 'D')
        {
            result += 13 * Math.pow(16, power);
        }
        else if (char == 'E')
        {
            result += 14 * Math.pow(16, power);
        }
        else if (char == 'F')
        {
            result += 15 * Math.pow(16, power);
        }

        else if (isNaN(+char) == false && +char < 10)
        {
            result += char * Math.pow(16, power);
        }

        power += 1;
    }

    console.log(result);
}