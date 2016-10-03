function solve(args) {
    var n = +args[0],
    arr = args[1].split(' ');

    console.log(FirstLarger(arr));

    function FirstLarger(array) {
        var i;
        for(i = 0; i < array.length - 1; i += 1) {
            if(+array[i] > +array[i + 1]){
                return i;
            }
        }
        return -1;
    }
}