function solve(args) {
    var input = args[0];

    if (input[0] == ')')
    {
        console.log("Incorrect");
        return;
    }

    var leftCount = 0;
    var rightCount = 0;

    for (var item of input)
    {
        if (item == ')')
        {
            rightCount += 1;
        }
        else if (item == '(')
        {
            leftCount += 1;
        }
    }

    if (leftCount == rightCount)
    {
        console.log("Correct");
    }
    else
    {
        console.log("Incorrect");
    }
}