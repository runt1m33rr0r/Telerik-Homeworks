function solve(arr) {
    var arrCopy = arr;
    var elementToRemove = arr[0];

    for (var i = 1; i < arrCopy.length; i+=1) {
        if (arrCopy[i] !== elementToRemove) {
            console.log(arrCopy[i])
        }
    }
}