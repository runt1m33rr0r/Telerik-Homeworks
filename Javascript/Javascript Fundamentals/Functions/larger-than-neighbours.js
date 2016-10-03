function solve(args) {
    var n = +args[0],
    arr = args[1].split(' '),
    k,
    count = 0;

    for(k = 0; k < n - 1; k += 1) {
        if(LargerThanNeighbours(k, arr)){
            count += 1;
        }
    }

    console.log(count);
    function LargerThanNeighbours(i, array) {
        if(+i === 0 || +i >= array.lenght - 1){
            return false;
        }

        if(+array[i] > +array[i - 1] && +array[i] > +array[i + 1]){
            return true;
        } else{
            return false;
        }
    }
}