function solve(args) {
    var n = +args[0],
    arr = args[1].split(' '),
    number = +args[2];

    console.log(AppearanceCount(number, arr));

    function AppearanceCount(number, array) {
        var count = 0,
        i;

        for(i = 0; i < n; i += 1) {
            if(+array[i] === number){
                count += 1;
            }
        }

        return count;
    }
}